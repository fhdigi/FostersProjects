Imports Microsoft.Reporting.WinForms
Imports DevExpress.XtraReports.UI

Public Class ReportFrames

    Public Enum ReportTypeFlags
        PaymentSummary = 0
        RevenueReport = 1
    End Enum

    Public Property ReportType As ReportTypeFlags

    Private PaymentListingReport As PaymentListingReport
    Private RevenueListingReport As RevenueAllocation
    Private AppliedPaymentListingReport As New AppliedPaymentReport

    Private Sub PaymentSummaryFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButtonToday.Checked = True
    End Sub

    Private Sub GeneratePaymentSummaryReport()

        Dim startDate As Date = Nothing
        Dim endDate As Date = Nothing
        GetDates(startDate, endDate)

        Dim PaymentSummaryDateList As New List(Of CReportObjects.CPaymentSummary)
        Dim CreditSummaryDateList As New List(Of CReportObjects.CCreditsIssuedSummary)

        For Each paymentObj As CPayments In CPayments.GetPaymentListForDateRange(startDate, endDate)
            Dim tempPS As New CReportObjects.CPaymentSummary
            tempPS.TransDate = paymentObj.TransactionDate
            tempPS.TransAmount = paymentObj.Amount
            tempPS.Customer = paymentObj.RollOffObject.Customer.BillingAddress.ReverseFullName
            tempPS.CustomerBillingAddress = paymentObj.RollOffObject.Customer.BillingAddress.Address
            tempPS.AccountNumber = paymentObj.RollOffObject.Customer.CustomerNumber
            tempPS.CheckNumber = if (paymentObj .CreditCardTransaction, "Credit", paymentObj.CheckNumber)
            PaymentSummaryDateList.Add(tempPS)
        Next

        ' ----- Only show the deposits ... not the credits 
        For Each paymentObj As CDeposits In CDeposits.GetDepositListForDateRange(startDate, endDate).Where(Function(p) p.Amount > 0.0)
            Dim tempPS As New CReportObjects.CPaymentSummary
            tempPS.TransDate = paymentObj.TransactionDate
            tempPS.DepositAmount = paymentObj.Amount
            tempPS.Customer = paymentObj.RollOffObject.Customer.BillingAddress.ReverseFullName
            tempPS.CustomerBillingAddress = paymentObj.RollOffObject.Customer.BillingAddress.Address
            tempPS.AccountNumber = paymentObj.RollOffObject.Customer.CustomerNumber
            tempPS.CheckNumber = if (paymentObj .CreditCardTransaction, "Credit", paymentObj.CheckNumber)
            PaymentSummaryDateList.Add(tempPS)
        Next

        ' ----- Now get the credits
        For Each paymentObj As CDeposits In CDeposits.GetDepositListForDateRange(startDate, endDate).Where(Function(p) p.Amount < 0.0)
            Dim tempPS As New CReportObjects.CCreditsIssuedSummary
            tempPS.TransDate = paymentObj.TransactionDate
            tempPS.DepositAmount = paymentObj.Amount
            tempPS.Customer = paymentObj.RollOffObject.Customer.BillingAddress.ReverseFullName
            tempPS.CustomerBillingAddress = paymentObj.RollOffObject.Customer.BillingAddress.Address
            tempPS.AccountNumber = paymentObj.RollOffObject.Customer.CustomerNumber
            tempPS.CheckNumber = if (paymentObj .CreditCardTransaction, "Credit", paymentObj.CheckNumber)
            CreditSummaryDateList.Add(tempPS)
        Next

        PaymentListingReport = New PaymentListingReport
        PaymentListingReport.BindingSourcePaymentData.DataSource = PaymentSummaryDateList.OrderBy(Function(p) p.TransDate)

        Dim rptSub As New PaymentReportCreditsIssued
        rptSub.BindingSourceCredits.DataSource = CreditSummaryDateList.OrderBy(Function(p) p.TransDate)

        ' ----- Set the subreport 
        PaymentListingReport.XrSubreportCreditsIssued.ReportSource = rptSub

        ' ----- Show the report 
        PaymentListingReport.CreateDocument()
        DocumentViewerReport.DocumentSource = PaymentListingReport

    End Sub

    Private Sub GenerateRevenueReport()

        Dim startDate As Date = Nothing
        Dim endDate As Date = Nothing
        Dim appliedPaymentBaseTotal As Double = 0.0
        Dim appliedPaymentTaxTotal As Double = 0.0

        ' ----- Get the report dates 
        GetDates(startDate, endDate)

        Dim revenueReportList As New CReportObjects.CRevenueReport

        ' ----- Save the dates 
        revenueReportList.ReportStartDate = startDate
        revenueReportList.ReportEndDate = endDate

        ' ----- First we will need the applied payments from bills
        Dim appPayList As New List(Of CReportObjects.AppliedPaymentReport)

        ' ----- Let's set up a refund listing
        Dim refundListing As List(Of ITransaction) = CDeposits.GetDepositListForDateRange(startDate, endDate).Where(Function(d) d.Description = "REFUND").Select(Function(d) d).ToList

        ' ----- Loop through all of the bills that fall on this date
        For Each billObj As CBillingObject In CDataExtender.ReturnBillsListByDateRange(startDate, endDate)

            ' ---- See if we have a previous balance that is a credit 
            Dim prevBal As CRollOffHistoryBilling = billObj.ChargeListing.Where(Function(c) c.TransactionType = CRollOffHistoryBilling.TransType.PreviousBalance And c.Amount < 0).Select(Function(c) c).FirstOrDefault

            Dim prevCreditBalance As Double = 0.0
            Dim transAmount As Double = 0.0

            If Not prevBal Is Nothing Then

                prevCreditBalance = prevBal.Amount

                If billObj.Total < 0.0 Then
                    transAmount = billObj.Total - prevCreditBalance
                Else
                    transAmount = Math.Abs(prevCreditBalance)
                End If

                Dim appPayObj As New CReportObjects.AppliedPaymentReport
                appPayObj.CustomerNumber = prevBal.AccountNumber
                appPayObj.CustomerName = prevBal.BillingName
                appPayObj.CheckNumber = prevBal.CheckNumber
                appPayObj.TransactionDate = prevBal.TransactionDate.ToShortDateString
                appPayObj.TransactionAmount = transAmount
                appPayObj.TransactionType = "C"

                ' ----- Figure out the break out of the taxes 
                If prevBal.TaxRate = 0.0 Then
                    revenueReportList.CollectionFromTaxFreeCustomers += appPayObj.TransactionAmount
                Else
                    Dim basedAmount As Double = appPayObj.TransactionAmount / (1.0 + prevBal.TaxRate)
                    revenueReportList.CollectionFromTaxedCustomers += basedAmount
                    revenueReportList.TaxCollected += (appPayObj.TransactionAmount - basedAmount)
                End If

                appPayList.Add(appPayObj)

            End If

            ' ----- All we care about are the deposit entries
            Dim chrgeList As List(Of CRollOffHistoryBilling) =
                    billObj.ChargeListing.Where(Function(c) c.TransactionType = CRollOffHistoryBilling.TransType.Deposit) _
                    .Select(Function(c) c).ToList

            ' ----- Assuming we have a deposit (applied to billing), write it out 
            If Not chrgeList Is Nothing Then

                ' ----- If there are more than one deposit, then we need to figure that out
                if chrgeList.Count > 1 then 

                    dim itemCounter as Integer = 0
                    dim totalDeposit as Double = 0.0

                    For Each chObject As CRollOffHistoryBilling In chrgeList

                        ' ----- increase the counter 
                        itemCounter += 1

                        ' ----- add in the main deposit 
                        totalDeposit += chObject.Amount

                        ' ----- see if this is the last one
                        if itemCounter = chrgeList.Count then
                            
                            Dim appPayObj As New CReportObjects.AppliedPaymentReport
                            appPayObj.CustomerNumber = chObject.AccountNumber
                            appPayObj.CustomerName = chObject.BillingName & " (multiple deposits)"
                            appPayObj.CheckNumber = chObject.CheckNumber
                            appPayObj.TransactionDate = chObject.TransactionDate.ToShortDateString
                            If billObj.Total < 0.0 Then
                                appPayObj.TransactionAmount = Math.Abs(totalDeposit) - Math.Abs(billObj.Total)
                            Else
                                appPayObj.TransactionAmount = Math.Abs(totalDeposit)
                            End If

                            appPayObj.TransactionType = "D"

                            ' ----- Figure out the break out of the taxes 
                            If chObject.TaxRate = 0.0 Then
                                revenueReportList.CollectionFromTaxFreeCustomers += appPayObj.TransactionAmount
                            Else
                                Dim basedAmount As Double = appPayObj.TransactionAmount/(1.0 + chObject.TaxRate)
                                revenueReportList.CollectionFromTaxedCustomers += basedAmount
                                revenueReportList.TaxCollected += (appPayObj.TransactionAmount - basedAmount)
                            End If

                            appPayList.Add(appPayObj)

                        End If

                    Next

                else

                    For Each chObject As CRollOffHistoryBilling In chrgeList

                        Dim appPayObj As New CReportObjects.AppliedPaymentReport
                        appPayObj.CustomerNumber = chObject.AccountNumber
                        appPayObj.CustomerName = chObject.BillingName
                        appPayObj.CheckNumber = chObject.CheckNumber
                        appPayObj.TransactionDate = chObject.TransactionDate.ToShortDateString
                        If billObj.Total < 0.0 Then
                            appPayObj.TransactionAmount = Math.Abs(chObject.Amount) - Math.Abs(billObj.Total)
                        Else
                            appPayObj.TransactionAmount = Math.Abs(chObject.Amount)
                        End If
                        appPayObj.TransactionType = "D"

                        ' ----- Figure out the break out of the taxes 
                        If chObject.TaxRate = 0.0 Then
                            revenueReportList.CollectionFromTaxFreeCustomers += appPayObj.TransactionAmount
                        Else
                            Dim basedAmount As Double = appPayObj.TransactionAmount / (1.0 + chObject.TaxRate)
                            revenueReportList.CollectionFromTaxedCustomers += basedAmount
                            revenueReportList.TaxCollected += (appPayObj.TransactionAmount - basedAmount)
                        End If

                        appPayList.Add(appPayObj)

                    Next

                End If

            End If

        Next

        'For Each refundObj As CDeposits In refundListing

        '    Dim appPayObj As New CReportObjects.AppliedPaymentReport
        '    appPayObj.CustomerNumber = refundObj.RollOffObject.Customer.CustomerNumber
        '    appPayObj.CustomerName = refundObj.RollOffObject.Customer.BillingAddress.FullName
        '    appPayObj.CheckNumber = refundObj.CheckNumber
        '    appPayObj.TransactionDate = refundObj.TransactionDate.ToShortDateString
        '    appPayObj.TransactionAmount = Math.Abs(refundObj.Amount)
        '    appPayObj.TransactionType = "C"

        '    If refundObj.RollOffObject.Customer.TaxRate = 0.0 Then
        '        RevenueReportList.CollectionFromTaxFreeCustomers += refundObj.Amount
        '    Else
        '        Dim basedAmount As Double = refundObj.Amount / (1.0 + refundObj.RollOffObject.Customer.TaxRate)
        '        RevenueReportList.CollectionFromTaxedCustomers += basedAmount
        '        RevenueReportList.TaxCollected += (refundObj.Amount - basedAmount)
        '    End If

        '    appPayList.Add(appPayObj)

        'Next

        ' ----- This is mainly for the payments that are made in the report period
        For Each paymentObj As CPayments In CPayments.GetPaymentListForDateRange(startDate, endDate)
            If paymentObj.RollOffObject.Customer.TaxRate = 0.0 Then
                revenueReportList.CollectionFromTaxFreeCustomers += paymentObj.Amount
            Else
                Dim basedAmount As Double = paymentObj.Amount / (1.0 + paymentObj.RollOffObject.Customer.TaxRate)
                revenueReportList.CollectionFromTaxedCustomers += basedAmount
                revenueReportList.TaxCollected += (paymentObj.Amount - basedAmount)
            End If

            ' ----- break out credit card 
            if paymentObj.CreditCardTransaction Then 
                revenueReportList.TotalCreditCollected += paymentObj.Amount
            Else
                revenueReportList.TotalNonCreditCollected += paymentObj.Amount
            End If

        Next

        revenueReportList.CollectionFromTaxedCustomers += appliedPaymentBaseTotal

        revenueReportList.TotalCollectedLessTax = revenueReportList.CollectionFromTaxFreeCustomers + revenueReportList.CollectionFromTaxedCustomers
        revenueReportList.TotalCollected = revenueReportList.TotalCollectedLessTax + revenueReportList.TaxCollected

        RevenueListingReport = New RevenueAllocation
        RevenueListingReport.BindingSourceRevenue.DataSource = revenueReportList

        Dim rptSub As New AppliedPaymentReport
        rptSub.BindingSource1.DataSource = appPayList

        RevenueListingReport.XrSubreportAppliedPayments.ReportSource = rptSub
        RevenueListingReport.CreateDocument()
        DocumentViewerReport.DocumentSource = RevenueListingReport

    End Sub

    Private Sub GetDates(ByRef startDate As Date, ByRef endDate As Date)

        If RadioButtonToday.Checked Then
            startDate = Date.Now
            endDate = Date.Now
        ElseIf RadioButtonYesterday.Checked = True Then
            startDate = Date.Now - New TimeSpan(1, 0, 0, 0)
            endDate = Date.Now - New TimeSpan(1, 0, 0, 0)
        ElseIf RadioButtonCurrentWeek.Checked = True Then
            startDate = Date.Now - New TimeSpan(Date.Now.DayOfWeek - 1, 0, 0, 0)
            endDate = Date.Now + New TimeSpan(7 - Date.Now.DayOfWeek, 0, 0, 0)
        ElseIf RadioButtonCurrentMonth.Checked = True Then
            startDate = New Date(Date.Now.Year, Date.Now.Month, 1)
            endDate = New Date(Date.Now.Year, Date.Now.Month, Date.DaysInMonth(Date.Now.Year, Date.Now.Month))
        ElseIf RadioButtonLastMonth.Checked = True Then
            If Date.Now.Month = 1 Then
                startDate = New Date(Date.Now.Year - 1, 12, 1)
                endDate = New Date(Date.Now.Year - 1, 12, Date.DaysInMonth(Date.Now.Year - 1, 12))
            Else
                startDate = New Date(Date.Now.Year, Date.Now.Month - 1, 1)
                endDate = New Date(Date.Now.Year, Date.Now.Month - 1, Date.DaysInMonth(Date.Now.Year, Date.Now.Month - 1))
            End If
        ElseIf RadioButtonCurrentYear.Checked = True Then
            startDate = New Date(Date.Now.Year, 1, 1)
            endDate = New Date(Date.Now.Year, 12, 31)
        ElseIf RadioButtonSpecificDate.Checked = True Then
            startDate = DateTimePickerReportDate.Value
            endDate = DateTimePickerReportDate.Value
        ElseIf RadioButtonCustomRange.Checked = True Then
            startDate = DateTimePickerCustomStart.Value
            endDate = DateTimePickerCustomEnd.Value
        End If

    End Sub

    Private Sub ButtonRefreshReport_Click(sender As Object, e As EventArgs) Handles ButtonRefreshReport.Click

        Select Case ReportType
            Case ReportTypeFlags.PaymentSummary
                GeneratePaymentSummaryReport()
            Case ReportTypeFlags.RevenueReport
                GenerateRevenueReport()
        End Select

    End Sub

    Private Sub RadioButtonToday_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonToday.CheckedChanged, RadioButtonYesterday.CheckedChanged, RadioButtonCurrentWeek.CheckedChanged, RadioButtonCurrentMonth.CheckedChanged, RadioButtonCurrentYear.CheckedChanged, RadioButtonSpecificDate.CheckedChanged, RadioButtonCustomRange.CheckedChanged

        Dim rdoBtn As RadioButton = DirectCast(sender, RadioButton)

        ' ----- Enable / disable the date time picker 
        If Not rdoBtn Is Nothing Then
            DateTimePickerReportDate.Enabled = (rdoBtn.Name = "RadioButtonSpecificDate")
            DateTimePickerCustomStart.Enabled = (rdoBtn.Name = "RadioButtonCustomRange")
            DateTimePickerCustomEnd.Enabled = (rdoBtn.Name = "RadioButtonCustomRange")
        End If

        ' ----- Refresh the report 
        ButtonRefreshReport.PerformClick()

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonPrintReport_Click(sender As Object, e As EventArgs) Handles ButtonPrintReport.Click

        If ReportType = ReportTypeFlags.PaymentSummary Then
            Dim rptPrintTl As ReportPrintTool = New ReportPrintTool(PaymentListingReport)
            rptPrintTl.PrintDialog()
        Else
            Dim rptPrintTl As ReportPrintTool = New ReportPrintTool(RevenueListingReport)
            rptPrintTl.PrintDialog()
        End If

    End Sub

End Class
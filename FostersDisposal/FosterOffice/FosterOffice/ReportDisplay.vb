Public Class ReportDisplay 

    Public Enum ReportType
        CustomerListing = 1
        PaymentListing
        RevenueReport
    End Enum

    Public Property WhichReport As ReportType = ReportType.CustomerListing

    Private Sub ReportDisplay_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        RadioButtonToday.Checked = True

        TextBoxSeqStart.Enabled = (WhichReport = ReportType.CustomerListing)
        TextBoxSeqEnd.Enabled = (WhichReport = ReportType.CustomerListing)

    End Sub

    Private Function GetStartingDate() As Date

        If RadioButtonToday.Checked Then
            Return Date.Today
        ElseIf RadioButtonYesterday.Checked Then
            Return Date.Today - New TimeSpan(1, 0, 0, 0)
        ElseIf RadioButtonCurrentWeek.Checked Then
            Return Date.Today - New TimeSpan(Date.Today.DayOfWeek - 1, 0, 0, 0)
        ElseIf RadioButtonCurrentMonth.Checked Then
            Return New Date(Date.Today.Year, Date.Today.Month, 1)

        ElseIf RadioButtonLastMonth.Checked then

            Dim reportMonth as integer = Date.Today.Month-1
            Dim reportYear as Integer = Date.Today.Year

            If reportMonth = 0 Then
                reportMonth = 12
                reportYear -= 1
            End If

            Return New Date(reportYear, reportMonth, 1)

        ElseIf RadioButtonCurrentYear.Checked Then
            Return New Date(Date.Now.Year, 1, 1)
        ElseIf RadioButtonCustom.Checked Then
            Return DateStartReport.EditValue
        Else
            Return Date.Now
        End If

    End Function

    Private Function GetEndingDate() As Date

        If RadioButtonToday.Checked Then
            Return Date.Today
        ElseIf RadioButtonYesterday.Checked Then
            Return Date.Today - New TimeSpan(1, 0, 0, 0)
        ElseIf RadioButtonCurrentWeek.Checked Then
            Return Date.Today + New TimeSpan(5 - Date.Today.DayOfWeek, 0, 0, 0)
        ElseIf RadioButtonCurrentMonth.Checked Then
            Return New Date(Date.Today.Year, Date.Today.Month, Date.DaysInMonth(Date.Today.Year, Date.Today.Month))

        ElseIf RadioButtonLastMonth.Checked then

            Dim reportMonth as integer = Date.Today.Month-1
            Dim reportYear as Integer = Date.Today.Year

            If reportMonth = 0 Then
                reportMonth = 12
                reportYear -= 1
            End If

            Return New Date(reportYear, reportMonth, Date.DaysInMonth(reportYear, reportMonth))

        ElseIf RadioButtonCurrentYear.Checked Then
            Return New Date(Date.Now.Year, 12, 31)
        ElseIf RadioButtonCustom.Checked Then
            Return DateEndReport.EditValue
        Else
            Return Date.Now
        End If

    End Function

    Private Sub RunReports()

#If RentalProgram Then

        Select Case WhichReport

            Case ReportType.CustomerListing

                Dim rpt As New CustomerListing
                rpt.BindingSource1.DataSource = From p In PickupTransaction.RentalCustomer.ReturnMainRentalList(My.Settings.DatabaseLocation, True)
                                                Order By p.SequenceNumber Select p

                ' ----- display the report 
                PrintControlReportEngine.PrintingSystem = rpt.PrintingSystem
                rpt.CreateDocument()


            Case ReportType.PaymentListing

                Dim rpt As New PaymentListing

                If String.IsNullOrEmpty(TextBoxCheckNumber.Text) Then
                    rpt.BindingSource1.DataSource = PickupTransaction.RentalPayment.ReturnPaymentsForDate(My.Settings.DatabaseLocation, GetStartingDate, GetEndingDate)
                Else
                    Dim tempCheckNumber As Long = 0
                    Long.TryParse(TextBoxCheckNumber.Text, tempCheckNumber)
                    rpt.BindingSource1.DataSource = PickupTransaction.RentalPayment.ReturnPaymentsForDateByCheck(My.Settings.DatabaseLocation, tempCheckNumber)
                End If

                ' ----- display the report 
                PrintControlReportEngine.PrintingSystem = rpt.PrintingSystem
                rpt.CreateDocument()


            Case ReportType.RevenueReport

                Dim rpt As New RevenueReport
                rpt.BindingSource1.DataSource = PickupTransaction.RentalPayment.ReturnRevenueValue(My.Settings.DatabaseLocation, GetStartingDate, GetEndingDate)

                ' ----- display the report 
                PrintControlReportEngine.PrintingSystem = rpt.PrintingSystem
                rpt.CreateDocument()

        End Select
#Else

        Select Case WhichReport

            Case ReportType.CustomerListing

                ' ----- Determine if sequence numbers are used 
                Dim startingSeq As Integer = 0
                Dim endingSeq As Integer = 0
                Int32.TryParse(TextBoxSeqStart.Text, startingSeq)
                Int32.TryParse(TextBoxSeqEnd.Text, endingSeq)
                If endingSeq = 0 Then endingSeq = 80000

                ' ----- Set the report data 
                If startingSeq = 0 And endingSeq = 80000 Then

                    Dim rpt As New CustomerListingGrouped
                    rpt.BindingSource1.DataSource = PickupTransaction.Customer.ReturnCustomerListByDay(My.Settings.DatabaseLocation, GetStartingDate.DayOfWeek)

                    ' ----- display the report 
                    PrintControlReportEngine.PrintingSystem = rpt.PrintingSystem
                    rpt.CreateDocument()

                Else

                    Dim rpt As New CustomerListing
                    rpt.BindingSource1.DataSource = From p In PickupTransaction.Customer.ReturnCustomerListByDay(My.Settings.DatabaseLocation, 0, startingSeq, endingSeq)
                                                    Order By p.SequenceNumber Select p
                    ' ----- display the report 
                    PrintControlReportEngine.PrintingSystem = rpt.PrintingSystem
                    rpt.CreateDocument()

                End If

            Case ReportType.PaymentListing

                Dim rpt As New PaymentListing

                If String.IsNullOrEmpty(TextBoxCheckNumber.Text) Then
                    rpt.BindingSource1.DataSource = PickupTransaction.Payments.ReturnPaymentsForDate(My.Settings.DatabaseLocation, GetStartingDate, GetEndingDate)
                Else
                    Dim tempCheckNumber As Long = 0
                    Long.TryParse(TextBoxCheckNumber.Text, tempCheckNumber)
                    rpt.BindingSource1.DataSource = PickupTransaction.Payments.ReturnPaymentsForDateByCheck(My.Settings.DatabaseLocation, tempCheckNumber)
                End If

                ' ----- display the report 
                PrintControlReportEngine.PrintingSystem = rpt.PrintingSystem
                rpt.CreateDocument()

            Case ReportType.RevenueReport

                Dim rpt As New RevenueReport
                rpt.BindingSource1.DataSource = PickupTransaction.Payments.ReturnRevenueValue(My.Settings.DatabaseLocation, GetStartingDate, GetEndingDate)

                ' ----- display the report 
                PrintControlReportEngine.PrintingSystem = rpt.PrintingSystem
                rpt.CreateDocument()

        End Select

#End If



    End Sub

    Private Sub ButtonRefreshReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRefreshReport.Click
        RunReports()
    End Sub

    Private Sub RadioButtonToday_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonToday.CheckedChanged, RadioButtonCurrentWeek.CheckedChanged, RadioButtonCurrentMonth.CheckedChanged, RadioButtonCurrentYear.CheckedChanged, RadioButtonCustom.CheckedChanged, RadioButtonYesterday.CheckedChanged

        DateStartReport.Enabled = RadioButtonCustom.Checked
        DateEndReport.Enabled = RadioButtonCustom.Checked

        If RadioButtonCustom.Checked = False Then
            RunReports()
        End If

    End Sub

    Private Sub ButtonClearSeq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClearSeq.Click
        TextBoxSeqStart.Text = ""
        TextBoxSeqEnd.Text = ""
        ButtonRefreshReport_Click(Nothing, Nothing)
    End Sub

    Private Sub ButtonClearCheckNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClearCheckNumber.Click
        TextBoxCheckNumber.Text = ""
    End Sub

    Private Sub ButtonAll_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAll.Click
        TextBoxSeqStart.Text = "10000"
        TextBoxSeqEnd.Text = "59999"
        Me.Refresh()
        RunReports()
    End Sub

End Class
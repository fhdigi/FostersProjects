Imports DevExpress.XtraReports.UI

Public Class BillingReview

    Dim MonthDescriptions(12) As String
    Dim ExtraBagDescription(12) As String
    Dim GoInAfterDescription(12) As String

    Dim CurrentListOfCustomers As List(Of PickupTransaction.CBillingData)

    Public Property ManualBillingMode As Boolean = False
    Public Property ManualCustomerNumber As Integer = 0

    Public Property FillMode As Integer = 1

    ' ----- Set the bag rate 
    Const BagRate As Double = 2.0

    Private Function GetBillingMonth(ByVal BillingDate As Date, ByVal reportPeriod As Integer) As Integer

        ' ----- Pull the month from the date passed in 
        Dim tempBillingMonth As Integer = BillingDate.Month - reportPeriod

        If tempBillingMonth <= 0 Then
            tempBillingMonth += 12
        End If

        Return tempBillingMonth

    End Function

    Private Sub GetListOfCustomers()

        Cursor = Cursors.WaitCursor

        Dim LastBillingMonth As Integer = 0

        ' ----- This gets the day of the week 
        Dim pickupDay As Integer = DateTimePickerBillingDate.Value.DayOfWeek

        ' ----- What year are we in
        Dim BillingYear As Integer = DateTimePickerBillingDate.Value.Year

        ' ----- find the last month that would have been billed 
        LastBillingMonth = GetBillingMonth(DateTimePickerBillingDate.Value, 1)

        ' ----- Create a master list 
        Dim overallCustomerList As New List(Of PickupTransaction.CBillingData)

        ' ----- Highlight the delete bill button 
        ButtonResetData.Enabled = If(FillMode = 1, False, True)
        ButtonCreateBills.Enabled = If(FillMode = 1, True, False)


        Try
            ' ----- We need this list to get all of the transactions for a billing date
            Dim transList As List(Of Integer) = (From c In PickupTransaction.Transactions.ReturnAllTransactions(My.Settings.DatabaseLocation, DateTimePickerBillingDate.Value)
                                                 Select c.CustomerID Distinct).ToList

            If Not ManualBillingMode Then

                If FillMode = 1 Then

                    Dim customerListDel As List(Of PickupTransaction.CBillingData) = PickupTransaction.Customer.ReturnCustomersToBill(My.Settings.DatabaseLocation, GetBillingMonth(DateTimePickerBillingDate.Value, 1), pickupDay, 0)
                    Dim customerListMonth1 As List(Of PickupTransaction.CBillingData) = PickupTransaction.Customer.ReturnCustomersToBill(My.Settings.DatabaseLocation, GetBillingMonth(DateTimePickerBillingDate.Value, 1), pickupDay, 1)
                    Dim customerListMonth2 As List(Of PickupTransaction.CBillingData) = PickupTransaction.Customer.ReturnCustomersToBill(My.Settings.DatabaseLocation, GetBillingMonth(DateTimePickerBillingDate.Value, 2), pickupDay, 2)
                    Dim customerListMonth3 As List(Of PickupTransaction.CBillingData) = PickupTransaction.Customer.ReturnCustomersToBill(My.Settings.DatabaseLocation, GetBillingMonth(DateTimePickerBillingDate.Value, 3), pickupDay, 3)

                    For Each obj As PickupTransaction.CBillingData In customerListDel
                        Dim savedCount As Integer = (From ii In transList Where ii = obj.AccountNumber Select ii).Count
                        If savedCount = 0 Then overallCustomerList.Add(obj)
                    Next

                    For Each obj As PickupTransaction.CBillingData In customerListMonth1
                        Dim savedCount As Integer = (From ii In transList Where ii = obj.AccountNumber Select ii).Count
                        Dim objCount As Integer = (From ii In customerListDel Where ii.AccountNumber = obj.AccountNumber Select ii).Count
                        If savedCount = 0 And objCount = 0 Then overallCustomerList.Add(obj)
                    Next

                    For Each obj As PickupTransaction.CBillingData In customerListMonth2
                        Dim savedCount As Integer = (From ii In transList Where ii = obj.AccountNumber Select ii).Count
                        Dim objCount As Integer = (From ii In customerListDel Where ii.AccountNumber = obj.AccountNumber Select ii).Count
                        If savedCount = 0 And objCount = 0 Then overallCustomerList.Add(obj)
                    Next

                    For Each obj As PickupTransaction.CBillingData In customerListMonth3
                        Dim savedCount As Integer = (From ii In transList Where ii = obj.AccountNumber Select ii).Count
                        Dim objCount As Integer = (From ii In customerListDel Where ii.AccountNumber = obj.AccountNumber Select ii).Count
                        If savedCount = 0 And objCount = 0 Then overallCustomerList.Add(obj)
                    Next

                ElseIf FillMode = 2 Then

                    For Each accountNumber As Integer In transList
                        Try
                            Dim customerListMonth1 As PickupTransaction.CBillingData = PickupTransaction.Customer.ReturnSingleCustomerToBill(My.Settings.DatabaseLocation, accountNumber, True)
                            If Not customerListMonth1 Is Nothing Then
                                overallCustomerList.Add(customerListMonth1)
                            Else
                                Debug.Print("Do not have record of account number: " & accountNumber.ToString)
                            End If
                        Catch ex As Exception
                        End Try
                    Next

                ElseIf FillMode = 3 Then

                    Dim customerListMonthContinueBilling As List(Of PickupTransaction.CBillingData) = PickupTransaction.Customer.ReturnCustomersToBill(My.Settings.DatabaseLocation, GetBillingMonth(DateTimePickerBillingDate.Value, 1), pickupDay, -1)

                    For Each obj As PickupTransaction.CBillingData In customerListMonthContinueBilling
                        Dim savedCount As Integer = (From ii In transList Where ii = obj.AccountNumber Select ii).Count
                        If savedCount = 0 Then overallCustomerList.Add(obj)
                    Next

                End If

            Else

                Dim customerListMonth1 As PickupTransaction.CBillingData = PickupTransaction.Customer.ReturnSingleCustomerToBill(My.Settings.DatabaseLocation, ManualCustomerNumber)
                overallCustomerList.Add(customerListMonth1)

            End If

            ' ----- Set the customer list 
            CurrentListOfCustomers = New List(Of PickupTransaction.CBillingData)
            CurrentListOfCustomers = overallCustomerList

            Dim tempList As List(Of PickupTransaction.CBillingData) = (From c In overallCustomerList Order By c.SequenceNumber Select c).ToList

            ' ----- Display the information 
            ListBoxCustomers.DataSource = (From c In overallCustomerList Order By c.SequenceNumber Select c).ToList
            ListBoxCustomers.DisplayMember = "ListHeader"
            LabelTotalAmount.Text = String.Format("Total Amount: {0}", overallCustomerList.Count)

        Catch ex As Exception

        End Try

        ' ----- Set the cursor back 
        Cursor = Cursors.Default

    End Sub

    Private Sub ButtonRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRefresh.Click
        GetListOfCustomers()
    End Sub

    Private Sub BillingReview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' ----- Set the descriptions
        MonthDescriptions(1) = "January {0} Service"
        MonthDescriptions(2) = "February {0} Service"
        MonthDescriptions(3) = "March {0} Service"
        MonthDescriptions(4) = "April {0} Service"
        MonthDescriptions(5) = "May {0} Service"
        MonthDescriptions(6) = "June {0} Service"
        MonthDescriptions(7) = "July {0} Service"
        MonthDescriptions(8) = "August {0} Service"
        MonthDescriptions(9) = "September {0} Service"
        MonthDescriptions(10) = "October {0} Service"
        MonthDescriptions(11) = "November {0} Service"
        MonthDescriptions(12) = "December {0} Service"

        ExtraBagDescription(1) = "January"
        ExtraBagDescription(2) = "February"
        ExtraBagDescription(3) = "March"
        ExtraBagDescription(4) = "April"
        ExtraBagDescription(5) = "May"
        ExtraBagDescription(6) = "June"
        ExtraBagDescription(7) = "July"
        ExtraBagDescription(8) = "August"
        ExtraBagDescription(9) = "September"
        ExtraBagDescription(10) = "October"
        ExtraBagDescription(11) = "November"
        ExtraBagDescription(12) = "December"

        GoInAfterDescription(1) = "January - Go In After"
        GoInAfterDescription(2) = "February - Go In After"
        GoInAfterDescription(3) = "March - Go In After"
        GoInAfterDescription(4) = "April - Go In After"
        GoInAfterDescription(5) = "May - Go In After"
        GoInAfterDescription(6) = "June - Go In After"
        GoInAfterDescription(7) = "July - Go In After"
        GoInAfterDescription(8) = "August - Go In After"
        GoInAfterDescription(9) = "September - Go In After"
        GoInAfterDescription(10) = "October - Go In After"
        GoInAfterDescription(11) = "November - Go In After"
        GoInAfterDescription(12) = "December - Go In After"

        ' ----- Set the current number of rows 
        DataGridViewItems.Rows.Add(10)

        ' ----- Set the current date 
        DateTimePickerBillingDate.Value = Date.Today

    End Sub

    Private Function DaysInMonthYear(ByVal dayoftheWeek As Integer, ByVal month As Integer, ByVal year As Integer)

        Dim numberOfDaysInMonth As Integer = 0

        For iDayCounter As Integer = 1 To Date.DaysInMonth(year, month)

            Dim tempDate As New Date(year, month, iDayCounter)

            If tempDate.DayOfWeek = dayoftheWeek Then
                numberOfDaysInMonth += 1
            End If
        Next

        Return numberOfDaysInMonth

    End Function

    Private Sub WriteToRow(ByRef rowNumber As Integer, ByVal Description As String, ByVal Amount As Double, Optional showAmount As Boolean = True)
        rowNumber += 1
        If rowNumber < 8 Then
            DataGridViewItems.Rows(rowNumber).Cells("colDescription").Value = Description
            If showAmount Then
                DataGridViewItems.Rows(rowNumber).Cells("colAmount").Value = String.Format("{0:f2}", Amount)
            End If
        End If
    End Sub

    Private Sub ClearRows()
        For iStep As Integer = 0 To 7
            DataGridViewItems.Rows(iStep).Cells("colDescription").Value = ""
            DataGridViewItems.Rows(iStep).Cells("colAmount").Value = ""
        Next
    End Sub

    Private Function FillInGrid(ByVal customerNumber As Integer, ByVal billingDate As Date) As Boolean

        ' ----- Creates a list of all transactions for a particular date and customer 
        Dim transList As List(Of PickupTransaction.Transactions) = PickupTransaction.Transactions.LookupTransactions(My.Settings.DatabaseLocation, customerNumber, billingDate)

        If transList.Count = 0 AndAlso (FillMode = 1 Or FillMode = 3) Then

            ' ----- If there are no transactions and we are in "GENERATE" mode ... then return FALSE
            Return False

        Else

            Dim totalAmount As Double = 0.0

            For iRow As Integer = 0 To 7
                DataGridViewItems.Rows(iRow).Cells(0).Value = ""
                DataGridViewItems.Rows(iRow).Cells(1).Value = ""
            Next

            Dim rowCount As Integer = -1
            For Each tObj As PickupTransaction.Transactions In transList

                If tObj.Description = "Sales Tax" Then
                    ' ----- Write the tax amount 
                    DataGridViewItems.Rows(8).DefaultCellStyle.BackColor = Color.LightGray
                    DataGridViewItems.Rows(8).DefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
                    DataGridViewItems.Rows(8).Cells("colDescription").Value = tObj.Description
                    DataGridViewItems.Rows(8).Cells("colAmount").Value = String.Format("{0:f2}", tObj.Amount)
                Else
                    rowCount += 1
                    DataGridViewItems.Rows(rowCount).Cells(0).Value = tObj.Description
                    If tObj.Amount <> 0.0 Then
                        DataGridViewItems.Rows(rowCount).Cells(1).Value = String.Format("{0:f2}", tObj.Amount)
                    End If
                End If

                totalAmount += tObj.Amount

            Next

            ' ----- Write the total amount 
            DataGridViewItems.Rows(9).DefaultCellStyle.BackColor = Color.LightGray
            DataGridViewItems.Rows(9).DefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
            DataGridViewItems.Rows(9).Cells("colDescription").Value = "Bill Total"
            DataGridViewItems.Rows(9).Cells("colAmount").Value = String.Format("{0:f2}", totalAmount)

            Return True

        End If

    End Function

    Private Sub UpdateGridTotal(ByVal taxRate As Double)

        Dim totalAmount As Double = 0.0
        Dim totalTaxAmount As Double = 0.0

        For iStep As Integer = 0 To 7

            If DataGridViewItems.Rows(iStep).Cells(1).Value <> "" Then

                Dim amtToApply As Double = Convert.ToDouble(DataGridViewItems.Rows(iStep).Cells(1).Value)

                If DataGridViewItems.Rows(iStep).Cells(0).Value <> "Starting Balance" And amtToApply > 0.0 Then
                    totalTaxAmount += amtToApply
                End If

                totalAmount += amtToApply

            End If

        Next

        DataGridViewItems.Rows(8).DefaultCellStyle.BackColor = Color.LightGray
        DataGridViewItems.Rows(8).DefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
        DataGridViewItems.Rows(8).Cells("colDescription").Value = "Sales Tax"
        DataGridViewItems.Rows(8).Cells("colAmount").Value = String.Format("{0:f2}", totalTaxAmount * taxRate)

        ' ----- Write the total amount 
        DataGridViewItems.Rows(9).DefaultCellStyle.BackColor = Color.LightGray
        DataGridViewItems.Rows(9).DefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
        DataGridViewItems.Rows(9).Cells("colDescription").Value = "Bill Total"
        DataGridViewItems.Rows(9).Cells("colAmount").Value = String.Format("{0:f2}", totalAmount + (totalTaxAmount * taxRate))

    End Sub

    Private Sub ListBoxCustomers_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxCustomers.SelectedIndexChanged

        Dim daysOfPickup(3) As Integer
        Dim monthsOfPickup(3) As Integer
        Dim yearsOfPickup(3) As Integer

        Dim ServiceDescription(3) As String
        Dim ServiceDescriptionAmount(3) As Double
        Dim GOIDesc(3) As String

        ServiceDescription(1) = ""
        ServiceDescription(2) = ""
        ServiceDescription(3) = ""
        ServiceDescriptionAmount(1) = 0.0
        ServiceDescriptionAmount(2) = 0.0
        ServiceDescriptionAmount(3) = 0.0
        GOIDesc(1) = ""
        GOIDesc(2) = ""
        GOIDesc(3) = ""

        ' ---- Each new customer gets a refresh 
        Dim rowCount As Integer = -1
        ClearRows()

        ' ----- Amount to keep track of
        Dim totalAmount As Double = 0.0
        Dim taxableAmount As Double = 0.0

        ' ----- Set the year 
        Dim BillingYear As Integer = DateTimePickerBillingDate.Value.Year

        ' ----- Set the pickup day 
        Dim pickupDay As Integer = DateTimePickerBillingDate.Value.DayOfWeek

        ' ----- Get the billing object 
        Dim customerBillingObj As PickupTransaction.CBillingData = DirectCast(ListBoxCustomers.SelectedItem, PickupTransaction.CBillingData)

        ' ----- If the object is blank than get out of this routine 
        If customerBillingObj Is Nothing Then Exit Sub

        ' ----- Determine if the user already has records for this date 
        Dim hadRecords As Boolean = FillInGrid(customerBillingObj.AccountNumber, DateTimePickerBillingDate.Value)

        ' ----- find the last month that would have been billed 
        Dim LastBillingMonth As Integer = DateTimePickerBillingDate.Value.Month - customerBillingObj.MonthsToBill

        ' ----- If the last month was last year, then adjust accordingly 
        If LastBillingMonth <= 0 Then
            LastBillingMonth += 12
            BillingYear -= 1
        End If

        Dim pickupStartDate As Date = Nothing
        Dim pickupEndDate As Date = Nothing

        ' ----- We need to find how many pickup days the customer had in each billing month
        Dim indexforMonth As Integer = 0
        For iMonthCounter As Integer = LastBillingMonth + 1 To LastBillingMonth + customerBillingObj.MonthsToBill

            indexforMonth += 1

            If iMonthCounter > 12 Then
                daysOfPickup(indexforMonth) = DaysInMonthYear(pickupDay, iMonthCounter - 12, BillingYear + 1)
                monthsOfPickup(indexforMonth) = iMonthCounter - 12
                yearsOfPickup(indexforMonth) = BillingYear + 1
                ServiceDescription(indexforMonth) = String.Format(MonthDescriptions(iMonthCounter - 12), BillingYear + 1)
                GOIDesc(indexforMonth) = GoInAfterDescription(iMonthCounter - 12)
            Else
                daysOfPickup(indexforMonth) = DaysInMonthYear(pickupDay, iMonthCounter, BillingYear)
                monthsOfPickup(indexforMonth) = iMonthCounter
                yearsOfPickup(indexforMonth) = BillingYear
                ServiceDescription(indexforMonth) = String.Format(MonthDescriptions(iMonthCounter), BillingYear)
                GOIDesc(indexforMonth) = GoInAfterDescription(iMonthCounter)
            End If

            ' ----- If this is the first month, set the date 
            If iMonthCounter = LastBillingMonth + 1 Then
                If iMonthCounter > 12 Then
                    pickupStartDate = New Date(BillingYear + 1, iMonthCounter - 12, 1)
                Else
                    pickupStartDate = New Date(BillingYear, iMonthCounter, 1)
                End If
            End If

            ' ----- If this is the last month, set the date 
            If iMonthCounter = LastBillingMonth + customerBillingObj.MonthsToBill Then
                If iMonthCounter > 12 Then
                    pickupEndDate = New Date(BillingYear + 1, iMonthCounter - 12, Date.DaysInMonth(BillingYear + 1, iMonthCounter - 12))
                Else
                    pickupEndDate = New Date(BillingYear, iMonthCounter, Date.DaysInMonth(BillingYear, iMonthCounter))
                End If
            End If

        Next

        ' ----- Fill in the data 
        LabelCustomer.Text = customerBillingObj.CustomerName
        LabelAcctNumber.Text = String.Format("Account #: {0}", customerBillingObj.AccountNumber)
        LabelSeqNumber.Text = String.Format("Sequence #: {0}", customerBillingObj.SequenceNumber)

        LabelCurrentBalance.Text = String.Format("Current Balance: {0:c2}", customerBillingObj.StartingBalance)

        ' ----- If the starting balance is not 0.0, then it should go on the bill 
        If customerBillingObj.StartingBalance <> 0.0 Then

            ' ----- If this is a new record, then write the starting balance 
            If Not hadRecords Then

                ' ----- Write it to the grid 
                WriteToRow(rowCount, "Starting Balance", customerBillingObj.StartingBalance)

                ' ----- Add to the total amount 
                totalAmount += customerBillingObj.StartingBalance

            End If

        End If

        ' ----- Write out the billing type 
        LabelBillingType.Text = String.Format("Billing Type: {0}", customerBillingObj.BillingType)

        ' ----- Assuming we have a valid billing type 
        If Not customerBillingObj.BillingType Is Nothing Then

            ' ----- This is the list of everything collected 
            Dim itemListOfCollected As List(Of PickupTransaction.CollectionRecord) = PickupTransaction.CollectionRecord.GetCollectedItemsWithinRangeByDate(My.Settings.DatabaseLocation, pickupStartDate, pickupEndDate)

            ' ----- Get the monthly charge 
            customerBillingObj.MonthlyCharge = (From c In ProgramDataObject.BillingTypeObjectList Where c.Designation = customerBillingObj.BillingType Select c.Amount).SingleOrDefault
            customerBillingObj.TotalCharge = customerBillingObj.MonthlyCharge * customerBillingObj.MonthsToBill
            LabelMonthlyCharge.Text = String.Format("Monthly Charge: {0:c2}", customerBillingObj.MonthlyCharge)
            LabelTotalCharge.Text = String.Format("Total Charge: {0:c2}", customerBillingObj.TotalCharge)

            ' ----- Write out the service charges (if they are not already part of the record
            For iStep As Integer = 1 To customerBillingObj.MonthsToBill

                If Not hadRecords Then

                    Dim tempStep As Integer = iStep

                    ' ----- The program should not generate a monthly charge for customers who did not have bags out 
                    Dim bagsThisPeriodCheck As Integer = (From i In itemListOfCollected Where i.CustomerID = customerBillingObj.AccountNumber And i.ItemID = 1 And i.DateCollected.Month = monthsOfPickup(tempStep) And i.DateCollected.Year = yearsOfPickup(tempStep) Select i.Quantity).Sum
                    If bagsThisPeriodCheck > 0 Then

                        ' ----- We will need an adjustment for the price increase
                        Dim rateAdjustment As Double = 0.0

                        ' --- used for the 2012 price increase
                        'If monthsOfPickup(tempStep) < 11 AndAlso yearsOfPickup(tempStep) = 2012 AndAlso (customerBillingObj.BillingType.ToUpper = "B" Or customerBillingObj.BillingType.ToUpper = "C") Then
                        '    rateAdjustment = 1.0
                        'End If

                        ' --- used for the 2018 price increase
                        If monthsOfPickup(tempStep) < 9 AndAlso yearsOfPickup(tempStep) = 2018 Then
                            rateAdjustment = 1.0
                        End If

                        ' ----- This is the monthly charge 
                        ServiceDescriptionAmount(iStep) = customerBillingObj.MonthlyCharge - rateAdjustment
                        WriteToRow(rowCount, ServiceDescription(iStep), ServiceDescriptionAmount(iStep))
                        taxableAmount += customerBillingObj.MonthlyCharge - rateAdjustment
                        totalAmount += customerBillingObj.MonthlyCharge - rateAdjustment

                        ' ----- We can do the Go In After here 
                        If customerBillingObj.GoInAfter Then
                            Dim goInAmount As Double = If(customerBillingObj.GoInAfterAmount = 0.0, 2.0, customerBillingObj.GoInAfterAmount)
                            WriteToRow(rowCount, GOIDesc(iStep), goInAmount)
                            taxableAmount += goInAmount
                            totalAmount += goInAmount
                        End If

                    End If

                End If

            Next

            ' ----- Only perform this check if they are a A, B or C customer 
            If customerBillingObj.BillingType.ToUpper = "A" Or customerBillingObj.BillingType.ToUpper = "B" Or customerBillingObj.BillingType.ToUpper = "C" Then

                ' ----- Calculate the total number of bags that are allowed to be picked up this period
                customerBillingObj.BagsAllowedThisPeriod = 0
                customerBillingObj.BagsAllowedByMonth = New List(Of Integer)
                customerBillingObj.BagsPickedUpByMonth = New List(Of Integer)

                Dim bagMsg As String = ""
                Dim bagsPickedMsg As String = ""
                Dim extraBagMsg As String = ""
                Dim extraBagCostMsg As String = ""

                For iBagCounter As Integer = 1 To customerBillingObj.MonthsToBill

                    ' ----- Need to define a local variable because of compiler warnings
                    Dim tempBagCounter As Integer = iBagCounter

                    ' ----- This pulls out how many bags they are allowed on a per month basis
                    Dim bagsAllowed As Integer = (From c In ProgramDataObject.BillingTypeObjectList Where c.Designation = customerBillingObj.BillingType Select c.WeeklyBagAllowance).SingleOrDefault

                    ' ----- This calculates and sums the total amount of bags allowed 
                    customerBillingObj.BagsAllowedThisPeriod += bagsAllowed * daysOfPickup(iBagCounter)

                    ' ----- This keeps track of how many bags they are allowed for each month in the period 
                    customerBillingObj.BagsAllowedByMonth.Add(bagsAllowed * daysOfPickup(iBagCounter))

                    ' ----- Generate the string to display to the user 
                    bagMsg &= (bagsAllowed * daysOfPickup(iBagCounter)).ToString & If(iBagCounter = customerBillingObj.MonthsToBill, "", ", ")

                    ' ----- This gives us a list of bags picked up for a certain period 
                    Dim bagsThisPeriod As Integer = (From i In itemListOfCollected Where i.CustomerID = customerBillingObj.AccountNumber And i.ItemID = 1 And i.DateCollected.Month = monthsOfPickup(tempBagCounter) And i.DateCollected.Year = yearsOfPickup(tempBagCounter) Select i.Quantity).Sum
                    customerBillingObj.BagsPickedUpByMonth.Add(bagsThisPeriod)

                    ' ----- Generate the string to display to the user 
                    bagsPickedMsg &= (bagsThisPeriod).ToString & If(iBagCounter = customerBillingObj.MonthsToBill, "", ", ")

                    Dim extraBagsThisMonth As Integer = bagsThisPeriod - (bagsAllowed * daysOfPickup(iBagCounter))
                    extraBagMsg &= If(extraBagsThisMonth < 0, 0, extraBagsThisMonth).ToString & If(iBagCounter = customerBillingObj.MonthsToBill, "", ", ")

                    If extraBagsThisMonth > 0 Then

                        Dim fBagRateAdjust As Double = BagRate

                        ' --- used for the 2012 price increase
                        'If monthsOfPickup(tempBagCounter) < 11 AndAlso yearsOfPickup(tempBagCounter) = 2012 Then
                        '    fBagRateAdjust -= 0.5
                        'End If

                        ' --- used for the 2018 price increase
                        If monthsOfPickup(tempBagCounter) < 9 AndAlso yearsOfPickup(tempBagCounter) = 2018 Then
                            fBagRateAdjust -= 0.5
                        End If

                        ' ----- Format the message 
                        extraBagCostMsg &= (extraBagsThisMonth * fBagRateAdjust).ToString("c2") & If(iBagCounter = customerBillingObj.MonthsToBill, "", ", ")

                        ' ----- Write the charge out to the screen
                        If Not hadRecords Then
                            Dim extraBagMessage As String = String.Format("{0} - {1} extra bag{2}", ExtraBagDescription(monthsOfPickup(iBagCounter)), extraBagsThisMonth, If(extraBagsThisMonth > 1, "s", ""))
                            taxableAmount += extraBagsThisMonth * fBagRateAdjust
                            totalAmount += extraBagsThisMonth * fBagRateAdjust
                            WriteToRow(rowCount, extraBagMessage, extraBagsThisMonth * fBagRateAdjust)
                        End If

                    End If

                Next

                ' ----- Write out the number of bags for each month in the period 
                LabelBagsAllowed.Text = String.Format("Bags Allowed: {0}", bagMsg)
                LabelBagsPickedUp.Text = String.Format("Bags Picked Up: {0}", bagsPickedMsg)
                LabelExtraBagQty.Text = String.Format("Extra Bags: {0}", extraBagMsg)

                If String.IsNullOrEmpty(extraBagCostMsg) Then
                    LabelExtraBagQty.ForeColor = Color.Black
                    LabelExtraBagCost.Text = ""
                    LabelExtraBagCost.ForeColor = Color.Black
                Else
                    LabelExtraBagQty.ForeColor = Color.Red
                    LabelExtraBagCost.Text = String.Format("Extra Bag Cost {0}", extraBagCostMsg)
                    LabelExtraBagCost.ForeColor = Color.Red
                End If

            Else

                LabelBagsAllowed.Text = String.Format("Bags Allowed: {0}", 0)
                LabelBagsPickedUp.Text = String.Format("Bags Picked Up: {0}", 0)
                LabelExtraBagQty.Text = String.Format("Extra Bags: {0}", 0)
                LabelExtraBagCost.Text = String.Format("Extra Bag Cost {0}", 0)
                LabelExtraBagQty.ForeColor = Color.Black
                LabelExtraBagCost.ForeColor = Color.Black

            End If

            ' ----- Get the additional items 
            customerBillingObj.AdditionalItems = ""
            customerBillingObj.AdditionalItemCost = 0.0

            Dim tempList As List(Of PickupTransaction.CAdditionalItems) = (From i In itemListOfCollected
                                                                           Where i.CustomerID = customerBillingObj.AccountNumber And i.ItemID <> 1
                                                                           Select New PickupTransaction.CAdditionalItems With
                                                                                 {
                                                                                     .AdditionalItems = i.ItemDescription,
                                                                                     .AdditionalItemCost = i.ItemPrice
                                                                                 }).ToList

            ' ----- Set them for the customer object 
            For Each strTemp As PickupTransaction.CAdditionalItems In tempList

                customerBillingObj.AdditionalItems &= strTemp.AdditionalItems & " "
                customerBillingObj.AdditionalItemCost += strTemp.AdditionalItemCost

                ' ----- Only write these out if these are new records 
                If Not hadRecords Then
                    WriteToRow(rowCount, strTemp.AdditionalItems, strTemp.AdditionalItemCost)
                    taxableAmount += strTemp.AdditionalItemCost
                    totalAmount += strTemp.AdditionalItemCost
                End If

            Next

            ' ----- Only write these out if these are new records 
            'If Not hadRecords Then
            '    If customerBillingObj.SequenceNumber >= 10000 And customerBillingObj.SequenceNumber < 20000 Then
            '        WriteToRow(rowCount, "*** Holiday Pickup ***", 0.0, False)
            '        WriteToRow(rowCount, "Sat 12/22, Sat 12/29", 0.0, False)
            '    ElseIf customerBillingObj.SequenceNumber >= 20000 And customerBillingObj.SequenceNumber < 29999 Then
            '        WriteToRow(rowCount, "*** Holiday Pickup ***", 0.0, False)
            '        WriteToRow(rowCount, "Mon 12/24, Mon 12/31", 0.0, False)
            '    End If
            'End If

            ' ----- Write out the tax and total 
            If Not hadRecords Then

                ' ----- Write the tax amount 
                Dim taxAmount As Double = taxableAmount * customerBillingObj.TaxRate
                DataGridViewItems.Rows(8).DefaultCellStyle.BackColor = Color.LightGray
                DataGridViewItems.Rows(8).DefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
                DataGridViewItems.Rows(8).Cells("colDescription").Value = "Sales Tax"
                DataGridViewItems.Rows(8).Cells("colAmount").Value = String.Format("{0:f2}", taxAmount)

                ' ----- Write the total amount 
                totalAmount += taxAmount
                DataGridViewItems.Rows(9).DefaultCellStyle.BackColor = Color.LightGray
                DataGridViewItems.Rows(9).DefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
                DataGridViewItems.Rows(9).Cells("colDescription").Value = "Bill Total"
                DataGridViewItems.Rows(9).Cells("colAmount").Value = String.Format("{0:f2}", totalAmount)

            End If

            '----- Determine the current balance
            Dim customerHistoryData As PickupTransaction.Customer.CCustomerHistory = PickupTransaction.Customer.CustomerHistory(My.Settings.DatabaseLocation, customerBillingObj.AccountNumber, Date.Today + New TimeSpan(1, 0, 0, 0))
            DataGridViewHistory.DataSource = (From c In customerHistoryData.TransactionLineItems Order By c.TransactionDate Select c).ToList
            DataGridViewHistory.FirstDisplayedScrollingRowIndex = DataGridViewHistory.Rows.Count - 1

        End If

    End Sub

    Private Sub ButtonNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNext.Click
        If ListBoxCustomers.SelectedIndex - 1 < ListBoxCustomers.Items.Count Then
            SaveCurrentCustomer()
            ListBoxCustomers.SelectedIndex += 1
        End If
    End Sub

    Private Sub ButtonPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrevious.Click
        If ListBoxCustomers.SelectedIndex > 0 Then
            SaveCurrentCustomer()
            ListBoxCustomers.SelectedIndex -= 1
        End If
    End Sub

    Private Sub SaveCurrentCustomer()

        ' ----- Get the object 
        Dim customerBillingObj As PickupTransaction.CBillingData = DirectCast(ListBoxCustomers.SelectedItem, PickupTransaction.CBillingData)

        ' ----- Get the billing date 
        Dim billDate As Date = DateTimePickerBillingDate.Value

        ' ----- Refresh the grid 
        UpdateGridTotal(customerBillingObj.TaxRate)

        ' ----- Remove all of the transactions 
        PickupTransaction.Transactions.DeleteTransactions(My.Settings.DatabaseLocation, customerBillingObj.AccountNumber, billDate)

        ' ----- Make sure the customer object has something in it
        If Not customerBillingObj Is Nothing Then

            For iRow As Integer = 0 To 7

                If DataGridViewItems.Rows(iRow).Cells("colDescription").Value <> "" Then

                    ' ----- Get the description and the amount 
                    Dim strDesc As String = DataGridViewItems.Rows(iRow).Cells("colDescription").Value
                    Dim strAmt As String = DataGridViewItems.Rows(iRow).Cells("colAmount").Value

                    ' ----- Make sure the amount is a valid number 
                    Dim dAmt As Double = 0.0
                    Double.TryParse(strAmt.Replace("$", ""), dAmt)

                    ' ----- Save the data 
                    PickupTransaction.Transactions.SaveTransaction(My.Settings.DatabaseLocation, customerBillingObj.AccountNumber, billDate, strDesc, dAmt)

                End If

            Next

            ' ----- Save the tax 
            Dim dTax As Double = 0.0
            Double.TryParse(DataGridViewItems.Rows(8).Cells("colAmount").Value.ToString, dTax)
            PickupTransaction.Transactions.SaveTransaction(My.Settings.DatabaseLocation, customerBillingObj.AccountNumber, billDate, "Sales Tax", dTax)

            ' ----- Mark the last billing date 
            PickupTransaction.Customer.UpdateMonthBilled(My.Settings.DatabaseLocation, customerBillingObj.AccountNumber, billDate.Month)

            ' ----- Update the balances 
            PickupTransaction.Customer.SetCustomerBalances(My.Settings.DatabaseLocation, customerBillingObj.AccountNumber)

        End If

    End Sub

    Private Sub DataGridViewItems_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewItems.CellEndEdit
        If e.ColumnIndex = 1 Then
            Dim taxRate As Double = DirectCast(ListBoxCustomers.SelectedItem, PickupTransaction.CBillingData).TaxRate
            UpdateGridTotal(taxRate)
        End If
    End Sub

    Private Sub ButtonResetData_Click(sender As System.Object, e As System.EventArgs) Handles ButtonResetData.Click

        ' ----- Make sure this is what the user wants to do 
        Dim ans As DialogResult = MessageBox.Show("The program will remove any transactions in the database for this customer on this billing date and the recreate the transactions based on collection data.  Would you like to continue?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If ans = Windows.Forms.DialogResult.No Then Exit Sub

        Dim customerBillingObj As PickupTransaction.CBillingData = DirectCast(ListBoxCustomers.SelectedItem, PickupTransaction.CBillingData)
        Dim billDate As Date = DateTimePickerBillingDate.Value

        ' ----- Delete the record from the database
        PickupTransaction.Transactions.DeleteTransactions(My.Settings.DatabaseLocation, customerBillingObj.AccountNumber, billDate)

        ' ----- Reset the month billed 
        PickupTransaction.Customer.ResetMonthBilled(My.Settings.DatabaseLocation, customerBillingObj.AccountNumber)

        ' ----- Update the balances 
        PickupTransaction.Customer.SetCustomerBalances(My.Settings.DatabaseLocation, customerBillingObj.AccountNumber)

        ' ----- Refresh the record using calculated values 
        ListBoxCustomers_SelectedIndexChanged(Nothing, Nothing)

        ' ----- Refresh the grid 
        LabelSaved_Click(Nothing, Nothing)

    End Sub

    Private Sub DateTimePickerBillingDate_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePickerBillingDate.ValueChanged
        GetListOfCustomers()
    End Sub

    Private Sub ButtonPreview_Click(sender As System.Object, e As System.EventArgs) Handles ButtonPreview.Click

        Dim billingListing As New List(Of CCustomerBill)

        ' ----- This will give a list of transactions 
        Dim transActionList As List(Of PickupTransaction.Transactions) = PickupTransaction.Transactions.ReturnAllTransactions(My.Settings.DatabaseLocation, DateTimePickerBillingDate.Value)

        ' ----- Get a list of all of the customers 
        For Each obj As PickupTransaction.CBillingData In ListBoxCustomers.Items

            Dim tempBillObj As New CCustomerBill
            tempBillObj.AccountNumber = obj.AccountNumber
            tempBillObj.SequenceNumber = obj.SequenceNumber
            tempBillObj.BillingDate = DateTimePickerBillingDate.Value
            tempBillObj.FirstName = obj.FirstName
            tempBillObj.LastName = obj.LastName
            tempBillObj.Address = obj.Address
            tempBillObj.City = obj.City
            tempBillObj.State = obj.State
            tempBillObj.ZipCode = obj.ZipCode

            Dim billTotal As Double = 0.0

            For Each transOBj As PickupTransaction.Transactions In (From f In transActionList Where f.CustomerID = tempBillObj.AccountNumber Select f).ToList

                Dim newLineItem As New CBillLineItems

                If transOBj.Description = "Sales Tax" Then
                    tempBillObj.Tax = transOBj.Amount
                Else
                    newLineItem.Description = transOBj.Description
                    newLineItem.Amount = transOBj.Amount
                    tempBillObj.LineItems.Add(newLineItem)
                End If

                billTotal += transOBj.Amount

            Next

            tempBillObj.Total = billTotal
            billingListing.Add(tempBillObj)

        Next

        Dim rpt As New BillingSheet
        rpt.BindingSource1.DataSource = From b In billingListing Where b.Total >= 0.01 Select b

        rpt.ShowPreview()

    End Sub

    Private Sub ButtonPreviewSelectedBill_Click(sender As Object, e As EventArgs) Handles ButtonPreviewSelectedBill.Click

        Dim billingListing As New List(Of CCustomerBill)

        ' ----- This will give a list of transactions 
        Dim transActionList As List(Of PickupTransaction.Transactions) = PickupTransaction.Transactions.ReturnAllTransactions(My.Settings.DatabaseLocation, DateTimePickerBillingDate.Value)

        ' ----- Get the selected customer 
        Dim selectedCustomer As PickupTransaction.CBillingData = ListBoxCustomers.SelectedItem

        If Not selectedCustomer Is Nothing Then

            Dim tempBillObj As New CCustomerBill
            tempBillObj.AccountNumber = selectedCustomer.AccountNumber
            tempBillObj.SequenceNumber = selectedCustomer.SequenceNumber
            tempBillObj.BillingDate = DateTimePickerBillingDate.Value
            tempBillObj.FirstName = selectedCustomer.FirstName
            tempBillObj.LastName = selectedCustomer.LastName
            tempBillObj.Address = selectedCustomer.Address
            tempBillObj.City = selectedCustomer.City
            tempBillObj.State = selectedCustomer.State
            tempBillObj.ZipCode = selectedCustomer.ZipCode

            Dim billTotal As Double = 0.0

            For Each transOBj As PickupTransaction.Transactions In (From f In transActionList Where f.CustomerID = tempBillObj.AccountNumber Select f).ToList

                Dim newLineItem As New CBillLineItems

                If transOBj.Description = "Sales Tax" Then
                    tempBillObj.Tax = transOBj.Amount
                Else
                    newLineItem.Description = transOBj.Description
                    newLineItem.Amount = transOBj.Amount
                    tempBillObj.LineItems.Add(newLineItem)
                End If

                billTotal += transOBj.Amount

            Next

            tempBillObj.Total = billTotal
            billingListing.Add(tempBillObj)

        End If

        Dim rpt As New BillingSheetSingle
        rpt.BindingSource1.DataSource = From b In billingListing Where b.Total >= 0.01 Select b

        rpt.ShowPreview()

    End Sub

    Private Sub ButtonCreateBills_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCreateBills.Click

        Dim tempCounter As Integer = 0

        ' ----- Make sure this is what the user wants to do 
        Dim ans As DialogResult = MessageBox.Show("The program will create database entries for all billing transactions that are not in the database for this billing date.  Would you like to continue?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If ans = Windows.Forms.DialogResult.No Then Exit Sub

        ' ----- We need this list to get all of the transactions for a billing date
        Dim transList As List(Of PickupTransaction.Transactions) = PickupTransaction.Transactions.ReturnAllTransactions(My.Settings.DatabaseLocation, DateTimePickerBillingDate.Value)

        ' ------ Loop through all of the bills in the customer list box
        For Each obj As PickupTransaction.CBillingData In (From c In CurrentListOfCustomers Order By c.SequenceNumber Select c)

            Dim tmpCust As PickupTransaction.CBillingData = obj

            Dim custTrans As List(Of PickupTransaction.Transactions) = (From t In transList
                                                                        Where t.CustomerID = tmpCust.AccountNumber Select t).ToList

            ' ------ See if the customer has a bill saved for this billing day                      
            If custTrans.Count = 0 Then

                ' ------ if there are no transactions, then create one
                ListBoxCustomers.SelectedItem = tmpCust

                ' ----- Save the current customer 
                SaveCurrentCustomer()

                Me.Refresh()

            End If

        Next

    End Sub

    Private Sub ButtonSearch_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSearch.Click

        For Each obj As PickupTransaction.CBillingData In ListBoxCustomers.Items

            Dim searchText As String = TextBoxSearch.Text.ToUpper

            If obj.SequenceNumber.ToString.Contains(searchText) Or obj.CustomerName.ToUpper.Contains(searchText) Or obj.AccountNumber.ToString.Contains(searchText) Then
                ListBoxCustomers.SelectedItem = obj
                Exit For
            End If

        Next

    End Sub

    Private Sub ButtonSaveCurrentBill_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSaveCurrentBill.Click
        SaveCurrentCustomer()
    End Sub

    Private Sub LabelGenerate_Click(sender As System.Object, e As System.EventArgs) Handles LabelGenerate.Click, PictureBoxGenerate.Click
        FillMode = 1
        LabelHeader.Text = "Bills to be Generated"
        GetListOfCustomers()
    End Sub

    Private Sub LabelSaved_Click(sender As System.Object, e As System.EventArgs) Handles LabelSaved.Click, PictureBoxSaved.Click
        FillMode = 2
        LabelHeader.Text = "Bills that have been Saved"
        GetListOfCustomers()
    End Sub

    Private Sub PictureBoxClosedAccounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxClosedAccounts.Click
        FillMode = 3
        LabelHeader.Text = "Closed Accounts Still to be Billed"
        GetListOfCustomers()
    End Sub

    Private Sub LabelBagsPickedUp_Click(sender As System.Object, e As System.EventArgs) Handles LabelBagsPickedUp.Click

        ' ----- Display a screen that shows all of the items picked up and on what date
        Dim frm As New EditPickupItems
        frm.CustomerNumber = DirectCast(ListBoxCustomers.SelectedItem, PickupTransaction.CBillingData).AccountNumber
        frm.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim adjBillDate As New AdjustBillDate

        Dim customerBillingObj As PickupTransaction.CBillingData = DirectCast(ListBoxCustomers.SelectedItem, PickupTransaction.CBillingData)
        Dim billDate As Date = DateTimePickerBillingDate.Value

        adjBillDate.CustomerName = customerBillingObj.CustomerName
        adjBillDate.CustomerNumber = customerBillingObj.AccountNumber
        adjBillDate.SequenceNumber = customerBillingObj.SequenceNumber
        adjBillDate.CurrentBillDate = billDate 

        if adjBillDate.ShowDialog = DialogResult.OK then
            ButtonRefresh.PerformClick
        end if

    End Sub

End Class
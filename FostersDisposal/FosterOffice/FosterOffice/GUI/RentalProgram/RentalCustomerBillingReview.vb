Imports DevExpress.XtraReports.UI

Public Class RentalCustomerBillingReview

    Dim MonthDescriptions(12) As String

    Dim CurrentListOfCustomers As List(Of PickupTransaction.CRentalBillingData)

    Public Property ManualBillingMode As Boolean = False
    Public Property ManualCustomerNumber As Integer = 0

    Public Property FillMode As Integer = 1

    Private Property BillingMonth As Integer = 0
    Private Property BillingYear As Integer = 0
    Private Property BillingDate As Date = Nothing

    Private ReadOnly NumberOfTotalRows As Integer = 40
    Private ReadOnly NumberOfWritableRows As Integer = NumberOfTotalRows -  2

    Private Sub GetListOfCustomers()

        Cursor = Cursors.WaitCursor

        ' ----- Highlight the delete bill button 
        ButtonResetData.Enabled = FillMode <> 1
        ButtonCreateBills.Enabled = FillMode = 1


        Dim customerListMonth As New List(Of PickupTransaction.CRentalBillingData)

        ' ----- This gives me a list of account numbers that have saved bills 
        Dim transList As List(Of Integer) = (From c In PickupTransaction.RentalTransaction.ReturnAllTransactions(My.Settings.DatabaseLocation, BillingDate)
                                             Select c.CustomerID Distinct).ToList

        Try

            If FillMode = 1 Then

                ' ----- Return a list of customers 
                customerListMonth = PickupTransaction.RentalCustomer.ReturnCustomersToBill(My.Settings.DatabaseLocation)

                For Each acctNumber As Integer In transList
                    Try
                        Dim tempObj As PickupTransaction.CRentalBillingData = customerListMonth.Where(Function(c) c.AccountNumber = acctNumber).SingleOrDefault
                        If Not tempObj Is Nothing Then
                            customerListMonth.Remove(tempObj)
                        End If
                    Catch ex As Exception
                    End Try
                Next

            ElseIf FillMode = 2 Then


                For Each accountNumber As Integer In transList
                    Try
                        Dim tempList As List(Of PickupTransaction.CRentalBillingData) = PickupTransaction.RentalCustomer.ReturnCustomersToBill(My.Settings.DatabaseLocation, accountNumber)
                        If tempList.Count > 0 Then customerListMonth.Add(tempList(0))
                    Catch ex As Exception
                    End Try
                Next

            End If

            ' ----- Set the customer list 
            CurrentListOfCustomers = New List(Of PickupTransaction.CRentalBillingData)
            CurrentListOfCustomers = customerListMonth

            ' ----- Display the information 
            ListBoxCustomers.DataSource = (From c In customerListMonth Order By c.AccountNumber Select c).ToList
            ListBoxCustomers.DisplayMember = "ListHeader"
            LabelTotalAmount.Text = String.Format("Total Amount: {0}", customerListMonth.Count)

        Catch ex As Exception

        End Try

        ' ----- Set the cursor back 
        Cursor = Cursors.Default

    End Sub

    Private Sub BillingReview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' ----- Set the descriptions
        MonthDescriptions(1) = "January {0}"
        MonthDescriptions(2) = "February {0}"
        MonthDescriptions(3) = "March {0}"
        MonthDescriptions(4) = "April {0}"
        MonthDescriptions(5) = "May {0}"
        MonthDescriptions(6) = "June {0}"
        MonthDescriptions(7) = "July {0}"
        MonthDescriptions(8) = "August {0}"
        MonthDescriptions(9) = "September {0}"
        MonthDescriptions(10) = "October {0}"
        MonthDescriptions(11) = "November {0}"
        MonthDescriptions(12) = "December {0}"

        ' ----- Set the current number of rows 
        DataGridViewItems.Rows.Add(NumberOfTotalRows)

        ' ----- Set the current date 
        Dim currentMonthIndex As Integer = 0
        If Date.Today.Day > 10 Then
            currentMonthIndex = Date.Today.Month
        Else
            currentMonthIndex = Date.Today.Month - 1
        End If

        ' ----- Adjust for January / December 
        Dim SubtractYear As Boolean = False
        If currentMonthIndex = 0 Then
            currentMonthIndex = 12
            SubtractYear = True
        End If

        ComboBoxBillingMonth.SelectedIndex = currentMonthIndex - 1
        TextBoxBillingYear.Text = If(SubtractYear, (Date.Today.Year - 1).ToString, Date.Today.Year.ToString)
        SetBillingDate()

        LabelGenerate_Click(Nothing, Nothing)

    End Sub

    Private Sub WriteToRow(ByRef rowNumber As Integer, ByVal Description As String, ByVal Amount As Double, transDate As Date, qty As Integer)
        rowNumber += 1
        If rowNumber < NumberOfWritableRows Then
            DataGridViewItems.Rows(rowNumber).Cells("colDate").Value = String.Format("{0:MM/dd/yyyy}", transDate)
            DataGridViewItems.Rows(rowNumber).Cells("colQty").Value = If(qty = 0, "", qty.ToString)
            DataGridViewItems.Rows(rowNumber).Cells("colDescription").Value = Description
            DataGridViewItems.Rows(rowNumber).Cells("colAmount").Value = String.Format("{0:f2}", Amount)
        End If
    End Sub

    Private Sub ClearRows()
        For iStep As Integer = 0 To NumberOfWritableRows - 1
            DataGridViewItems.Rows(iStep).Cells("colDate").Value = ""
            DataGridViewItems.Rows(iStep).Cells("colQty").Value = ""
            DataGridViewItems.Rows(iStep).Cells("colDescription").Value = ""
            DataGridViewItems.Rows(iStep).Cells("colAmount").Value = ""
        Next
    End Sub

    Private Function FillInGrid(ByVal customerNumber As Integer, ByVal billingDate As Date) As Boolean

        ' ----- Creates a list of all transactions for a particular date and customer 
        Dim transList As List(Of PickupTransaction.RentalTransaction) = PickupTransaction.RentalTransaction.LookupTransactions(My.Settings.DatabaseLocation, customerNumber, billingDate)

        If transList.Count = 0 AndAlso (FillMode = 1 Or FillMode = 3) Then

            ' ----- If there are no transactions and we are in "GENERATE" mode ... then return FALSE
            Return False

        Else

            Dim totalAmount As Double = 0.0

            For iRow As Integer = 0 To NumberOfWritableRows - 1
                DataGridViewItems.Rows(iRow).Cells(0).Value = ""
                DataGridViewItems.Rows(iRow).Cells(1).Value = ""
            Next

            Dim rowCount As Integer = -1
            For Each tObj As PickupTransaction.RentalTransaction In transList.OrderBy(Function(d) d.TransDate)

                If tObj.Description = "Sales Tax" Then
                    ' ----- Write the tax amount 
                    DataGridViewItems.Rows(NumberOfTotalRows - 2).DefaultCellStyle.BackColor = Color.LightGray
                    DataGridViewItems.Rows(NumberOfTotalRows - 2).DefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
                    DataGridViewItems.Rows(NumberOfTotalRows - 2).Cells("colDescription").Value = tObj.Description
                    DataGridViewItems.Rows(NumberOfTotalRows - 2).Cells("colAmount").Value = String.Format("{0:f2}", tObj.Amount)
                Else
                    rowCount += 1
                    DataGridViewItems.Rows(rowCount).Cells("colDate").Value = String.Format("{0:MM/dd/yyyy}", tObj.TransDate)
                    DataGridViewItems.Rows(rowCount).Cells("colQty").Value = If(tObj.Qty = 0, "", tObj.Qty.ToString)
                    DataGridViewItems.Rows(rowCount).Cells("colDescription").Value = tObj.Description
                    DataGridViewItems.Rows(rowCount).Cells("colAmount").Value = String.Format("{0:f2}", tObj.Amount)
                End If

                totalAmount += tObj.Amount

            Next

            ' ----- Write the total amount 
            DataGridViewItems.Rows(NumberOfTotalRows - 1).DefaultCellStyle.BackColor = Color.LightGray
            DataGridViewItems.Rows(NumberOfTotalRows - 1).DefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
            DataGridViewItems.Rows(NumberOfTotalRows - 1).Cells("colDescription").Value = "Bill Total"
            DataGridViewItems.Rows(NumberOfTotalRows - 1).Cells("colAmount").Value = String.Format("{0:f2}", totalAmount)

            Return True

        End If

    End Function

    Private Sub UpdateGridTotal(ByVal taxRate As Double)

        Dim totalAmount As Double = 0.0
        Dim totalTaxAmount As Double = 0.0

        For iStep As Integer = 0 To NumberOfWritableRows - 1

            If DataGridViewItems.Rows(iStep).Cells("colAmount").Value <> "" Then

                Dim amtToApply As Double = Convert.ToDouble(DataGridViewItems.Rows(iStep).Cells("colAmount").Value)

                If DataGridViewItems.Rows(iStep).Cells("colDescription").Value <> "Previous Balance" And amtToApply > 0.0 Then
                    totalTaxAmount += amtToApply
                End If

                totalAmount += amtToApply

            End If

        Next

        DataGridViewItems.Rows(NumberOfTotalRows - 2).DefaultCellStyle.BackColor = Color.LightGray
        DataGridViewItems.Rows(NumberOfTotalRows - 2).DefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
        DataGridViewItems.Rows(NumberOfTotalRows - 2).Cells("colDescription").Value = "Sales Tax"
        DataGridViewItems.Rows(NumberOfTotalRows - 2).Cells("colAmount").Value = String.Format("{0:f2}", totalTaxAmount * taxRate)

        ' ----- Write the total amount 
        DataGridViewItems.Rows(NumberOfTotalRows - 1).DefaultCellStyle.BackColor = Color.LightGray
        DataGridViewItems.Rows(NumberOfTotalRows - 1).DefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
        DataGridViewItems.Rows(NumberOfTotalRows - 1).Cells("colDescription").Value = "Bill Total"
        DataGridViewItems.Rows(NumberOfTotalRows - 1).Cells("colAmount").Value = String.Format("{0:f2}", totalAmount + (totalTaxAmount * taxRate))

    End Sub

    Private Sub ListBoxCustomers_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxCustomers.SelectedIndexChanged

        Dim daysOfPickup(3) As Integer
        Dim monthsOfPickup(3) As Integer
        Dim yearsOfPickup(3) As Integer

        Dim ServiceDescription As String = ""
        Dim ServiceDescriptionAmount(3) As Double

        ' ---- Each new customer gets a refresh 
        Dim rowCount As Integer = -1
        ClearRows()

        ' ----- Amount to keep track of
        Dim totalAmount As Double = 0.0
        Dim taxableAmount As Double = 0.0

        ' ----- Get the billing object 
        Dim customerBillingObj As PickupTransaction.CRentalBillingData = DirectCast(ListBoxCustomers.SelectedItem, PickupTransaction.CRentalBillingData)

        ' ----- If the object is blank than get out of this routine 
        If customerBillingObj Is Nothing Then Exit Sub

        ' ----- Determine if the user already has records for this date 
        Dim hadRecords As Boolean = FillInGrid(customerBillingObj.AccountNumber, BillingDate)

        ' ----- Get the billing dates 
        Dim pickupStartDate As Date = New Date(BillingYear, BillingMonth, 1)
        Dim pickupEndDate As Date = New Date(BillingYear, BillingMonth, Date.DaysInMonth(BillingYear, BillingMonth))

        ' ----- Set the description label
        ServiceDescription = String.Format(MonthDescriptions(BillingMonth), BillingYear)

        ' ----- Fill in the data 
        LabelCustomer.Text = customerBillingObj.CustomerName
        LabelAcctNumber.Text = String.Format("Account #: {0}", customerBillingObj.AccountNumber)
        LabelCurrentBalance.Text = String.Format("Current Balance: {0:c2}", customerBillingObj.StartingBalance)

        ' ----- If the previous balance is not 0.0, then it should go on the bill 
        If customerBillingObj.StartingBalance <> 0.0 Then

            ' ----- If this is a new record, then write the previous balance 
            If Not hadRecords Then

                ' ----- Write it to the grid 
                Dim startingDate As Date = New Date(BillingDate.Year, BillingDate.Month, 1)
                WriteToRow(rowCount, "Previous Balance", customerBillingObj.StartingBalance, startingDate, 0)

                ' ----- Add to the total amount 
                totalAmount += customerBillingObj.StartingBalance

            End If

        End If

        If Not hadRecords Then

            ' ----- This is the list of everything collected 
            Dim itemListOfCollected As List(Of PickupTransaction.RentalRouteData) = PickupTransaction.RentalRouteData.GetCollectedItemsWithinRangeByDate(My.Settings.DatabaseLocation, pickupStartDate, pickupEndDate, customerBillingObj.AccountNumber)

            ' ----- Per pickup charges 
            For Each strObj As PickupTransaction.RentalRouteData In itemListOfCollected

                If Not strObj.Trash Is Nothing AndAlso strObj.Trash.Trim <> "" AndAlso customerBillingObj.DumpsterChargePUType = 1 AndAlso customerBillingObj.DumpsterCharge <> 0.0 Then
                    If IsNumeric(strObj.Trash) Then
                        WriteToRow(rowCount, "Dumpster Pickup Charge", customerBillingObj.DumpsterCharge * strObj.Trash, strObj.DateOfPickup, strObj.Trash)
                        taxableAmount += customerBillingObj.DumpsterCharge * strObj.Trash
                        totalAmount += customerBillingObj.DumpsterCharge * strObj.Trash
                    Else
                        WriteToRow(rowCount, String.Format("Dumpster Pickup - {0}", strObj.Trash), 0.0, strObj.DateOfPickup, 0)
                    End If
                End If

                If Not strObj.RollOff Is Nothing AndAlso strObj.RollOff.Trim <> "" AndAlso customerBillingObj.RollOffCharge <> 0.0 Then
                    If IsNumeric(strObj.RollOff) Then
                        WriteToRow(rowCount, String.Format("Roll Off Charge"), customerBillingObj.RollOffCharge * strObj.RollOff, strObj.DateOfPickup, strObj.RollOff)
                        taxableAmount += customerBillingObj.RollOffCharge * strObj.RollOff
                        totalAmount += customerBillingObj.RollOffCharge * strObj.RollOff
                    End If
                End If

                If Not strObj.Cart Is Nothing AndAlso strObj.Cart.Trim <> "" AndAlso customerBillingObj.Cart90ChargePUType = 1 AndAlso customerBillingObj.Cart90Charge <> 0.0 Then
                    If IsNumeric(strObj.Cart) Then
                        WriteToRow(rowCount, String.Format("Cart Pickup Charge"), customerBillingObj.Cart90Charge * strObj.Cart, strObj.DateOfPickup, strObj.Cart)
                        taxableAmount += customerBillingObj.Cart90Charge * strObj.Cart
                        totalAmount += customerBillingObj.Cart90Charge * strObj.Cart
                    Else
                        WriteToRow(rowCount, String.Format("Cart Pickup - {0}", strObj.Cart), 0.0, strObj.DateOfPickup, 0)
                    End If
                End If

                If Not strObj.Cardboard Is Nothing AndAlso strObj.Cardboard.Trim <> "" AndAlso customerBillingObj.CardboardChargePUType = 1 AndAlso customerBillingObj.CardboardCharge <> 0.0 Then
                    If IsNumeric(strObj.Cardboard) Then
                        WriteToRow(rowCount, String.Format("Cardboard Pickup Charge"), customerBillingObj.CardboardCharge * strObj.Cardboard, strObj.DateOfPickup, strObj.Cardboard)
                        taxableAmount += customerBillingObj.CardboardCharge * strObj.Cardboard
                        totalAmount += customerBillingObj.CardboardCharge * strObj.Cardboard
                    Else
                        WriteToRow(rowCount, String.Format("Cardboard Pickup - {0}", strObj.Cardboard), 0.0, strObj.DateOfPickup, 0)
                    End If
                End If

                If Not strObj.Recycle Is Nothing AndAlso strObj.Recycle.Trim <> "" AndAlso customerBillingObj.RecycleChargePUType = 1 AndAlso customerBillingObj.RecycleCharge <> 0.0 Then
                    If IsNumeric(strObj.Recycle) Then
                        If customerBillingObj.RecycleChargePUType = 0 Then
                            WriteToRow(rowCount, String.Format("Recycle Pickup Charge"), 0.0, strObj.DateOfPickup, 0)
                        Else
                            WriteToRow(rowCount, String.Format("Recycle Pickup Charge"), customerBillingObj.RecycleCharge * strObj.Recycle, strObj.DateOfPickup, strObj.Recycle)
                            taxableAmount += customerBillingObj.RecycleCharge * strObj.Recycle
                            totalAmount += customerBillingObj.RecycleCharge * strObj.Recycle
                        End If
                    Else
                        WriteToRow(rowCount, String.Format("Recycle Pickup - {0}", strObj.Recycle), 0.0, strObj.DateOfPickup, 0)
                    End If
                End If

                ' ----- Write out the misc charges 
                If IsNumeric(strObj.MiscCharge) AndAlso strObj.MiscCharge > 0.0 Then
                    WriteToRow(rowCount, String.Format("{0}", strObj.Notes), strObj.MiscCharge, strObj.DateOfPickup, 1)
                    taxableAmount += strObj.MiscCharge
                    totalAmount += strObj.MiscCharge
                End If

            Next

            ' ----- Rental charges 
            If customerBillingObj.DumpsterRental <> 0.0 Then
                WriteToRow(rowCount, String.Format("Dumpster Rental - {0}", ServiceDescription), customerBillingObj.DumpsterRental, BillingDate, 1)
                taxableAmount += customerBillingObj.DumpsterRental
                totalAmount += customerBillingObj.DumpsterRental
            End If

            If customerBillingObj.RollOffRental <> 0.0 Then
                WriteToRow(rowCount, String.Format("Roll Off Rental - {0}", ServiceDescription), customerBillingObj.RollOffRental, BillingDate, 1)
                taxableAmount += customerBillingObj.RollOffRental
                totalAmount += customerBillingObj.RollOffRental
            End If

            If customerBillingObj.Cart90Rental <> 0.0 Then
                WriteToRow(rowCount, String.Format("Cart Rental - {0}", ServiceDescription), customerBillingObj.Cart90Rental, BillingDate, 1)
                taxableAmount += customerBillingObj.Cart90Rental
                totalAmount += customerBillingObj.Cart90Rental
            End If

            If customerBillingObj.CardboardRental <> 0.0 Then
                WriteToRow(rowCount, String.Format("Cardboard Rental - {0}", ServiceDescription), customerBillingObj.CardboardRental, BillingDate, 1)
                taxableAmount += customerBillingObj.CardboardRental
                totalAmount += customerBillingObj.CardboardRental
            End If

            If customerBillingObj.RecycleRental <> 0.0 Then
                WriteToRow(rowCount, String.Format("Recycle Rental - {0}", ServiceDescription), customerBillingObj.RecycleRental, BillingDate, 1)
                taxableAmount += customerBillingObj.RecycleRental
                totalAmount += customerBillingObj.RecycleRental
            End If

            If customerBillingObj.DumpsterChargePUType = 0 AndAlso customerBillingObj.DumpsterCharge <> 0.0 Then
                WriteToRow(rowCount, String.Format("Dumpster Charge - {0}", ServiceDescription), customerBillingObj.DumpsterCharge, BillingDate, 1)
                taxableAmount += customerBillingObj.DumpsterCharge
                totalAmount += customerBillingObj.DumpsterCharge
            End If

            'If customerBillingObj.RollOffCharge <> 0.0 Then
            '    WriteToRow(rowCount, String.Format("Roll Off Charge - {0}", ServiceDescription), customerBillingObj.RollOffCharge, BillingDate, 1)
            '    taxableAmount += customerBillingObj.RollOffCharge
            '    totalAmount += customerBillingObj.RollOffCharge
            'End If

            If customerBillingObj.Cart90ChargePUType = 0 AndAlso customerBillingObj.Cart90Charge <> 0.0 Then
                WriteToRow(rowCount, String.Format("Cart Charge - {0}", ServiceDescription), customerBillingObj.Cart90Charge, BillingDate, 1)
                taxableAmount += customerBillingObj.Cart90Charge
                totalAmount += customerBillingObj.Cart90Charge
            End If

            If customerBillingObj.CardboardChargePUType = 0 AndAlso customerBillingObj.CardboardCharge <> 0.0 Then
                WriteToRow(rowCount, String.Format("Cardboard Charge - {0}", ServiceDescription), customerBillingObj.CardboardCharge, BillingDate, 1)
                taxableAmount += customerBillingObj.CardboardCharge
                totalAmount += customerBillingObj.CardboardCharge
            End If

            If customerBillingObj.RecycleChargePUType = 0 AndAlso customerBillingObj.RecycleCharge <> 0.0 Then
                WriteToRow(rowCount, String.Format("Recycle Charge - {0}", ServiceDescription), customerBillingObj.RecycleCharge, BillingDate, 1)
                taxableAmount += customerBillingObj.RecycleCharge
                totalAmount += customerBillingObj.RecycleCharge
            End If

        End If

        ' ----- Get the additional items 
        customerBillingObj.AdditionalItems = ""
        customerBillingObj.AdditionalItemCost = 0.0

        'Dim tempList As List(Of PickupTransaction.CAdditionalItems) = (From i In itemListOfCollected
        '                                                              Where i.CustomerID = customerBillingObj.AccountNumber And i.ItemID <> 1
        '                                                              Select New PickupTransaction.CAdditionalItems With
        '                                                                     {
        '                                                                         .AdditionalItems = i.ItemDescription,
        '                                                                         .AdditionalItemCost = i.ItemPrice
        '                                                                     }).ToList

        '' ----- Set them for the customer object 
        'For Each strTemp As PickupTransaction.CAdditionalItems In tempList

        '    customerBillingObj.AdditionalItems &= strTemp.AdditionalItems & " "
        '    customerBillingObj.AdditionalItemCost += strTemp.AdditionalItemCost

        '    ' ----- Only write these out if these are new records 
        '    If Not hadRecords Then
        '        WriteToRow(rowCount, strTemp.AdditionalItems, strTemp.AdditionalItemCost)
        '        taxableAmount += strTemp.AdditionalItemCost
        '        totalAmount += strTemp.AdditionalItemCost
        '    End If

        'Next

        ' ----- Routine to track the payments 
        'If customerBillingObj.DelinquentAccount = False And customerBillingObj.StartingBalance <> 0.0 Then
        'If customerBillingObj.DelinquentAccount = False Then
        '    Dim customerPayments As Double = PickupTransaction.Payments.ReturnSumPaymentsWithinRange(My.Settings.DatabaseLocation, customerBillingObj.AccountNumber, pickupStartDate, pickupEndDate)
        '    If customerPayments <> 0.0 And Not hadRecords Then
        '        WriteToRow(rowCount, "Payments - Thank you", -customerPayments)
        '        totalAmount -= customerPayments
        '    End If
        'End If

        ' ----- Write out the tax and total 
        If Not hadRecords Then

            ' ----- Write the tax amount 
            Dim taxAmount As Double = taxableAmount * customerBillingObj.TaxRate
            DataGridViewItems.Rows(NumberOfTotalRows - 2).DefaultCellStyle.BackColor = Color.LightGray
            DataGridViewItems.Rows(NumberOfTotalRows - 2).DefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
            DataGridViewItems.Rows(NumberOfTotalRows - 2).Cells("colDescription").Value = "Sales Tax"
            DataGridViewItems.Rows(NumberOfTotalRows - 2).Cells("colAmount").Value = String.Format("{0:f2}", taxAmount)

            ' ----- Write the total amount 
            totalAmount += taxAmount
            DataGridViewItems.Rows(NumberOfTotalRows - 1).DefaultCellStyle.BackColor = Color.LightGray
            DataGridViewItems.Rows(NumberOfTotalRows - 1).DefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
            DataGridViewItems.Rows(NumberOfTotalRows - 1).Cells("colDescription").Value = "Bill Total"
            DataGridViewItems.Rows(NumberOfTotalRows - 1).Cells("colAmount").Value = String.Format("{0:f2}", totalAmount)

        End If

        '----- Determine the current balance
        'Dim customerHistoryData As PickupTransaction.Customer.CCustomerHistory = PickupTransaction.Customer.CustomerHistory(My.Settings.DatabaseLocation, customerBillingObj.AccountNumber, Date.Today + New TimeSpan(1, 0, 0, 0))
        'DataGridViewHistory.DataSource = (From c In customerHistoryData.TransactionLineItems Order By c.TransactionDate Select c).ToList
        'DataGridViewHistory.FirstDisplayedScrollingRowIndex = DataGridViewHistory.Rows.Count - 1

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
        Dim customerBillingObj As PickupTransaction.CRentalBillingData = DirectCast(ListBoxCustomers.SelectedItem, PickupTransaction.CRentalBillingData)

        ' ----- Refresh the grid 
        UpdateGridTotal(customerBillingObj.TaxRate)

        ' ----- Remove all of the transactions 
        PickupTransaction.RentalTransaction.DeleteTransactions(My.Settings.DatabaseLocation, customerBillingObj.AccountNumber, BillingDate)

        ' ----- Make sure the customer object has something in it
        If Not customerBillingObj Is Nothing Then

            For iRow As Integer = 0 To NumberOfWritableRows - 1

                If DataGridViewItems.Rows(iRow).Cells("colDescription").Value <> "" Then

                    ' ----- Get the service date 
                    Dim dteServiceDate As Date = Nothing
                    Date.TryParse(DataGridViewItems.Rows(iRow).Cells("colDate").Value.ToString, dteServiceDate)

                    ' ----- Get the description and the amount 
                    Dim nQty As Integer = 0
                    Integer.TryParse(DataGridViewItems.Rows(iRow).Cells("colQty").Value.ToString, nQty)

                    Dim strDesc As String = DataGridViewItems.Rows(iRow).Cells("colDescription").Value
                    Dim strAmt As String = DataGridViewItems.Rows(iRow).Cells("colAmount").Value

                    ' ----- Make sure the amount is a valid number 
                    Dim dAmt As Double = 0.0
                    Double.TryParse(strAmt.Replace("$", ""), dAmt)

                    ' ----- Save the data 
                    PickupTransaction.RentalTransaction.SaveTransaction(My.Settings.DatabaseLocation, customerBillingObj.AccountNumber, dteServiceDate, strDesc, dAmt, nQty, BillingDate)

                End If

            Next

            ' ----- Save the tax 
            Dim dTax As Double = 0.0
            Double.TryParse(DataGridViewItems.Rows(NumberOfTotalRows - 2).Cells("colAmount").Value.ToString, dTax)
            PickupTransaction.RentalTransaction.SaveTransaction(My.Settings.DatabaseLocation, customerBillingObj.AccountNumber, BillingDate, "Sales Tax", dTax, 0, BillingDate)

            ' ----- Mark the last billing date 
            PickupTransaction.RentalCustomer.UpdateMonthBilled(My.Settings.DatabaseLocation, customerBillingObj.AccountNumber, BillingDate.Month)

            ' ----- Update the balances 
            PickupTransaction.RentalCustomer.SetCustomerBalances(My.Settings.DatabaseLocation, customerBillingObj.AccountNumber)

        End If

    End Sub

    Private Sub DataGridViewItems_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewItems.CellEndEdit
        If e.ColumnIndex = 3 Then
            Dim taxRate As Double = DirectCast(ListBoxCustomers.SelectedItem, PickupTransaction.CRentalBillingData).TaxRate
            UpdateGridTotal(taxRate)
        End If
    End Sub

    Private Sub ButtonResetData_Click(sender As System.Object, e As System.EventArgs) Handles ButtonResetData.Click

        ' ----- Make sure this is what the user wants to do 
        Dim ans As DialogResult = MessageBox.Show("The program will remove any transactions in the database for this customer on this billing date and the recreate the transactions based on collection data.  Would you like to continue?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If ans = Windows.Forms.DialogResult.No Then Exit Sub

        Dim customerBillingObj As PickupTransaction.CRentalBillingData = DirectCast(ListBoxCustomers.SelectedItem, PickupTransaction.CRentalBillingData)

        ' ----- Delete the record from the database
        PickupTransaction.RentalTransaction.DeleteTransactions(My.Settings.DatabaseLocation, customerBillingObj.AccountNumber, BillingDate)

        ' ----- Reset the month billed 
        'PickupTransaction.Customer.ResetMonthBilled(My.Settings.DatabaseLocation, customerBillingObj.AccountNumber)

        ' ----- Update the balances 
        'PickupTransaction.Customer.SetCustomerBalances(My.Settings.DatabaseLocation, customerBillingObj.AccountNumber)

        ' ----- Refresh the record using calculated values 
        ListBoxCustomers_SelectedIndexChanged(Nothing, Nothing)

        ' ----- Refresh the grid 
        LabelSaved_Click(Nothing, Nothing)

    End Sub

    Private Sub PrintBills(allBills As Boolean, withHeader As Boolean)

        Dim billingListing As New List(Of CRentalCustomerBill)

        ' ----- This will give a list of transactions 
        Dim transActionList As List(Of PickupTransaction.RentalTransaction) = PickupTransaction.RentalTransaction.ReturnAllTransactions(My.Settings.DatabaseLocation, BillingDate)

        ' ----- Get a list of all of the customers 
        For Each obj As PickupTransaction.CRentalBillingData In If(allBills, ListBoxCustomers.Items, ListBoxCustomers.SelectedItems)

            Dim tempBillObj As New CRentalCustomerBill
            tempBillObj.AccountNumber = obj.AccountNumber
            tempBillObj.SequenceNumber = obj.SequenceNumber
            tempBillObj.BillingDate = BillingDate
            tempBillObj.BillingFirstName = obj.BillingFirstName
            tempBillObj.BillingLastName = obj.BillingLastName
            tempBillObj.BillingAddress = obj.BillingAddress
            tempBillObj.BillingCity = obj.BillingCity
            tempBillObj.BillingState = obj.BillingState
            tempBillObj.BillingZipCode = obj.BillingZipCode
            tempBillObj.PickUpFirstName = obj.PickupFirstName
            tempBillObj.PickUpLastName = obj.PickupLastName
            tempBillObj.PickUpAddress = obj.PickupAddress
            tempBillObj.PickUpCity = obj.PickupCity
            tempBillObj.PickUpState = obj.PickupState
            tempBillObj.PickUpZipCode = obj.PickupZipCode

            ' ----- Added 01-Mar-2017
            tempBillObj.PurchaseOrderNumber = obj.PurchaseOrderNumber 

            Dim billTotal As Double = 0.0
            Dim billSubTotal As Double = 0.0

            For Each transObj As PickupTransaction.RentalTransaction In (From f In transActionList Where f.CustomerID = tempBillObj.AccountNumber Select f).ToList

                Dim newLineItem As New CRentalBillLineItems

                If transObj.Description = "Sales Tax" Then
                    tempBillObj.Tax = transObj.Amount
                Else
                    newLineItem.Description = transObj.Description
                    newLineItem.Amount = transObj.Amount
                    newLineItem.ServiceDate = transObj.TransDate
                    newLineItem.Qty = If(transObj.Qty = 0, "", transObj.Qty.ToString)

                    If transObj.Qty > 0 Then
                        newLineItem.UnitPrice = String.Format("{0:f2}", newLineItem.Amount / transObj.Qty)
                    Else
                        newLineItem.UnitPrice = ""
                    End If

                    tempBillObj.LineItems.Add(newLineItem)
                    billSubTotal += transObj.Amount
                End If

                billTotal += transObj.Amount

            Next

            tempBillObj.Subtotal = billSubTotal
            tempBillObj.Total = billTotal
            billingListing.Add(tempBillObj)

        Next

        Dim rpt As New CommercialInvoice
        If withHeader = False Then rpt.HidePanels()
        rpt.XrLabelPrintDate.Text = String.Format("{0:MM/dd/yyyy}", Date.Today)
        rpt.BindingSourceMain.DataSource = From b In billingListing Order By b.AccountNumber Select b

        rpt.ShowPreview()

    End Sub

    Private Sub ButtonPreview_Click(sender As System.Object, e As System.EventArgs) Handles ButtonPreview.Click, ButtonPrintSelectedBill.Click

        Dim btn As Button = DirectCast(sender, Button)

        If btn.Name = "ButtonPrintSelectedBill" Then
            PrintBills(False, CheckBoxWithHeader.Checked)
        Else
            PrintBills(True, False)
        End If

    End Sub

    Private Sub ButtonCreateBills_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCreateBills.Click

        Dim tempCounter As Integer = 0

        ' ----- Make sure this is what the user wants to do 
        Dim ans As DialogResult = MessageBox.Show("The program will create database entries for all billing transactions that are not in the database for this billing date.  Would you like to continue?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If ans = Windows.Forms.DialogResult.No Then Exit Sub

        ' ----- We need this list to get all of the transactions for a billing date
        Dim transList As List(Of PickupTransaction.RentalTransaction) = PickupTransaction.RentalTransaction.ReturnAllTransactions(My.Settings.DatabaseLocation, BillingDate)

        ' ------ Loop through all of the bills in the customer list box
        For Each obj As PickupTransaction.CRentalBillingData In (From c In CurrentListOfCustomers Order By c.AccountNumber Select c)

            Dim tmpCust As PickupTransaction.CRentalBillingData = obj

            Dim custTrans As List(Of PickupTransaction.RentalTransaction) = (From t In transList
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

        For Each obj As PickupTransaction.CRentalBillingData In ListBoxCustomers.Items

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

        ' ----- Redo the search if the user 
        If Not String.IsNullOrEmpty(TextBoxSearch.Text) Then ButtonSearch.PerformClick()

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
        Dim frm As New ViewRentalPickupItems
        frm.AccountNumber = DirectCast(ListBoxCustomers.SelectedItem, PickupTransaction.CRentalBillingData).AccountNumber
        frm.CustomerName = DirectCast(ListBoxCustomers.SelectedItem, PickupTransaction.CRentalBillingData).CustomerName
        frm.ShowDialog()

    End Sub

    Private Sub LabelViewCompanyCard_Click(sender As Object, e As EventArgs) Handles LabelViewCompanyCard.Click

        Dim frm As New RentalCustomerEntry
        frm.EditMode = True
        frm.CustomerNumber = DirectCast(ListBoxCustomers.SelectedItem, PickupTransaction.CRentalBillingData).AccountNumber
        frm.TabIndexToDisplay = 1
        frm.ShowDialog()

    End Sub

#Region "Set Billing Date"

    Private Sub ComboBoxBillingMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBillingMonth.SelectedIndexChanged
        If ComboBoxBillingMonth.Focused Then SetBillingDate()
    End Sub

    Private Sub TextBoxBillingYear_Leave(sender As Object, e As EventArgs) Handles TextBoxBillingYear.Leave
        SetBillingDate()
    End Sub

    Private Sub SetBillingDate()

        ' ----- Get the month from the combobox 
        BillingMonth = ComboBoxBillingMonth.SelectedIndex + 1

        ' ----- Get the year
        If IsNumeric(TextBoxBillingYear.Text) Then
            BillingYear = Convert.ToInt32(TextBoxBillingYear.Text)
        Else
            BillingYear = Date.Today.Year
        End If

        ' ----- Now set the billing date 
        BillingDate = New Date(BillingYear, BillingMonth, Date.DaysInMonth(BillingYear, BillingMonth))

    End Sub

#End Region

End Class
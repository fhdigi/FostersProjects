Imports DevExpress.XtraReports.UI

Public Class ReprintBill

    Private Sub ReprintBill_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        RefreshPrintQueLB()

        ' ----- Fill in the list of the customer 
        Dim customerList As List(Of PickupTransaction.Customer) = PickupTransaction.Customer.ReturnCustomer(My.Settings.DatabaseLocation)
        ListBoxCustomers.DataSource = customerList
        ListBoxCustomers.DisplayMember = "ReverseFullName"

    End Sub

    Private Sub ButtonClose_Click(sender As System.Object, e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub GetTransactions(customerNumber As Integer)
        Dim transList As List(Of Date) = PickupTransaction.Transactions.ReturnAllTransactionDatesByCustomer(My.Settings.DatabaseLocation, customerNumber)
        ListBoxBills.DataSource = transList
    End Sub

    Private Sub ListBoxCustomers_Leave(sender As Object, e As System.EventArgs) Handles ListBoxCustomers.Leave

    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As System.EventArgs) Handles TextBoxSearch.TextChanged
        Try
            ListBoxCustomers.SelectedIndex = ListBoxCustomers.FindString(TextBoxSearch.Text)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub RefreshPrintQueLB()

        ' ----- Fill in the current print ques
        ListBoxPrintQue.DataSource = Nothing
        ListBoxPrintQue.DataSource = CustomPrintQue
        ListBoxPrintQue.DisplayMember = "ListBoxString"

    End Sub

    Private Sub ButtonAddToQue_Click(sender As Object, e As System.EventArgs) Handles ButtonAddToQue.Click

        ' ----- Get the selected customer 
        Dim customerObj As PickupTransaction.Customer = DirectCast(ListBoxCustomers.SelectedItem, PickupTransaction.Customer)

        ' ----- Get the selected date 
        Dim selectedDate As Date = DirectCast(ListBoxBills.SelectedItem, Date)

        ' ----- This will give a list of transactions 
        Dim transActionList As List(Of PickupTransaction.Transactions) = PickupTransaction.Transactions.ReturnAllTransactions(My.Settings.DatabaseLocation, selectedDate)

        ' ----- Get a list of all of the customers 
        Dim tempBillObj As New CCustomerBill
        tempBillObj.AccountNumber = customerObj.CustomerNumber
        tempBillObj.SequenceNumber = customerObj.SequenceNumber
        tempBillObj.BillingDate = selectedDate
        tempBillObj.FirstName = customerObj.Billing_FirstName
        tempBillObj.LastName = customerObj.Billing_LastName
        tempBillObj.Address = customerObj.Billing_Address
        tempBillObj.City = customerObj.Billing_City
        tempBillObj.State = customerObj.Billing_State
        tempBillObj.ZipCode = customerObj.Billing_ZipCode

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
            tempBillObj.Total = billTotal

        Next

        CustomPrintQue.Add(tempBillObj)

        RefreshPrintQueLB()

    End Sub

    Private Sub ListBoxCustomers_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ListBoxCustomers.SelectedIndexChanged
        Try
            Dim custObj As PickupTransaction.Customer = DirectCast(ListBoxCustomers.SelectedItem, PickupTransaction.Customer)
            GetTransactions(custObj.CustomerNumber)
            LabelBillDates.Text = "Bill Dates: " & custObj.FullName
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonRemoveFromQue_Click(sender As System.Object, e As System.EventArgs) Handles ButtonRemoveFromQue.Click

        Dim tempBillObj As CCustomerBill = DirectCast(ListBoxPrintQue.SelectedItem, CCustomerBill)
        CustomPrintQue.Remove(tempBillObj)
        RefreshPrintQueLB()

    End Sub

    Private Sub ButtonPrint_Click(sender As Object, e As System.EventArgs) Handles ButtonPrint.Click

        Dim rpt As New BillingSheetCustom
        rpt.BindingSource1.DataSource = CustomPrintQue
        rpt.ShowPreview()

    End Sub

    Private Sub LinkLabelRemoveAllBills_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelRemoveAllBills.LinkClicked

        ' ----- Remove all of the items from the print que
        If MessageBox.Show("This will remove all of the bills from the print que.  Are you sure you would like to continue?", "Clear Print Que", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            CustomPrintQue.Clear()
            RefreshPrintQueLB()
        End If

    End Sub

End Class
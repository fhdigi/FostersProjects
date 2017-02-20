Imports DevExpress.XtraReports.UI

Public Class ViewRentalBills

    Public Property CustomerAccountNumber As Integer = 0
    Dim RentalCustomerBilling As New PickupTransaction.RentalTransaction.RentalTransactionSummary

    Private Sub ViewRentalBills_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RentalCustomerBilling = PickupTransaction.RentalTransaction.ReturnAllTransactionsForCustomer(My.Settings.DatabaseLocation, CustomerAccountNumber)

        If Not RentalCustomerBilling Is Nothing AndAlso RentalCustomerBilling.TransactionList.Count > 0 Then
            For Each obj As PickupTransaction.RentalTransaction.RentalTransactionItem In RentalCustomerBilling.TransactionList
                Dim itmX As ListViewItem = ListViewBills.Items.Add(String.Format("{0:MM/dd/yyyy}", obj.TransDate))
                itmX.SubItems.Add(String.Format("{0:f2}", obj.TotalAmount))
            Next
        End If

    End Sub

    Private Sub ButtonView_Click(sender As Object, e As EventArgs) Handles ButtonView.Click

        Dim billingListing As New List(Of CRentalCustomerBill)

        ' ----- check to make sure something was checked 
        If ListViewBills.SelectedItems.Count = 0 Then Exit Sub

        Dim selectedItem As ListViewItem = ListViewBills.SelectedItems(0)
        Dim billDate As Date = Nothing

        If Date.TryParse(selectedItem.Text, billDate) Then

            ' ----- This will give a list of transactions 
            Dim transActionList As List(Of PickupTransaction.RentalTransaction) = PickupTransaction.RentalTransaction.ReturnAllTransactions(My.Settings.DatabaseLocation, billDate)

            ' ----- Get a list of all of the customers 
            Dim tempBillObj As New CRentalCustomerBill
            tempBillObj.AccountNumber = RentalCustomerBilling.Customer.CustomerNumber
            tempBillObj.BillingDate = billDate
            tempBillObj.BillingFirstName = RentalCustomerBilling.Customer.Billing_FirstName
            tempBillObj.BillingLastName = RentalCustomerBilling.Customer.Billing_LastName
            tempBillObj.BillingAddress = RentalCustomerBilling.Customer.Billing_Address
            tempBillObj.BillingCity = RentalCustomerBilling.Customer.Billing_City
            tempBillObj.BillingState = RentalCustomerBilling.Customer.Billing_State
            tempBillObj.BillingZipCode = RentalCustomerBilling.Customer.Billing_ZipCode
            tempBillObj.PickUpFirstName = RentalCustomerBilling.Customer.RouteLocation_FirstName
            tempBillObj.PickUpLastName = RentalCustomerBilling.Customer.RouteLocation_LastName
            tempBillObj.PickUpAddress = RentalCustomerBilling.Customer.RouteLocation_Address
            tempBillObj.PickUpCity = RentalCustomerBilling.Customer.RouteLocation_City
            tempBillObj.PickUpState = RentalCustomerBilling.Customer.RouteLocation_State
            tempBillObj.PickUpZipCode = RentalCustomerBilling.Customer.RouteLocation_ZipCode

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


            Dim rpt As New CommercialInvoice
            rpt.XrLabelPrintDate.Text = String.Format("{0:MM/dd/yyyy}", Date.Today)
            rpt.BindingSourceMain.DataSource = From b In billingListing Order By b.AccountNumber Select b

            rpt.ShowPreview()

        End If


    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ListViewBills_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListViewBills.MouseDoubleClick
        ButtonView.PerformClick()
    End Sub

End Class
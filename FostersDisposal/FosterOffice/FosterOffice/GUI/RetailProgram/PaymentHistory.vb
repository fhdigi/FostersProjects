Imports PickupTransaction

Public Class PaymentHistory

    Public Property CustomerNumber As Integer = 0

    Private Sub PaymentHistory_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        RefreshPaymentGrid()
    End Sub

    Private Sub RefreshPaymentGrid()

#If RentalProgram Then

        ' ----- The grid for the payments 
        PaymentsBindingSource.Clear()
        PaymentsBindingSource.DataSource = RentalPayment.ReturnAllPayments(My.Settings.DatabaseLocation, _CustomerNumber)

        ' ----- Set the customer name also 
        LabelCustomer.Text = RentalCustomer.GetCustomerName(My.Settings.DatabaseLocation, _CustomerNumber)

#Else
        ' ----- The grid for the payments 
        PaymentsBindingSource.Clear()
        PaymentsBindingSource.DataSource = Payments.ReturnAllPayments(My.Settings.DatabaseLocation, _CustomerNumber)

        ' ----- Set the customer name also 
        LabelCustomer.Text = Customer.GetCustomerName(My.Settings.DatabaseLocation, _CustomerNumber)

#End If

    End Sub

    Private Sub ButtonAddNewPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAddNewPayment.Click

#If RentalProgram Then

        Dim frm As New RentalMakePayment
        frm.SelectedCustomerNumber = CustomerNumber

        ' ----- Show the proper screen 
        frm.ShowDialog()

        ' ----- Refresh the payment grid 
        RefreshPaymentGrid()

#Else

        Dim frm As New MakePayment
        frm.SelectedCustomerNumber = CustomerNumber

        ' ----- Show the proper screen 
        frm.ShowDialog()

        ' ----- Refresh the payment grid 
        RefreshPaymentGrid()

#End If

    End Sub

    Private Sub ButtonEditSelectedPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEditSelectedPayment.Click

#If RentalProgram Then

        If DataGridViewPayments.SelectedRows.Count > 0 Then

            Dim frm As New RentalMakePayment
            frm.SelectedCustomerNumber = CustomerNumber
            frm.EditPayment = True
            frm.PaymentID = DataGridViewPayments.SelectedRows(0).Cells("colID").Value

            ' ----- Show the dialog
            frm.ShowDialog()

            ' ----- Refresh the payment grid 
            RefreshPaymentGrid()

        End If
#Else

       If DataGridViewPayments.SelectedRows.Count > 0 Then

            Dim frm As New MakePayment
            frm.SelectedCustomerNumber = CustomerNumber
            frm.EditPayment = True
            frm.PaymentID = DataGridViewPayments.SelectedRows(0).Cells("colID").Value

            ' ----- Show the dialog
            frm.ShowDialog()

            ' ----- Refresh the payment grid 
            RefreshPaymentGrid()

        End If
#End If

    End Sub

    Private Sub ButtonDeleteSelectedPayment_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonDeleteSelectedPayment.Click

#If RentalProgram Then

        If DataGridViewPayments.SelectedRows.Count > 0 Then

            ' ----- Only delete the payment if the user is certain 
            If (MessageBox.Show("Are you sure you would like to delete the selected payment?  Once confirmed, this process cannot be undone.", "Delete Payment Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then

                ' ----- Get the payment ID 
                Dim PaymentID As Integer = DataGridViewPayments.SelectedRows(0).Cells("colID").Value

                ' ----- Delete the payment from the database 
                PickupTransaction.RentalPayment.DeletePayment(My.Settings.DatabaseLocation, PaymentID)

                ' ----- Refresh the customer balance 
                PickupTransaction.RentalCustomer.SetCustomerBalances(My.Settings.DatabaseLocation, CustomerNumber)

                ' ----- Refresh the grid 
                RefreshPaymentGrid()

            End If

        End If

#Else

        If DataGridViewPayments.SelectedRows.Count > 0 Then

            ' ----- Only delete the payment if the user is certain 
            If (MessageBox.Show("Are you sure you would like to delete the selected payment?  Once confirmed, this process cannot be undone.", "Delete Payment Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then

                ' ----- Get the payment ID 
                Dim paymentId As Integer = DataGridViewPayments.SelectedRows(0).Cells("colID").Value

                ' ----- Delete the payment from the database 
                Payments.DeletePayment(My.Settings.DatabaseLocation, paymentId)

                ' ----- Refresh the customer balance 
                Customer.SetCustomerBalances(My.Settings.DatabaseLocation, CustomerNumber)

                ' ----- Refresh the grid 
                RefreshPaymentGrid()

            End If

        End If

#End If


    End Sub

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Close()
    End Sub

End Class
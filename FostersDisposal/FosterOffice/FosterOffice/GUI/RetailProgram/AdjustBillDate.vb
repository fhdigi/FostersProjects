Public Class AdjustBillDate

    Public Property CurrentBillDate As DateTime
    Public Property CustomerName As String
    Public Property CustomerNumber As Integer
    Public Property SequenceNumber As Integer

    Private Sub ButtonAdjust_Click(sender As Object, e As EventArgs) Handles ButtonAdjust.Click

        '* first refresh the bill *'
        PickupTransaction.Transactions.UpdateBillingDate(My.Settings.DatabaseLocation, CustomerNumber, CurrentBillDate, DateTimePickerNewDate.Value)

        '* now refresh the balance *'
        PickupTransaction.Customer.SetCustomerBalances(My.Settings.DatabaseLocation, CustomerNumber)

        '* close the screen *'
        DialogResult = DialogResult.OK

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub AdjustBillDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LabelMessage.Text = String.Format("Current bill date for {0} is {1}", CustomerName, CurrentBillDate.ToShortDateString)
        DateTimePickerNewDate.Value = Convert.ToDateTime(CurrentBillDate)

    End Sub

End Class
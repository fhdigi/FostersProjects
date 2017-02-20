Public Class CustomerListing

    Public Property SelectedCustomer As Integer = 0

    Private Sub CustomerListing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'For Each customerObj As PickupTransaction.Customer.CCustomerList In PickupTransaction.Customer.ReturnCustomerListByDayAndRoute(My.Settings.DatabaseLocation, My.Settings.SelectedRouteDay, My.Settings.SelectedRouteNumber)
        '    Dim tmpString As String = String.Format("{0} - {1}", customerObj.SequenceNumber, customerObj.CustomerName)
        '    ListBoxCustomers.Items.Add(tmpString)
        'Next

        For Each customerObj As PickupTransaction.Customer.CCustomerList In PickupTransaction.Customer.ReturnCustomerListByDayAndRoute_V2(My.Settings.SelectedRouteDay, My.Settings.SelectedRouteNumber)
            Dim tmpString As String = String.Format("{0} - {1}", customerObj.SequenceNumber, customerObj.CustomerName)
            ListBoxCustomers.Items.Add(tmpString)
        Next

    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click

        ' ----- Just close the listing 
        DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub ButtonGoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGoto.Click

        ' ----- Set the customer listing 
        SelectedCustomer = ListBoxCustomers.SelectedIndex

        ' ----- Close the dialog 
        DialogResult = DialogResult.OK
        Me.Close()

    End Sub

End Class
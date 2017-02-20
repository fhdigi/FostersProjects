Public Class EditCustomerRecord

    Public CustomerToEdit As CCustomer = Nothing

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub EditCustomerRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' ----- Set the property grid 
        PropertyGridCustomer.SelectedObject = CustomerToEdit
        PropertyGridCustomer.ExpandAllGridItems()

        ' ----- Set the customer name on the label
        LabelCustomerName.Text = CustomerToEdit.BillingAddress.FullName

    End Sub

    Private Sub PropertyGridCustomer_PropertyValueChanged(s As Object, e As PropertyValueChangedEventArgs) Handles PropertyGridCustomer.PropertyValueChanged

        ' ----- Save any changes 
        DirectCast(PropertyGridCustomer.SelectedObject, CCustomer).Update()

    End Sub

End Class
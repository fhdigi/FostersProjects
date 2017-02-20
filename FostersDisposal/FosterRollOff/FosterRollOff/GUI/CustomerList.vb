Public Class CustomerList

    Public Property ForceRefresh As Boolean = False

    Private Sub FillList(searchCriteria As String)

        ListViewCustomers.Items.Clear()

        Dim listForCustomers As List(Of CCustomer) = Nothing
        If searchCriteria.Trim <> "" Then
            listForCustomers = CurrentCustomerList.Where(Function(c) c.CustomerNumber.ToUpper.Contains(searchCriteria) OrElse c.BillingAddress.LastName.ToUpper.Contains(searchCriteria) OrElse c.BillingAddress.FirstName.ToUpper.Contains(searchCriteria) OrElse c.BillingAddress.Address.ToUpper.Contains(searchCriteria)).ToList
        Else
            listForCustomers = CurrentCustomerList
        End If

        For Each custObj As CCustomer In listForCustomers.OrderBy(Function(c) c.BillingAddress.FirstName).OrderBy(Function(c) c.BillingAddress.LastName)
            Dim itmX As ListViewItem = ListViewCustomers.Items.Add(custObj.CustomerNumber)
            itmX.SubItems.Add(custObj.BillingAddress.ReverseFullName)
            itmX.SubItems.Add(custObj.BillingAddress.Address & " " & custObj.BillingAddress.CSZ)
            itmX.Tag = custObj
        Next

    End Sub

    Private Sub CustomerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' ----- If this screen request came from the collection screen, the force a refresh
        If ForceRefresh Then
            ButtonRefresh.PerformClick()
            If ListViewCustomers.Items.Count > 0 Then
                ListViewCustomers.Items(0).Selected = True
            End If
        Else
            FillList("")
        End If

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim delCustomer As CCustomer = DirectCast(ListViewCustomers.SelectedItems(0).Tag, CCustomer)
        delCustomer.Delete()
        FillGlobalLists()
        FillList("")
    End Sub

    Private Sub ListViewCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewCustomers.SelectedIndexChanged
        If ListViewCustomers.SelectedItems.Count > 0 Then
            PropertyGridCustomer.SelectedObject = DirectCast(ListViewCustomers.SelectedItems(0).Tag, CCustomer)
            PropertyGridCustomer.ExpandAllGridItems()
        End If
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        FillList(TextBoxSearch.Text.ToUpper)
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub PropertyGridCustomer_PropertyValueChanged(s As Object, e As PropertyValueChangedEventArgs) Handles PropertyGridCustomer.PropertyValueChanged
        DirectCast(PropertyGridCustomer.SelectedObject, CCustomer).Update()
    End Sub

    Private Sub TextBoxSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxSearch.KeyDown
        If e.KeyCode = Keys.Return Then
            ButtonRefresh.PerformClick()
        End If
    End Sub

    Private Sub TextBoxSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxSearch.KeyPress
        If e.KeyChar = ControlChars.Cr Then
            e.Handled = True
        End If
    End Sub

End Class
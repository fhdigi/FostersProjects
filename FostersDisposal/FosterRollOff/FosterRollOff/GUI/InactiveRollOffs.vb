Public Class InactiveRollOffs

    Public ShouldRefresh As Boolean = False

    Private Sub InactiveRollOffs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillList()
    End Sub

    Private Function GetRollOffList(searchCriteria As String) As List(Of CRollOff)

        ' ----- If a search string is passed in, then filter the results ... a blank search string returns the full list 
        If searchCriteria.Trim = "" Then
            Return CRollOff.GetListOfInActiveRollOffs.OrderBy(Function(r) r.Customer.BillingAddress.LastName).ToList
        Else
            searchCriteria = searchCriteria.ToUpper
            Return CRollOff.GetListOfInActiveRollOffs.Where(Function(r) r.Customer.BillingAddress.LastName.ToUpper.Contains(searchCriteria) Or r.Customer.BillingAddress.FirstName.ToUpper.Contains(searchCriteria) Or r.ServiceAddress.Address.ToUpper.Contains(searchCriteria) Or r.Customer.BillingAddress.Address.ToUpper.Contains(searchCriteria)).OrderBy(Function(r) r.Customer.BillingAddress.LastName).ToList
        End If

    End Function

    Private Sub FillList()

        ' ----- Clear the list 
        ListViewRollOffs.Items.Clear()

        ' ----- Get a filtered list of roll offs 
        Dim rollOffList As List(Of CRollOff) = GetRollOffList(TextBoxSearch.Text)

        ' ----- Fill in the list view control 
        For Each obj As CRollOff In rollOffList
            Dim itmX As ListViewItem = ListViewRollOffs.Items.Add(obj.Customer.BillingAddress.FullName)
            itmX.SubItems.Add(String.Format("{0:MM/dd/yyyy}", obj.DateRollOffDelivered))
            itmX.SubItems.Add(obj.ServiceAddress.Address)
            itmX.SubItems.Add(obj.Customer.BillingAddress.Address)
            itmX.Tag = obj.DatabaseID
        Next

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonMakeActive_Click(sender As Object, e As EventArgs) Handles ButtonMakeActive.Click
        If ListViewRollOffs.SelectedItems.Count > 0 Then
            Dim itmX As ListViewItem = ListViewRollOffs.SelectedItems(0)
            Dim databaseID As Integer = DirectCast(itmX.Tag, Integer)
            Dim tempRO As CRollOff = CDataExtender.GetRollOff(databaseID)
            If tempRO IsNot Nothing Then
                tempRO.Active = True
                tempRO.Update()
                FillList()
                ShouldRefresh = True
            End If
        End If
    End Sub

    Private Sub TimerMain_Tick(sender As Object, e As EventArgs) Handles TimerMain.Tick
        ButtonViewBillingHistory.Enabled = (ListViewRollOffs.SelectedItems.Count > 0)
        ButtonRollOffInfo.Enabled = (ListViewRollOffs.SelectedItems.Count > 0)
    End Sub

    Private Sub ButtonViewBillingHistory_Click(sender As Object, e As EventArgs) Handles ButtonViewBillingHistory.Click
        If ListViewRollOffs.SelectedItems.Count > 0 Then
            Dim itmX As ListViewItem = ListViewRollOffs.SelectedItems(0)
            Dim databaseID As Integer = DirectCast(itmX.Tag, Integer)
            Dim tempRO As CRollOff = CDataExtender.GetRollOff(databaseID)
            If tempRO IsNot Nothing Then
                Dim frm As New CreateRollOffForm() With {.SelectedRollOff = tempRO, .SelectedCustomer = tempRO.Customer, .EditMode = True}
                frm.ButtonSave.Enabled = False
                frm.TabControlRollOff.SelectedTab = frm.TabPageBilling
                frm.ShowDialog()
            End If
        End If
    End Sub

    Private Sub ButtonRollOffInfo_Click(sender As Object, e As EventArgs) Handles ButtonRollOffInfo.Click
        If ListViewRollOffs.SelectedItems.Count > 0 Then
            Dim itmX As ListViewItem = ListViewRollOffs.SelectedItems(0)
            Dim databaseID As Integer = DirectCast(itmX.Tag, Integer)
            Dim tempRO As CRollOff = CDataExtender.GetRollOff(databaseID)
            If tempRO IsNot Nothing Then
                Dim frm As New CreateRollOffForm() With {.SelectedRollOff = tempRO, .SelectedCustomer = tempRO.Customer, .EditMode = True}
                frm.ButtonSave.Enabled = False
                frm.TabControlRollOff.SelectedTab = frm.TabPageDelivered
                frm.ShowDialog()
            End If
        End If
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        FillList()
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxSearch.Text = ""
    End Sub

End Class
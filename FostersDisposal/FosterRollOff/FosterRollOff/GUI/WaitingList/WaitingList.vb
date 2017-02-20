Public Class WaitingList

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub WaitingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButtonWaitingList.Checked = True
        CDataExtender.GetMaxWaitingListNumber(CWaitingList.WaitListStatusTypes.OnWaitList)
    End Sub

    Private Sub FillList()

        DataGridViewWaitingList.Rows.Clear()

        Dim waitTimeAverage(3) As Integer
        Dim waitTimeDays(3) As Integer
        Dim waitTimeCounter(3) As Integer

        Dim waitListstatusType As CWaitingList.WaitListStatusTypes = If(RadioButtonWaitingList.Checked, CWaitingList.WaitListStatusTypes.OnWaitList, CWaitingList.WaitListStatusTypes.Cancelled)

        'For Each waitingListObj As CWaitingList In CWaitingList.GetCustomersOnListLocal(waitListstatusType).OrderBy(Function(c) c.CallDate)

        For Each waitingListObj As CWaitingList In CWaitingList.GetCustomersOnList(waitListstatusType).OrderBy(Function(c) c.CallDate).OrderBy(Function(c) c.NumberOnList)
            With DataGridViewWaitingList
                Dim newRowIndex = .Rows.Add()
                .Rows(newRowIndex).Tag = waitingListObj
                .Rows(newRowIndex).Cells("colID").Value = waitingListObj.DatabaseID
                .Rows(newRowIndex).Cells("colNumber").Value = waitingListObj.NumberOnList
                .Rows(newRowIndex).Cells("colCustomer").Value = waitingListObj.Customer.BillingAddress.ReverseFullName
                .Rows(newRowIndex).Cells("colDate").Value = String.Format("{0:MM/dd/yyyy}", waitingListObj.CallDate)
                .Rows(newRowIndex).Cells("colDaysOnList").Value = waitingListObj.DaysOnList.ToString
                .Rows(newRowIndex).Cells("colSize").Value = waitingListObj.RollOffSize.ToString
                .Rows(newRowIndex).Cells("colUse").Value = waitingListObj.RollOffUse
                .Rows(newRowIndex).Cells("colNotes").Value = waitingListObj.Notes

                Select Case waitingListObj.RollOffSize
                    Case 10
                        waitTimeDays(0) += waitingListObj.DaysOnList
                        waitTimeCounter(0) += 1
                    Case 20
                        waitTimeDays(1) += waitingListObj.DaysOnList
                        waitTimeCounter(1) += 1
                    Case 30
                        waitTimeDays(2) += waitingListObj.DaysOnList
                        waitTimeCounter(2) += 1
                End Select

            End With
        Next

        ' ----- Set the button depending on what is selected 
        If waitListstatusType = CWaitingList.WaitListStatusTypes.Cancelled Then
            ButtonCustomerCancelled.Text = "Convert to Active"
        Else
            ButtonCustomerCancelled.Text = "Customer Cancelled"
        End If

    End Sub

    Private Sub ButtonAddToWaitingList_Click(sender As Object, e As EventArgs) Handles ButtonAddToWaitingList.Click
        Dim frm As New AddToWaitingList
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            FillList()
        End If
    End Sub

    Private Sub ButtonEditItem_Click(sender As Object, e As EventArgs) Handles ButtonEditItem.Click

        ' ----- Call the screen 
        Dim frm As New AddToWaitingList
        frm.EditMode = True
        frm.EditedWaitingListObject = DirectCast(DataGridViewWaitingList.CurrentRow.Tag, CWaitingList)

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            FillList()
        End If

    End Sub

    Private Sub TimerMain_Tick(sender As Object, e As EventArgs) Handles TimerMain.Tick
        ButtonEditItem.Enabled = (DataGridViewWaitingList.SelectedRows.Count = 1)
        ButtonRemoveFromWaitingList.Enabled = (DataGridViewWaitingList.SelectedRows.Count = 1)
        ButtonCustomerCancelled.Enabled = (DataGridViewWaitingList.SelectedRows.Count = 1)
        ButtonConvertToRollOff.Enabled = (DataGridViewWaitingList.SelectedRows.Count = 1)
    End Sub

    Private Sub ButtonRemoveFromWaitingList_Click(sender As Object, e As EventArgs) Handles ButtonRemoveFromWaitingList.Click

        ' ---- First confirm ... then delete 
        If MessageBox.Show("Are you sure you would like to remove this entry from the waiting list?  Once confirmed, the process cannot be undone.", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Dim tempObj As CWaitingList = DirectCast(DataGridViewWaitingList.CurrentRow.Tag, CWaitingList)
            If Not tempObj Is Nothing Then
                tempObj.Delete()
                FillList()
            End If
        End If

    End Sub

    Private Sub ButtonCustomerCancelled_Click(sender As Object, e As EventArgs) Handles ButtonCustomerCancelled.Click

        If RadioButtonWaitingList.Checked Then
            If MessageBox.Show("Are you sure you would like to mark this item as cancelled?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Dim tempObj As CWaitingList = DirectCast(DataGridViewWaitingList.CurrentRow.Tag, CWaitingList)
                If Not tempObj Is Nothing Then
                    tempObj.CustomerCancelled()
                    FillList()
                End If
            End If
        Else
            Dim tempObj As CWaitingList = DirectCast(DataGridViewWaitingList.CurrentRow.Tag, CWaitingList)
            If Not tempObj Is Nothing Then
                tempObj.CustomerReOpened()
                FillList()
            End If
        End If

    End Sub

    Private Sub RadioButtonWaitingList_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonWaitingList.CheckedChanged, RadioButtonCancelList.CheckedChanged
        FillList()
    End Sub

    Private Sub ButtonConvertToRollOff_Click(sender As Object, e As EventArgs) Handles ButtonConvertToRollOff.Click

        ' ----- Get a pointer to the waiting list object 
        Dim waitingListObj As CWaitingList = DirectCast(DataGridViewWaitingList.CurrentRow.Tag, CWaitingList)

        ' ----- Make sure we have a valid object 
        If waitingListObj Is Nothing Then Exit Sub

        ' ----- Pull the customer from the waiting list 
        Dim roCustomer As CCustomer = waitingListObj.Customer

        ' ----- If we are OK ... go forward 
        If roCustomer IsNot Nothing Then

            Dim frm As New CreateRollOffForm
            frm.EditMode = False
            frm.FromCustomerForm = True
            frm.SelectedCustomer = roCustomer
            frm.ServiceAddress = waitingListObj.ServiceAddress
            frm.DateRollOffDelivered = Date.Today
            frm.SizeFromWaitingList = waitingListObj.RollOffSize
            frm.TextBoxDumpingFee.Text = String.Format ("{0:f2}", DumpingFee.GetDumpingFee ()) '  "70.50"
            frm.TextBoxNotes.Text = waitingListObj.RollOffUse & ControlChars.CrLf & waitingListObj.Notes

            ' ----- Show the roll off and if it comes back as saved ... mark the roll off 
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                waitingListObj.CustomerMovedToRolloff()
                FillList()
            End If

        End If

    End Sub

    Private Sub ButtonPrint_Click(sender As Object, e As EventArgs) Handles ButtonPrint.Click
        Dim frm As New PrintedWaitingList
        frm.Show()
    End Sub

    Private Sub ButtonMoveUp_Click(sender As Object, e As EventArgs) Handles ButtonMoveUp.Click

        ' ----- Get the selected object 
        Dim selectedObj As CWaitingList = DirectCast(DataGridViewWaitingList.CurrentRow.Tag, CWaitingList)
        If selectedObj IsNot Nothing Then
            Dim rowIndex As Integer = DataGridViewWaitingList.CurrentRow.Index
            If rowIndex > 0 Then
                Dim swapObj As CWaitingList = DirectCast(DataGridViewWaitingList.Rows(rowIndex - 1).Tag, CWaitingList)
                If swapObj IsNot Nothing Then
                    Dim saveNumber As Integer = selectedObj.NumberOnList
                    selectedObj.NumberOnList = swapObj.NumberOnList
                    swapObj.NumberOnList = saveNumber
                    selectedObj.Update()
                    swapObj.Update()
                    FillList()
                End If
            End If
        End If

    End Sub

    Private Sub ButtonMoveDown_Click(sender As Object, e As EventArgs) Handles ButtonMoveDown.Click

        ' ----- Get the selected object 
        Dim selectedObj As CWaitingList = DirectCast(DataGridViewWaitingList.CurrentRow.Tag, CWaitingList)
        If selectedObj IsNot Nothing Then
            Dim rowIndex As Integer = DataGridViewWaitingList.CurrentRow.Index
            If (rowIndex + 1 < DataGridViewWaitingList.Rows.Count) Then
                Dim swapObj As CWaitingList = DirectCast(DataGridViewWaitingList.Rows(rowIndex + 1).Tag, CWaitingList)
                If swapObj IsNot Nothing Then
                    Dim saveNumber As Integer = selectedObj.NumberOnList
                    selectedObj.NumberOnList = swapObj.NumberOnList
                    swapObj.NumberOnList = saveNumber
                    selectedObj.Update()
                    swapObj.Update()
                    FillList()
                End If
            End If
        End If

    End Sub

    Private Sub ButtonMoveToBottom_Click(sender As Object, e As EventArgs) Handles ButtonMoveToBottom.Click

        If MessageBox.Show("You are about to move the selected customer to the bottom of the waiting list.  Once confirmed, this process cannot be undone.  Do you want to continue?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Dim selectedObj As CWaitingList = DirectCast(DataGridViewWaitingList.CurrentRow.Tag, CWaitingList)
            If selectedObj IsNot Nothing Then
                selectedObj.NumberOnList = CDataExtender.GetMaxWaitingListNumber(CWaitingList.WaitListStatusTypes.OnWaitList) + 1
                selectedObj.Update()
                FillList()
            End If
        End If

    End Sub

End Class
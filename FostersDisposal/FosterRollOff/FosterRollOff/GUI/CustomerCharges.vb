Public Class CustomerCharges

    Public Property SelectedCustomer As CCustomer = Nothing
    Public Property SelectedRollOff As CRollOff = Nothing

    Private Sub FillList()

        DataGridViewCustomerCharges.Rows.Clear()

        For Each chrObj As CCharges In CCharges.GetChargeList(SelectedRollOff)
            With DataGridViewCustomerCharges
                Dim newRowIndex As Integer = .Rows.Add

                .Rows(newRowIndex).Cells("colID").Value = chrObj.DatabaseID
                .Rows(newRowIndex).Cells("colChargeType").Value = chrObj.ChargeType

                ' ----- Only show this date if the charge has already been billed 
                If chrObj.HasBeenBilled Then
                    .Rows(newRowIndex).Cells("colBilledOn").Value = chrObj.BilledDate
                End If

                .Rows(newRowIndex).Cells("colDescription").Value = chrObj.Description
                .Rows(newRowIndex).Cells("colDate").Value = String.Format("{0:MM/dd/yyyy}", chrObj.ChargeDateBegin)
                .Rows(newRowIndex).Cells("colUnit").Value = String.Format("{0:f3}", chrObj.Unit)
                .Rows(newRowIndex).Cells("colRate").Value = String.Format("{0:f2}", chrObj.Rate)
                .Rows(newRowIndex).Cells("colTotal").Value = String.Format("{0:f2}", chrObj.Total)
            End With
        Next

    End Sub

    Private Sub CustomerCharges_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelHeader.Text = SelectedCustomer.BillingAddress.FirstName & " " & SelectedCustomer.BillingAddress.LastName
        FillList()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        For Each dgr As DataGridViewRow In DataGridViewCustomerCharges.Rows

            Dim saveObj As New CCharges
            Dim newRecord As Boolean = False

            If dgr.Cells("colID").Value Is Nothing Then
                'saveObj.AssignID()
                newRecord = True
            Else
                saveObj.DatabaseID = dgr.Cells("colID").Value
            End If

            saveObj.ChargeType = dgr.Cells("colChargeType").Value

            ' ----- Would rather not save the rental charge here but this may change 
            If saveObj.ChargeType <> CCharges.ChargeTypeListing.Rental Then
                saveObj.Description = dgr.Cells("colDescription").Value
                saveObj.ChargeDateBegin = dgr.Cells("colDate").Value
                saveObj.ChargeDateEnd = saveObj.ChargeDateBegin
                saveObj.Unit = dgr.Cells("colUnit").Value
                saveObj.Rate = dgr.Cells("colRate").Value
                saveObj.Total = dgr.Cells("colTotal").Value
                saveObj.RollOffObject = SelectedRollOff

                ' ----- Save the billed on date 
                If Not dgr.Cells("colBilledOn").Value Is Nothing Then
                    If dgr.Cells("colBilledOn").Value.ToString <> "" AndAlso IsDate(dgr.Cells("colBilledOn").Value.ToString) Then
                        saveObj.HasBeenBilled = True
                        saveObj.BilledDate = dgr.Cells("colBilledOn").Value
                    End If
                End If

                If newRecord Then
                    saveObj.Save()
                Else
                    saveObj.Update()
                End If
            End If

        Next

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub DataGridViewCustomerCharges_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCustomerCharges.CellEndEdit

        If DataGridViewCustomerCharges.Columns(e.ColumnIndex).Name = "colUnit" Or DataGridViewCustomerCharges.Columns(e.ColumnIndex).Name = "colRate" Then

            Dim unitAmount As Double = 0.0
            Dim rateAmount As Double = 0.0

            Try
                If Double.TryParse(DataGridViewCustomerCharges.Rows(e.RowIndex).Cells("colUnit").Value.ToString, unitAmount) Then
                    If Double.TryParse(DataGridViewCustomerCharges.Rows(e.RowIndex).Cells("colRate").Value.ToString, rateAmount) Then
                        DataGridViewCustomerCharges.Rows(e.RowIndex).Cells("colTotal").Value = String.Format("{0:f2}", unitAmount * rateAmount)
                    End If
                End If
            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click

        If DataGridViewCustomerCharges.SelectedRows.Count > 0 Then

            If MessageBox.Show("Are you sure you would like to delete the selected charge?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                Dim selectedDGR As DataGridViewRow = DataGridViewCustomerCharges.SelectedRows(0)

                Dim tempCharge As CCharges = CCharges.FindCharge(selectedDGR.Cells("colID").Value)

                If tempCharge IsNot Nothing Then
                    If tempCharge.HasBeenBilled Then
                        If MessageBox.Show(String.Format("It is highly recommended that you do not delete this charge because it has already been billed out to the customer on {0:MM/dd/yyyy}.  Are you sure you would like to delete it?", tempCharge.BilledDate), "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            tempCharge.Delete()
                            FillList()
                        Else
                            Exit Sub
                        End If
                    Else
                        tempCharge.Delete()
                        FillList()
                    End If
                End If

            End If

        End If

    End Sub

    Private Sub ButtonAddDumpingService_Click(sender As Object, e As EventArgs) Handles ButtonAddDumpingService.Click, ButtonAddDumpingOnly.Click, ButtonAddMiscCharge.Click

        Dim tempButton As Button = DirectCast(sender, Button)

        With DataGridViewCustomerCharges

            If tempButton.Name = "ButtonAddMiscCharge" Then

                Dim newMiscRowIndex As Integer = .Rows.Add
                .Rows(newMiscRowIndex).Cells("colChargeType").Value = CCharges.ChargeTypeListing.Miscellaneous
                .Rows(newMiscRowIndex).Cells("colDescription").Value = ""
                .Rows(newMiscRowIndex).Cells("colDate").Value = String.Format("{0:MM/dd/yyyy}", Date.Today)

                ' ----- Move to the unti cell
                .CurrentCell = .Rows(newMiscRowIndex).Cells("colDescription")
                .BeginEdit(True)

            Else

                Dim newRowIndex As Integer = .Rows.Add
                .Rows(newRowIndex).Cells("colChargeType").Value = CCharges.ChargeTypeListing.Dumping
                .Rows(newRowIndex).Cells("colDescription").Value = "Dumping Fee"
                .Rows(newRowIndex).Cells("colDate").Value = String.Format("{0:MM/dd/yyyy}", Date.Today)
                .Rows(newRowIndex).Cells("colRate").Value = String.Format("{0:f2}", SelectedRollOff.DumpingFee)

                If tempButton.Name = "ButtonAddDumpingService" Then
                    Dim newServiceIndex As Integer = .Rows.Add
                    .Rows(newServiceIndex).Cells("colChargeType").Value = CCharges.ChargeTypeListing.Service
                    .Rows(newServiceIndex).Cells("colDescription").Value = "Service Charge"
                    .Rows(newServiceIndex).Cells("colDate").Value = String.Format("{0:MM/dd/yyyy}", Date.Today)
                    .Rows(newServiceIndex).Cells("colUnit").Value = "1"
                    .Rows(newServiceIndex).Cells("colRate").Value = String.Format("{0:f2}", SelectedRollOff.ServiceCharge)
                    .Rows(newServiceIndex).Cells("colTotal").Value = String.Format("{0:f2}", SelectedRollOff.ServiceCharge)
                End If

                ' ----- Move to the unti cell
                .CurrentCell = .Rows(newRowIndex).Cells("colUnit")
                .BeginEdit(True)

            End If

        End With

    End Sub

End Class
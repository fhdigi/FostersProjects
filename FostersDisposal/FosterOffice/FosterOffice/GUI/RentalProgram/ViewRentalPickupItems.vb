Public Class ViewRentalPickupItems

    Public Property AccountNumber As Integer = 0
    Public Property CustomerName As String = ""

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub GetCustomerData()

        DataGridViewRentals.Rows.Clear()

        ' ----- Set the customer name 
        LabelCustomerName.Text = CustomerName

        ' ----- Use the dictionary to find out the customers on this date 
        Dim newList As List(Of PickupTransaction.RentalRouteData) = PickupTransaction.RentalRouteData.GetCustomerPickupData(My.Settings.DatabaseLocation, AccountNumber)

        For Each obj As PickupTransaction.RentalRouteData In newList
            With DataGridViewRentals
                Dim newRow As Integer = .Rows.Add()
                .Rows(newRow).Cells(0).Value = obj.DateOfPickup.ToShortDateString
                .Rows(newRow).Cells(1).Value = obj.Trash
                .Rows(newRow).Cells(2).Value = obj.Recycle
                .Rows(newRow).Cells(3).Value = obj.Cardboard
                .Rows(newRow).Cells(4).Value = obj.Cart
                .Rows(newRow).Cells(5).Value = obj.RollOff
                .Rows(newRow).Cells(6).Value = If(obj.MiscCharge.ToString = "", "0.00", String.Format("{0:f2}", obj.MiscCharge))
                .Rows(newRow).Cells(7).Value = obj.Notes
                .Rows(newRow).Cells(8).Value = obj.ID
            End With
        Next

    End Sub

    Private Sub ViewRentalPickupItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetCustomerData()
    End Sub

    Private Sub ButtonDeleteSelectedItem_Click(sender As Object, e As EventArgs) Handles ButtonDeleteSelectedItem.Click

        If MessageBox.Show("Are you sure you would like to delete the selected item?  Once confirmed, this process cannot be undone.", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

            Dim currentDGR As DataGridViewRow = DataGridViewRentals.CurrentRow

            If Not currentDGR Is Nothing Then
                Dim itemPickID As Integer = currentDGR.Cells("colID").Value
                PickupTransaction.RentalRouteData.RemovePickupItem(My.Settings.DatabaseLocation, itemPickID)
                GetCustomerData()
            End If

        End If

    End Sub

    Private Sub DataGridViewRentals_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewRentals.CellEndEdit

        ' ----- Get the control and the current row 
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)
        Dim currentRow As DataGridViewRow = dgv.Rows(e.RowIndex)

        ' ----- Get the customer number 
        Dim dataID As Integer = currentRow.Cells("colID").Value


        Dim newPUDataObj As New PickupTransaction.RentalRouteData
        newPUDataObj.MiscCharge = 0.0

        With newPUDataObj
            .ID = dataID
            .DateOfPickup = currentRow.Cells(0).Value
            .Trash = currentRow.Cells(1).Value
            .Recycle = currentRow.Cells(2).Value
            .Cardboard = currentRow.Cells(3).Value
            .Cart = currentRow.Cells(4).Value
            .RollOff = currentRow.Cells(5).Value

            If IsNumeric(currentRow.Cells(6).Value) Then
                Double.TryParse(currentRow.Cells(6).Value.ToString, .MiscCharge)
            End If

            .Notes = currentRow.Cells(7).Value
            .UpdatePickupDataViaID(My.Settings.DatabaseLocation)
        End With

    End Sub

End Class
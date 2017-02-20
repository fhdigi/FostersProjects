Public Class EditPickupItems

    Public Class CPickup
        Public Property DatabaseID As Integer = 0
        Public Property PickupDate As Date = Nothing
        Public Property GarbageBags As Integer = 0
        Public Property AdditionalItem As String = ""
        Public Property ItemPrice As Double = 0.0
    End Class

    Public Property CustomerNumber As Integer = 0

    Private Sub FillData()

        ' ----- Fill in the customer name 
        ' ---> COMMENTED OUT 17-Jan-2016 ---> LabelPerson.Text = ProgramDataObject.CustomerDictionary(CustomerNumber).FullName

        ' ----- Now call database direct
        LabelPerson.Text = PickupTransaction.Customer.GetCustomerName (My.Settings .DatabaseLocation , CustomerNumber )

        ' ----- This will fill in the data grid view 
        Dim collectionList As List(Of PickupTransaction.CollectionRecord) = PickupTransaction.CollectionRecord.RetrieveCollectedItems(My.Settings.DatabaseLocation, _CustomerNumber)

        ' ----- Fill in the data grid 
        DataGridViewItems.DataSource = (From i In collectionList
                                       Order By i.DateCollected Descending, i.ItemID
                                       Select New CPickup With
                                              {
                                                  .DatabaseID = i.ID,
                                                  .PickupDate = i.DateCollected.ToShortDateString,
                                                  .GarbageBags = IIf(i.ItemID = 1, i.Quantity, 0),
                                                  .AdditionalItem = IIf(i.ItemID > 1, i.ItemDescription, ""),
                                                  .ItemPrice = IIf(i.ItemID > 1, i.ItemPrice, 0.0)
                                              }).ToList

        ' ----- Now style the rows 
        For Each dr As DataGridViewRow In DataGridViewItems.Rows

            If dr.Cells("colGarbageBags").Value > 0 Then
                dr.Cells("colAdditionalItems").ReadOnly = True
                dr.Cells("colItemPrice").ReadOnly = True
                dr.Cells("colAdditionalItems").Style.BackColor = Color.LightGray
                dr.Cells("colItemPrice").Style.BackColor = Color.LightGray
            Else
                dr.Cells("colGarbageBags").ReadOnly = True
                dr.Cells("colGarbageBags").Style.BackColor = Color.LightGray
            End If

        Next

    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub EditPickupItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillData()
    End Sub

    Private Sub DataGridViewItems_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewItems.CellEndEdit

        ' ----- Get the database ID
        Dim dbID As Integer = DataGridViewItems.Rows(e.RowIndex).Cells("DatabaseID").Value

        ' ----- Get the values from the cells and update the record 
        Dim updateObj As New PickupTransaction.CollectionRecord

        ' ----- Get the values from the grid 
        With DataGridViewItems.Rows(e.RowIndex)
            updateObj.ID = dbID
            Date.TryParse(.Cells("colPickupDate").Value.ToString, updateObj.DateCollected)
            Integer.TryParse(.Cells("colGarbageBags").Value.ToString, updateObj.Quantity)
            updateObj.ItemDescription = .Cells("colAdditionalItems").Value
            Double.TryParse(.Cells("colItemPrice").Value.ToString, updateObj.ItemPrice)
        End With

        ' ----- Save the data 
        PickupTransaction.CollectionRecord.UpdateCollectedItem(My.Settings.DatabaseLocation, updateObj)

    End Sub

    Private Sub ButtonDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDeleteItem.Click

        ' ----- If there is nothing selected, then get out 
        If DataGridViewItems.SelectedRows.Count = 0 Then Exit Sub

        ' ----- Make sure they want to delete the row 
        If MessageBox.Show("Are you sure you would like to delete the selected record?  Once deleted, the process cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

            ' ----- Get the current row 
            Dim curentRow As DataGridViewRow = DataGridViewItems.SelectedRows(0)

            ' ----- Get the ID
            Dim dbID As Integer = curentRow.Cells("DatabaseID").Value

            ' ----- Delete it 
            PickupTransaction.CollectionRecord.RemoveCollectedItemByID(My.Settings.DatabaseLocation, dbID)

            ' ----- Refresh the grid 
            FillData()

        End If

    End Sub

    Private Sub ButtonAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAddItem.Click

        Dim frm As New AddNewItem
        frm.CustomerNumber = _CustomerNumber
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            FillData()
        End If

    End Sub

End Class
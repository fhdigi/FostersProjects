Public Class PriceList

    Private Sub PriceList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridControlItemsCollected.DataSource = ProgramDataObject.ReturnItemList()
    End Sub

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click

        ' ----- Save the data 
        Dim tempList As List(Of PickupTransaction.ItemsCollected) = DirectCast(GridControlItemsCollected.DataSource, List(Of PickupTransaction.ItemsCollected))
        PickupTransaction.ItemsCollected.SaveItemsCollectedFile(tempList)

        ' ----- Close the form 
        Me.Close()

    End Sub

    Private Sub ButtonAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAddNewItem.Click

    End Sub

End Class
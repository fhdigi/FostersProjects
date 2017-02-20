Public Class AddNewItem

    Public Property CustomerNumber As Integer = 0

    Private Sub AddNewItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' ----- Fill in the customer name 
        LabelCustomer.Text = ProgramDataObject.CustomerDictionary(CustomerNumber).FullName

        ' ------ Fill in the combo box of items 
        ComboBoxAdditionalItems.DataSource = (From i In ProgramDataObject.ItemsCollectedObjectList Order By i.ItemDescription Select i).ToArray
        ComboBoxAdditionalItems.DisplayMember = "ItemDescription"
        ComboBoxAdditionalItems.ValueMember = "ID"

        ' ----- Update the radio buttons 
        RadioButtonGarbageBag.Checked = True
        UpdateControls()

    End Sub

    Private Sub RadioButtonGarbageBag_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButtonGarbageBag.CheckedChanged
        UpdateControls()
    End Sub

    Private Sub UpdateControls()
        TextBoxGarbageBags.Enabled = RadioButtonGarbageBag.Checked
        ComboBoxAdditionalItems.Enabled = RadioButtonAdditionalItem.Checked
        TextBoxItemPrice.Enabled = RadioButtonAdditionalItem.Checked
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click

        ' ----- Create a new object 
        Dim crObj As New PickupTransaction.CollectionRecord
        crObj.CustomerID = _CustomerNumber
        crObj.DateCollected = DateTimePickerEntryDate.Value.ToShortDateString

        If RadioButtonGarbageBag.Checked Then

            crObj.ItemID = 1
            Integer.TryParse(TextBoxGarbageBags.Text, crObj.Quantity)

        Else

            ' ----- Get the item ID
            Dim itemObj As PickupTransaction.ItemsCollected = DirectCast(ComboBoxAdditionalItems.SelectedItem, PickupTransaction.ItemsCollected)

            If Not itemObj Is Nothing Then
                crObj.ItemID = itemObj.ID
                crObj.ItemDescription = itemObj.ItemDescription
                Double.TryParse(TextBoxItemPrice.Text, crObj.ItemPrice)
            End If

        End If

        ' ----- Distinguish how the entry was entered 
        crObj.RouteDescription = "Manual Entry"

        ' ----- Save the information to the database 
        PickupTransaction.CollectionRecord.SaveCollectedItemUpload(My.Settings.DatabaseLocation, crObj)

        ' ----- Close the scree n
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ComboBoxAdditionalItems_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxAdditionalItems.SelectedIndexChanged

        ' ----- Get the item ID
        Dim itemObj As PickupTransaction.ItemsCollected = DirectCast(ComboBoxAdditionalItems.SelectedItem, PickupTransaction.ItemsCollected)

        If Not itemObj Is Nothing Then

            ' ----- Fill in the price 
            Try
                TextBoxItemPrice.Text = String.Format("{0:f2}", ProgramDataObject.ItemsCollectedPriceDictionary(itemObj.ID))
            Catch ex As Exception
            End Try

        End If

    End Sub

End Class
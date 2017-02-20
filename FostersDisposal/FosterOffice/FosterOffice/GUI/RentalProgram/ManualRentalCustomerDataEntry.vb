Public Class ManualRentalCustomerDataEntry

    Private Sub LoadCustomers()

        ' ----- this is a list of all rental customers regardless of route 
        Dim customerList As List(Of PickupTransaction.RentalCustomer.CRentalCustomerList) = PickupTransaction.RentalCustomer.ReturnMainRentalList(My.Settings.DatabaseLocation, False)

        ' ----- Add this list to the combobox 
        For Each obj As PickupTransaction.RentalCustomer.CRentalCustomerList In customerList
            ComboBoxCustomerList.Items.Add(obj)
        Next

    End Sub

    Private Sub SaveData()

        ' ----- Get the selected object 
        Dim selCustomer As PickupTransaction.RentalCustomer.CRentalCustomerList = ComboBoxCustomerList.SelectedItem

        Dim pickupObj As PickupTransaction.RentalRouteData = New PickupTransaction.RentalRouteData

        pickupObj.CustomerNumber = selCustomer.AccountNumber
        pickupObj.DateOfPickup = DateTimePickupDate.Value.ToShortDateString
        pickupObj.Notes = TextBoxNotes.Text
        pickupObj.Trash = TextBoxTrash.Text
        pickupObj.Recycle = TextBoxRecycle.Text
        pickupObj.Cardboard = TextBoxCardBoard.Text
        pickupObj.Cart = TextBoxCart.Text
        pickupObj.RollOff = TextBoxRollOff.Text

        If IsNumeric(TextBoxMiscCharge.Text) Then
            pickupObj.MiscCharge = Convert.ToDouble(TextBoxMiscCharge.Text)
        End If

        pickupObj.SaveManualData(My.Settings.DatabaseLocation)

    End Sub

    Private Sub ButtonSaveAndNew_Click(sender As Object, e As EventArgs) Handles ButtonSaveAndNew.Click

        ' ----- Save the pickup data 
        SaveData()

        ' ----- Clear out the textboxes 
        TextBoxCardBoard.Text = ""
        TextBoxCart.Text = ""
        TextBoxNotes.Text = ""
        TextBoxRecycle.Text = ""
        TextBoxTrash.Text = ""
        TextBoxRollOff.Text = ""
        TextBoxMiscCharge.Text = "0.00"

        ' ----- Set the focus back to the customer drop down
        ComboBoxCustomerList.Focus()

    End Sub

    Private Sub ButtonSaveAndClose_Click(sender As Object, e As EventArgs) Handles ButtonSaveAndClose.Click
        SaveData()
        Me.Close()
    End Sub

    Private Sub ManualRentalCustomerDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()

        TextBoxMiscCharge.Text = "0.00"

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

End Class
Public Class RollOffServiceEdit

    Public RollOffObj As CRollOff = Nothing

    Private Sub RollOffServiceEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBoxAddress.Text = RollOffObj.ServiceAddress.Address
        TextBoxCity.Text = RollOffObj.ServiceAddress.City
        TextBoxState.Text = RollOffObj.ServiceAddress.State
        TextBoxZipCode.Text = RollOffObj.ServiceAddress.ZipCode

        ' ----- Added 22-Jun-2016
        CheckBoxUseRollingBillingInfo.Checked = RollOffObj.UseRollOffBillingAddress
        TextBoxRollOffBillingName.Text = RollOffObj.RollOffBillingName

        if not RollOffObj.RollOffBillingAddress Is Nothing
            TextBoxRollOffBillingAddress.Text = RollOffObj.RollOffBillingAddress.Address
            TextBoxRollOffBillingCity.Text = RollOffObj.RollOffBillingAddress.City
            TextBoxRollOffBillingState.Text = RollOffObj.RollOffBillingAddress.State
            TextBoxRollOffBillingZipCode.Text = RollOffObj.RollOffBillingAddress.ZipCode
        End If

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Close()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        
        ' ------ Fill in the information 
        RollOffObj.ServiceAddress.Address = TextBoxAddress.Text
        RollOffObj.ServiceAddress.City = TextBoxCity.Text
        RollOffObj.ServiceAddress.State = TextBoxState.Text
        RollOffObj.ServiceAddress.ZipCode = TextBoxZipCode.Text

        ' ------ New information added 22-Jun-2016
        RollOffObj.UseRollOffBillingAddress = CheckBoxUseRollingBillingInfo.Checked

        If RollOffObj.UseRollOffBillingAddress Then
            RollOffObj.RollOffBillingAddress = New CAddressBlock()
            RollOffObj.RollOffBillingName = TextBoxRollOffBillingName.Text
            RollOffObj.RollOffBillingAddress.Address = TextBoxRollOffBillingAddress.Text
            RollOffObj.RollOffBillingAddress.City = TextBoxRollOffBillingCity.Text
            RollOffObj.RollOffBillingAddress.State = TextBoxRollOffBillingState.Text
            RollOffObj.RollOffBillingAddress.ZipCode = TextBoxRollOffBillingZipCode.Text
        End If

        ' ------ Close the screen 
        DialogResult = Windows.Forms.DialogResult.OK
        Close()

    End Sub

    Private Sub CheckBoxUseRollingBillingInfo_CheckedChanged(sender As Object, e As EventArgs) _
        Handles CheckBoxUseRollingBillingInfo.CheckedChanged
        GroupBoxRollOffBilling.Enabled = CheckBoxUseRollingBillingInfo.Checked
    End Sub

End Class
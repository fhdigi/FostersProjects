Public Class SetupForm

    Private Sub ButtonBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBrowse.Click
        If OpenFileDialogDB.ShowDialog() = Windows.Forms.DialogResult.OK Then
            TextBoxDatabaseLocation.Text = OpenFileDialogDB.FileName
        End If
    End Sub

    Private Sub ButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click

        ' ----- Save the location 
        My.Settings.DatabaseLocation = TextBoxDatabaseLocation.Text
        My.Settings.Save()

        ' ----- Close the form 
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click

        ' ----- Just get out of the screen 
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub SetupForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' ------ Default to what is in the registry already 
        TextBoxDatabaseLocation.Text = My.Settings.DatabaseLocation

    End Sub

End Class
Public Class UploadWarning

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ButtonProceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonProceed.Click
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub TextBoxProceed_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxProceed.TextChanged
        If TextBoxProceed.Text = "PROCEED" Then
            ButtonProceed.Enabled = True
        Else
            ButtonProceed.Enabled = False
        End If
    End Sub

End Class
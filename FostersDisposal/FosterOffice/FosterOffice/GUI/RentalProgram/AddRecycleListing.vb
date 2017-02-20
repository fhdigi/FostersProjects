Public Class AddRecycleListing

    Public Property RecycleListingName As String = ""

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        RecycleListingName = TextBoxListingName.Text
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        RecycleListingName = ""
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AddRecycleListing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxListingName.Text = RecycleListingName
    End Sub

End Class
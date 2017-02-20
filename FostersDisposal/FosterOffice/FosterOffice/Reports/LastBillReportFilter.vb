Public Class LastBillReportFilter

    Public Property NumberOfMonths As Integer = 3

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub ButtonRunReport_Click(sender As Object, e As EventArgs) Handles ButtonRunReport.Click
        NumberOfMonths = Convert.ToInt32(TextBoxMonths.Text)
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub LastBillReportFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxMonths.Text = NumberOfMonths.ToString
    End Sub

End Class
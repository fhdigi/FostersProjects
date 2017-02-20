Public Class CustomerHistoryForm 

    Public Property CustomerNumber As Integer = 0

    Private CustomerHistoryReport As New CustomerHistory

    Private Sub CustomerHistoryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' ----- Set the year 
        For iYear As Integer = DateTime.Now.Year To DateTime.Now.Year - 5 Step -1
            ComboBoxYear.Items.Add(iYear.ToString)
        Next
        ComboBoxYear.SelectedIndex = 0

    End Sub

    Private Sub RefreshReport()

        ' ----- Set up the report 
        CustomerHistoryReport.CustomerNumber = _CustomerNumber
        Integer.TryParse(ComboBoxYear.Text, CustomerHistoryReport.YearToReview)
        CustomerHistoryReport.UpdateGrid()
        PrintControlHistory.PrintingSystem = CustomerHistoryReport.PrintingSystem
        CustomerHistoryReport.CreateDocument()

    End Sub

    Private Sub SimpleButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ComboBoxYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxYear.SelectedIndexChanged
        RefreshReport()
    End Sub

End Class
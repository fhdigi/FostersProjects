Public Class PrintedWaitingList

    Private Sub PrintedWaitingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rpt As New WaitingListPrintedReport

        Dim wlDataSource As List(Of CWaitingList) = CWaitingList.GetCustomersOnList(CWaitingList.WaitListStatusTypes.OnWaitList)
        rpt.BindingSourceWaitingList.DataSource = wlDataSource
        rpt.XrLabelTotalNumber.Text = String.Format("Total Number People on List : {0}", wlDataSource.Count)
        rpt.CreateDocument()

        DocumentViewerWaitingList.DocumentSource = rpt

    End Sub

End Class
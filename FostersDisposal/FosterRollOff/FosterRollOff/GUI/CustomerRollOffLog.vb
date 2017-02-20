Public Class CustomerRollOffLog

    Public rollOffLogReport As CustomerHistoryReport

    Private Sub CustomerRollOffLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        DocumentViewerROLog.DocumentSource = rollOffLogReport

    End Sub

End Class
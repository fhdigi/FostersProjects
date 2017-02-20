Public Class CustomerBillingLog

    Public passedRO As CRollOff = Nothing

    Private Sub CustomerBillingLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' ----- Get the last bill date for this roll off 
        Dim billsList As List(Of CBillingObject) = CDataExtender.ReturnBillsList(passedRO).OrderByDescending(Function(t) t.BillingDate).ToList

        If billsList.Count > 0 Then

            Dim lastBillDate As Date = billsList(0).BillingDate
            Dim rpt As New CustomerBillLogReport
            rpt.BindingSource1.DataSource = passedRO.GetRollOffBillInformation(lastBillDate).OrderBy(Function(t) t.TransactionDate).ToList
            rpt.CreateDocument()
            DocumentViewerBillLog.DocumentSource = rpt

        End If

    End Sub

End Class
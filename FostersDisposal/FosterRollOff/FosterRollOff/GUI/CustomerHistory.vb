Public Class CustomerHistory

    Public Property SelectedCustomer As CCustomer = Nothing
    Public Property SelectedRollOff As CRollOff = Nothing

    Public Property RollOffHistoryList As List(Of CRollOffHistory)

    Private Sub CustomerHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelHeader.Text = SelectedCustomer.BillingAddress.FirstName & " " & SelectedCustomer.BillingAddress.LastName
        FillGrid()
    End Sub

    Private Sub FillGrid()

        DataGridViewHistory.Rows.Clear()
        Dim runningBalance As Double = 0.0

        RollOffHistoryList = New List(Of CRollOffHistory)
        RollOffHistoryList = SelectedRollOff.GetRollOffHistory(0, Nothing).OrderBy(Function(h) h.TransactionDate).ToList

        For Each itmX As CRollOffHistory In RollOffHistoryList
            With DataGridViewHistory
                Dim newRowIndex As Integer = .Rows.Add
                .Rows(newRowIndex).Cells("colDate").Value = itmX.TransactionDate
                .Rows(newRowIndex).Cells("colDescription").Value = itmX.Description
                .Rows(newRowIndex).Cells("colCredit").Value = If(itmX.Credit <> 0.0, itmX.Credit, "")
                .Rows(newRowIndex).Cells("colDebit").Value = If(itmX.Debit <> 0.0, itmX.Debit, "")
                runningBalance -= itmX.Credit
                runningBalance += itmX.Debit
                .Rows(newRowIndex).Cells("colTotal").Value = runningBalance
                itmX.RunningTotal = runningBalance
            End With
        Next

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonPrint_Click(sender As Object, e As EventArgs) Handles ButtonPrint.Click

        With CustomerRollOffLog

            CustomerRollOffLog.rollOffLogReport = New CustomerHistoryReport

            CustomerRollOffLog.rollOffLogReport.XrLabelCustomer.Text = SelectedCustomer.BillingAddress.FirstName & " " & SelectedCustomer.BillingAddress.LastName
            CustomerRollOffLog.rollOffLogReport.XrLabelServiceAddress.Text = SelectedRollOff.ServiceAddress.Address
            CustomerRollOffLog.rollOffLogReport.XrLabelServiceCSZ.Text = SelectedRollOff.ServiceAddress.CSZ
            CustomerRollOffLog.rollOffLogReport.XrLabelBillingAddress.Text = SelectedRollOff.Customer.BillingAddress.Address
            CustomerRollOffLog.rollOffLogReport.XrLabelBillingCSZ.Text = SelectedRollOff.Customer.BillingAddress.CSZ

            CustomerRollOffLog.rollOffLogReport.BindingSourceROHistory.DataSource = RollOffHistoryList
            CustomerRollOffLog.rollOffLogReport.CreateDocument()

            .Show(Me)

        End With

    End Sub

End Class
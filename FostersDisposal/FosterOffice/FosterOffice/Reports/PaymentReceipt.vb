Public Class PaymentReceipt

    Public Property PaymentDate As Date = Nothing
    Public Property PaymentAmount As Double = 0.0
    Public Property PaymentMOPDescription As String = ""

    Private Sub GroupHeader1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GroupHeader1.BeforePrint

        XrLabelPaymentDate.Text = String.Format("Payment Date: {0:MMMM dd, yyyy}", PaymentDate)
        XrLabelPaymentAmount.Text = String.Format("{0:c2}", PaymentAmount)

        Dim previousBalance As Double = DirectCast(GetCurrentColumnValue("CurrentBalance"), Double)
        XrLabelCurrentBalance.Text = String.Format("{0:c2}", previousBalance - PaymentAmount)

        XrLabelMOPDesc.Text = PaymentMOPDescription

    End Sub

End Class
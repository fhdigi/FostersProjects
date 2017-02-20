Public Class PaymentReceipt

    Public Property PaymentDate As Date = Nothing
    Public Property PaymentAmount As Double = 0.0
    Public Property PaymentMOPDescription As String = ""
    Public Property CustomerAccountNumber As String = ""
    Public Property CustomerName As String = ""
    Public Property BillingAddress As String = ""
    Public Property BillingCSZ As String = ""
    Public Property ServiceAddress As String = ""
    Public Property ServiceCSZ As String = ""
    Public Property CurrentBalance As Double = 0.0

    Private Sub GroupHeader1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GroupHeader1.BeforePrint

        ' ----- Write the customer information 
        XrLabelAccountNumber.Text = "Account Number : " & CustomerAccountNumber
        XrLabelCustomerName.Text = "Account Name : " & CustomerName

        ' ----- Write out the addresses 
        XrLabelBillingAddress.Text = BillingAddress
        XrLabelBillingCSZ.Text = BillingCSZ
        XrLabelServiceAddress.Text = ServiceAddress
        XrLabelServiceCSZ.Text = ServiceCSZ

        ' ----- Write out the payment information 
        XrLabelPaymentDate.Text = String.Format("Payment Date: {0:MMMM dd, yyyy}", PaymentDate)
        XrLabelPaymentAmount.Text = String.Format("{0:c2}", PaymentAmount)
        XrLabelMOPDesc.Text = PaymentMOPDescription

        ' ----- Write out the current balance
        XrLabelCurrentBalance.Text = String.Format("{0:c2}", CurrentBalance)

    End Sub

End Class
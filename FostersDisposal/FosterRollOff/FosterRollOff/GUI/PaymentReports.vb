Public Class PaymentReports

    Public Enum ReportType
        PrintReceipt = 1
        PaymentListing = 2
    End Enum

    Public Structure ReceiptInformation
        Dim CustomerNumber As String
        Dim CustomerName As String
        Dim BillingAddress As String
        Dim BillingCSZ As String
        Dim ServiceAddress As String
        Dim ServiceCSZ As String
        Dim Amount As Double
        Dim PaymentDate As Date
        Dim MOP As String
        Dim CurrentBalance As Double
    End Structure

    Public Property CurrentReportType As ReportType = ReportType.PrintReceipt
    Public Receipt As ReceiptInformation = Nothing
    Public PaymentListing As List(Of ITransaction)

    Private Sub PaymentReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Select Case CurrentReportType

            Case ReportType.PrintReceipt
                Dim rpt As New PaymentReceipt
                rpt.CustomerAccountNumber = Receipt.CustomerNumber
                rpt.CustomerName = Receipt.CustomerName
                rpt.BillingAddress = Receipt.BillingAddress
                rpt.BillingCSZ = Receipt.BillingCSZ
                rpt.ServiceAddress = Receipt.ServiceAddress
                rpt.ServiceCSZ = Receipt.ServiceCSZ
                rpt.PaymentAmount = Receipt.Amount
                rpt.PaymentDate = Receipt.PaymentDate
                rpt.PaymentMOPDescription = Receipt.MOP
                rpt.CurrentBalance = Receipt.CurrentBalance
                rpt.CreateDocument()
                DocumentViewerPayments.DocumentSource = rpt

            Case ReportType.PaymentListing
                Dim rpt As New CustomerPaymentReport
                rpt.BindingSourcePayment.DataSource = PaymentListing
                rpt.CreateDocument()
                DocumentViewerPayments.DocumentSource = rpt

        End Select

    End Sub

End Class
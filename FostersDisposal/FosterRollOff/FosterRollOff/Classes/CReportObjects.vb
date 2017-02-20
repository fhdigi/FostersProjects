Public Class CReportObjects

    Public Class CPaymentSummary
        Public Property TransDate As Date = Nothing
        Public Property DepositAmount As Double = 0.0
        Public Property TransAmount As Double = 0.0
        Public Property Customer As String = ""
        Public Property CustomerBillingAddress As String = ""
        Public Property AccountNumber As String = ""
        Public Property CheckNumber As String = ""
    End Class

    Public Class CCreditsIssuedSummary
        Public Property TransDate As Date = Nothing
        Public Property DepositAmount As Double = 0.0
        Public Property TransAmount As Double = 0.0
        Public Property Customer As String = ""
        Public Property CustomerBillingAddress As String = ""
        Public Property AccountNumber As String = ""
        Public Property CheckNumber As String = ""
    End Class

    Public Class CRevenueReport
        Public Property CollectionFromTaxFreeCustomers As Double = 0.0
        Public Property CollectionFromTaxedCustomers As Double = 0.0
        Public Property TotalCollectedLessTax As Double = 0.0
        Public Property TaxCollected As Double = 0.0
        Public Property TotalCollected As Double = 0.0
        Public Property ReportStartDate As Date = Nothing
        Public Property ReportEndDate As Date = Nothing
        public Property TotalCreditCollected as Double = 0.0
        Public Property TotalNonCreditCollected As Double = 0.0

    End Class

    Public Class AppliedPaymentReport
        Public Property CustomerNumber As String = ""
        Public Property CustomerName As String = ""
        Public Property CheckNumber As String = ""
        Public Property TransactionDate As Date = Nothing
        Public Property TransactionAmount As Double = 0.0
        Public Property TransactionType As String = ""
    End Class

End Class

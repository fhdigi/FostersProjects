Public Class CCustomerBill

    Public Property AccountNumber As Integer = 0
    Public Property SequenceNumber As Integer = 0
    Public Property BillingDate As Date = Nothing
    Public Property LastName As String = ""
    Public Property FirstName As String = ""
    Public Property Address As String = ""
    Public Property City As String = ""
    Public Property State As String = ""
    Public Property ZipCode As String = ""
    Public Property Tax As Double = 0.0
    Public Property Subtotal As Double = 0.0
    Public Property Total As Double = 0.0

    Public Property LineItems As New List(Of CBillLineItems)

    Public ReadOnly Property FullName As String
        Get
            Return _FirstName & " " & _LastName
        End Get
    End Property

    Public ReadOnly Property CSZ As String
        Get
            Return _City & ", " & _State & " " & _ZipCode
        End Get
    End Property

    Public ReadOnly Property ListBoxString As String
        Get
            Return String.Format("{0} {1} - Bill: {2:c2} ({3})", _FirstName, _LastName, _Total, _BillingDate.Date.ToShortDateString)
        End Get
    End Property

End Class

Public Class CBillLineItems

    Public Property Description As String = ""
    Public Property Amount As Double = 0.0

End Class

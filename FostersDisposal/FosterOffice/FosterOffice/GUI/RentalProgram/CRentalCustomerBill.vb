Public Class CRentalCustomerBill

    Public Property AccountNumber As Integer = 0
    Public Property SequenceNumber As Integer = 0
    Public Property BillingDate As Date = Nothing
    Public Property BillingLastName As String = ""
    Public Property BillingFirstName As String = ""
    Public Property BillingAddress As String = ""
    Public Property BillingCity As String = ""
    Public Property BillingState As String = ""
    Public Property BillingZipCode As String = ""
    Public Property PickUpLastName As String = ""
    Public Property PickUpFirstName As String = ""
    Public Property PickUpAddress As String = ""
    Public Property PickUpCity As String = ""
    Public Property PickUpState As String = ""
    Public Property PickUpZipCode As String = ""
    Public Property Tax As Double = 0.0
    Public Property Subtotal As Double = 0.0
    Public Property Total As Double = 0.0

    Public Property PurchaseOrderNumber As string = ""

    Public Property LineItems As New List(Of CRentalBillLineItems)

    Public ReadOnly Property BillingFullName As String
        Get
            Return _BillingFirstName & " " & _BillingLastName
        End Get
    End Property

    Public ReadOnly Property PickupFullName As String
        Get
            Return _PickUpFirstName & " " & _PickUpLastName
        End Get
    End Property

    Public ReadOnly Property BillingCSZ As String
        Get
            Return _BillingCity & ", " & _BillingState & " " & _BillingZipCode
        End Get
    End Property

    Public ReadOnly Property PickupCSZ As String
        Get
            Return _PickUpCity & ", " & _PickUpState & " " & _PickUpZipCode
        End Get
    End Property

    Public ReadOnly Property ListBoxString As String
        Get
            Return String.Format("{0} {1} - Bill: {2:c2} ({3})", _BillingFirstName, _BillingLastName, _Total, _BillingDate.Date.ToShortDateString)
        End Get
    End Property

End Class

Public Class CRentalBillLineItems

    Public Property ServiceDate As Date = Nothing
    Public Property Description As String = ""
    Public Property Amount As Double = 0.0
    Public Property Qty As String = ""
    Public Property UnitPrice As String = ""

End Class

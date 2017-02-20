Imports System.ComponentModel

Public Class CBillingObject

    ' ----- Set the database name 
    'Private Const BillsDatabase As String = "CustomerBills.db"

    '<BrowsableAttribute(False)> Public Property UniqueID As Guid = Nothing
    <BrowsableAttribute(False)> Public Property DatabaseID As Integer = 0

    Public Property BillingDate As Date = Nothing
    Public Property RollOffObject As CRollOff = Nothing

    Public Property SubTotal As Double = 0.0
    Public Property Tax As Double = 0.0
    Public Property Total As Double = 0.0

    Public Property ChargeListing As New List(Of CRollOffHistoryBilling)

    Public Sub New()
    End Sub

    Public Function Save(editmode As Boolean) As Boolean
        Return CDataExtender.SaveBilling(Me, editmode)
    End Function

    Public Function Delete() As Boolean
        Return CDataExtender.DeleteBilling(Me)
    End Function

    Public Shared Function ReturnBillsList(ro As CRollOff) As List(Of CBillingObject)
        Return CDataExtender.ReturnBillsList(ro)
    End Function

    Public Shared Function ReturnBillCharges(ro As CRollOff) As List(Of CRollOffHistoryBilling)
        Return CDataExtender.ReturnRollOffCharges(ro)
    End Function

    Public Shared Function ReturnLastBill(ro As CRollOff) As CBillingObject

        Dim billList As List(Of CBillingObject) = ReturnBillsList(ro).OrderByDescending(Function(b) b.BillingDate).ToList
        If billList.Count > 0 Then
            Return billList(0)
        Else
            Return Nothing
        End If

    End Function

    Public Shared Function GetBillInformation(ro As CRollOff, dteBill As Date) As CBillingObject
        Dim billList As CBillingObject = CDataExtender.ReturnBillsList(ro).Where(Function(d) d.BillingDate = dteBill).Select(Function(d) d).FirstOrDefault
        Return billList
    End Function

End Class

Public Class CRollOffHistoryBilling

    Public Enum TransType
        Charge = 0
        Deposit = 1
        Payment = 2
        PreviousBalance = 3
        Rental = 4
        Miscellaneous = 5
    End Enum

    Public Property TransactionType As TransType = TransType.Charge
    Public Property TransactionDatabaseID As Integer = 0  ' Added with the migration to Access 
    Public Property TransactionID As Guid = Nothing
    Public Property AccountNumber As String = ""
    Public Property BillingDate As Date = Nothing
    Public Property BillingName As String = ""
    Public Property BillingAddress As String = ""
    Public Property BillingCSZ As String = ""
    Public Property PickupName As String = ""
    Public Property PickupAddress As String = ""
    Public Property PickupCSZ As String = ""
    Public Property TaxRate As Double = 0.0
    Public Property TransactionDate As Date = Nothing
    Public Property Quantity As Double = 0.0
    Public Property Description As String = ""
    Public Property TaxableAmount As Double = 0.0
    Public Property UnitAmount As Double = 0.0
    Public Property Amount As Double = 0.0
    Public Property SubTotal As Double = 0.0
    Public Property Tax As Double = 0.0
    Public Property Total As Double = 0.0
    Public Property ReprintMessage As String = ""
    Public Property BillSortOrder As Integer = 0
    Public Property CheckNumber As String = ""

End Class

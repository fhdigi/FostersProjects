Imports System.ComponentModel

Public Class CPayments
    Implements ITransaction

    '<BrowsableAttribute(False)> Public Property UniqueID As Guid = Nothing
    <BrowsableAttribute(False)> Public Property DatabaseID As Integer Implements ITransaction.DatabaseID

    Public Property TransactionDate As Date Implements ITransaction.TransactionDate
    Public Property Amount As Double Implements ITransaction.Amount
    Public Property Description As String Implements ITransaction.Description
    Public Property CheckNumber As String Implements ITransaction.CheckNumber
    Public Property RollOffID As Integer Implements ITransaction.RollOffID
    Public Property RollOffObject As CRollOff Implements ITransaction.RollOffObject
    Public Property HasBeenBilled As Boolean Implements ITransaction.HasBeenBilled
    Public Property BilledDate As Date Implements ITransaction.BilledDate
    Public Property Taxable As Boolean Implements ITransaction.Taxable
    
    ' ----- Added for credit cards 
    public Property CreditCardTransaction as Boolean Implements ITransaction .CreditCardTransaction
    Public Property CreditCardAuthNumber As String Implements ITransaction .CreditCardAuthNumber
    Public Property TransactionId As string Implements ITransaction .TransactionId 

    Public Sub New()
    End Sub

    'Public Sub AssignID()
    '    UniqueID = System.Guid.NewGuid
    'End Sub

    Public Function Save() As Boolean
        Return CDataExtender.SaveDepositPaymentData(Me, "Payments")
    End Function

    Public Function Update() As Boolean
        Return CDataExtender.UpdateDepositPaymentData(Me, "Payments")
    End Function

    Public Function Delete() As Boolean
        Return CDataExtender.DeleteDepositPayment(Me, "Payments")
    End Function

    Public Shared Function GetPaymentList(rollOffObject As CRollOff) As List(Of ITransaction)
        Return CDataExtender.GetDepositPaymentList(rollOffObject, "Payments")
    End Function

    Public Function MarkAsBilled(dteBill As Date) As Boolean Implements ITransaction.MarkAsBilled
        Return CDataExtender.MarkAsBilled(Me.DatabaseID, dteBill, "Payments")
    End Function

    Public Function RemoveBillFlag(billDate As Date) As Boolean Implements ITransaction.RemoveBillFlag
        Return CDataExtender.RemoveBillFlag(Me.DatabaseID, billDate, "Payments")
    End Function

    Public Shared Function FindPayment(databaseID As Integer) As ITransaction
        Return CDataExtender.FindDepositPayment(databaseID, "Payments")
    End Function

    Public Shared Function GetPaymentListForDateRange(startDate As Date, endDate As Date) As List(Of ITransaction)
        Return CDataExtender.GetDepositPaymentListForDateRange(startDate, endDate, "Payments")
    End Function

End Class

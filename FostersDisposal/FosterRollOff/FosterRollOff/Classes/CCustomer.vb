Imports System.ComponentModel
Imports System.Globalization
Imports FosterRollOff

Public Class CCustomer

    Private Const CustomerDatabase As String = "Customer.db"

    '<BrowsableAttribute(False)> Public Property UniqueID As Guid = Nothing
    <BrowsableAttribute(False)> Public Property DatabaseID As Integer = 0

    Public Property CustomerNumber As String = ""
    Public Property CustomerNumberPrefix As String = "02"
    Public Property CustomerNumberBase As Integer = 0
    'Public Property PickUpAddress As CAddressBlock
    Public Property BillingAddress As CAddressBlock
    Public Property ContactName As String = ""
    Public Property BusinessPhone As String = ""
    Public Property HomePhone As String = ""
    Public Property TaxRate As String = ""
    Public Property PrintBill As String = ""
    Public Property SendToCollections As Boolean = False
    Public Property CurrentBalanceForCollection As Double = 0.0
    Public Property CollectionBalanceAsOf As Date = Nothing

    Public Property CustomerNotes As String = ""
    Public Property RollOffAdddress As CAddressBlock

    'Public Property RollOff10Yard As String = ""
    'Public Property RollOff20Yard As String = ""
    'Public Property RollOff30Yard As String = ""
    'Public Property RollOffDumpFee As String = ""
    'Public Property RollOff10YardRental As String = ""
    'Public Property RollOff20YardRental As String = ""
    'Public Property RollOff30YardRental As String = ""
    'Public Property DepositAmount As String = ""
    'Public Property LastPaymentAmount As String = ""
    'Public Property LastPaymentDate As String = ""
    'Public Property DateRollOffDelivered As Date = Nothing

    Public Overrides Function ToString() As String
        If Not BillingAddress Is Nothing Then
            If BillingAddress.LastName.Trim <> "" Then
                Return BillingAddress.LastName & ", " & BillingAddress.FirstName & " (" & CustomerNumber & ")"
            Else
                Return BillingAddress.FirstName & " (" & CustomerNumber & ")"
            End If
        Else
            Return ""
        End If
    End Function

    'Public Sub New()
    '    UniqueID = System.Guid.NewGuid
    'End Sub

    Public Function Save() As Boolean
        Return CDataExtender.SaveCustomer(Me)
    End Function

    Public Function Update() As Boolean
        Return CDataExtender.SaveCustomer(Me, True)
    End Function

    Public Function Delete() As Boolean
        Return CDataExtender.DeleteCustomer(Me)
    End Function

    Public Shared Function GetCustomerList() As List(Of CCustomer)
        Return CDataExtender.GetCustomerList
    End Function

    Public Shared Function GetCustomersInCollection() As List(Of CCustomer)
        Return CDataExtender.GetCustomersInCollection
    End Function

    Public Shared Function GetNextBaseCustomerNumber() As Integer

        Dim nextBaseNumber As Integer = 0
        Try
            nextBaseNumber = CurrentCustomerList.Where(Function(c) c.CustomerNumberPrefix = "02").Select(Function(c) c.CustomerNumberBase).Max
        Catch ex As Exception
        End Try
        If nextBaseNumber = 0 Then nextBaseNumber = 999
        Return nextBaseNumber + 1

    End Function

End Class

Imports System.ComponentModel

Public Class CWaitingList

    Public Enum WaitListStatusTypes
        OnWaitList = 0
        MovedToRollOff = 1
        Cancelled = 2
    End Enum

    <BrowsableAttribute(False)> Public Property DatabaseID As Integer = 0

    Public Property NumberOnList As Integer = 0
    Public Property Customer As CCustomer = Nothing
    Public Property CallDate As Date = Nothing
    Public Property WaitListStatus As WaitListStatusTypes = WaitListStatusTypes.OnWaitList
    Public Property RollOffSize As Integer = 10
    Public Property RollOffUse As String = ""
    Public Property CancelDate As Date = Nothing
    Public Property ConvertedToRollOffDate As Date = Nothing
    Public Property Notes As String = ""
    Public Property ServiceAddress As CAddressBlock

    Public ReadOnly Property CustomerPhone As String
        Get
            Return String.Format("{0}{1}{2}", Customer.HomePhone, ControlChars.CrLf, Customer.BusinessPhone)
        End Get
    End Property

    Public ReadOnly Property CustomerAccountNumber As String
        Get
            Return Customer.CustomerNumber
        End Get
    End Property

    Public ReadOnly Property CustomerFullName As String
        Get
            Return Customer.BillingAddress.FullName
        End Get
    End Property

    Public ReadOnly Property CustomerBillngAddress As String
        Get
            Return String.Format("{0}{1}{2}{1}{3}, {4} {5}{1}{6}{1}{7}", Customer.BillingAddress.FullName, ControlChars.CrLf, Customer.BillingAddress.Address, Customer.BillingAddress.City, Customer.BillingAddress.State, Customer.BillingAddress.ZipCode, Customer.HomePhone, Customer.BusinessPhone)
        End Get
    End Property

    Public ReadOnly Property CustomerServiceCSZ As String
        Get
            Return String.Format("{0}{1}{2}, {3} {4}", ServiceAddress.Address, ControlChars.CrLf, ServiceAddress.City, ServiceAddress.State, ServiceAddress.ZipCode)
        End Get
    End Property

    Public ReadOnly Property DaysOnList As Integer
        Get
            Return (Date.Today - CallDate).Days
        End Get
    End Property

    Public Sub New()
    End Sub

    Public Function Save() As Boolean
        Return CDataExtender.SaveWaitingList(Me)
    End Function

    Public Function Update() As Boolean
        Return CDataExtender.UpdateWaitingList(Me)
    End Function

    Public Sub Delete()
        CDataExtender.DeleteWaitingList(Me)
    End Sub

    Public Function CustomerCancelled()
        Me.CancelDate = Date.Now
        Me.WaitListStatus = WaitListStatusTypes.Cancelled
        Return Update()
    End Function

    Public Function CustomerReOpened()
        Me.CancelDate = Nothing
        Me.WaitListStatus = WaitListStatusTypes.OnWaitList
        Return Update()
    End Function

    Public Function CustomerMovedToRolloff()
        Me.ConvertedToRollOffDate = Date.Now
        Me.WaitListStatus = WaitListStatusTypes.MovedToRollOff
        Return Update()
    End Function

    Public Shared Function GetCustomersOnList(listType As CWaitingList.WaitListStatusTypes) As List(Of CWaitingList)
        Return CDataExtender.GetCustomersOnWaitingList(listType)
    End Function

End Class

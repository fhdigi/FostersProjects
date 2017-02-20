Imports System.ComponentModel

Public Class CCharges

    Public Enum ChargeTypeListing
        Unassigned = 0
        Rental = 1
        Service = 2
        Dumping = 3
        Tax = 4
        Miscellaneous = 5
    End Enum

    ' ----- Set the database name 
    Private Const ChargesDatabase As String = "Charges.db"

    ' ----- This becomes the unique ID that we will reference throughout the code 
    '<BrowsableAttribute(False)> Public Property UniqueID As Guid = Nothing
    <BrowsableAttribute(False)> Public Property DatabaseID As Integer = 0

    Public Property ChargeDateBegin As Date = Nothing
    Public Property ChargeDateEnd As Date = Nothing
    Public Property ChargeType As ChargeTypeListing = ChargeTypeListing.Unassigned
    Public Property Unit As Double = 0.0
    Public Property Rate As Double = 0.0
    Public Property Total As Double = 0.0
    Public Property Description As String = ""
    Public Property RollOffObject As CRollOff = Nothing
    Public Property HasBeenBilled As Boolean = False
    Public Property BilledDate As Date = Nothing
    Public Property Taxable As Boolean = True

    Public Sub New()
    End Sub

    'Public Sub AssignID()
    '    UniqueID = System.Guid.NewGuid
    'End Sub

    Public Function Save() As Boolean
        Return CDataExtender.SaveChargeData(Me)
    End Function

    Public Function Update() As Boolean
        Return CDataExtender.UpdateChargeData(Me)
    End Function

    Public Function Delete() As Boolean
        Return CDataExtender.DeleteCharge(Me)
    End Function

    Public Function MarkAsBilled(billDate As Date) As Boolean
        Return CDataExtender.MarkAsBilled(Me.DatabaseID, billDate, "Charges")
    End Function

    Public Function RemoveBillFlag(billDate As Date) As Boolean
        Return CDataExtender.RemoveBillFlag(Me.DatabaseID, billDate, "Charges")
    End Function

    Public Shared Function FindCharge(databaseID As Integer) As CCharges
        Return CDataExtender.FindCharge(DatabaseID)
    End Function

    Public Shared Function GetChargeList(rollOffObj As CRollOff) As List(Of CCharges)
        Return CDataExtender.GetChargeList(rollOffObj.DatabaseID)
    End Function

    Public Shared Function ReturnAllRecords() As List(Of CCharges)
        Return CDataExtender.ReturnAllCharges
    End Function

End Class

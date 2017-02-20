Imports System.ComponentModel
Imports System.IO
Imports System.Xml.Serialization

Public Class CRollOff

    <BrowsableAttribute(False)> Public Property UniqueID As Guid = Nothing
    Public Property DatabaseID As Integer = 0

    Public Property Customer As CCustomer = Nothing
    Public Property RollOffPickedUp As Boolean = False
    Public Property DateRollOffDelivered As Date = Nothing
    Public Property DateRollOffPickedUp As Nullable(Of Date) = Nothing
    Public Property RollOffSize As Integer = 0
    Public Property RentalRate As Double = 0.0
    Public Property RentalPeriod As Integer = 0 ' 0 = Daily / 1 = Monthly
    Public Property ServiceCharge As Double = 0.0
    Public Property DumpingFee As Double = 0.0
    Public Property FeeObj As CRollOffFee = Nothing
    Public Property Active As Boolean = True
    Public Property ServiceAddress As CAddressBlock
    Public Property Deposits As Double = 0.0

    ' ----- Use this flag to tell the program the roll off object is a dummy object
    Public Property AccountDataOnly As Boolean = False

    ' ----- Added September 2015
    Public Property RollOffNotes as String = ""

    ' ----- Added June 2016
    Public Property UseRollOffBillingAddress As Boolean = False
    Public Property RollOffBillingName As string = ""
    Public Property RollOffBillingAddress  As CAddressBlock

    Public ReadOnly Property AddressBlock As String
        Get
            Return ServiceAddress.Address & " " & ServiceAddress.City
        End Get
    End Property

    Public Function GetRollOffHistory(billFlag As Integer, billDate As Date) As List(Of CRollOffHistory)

        Dim newHistoryList As New List(Of CRollOffHistory)
        Dim runningTotal As Double = 0.0

        ' ----- Get a list of charges that are associated with the roll off (not necessarily the customer)
        For Each chrObj As CCharges In CCharges.GetChargeList(Me)

            Dim itmObj As New CRollOffHistory

            If chrObj.ChargeType = CCharges.ChargeTypeListing.Rental Then
                itmObj.TransactionType = CRollOffHistory.TransType.Rental
            Else
                itmObj.TransactionType = CRollOffHistory.TransType.Charge
            End If

            itmObj.TransactionDatabaseID = chrObj.DatabaseID
            itmObj.TransactionDate = chrObj.ChargeDateEnd
            itmObj.Description = chrObj.Description
            itmObj.Debit = chrObj.Total
            itmObj.Quantity = chrObj.Unit
            itmObj.UnitAmount = chrObj.Rate

            ' ----- Sum up the taxable amounts 
            If chrObj.Taxable Then itmObj.TaxableAmount += chrObj.Total

            Select Case billFlag
                Case 0
                    newHistoryList.Add(itmObj)
                Case 1
                    If chrObj.HasBeenBilled = False Then newHistoryList.Add(itmObj)
                Case 2
                    If chrObj.HasBeenBilled = True AndAlso chrObj.BilledDate.Date = billDate.Date AndAlso chrObj.ChargeType <> CCharges.ChargeTypeListing.Tax Then newHistoryList.Add(itmObj)
            End Select

            itmObj.CheckNumber = ""

        Next

        ' ----- Get a list of payments  
        For Each chrObj As ITransaction In CPayments.GetPaymentList(Me)
            Dim itmObj As New CRollOffHistory
            itmObj.TransactionType = CRollOffHistory.TransType.Payment
            itmObj.TransactionDatabaseID = chrObj.DatabaseID
            itmObj.TransactionDate = chrObj.TransactionDate
            itmObj.Description = chrObj.Description
            itmObj.Credit = chrObj.Amount
            itmObj.Quantity = 1.0
            itmObj.UnitAmount = chrObj.Amount

            Select Case billFlag
                Case 0
                    newHistoryList.Add(itmObj)
                Case 1
                    If chrObj.HasBeenBilled = False Then newHistoryList.Add(itmObj)
                Case 2
                    If chrObj.HasBeenBilled = True AndAlso chrObj.BilledDate.Date = billDate.Date Then newHistoryList.Add(itmObj)
            End Select

            itmObj.CheckNumber = chrObj.CheckNumber

        Next

        ' ----- Get a list of deposits
        For Each chrObj As ITransaction In CDeposits.GetDepositList(Me)
            Dim itmObj As New CRollOffHistory
            itmObj.TransactionType = CRollOffHistory.TransType.Deposit
            itmObj.TransactionDatabaseID = chrObj.DatabaseID
            itmObj.TransactionDate = chrObj.TransactionDate
            itmObj.Description = chrObj.Description
            itmObj.Credit = chrObj.Amount
            itmObj.Quantity = 1.0
            itmObj.UnitAmount = chrObj.Amount

            Select Case billFlag
                Case 0
                    newHistoryList.Add(itmObj)
                Case 1
                    If chrObj.HasBeenBilled = False Then newHistoryList.Add(itmObj)
                Case 2
                    If chrObj.HasBeenBilled = True AndAlso chrObj.BilledDate.Date = billDate.Date Then newHistoryList.Add(itmObj)
            End Select

            itmObj.CheckNumber = chrObj.CheckNumber

        Next

        ' ----- Determine the rental charge to date 
        If billFlag = 0 Then

            Dim unbilledRental As Double = UnbilledRentalCharge

            If unbilledRental > 0.0 Then

                Dim itmRentalObj As New CRollOffHistory

                itmRentalObj.TransactionDate = Date.Today
                itmRentalObj.Description = String.Format("Unbilled Rental Charge {0}", If(Me.RollOffPickedUp, "Since Pickup", "to Date"))

                itmRentalObj.Debit = unbilledRental
                itmRentalObj.TaxableAmount += itmRentalObj.Debit

                ' ----- Add it to the list  
                newHistoryList.Add(itmRentalObj)

            End If

        End If

        ' ----- Return the list 
        Return newHistoryList

    End Function

    Public Function GetRollOffHistoryForBilling(billingDate As Date) As List(Of CRollOffHistoryBilling)

        Dim BillingObject As New List(Of CRollOffHistoryBilling)
        Dim runningTotal As Double = 0.0
        Dim runningTaxableTotal As Double = 0.0

        ' ----- First thing we need to do is get the previous balance 
        Dim roBillListing As List(Of CBillingObject) = CBillingObject.ReturnBillsList(Me)

        If roBillListing.Count > 0 Then

            ' ----- Get the last item 
            Dim previousBill As CBillingObject = roBillListing.OrderByDescending(Function(b) b.BillingDate)(0)

            Dim prevObj As New CRollOffHistoryBilling
            prevObj.TransactionType = CRollOffHistoryBilling.TransType.PreviousBalance

            prevObj.TransactionDate = previousBill.BillingDate
            prevObj.Quantity = 1
            prevObj.Description = "Previous Balance"

            prevObj.Amount = previousBill.Total
            prevObj.UnitAmount = previousBill.Total

            ' ----- Create totals for the total amount and the total taxable amount 
            runningTotal += prevObj.Amount

            ' ----- Previous balance should be the first on the listing 
            prevObj.BillSortOrder = 1

            ' ----- Add it to the list 
            BillingObject.Add(prevObj)

        End If

        ' ----- This gets all of the unbilled history 
        Dim newHistoryList As List(Of CRollOffHistory) = GetRollOffHistory(1, Nothing)

        ' ----- Loop through the history list 
        For Each obj As CRollOffHistory In newHistoryList.OrderBy(Function(t) t.TransactionDate)

            Dim tempObj As New CRollOffHistoryBilling

            tempObj.TransactionType = obj.TransactionType
            tempObj.TransactionID = obj.TransactionID
            tempObj.TransactionDatabaseID = obj.TransactionDatabaseID
            tempObj.TransactionDate = obj.TransactionDate
            tempObj.Quantity = obj.Quantity
            tempObj.Description = obj.Description

            If obj.Credit > 0 Then
                tempObj.Amount = -1.0 * obj.Credit
                tempObj.UnitAmount = -1.0 * obj.UnitAmount
            Else
                tempObj.Amount = obj.Debit
                tempObj.UnitAmount = obj.UnitAmount
            End If

            ' ----- Create totals for the total amount and the total taxable amount 
            runningTaxableTotal += obj.TaxableAmount

            runningTotal += tempObj.Amount

            If tempObj.TransactionType = CRollOffHistoryBilling.TransType.Deposit Then
                tempObj.BillSortOrder = 1
            ElseIf tempObj.TransactionType = CRollOffHistoryBilling.TransType.Payment Then
                tempObj.BillSortOrder = 2
            ElseIf tempObj.TransactionType = CRollOffHistoryBilling.TransType.Rental Then
                tempObj.BillSortOrder = 3
            ElseIf tempObj.TransactionType = CRollOffHistoryBilling.TransType.Charge Then
                tempObj.BillSortOrder = 4
            Else
                tempObj.BillSortOrder = 5
            End If

            tempObj.CheckNumber = obj.CheckNumber

            ' ----- Add it to the list 
            BillingObject.Add(tempObj)

        Next

        For Each tempObj As CRollOffHistoryBilling In BillingObject
            tempObj.AccountNumber = Customer.CustomerNumber
            tempObj.BillingDate = billingDate

            ' ----- Modified on 22-Jun-2016
            if UseRollOffBillingAddress then 
                tempObj.BillingName = RollOffBillingName
                tempObj.BillingAddress = RollOffBillingAddress.Address
                tempObj.BillingCSZ = RollOffBillingAddress.CSZ
            Else 
                tempObj.BillingName = Customer.BillingAddress.FullName
                tempObj.BillingAddress = Customer.BillingAddress.Address
                tempObj.BillingCSZ = Customer.BillingAddress.CSZ
            End If

            tempObj.PickupName = Customer.BillingAddress.FullName
            tempObj.PickupAddress = ServiceAddress.Address
            tempObj.PickupCSZ = ServiceAddress.CSZ
            tempObj.TaxRate = If(Customer.TaxRate.Trim = "", 0.08, Convert.ToDouble(Customer.TaxRate))

            ' ----- We seem to have a round off issue ... the following code tries to account for it.  
            tempObj.SubTotal = Convert.ToDouble(String.Format("{0:f2}", runningTaxableTotal))
            tempObj.Tax = Convert.ToDouble(String.Format("{0:f2}", runningTaxableTotal * BillingObject(0).TaxRate))
            tempObj.Total = Convert.ToDouble(String.Format("{0:f2}", runningTotal + (runningTaxableTotal * BillingObject(0).TaxRate)))

        Next

        ' ----- Return the data 
        Return BillingObject

    End Function

    Public Function GetRollOffBillInformation(billDate As Date) As List(Of CRollOffHistoryBilling)

        Dim savedBillObject As CBillingObject = CBillingObject.ReturnBillsList(Me).Where(Function(c) c.BillingDate.Date.ToShortDateString = billDate.Date.ToShortDateString).Select(Function(c) c).FirstOrDefault
        Return savedBillObject.ChargeListing

    End Function

    Public ReadOnly Property DisplayedPickupDate As String
        Get
            If DateRollOffPickedUp IsNot Nothing Then
                Return String.Format("{0:MM/dd/yyyy}", DateRollOffPickedUp.Value)
            Else
                Return ""
            End If
        End Get
    End Property

    Public ReadOnly Property DisplayedLastBillDetails As String
        Get
            Dim roBillList As List(Of CBillingObject) = CBillingObject.ReturnBillsList(Me)
            If roBillList.Count > 0 Then
                Dim billDetails As CBillingObject = roBillList.OrderByDescending(Function(b) b.BillingDate).Select(Function(b) b).FirstOrDefault

                Return String.Format("{0:c2} ({1:MM/dd/yyyy})", billDetails.Total, billDetails.BillingDate)
            Else
                Return ""
            End If
        End Get
    End Property

    Public ReadOnly Property RollOffTotalCharge As Double
        Get
            Return UnbilledRentalCharge + TotalCharges - TotalPayments - TotalDeposits
        End Get
    End Property

    Public ReadOnly Property DaysHadRollOff As Integer
        Get
            If RollOffPickedUp Then
                Return (DateRollOffPickedUp.Value - DateRollOffDelivered).Days
            Else
                Return (Date.Today - DateRollOffDelivered).Days
            End If
        End Get
    End Property

    Public ReadOnly Property MonthsHadRollOff As Integer
        Get
            Return DaysHadRollOff \ 30
        End Get
    End Property

    Public ReadOnly Property TotalDeposits As Double
        Get
            Dim totalAmount As Double = CurrentTransactions.Where(Function(f) f.RollOffID = Me.DatabaseID And f.TransactionType = "Deposits").Select(Function(f) f.Amount).Sum

            'Dim chargeListing As List(Of Double) = CurrentTransactions.Where(Function(f) f.RollOffID = Me.DatabaseID And f.TransactionType = "Deposits") '   CDeposits.GetDepositList(Me)
            'For Each chrObj As Double In chargeListing
            '    totalAmount += chrObj
            'Next
            Return totalAmount
        End Get
    End Property

    Public ReadOnly Property TotalCharges As Double
        Get
            Dim chargeListTemp = (From f In CurrentTransactions
                                  Where f.RollOffID = Me.DatabaseID And f.TransactionType = "Charges"
                                  Select f).ToList

            Dim totalAmount As Double = CurrentTransactions.Where(Function(f) f.RollOffID = Me.DatabaseID And f.TransactionType = "Charges").Select(Function(f) f.Amount).Sum
            'Dim chargeListing As List(Of CCharges) = CCharges.GetChargeList(Me)
            'For Each chrObj As CCharges In chargeListing
            '    totalAmount += chrObj.Total
            'Next
            Return totalAmount
        End Get
    End Property

    Public ReadOnly Property TotalPayments As Double
        Get
            Dim totalAmount As Double = CurrentTransactions.Where(Function(f) f.RollOffID = Me.DatabaseID And f.TransactionType = "Payments").Select(Function(f) f.Amount).Sum
            'Dim chargeListing As List(Of ITransaction) = CPayments.GetPaymentList(Me)
            'For Each chrObj As ITransaction In chargeListing
            '    totalAmount += chrObj.Amount
            'Next
            Return totalAmount
        End Get
    End Property

    Public ReadOnly Property TotalPaymentsSinceCollection As Double
        Get
            Dim totalAmount As Double = CurrentTransactions.Where(Function(f) f.RollOffID = Me.DatabaseID And f.TransactionType = "Payments").Select(Function(f) f.Amount).Sum
            Return totalAmount
        End Get
    End Property
    Public ReadOnly Property UnbilledRentalCharge As Double
        Get
            ' ----- Determine if there have been any rental charges on this roll off 
            ' Dim rentalCharges As List(Of CCharges) = CCharges.GetChargeList(Me).Where(Function(c) c.ChargeType = CCharges.ChargeTypeListing.Rental).OrderByDescending(Function(c) c.ChargeDateEnd).ToList
            Dim rentalCharges As List(Of CDataExtender.CMainScreenData) = CurrentTransactions.Where(Function(c) c.RollOffID = Me.DatabaseID And c.ChargeType = CCharges.ChargeTypeListing.Rental).OrderByDescending(Function(c) c.ChargeDate).ToList

            ' ----- If so ... get the latest date 
            Dim startingRentalChargeDate As Date = Nothing
            Dim endingRentalChargeDate As Date = Nothing
            Dim baseRentalDate As Date = Nothing

            If rentalCharges.Count > 0 Then
                startingRentalChargeDate = rentalCharges(0).ChargeDate + New TimeSpan(1, 0, 0, 0)
                baseRentalDate = rentalCharges(0).ChargeDate
            Else
                startingRentalChargeDate = Me.DateRollOffDelivered
                baseRentalDate = startingRentalChargeDate
            End If

            If Me.RollOffPickedUp Then
                endingRentalChargeDate = Me.DateRollOffPickedUp
            Else
                endingRentalChargeDate = Now
            End If

            If endingRentalChargeDate.Date <> baseRentalDate.Date Then

                If RentalPeriod = 0 Then
                    Return Convert.ToDouble((endingRentalChargeDate - startingRentalChargeDate).Days) * RentalRate
                Else
                    Return Convert.ToDouble((endingRentalChargeDate - startingRentalChargeDate).Days \ 30) * RentalRate
                End If

            Else
                Return 0.0
            End If

        End Get
    End Property

    Public Sub New()
        UniqueID = System.Guid.NewGuid
    End Sub

    Public Overrides Function ToString() As String
        Return Customer.BillingAddress.FullName
    End Function

    Public Function Save() As Boolean
        Return CDataExtender.SaveRollOffData(Me)
    End Function

    Public Function Update() As Boolean
        Return CDataExtender.UpdateRollOffData(Me)
    End Function

    Public Function Delete() As Boolean
        Return CDataExtender.DeleteRollOff(Me)
    End Function

    Public Shared Function GetListOfInActiveRollOffs() As List(Of CRollOff)
        Return CDataExtender.GetListOfInActiveRollOffs()
    End Function

    Public Shared Function GetRollOffsForCustomer(customerID As Integer) As List(Of CRollOff)
        Return CDataExtender.GetRollOffsForCustomer(customerID)
    End Function

    Public Shared Function GetServiceAddress(rollOffID As Integer) As CAddressBlock
        Return CDataExtender.GetServiceAddress(rollOffID)
    End Function

End Class

Public Class CRollOffHistory

    Public Enum TransType
        Charge = 0
        Deposit = 1
        Payment = 2
        Rental = 4
    End Enum

    Public Property TransactionType As TransType = TransType.Charge
    Public Property TransactionID As Guid = Nothing
    Public Property TransactionDatabaseID As Integer = 0
    Public Property TransactionDate As Date = Nothing
    Public Property Quantity As Double = 0.0
    Public Property Description As String = ""
    Public Property Credit As Double = 0.0
    Public Property Debit As Double = 0.0
    Public Property UnitAmount As Double = 0.0
    Public Property TaxableAmount As Double = 0.0
    Public Property CheckNumber As String = ""

    ' ----- This is just a helper property that I use for the print out version of the roll off history
    ' ----- DO NOT DEPEND ON THIS PROPERTY TO HAVE ACTUAL VALUES IN ANY OTHER MODULE
    Public Property RunningTotal As Double = 0.0

End Class

Public Class CRollOffFee

    Private Const RollOffFeeTypeDatabase As String = "RollOffFees.db"

    <BrowsableAttribute(False)> Public Property DatabaseID As Integer = 0

    Public Property RollOffSize As Integer = 0
    Public Property RentalAmount As Double = 0.0
    Public Property DailyFee As Double = 0.0
    Public Property Description As String = ""

    Public Sub New()
        UniqueID = System.Guid.NewGuid
    End Sub

    Public Function Save()
        Return CDataExtender.SaveRollOffFee(Me)
    End Function

    Public Function Update()
        Return CDataExtender.UpdateRollOffFee(Me)
    End Function

    Public Shared Function GetRollOffFees() As List(Of CRollOffFee)
        Return CDataExtender.GetRollOffFees
    End Function

    Public Overrides Function ToString() As String
        Return Description
    End Function

End Class

Public Class DumpingFee

    Public Property CurrentDumpingFee as Double = 72.00

    Public Shared Function GetDumpingFee() as Double

        dim defaultFee as Double = 72

        try
            dim dumpingFeeObj as new DumpingFee

            ' ----- Serialize the dumping feel
            Dim dumpingFeeFile As New StreamReader(My.Application.Info.DirectoryPath & "\DumpingFee.xml")
            Dim fileSerialized As new XmlSerializer(dumpingFeeObj.GetType())
            dumpingFeeObj = fileSerialized.Deserialize(dumpingFeeFile)
            dumpingFeeFile.Close()

            ' ----- If we have a valid number then display it 
            if not dumpingFeeObj is Nothing then
                defaultFee = dumpingFeeObj.CurrentDumpingFee
            End If
        Catch ex As Exception
        End Try

        return defaultFee

    End Function

    Public Shared Sub SaveDumpingFee(DumpingFee as Double)

                ' ----- Create the object 
        dim dumpingFeeObj as new DumpingFee
        dumpingFeeObj.CurrentDumpingFee = DumpingFee

        ' ----- Serialize the dumping feel
        Dim dumpingFeeFile As New StreamWriter(My.Application.Info.DirectoryPath & "\DumpingFee.xml", False)
        Dim fileSerialized As new XmlSerializer(dumpingFeeObj.GetType())
        fileSerialized.Serialize(dumpingFeeFile, dumpingFeeObj)
        dumpingFeeFile.Close()

    End Sub

End Class


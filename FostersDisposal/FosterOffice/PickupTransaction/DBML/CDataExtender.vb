Imports System.ComponentModel
Imports System.Xml.Serialization
Imports System.IO

Public Class CDataExtender

    Public BillingTypeObjectList As New List(Of PickupTransaction.BillingTypes)
    Public BillingTypeDictionary As New Dictionary(Of String, Integer)
    Public ItemsCollectedObjectList As New List(Of PickupTransaction.ItemsCollected)
    Public ItemsCollectedDictionary As New Dictionary(Of Integer, String)
    Public ItemsCollectedPriceDictionary As New Dictionary(Of Integer, Double)
    Public CustomerDictionary As New Dictionary(Of Integer, Customer)

    Public Sub Init(ByVal ConnectionString As String)

        ' ----- Create a billing type object list 
        BillingTypeObjectList = PickupTransaction.BillingTypes.OpenBillingFile
        BillingTypeDictionary.Clear()

        For Each itmX As BillingTypes In BillingTypeObjectList
            BillingTypeDictionary.Add(itmX.Designation.ToUpper, itmX.ID)
        Next

        ' ----- Create a list of the items that we collect
        ItemsCollectedObjectList = PickupTransaction.ItemsCollected.OpenItemsCollectedFile

        ' ----- Create a dictionary that can be used later 
        ItemsCollectedDictionary.Clear()
        For Each itmX As ItemsCollected In ItemsCollectedObjectList
            ItemsCollectedDictionary.Add(itmX.ID, itmX.ItemDescription)
        Next

        ItemsCollectedPriceDictionary.Clear()
        For Each itmX As ItemsCollected In ItemsCollectedObjectList
            ItemsCollectedPriceDictionary.Add(itmX.ID, itmX.MaximumPrice)
        Next

        Try
            CustomerDictionary.Clear()
            Dim customerListing = Customer.ReturnCustomer(ConnectionString)

            If customerListing Is Nothing Then Return

            For Each custX As Customer In customerListing
                CustomerDictionary.Add(custX.CustomerNumber, custX)
            Next
        Catch ex As Exception

        End Try

    End Sub

    Public Function ReturnItemList() As List(Of ItemsCollected)

        Dim itemObj = From ic In ItemsCollectedObjectList
                      Order By ic.ItemDescription
                      Select ic

        Return itemObj.ToList

    End Function

    Public Sub UpdateCustomerDictionary(ConnectionString As String)
        Try
            CustomerDictionary.Clear()
            For Each custX As Customer In Customer.ReturnCustomer(ConnectionString)
                CustomerDictionary.Add(custX.CustomerNumber, custX)
            Next
        Catch ex As Exception

        End Try
    End Sub

End Class

Public Class Customer

    Public Enum PickupDayListing
        Monday = 1
        Tuesday
        Wednesday
        Thursday
        Friday
        Saturday
    End Enum

    Public Class CCustomerList

        Public Property PickupDate As PickupDayListing = PickupDayListing.Monday
        Public Property SequenceNumber As Integer = 0
        Public Property AccountNumber As Integer = 0
        Public Property CustomerName As String = ""
        Public Property CustomerAddress As String = ""
        Public Property CompleteAddressWithCSZ As String = ""
        Public Property SpecialInstructions As String = ""
        Public Property Route As Integer = 0
        Public Property PhoneNumber As String = ""
        Public Property BillingBagRate As Integer = 0
        Public Property PickupDayIndex As Integer = 1
        Public Property YellowTab As Boolean = False

        Public Sub New(ByVal SeqNum As Integer, ByVal AcctNum As Integer, ByVal CustName As String, ByVal CustAddress As String, ByVal strSpecialInstructions As String, ByVal billingBagRate As Integer)
            _SequenceNumber = SeqNum
            _AccountNumber = AcctNum
            _CustomerName = CustName
            _CustomerAddress = CustAddress
            _SpecialInstructions = strSpecialInstructions
            _BillingBagRate = billingBagRate
        End Sub

        Public Sub New()

        End Sub

        Public Overrides Function ToString() As String
            Return _CustomerName
        End Function

        Public ReadOnly Property NameWithAccountNumber As String
            Get
                Return _AccountNumber.ToString & " - " & _CustomerName.Replace("/", " ").Replace("\", " ")
            End Get
        End Property

    End Class

    Public Class CCustomerHistory

        Public Class CCustomerHistoryLineItems
            Public Property TransactionID As Integer = 0
            Public Property CustomerID As Integer = 0
            Public Property TransactionDate As Date = Nothing
            Public Property TransactionDesc As String = ""
            Public Property TransactionAmount As Double = 0.0
            Public Property RunningBalance As Double = 0.0
        End Class

        Public Property CustomerName As String = ""
        Public Property CustomerAccountNumber As Integer = 0
        Public Property BillingAddress As String = ""
        Public Property BillingCSZ As String = ""
        Public Property RouteAddress As String = ""
        Public Property RouteCSZ As String = ""
        Public Property CurrentBalance As Double = 0.0
        Public Property Balance12Month As Double = 0.0
        Public Property Balance3Month As Double = 0.0
        Public Property Balance4Month As Double = 0.0
        Public Property Balance5MonthOrGreater As Double = 0.0
        Public TransactionLineItems As New List(Of CCustomerHistoryLineItems)

    End Class

    Public Class CCustomerRouteCounts

        ' ----- This class is mainly used for the route count report
        Public Property RouteDescription As String = ""
        Public Property SequenceRange As String = ""
        Public Property CountDate As String = ""
        Public Property RouteCount As Integer = 0
        Public Property PickupDay As Integer = 0

        Public Property WorkingList As New List(Of Customer)
        Public Property MinimumSequenceNumber As Integer = 99999
        Public Property MaximumSequenceNumber As Integer = 0

        Public Sub GetData()

            Dim LookupRouteDesc(5, 4) As String
            LookupRouteDesc(1, 1) = "Monday Book #1"
            LookupRouteDesc(1, 2) = "Monday Book #2"
            LookupRouteDesc(1, 3) = "Monday Book #3"
            LookupRouteDesc(1, 4) = "Monday Book #4"

            LookupRouteDesc(2, 1) = "Tuesday Book #1"
            LookupRouteDesc(2, 2) = "Tuesday Book #2"
            LookupRouteDesc(2, 3) = "Tuesday Book #3"
            LookupRouteDesc(2, 4) = "Tuesday Book #4"

            LookupRouteDesc(3, 1) = "Wednesday Book #1"
            LookupRouteDesc(3, 2) = "Wednesday Book #2"
            LookupRouteDesc(3, 3) = "Wednesday Book #3"
            LookupRouteDesc(3, 4) = "Wednesday Book #4"

            LookupRouteDesc(4, 1) = "Thursday Book #1"
            LookupRouteDesc(4, 2) = "Thursday Book #2"
            LookupRouteDesc(4, 3) = "Thursday Book #3"
            LookupRouteDesc(4, 4) = "Thursday Book #4"

            LookupRouteDesc(5, 1) = "Friday Book #1"
            LookupRouteDesc(5, 2) = "Friday Book #2"
            LookupRouteDesc(5, 3) = "Friday Book #3"
            LookupRouteDesc(5, 4) = "Friday Book #4"

            For Each obj As Customer In WorkingList
                If MinimumSequenceNumber > obj.SequenceNumber Then MinimumSequenceNumber = obj.SequenceNumber
                If MaximumSequenceNumber < obj.SequenceNumber Then MaximumSequenceNumber = obj.SequenceNumber
            Next

            RouteCount = WorkingList.Count
            CountDate = String.Format("{0:MMM-yyyy}", Date.Today)

            If WorkingList.Count > 0 Then
                RouteDescription = LookupRouteDesc(WorkingList(0).PickupDay, WorkingList(0).Route)
                SequenceRange = MinimumSequenceNumber.ToString & " - " & MaximumSequenceNumber.ToString
                PickupDay = WorkingList(0).PickupDay
            End If

        End Sub

        Public Shared Function GenerateRouteCount(connectionString As String) As List(Of CCustomerRouteCounts)

            Dim routeListing As New List(Of CCustomerRouteCounts)
            Dim db As New DisposalData(connectionString)

            ' ----- Loop through the pickup days and the route numbers 
            For pickupDayNum As Integer = 1 To 5

                For routeNumber As Integer = 1 To 4

                    Dim tempPickDay As Integer = pickupDayNum
                    Dim tempRouteNum As Integer = routeNumber

                    Dim newObj As New CCustomerRouteCounts

                    ' ----- Create a customer list 
                    newObj.WorkingList = (From c In db.Customers
                                          Where c.SequenceNumber < 80000 And c.PickupDay = tempPickDay And c.Route = tempRouteNum
                                          Select c).ToList

                    ' ----- Analyze the data 
                    newObj.GetData()

                    ' ----- Add it to the list 
                    If newObj.RouteCount > 0 Then routeListing.Add(newObj)

                Next

            Next

            Return routeListing

        End Function

    End Class

    <CategoryAttribute("Name"), DisplayNameAttribute("Full Name")>
    Public ReadOnly Property FullName As String
        Get
            Try
                Return _RouteLocation_FirstName.Trim & " " & _RouteLocation_LastName.Trim
            Catch ex As Exception
                Return _RouteLocation_FirstName & " " & _RouteLocation_LastName
            End Try
        End Get
    End Property

    Public ReadOnly Property ReverseFullName As String
        Get
            Return _RouteLocation_LastName & ", " & _RouteLocation_FirstName
        End Get
    End Property

    Public ReadOnly Property BillingAddressCity As String
        Get
            Return _Billing_Address & " " & _Billing_City
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return _RouteLocation_LastName
    End Function

    Public Shared Function GetCustomer(ByVal ConnectionString As String, ByVal customerNumber As Integer) As Customer

        Dim db As New DisposalData(ConnectionString)

        Dim custObj As Customer = (From c In db.Customers Where c.CustomerNumber = customerNumber Select c).SingleOrDefault
        Return custObj

    End Function

    Public Shared Function GetCustomerListInSeqBlock(connectionString As String, seqStart As Integer, seqEnd As Integer) As List(Of Customer)

        Using db As New DisposalData(connectionString)
            Return _
                (From c In db.Customers Where c.SequenceNumber >= seqStart And c.SequenceNumber <= seqEnd Order By c.SequenceNumber Select c).
                    ToList
        End Using

    End Function

    Public Shared Function GetCustomerListInPrevSeqBlock(connectionString As String, seqStart As Integer, seqEnd As Integer, curSeqStart As Integer, curSeqEnd As Integer) As List(Of Customer)

        Using db As New DisposalData(connectionString)
            Return _
                (From c In db.Customers Where c.PreviousSequenceNumber >= seqStart And c.PreviousSequenceNumber <= seqEnd And c.SequenceNumber >= curSeqStart And c.SequenceNumber <= curSeqEnd Order By c.PreviousSequenceNumber Select c).
                    ToList
        End Using

    End Function

    Public Shared Function GetCustomerName(ByVal ConnectionString As String, ByVal customerNumber As Integer) As String

        ' ----- Open the connection 
        Dim db As New DisposalData(ConnectionString)

        ' ----- Pull the customer name from the database 
        Try
            Dim custObj As Customer = (From c In db.Customers Where c.CustomerNumber = customerNumber Select c).SingleOrDefault
            Return custObj.FullName
        Catch ex As Exception
            Return ""
        End Try

    End Function

    <DisplayNameAttribute("Scheduled Pickup Day")>
    Public Property ScheduledPickupDay As PickupDayListing
        Get
            Return _PickupDay
        End Get
        Set(ByVal value As PickupDayListing)
            _PickupDay = value
        End Set
    End Property

    <DisplayNameAttribute("Billing Type Code")>
    Public ReadOnly Property BillingTypeCode As String
        Get
            If Not BillingType Is Nothing Then
                Return Chr(BillingType + 64)
            Else
                Return ""
            End If
        End Get
    End Property

    Public Shared Function ReturnMainCustomerList(ByVal ConnectionString As String, Optional ByVal ActiveCustomers As Boolean = True) As List(Of Customer.CCustomerList)

        Dim db As New DisposalData(ConnectionString)

        Dim custList = From c In db.Customers
                       Where If(ActiveCustomers, c.SequenceNumber < 80000, c.SequenceNumber >= 80000)
                       Order By c.PickupDay, c.SequenceNumber
                       Select New CCustomerList With
                              {
                                  .PickupDate = c.PickupDay,
                                  .SequenceNumber = c.SequenceNumber,
                                  .AccountNumber = c.CustomerNumber,
                                  .CustomerName = c.FullName,
                                  .CustomerAddress = c.RouteLocation_Address,
                                  .CompleteAddressWithCSZ = c.RouteLocation_Address & " " & c.RouteLocation_City & ", " & c.RouteLocation_State & " " & c.RouteLocation_ZipCode,
                                  .SpecialInstructions = c.SpecialInstructions,
                                  .PhoneNumber = c.HomePhone,
                                  .Route = c.Route
                              }

        Return custList.ToList

    End Function

    Public Shared Function ReturnCustomerList(ByVal ConnectionString As String, Optional ByVal pickupDay As Integer = 0) As List(Of Customer.CCustomerList)

        Dim db As New DisposalData(ConnectionString)

        Dim custList = From c In db.Customers
                       Where c.PickupDay > pickupDay
                       Order By c.PickupDay, c.SequenceNumber
                       Select New CCustomerList With
                              {
                                  .PickupDate = c.PickupDay,
                                  .SequenceNumber = c.SequenceNumber,
                                  .AccountNumber = c.CustomerNumber,
                                  .CustomerName = c.FullName,
                                  .CustomerAddress = c.RouteLocation_Address,
                                  .CompleteAddressWithCSZ = c.RouteLocation_Address & " " & c.RouteLocation_City & ", " & c.RouteLocation_State & " " & c.RouteLocation_ZipCode,
                                  .SpecialInstructions = c.SpecialInstructions,
                                  .PhoneNumber = c.HomePhone,
                                  .Route = c.Route
                              }

        Return custList.ToList

    End Function

    Public Shared Function ReturnCustomerListByDay(ByVal ConnectionString As String, ByVal dayOfTheWeek As Integer, Optional ByVal seqNumStart As Integer = 0, Optional ByVal seqNumEnd As Integer = 80000) As List(Of Customer.CCustomerList)

        ' ----- Create the database connection 
        Dim db As New DisposalData(ConnectionString)


        If dayOfTheWeek > 0 Then

            Dim custList = From c In db.Customers
                           Where c.PickupDay = dayOfTheWeek And c.SequenceNumber > seqNumStart And c.SequenceNumber < seqNumEnd And c.Route <> 0
                           Order By c.PickupDay, c.SequenceNumber
                           Select New CCustomerList With
                                  {
                                      .SequenceNumber = c.SequenceNumber,
                                      .AccountNumber = c.CustomerNumber,
                                      .CustomerName = c.FullName,
                                      .CustomerAddress = c.RouteLocation_Address,
                                      .CompleteAddressWithCSZ = c.RouteLocation_Address & " " & c.RouteLocation_City & ", " & c.RouteLocation_State & " " & c.RouteLocation_ZipCode,
                                      .SpecialInstructions = c.SpecialInstructions,
                                      .Route = c.Route
                                  }

            Return custList.ToList

        Else

            Dim custList = From c In db.Customers
                           Where c.SequenceNumber >= seqNumStart And c.SequenceNumber <= seqNumEnd And c.Route <> 0
                           Order By c.PickupDay, c.SequenceNumber
                           Select New CCustomerList With
                                  {
                                      .SequenceNumber = c.SequenceNumber,
                                      .AccountNumber = c.CustomerNumber,
                                      .CustomerName = c.FullName,
                                      .CustomerAddress = c.RouteLocation_Address,
                                      .CompleteAddressWithCSZ = c.RouteLocation_Address & " " & c.RouteLocation_City & ", " & c.RouteLocation_State & " " & c.RouteLocation_ZipCode,
                                      .SpecialInstructions = c.SpecialInstructions,
                                      .Route = c.Route
                                  }

            Return custList.ToList

        End If

    End Function

    Public Shared Function ReturnCustomerListByDayAndRoute(ByVal ConnectionString As String, ByVal dayOfTheWeek As Integer, ByVal currentRoute As Integer) As List(Of Customer.CCustomerList)

        Dim db As New DisposalData(ConnectionString)

        Dim custList = From c In db.Customers
                       Where c.PickupDay = dayOfTheWeek And c.Route = currentRoute And c.SequenceNumber < 80000
                       Order By c.PickupDay, c.SequenceNumber
                       Select New CCustomerList With
                              {
                                  .SequenceNumber = c.SequenceNumber,
                                  .AccountNumber = c.CustomerNumber,
                                  .CustomerName = c.FullName,
                                  .CustomerAddress = c.RouteLocation_Address,
                                  .CompleteAddressWithCSZ = c.RouteLocation_Address & " " & c.RouteLocation_City & ", " & c.RouteLocation_State & " " & c.RouteLocation_ZipCode,
                                  .SpecialInstructions = c.SpecialInstructions,
                                  .BillingBagRate = IIf(c.BillingType Is Nothing, 0, Convert.ToInt32(c.BillingType)),
                                  .Route = c.Route
                              }

        Return custList.ToList

    End Function

    Public Shared Function ReturnCustomerListByDayAndRoute_V2(ByVal dayoftheWeek As Integer, ByVal currentRoute As Integer) As List(Of CCustomerList)

        Dim customerListObj As List(Of CCustomerList) = Nothing

        Using fs As New StreamReader(My.Application.Info.DirectoryPath & "\CustomerList.dat")

            ' ----- Read the data from the file 
            Dim customerSerialization As New XmlSerializer(GetType(List(Of CCustomerList)))
            customerListObj = customerSerialization.Deserialize(fs)

        End Using

        Dim custList = From c In customerListObj
                       Where c.PickupDate = dayoftheWeek And c.Route = currentRoute And c.SequenceNumber < 80000
                       Order By c.PickupDate, c.SequenceNumber
                       Select c

        Return custList.ToList
        'Return customerListObj

    End Function

    Public Shared Sub CreateCustomerList(ByVal ConnectionString As String)

        ' ----- Get the connection string 
        Dim db As New DisposalData(ConnectionString)

        ' ----- Create a customer listing 
        Dim custList = From c In db.Customers
                       Where c.SequenceNumber < 80000
                       Order By c.PickupDay, c.SequenceNumber
                       Select New CCustomerList With
                              {
                                  .SequenceNumber = c.SequenceNumber,
                                  .AccountNumber = c.CustomerNumber,
                                  .CustomerName = c.FullName,
                                  .CustomerAddress = c.RouteLocation_Address,
                                  .CompleteAddressWithCSZ = c.RouteLocation_Address & " " & c.RouteLocation_City & ", " & c.RouteLocation_State & " " & c.RouteLocation_ZipCode,
                                  .SpecialInstructions = c.SpecialInstructions,
                                  .PickupDate = c.PickupDay,
                                  .BillingBagRate = IIf(c.BillingType Is Nothing, 0, Convert.ToInt32(c.BillingType)),
                                  .YellowTab = IIf(c.YellowTab Is Nothing, False, c.YellowTab.Value),
                                  .Route = c.Route
                              }


        Dim customerListingObj As List(Of CCustomerList) = custList.ToList

        Try

            Using fs As New StreamWriter(My.Application.Info.DirectoryPath & "\CustomerList.dat")

                Dim customerSerialization As New XmlSerializer(GetType(List(Of CCustomerList)))
                customerSerialization.Serialize(fs, customerListingObj)

            End Using

        Catch ex As Exception

        End Try

    End Sub

    Public Sub DeleteCustomer(ByVal ConnectionString As String)

        ' ----- Remove the customer from the database 
        Dim db As New DisposalData(ConnectionString)

        Dim obj = (From c In db.Customers
                   Where c.CustomerNumber = Me.CustomerNumber
                   Select c).SingleOrDefault

        db.Customers.DeleteOnSubmit(obj)
        db.SubmitChanges()

    End Sub

    Public Sub Save(ByVal ConnectionString As String)

        Dim db As New DisposalData(ConnectionString)
        db.Customers.InsertOnSubmit(Me)
        db.SubmitChanges()

    End Sub

    Public Shared Sub UpdateMonthBilled(ByVal ConnectionString As String, ByVal customerNumber As Integer, ByVal monthBilled As Integer)

        Dim db As New DisposalData(ConnectionString)

        Dim obj = (From c In db.Customers
                   Where c.CustomerNumber = customerNumber
                   Select c).SingleOrDefault

        With obj
            If .PreviousMonthBilled <> .LastMonthBilled Or .PreviousMonthBilled Is Nothing Then .PreviousMonthBilled = .LastMonthBilled
            .LastMonthBilled = monthBilled
        End With

        db.SubmitChanges()

    End Sub

    Public Shared Sub ResetMonthBilled(ByVal ConnectionString As String, ByVal customerNumber As Integer)

        Dim db As New DisposalData(ConnectionString)

        Dim obj = (From c In db.Customers
                   Where c.CustomerNumber = customerNumber
                   Select c).SingleOrDefault

        If Not obj.PreviousMonthBilled Is Nothing Then
            obj.LastMonthBilled = obj.PreviousMonthBilled
        Else
            obj.LastMonthBilled -= 1
            obj.PreviousMonthBilled = obj.LastMonthBilled
        End If

        db.SubmitChanges()

    End Sub

    Public Sub Update(ByVal ConnectionString As String)

        Dim db As New DisposalData(ConnectionString)

        Dim obj = (From c In db.Customers
                   Where c.CustomerNumber = Me.CustomerNumber
                   Select c).SingleOrDefault

        With obj
            .SequenceNumber = Me.SequenceNumber
            .PreviousSequenceNumber = Me.PreviousSequenceNumber
            .RouteLocation_FirstName = Me.RouteLocation_FirstName
            .RouteLocation_LastName = Me.RouteLocation_LastName
            .RouteLocation_Address = Me.RouteLocation_Address
            .RouteLocation_City = Me.RouteLocation_City
            .RouteLocation_State = Me.RouteLocation_State
            .RouteLocation_ZipCode = Me.RouteLocation_ZipCode
            .BusinessPhone = Me.BusinessPhone
            .HomePhone = Me.HomePhone
            .BillingSameAsRoute = Me.BillingSameAsRoute
            .PickupDay = Me.PickupDay
            .TaxRate = Me.TaxRate
            .BillingType = Me.BillingType
            .SpecialInstructions = Me.SpecialInstructions
            .Route = Me.Route
            .MonthsToBill = Me.MonthsToBill
            .Comments = Me.Comments

            ' ----- Added for new data 
            .Balance = Me.Balance
            .AdditionalChargeDesc1 = Me.AdditionalChargeDesc1
            .AdditionalChargeDesc2 = Me.AdditionalChargeDesc2
            .LastMonthBilled = Me.LastMonthBilled
            .LastPaymentAmount = Me.LastPaymentAmount
            .LastPaymentDate = Me.LastPaymentDate
            .PreviousMonthBilled = Me.PreviousMonthBilled

            ' ----- Go in after data
            .GoInAfter = Me.GoInAfter
            .GoInAfterAmount = Me.GoInAfterAmount

            ' ----- Collection Notes
            .ContinueBilling = Me.ContinueBilling
            .SendToCollections = Me.SendToCollections
            .CollectionNotes = Me.CollectionNotes

            ' ----- Set the yellow tab flag 
            .YellowTab = Me.YellowTab

            If .BillingSameAsRoute Then
                .Billing_FirstName = Me.RouteLocation_FirstName
                .Billing_LastName = Me.RouteLocation_LastName
                .Billing_Address = Me.RouteLocation_Address
                .Billing_City = Me.RouteLocation_City
                .Billing_State = Me.RouteLocation_State
                .Billing_ZipCode = Me.RouteLocation_ZipCode
            Else
                .Billing_FirstName = Me.Billing_FirstName
                .Billing_LastName = Me.Billing_LastName
                .Billing_Address = Me.Billing_Address
                .Billing_City = Me.Billing_City
                .Billing_State = Me.Billing_State
                .Billing_ZipCode = Me.Billing_ZipCode
            End If

        End With

        db.SubmitChanges()

    End Sub

    Public Shared Function ReturnCustomer(ByVal ConnectionString As String) As List(Of Customer)

        Try
            Dim db As New DisposalData(ConnectionString)

            Dim cust = (From c In db.Customers
                        Order By c.Billing_LastName, c.Billing_FirstName
                        Select c).ToList

            Return cust
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Shared Function ReturnSingleCustomerToBill(ByVal ConnectionString As String, ByVal customerNumber As Integer, Optional ByVal UseMonthsToBill As Boolean = False) As CBillingData

        ' ----- Create a connection string 
        Dim db As New DisposalData(ConnectionString)

        ' ----- Select all of the customers that are on the report billing cycle 
        Dim custListWithBalance = (From c In db.Customers
                                   Where c.CustomerNumber = customerNumber
                                   Order By c.Billing_LastName, c.Billing_FirstName
                                   Select New CBillingData With
                                          {
                                              .AccountNumber = c.CustomerNumber,
                                              .SequenceNumber = c.SequenceNumber,
                                              .MonthsToBill = If(UseMonthsToBill, c.MonthsToBill, 1),
                                              .StartingBalance = c.CurrentBalance,
                                              .FirstName = c.Billing_FirstName,
                                              .LastName = c.Billing_LastName,
                                              .CustomerName = c.Billing_FirstName & " " & c.Billing_LastName,
                                              .Address = c.Billing_Address,
                                              .City = c.Billing_City,
                                              .State = c.Billing_State,
                                              .ZipCode = c.Billing_ZipCode,
                                              .BillingType = c.BillingTypeCode,
                                              .TaxRate = c.TaxRate,
                                              .MonthlyCharge = 0.0,
                                              .ExtraBagsQty = 0,
                                              .ExtraBagsCost = 0.0,
                                              .AdditionalItems = "",
                                              .AdditionalItemCost = 0.0,
                                              .ListHeader = String.Format("{0} - {1} {2} ({3})", c.SequenceNumber, c.Billing_FirstName, c.Billing_LastName, c.CustomerNumber),
                                              .DelinquentAccount = False,
                                              .GoInAfter = c.GoInAfter,
                                              .GoInAfterAmount = c.GoInAfterAmount
                                          }).SingleOrDefault

        Return custListWithBalance

    End Function

    Public Shared Function ReturnCustomersToBill(ByVal ConnectionString As String, ByVal monthIndex As Integer, ByVal pickDay As Integer, ByVal frequency As Integer) As List(Of CBillingData)

        ' ----- Create a connection string 
        Dim db As New DisposalData(ConnectionString)

        If frequency = 0 Then

            ' ----- Get the listing of customers for this pickup date
            Dim customerDict As Dictionary(Of Integer, Customer) = (From c In db.Customers
                                                                    Where c.PickupDay = pickDay And c.SequenceNumber < 80000
                                                                    Select c).ToList.ToDictionary(Function(p) p.CustomerNumber)

            ' ----- Select all of the customers that are on the report billing cycle 
            Dim custListWithBalance = (From c In customerDict.Values
                                       Where (c.AgingBalance3Month > 0.0 Or c.AgingBalance4Month > 0 Or c.AgingBalance5Month > 0) And c.LastMonthBilled = monthIndex
                                       Order By c.Billing_LastName, c.Billing_FirstName
                                       Select New CBillingData With
                                              {
                                                   .AccountNumber = c.CustomerNumber,
                                                   .SequenceNumber = c.SequenceNumber,
                                                   .MonthsToBill = 1,
                                                   .StartingBalance = c.CurrentBalance,
                                                   .FirstName = c.Billing_FirstName,
                                                   .LastName = c.Billing_LastName,
                                                   .CustomerName = c.Billing_FirstName & " " & c.Billing_LastName,
                                                   .Address = c.Billing_Address,
                                                   .City = c.Billing_City,
                                                   .State = c.Billing_State,
                                                   .ZipCode = c.Billing_ZipCode,
                                                   .ListHeader = .SequenceNumber.ToString & " - " & .CustomerName & " (" & .AccountNumber.ToString & ") - D",
                                                   .BillingType = c.BillingTypeCode,
                                                   .TaxRate = c.TaxRate,
                                                   .MonthlyCharge = 0.0,
                                                   .ExtraBagsQty = 0,
                                                   .ExtraBagsCost = 0.0,
                                                   .AdditionalItems = "",
                                                   .AdditionalItemCost = 0.0,
                                                   .DelinquentAccount = True,
                                                   .GoInAfter = If(c.GoInAfter Is Nothing, 0, c.GoInAfter),
                                                   .GoInAfterAmount = If(c.GoInAfterAmount Is Nothing, 0.0, c.GoInAfterAmount)
                                               }).ToList

            Return custListWithBalance

        ElseIf frequency = -1 Then

            ' ----- Get the listing of customers for this pickup date
            Dim customerDict As Dictionary(Of Integer, Customer) = (From c In db.Customers
                                                                    Where c.SequenceNumber >= 80000 And c.ContinueBilling = True
                                                                    Select c).ToList.ToDictionary(Function(p) p.CustomerNumber)

            ' ----- Select all of the customers that are on the report billing cycle 
            Dim custListWithBalance = (From c In customerDict.Values
                                       Order By c.Billing_LastName, c.Billing_FirstName
                                       Select New CBillingData With
                                             {
                                                  .AccountNumber = c.CustomerNumber,
                                                  .SequenceNumber = c.SequenceNumber,
                                                  .MonthsToBill = 1,
                                                  .StartingBalance = c.CurrentBalance,
                                                  .FirstName = c.Billing_FirstName,
                                                  .LastName = c.Billing_LastName,
                                                  .CustomerName = c.Billing_FirstName & " " & c.Billing_LastName,
                                                  .Address = c.Billing_Address,
                                                  .City = c.Billing_City,
                                                  .State = c.Billing_State,
                                                  .ZipCode = c.Billing_ZipCode,
                                                  .ListHeader = .SequenceNumber.ToString & " - " & .CustomerName & " (" & .AccountNumber.ToString & ") - D",
                                                  .BillingType = c.BillingTypeCode,
                                                  .TaxRate = c.TaxRate,
                                                  .MonthlyCharge = 0.0,
                                                  .ExtraBagsQty = 0,
                                                  .ExtraBagsCost = 0.0,
                                                  .AdditionalItems = "",
                                                  .AdditionalItemCost = 0.0,
                                                  .DelinquentAccount = True,
                                                  .GoInAfter = False,
                                                  .GoInAfterAmount = 0.0
                                              }).ToList

            Return custListWithBalance

        Else

            ' ----- Get the listing of customers for this pickup date
            Dim customerDict As Dictionary(Of Integer, Customer) = (From c In db.Customers
                                                                    Where c.PickupDay = pickDay And c.SequenceNumber < 80000
                                                                    Select c).ToList.ToDictionary(Function(p) p.CustomerNumber)

            ' ----- Select all of the customers that are on the report billing cycle 
            Dim custList = (From c In customerDict.Values
                            Where c.LastMonthBilled = monthIndex And c.MonthsToBill = frequency And c.PickupDay = pickDay And c.SequenceNumber <= 80000
                            Order By c.Billing_LastName, c.Billing_FirstName
                            Select New CBillingData With
                                   {
                                       .AccountNumber = c.CustomerNumber,
                                       .SequenceNumber = c.SequenceNumber,
                                       .MonthsToBill = c.MonthsToBill,
                                       .StartingBalance = c.CurrentBalance,
                                       .FirstName = c.Billing_FirstName,
                                       .LastName = c.Billing_LastName,
                                       .CustomerName = c.Billing_FirstName & " " & c.Billing_LastName,
                                       .Address = c.Billing_Address,
                                       .City = c.Billing_City,
                                       .State = c.Billing_State,
                                       .ZipCode = c.Billing_ZipCode,
                                       .ListHeader = .SequenceNumber.ToString & " - " & .CustomerName & " (" & .AccountNumber.ToString & ") - " & .MonthsToBill.ToString,
                                       .BillingType = c.BillingTypeCode,
                                       .TaxRate = c.TaxRate,
                                       .MonthlyCharge = 0.0,
                                       .ExtraBagsQty = 0,
                                       .ExtraBagsCost = 0.0,
                                       .AdditionalItems = "",
                                       .AdditionalItemCost = 0.0,
                                       .GoInAfter = If(c.GoInAfter Is Nothing, 0, c.GoInAfter),
                                       .GoInAfterAmount = If(c.GoInAfterAmount Is Nothing, 0.0, c.GoInAfterAmount)
                                   }).ToList
            Return custList

        End If

        '.StartingBalance = If(c.Balance Is Nothing, 0.0, c.Balance),
    End Function

    Public Shared Function ReturnMaxCustomerNumber(ByVal connectionString As String)

        Dim db As New DisposalData(connectionString)

        Dim maxNum As Integer = (From c In db.Customers Select c.CustomerNumber).Max

        If maxNum < 50000 Then
            Return 50000
        Else
            Return maxNum + 1
        End If

    End Function

    Public Shared Function ReturnMaxSequenceNumber(ByVal connectionString As String) As Integer

        Dim db As New DisposalData(connectionString)

        Dim maxNum As Integer = (From c In db.Customers Where c.SequenceNumber > 80000 Select c.SequenceNumber).Max

        Return maxNum + 1

    End Function

    Public Shared Sub UpdateTransactionsTable(connectionString As String)

        Dim db As New DisposalData(connectionString)

        Dim custList = From c In db.Customers Order By c.SequenceNumber Select c.CustomerNumber, c.Balance

        For Each obj In custList
            Dim newTrans As New Transactions
            newTrans.TransDate = New Date(2012, 1, 1)
            newTrans.Description = "Starting Balance"
            newTrans.CustomerID = obj.CustomerNumber
            newTrans.Amount = If(obj.Balance Is Nothing, 0.0, obj.Balance)
            db.Transactions.InsertOnSubmit(newTrans)
            db.SubmitChanges()
        Next

    End Sub

    Public Shared Function CheckDateLastPost(connectionString As String) As List(Of Date)

        Dim db As New DisposalData(connectionString)

        Try
            Dim dateList As List(Of Date) = (From c In db.Customers Select c.CurrentBalanceDate.Value.Date).Distinct.ToList

            Return dateList
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Shared Sub SetCustomerBalances(ByVal connectionString As String, Optional ByVal customerNumber As Integer = -99)

        ' ----- Create the database connection 
        Dim db As New DisposalData(connectionString)

        ' ----- Create a customer list 
        Dim customerList As New List(Of Customer)

        ' ----- Depending on what the user wants, get a customer listing 
        If customerNumber = -99 Then
            customerList = (From c In db.Customers Select c).ToList
        Else
            customerList = (From c In db.Customers Where c.CustomerNumber = customerNumber Select c).ToList
        End If

        ' ----- Get the current balances and save them to the database 
        For Each obj As Customer In customerList

            Dim customerHistObj As CCustomerHistory = CustomerHistory(connectionString, obj.CustomerNumber, Date.Today + New TimeSpan(1, 0, 0, 0))
            Dim tmpVal As Double = customerHistObj.CurrentBalance
            Dim strVal As String = String.Format("{0:n2}", tmpVal)

            obj.CurrentBalance = Convert.ToDouble(strVal)
            obj.CurrentBalanceDate = Date.Today

            obj.AgingBalanceCurrent = customerHistObj.Balance12Month
            obj.AgingBalance3Month = customerHistObj.Balance3Month
            obj.AgingBalance4Month = customerHistObj.Balance4Month
            obj.AgingBalance5Month = customerHistObj.Balance5MonthOrGreater

            db.SubmitChanges()

        Next

    End Sub

    Public Shared Function CustomerHistory(ByVal connectionString As String, ByVal customerNumber As Integer, ByVal dteStart As Date) As CCustomerHistory

        ' ----- Create a connection object to the database 
        Dim db As New DisposalData(connectionString)

        Dim CustomerHistoryObj As CCustomerHistory = (From c In db.Customers
                                                      Where c.CustomerNumber = customerNumber
                                                      Select New CCustomerHistory With
                                                             {
                                                                 .CustomerName = c.Billing_FirstName & " " & c.Billing_LastName,
                                                                 .CustomerAccountNumber = c.CustomerNumber,
                                                                 .BillingAddress = c.Billing_Address,
                                                                 .BillingCSZ = c.Billing_City & ", " & c.Billing_State & " " & c.Billing_ZipCode,
                                                                 .RouteAddress = c.RouteLocation_Address,
                                                                 .RouteCSZ = c.RouteLocation_City & ", " & c.RouteLocation_State & " " & c.RouteLocation_ZipCode
                                                             }).SingleOrDefault


        ' ----- Create a starting balance line item 
        Dim startingBal As CCustomerHistory.CCustomerHistoryLineItems = (From c In db.Customers
                                                                         Where c.CustomerNumber = customerNumber
                                                                         Select New CCustomerHistory.CCustomerHistoryLineItems With
                                                                                {
                                                                                    .TransactionID = 99,
                                                                                    .CustomerID = c.CustomerNumber,
                                                                                    .TransactionDate = New Date(2012, 1, 1),
                                                                                    .TransactionDesc = "Starting Balance",
                                                                                    .TransactionAmount = If(c.Balance Is Nothing, 0.0, c.Balance)
                                                                                }).SingleOrDefault


        ' ----- Get all of the transactions in the Transactions table for this customer 
        Dim customerBills As List(Of CCustomerHistory.CCustomerHistoryLineItems) = (From t In db.Transactions
                                                                                    Where t.CustomerID = customerNumber And t.Description <> "Starting Balance" And t.Amount > 0.0 And t.TransDate.Date < dteStart.Date
                                                                                    Select New CCustomerHistory.CCustomerHistoryLineItems With
                                                                                           {
                                                                                               .TransactionID = t.ID,
                                                                                               .CustomerID = t.CustomerID,
                                                                                               .TransactionDate = t.TransDate,
                                                                                               .TransactionDesc = t.Description,
                                                                                               .TransactionAmount = t.Amount
                                                                                           }).ToList

        ' ----- Get all of the payments in the Payments table for this customer 
        Dim customerPayments As List(Of CCustomerHistory.CCustomerHistoryLineItems) = (From p In db.Payments
                                                                                       Where p.CustomerID = customerNumber And p.PaymentDate < dteStart
                                                                                       Select New CCustomerHistory.CCustomerHistoryLineItems With
                                                                                              {
                                                                                                  .TransactionID = p.ID,
                                                                                                  .CustomerID = p.CustomerID,
                                                                                                  .TransactionDate = p.PaymentDate,
                                                                                                  .TransactionDesc = If(p.PaymentAmount < 0.0, "Credit", "Payment"),
                                                                                                  .TransactionAmount = p.PaymentAmount
                                                                                              }).ToList

        ' ----- Add the starting balance object into the collection 
        CustomerHistoryObj.TransactionLineItems.Add(startingBal)

        For Each obj As CCustomerHistory.CCustomerHistoryLineItems In customerBills
            CustomerHistoryObj.TransactionLineItems.Add(obj)
        Next

        For Each obj As CCustomerHistory.CCustomerHistoryLineItems In customerPayments
            CustomerHistoryObj.TransactionLineItems.Add(obj)
        Next

        Dim runningBalance As Double = 0.0
        For Each obj As CCustomerHistory.CCustomerHistoryLineItems In (From c In CustomerHistoryObj.TransactionLineItems Order By c.TransactionDate)
            runningBalance += If(obj.TransactionDesc = "Payment" Or obj.TransactionDesc = "Credit", -1.0 * obj.TransactionAmount, obj.TransactionAmount)
            obj.RunningBalance = runningBalance
        Next

        '----- Set the current balance 
        CustomerHistoryObj.CurrentBalance = runningBalance

        ' ----- Determine the aging amount
        For Each obj As CCustomerHistory.CCustomerHistoryLineItems In (From c In CustomerHistoryObj.TransactionLineItems Order By c.TransactionDate)

            ' ----- Determine the number of days since the amount was recorded 
            If obj.TransactionDesc <> "Payment" And obj.TransactionDesc <> "Credit" Then
                Dim daysFromToday As Integer = (Date.Today.Subtract(obj.TransactionDate.Date)).Days
                Select Case daysFromToday
                    Case Is < 29
                        CustomerHistoryObj.Balance12Month += obj.TransactionAmount
                    Case Is < 60
                        CustomerHistoryObj.Balance3Month += obj.TransactionAmount
                    Case Is < 90
                        CustomerHistoryObj.Balance4Month += obj.TransactionAmount
                    Case Else
                        CustomerHistoryObj.Balance5MonthOrGreater += obj.TransactionAmount
                End Select
            End If

        Next

        ' ----- Get a list of payments
        Dim sumPayments As Double = 0.0
        For Each obj As CCustomerHistory.CCustomerHistoryLineItems In (From c In CustomerHistoryObj.TransactionLineItems Order By c.TransactionDate)
            If obj.TransactionDesc = "Payment" Or obj.TransactionDesc = "Credit" Then
                sumPayments += obj.TransactionAmount
            End If
        Next

        ' ----- Now remove the payments from the balances 
        Dim paymentRemainder As Double = 0.0

        Customer.UpdateAgingBalances(CustomerHistoryObj.Balance5MonthOrGreater, sumPayments)
        Customer.UpdateAgingBalances(CustomerHistoryObj.Balance4Month, sumPayments)
        Customer.UpdateAgingBalances(CustomerHistoryObj.Balance3Month, sumPayments)
        Customer.UpdateAgingBalances(CustomerHistoryObj.Balance12Month, sumPayments)

        If sumPayments > 0 Then
            CustomerHistoryObj.Balance12Month -= sumPayments
        End If

        ' ----- Return the object 
        Return CustomerHistoryObj

    End Function

    Public Shared Sub UpdateAgingBalances(ByRef balanceAmount As Double, ByRef remainingPaymentAmount As Double)

        ' ----- Determine the remaining balance amount 
        Dim remAmount As Double = remainingPaymentAmount - balanceAmount

        If remAmount >= 0.0 Then
            balanceAmount = 0.0
            remainingPaymentAmount = Convert.ToInt32(remAmount * 100.0) / 100.0
        Else
            balanceAmount = Convert.ToInt32(-1.0 * remAmount * 100.0) / 100.0
            remainingPaymentAmount = 0.0
        End If

    End Sub

    ''' <summary>
    ''' Function used to retrieve data for the Customer Notes report
    ''' </summary>
    ''' <param name="connectionString"></param>
    ''' <returns>List of Customer objects</returns>
    ''' <remarks></remarks>
    Public Shared Function ReturnCustomersWithComments(connectionString As String) As List(Of Customer)

        Dim db As New DisposalData(connectionString)

        Dim charSep() As Char = ControlChars.CrLf

        Dim custList As List(Of Customer) = (From c In db.Customers
                                             Where c.Comments.ToString.Trim.Length > 0 Or c.SpecialInstructions.ToString.Trim.Length > 0
                                             Select c).ToList

        ' ----- See if this extra processing helps
        Dim custsToRemove As New List(Of Customer)

        For Each custObj As Customer In custList

            ' ----- check for the dreaded nothings 
            If custObj.Comments Is Nothing Then custObj.Comments = ""
            If custObj.SpecialInstructions Is Nothing Then custObj.SpecialInstructions = ""

            If custObj.Comments.Trim = "" And custObj.SpecialInstructions.Trim = "" Then
                custsToRemove.Add(custObj)
            End If

        Next

        For Each custObj As Customer In custsToRemove
            custList.Remove(custObj)
        Next

        Return custList

    End Function

    Public Shared Function ReturnCustomersWithCommentsThisBilling(ByVal connectionString As String, ByVal LMB As Integer, ByVal LMB1Month As Integer, LMBMonth3 As Integer) As List(Of Customer)

        Dim db As New DisposalData(connectionString)

        Dim custList As List(Of Customer) = (From c In db.Customers
                                             Where (c.Comments.ToString.Trim <> "" Or c.SpecialInstructions.ToString.Trim <> "") And ((c.LastMonthBilled = LMB And c.MonthsToBill = 2) Or (c.LastMonthBilled = LMB1Month And c.MonthsToBill = 1) Or (c.LastMonthBilled = LMBMonth3 And c.MonthsToBill = 3) Or (c.AgingBalance3Month > 0.0 Or c.AgingBalance4Month > 0 Or c.AgingBalance5Month > 0))
                                             Select c).ToList

        ' ----- See if this extra processing helps
        Dim custsToRemove As New List(Of Customer)

        For Each custObj As Customer In custList

            ' ----- check for the dreaded nothings 
            If custObj.Comments Is Nothing Then custObj.Comments = ""
            If custObj.SpecialInstructions Is Nothing Then custObj.SpecialInstructions = ""

            If custObj.Comments.Trim = "" And custObj.SpecialInstructions.Trim = "" Then
                custsToRemove.Add(custObj)
            End If

        Next

        For Each custObj As Customer In custsToRemove
            custList.Remove(custObj)
        Next

        Return custList

    End Function

    Public Shared Sub GetCustomerYellowStatus(ByVal connectionString As String, ByVal custNum As Integer, ByRef yellowTabFlag As Boolean, ByRef agingBalance As Double)

        Dim db As New DisposalData(connectionString)

        Dim test As IEnumerable = From c In db.Customers
                                  Where c.CustomerNumber = custNum
                                  Select c.YellowTab, c.AgingBalance3Month, c.AgingBalance4Month, c.AgingBalance5Month

        Try
            yellowTabFlag = test(0).YellowTab
            agingBalance = test(0).AgingBalance3Month + test(0).AgingBalance4Month + test(0).AgingBalance5Month

        Catch ex As Exception
            yellowTabFlag = False
            agingBalance = 0.0
        End Try

    End Sub

    Public Shared Sub RemoveYellowTab(ByVal connectionString As String, ByVal custNum As Integer)

        Dim db As New DisposalData(connectionString)

        Dim custObj As Customer = (From c In db.Customers Where c.CustomerNumber = custNum Select c).SingleOrDefault

        If Not custObj Is Nothing Then
            custObj.YellowTab = False
            db.SubmitChanges()
        End If

    End Sub

    Public Shared Function ReturnCustomerWithinSequence(ByVal connectionString As String, ByVal seqStart As Integer, ByVal seqEnd As Integer) As List(Of Customer)

        Dim db As New DisposalData(connectionString)

        Dim custList As List(Of Customer) = (From c In db.Customers
                                             Where c.SequenceNumber >= seqStart And c.SequenceNumber <= seqEnd
                                             Order By c.SequenceNumber
                                             Select c).ToList

        Return custList

    End Function

    Public Shared Sub UpdateSequenceNumber(ByVal connectionString As String, ByVal accountNumber As Integer, ByVal newSequenceNumber As Integer)

        Dim db As New DisposalData(connectionString)

        ' ----- Get the customer object 
        Dim custObj As Customer = (From c In db.Customers
                                   Where c.CustomerNumber = accountNumber
                                   Select c).SingleOrDefault

        ' ----- Assuming we have a good object, save the sequence number 
        If Not custObj Is Nothing Then
            Dim oldSeqNum As Integer = custObj.SequenceNumber
            custObj.SequenceNumber = newSequenceNumber
            custObj.PreviousSequenceNumber = oldSeqNum
            db.SubmitChanges()
        End If

    End Sub

    Public Shared Function GetCustomerSequenceNumber(ByVal connectionString As String, ByVal custNum As Integer) As Integer

        Dim db As New DisposalData(connectionString)

        Dim seqID As Integer = (From c In db.Customers Where c.CustomerNumber = custNum Select c.SequenceNumber).SingleOrDefault

        Return seqID

    End Function

    Public Shared Function GetRoute4Customers(connectionString As String) As List(Of Customer)

        Dim db As New DisposalData(connectionString)

        Dim customerList As List(Of Customer) = (From c In db.Customers Where c.Route = 4 And c.SequenceNumber < 61000 Select c).ToList

        Return customerList

    End Function

    Public Shared Function FindCustomersWithDuplicateSeqNumbers(connectionString As String) As List(Of Customer)

        Dim db As New DisposalData(connectionString)
        Dim prevCust As Customer = Nothing
        Dim filteredCustomerList As New List(Of Customer)

        Dim customerList As List(Of Customer) = (From c In db.Customers Where c.SequenceNumber < 60000 Order By c.SequenceNumber Select c).ToList

        For Each cust As Customer In customerList
            If prevCust Is Nothing Then
                prevCust = cust
            Else
                If prevCust.SequenceNumber = cust.SequenceNumber Then
                    filteredCustomerList.Add(prevCust)
                    filteredCustomerList.Add(cust)
                End If
                prevCust = cust
            End If
        Next

        Return filteredCustomerList

    End Function
End Class

Public Class CollectionRecord

    Public Enum ImportReturnCodes
        ImportSuccessful = 0
        Duplicates = 1
        UndefinedError = 2
    End Enum

    Public Class PickupRecords
        Public Property DatabaseID As Integer = 0
        Public Property SequenceNumber As Integer = 0
        Public Property AccountNumber As Integer = 0
        Public Property CustomerName As String = ""
        Public Property PickupDate As Date = Nothing
        Public Property GarbageBags As Integer = 0
        Public Property AdditionalItem As String = ""
        Public Property AdditionalItemPrice As Double = 0.0
        Public Property CustomerAddress As String = ""
    End Class

    Public Sub New(ByVal custID As Integer, ByVal dateCol As Date, ByVal qty As Integer, ByVal itemID As Integer, ByVal strDesc As String, ByVal dPrice As Double, ByVal routeName As String)
        _CustomerID = custID
        _DateCollected = dateCol
        _Quantity = qty
        _ItemID = itemID
        _ItemDescription = strDesc
        _ItemPrice = dPrice
        _RouteDescription = routeName
    End Sub

    Public Shared Sub SaveCollectedItemMobile(ByVal ConnectionString As String, ByVal colRecordObj As CollectionRecord)

        ' ----- Create the context
        Dim db As New DisposalData(ConnectionString)

        ' ----- Get a collection record object 
        Dim obj As CollectionRecord = (From cr In db.CollectionRecords
                                       Where cr.CustomerID = colRecordObj.CustomerID And cr.ItemID = colRecordObj.ItemID
                                       Select cr).SingleOrDefault

        ' ----- If there were records, then delete them 
        If Not obj Is Nothing Then
            db.CollectionRecords.DeleteOnSubmit(obj)
            db.SubmitChanges()
        End If

        ' ----- Add the new record 
        db.CollectionRecords.InsertOnSubmit(colRecordObj)
        db.SubmitChanges()

    End Sub

    Public Shared Sub UpdateCollectedItem(ByVal ConnectionString As String, ByVal colRecordObj As CollectionRecord)

        ' ----- Create the context
        Dim db As New DisposalData(ConnectionString)

        ' ----- Get a collection record object 
        Dim obj As CollectionRecord = (From cr In db.CollectionRecords
                                       Where cr.ID = colRecordObj.ID
                                       Select cr).SingleOrDefault

        ' ----- If there were records, then delete them 
        If Not obj Is Nothing Then
            obj.DateCollected = colRecordObj.DateCollected
            obj.Quantity = colRecordObj.Quantity
            obj.ItemDescription = colRecordObj.ItemDescription
            obj.ItemPrice = colRecordObj.ItemPrice
            db.SubmitChanges()
        End If

    End Sub

    Public Shared Sub SaveCollectedItemUpload(ByVal ConnectionString As String, ByVal colRecordObj As CollectionRecord)

        ' ----- Create the context
        Dim db As New DisposalData(ConnectionString)

        ' ----- Now save the record 
        db.CollectionRecords.InsertOnSubmit(colRecordObj)
        db.SubmitChanges()

    End Sub

    Public Shared Sub RemoveCollectedItem(ByVal ConnectionString As String, ByVal colRecordObj As CollectionRecord)

        ' ----- Create the context
        Dim db As New DisposalData(ConnectionString)

        ' ----- Get a collection record object 
        Dim obj As CollectionRecord = (From cr In db.CollectionRecords
                                       Where cr.CustomerID = colRecordObj.CustomerID And cr.ItemID = colRecordObj.ItemID
                                       Select cr).SingleOrDefault

        ' ----- If there were records, then delete them 
        If Not obj Is Nothing Then
            db.CollectionRecords.DeleteOnSubmit(obj)
            db.SubmitChanges()
        End If

    End Sub

    Public Shared Sub RemoveCollectedItemByID(ByVal ConnectionString As String, ByVal dbID As Integer)

        ' ----- Create the context
        Dim db As New DisposalData(ConnectionString)

        ' ----- Get a collection record object 
        Dim obj As CollectionRecord = (From cr In db.CollectionRecords
                                       Where cr.ID = dbID
                                       Select cr).SingleOrDefault

        ' ----- If there were records, then delete them 
        If Not obj Is Nothing Then
            db.CollectionRecords.DeleteOnSubmit(obj)
            db.SubmitChanges()
        End If

    End Sub

    Public Shared Function RetrieveCollectedItems(ByVal ConnectionString As String, ByVal customerID As Integer) As List(Of CollectionRecord)

        Dim returnedList As New List(Of CollectionRecord)

        ' ----- Create the context
        Dim db As New DisposalData(ConnectionString)

        ' ----- Get a collection record object 
        Dim colList = From cr In db.CollectionRecords
                      Where cr.CustomerID = customerID
                      Order By cr.ItemID
                      Select cr

        If Not colList Is Nothing Then
            For Each obj As CollectionRecord In colList
                returnedList.Add(obj)
            Next
        End If

        Return returnedList

    End Function

    Public Shared Function RetrieveCollectedItemsByDate(ByVal ConnectionString As String, ByVal dtePickup As Date, ByVal routeDesc As String) As List(Of PickupRecords)

        Dim returnedList As New List(Of CollectionRecord)

        ' ----- Create the context
        Dim db As New DisposalData(ConnectionString)

        ' ----- Get a collection record object 
        Dim colList = From cr In db.CollectionRecords
                      Join cu In db.Customers On cr.CustomerID Equals cu.CustomerNumber
                      Where cr.DateCollected >= dtePickup.ToShortDateString And cr.DateCollected < (dtePickup + New TimeSpan(1, 0, 0, 0)).ToShortDateString And cr.RouteDescription = routeDesc
                      Order By cu.SequenceNumber, cr.ItemID
                      Select New PickupRecords With
                              {
                                  .DatabaseID = cr.ID,
                                  .SequenceNumber = cu.SequenceNumber,
                                  .AccountNumber = cu.CustomerNumber,
                                  .CustomerName = cu.RouteLocation_LastName & ", " & cu.RouteLocation_FirstName,
                                  .GarbageBags = IIf(cr.ItemID = 1, cr.Quantity, 0),
                                  .PickupDate = cr.DateCollected,
                                  .AdditionalItem = IIf(cr.ItemID <> 1, cr.ItemDescription, ""),
                                  .AdditionalItemPrice = IIf(cr.ItemID <> 1, cr.ItemPrice, 0.0),
                                  .CustomerAddress = cu.RouteLocation_Address & " (" & cu.RouteLocation_City & ")"
                              }

        Return colList.ToList

    End Function

    Public Shared Function GetNumberCollectedBags(ByVal ConnectionString As String, ByVal customerID As Integer) As Integer

        ' ----- Create the context
        Dim db As New DisposalData(ConnectionString)

        ' ----- Get a collection record object 
        Dim numberOfBags As Integer = (From cr In db.CollectionRecords
                                       Where cr.CustomerID = customerID And cr.ItemID = 1
                                       Select cr.Quantity).SingleOrDefault

        Return numberOfBags

    End Function

    Public Shared Function GetCollectedItemsWithinRangeByDate(ByVal ConnectionString As String, ByVal dteStart As Date, ByVal dteEnd As Date) As List(Of CollectionRecord)

        ' ----- Create the context
        Dim db As New DisposalData(ConnectionString)

        ' ----- Get a collection record object 
        Dim numObj = From cr In db.CollectionRecords
                     Where cr.DateCollected >= dteStart And cr.DateCollected <= (dteEnd + New TimeSpan(1, 0, 0, 0))
                     Select cr

        Return numObj.ToList

    End Function

    Public Shared Function GetNumberCollectedBagsWithinRangeByCustomer(ByVal ConnectionString As String, ByVal customerID As Integer, ByVal dteStart As Date, ByVal dteEnd As Date) As Integer

        ' ----- Create the context
        Dim db As New DisposalData(ConnectionString)

        ' ----- Get a collection record object 
        Dim numObj = From cr In db.CollectionRecords
                     Where cr.CustomerID = customerID And cr.ItemID = 1 And cr.DateCollected >= dteStart And cr.DateCollected <= (dteEnd + New TimeSpan(1, 0, 0, 0))
                     Select cr.Quantity

        Dim sumBags As Integer = 0
        If Not numObj Is Nothing Then
            For Each intItem As Integer In numObj
                sumBags += intItem
            Next
        End If

        Return sumBags

    End Function

    Public Shared Function GetNumberCollectedItemsWithinRange(ByVal ConnectionString As String, ByVal customerID As Integer, ByVal dteStart As Date, ByVal dteEnd As Date) As List(Of CAdditionalItems)

        ' ----- Create the context
        Dim db As New DisposalData(ConnectionString)

        ' ----- Get a collection record object (everything but bags)
        Dim numberOfItems As List(Of CAdditionalItems) = (From cr In db.CollectionRecords
                                                          Where cr.CustomerID = customerID And cr.ItemID > 1 And cr.DateCollected >= dteStart And cr.DateCollected <= (dteEnd + New TimeSpan(1, 0, 0, 0))
                                                          Select New CAdditionalItems With
                                                                 {
                                                                     .AdditionalItems = cr.ItemDescription,
                                                                     .AdditionalItemCost = cr.ItemPrice
                                                                 }).ToList

        Return numberOfItems

    End Function

    Public Shared Function GenerateXML(ByVal ConnectionString As String, ByVal collectionDataFileName As String) As Boolean

        Dim db As New DisposalData(ConnectionString)

        ' ----- Attempt to delete the existing file 
        Try
            My.Computer.FileSystem.DeleteFile(collectionDataFileName)
        Catch ex As Exception
        End Try

        ' -----We can assume that the records will contain a blank slate
        Dim colRec As List(Of CollectionRecord) = (From cr In db.CollectionRecords Select cr).ToList

        If Not colRec Is Nothing Then

            Dim SerXML As New XmlSerializer(GetType(List(Of CollectionRecord)))

            Using fs As New FileStream(collectionDataFileName, FileMode.Create, FileAccess.Write)
                SerXML.Serialize(fs, colRec)
            End Using

        End If

        Return True

    End Function

    Public Shared Function ReadXML(ByVal ConnectionString As String, ByVal collectionRecordFileName As String, ByRef returnDataPrevList As Integer, ByRef returnDataCurrList As Integer) As ImportReturnCodes

        ' ----- Open the collection file 
        Using fs As New FileStream(collectionRecordFileName, FileMode.Open, FileAccess.Read)

            ' ----- Retrieve the information from the server 
            Dim SerXML As New XmlSerializer(GetType(List(Of CollectionRecord)))
            Dim colRec As List(Of CollectionRecord) = DirectCast(SerXML.Deserialize(fs), List(Of CollectionRecord))

            '* just in case we need it later *'
            returnDataCurrList = colRec.Count

            ' ----- If we have data, post it to the database 
            If colRec.Count > 0 Then

                Dim db As New DisposalData(ConnectionString)

                Dim collectionDay As DateTime = colRec(0).DateCollected.Date
                Dim nextDay As DateTime = collectionDay + New TimeSpan(1, 0, 0, 0)

                '* at this point, see if we have any records already '*
                Dim previousList As List(Of CollectionRecord) = (From l In db.CollectionRecords
                                                                 Where l.RouteDescription = colRec(0).RouteDescription And l.DateCollected >= collectionDay And l.DateCollected < nextDay Select l).ToList

                '* we need to handle this some how *'
                If previousList.Count > 0 Then
                    returnDataPrevList = previousList.Count
                    Return ImportReturnCodes.Duplicates
                End If

                For Each obj As CollectionRecord In colRec
                    SaveCollectedItemUpload(ConnectionString, obj)
                Next

                Return ImportReturnCodes.ImportSuccessful

            End If

        End Using

        Return True

    End Function

    Public Shared Sub RemoveAllCollectedItems(ByVal ConnectionString As String, ByVal customerID As Integer, ByVal dtePickup As Date)

        Dim db As New DisposalData(ConnectionString)

        Dim itmX As List(Of CollectionRecord) = (From i In db.CollectionRecords
                                                 Where i.CustomerID = customerID And i.DateCollected = dtePickup
                                                 Select i).ToList

        For Each obj As CollectionRecord In itmX
            db.CollectionRecords.DeleteOnSubmit(obj)
            db.SubmitChanges()
        Next

    End Sub

    Public Shared Function DeleteRoute(ByVal ConnectionString As String)

        Try

            ' ----- Get the data object 
            Dim db As New DisposalData(ConnectionString)

            ' ----- Select all of the collection items 
            Dim crList As List(Of CollectionRecord) = (From cr In db.CollectionRecords Select cr).ToList

            ' ----- Remove all of the items 
            For Each obj As CollectionRecord In crList
                db.CollectionRecords.DeleteOnSubmit(obj)
            Next

            ' ----- Save it back to the database 
            db.SubmitChanges()

            Return True

        Catch ex As Exception

            Return False

        End Try

    End Function

    Public Shared Function ReturnUniqueRouteDescriptions(ByVal ConnectionString As String) As List(Of String)

        Dim db As New DisposalData(ConnectionString)

        Dim strList = (From r In db.CollectionRecords
                       Order By r.RouteDescription
                       Select r.RouteDescription).Distinct

        Return strList.ToList

    End Function

    Public Shared Function ReturnCollectionDuplicates(ConnectionString As String, collectionDate As DateTime) As List(Of CollectionRecord)

        ' ----- Create the context
        Dim db As New DisposalData(ConnectionString)

        ' ----- Get a collection record object 
        Dim dupItems As List(Of CollectionRecord) = (From cr In db.CollectionRecords
                                                     Where cr.DateCollected >= collectionDate And cr.DateCollected < collectionDate
                                                     Order By cr.CustomerID
                                                     Select cr).ToList


        Return dupItems

    End Function

End Class

Public Class ItemsCollected

    Public Property ID As Integer = 0
    Public Property ItemDescription As String = ""
    Public Property MinimumPrice As Double = 0.0
    Public Property MaximumPrice As Double = 0.0

    Public Sub New()
        _ID = 0
        _ItemDescription = ""
        _MinimumPrice = 0.0
        _MaximumPrice = 0.0
    End Sub

    Public Sub New(ByVal nID As Integer, ByVal strDesc As String, ByVal dMin As Double, ByVal dMax As Double)
        _ID = nID
        _ItemDescription = strDesc
        _MinimumPrice = dMin
        _MaximumPrice = dMax
    End Sub

    Public Overrides Function ToString() As String
        Return _ItemDescription
    End Function

    Public Shared Function OpenItemsCollectedFile() As List(Of ItemsCollected)

        Dim tempListing As New List(Of ItemsCollected)

        Try

            ' ----- Open the billing type file 
            Using fs As New StreamReader(My.Application.Info.DirectoryPath & "\ItemsCollected.xml")

                ' ----- Read the data from the file 
                Dim billingTypeSerialization As New XmlSerializer(GetType(List(Of ItemsCollected)))
                tempListing = billingTypeSerialization.Deserialize(fs)

                ' ----- If the listing is blank, then create a default file 
                If tempListing.Count = 0 Then
                    tempListing = CreateItemsCollectedFile()
                    SaveItemsCollectedFile(tempListing)
                End If

            End Using

        Catch ex As Exception

            ' ----- If we get here, we are assuming the data file is no longer there
            tempListing = CreateItemsCollectedFile()
            SaveItemsCollectedFile(tempListing)

        End Try

        Return tempListing

    End Function

    Public Shared Sub SaveItemsCollectedFile(ByVal tempList As List(Of ItemsCollected))

        Try

            Using fs As New StreamWriter(My.Application.Info.DirectoryPath & "\ItemsCollected.xml")

                Dim billingTypeSerialization As New XmlSerializer(GetType(List(Of ItemsCollected)))
                billingTypeSerialization.Serialize(fs, tempList)

            End Using

        Catch ex As Exception

        End Try

    End Sub

    Private Shared Function CreateItemsCollectedFile() As List(Of ItemsCollected)

        Dim tempList As New List(Of ItemsCollected)

        tempList.Add(New ItemsCollected(1, "Garbage Bags", 0.0, 0.0))

        tempList.Add(New ItemsCollected(2, "Bath Tub - Fiberglass", 10.0, 10.0))
        tempList.Add(New ItemsCollected(3, "Bath Tub - Tin", 10.0, 10.0))
        tempList.Add(New ItemsCollected(4, "Bath Tub - Cast Iron", 15.0, 15.0))
        tempList.Add(New ItemsCollected(5, "Bicycle", 3.0, 3.0))
        tempList.Add(New ItemsCollected(6, "Box Spring - Twin", 5.0, 5.0))
        tempList.Add(New ItemsCollected(7, "Box Spring - Full", 8.0, 8.0))
        tempList.Add(New ItemsCollected(8, "Carpet (12x12)", 10.0, 10.0))
        tempList.Add(New ItemsCollected(9, "Carpet Padding (12x12)", 10.0, 10.0))
        tempList.Add(New ItemsCollected(10, "Chair - Lawn", 0.0, 0.0))
        tempList.Add(New ItemsCollected(11, "Chair - Kitchen", 2.0, 2.0))
        tempList.Add(New ItemsCollected(12, "Chair - Living Room", 5.0, 5.0))
        tempList.Add(New ItemsCollected(13, "Chair - Recliners", 7.0, 7.0))
        tempList.Add(New ItemsCollected(14, "Christmas Tree", 2.0, 5.0))
        tempList.Add(New ItemsCollected(15, "Computer Monitor", 10.0, 10.0))
        tempList.Add(New ItemsCollected(16, "Couch - Regular", 7.0, 10.0))
        tempList.Add(New ItemsCollected(17, "Couch - Hide-a-Bed", 15.0, 15.0))
        tempList.Add(New ItemsCollected(18, "Desk", 10.0, 10.0))
        tempList.Add(New ItemsCollected(19, "Dishwasher", 5.0, 5.0))
        tempList.Add(New ItemsCollected(20, "Door - Storm", 3.0, 3.0))
        tempList.Add(New ItemsCollected(21, "Door - Wood", 5.0, 5.0))
        tempList.Add(New ItemsCollected(22, "Dresser", 5.0, 10.0))
        tempList.Add(New ItemsCollected(23, "Dryer", 5.0, 5.0))
        tempList.Add(New ItemsCollected(24, "Furnace", 10.0, 10.0))
        tempList.Add(New ItemsCollected(25, "Gas Grill (without tank)", 5.0, 5.0))
        tempList.Add(New ItemsCollected(26, "Hot Water Tank (Empty)", 5.0, 7.0))
        tempList.Add(New ItemsCollected(27, "Lawnmower", 5.0, 5.0))
        tempList.Add(New ItemsCollected(28, "Mattress - Twin", 5.0, 5.0))
        tempList.Add(New ItemsCollected(29, "Mattress - Full", 8.0, 8.0))
        tempList.Add(New ItemsCollected(30, "Microwave", 3.0, 5.0))
        tempList.Add(New ItemsCollected(31, "Sink - Fiberglass", 3.0, 3.0))
        tempList.Add(New ItemsCollected(32, "Sink - Tin", 3.0, 3.0))
        tempList.Add(New ItemsCollected(33, "Sink - Cast Iron", 5.0, 5.0))
        tempList.Add(New ItemsCollected(34, "Stove", 5.0, 5.0))
        tempList.Add(New ItemsCollected(35, "Swing Set", 10.0, 10.0))
        tempList.Add(New ItemsCollected(36, "Table - Kitchen", 7.0, 10.0))
        tempList.Add(New ItemsCollected(37, "Table - Picnic", 15.0, 15.0))
        tempList.Add(New ItemsCollected(38, "Tire - Passenger", 3.0, 3.0))
        tempList.Add(New ItemsCollected(39, "Tire - Truck", 5.0, 5.0))
        tempList.Add(New ItemsCollected(40, "Toilet", 5.0, 5.0))
        tempList.Add(New ItemsCollected(41, "Treadmill", 7.0, 10.0))
        tempList.Add(New ItemsCollected(42, "TV - Table Model", 15.0, 15.0))
        tempList.Add(New ItemsCollected(43, "TV - Console", 20.0, 20.0))
        tempList.Add(New ItemsCollected(44, "Vacuum", 2.0, 2.0))
        tempList.Add(New ItemsCollected(45, "Vanity", 5.0, 5.0))
        tempList.Add(New ItemsCollected(46, "Washer", 5.0, 5.0))
        tempList.Add(New ItemsCollected(47, "Water Softner - Empty", 5.0, 5.0))
        tempList.Add(New ItemsCollected(48, "Water Softner - Full of Salt", 10.0, 15.0))
        tempList.Add(New ItemsCollected(49, "Waterbed Mattress (water drained)", 5.0, 5.0))
        tempList.Add(New ItemsCollected(50, "Window (depends on size)", 3.0, 10.0))

        Return tempList

    End Function

End Class

Public Class CBillingData
    Public Property AccountNumber As Integer = 0
    Public Property SequenceNumber As Integer = 0
    Public Property CustomerName As String = ""
    Public Property FirstName As String = ""
    Public Property LastName As String = ""
    Public Property Address As String = ""
    Public Property City As String = ""
    Public Property State As String = ""
    Public Property ZipCode As String = ""
    Public Property ListHeader As String = ""
    Public Property StartingBalance As Double = 0.0
    Public Property BillingType As String = ""
    Public Property MonthlyCharge As Double = 0.0
    Public Property TotalCharge As Double = 0.0
    Public Property BagsAllowedThisPeriod As Integer = 0
    Public Property BagsAllowedByMonth As List(Of Integer)
    Public Property BagsPickedUpThisPeriod As Integer = 0
    Public Property BagsPickedUpByMonth As List(Of Integer)
    Public Property ExtraBagsQty As Integer = 0
    Public Property ExtraBagsCost As Double = 0.0
    Public Property AdditionalItems As String = ""
    Public Property AdditionalItemCost As Double = 0.0
    Public Property MonthsToBill As Integer = 0
    Public Property TaxRate As Double = 0.0
    Public Property DelinquentAccount As Boolean = False
    Public Property GoInAfter As Boolean = False
    Public Property GoInAfterAmount As Double = 0.0
End Class

Public Class CBillingDataExtended

    Public Property BillDate As Date = Nothing
    Public Property BillingData As New CBillingData

    Public Overrides Function ToString() As String
        Return _BillingData.CustomerName & " - " & BillDate.Date
    End Function

End Class

Public Class CAdditionalItems
    Public Property AdditionalItems As String = ""
    Public Property AdditionalItemCost As Double = 0.0
End Class

Public Class BillingTypes

    Public Property ID As Integer = 0
    Public Property Amount As Double = 0.0
    Public Property Designation As String = ""
    Public Property WeeklyBagAllowance As Integer = 0

    Public Sub New()
        _ID = 0
        _Amount = 0.0
        _Designation = ""
        _WeeklyBagAllowance = 0
    End Sub

    Public Sub New(ByVal nID As Integer, ByVal dAmt As Double, ByVal strDes As String, ByVal weekBag As Integer)
        _ID = nID
        _Amount = dAmt
        _Designation = strDes
        _WeeklyBagAllowance = weekBag
    End Sub

    Public Shared Function OpenBillingFile() As List(Of BillingTypes)

        Dim tempListing As New List(Of BillingTypes)

        Try

            ' ----- Open the billing type file 
            Using fs As New StreamReader(My.Application.Info.DirectoryPath & "\billingtypes.xml")

                ' ----- Read the data from the file 
                Dim billingTypeSerialization As New XmlSerializer(GetType(List(Of BillingTypes)))
                tempListing = billingTypeSerialization.Deserialize(fs)

                ' ----- If the listing is blank, then create a default file 
                If tempListing.Count = 0 Then
                    tempListing = CreateDefaultBillingFile()
                    SaveBillingFile(tempListing)
                End If

            End Using

        Catch ex As Exception

            ' ----- If we get here, we are assuming the data file is no longer there
            tempListing = CreateDefaultBillingFile()
            SaveBillingFile(tempListing)
        End Try

        Return tempListing

    End Function

    Public Shared Sub SaveBillingFile(ByVal tempList As List(Of BillingTypes))

        Try

            Using fs As New StreamWriter(My.Application.Info.DirectoryPath & "\billingtypes.xml")

                Dim billingTypeSerialization As New XmlSerializer(GetType(List(Of BillingTypes)))
                billingTypeSerialization.Serialize(fs, tempList)

            End Using

        Catch ex As Exception

        End Try

    End Sub

    Private Shared Function CreateDefaultBillingFile() As List(Of BillingTypes)

        Dim tempList As New List(Of BillingTypes)
        tempList.Add(New BillingTypes(1, 9.0, "A", 1))
        tempList.Add(New BillingTypes(2, 13.0, "B", 2))
        tempList.Add(New BillingTypes(3, 16.0, "C", 3))
        tempList.Add(New BillingTypes(4, 15.0, "D", 0))
        tempList.Add(New BillingTypes(5, 0.0, "E", 0))
        tempList.Add(New BillingTypes(6, 0.0, "F", 0))

        Return tempList

    End Function

    Public Overrides Function ToString() As String
        Return "Type " & _Designation & ": " & String.Format("${0:f2}", _Amount)
    End Function

End Class

Public Class Payments

    Public Class PaymentListingReport
        Public Property AccountNumber As Integer = 0
        Public Property CustomerName As String = ""
        Public Property CustomerAddress As String = ""
        Public Property PaymentDate As Date = Nothing
        Public Property PaymentAmount As Single = 0.0
        Public Property CheckNumber As String = ""
        Public Property Description As String = ""
        Public Property CashAmountForReport As Single = 0.0
        Public Property CheckAmountForReport As Single = 0.0
        Public Property CreditCardAmountForReport As Single = 0.0
        Public Property AutoPayAmountForReport As Single = 0.0
        Public Property CompanyCreditAmountForReport As Single = 0.0
        Public Property IsCheck As Boolean = False
        Public Property IsMoneyOrder As Boolean = False
    End Class

    Public Class CRevenueListing
        Public Property TaxRate As Double = 0.0
        Public Property TotalPayment As Double = 0.0
        Public Property Revenue As Double = 0.0
        Public Property Taxes As Double = 0.0
        Public Property CreditCardUsed As Boolean = False
    End Class

    Public Class CRevenueReport
        Public Property ReportStartDate As Date = Nothing
        Public Property ReportEndDate As Date = Nothing
        Public Property IncomeNoTax As Double = 0.0
        Public Property Income8Tax As Double = 0.0
        Public Property TaxCollected8Tax As Double = 0.0
        Public Property TotalIncome As Double = 0.0
        Public Property TotalTax As Double = 0.0
        Public Property TotalCollected As Double = 0.0
        Public Property TotalCreditCollected As Double = 0.0
        Public Property TotalNonCreditCollected As Double = 0.0
    End Class

    Public Sub New(ByVal dbID As Integer, ByVal datePayment As Date, ByVal amountPayment As Single, ByVal customerNumber As Integer, ByVal methodOfPay As Integer, ByVal nCheckNumber As Long, strDesc As String, strCCAuth As String)

        _ID = dbID
        _PaymentDate = datePayment
        _PaymentAmount = amountPayment
        _CustomerID = customerNumber
        _MOP = methodOfPay
        _CheckNumber = nCheckNumber
        _Description = strDesc
        _CreditCardAuthNumber = strCCAuth

    End Sub

    Public ReadOnly Property MethodOfPaymentDesc As String
        Get
            Select Case _MOP
                Case 0
                    Return "Cash"
                Case 1
                    Return "Check"
                Case 2
                    Return "Money Order"
                Case 3
                    Return "Other"
                Case 4
                    Return "Credit Card"
                Case Else
                    Return "Cash"
            End Select
        End Get
    End Property

    Public Shared Function ReturnPaymentsForDate(ByVal ConnectionString As String, ByVal dtePaymentStart As Date, ByVal dtePaymentEnd As Date) As List(Of PaymentListingReport)

        Dim db As New DisposalData(ConnectionString)

        Dim paymentList = From p In db.Payments
                          Join c In db.Customers On p.CustomerID Equals c.CustomerNumber
                          Where p.PaymentDate.Date >= dtePaymentStart And p.PaymentDate.Date <= dtePaymentEnd
                          Order By c.RouteLocation_LastName, c.RouteLocation_FirstName
                          Select New PaymentListingReport With
                              {
                              .AccountNumber = c.CustomerNumber,
                              .CustomerName = c.ReverseFullName,
                              .CustomerAddress = c.RouteLocation_Address,
                              .PaymentDate = p.PaymentDate,
                              .PaymentAmount = p.PaymentAmount,
                              .Description = p.Description,
                              .CheckNumber = If(p.MOP = 0, "CASH", If(p.MOP = 2, "M/O", If(p.MOP = 4, "Credit", If(p.PaymentAmount < 0.0, "CR", p.CheckNumber.ToString)))),
                              .IsMoneyOrder = p.MOP = 2,
                              .IsCheck = If(p.MOP = 0, False, If(p.MOP = 2, False, If(p.MOP = 4, False, If(p.PaymentAmount < 0.0, False, True)))),
                              .CashAmountForReport = If(p.MOP = 0, p.PaymentAmount, 0.0),
                              .CreditCardAmountForReport = If(p.MOP = 4, p.PaymentAmount, 0.0)
                              }

        Dim fullListing = paymentList.ToList

        For Each item As PaymentListingReport In fullListing

            If item.IsCheck And item.CheckNumber <> "0" Or item.IsMoneyOrder Then
                item.CheckAmountForReport = item.PaymentAmount
            End If

            If item.CheckNumber = "0" And item.Description.ToUpper = "AUTOPAY" Then
                item.AutoPayAmountForReport = item.PaymentAmount
            End If

            If item.CheckNumber = "CR" Then
                item.CompanyCreditAmountForReport = item.PaymentAmount
            End If

        Next

        Return fullListing

    End Function

    Public Shared Function ReturnPaymentsForDateByCheck(ByVal ConnectionString As String, ByVal checkNumber As Long) As List(Of PaymentListingReport)

        Dim db As New DisposalData(ConnectionString)

        Dim paymentList = From p In db.Payments
                          Join c In db.Customers On p.CustomerID Equals c.CustomerNumber
                          Where p.CheckNumber = checkNumber
                          Order By p.PaymentDate, c.RouteLocation_LastName, c.RouteLocation_FirstName
                          Select New PaymentListingReport With
                                 {
                                     .AccountNumber = c.CustomerNumber,
                                     .CustomerName = c.ReverseFullName,
                                     .CustomerAddress = c.RouteLocation_Address,
                                     .PaymentDate = p.PaymentDate,
                                     .PaymentAmount = p.PaymentAmount,
                                     .Description = p.Description,
                                     .CheckNumber = If(p.MOP = 0, "CASH", If(p.MOP = 2, "M/O", If(p.MOP = 4, "Credit", If(p.PaymentAmount < 0.0, "CR", p.CheckNumber.ToString))))
                                 }

        Return paymentList.ToList

    End Function

    Public Shared Function ReturnAllPayments(ByVal ConnectionString As String, ByVal customerID As Integer) As List(Of Payments)

        Dim db As New DisposalData(ConnectionString)

        Dim paymentList = From p In db.Payments
                          Where p.CustomerID = customerID
                          Order By p.PaymentDate Descending
                          Select p

        Return paymentList.ToList

    End Function

    Public Shared Function ReturnSumPaymentsWithinRange(ByVal ConnectionString As String, ByVal customerID As Integer, ByVal dteStart As Date, ByVal dteEnd As Date) As Double

        Dim db As New DisposalData(ConnectionString)

        Dim pay As Double = 0.0

        Try
            pay = (From p In db.Payments
                   Where p.CustomerID = customerID And p.PaymentDate >= dteStart And p.PaymentDate <= dteEnd
                   Select p.PaymentAmount).Sum
        Catch ex As Exception

        End Try

        Return pay

    End Function

    Public Sub SavePayment(ByVal ConnectionString As String)

        Dim db As New DisposalData(ConnectionString)

        If Me.ID = 0 Then
            db.Payments.InsertOnSubmit(Me)
        Else
            Dim obj = (From p In db.Payments Where p.ID = Me.ID Select p).SingleOrDefault

            If Not obj Is Nothing Then
                obj.PaymentDate = Me.PaymentDate
                obj.PaymentAmount = Me.PaymentAmount
                obj.MOP = Me.MOP
                obj.CheckNumber = Me.CheckNumber
                obj.Description = Me.Description
            End If

        End If

        db.SubmitChanges()

    End Sub

    Public Sub SaveCredit(ByVal ConnectionString As String)

        Dim db As New DisposalData(ConnectionString)

        If Me.ID = 0 Then
            db.Payments.InsertOnSubmit(Me)
        Else
            Dim obj = (From p In db.Payments Where p.ID = Me.ID Select p).SingleOrDefault

            If Not obj Is Nothing Then
                obj.PaymentDate = Me.PaymentDate
                obj.PaymentAmount = Me.PaymentAmount
                obj.MOP = Me.MOP
                obj.CheckNumber = Me.CheckNumber
            End If

        End If

        db.SubmitChanges()

    End Sub

    Public Shared Function ReturnPaymentDetails(ByVal ConnectionString As String, ByVal paymentID As Integer) As Payments

        Dim db As New DisposalData(ConnectionString)

        Dim paymentDetail = (From p In db.Payments Where p.ID = paymentID Select p).SingleOrDefault

        Return paymentDetail

    End Function

    Public Shared Sub DeletePayment(ByVal ConnectionString As String, ByVal paymentID As Integer)

        Dim db As New DisposalData(ConnectionString)

        Dim paymentDetail = (From p In db.Payments Where p.ID = paymentID Select p).SingleOrDefault

        If Not paymentDetail Is Nothing Then
            db.Payments.DeleteOnSubmit(paymentDetail)
            db.SubmitChanges()
        End If

    End Sub

    Public Shared Function ReturnRevenueValue(ByVal ConnectionString As String, ByVal dtePaymentStart As Date, ByVal dtePaymentEnd As Date) As CRevenueReport

        Dim db As New DisposalData(ConnectionString)

        ' ----- Creates a list of payments broken down into revenue
        Dim revenue As List(Of CRevenueListing) = (From p In db.Payments
                                                   Join c In db.Customers On p.CustomerID Equals c.CustomerNumber
                                                   Where p.PaymentDate.Date >= dtePaymentStart And p.PaymentDate.Date <= dtePaymentEnd
                                                   Select New CRevenueListing With
                                                          {
                                                              .TaxRate = c.TaxRate.Value,
                                                              .CreditCardUsed = (p.MOP = 4),
                                                              .TotalPayment = Decimal.ToDouble(p.PaymentAmount),
                                                              .Revenue = Decimal.ToDouble(p.PaymentAmount) / (1.0 + c.TaxRate.Value),
                                                              .Taxes = Decimal.ToDouble(p.PaymentAmount) - (Decimal.ToDouble(p.PaymentAmount) / (1.0 + c.TaxRate.Value))
                                                          }).ToList

        ' ----- create the report object 
        Dim rptObj As New CRevenueReport

        ' ----- set the dates 
        rptObj.ReportStartDate = dtePaymentStart
        rptObj.ReportEndDate = dtePaymentEnd

        ' ----- loop through our revenue collection 
        For Each obj As CRevenueListing In revenue

            If obj.TaxRate = 0.0 Then
                rptObj.IncomeNoTax += obj.Revenue
            End If

            If obj.TaxRate = 0.08 Then
                rptObj.Income8Tax += obj.Revenue
                rptObj.TaxCollected8Tax += obj.Taxes
            End If

            rptObj.TotalIncome += obj.Revenue
            rptObj.TotalTax += obj.Taxes

            ' ----- added for credit cards 
            If obj.CreditCardUsed Then
                rptObj.TotalCreditCollected += obj.TotalPayment
            Else
                rptObj.TotalNonCreditCollected += obj.TotalPayment
            End If

            rptObj.TotalCollected += obj.TotalPayment

        Next

        Return rptObj

    End Function

    Public Shared Function DoesPaymentExist(ByVal connectionString As String, ByVal customerNumber As Integer, ByVal dtePayment As Date) As Boolean

        Dim db As New DisposalData(connectionString)

        Dim hasPayment As Integer = (From p In db.Payments Where p.CustomerID = customerNumber And p.PaymentDate.Date = dtePayment.Date Select p.CheckNumber).Count

        If hasPayment > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

End Class

Public Class Transactions

    Public Shared Function ReturnAllTransactions(ByVal connectionString As String, ByVal billingDate As Date) As List(Of Transactions)

        Dim db As New DisposalData(connectionString)

        Dim trans = (From t In db.Transactions
                     Where t.TransDate >= billingDate And t.TransDate < billingDate + New TimeSpan(1, 0, 0, 0)
                     Select t).ToList

        Return trans

    End Function

    Public Shared Function ReturnAllTransactionDatesByCustomer(ByVal connectionString As String, customerNumber As Integer) As List(Of Date)

        Dim db As New DisposalData(connectionString)

        Dim trans As List(Of Date) = (From t In db.Transactions Where t.CustomerID = customerNumber Order By t.TransDate Select t.TransDate).Distinct.ToList

        Return trans

    End Function

    Public Shared Function ReturnLatestTransaction(ByVal connectionstring As String) As List(Of Transactions)

        Dim db As New DisposalData(connectionstring)

        Dim trans = (From t In db.Transactions
                     Where t.Description = "Sales Tax" And t.TransDate >= New Date(2012, 1, 1)
                     Order By t.TransDate
                     Select t).ToList

        Return trans

    End Function

    Public Shared Function LookupTransactions(ByVal connectionString As String, ByVal customerNumber As Integer, ByVal billingDate As Date) As List(Of Transactions)

        Dim db As New DisposalData(connectionString)

        Dim trans = (From t In db.Transactions
                     Where t.CustomerID = customerNumber And t.TransDate >= billingDate And t.TransDate < billingDate + New TimeSpan(1, 0, 0, 0)
                     Select t).ToList

        Return trans

    End Function

    Public Shared Sub DeleteTransactions(ByVal connectionString As String, ByVal customerNumber As Integer, ByVal billingDate As Date)

        Dim db As New DisposalData(connectionString)

        Dim transList = From t In db.Transactions
                        Where t.CustomerID = customerNumber And t.TransDate >= billingDate And t.TransDate < billingDate + New TimeSpan(1, 0, 0, 0)
                        Select t

        For Each trans As Transactions In transList.ToList
            db.Transactions.DeleteOnSubmit(trans)
            db.SubmitChanges()
        Next

    End Sub

    Public Shared Sub SaveTransaction(ByVal connectionString As String, ByVal customerNumber As Integer, ByVal billingDate As Date, ByVal description As String, ByVal amt As Double)

        Dim db As New DisposalData(connectionString)

        Dim newTransObj As New Transactions
        newTransObj.CustomerID = customerNumber
        newTransObj.Description = description
        newTransObj.TransDate = billingDate
        newTransObj.Amount = amt
        newTransObj.Reference = "Charge"

        db.Transactions.InsertOnSubmit(newTransObj)
        db.SubmitChanges()

    End Sub


    Public Shared Sub UpdateBillingDate(ByVal connectionString As String, ByVal customerNumber As Integer, ByVal billingDate As Date, ByVal newBillingDate As Date)

        Dim db As New DisposalData(connectionString)

        Dim trans = (From t In db.Transactions
                     Where t.CustomerID = customerNumber And t.TransDate >= billingDate And t.TransDate < billingDate + New TimeSpan(1, 0, 0, 0)
                     Select t).ToList

        For Each transaction In trans
            transaction.TransDate = newBillingDate
            db.SubmitChanges()
        Next

    End Sub

End Class

Public Class RentalTransaction

    Public Class RentalTransactionItem
        Public Property TransDate As Date = Nothing
        Public Property TotalAmount As Double = 0.0
    End Class

    Public Class RentalTransactionSummary
        Public Property Customer As New RentalCustomer
        Public Property TransactionList As New List(Of RentalTransactionItem)
    End Class

    Public Shared Sub DeleteTransactions(ByVal connectionString As String, ByVal customerNumber As Integer, ByVal billingDate As Date)

        Dim db As New DisposalData(connectionString)

        Dim transList = From t In db.RentalTransactions
                        Where t.CustomerID = customerNumber And t.BillingDate >= billingDate And t.BillingDate < billingDate + New TimeSpan(1, 0, 0, 0)
                        Select t

        For Each trans As RentalTransaction In transList.ToList
            db.RentalTransactions.DeleteOnSubmit(trans)
            db.SubmitChanges()
        Next

    End Sub

    Public Shared Function ReturnAllTransactions(ByVal connectionString As String, ByVal billingDate As Date) As List(Of RentalTransaction)

        Dim db As New DisposalData(connectionString)

        Dim trans = (From t In db.RentalTransactions
                     Where t.BillingDate >= billingDate And t.BillingDate < billingDate + New TimeSpan(1, 0, 0, 0)
                     Select t).ToList

        Return trans

    End Function

    Public Shared Function ReturnAllTransactionsForCustomer(ByVal connectionString As String, ByVal customerNumber As Integer) As RentalTransactionSummary

        Dim db As New DisposalData(connectionString)

        Dim rentalObject As New RentalTransactionSummary

        ' ----- Get the customer object 
        rentalObject.Customer = RentalCustomer.GetRentalCustomer(connectionString, customerNumber)

        rentalObject.TransactionList = (From p In db.RentalTransactions
                                        Where p.CustomerID = customerNumber
                                        Group p By p.BillingDate Into g = Group
                                        Select New RentalTransactionItem With
                                               {
                                                   .TransDate = g.FirstOrDefault.BillingDate,
                                                   .TotalAmount = g.Sum(Function(p) p.Amount)
                                               }).ToList

        Return rentalObject

    End Function

    Public Shared Sub SaveTransaction(ByVal connectionString As String, ByVal customerNumber As Integer, ByVal serviceDate As Date, ByVal description As String, ByVal amt As Double, qty As Integer, billingDate As Date)

        Dim db As New DisposalData(connectionString)

        Dim newTransObj As New RentalTransaction
        newTransObj.CustomerID = customerNumber
        newTransObj.Description = description
        newTransObj.TransDate = serviceDate
        newTransObj.Amount = amt
        newTransObj.Qty = qty
        newTransObj.Reference = "Charge"
        newTransObj.BillingDate = billingDate

        db.RentalTransactions.InsertOnSubmit(newTransObj)
        db.SubmitChanges()

    End Sub

    Public Shared Function LookupTransactions(ByVal connectionString As String, ByVal customerNumber As Integer, ByVal billingDate As Date) As List(Of RentalTransaction)

        Dim db As New DisposalData(connectionString)

        Dim trans = (From t In db.RentalTransactions
                     Where t.CustomerID = customerNumber And t.BillingDate >= billingDate And t.BillingDate < billingDate + New TimeSpan(1, 0, 0, 0)
                     Select t).ToList

        Return trans

    End Function

End Class

Public Class VacationCredit

    Public Sub SaveVacationDates(connectionString As String)

        ' ----- Save the vacation credit 
        Dim db As New DisposalData(connectionString)
        db.VacationCredits.InsertOnSubmit(Me)
        db.SubmitChanges()

    End Sub

    Public Sub EditVacationDates(connectionString As String, existingID As Integer)

        ' ----- Save the vacation credit 
        Dim db As New DisposalData(connectionString)

        Dim vc As VacationCredit = (From v In db.VacationCredits Where v.ID = existingID Select v).SingleOrDefault

        If Not vc Is Nothing Then
            vc.DateStart = Me.DateStart
            vc.DateEnd = Me.DateEnd
            db.SubmitChanges()
        End If

    End Sub

    Public Shared Sub DeleteVacationDates(connectionString As String, existingID As Integer)

        ' ----- Save the vacation credit 
        Dim db As New DisposalData(connectionString)

        Dim vc As VacationCredit = (From v In db.VacationCredits Where v.ID = existingID Select v).SingleOrDefault

        If Not vc Is Nothing Then
            db.VacationCredits.DeleteOnSubmit(vc)
            db.SubmitChanges()
        End If

    End Sub

    Public Shared Function GetVacationCredits(connectionString As String, customerID As Integer) As List(Of VacationCredit)

        Dim db As New DisposalData(connectionString)

        Dim vcList As List(Of VacationCredit) = (From v In db.VacationCredits Where v.CustomerNumber = customerID Order By v.DateEnd Descending Select v).ToList

        Return vcList

    End Function

    Public Shared Function GetVacationCreditObject(connectionString As String, existingID As Integer) As VacationCredit

        Dim db As New DisposalData(connectionString)

        Dim vcList As VacationCredit = (From v In db.VacationCredits Where v.ID = existingID Select v).SingleOrDefault

        Return vcList

    End Function

End Class

Public Class RentalCustomer

    Public Overrides Function ToString() As String
        Return String.Format("{0} {1}", RouteLocation_FirstName, RouteLocation_LastName)
    End Function

    Public ReadOnly Property NameWithAccountNumber As String
        Get
            Return String.Format("{0} - {1} {2}", CustomerNumber, Billing_FirstName, Billing_LastName)
        End Get
    End Property

    Public Class CRentalCustomerHistory

        Public Class CRentalCustomerHistoryLineItems
            Public Property TransactionID As Integer = 0
            Public Property CustomerID As Integer = 0
            Public Property TransactionDate As Date = Nothing
            Public Property TransactionDesc As String = ""
            Public Property TransactionAmount As Double = 0.0
            Public Property RunningBalance As Double = 0.0

        End Class

        Public Property CustomerName As String = ""
        Public Property CustomerAccountNumber As Integer = 0
        Public Property BillingAddress As String = ""
        Public Property BillingCSZ As String = ""
        Public Property RouteAddress As String = ""
        Public Property RouteCSZ As String = ""
        Public Property CurrentBalance As Double = 0.0
        Public Property Balance12Month As Double = 0.0
        Public Property Balance3Month As Double = 0.0
        Public Property Balance4Month As Double = 0.0
        Public Property Balance5MonthOrGreater As Double = 0.0
        Public TransactionLineItems As New List(Of CRentalCustomerHistoryLineItems)

    End Class

    Public Class RentalRouteInformation

        Public Property CustomerNumber As Integer = 0
        Public Property CustomerName As String = ""
        Public Property CustomerAddress As String = ""
        Public Property HasTrashDumpster As Boolean = False
        Public Property Container As String = ""
        Public Property Size As String = ""
        Public Property ExtraInfo As String = ""
        Public Property RouteNumber As Integer = 0
        Public Property SequenceNumber As Integer = 0
        Public Property DayOfTheWeek As String = ""
        Public Property HasRecycleContainer As Boolean = False
        Public Property Is90GallonCart As Boolean = False
        Public Property RouteOrBook As String = ""
        Public Property HeaderLine As String = ""
        Public Property ReportOrder As Integer = 0
        Public Property NotesOnly As String = ""

        ' ----- Added for the custom route listings 
        Public Property RecycleRouteNumber As Integer = 0
        Public Property RecycleSequenceNumber As Integer = 0
        Public Property MasterReportOrder As Integer = 0

        ' ----- Added to find HAND entries
        Public Property MiscText As String = ""
        Public Property PickupID As Integer = 0

        Public Property SpecialRoute As Boolean = False

        ' ----- Added for the auto-fill 
        Public Property HasCardboard As Boolean = False
        Public Property HasRecycleBin As Boolean = False


        Public Overrides Function ToString() As String
            Return CustomerName & " (" & CustomerAddress & ")"
        End Function

        Public Sub UpdateRoute(connectionString As String, routeNumber As Integer, sequenceNumber As Integer, dayOftheWeek As String, standardRoute As Boolean)

            Dim db As New DisposalData(connectionString)

            Dim obj As List(Of RentalPickupInformation) = New List(Of RentalPickupInformation)

            If CustomerNumber < 0 Or SpecialRoute Then
                obj = (From d In db.RentalPickupInformations
                       Where d.CustomerNumber = Math.Abs(Me.CustomerNumber) And d.Route = routeNumber And d.DaysIndex = dayOftheWeek
                       Select d).ToList
            Else
                obj = (From d In db.RentalPickupInformations
                       Where d.CustomerNumber = Me.CustomerNumber And d.DaysIndex = dayOftheWeek
                       Select d).ToList
            End If

            For Each tmp As RentalPickupInformation In obj

                If standardRoute Then
                    tmp.Route = routeNumber
                    tmp.SequenceNumber = sequenceNumber
                Else
                    tmp.RecycleRoute = routeNumber
                    tmp.RecycleSequenceNumber = sequenceNumber
                End If

                db.SubmitChanges()

            Next

        End Sub

        Public Sub RemoveFromRoute(connectionString As String, routeNumber As Integer, dayOfTheWeek As String, useRecycle As Boolean)

            Dim db As New DisposalData(connectionString)

            Dim obj As List(Of RentalPickupInformation) = Nothing

            If useRecycle Then

                obj = (From d In db.RentalPickupInformations
                       Where d.CustomerNumber = Me.CustomerNumber And d.DaysIndex = dayOfTheWeek And d.RecycleRoute = routeNumber
                       Select d).ToList

                For Each tmp As RentalPickupInformation In obj
                    tmp.RecycleRoute = 0
                    tmp.SequenceNumber = 0
                    db.SubmitChanges()
                Next

            Else

                obj = (From d In db.RentalPickupInformations
                       Where d.CustomerNumber = Me.CustomerNumber And d.DaysIndex = dayOfTheWeek And d.Route = routeNumber
                       Select d).ToList

                For Each tmp As RentalPickupInformation In obj
                    tmp.Route = 0
                    tmp.SequenceNumber = 0
                    db.SubmitChanges()
                Next

            End If

        End Sub

        Public Sub AssignNewRoute(connectionString As String, newRouteNumber As Integer)

            Dim db As New DisposalData(connectionString)

            Dim obj As List(Of RentalPickupInformation) = (From d In db.RentalPickupInformations
                                                           Where d.CustomerNumber = Me.CustomerNumber And d.DaysIndex = Me.DayOfTheWeek And d.Route = Me.RouteNumber
                                                           Select d).ToList

            For Each tmp As RentalPickupInformation In obj
                tmp.Route = newRouteNumber
                db.SubmitChanges()
            Next

        End Sub

    End Class

    Public Class RentalCustomerData
        Public Property AccountNumber As Integer = 0
        Public Property CustomerName As String = ""
        Public Property CustomerAddress As String = ""
        Public Property Trash As String = ""
        Public Property RecycleOther As String = ""
        Public Property Cardboard As String = ""
        Public Property Cart As String = ""
        Public Property RollOff As String = ""
        Public Property Notes As String = ""
        Public Property MiscCharge As Double = 0.0
        Public Property OrderOnDataSheet As Integer = 0

        '* Added on 16-Feb-2018 to auto-populate dumpsters *'
        Public Property HasDumpster As Boolean = False
        Public Property HasRecycle As Boolean = False
        Public Property HasCardboard As Boolean = False
        Public Property HasCart As Boolean = False

    End Class

    Public Class CRentalCustomerList

        Public Property AccountNumber As Integer = 0
        Public Property SequenceNumber As String = ""
        Public Property CustomerName As String = ""
        Public Property CustomerAddress As String = ""
        Public Property CompleteAddressWithCSZ As String = ""
        Public Property SpecialInstructions As String = ""
        Public Property PhoneNumber As String = ""
        Public Property BillingInformation As String = ""

        Public Sub New(ByVal SeqNum As Integer, ByVal AcctNum As Integer, ByVal CustName As String, ByVal CustAddress As String, ByVal strSpecialInstructions As String)
            _AccountNumber = AcctNum
            _CustomerName = CustName
            _CustomerAddress = CustAddress
            _SpecialInstructions = strSpecialInstructions
        End Sub

        Public Sub New()

        End Sub

        Public Overrides Function ToString() As String
            Return String.Format("{0} ({1}) - Acct# {2}", _CustomerName, _CustomerAddress, _AccountNumber)
        End Function

        Public ReadOnly Property NameWithAccountNumber As String
            Get
                Return String.Format("{0} - {1}", _AccountNumber, _CustomerName.Replace("\", "").Replace("/", " "))
            End Get
        End Property

    End Class

    <CategoryAttribute("Name"), DisplayNameAttribute("Full Name")>
    Public ReadOnly Property FullName As String
        Get
            Return String.Format("{0} {1}", _RouteLocation_FirstName, _RouteLocation_LastName)
        End Get
    End Property

    Public Shared Function ReturnMaxCustomerNumber(ByVal connectionString As String)

        Dim db As New DisposalData(connectionString)

        Dim maxNum As Integer = (From c In db.RentalCustomers Select c.CustomerNumber).Max

        If maxNum < 100000 Then
            Return 100000
        Else
            Return maxNum + 1
        End If

    End Function

    Public Sub Update(ByVal ConnectionString As String)

        Dim db As New DisposalData(ConnectionString)

        Dim obj = (From c In db.RentalCustomers
                   Where c.CustomerNumber = Me.CustomerNumber
                   Select c).SingleOrDefault

        With obj
            .SequenceNumber = Me.SequenceNumber
            .RouteLocation_FirstName = Me.RouteLocation_FirstName
            .RouteLocation_LastName = Me.RouteLocation_LastName
            .RouteLocation_Address = Me.RouteLocation_Address
            .RouteLocation_City = Me.RouteLocation_City
            .RouteLocation_State = Me.RouteLocation_State
            .RouteLocation_ZipCode = Me.RouteLocation_ZipCode
            .BusinessPhone = Me.BusinessPhone
            .HomePhone = Me.HomePhone
            .BillingSameAsRoute = Me.BillingSameAsRoute
            .PickupDay = Me.PickupDay
            .TaxRate = Me.TaxRate
            .BillingType = Me.BillingType
            .Route = Me.Route
            .MonthsToBill = Me.MonthsToBill
            .Comments = Me.Comments

            ' ----- Added for new data 
            .Fax = Me.Fax
            .Owner = Me.Owner
            .Contact = Me.Contact
            .EMailAddress = Me.EMailAddress
            .SendBillViaEmail = Me.SendBillViaEmail
            .PONumber = Me.PONumber
            .UsePONumberForAll = Me.UsePONumberForAll

            ' ----- Charges 
            .DumpsterCharge = Me.DumpsterCharge
            .RollOffCharge = Me.RollOffCharge
            .Cart90GallonCharge = Me.Cart90GallonCharge
            .CardboardCharge = Me.CardboardCharge
            .RecycleCharge = Me.RecycleCharge

            ' ----- How the charges are applied 
            .DumpsterPUType = Me.DumpsterPUType
            .CardboardPUType = Me.CardboardPUType
            .RecyclePUType = Me.RecyclePUType
            .Cart90GallonPUType = Me.Cart90GallonPUType

            ' ----- Rentals 
            .DumpsterRental = Me.DumpsterRental
            .RollOffRental = Me.RollOffRental
            .Cart90GallonRental = Me.Cart90GallonRental
            .CardboardRental = Me.CardboardRental
            .RecycleRental = Me.RecycleRental

            .Balance = Me.Balance
            '.CurrentBalance = .Balance
            .AdditionalChargeDesc1 = Me.AdditionalChargeDesc1
            '.AdditionalChargeDesc2 = Me.AdditionalChargeDesc2
            .LastMonthBilled = Me.LastMonthBilled
            .LastPaymentAmount = Me.LastPaymentAmount
            .LastPaymentDate = Me.LastPaymentDate
            .PreviousMonthBilled = Me.PreviousMonthBilled

            If .BillingSameAsRoute Then
                .Billing_FirstName = Me.RouteLocation_FirstName
                .Billing_LastName = Me.RouteLocation_LastName
                .Billing_Address = Me.RouteLocation_Address
                .Billing_City = Me.RouteLocation_City
                .Billing_State = Me.RouteLocation_State
                .Billing_ZipCode = Me.RouteLocation_ZipCode
            Else
                .Billing_FirstName = Me.Billing_FirstName
                .Billing_LastName = Me.Billing_LastName
                .Billing_Address = Me.Billing_Address
                .Billing_City = Me.Billing_City
                .Billing_State = Me.Billing_State
                .Billing_ZipCode = Me.Billing_ZipCode
            End If

            .PrintBill = Me.PrintBill

            ' ----- Added 18-Mar-2013
            .Inactive = Me.Inactive
            .SendToCollections = Me.SendToCollections
            .CollectionNotes = Me.CollectionNotes

        End With

        db.SubmitChanges()

    End Sub

    Public Sub Save(ByVal ConnectionString As String)

        Dim db As New DisposalData(ConnectionString)

        ' ----- Save the new customer record to the database 
        db.RentalCustomers.InsertOnSubmit(Me)
        db.SubmitChanges()

    End Sub

    Public Shared Function ReturnMainRentalList(ByVal ConnectionString As String, showInactives As Boolean) As List(Of RentalCustomer.CRentalCustomerList)

        Dim db As New DisposalData(ConnectionString)

        Dim custList = From c In db.RentalCustomers
                       Where c.Inactive = showInactives
                       Order By c.RouteLocation_FirstName, c.RouteLocation_LastName
                       Select New CRentalCustomerList With
                              {
                                  .AccountNumber = c.CustomerNumber,
                                  .SequenceNumber = "",
                                  .CustomerName = c.FullName,
                                  .CustomerAddress = c.RouteLocation_Address,
                                  .CompleteAddressWithCSZ = c.RouteLocation_Address & " " & c.RouteLocation_City & ", " & c.RouteLocation_State & " " & c.RouteLocation_ZipCode,
                                  .PhoneNumber = If(c.HomePhone Is Nothing, " ", c.HomePhone),
                                  .BillingInformation = c.Billing_LastName + ", " + c.Billing_FirstName
                              }

        Return custList.ToList

    End Function

    Public Shared Sub SaveRentalCustomer(connectionString As String, rentalObj As RentalCustomer)

        ' ----- Save the data to the database 
        Dim db As New DisposalData(connectionString)
        db.RentalCustomers.InsertOnSubmit(rentalObj)
        db.SubmitChanges()

    End Sub

    Public Shared Function GetRentalCustomer(ByVal ConnectionString As String, ByVal customerNumber As Integer) As RentalCustomer

        Dim db As New DisposalData(ConnectionString)

        Dim custObj As RentalCustomer = (From c In db.RentalCustomers Where c.CustomerNumber = customerNumber Select c).SingleOrDefault
        Return custObj

    End Function

    Public Shared Function GetCustomerOnCall(connectionString As String) As Dictionary(Of Integer, RentalRouteInformation)

        Dim db As New DisposalData(connectionString)

        Try
            Return GetCustomerByDay(connectionString, 6)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Shared Function GetCustomersFromResidential(connectionString As String) As List(Of RentalRouteInformation)

        Dim db As New DisposalData(connectionString)

        Dim residentialList As List(Of RentalRouteInformation) = (From c In db.Customers
                                                                  Where c.Route = 4
                                                                  Order By c.RouteLocation_FirstName, c.RouteLocation_LastName
                                                                  Select New RentalRouteInformation With
                                                                      {
                                                                          .CustomerNumber = c.CustomerNumber,
                                                                          .CustomerName = c.RouteLocation_FirstName & " " & c.RouteLocation_LastName,
                                                                          .CustomerAddress = c.RouteLocation_Address
                                                                      }).ToList

        Return residentialList

    End Function

    Public Shared Function GetCustomerByDay(ConnectionString As String, dayIndex As Integer) As Dictionary(Of Integer, RentalRouteInformation)

        ' ----- Create a day array
        Dim RentalCustomerDayArray() As String = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "On Call"}

        ' ----- Create a dictionary that we will fill in 
        Dim normalizedList As New Dictionary(Of Integer, RentalRouteInformation)

        ' ----- Open the database 
        Dim db As New DisposalData(ConnectionString)

        ' ----- Get a list of customers that have dumpsters to be emptied on the specific day 
        Dim rentalCustListDumpstersOnly As List(Of RentalRouteInformation) = (From c In db.RentalCustomers
                                                                              Join d In db.RentalPickupInformations On c.CustomerNumber Equals d.CustomerNumber
                                                                              Where d.DaysIndex = RentalCustomerDayArray(dayIndex) And d.DumpsterIndex = "Dumpster" And c.Inactive = False
                                                                              Select New RentalRouteInformation With
                                                                                     {
                                                                                         .CustomerNumber = c.CustomerNumber,
                                                                                         .CustomerName = c.RouteLocation_FirstName & " " & c.RouteLocation_LastName,
                                                                                         .CustomerAddress = c.RouteLocation_Address,
                                                                                         .Container = ReturnLoadAbbreviation(d.LoadIndex),
                                                                                         .Size = d.SizeIndex,
                                                                                         .MiscText = d.MiscText,
                                                                                         .PickupID = d.ID,
                                                                                         .HasTrashDumpster = True,
                                                                                         .RouteNumber = d.Route,
                                                                                         .ReportOrder = If(d.Route = 4, 999, d.Route),
                                                                                         .SequenceNumber = d.SequenceNumber,
                                                                                         .DayOfTheWeek = d.DaysIndex,
                                                                                         .RouteOrBook = If(d.Route >= 4, "Route Containers", "Containers"),
                                                                                         .ExtraInfo = d.MiscText,
                                                                                         .NotesOnly = d.TruckNotes,
                                                                                         .Is90GallonCart = False,
                                                                                         .RecycleRouteNumber = -99,
                                                                                         .RecycleSequenceNumber = -99,
                                                                                         .SpecialRoute = c.SpecialRoute,
                                                                                         .HeaderLine = String.Format("{0} {1} {2}", "Route", If(d.Route > 4, d.Route - 4, d.Route), If(d.Route > 4, "Tablet", "Containers"))
                                                                                     }).ToList


        ' ----- Add this information to a dictionary 
        For Each obj As RentalRouteInformation In rentalCustListDumpstersOnly
            Try
                Dim presentObj As RentalRouteInformation = normalizedList(obj.CustomerNumber)
                If Not presentObj Is Nothing Then
                    normalizedList(obj.CustomerNumber).ExtraInfo &= " (Extra Dumpster)"
                End If
            Catch exKey As KeyNotFoundException
                normalizedList.Add(obj.CustomerNumber, obj)
            Catch ex As Exception
                Debug.Print(ex.Message)
            End Try
        Next

        '----- Now get all of the customers that have non-dumpsters (there will be duplicates)
        Dim rentalCustListNonDumpsters As List(Of RentalRouteInformation) = (From c In db.RentalCustomers
                                                                             Join d In db.RentalPickupInformations On c.CustomerNumber Equals d.CustomerNumber
                                                                             Where d.DaysIndex = RentalCustomerDayArray(dayIndex) And d.DumpsterIndex <> "Dumpster" And c.Inactive = False
                                                                             Select New RentalRouteInformation With
                                                                                {
                                                                                    .CustomerNumber = c.CustomerNumber,
                                                                                    .CustomerName = c.RouteLocation_FirstName & " " & c.RouteLocation_LastName,
                                                                                    .CustomerAddress = c.RouteLocation_Address,
                                                                                    .Container = ReturnLoadAbbreviation(d.LoadIndex),
                                                                                    .ExtraInfo = String.Format("{0} ({1})", d.DumpsterIndex, d.MiscText),
                                                                                    .NotesOnly = d.TruckNotes,
                                                                                    .Size = d.SizeIndex,
                                                                                    .MiscText = d.MiscText,
                                                                                    .PickupID = d.ID,
                                                                                    .RouteNumber = d.Route,
                                                                                    .ReportOrder = If(d.Route = 4, 999, d.Route),
                                                                                    .RouteOrBook = If(d.Route >= 4, "Route Containers", "Containers"),
                                                                                    .DayOfTheWeek = d.DaysIndex,
                                                                                    .HasRecycleContainer = True,
                                                                                    .HasRecycleBin = If(d.DumpsterIndex = "Recycle", True, False),
                                                                                    .HasCardboard = If(d.DumpsterIndex = "Cardboard", True, False),
                                                                                    .SequenceNumber = d.SequenceNumber,
                                                                                    .SpecialRoute = c.SpecialRoute,
                                                                                    .Is90GallonCart = If(d.DumpsterIndex = "90-Gallon Cart" Or d.DumpsterIndex = "95-Gallon Cart", True, False),
                                                                                    .RecycleRouteNumber = d.RecycleRoute,
                                                                                    .RecycleSequenceNumber = d.RecycleSequenceNumber,
                                                                                    .HeaderLine = String.Format("{0} {1} {2}", "Route", If(d.Route > 4, d.Route - 4, d.Route), If(d.Route > 4, "Tablet", "Recycling Containers"))
                                                                                }).ToList


        ' ----- Modify the dictionary to include this new informaton 
        For Each obj As RentalRouteInformation In rentalCustListNonDumpsters
            Try
                ' ----- First see if the object already exists 
                Dim presentObj As RentalRouteInformation = normalizedList(obj.CustomerNumber)

                ' ----- If it does, append information to the ExtraInfo field
                If Not presentObj Is Nothing Then
                    'if obj.RouteNumber <= 3 and not obj.Container is nothing And obj.Container <> presentObj .Container And obj.RecycleRouteNumber = 0 And obj.RecycleSequenceNumber = 0 and obj.RouteNumber <> presentObj .RouteNumber  then 
                    If presentObj.SpecialRoute Then
                        obj.SpecialRoute = True
                        obj.CustomerNumber *= -1
                        normalizedList.Add(obj.CustomerNumber, obj)
                    Else

                        If normalizedList(obj.CustomerNumber).Is90GallonCart = False Then
                            normalizedList(obj.CustomerNumber).Is90GallonCart = obj.Is90GallonCart
                        End If

                        normalizedList(obj.CustomerNumber).ExtraInfo &= "+" & obj.ExtraInfo & " "
                        normalizedList(obj.CustomerNumber).HasRecycleContainer = obj.HasRecycleContainer

                        If normalizedList(obj.CustomerNumber).HasRecycleBin = False Then
                            normalizedList(obj.CustomerNumber).HasRecycleBin = obj.HasRecycleBin
                        End If

                        If normalizedList(obj.CustomerNumber).HasCardboard = False Then
                            normalizedList(obj.CustomerNumber).HasCardboard = obj.HasCardboard
                        End If

                        normalizedList(obj.CustomerNumber).RecycleRouteNumber = obj.RecycleRouteNumber
                        normalizedList(obj.CustomerNumber).RecycleSequenceNumber = obj.RecycleSequenceNumber
                        normalizedList(obj.CustomerNumber).NotesOnly &= " " & obj.NotesOnly

                    End If
                End If
            Catch exKey As KeyNotFoundException
                obj.ExtraInfo &= " Only"
                normalizedList.Add(obj.CustomerNumber, obj)
            Catch ex As Exception

            End Try
        Next

        '----- Now get all of the customers that have non-dumpsters (there will be duplicates)
        Dim rentalCustHandPickup As List(Of RentalRouteInformation) = (From c In db.Customers
                                                                       Join d In db.RentalPickupInformations On c.CustomerNumber Equals d.CustomerNumber
                                                                       Where d.DaysIndex = RentalCustomerDayArray(dayIndex)
                                                                       Select New RentalRouteInformation With
                                                                              {
                                                                                  .CustomerNumber = c.CustomerNumber,
                                                                                  .CustomerName = c.RouteLocation_FirstName & " " & c.RouteLocation_LastName,
                                                                                  .CustomerAddress = c.RouteLocation_Address,
                                                                                  .Container = "",
                                                                                  .ExtraInfo = c.SpecialInstructions,
                                                                                  .NotesOnly = c.SpecialInstructions,
                                                                                  .Size = "Hand",
                                                                                  .MiscText = d.MiscText,
                                                                                  .PickupID = d.ID,
                                                                                  .RouteNumber = d.Route,
                                                                                  .ReportOrder = If(d.Route = 4, 999, d.Route),
                                                                                  .RouteOrBook = If(d.Route >= 4, "Route Containers", "Containers"),
                                                                                  .DayOfTheWeek = d.DaysIndex,
                                                                                  .HasRecycleContainer = False,
                                                                                  .SequenceNumber = d.SequenceNumber,
                                                                                  .RecycleRouteNumber = d.RecycleRoute,
                                                                                  .RecycleSequenceNumber = d.RecycleSequenceNumber,
                                                                                  .HeaderLine = String.Format("{0} {1} {2}", "Route", If(d.Route > 4, d.Route - 4, d.Route), If(d.Route > 4, "Tablet", "Containers"))
                                                                              }).ToList


        ' ----- Modify the dictionary to include this new information 
        For Each obj As RentalRouteInformation In rentalCustHandPickup
            Try
                ' ----- First see if the object already exists 
                Dim presentObj As RentalRouteInformation = normalizedList(obj.CustomerNumber)

                ' ----- If it does, append information to the ExtraInfo field
                If Not presentObj Is Nothing Then
                    normalizedList(obj.CustomerNumber).ExtraInfo &= "+" & obj.ExtraInfo & " "
                    normalizedList(obj.CustomerNumber).HasRecycleContainer = obj.HasRecycleContainer
                    normalizedList(obj.CustomerNumber).NotesOnly &= " " & obj.NotesOnly
                End If
            Catch exKey As KeyNotFoundException
                normalizedList.Add(obj.CustomerNumber, obj)
            Catch ex As Exception

            End Try
        Next

        Return normalizedList

    End Function

    Public Shared Function ReturnLoadAbbreviation(loadString As String) As String
        Select Case loadString
            Case "Front Load"
                Return "F/L"
            Case "Rear Load"
                Return "R/L"
            Case Else
                Return loadString
        End Select
    End Function

    Public Shared Function ReturnCustomerList(ConnectionString As String) As List(Of RentalCustomer)

        Dim db As New DisposalData(ConnectionString)

        Return (From c In db.RentalCustomers Order By c.RouteLocation_FirstName, c.RouteLocation_LastName Select c).ToList

    End Function

    Public Shared Function ReturnCustomerListForPayments(ByVal ConnectionString As String, Optional ByVal pickupDay As Integer = 0) As List(Of RentalCustomer.CRentalCustomerList)

        Dim db As New DisposalData(ConnectionString)

        Dim custList = From c In db.RentalCustomers
                       Order By c.CustomerNumber
                       Select New CRentalCustomerList With
                              {
                                  .SequenceNumber = c.SequenceNumber,
                                  .AccountNumber = c.CustomerNumber,
                                  .CustomerName = c.FullName,
                                  .CustomerAddress = c.RouteLocation_Address,
                                  .CompleteAddressWithCSZ = c.RouteLocation_Address & " " & c.RouteLocation_City & ", " & c.RouteLocation_State & " " & c.RouteLocation_ZipCode,
                                  .PhoneNumber = c.HomePhone
                              }

        Return custList.ToList

    End Function

    Public Shared Function ReturnCustomersToBill(ByVal ConnectionString As String, Optional AccountNumber As Integer = -99) As List(Of CRentalBillingData)

        ' ----- Create a connection string 
        Dim db As New DisposalData(ConnectionString)

        ' ----- Get the listing of customers for this pickup date (those who are billing)
        Dim customerDict As New Dictionary(Of Integer, RentalCustomer)

        If AccountNumber = -99 Then
            customerDict = (From c In db.RentalCustomers Where c.PrintBill = True And c.SendToCollections = False Select c).ToList.ToDictionary(Function(p) p.CustomerNumber)
        Else
            customerDict = (From c In db.RentalCustomers Where c.PrintBill = True And c.SendToCollections = False And c.CustomerNumber = AccountNumber Select c).ToList.ToDictionary(Function(p) p.CustomerNumber)
        End If

        ' ----- Select all of the customers that are on the report billing cycle 
        Dim custListWithBalance = (From c In customerDict.Values
                                   Order By c.Billing_LastName, c.Billing_FirstName
                                   Select New CRentalBillingData With
                                          {
                                               .AccountNumber = c.CustomerNumber,
                                               .StartingBalance = If(c.CurrentBalance.ToString = "", 0.0, c.CurrentBalance),
                                               .PickupFirstName = c.RouteLocation_FirstName,
                                               .PickupLastName = c.RouteLocation_LastName,
                                               .CustomerName = c.RouteLocation_FirstName & " " & c.RouteLocation_LastName,
                                               .PickupAddress = c.RouteLocation_Address,
                                               .PickupCity = c.RouteLocation_City,
                                               .PickupState = c.RouteLocation_State,
                                               .PickupZipCode = c.RouteLocation_ZipCode,
                                               .BillingFirstName = c.Billing_FirstName,
                                               .BillingLastName = c.Billing_LastName,
                                               .BillingFullName = c.Billing_FirstName & " " & c.Billing_LastName,
                                               .BillingAddress = c.Billing_Address,
                                               .BillingCity = c.Billing_City,
                                               .BillingState = c.Billing_State,
                                               .BillingZipCode = c.Billing_ZipCode,
                                               .PurchaseOrderNumber = c.PONumber,
                                               .ListHeader = .AccountNumber.ToString & " - " & .CustomerName,
                                               .TaxRate = c.TaxRate,
                                               .DumpsterCharge = If(c.DumpsterCharge.ToString = "", 0.0, c.DumpsterCharge),
                                               .DumpsterChargePUType = If(c.DumpsterPUType.ToString = "", 0, c.DumpsterPUType),
                                               .DumpsterRental = If(c.DumpsterRental.ToString = "", 0.0, c.DumpsterRental),
                                               .RollOffCharge = If(c.RollOffCharge.ToString = "", 0.0, c.RollOffCharge),
                                               .RollOffRental = If(c.RollOffRental.ToString = "", 0.0, c.RollOffRental),
                                               .CardboardCharge = If(c.CardboardCharge.ToString = "", 0.0, c.CardboardCharge),
                                               .CardboardChargePUType = If(c.CardboardPUType.ToString = "", 0, c.CardboardPUType),
                                               .CardboardRental = If(c.CardboardRental.ToString = "", 0.0, c.CardboardRental),
                                               .Cart90Charge = If(c.Cart90GallonCharge.ToString = "", 0.0, c.Cart90GallonCharge),
                                               .Cart90ChargePUType = If(c.Cart90GallonPUType.ToString = "", 0, c.Cart90GallonPUType),
                                               .Cart90Rental = If(c.Cart90GallonRental.ToString = "", 0.0, c.Cart90GallonRental),
                                               .RecycleCharge = If(c.RecycleCharge.ToString = "", 0.0, c.RecycleCharge),
                                               .RecycleChargePUType = If(c.RecyclePUType.ToString = "", 0, c.RecyclePUType),
                                               .RecycleRental = If(c.RecycleRental.ToString = "", 0.0, c.RecycleRental),
                                               .AdditionalItems = "",
                                               .AdditionalItemCost = 0.0,
                                               .DelinquentAccount = False
                                           }).ToList

        Return custListWithBalance

    End Function

    Public Shared Sub UpdateMonthBilled(ByVal ConnectionString As String, ByVal customerNumber As Integer, ByVal monthBilled As Integer)

        Dim db As New DisposalData(ConnectionString)

        Dim obj = (From c In db.RentalCustomers
                   Where c.CustomerNumber = customerNumber
                   Select c).SingleOrDefault

        With obj
            If .PreviousMonthBilled <> .LastMonthBilled Or .PreviousMonthBilled Is Nothing Then .PreviousMonthBilled = .LastMonthBilled
            .LastMonthBilled = monthBilled
        End With

        db.SubmitChanges()

    End Sub

    Public Shared Sub SetCustomerBalances(ByVal connectionString As String, Optional ByVal customerNumber As Integer = -99)

        ' ----- Create the database connection 
        Dim db As New DisposalData(connectionString)

        ' ----- Create a customer list 
        Dim customerList As New List(Of RentalCustomer)

        ' ----- Depending on what the user wants, get a customer listing 
        If customerNumber = -99 Then
            customerList = (From c In db.RentalCustomers Select c).ToList
        Else
            customerList = (From c In db.RentalCustomers Where c.CustomerNumber = customerNumber Select c).ToList
        End If

        ' ----- Get the current balances and save them to the database 
        For Each obj As RentalCustomer In customerList

            Dim customerHistObj As CRentalCustomerHistory = RentalCustomerHistory(connectionString, obj.CustomerNumber, Date.Today + New TimeSpan(1, 0, 0, 0))
            Dim tmpVal As Double = customerHistObj.CurrentBalance
            Dim strVal As String = String.Format("{0:n2}", tmpVal)

            obj.CurrentBalance = Convert.ToDouble(strVal)
            obj.CurrentBalanceDate = Date.Today

            obj.AgingBalanceCurrent = customerHistObj.Balance12Month
            obj.AgingBalance3Month = customerHistObj.Balance3Month
            obj.AgingBalance4Month = customerHistObj.Balance4Month
            obj.AgingBalance5Month = customerHistObj.Balance5MonthOrGreater

            db.SubmitChanges()

        Next

    End Sub

    Public Shared Function RentalCustomerHistory(ByVal connectionString As String, ByVal customerNumber As Integer, ByVal dteStart As Date, Optional forceTransDate As Boolean = False) As CRentalCustomerHistory

        ' ----- Create a connection object to the database 
        Dim db As New DisposalData(connectionString)

        Dim CustomerHistoryObj As CRentalCustomerHistory = (From c In db.RentalCustomers
                                                            Where c.CustomerNumber = customerNumber
                                                            Select New CRentalCustomerHistory With
                                                                   {
                                                                       .CustomerName = c.Billing_FirstName & " " & c.Billing_LastName,
                                                                       .CustomerAccountNumber = c.CustomerNumber,
                                                                       .BillingAddress = c.Billing_Address,
                                                                       .BillingCSZ = c.Billing_City & ", " & c.Billing_State & " " & c.Billing_ZipCode,
                                                                       .RouteAddress = c.RouteLocation_Address,
                                                                       .RouteCSZ = c.RouteLocation_City & ", " & c.RouteLocation_State & " " & c.RouteLocation_ZipCode
                                                                   }).SingleOrDefault


        ' ----- Create a starting balance line item 
        Dim startingBal As CRentalCustomerHistory.CRentalCustomerHistoryLineItems = (From c In db.RentalCustomers
                                                                                     Where c.CustomerNumber = customerNumber
                                                                                     Select New CRentalCustomerHistory.CRentalCustomerHistoryLineItems With
                                                                                            {
                                                                                                .TransactionID = 99,
                                                                                                .CustomerID = c.CustomerNumber,
                                                                                                .TransactionDate = New Date(2013, 1, 1),
                                                                                                .TransactionDesc = "Previous Balance",
                                                                                                .TransactionAmount = If(c.Balance Is Nothing, 0.0, c.Balance)
                                                                                            }).SingleOrDefault


        ' ----- Get all of the transactions in the Transactions table for this customer 
        Dim customerBills As List(Of CRentalCustomerHistory.CRentalCustomerHistoryLineItems) = (From t In db.RentalTransactions
                                                                                                Where t.CustomerID = customerNumber And t.Description <> "Previous Balance" And t.Amount <> 0.0 And t.TransDate.Date < dteStart
                                                                                                Select New CRentalCustomerHistory.CRentalCustomerHistoryLineItems With
                                                                                                       {
                                                                                                           .TransactionID = t.ID,
                                                                                                           .CustomerID = t.CustomerID,
                                                                                                           .TransactionDate = t.TransDate,
                                                                                                           .TransactionDesc = t.Description,
                                                                                                           .TransactionAmount = t.Amount
                                                                                                       }).ToList

        ' ----- Get all of the payments in the Payments table for this customer 
        Dim customerPayments As List(Of CRentalCustomerHistory.CRentalCustomerHistoryLineItems) = (From p In db.RentalPayments
                                                                                                   Where p.CustomerID = customerNumber And p.PaymentDate.Date < dteStart
                                                                                                   Select New CRentalCustomerHistory.CRentalCustomerHistoryLineItems With
                                                                                                          {
                                                                                                              .TransactionID = p.ID,
                                                                                                              .CustomerID = p.CustomerID,
                                                                                                              .TransactionDate = p.PaymentDate,
                                                                                                              .TransactionDesc = If(p.PaymentAmount < 0.0, "Credit", "Payment"),
                                                                                                              .TransactionAmount = p.PaymentAmount
                                                                                                          }).ToList

        ' ----- Add the starting balance object into the collection 
        CustomerHistoryObj.TransactionLineItems.Add(startingBal)

        ' ----- This routine has been modified to only show pickups that occur in months prior to this month 
        For Each obj As CRentalCustomerHistory.CRentalCustomerHistoryLineItems In customerBills

            If forceTransDate Then
                Dim tempDate As Date = obj.TransactionDate.AddMonths(1)
                obj.TransactionDate = New Date(tempDate.Year, tempDate.Month, 1) - New TimeSpan(1, 0, 0, 0)
            End If

            CustomerHistoryObj.TransactionLineItems.Add(obj)
        Next

        For Each obj As CRentalCustomerHistory.CRentalCustomerHistoryLineItems In customerPayments
            CustomerHistoryObj.TransactionLineItems.Add(obj)
        Next

        Dim runningBalance As Double = 0.0
        For Each obj As CRentalCustomerHistory.CRentalCustomerHistoryLineItems In (From c In CustomerHistoryObj.TransactionLineItems Order By c.TransactionDate)
            runningBalance += If(obj.TransactionDesc = "Payment" Or obj.TransactionDesc = "Credit", -1.0 * obj.TransactionAmount, obj.TransactionAmount)
            obj.RunningBalance = runningBalance
        Next

        '----- Set the current balance 
        CustomerHistoryObj.CurrentBalance = runningBalance

        ' ----- Determine the aging amount
        For Each obj As CRentalCustomerHistory.CRentalCustomerHistoryLineItems In (From c In CustomerHistoryObj.TransactionLineItems Order By c.TransactionDate)

            ' ----- Determine the number of days since the amount was recorded 
            If obj.TransactionDesc <> "Payment" And obj.TransactionDesc <> "Credit" Then

                ' ----- This calculates the number of days from today and the transaction date
                Dim daysFromToday As Integer = (Date.Today.Subtract(obj.TransactionDate.Date)).Days

                ' ----- If the number of days is greater than 120 days (4 months), then force the monthsFromToday to 5
                Dim monthsFromToday As Integer = 0
                If daysFromToday > 120 Then
                    monthsFromToday = 5
                Else
                    monthsFromToday = Date.Today.Month - obj.TransactionDate.Month
                End If

                If monthsFromToday < 0 Then monthsFromToday += 12
                Select Case monthsFromToday ' daysFromToday
                    Case Is <= 1 '  29
                        CustomerHistoryObj.Balance12Month += obj.TransactionAmount
                    Case Is = 2 ' < 60
                        CustomerHistoryObj.Balance3Month += obj.TransactionAmount
                    Case Is = 3 ' < 90
                        CustomerHistoryObj.Balance4Month += obj.TransactionAmount
                    Case Else
                        CustomerHistoryObj.Balance5MonthOrGreater += obj.TransactionAmount
                End Select
            End If

        Next

        ' ----- Get a list of payments
        Dim sumPayments As Double = 0.0
        For Each obj As CRentalCustomerHistory.CRentalCustomerHistoryLineItems In (From c In CustomerHistoryObj.TransactionLineItems Order By c.TransactionDate)
            If obj.TransactionDesc = "Payment" Or obj.TransactionDesc = "Credit" Then
                sumPayments += obj.TransactionAmount
            End If
        Next

        ' ----- Now remove the payments from the balances 
        Dim paymentRemainder As Double = 0.0

        RentalCustomer.UpdateAgingBalances(CustomerHistoryObj.Balance5MonthOrGreater, sumPayments)
        RentalCustomer.UpdateAgingBalances(CustomerHistoryObj.Balance4Month, sumPayments)
        RentalCustomer.UpdateAgingBalances(CustomerHistoryObj.Balance3Month, sumPayments)
        RentalCustomer.UpdateAgingBalances(CustomerHistoryObj.Balance12Month, sumPayments)

        If sumPayments > 0 Then
            CustomerHistoryObj.Balance12Month -= sumPayments
        End If

        ' ----- Return the object 
        Return CustomerHistoryObj

    End Function

    Public Shared Sub UpdateAgingBalances(ByRef balanceAmount As Double, ByRef remainingPaymentAmount As Double)

        ' ----- Determine the remaining balance amount 
        Dim remAmount As Double = remainingPaymentAmount - balanceAmount

        If remAmount >= 0.0 Then
            balanceAmount = 0.0
            remainingPaymentAmount = Convert.ToInt32(remAmount * 100.0) / 100.0
        Else
            balanceAmount = Convert.ToInt32(-1.0 * remAmount * 100.0) / 100.0
            remainingPaymentAmount = 0.0
        End If

    End Sub

    Public Shared Function CheckDateLastPost(connectionString As String) As List(Of Date)

        Dim db As New DisposalData(connectionString)

        Try
            Dim dateList As List(Of Date) = (From c In db.RentalCustomers Select c.CurrentBalanceDate.Value.Date).Distinct.ToList

            Return dateList
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Shared Function ReturnCustomer(ByVal ConnectionString As String) As List(Of RentalCustomer)

        Try
            Dim db As New DisposalData(ConnectionString)

            Dim cust = (From c In db.RentalCustomers
                        Order By c.Billing_LastName, c.Billing_FirstName
                        Select c).ToList

            Return cust
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Shared Function GetCustomerName(ByVal ConnectionString As String, ByVal customerNumber As Integer) As String

        ' ----- Open the connection 
        Dim db As New DisposalData(ConnectionString)

        ' ----- Pull the customer name from the database 
        Try
            Dim custObj As RentalCustomer = (From c In db.RentalCustomers Where c.CustomerNumber = customerNumber Select c).SingleOrDefault
            Return custObj.FullName
        Catch ex As Exception
            Return ""
        End Try

    End Function

    Public Shared Function IsInActive(ByVal ConnectionString As String, ByVal customerNumber As Integer) As Boolean

        ' ----- Open the connection 
        Dim db As New DisposalData(ConnectionString)

        ' ----- Pull the customer name from the database 
        Try
            Return (From c In db.RentalCustomers Where c.CustomerNumber = customerNumber Select c.Inactive).SingleOrDefault
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Sub DeleteRentalCustomer(ByVal ConnectionString As String)

        ' ----- Remove the customer from the database 
        Dim db As New DisposalData(ConnectionString)

        Dim obj = (From c In db.RentalCustomers
                   Where c.CustomerNumber = Me.CustomerNumber
                   Select c).SingleOrDefault

        db.RentalCustomers.DeleteOnSubmit(obj)
        db.SubmitChanges()

    End Sub

    Public Shared Function ReturnRentalCustomersWithComments(connectionString As String) As List(Of RentalCustomer)

        Dim db As New DisposalData(connectionString)

        Dim custList As List(Of RentalCustomer) = (From c In db.RentalCustomers
                                                   Where c.Comments.ToString.Trim.Length > 0 And c.Inactive = False
                                                   Select c).ToList

        Return custList

    End Function

    Public Shared Function GetCustomerContainerInfo(connectionString As String) As List(Of RentalRouteInformation)

        Dim db As New DisposalData(connectionString)

        Dim containerInfo As List(Of RentalRouteInformation) = (From c In db.RentalCustomers
                                                                Join d In db.RentalPickupInformations On c.CustomerNumber Equals d.CustomerNumber
                                                                Where (d.DumpsterIndex = "Dumpster" Or d.DumpsterIndex = "Roll Off") And c.Inactive = False
                                                                Select New RentalRouteInformation With
                                                                {
                                                                    .CustomerNumber = c.CustomerNumber,
                                                                    .CustomerName = c.RouteLocation_FirstName & " " & c.RouteLocation_LastName,
                                                                    .CustomerAddress = c.RouteLocation_Address,
                                                                    .Container = ReturnLoadAbbreviation(d.LoadIndex),
                                                                    .Size = d.SizeIndex & " " & If(d.LoadIndex.ToString <> "", d.LoadIndex, "") & " " & d.DumpsterIndex
                                                                }).Distinct().ToList

        Return containerInfo

    End Function

End Class

Public Class RecycleListing

    Public Sub New(nID As Integer, strDesc As String)
        ID = nID
        Description = strDesc
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Description
    End Function

    Public Shared Function GetRecycleListings(connectionString As String, dayIndex As Integer) As List(Of RecycleListing)

        Dim db As New DisposalData(connectionString)

        Dim strListing As List(Of RecycleListing) = (From l In db.RecycleListings Where l.DayIndex = dayIndex Select l).ToList

        Return strListing

    End Function

    Public Shared Sub SaveListing(connectionString As String, obj As RecycleListing)

        Dim db As New DisposalData(connectionString)

        db.RecycleListings.InsertOnSubmit(obj)

        db.SubmitChanges()

    End Sub

    Public Shared Sub UpdateListing(connectionString As String, obj As RecycleListing)

        Dim db As New DisposalData(connectionString)

        ' ----- Get the current object 
        Dim tempObj As RecycleListing = (From l In db.RecycleListings Where l.ID = obj.ID Select l).SingleOrDefault

        ' ----- Copy over the data 
        tempObj.Description = obj.Description
        tempObj.DayIndex = obj.DayIndex

        ' ----- Save the changes 
        db.SubmitChanges()

    End Sub

    Public Sub DeleteListing(connectionString As String)

        Dim db As New DisposalData(connectionString)

        Dim tempObj As RecycleListing = (From r In db.RecycleListings Where r.ID = Me.ID Select r).SingleOrDefault

        If Not tempObj Is Nothing Then
            db.RecycleListings.DeleteOnSubmit(tempObj)
            db.SubmitChanges()
        End If

    End Sub

End Class

Public Class RentalRouteData

    Public Shared Function GetCustomerPickupData(connectionString As String, customerNumber As Integer) As List(Of RentalRouteData)

        Dim db As New DisposalData(connectionString)

        Dim pickupData As List(Of RentalRouteData) = (From r In db.RentalRouteDatas
                                                      Where r.CustomerNumber = customerNumber
                                                      Order By r.DateOfPickup Descending
                                                      Select r).ToList

        Return pickupData

    End Function

    Public Shared Function GetCustomerDataByDayAndRoute(ConnectionString As String, pickupDate As Date) As Dictionary(Of Integer, RentalRouteData)

        ' ----- Open the connection string 
        Dim db As New DisposalData(ConnectionString)

        Dim rentalCustData As Dictionary(Of Integer, RentalRouteData) = (From c In db.RentalRouteDatas
                                                                         Where c.DateOfPickup = pickupDate
                                                                         Select c).ToDictionary(Function(c) c.CustomerNumber)

        Return rentalCustData

    End Function

    Public Shared Function GetCollectedItemsWithinRangeByDate(ByVal ConnectionString As String, ByVal dteStart As Date, ByVal dteEnd As Date, CustomerNumber As Integer) As List(Of RentalRouteData)

        ' ----- Create the context
        Dim db As New DisposalData(ConnectionString)

        ' ----- Get a collection record object 
        Dim routeDataList As List(Of RentalRouteData) = (From cr In db.RentalRouteDatas
                                                         Where cr.DateOfPickup >= dteStart And cr.DateOfPickup < (dteEnd + New TimeSpan(1, 0, 0, 0)) And cr.CustomerNumber = CustomerNumber
                                                         Order By cr.DateOfPickup
                                                         Select cr).ToList

        Return routeDataList

    End Function

    Public Shared Sub UpdatePickupData(connectionString As String, pickupDate As Date, accountNumber As Integer, pickupType As Integer, valueToSave As String)

        Dim db As New DisposalData(connectionString)

        Dim pickupObj As RentalRouteData = (From r In db.RentalRouteDatas
                                            Where r.CustomerNumber = accountNumber And r.DateOfPickup = pickupDate
                                            Select r).SingleOrDefault

        If pickupObj Is Nothing Then

            pickupObj = New RentalRouteData
            pickupObj.CustomerNumber = accountNumber
            pickupObj.DateOfPickup = pickupDate

            Select Case pickupType
                Case 0
                    pickupObj.Notes = valueToSave
                Case 1
                    pickupObj.Trash = valueToSave
                Case 2
                    pickupObj.Recycle = valueToSave
                Case 3
                    pickupObj.Cardboard = valueToSave
                Case 4
                    pickupObj.Cart = valueToSave
                Case 5
                    If IsNumeric(valueToSave) Then
                        pickupObj.MiscCharge = Convert.ToDouble(valueToSave)
                    End If
                Case 6
                    pickupObj.RollOff = valueToSave
            End Select

            db.RentalRouteDatas.InsertOnSubmit(pickupObj)

        Else

            Select Case pickupType
                Case 0
                    pickupObj.Notes = valueToSave
                Case 1
                    pickupObj.Trash = valueToSave
                Case 2
                    pickupObj.Recycle = valueToSave
                Case 3
                    pickupObj.Cardboard = valueToSave
                Case 4
                    pickupObj.Cart = valueToSave
                Case 5
                    If IsNumeric(valueToSave) Then
                        pickupObj.MiscCharge = Convert.ToDouble(valueToSave)
                    End If
                Case 6
                    pickupObj.RollOff = valueToSave
            End Select

        End If

        db.SubmitChanges()

    End Sub

    Public Sub SaveManualData(connectionString As String)

        Dim db As New DisposalData(connectionString)
        db.RentalRouteDatas.InsertOnSubmit(Me)
        db.SubmitChanges()

    End Sub

    Public Sub UpdatePickupDataViaID(connectionString As String)

        Dim db As New DisposalData(connectionString)

        Dim pickupObj As RentalRouteData = (From r In db.RentalRouteDatas
                                            Where r.ID = Me.ID
                                            Select r).SingleOrDefault

        If Not pickupObj Is Nothing Then

            pickupObj.DateOfPickup = Me.DateOfPickup
            pickupObj.Notes = Me.Notes
            pickupObj.Trash = Me.Trash
            pickupObj.Recycle = Me.Recycle
            pickupObj.Cardboard = Me.Cardboard
            pickupObj.Cart = Me.Cart
            pickupObj.RollOff = Me.RollOff
            pickupObj.MiscCharge = Me.MiscCharge

            db.SubmitChanges()

        End If

    End Sub

    Public Shared Sub RemovePickupItem(connectionString As String, transID As Integer)

        Dim db As New DisposalData(connectionString)

        Dim pickupObj As RentalRouteData = (From r In db.RentalRouteDatas Where r.ID = transID Select r).SingleOrDefault

        If Not pickupObj Is Nothing Then
            db.RentalRouteDatas.DeleteOnSubmit(pickupObj)
            db.SubmitChanges()
        End If

    End Sub

End Class

Public Class RentalPickupInformation

    Public Shared Function GetCustomerPickupInformation(connectionString As String, customerNumber As Integer) As List(Of RentalPickupInformation)

        Dim db As New DisposalData(connectionString)

        Dim pickupInfo As List(Of RentalPickupInformation) = (From p In db.RentalPickupInformations Where p.CustomerNumber = customerNumber Select p).ToList

        Return pickupInfo

    End Function

    Public Shared Sub SetCustomerPickupInformation(connectionString As String, savedObj As RentalPickupInformation)

        ' ----- Set the connection string 
        Dim db As New DisposalData(connectionString)

        If savedObj.ID > 0 Then

            Dim recallObj As RentalPickupInformation = (From o In db.RentalPickupInformations Where o.ID = savedObj.ID Select o).SingleOrDefault

            If Not recallObj Is Nothing Then

                recallObj.DumpsterIndex = savedObj.DumpsterIndex
                recallObj.LoadIndex = savedObj.LoadIndex
                recallObj.DaysIndex = savedObj.DaysIndex
                recallObj.SizeIndex = savedObj.SizeIndex
                recallObj.Route = savedObj.Route
                recallObj.MiscText = savedObj.MiscText
                recallObj.TruckNotes = savedObj.TruckNotes
                db.SubmitChanges()

            End If

        Else

            ' ----- Save the information 
            db.RentalPickupInformations.InsertOnSubmit(savedObj)
            db.SubmitChanges()

        End If

    End Sub

    Public Shared Sub DeletePickupRecord(connectionString As String, pickupID As Integer)

        Dim db As New DisposalData(connectionString)

        Dim obj As RentalPickupInformation = (From p In db.RentalPickupInformations Where p.ID = pickupID Select p).SingleOrDefault

        If Not obj Is Nothing Then
            db.RentalPickupInformations.DeleteOnSubmit(obj)
            db.SubmitChanges()
        End If

    End Sub

    Public Shared Function IsCustomerInTable(connectionString As String, customerNumber As Integer) As Boolean

        Dim db As New DisposalData(connectionString)

        Dim tempObj As RentalPickupInformation = (From r In db.RentalPickupInformations Where r.CustomerNumber = customerNumber Select r).SingleOrDefault

        If tempObj Is Nothing Then
            Return False
        Else
            Return True
        End If

    End Function

End Class

Public Class RentalPayment

    Public Class PaymentListingReport
        Public Property AccountNumber As Integer = 0
        Public Property CustomerName As String = ""
        Public Property CustomerAddress As String = ""
        Public Property PaymentDate As Date = Nothing
        Public Property PaymentAmount As Single = 0.0
        Public Property CheckNumber As String = ""
        Public Property Description As String = ""
        Public Property CashAmountForReport As Single = 0.0
        Public Property CheckAmountForReport As Single = 0.0
        Public Property CreditCardAmountForReport As Single = 0.0
        Public Property AutoPayAmountForReport As Single = 0.0
        Public Property CompanyCreditAmountForReport As Single = 0.0
        Public Property IsCheck As Boolean = False
        Public Property IsMoneyOrder As Boolean = False
    End Class

    Public Class CRevenueListing
        Public Property TaxRate As Double = 0.0
        Public Property TotalPayment As Double = 0.0
        Public Property Revenue As Double = 0.0
        Public Property Taxes As Double = 0.0
        Public Property CreditCardUsed As Boolean = False
    End Class

    Public Class CRevenueReport
        Public Property ReportStartDate As Date = Nothing
        Public Property ReportEndDate As Date = Nothing
        Public Property IncomeNoTax As Double = 0.0
        Public Property Income8Tax As Double = 0.0
        Public Property TaxCollected8Tax As Double = 0.0
        Public Property TotalIncome As Double = 0.0
        Public Property TotalTax As Double = 0.0
        Public Property TotalCollected As Double = 0.0
        Public Property TotalCreditCollected As Double = 0.0
        Public Property TotalNonCreditCollected As Double = 0.0
    End Class

    Public Sub New(ByVal dbID As Integer, ByVal datePayment As Date, ByVal amountPayment As Single, ByVal customerNumber As Integer, ByVal methodOfPay As Integer, ByVal nCheckNumber As Long, strDesc As String, strCCAuth As String)

        _ID = dbID
        _PaymentDate = datePayment
        _PaymentAmount = amountPayment
        _CustomerID = customerNumber
        _MOP = methodOfPay
        _CheckNumber = nCheckNumber
        _Description = strDesc
        _CreditCardAuthNumber = strCCAuth
    End Sub

    Public ReadOnly Property MethodOfPaymentDesc As String
        Get
            Select Case _MOP
                Case 0
                    Return "Cash"
                Case 1
                    Return "Check"
                Case 2
                    Return "Money Order"
                Case 3
                    Return "Other"
                Case 4
                    Return "Credit Card"
                Case Else
                    Return "Cash"
            End Select
        End Get
    End Property

    Public Sub SavePayment(ByVal ConnectionString As String)

        Dim db As New DisposalData(ConnectionString)

        If Me.ID = 0 Then
            db.RentalPayments.InsertOnSubmit(Me)
        Else
            Dim obj = (From p In db.RentalPayments Where p.ID = Me.ID Select p).SingleOrDefault

            If Not obj Is Nothing Then
                obj.PaymentDate = Me.PaymentDate
                obj.PaymentAmount = Me.PaymentAmount
                obj.MOP = Me.MOP
                obj.CheckNumber = Me.CheckNumber
                obj.Description = Me.Description
            End If

        End If

        db.SubmitChanges()

    End Sub

    Public Shared Function ReturnPaymentDetails(ByVal ConnectionString As String, ByVal paymentID As Integer) As RentalPayment

        Dim db As New DisposalData(ConnectionString)

        Dim paymentDetail = (From p In db.RentalPayments Where p.ID = paymentID Select p).SingleOrDefault

        Return paymentDetail

    End Function

    Public Shared Function DoesPaymentExist(ByVal connectionString As String, ByVal customerNumber As Integer, ByVal dtePayment As Date) As Boolean

        Dim db As New DisposalData(connectionString)

        Dim hasPayment As Integer = (From p In db.RentalPayments Where p.CustomerID = customerNumber And p.PaymentDate.Date = dtePayment.Date Select p.CheckNumber).Count

        If hasPayment > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Shared Function ReturnPaymentsForDate(ByVal ConnectionString As String, ByVal dtePaymentStart As Date, ByVal dtePaymentEnd As Date) As List(Of PaymentListingReport)

        Dim db As New DisposalData(ConnectionString)

        Dim paymentList = From p In db.RentalPayments
                          Join c In db.RentalCustomers On p.CustomerID Equals c.CustomerNumber
                          Where p.PaymentDate.Date >= dtePaymentStart And p.PaymentDate.Date <= dtePaymentEnd
                          Order By c.RouteLocation_LastName, c.RouteLocation_FirstName
                          Select New PaymentListingReport With
                              {
                              .AccountNumber = c.CustomerNumber,
                              .CustomerName = c.RouteLocation_FirstName & " " & c.RouteLocation_LastName,
                              .CustomerAddress = c.RouteLocation_Address,
                              .PaymentDate = p.PaymentDate,
                              .PaymentAmount = p.PaymentAmount,
                              .Description = p.Description,
                              .CheckNumber = If(p.MOP = 0, "CASH", If(p.MOP = 2, "M/O", If(p.MOP = 4, "Credit", If(p.PaymentAmount < 0.0, "CR", p.CheckNumber.ToString)))),
                              .IsMoneyOrder = p.MOP = 2,
                              .IsCheck = If(p.MOP = 0, False, If(p.MOP = 2, False, If(p.MOP = 4, False, If(p.PaymentAmount < 0.0, False, True)))),
                              .CashAmountForReport = If(p.MOP = 0 Or p.MOP = 2, p.PaymentAmount, 0.0),
                              .CreditCardAmountForReport = If(p.MOP = 4, p.PaymentAmount, 0.0)
                              }

        Dim fullListing = paymentList.ToList

        For Each item As PaymentListingReport In fullListing

            If item.IsCheck And item.CheckNumber <> "0" Or item.IsMoneyOrder Then
                item.CheckAmountForReport = item.PaymentAmount
            End If

            If item.CheckNumber = "0" And item.Description.ToUpper = "AUTOPAY" Then
                item.AutoPayAmountForReport = item.PaymentAmount
            End If

            If item.CheckNumber = "CR" Then
                item.CompanyCreditAmountForReport = item.PaymentAmount
            End If

        Next

        Return fullListing

    End Function

    Public Shared Function ReturnPaymentsForDateByCheck(ByVal ConnectionString As String, ByVal checkNumber As Long) As List(Of PaymentListingReport)

        Dim db As New DisposalData(ConnectionString)

        Dim paymentList = From p In db.RentalPayments
                          Join c In db.RentalCustomers On p.CustomerID Equals c.CustomerNumber
                          Where p.CheckNumber = checkNumber
                          Order By p.PaymentDate, c.RouteLocation_LastName, c.RouteLocation_FirstName
                          Select New PaymentListingReport With
                              {
                              .AccountNumber = c.CustomerNumber,
                              .CustomerName = c.RouteLocation_FirstName & " " & c.RouteLocation_LastName,
                              .CustomerAddress = c.RouteLocation_Address,
                              .PaymentDate = p.PaymentDate,
                              .PaymentAmount = p.PaymentAmount,
                              .Description = p.Description,
                              .CheckNumber = If(p.MOP = 0, "CASH", If(p.MOP = 2, "M/O", If(p.MOP = 4, "Credit", If(p.PaymentAmount < 0.0, "CR", p.CheckNumber.ToString))))
                            }

        Return paymentList.ToList

    End Function

    Public Shared Function ReturnRevenueValue(ByVal ConnectionString As String, ByVal dtePaymentStart As Date, ByVal dtePaymentEnd As Date) As CRevenueReport

        Dim db As New DisposalData(ConnectionString)

        ' ----- Creates a list of payments broken down into revenue
        Dim revenue As List(Of CRevenueListing) = (From p In db.RentalPayments
                                                   Join c In db.RentalCustomers On p.CustomerID Equals c.CustomerNumber
                                                   Where p.PaymentDate.Date >= dtePaymentStart And p.PaymentDate.Date <= dtePaymentEnd
                                                   Select New CRevenueListing With
                                                          {
                                                              .TaxRate = c.TaxRate.Value,
                                                              .CreditCardUsed = (p.MOP = 4),
                                                              .TotalPayment = Decimal.ToDouble(p.PaymentAmount),
                                                              .Revenue = Decimal.ToDouble(p.PaymentAmount) / (1.0 + c.TaxRate.Value),
                                                              .Taxes = Decimal.ToDouble(p.PaymentAmount) - (Decimal.ToDouble(p.PaymentAmount) / (1.0 + c.TaxRate.Value))
                                                          }).ToList

        Dim rptObj As New CRevenueReport

        rptObj.ReportStartDate = dtePaymentStart
        rptObj.ReportEndDate = dtePaymentEnd

        For Each obj As CRevenueListing In revenue

            If obj.TaxRate = 0.0 Then
                rptObj.IncomeNoTax += obj.Revenue
            End If

            If obj.TaxRate = 0.08 Then
                rptObj.Income8Tax += obj.Revenue
                rptObj.TaxCollected8Tax += obj.Taxes
            End If

            rptObj.TotalIncome += obj.Revenue
            rptObj.TotalTax += obj.Taxes

            ' ----- added for credit cards 
            If obj.CreditCardUsed Then
                rptObj.TotalCreditCollected += obj.TotalPayment
            Else
                rptObj.TotalNonCreditCollected += obj.TotalPayment
            End If

            rptObj.TotalCollected += obj.TotalPayment

        Next

        Return rptObj

    End Function

    Public Shared Function ReturnAllPayments(ByVal ConnectionString As String, ByVal customerID As Integer) As List(Of RentalPayment)

        Dim db As New DisposalData(ConnectionString)

        Dim paymentList = From p In db.RentalPayments
                          Where p.CustomerID = customerID
                          Order By p.PaymentDate Descending
                          Select p

        Return paymentList.ToList

    End Function

    Public Shared Sub DeletePayment(ByVal ConnectionString As String, ByVal paymentID As Integer)

        Dim db As New DisposalData(ConnectionString)

        Dim paymentDetail = (From p In db.RentalPayments Where p.ID = paymentID Select p).SingleOrDefault

        If Not paymentDetail Is Nothing Then
            db.RentalPayments.DeleteOnSubmit(paymentDetail)
            db.SubmitChanges()
        End If

    End Sub

End Class

Public Class CRentalBillingData
    Public Property AccountNumber As Integer = 0
    Public Property SequenceNumber As Integer = 0
    Public Property CustomerName As String = ""
    Public Property PickupFirstName As String = ""
    Public Property PickupLastName As String = ""
    Public Property PickupAddress As String = ""
    Public Property PickupCity As String = ""
    Public Property PickupState As String = ""
    Public Property PickupZipCode As String = ""
    Public Property BillingFullName As String = ""
    Public Property BillingFirstName As String = ""
    Public Property BillingLastName As String = ""
    Public Property BillingAddress As String = ""
    Public Property BillingCity As String = ""
    Public Property BillingState As String = ""
    Public Property BillingZipCode As String = ""
    Public Property ListHeader As String = ""
    Public Property StartingBalance As Double = 0.0
    Public Property DumpsterCharge As Double = 0.0
    Public Property DumpsterChargePUType As Integer = 0
    Public Property DumpsterRental As Double = 0.0
    Public Property RollOffCharge As Double = 0.0
    Public Property RollOffRental As Double = 0.0
    Public Property Cart90Charge As Double = 0.0
    Public Property Cart90ChargePUType As Integer = 0
    Public Property Cart90Rental As Double = 0.0
    Public Property CardboardCharge As Double = 0.0
    Public Property CardboardChargePUType As Integer = 0
    Public Property CardboardRental As Double = 0.0
    Public Property RecycleCharge As Double = 0.0
    Public Property RecycleChargePUType As Integer = 0
    Public Property RecycleRental As Double = 0.0
    Public Property AdditionalItems As String = ""
    Public Property AdditionalItemCost As Double = 0.0
    Public Property TaxRate As Double = 0.0
    Public Property DelinquentAccount As Boolean = False
    Public Property PurchaseOrderNumber As String = ""

End Class
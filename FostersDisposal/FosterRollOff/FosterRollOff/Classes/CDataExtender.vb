Imports System.Data
Imports System.Data.OleDb
Imports System.Xml.Serialization
Imports System.IO

Public Class CDataExtender

    Private Const DatabaseName As String = "RollOffData.mdb"

    Public Class CMainScreenData
        Public Property RollOffID As Integer = 0
        Public Property ChargeType As Integer = 0
        Public Property TransactionType As String = ""
        Public Property Amount As Double = 0.0
        Public Property ChargeDate As Date = Nothing
    End Class

#Region "General"

    Private Shared Function Delete(tableName As String, databaseID As Integer) As Boolean

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim strSQL As String = String.Format("DELETE * FROM {0} WHERE ID = {1}", tableName, databaseID)
        Dim rs As New OleDbCommand(strSQL, db)
        rs.ExecuteNonQuery()

        db.Close()

        Return True

    End Function

    Public Shared Function MarkAsBilled(databaseID As Integer, dteBill As Date, tableName As String) As Boolean

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim strSQL As String = String.Format("UPDATE {3} SET HasBeenBilled = {0}, BilledDate = #{1}# WHERE ID = {2}", True, dteBill.ToShortDateString, databaseID, tableName)
        Dim rs As New OleDb.OleDbCommand(strSQL, db)
        rs.ExecuteScalar()

        db.Close()
        Return True

    End Function

    Public Shared Function RemoveBillFlag(databaseID As Integer, dteBill As Date, tableName As String) As Boolean

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim strSQL As String = String.Format("UPDATE {3} SET HasBeenBilled = {0}, BilledDate = #{1}# WHERE ID = {2}", False, dteBill.ToShortDateString, databaseID, tableName)
        Dim rs As New OleDb.OleDbCommand(strSQL, db)
        rs.ExecuteScalar()

        db.Close()
        Return True

    End Function

#End Region

#Region "Roll Off Data"

    Public Shared Function SaveRollOffData(rollOffObj As CRollOff) As Boolean

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim rollOffDataTable As New DataTable
        Dim rollOffDataSet As New DataSet
        rollOffDataSet.Tables.Add(rollOffDataTable)

        Dim rollOffDataAdapter As New OleDbDataAdapter
        rollOffDataAdapter = New OleDbDataAdapter("SELECT * FROM RollOff", db)
        rollOffDataAdapter.Fill(rollOffDataTable)

        Dim newRow As DataRow = rollOffDataTable.NewRow

        newRow.Item("CustomerID") = rollOffObj.Customer.DatabaseID
        newRow.Item("RollOffPickedUp") = rollOffObj.RollOffPickedUp
        newRow.Item("DateRollOffDelivered") = rollOffObj.DateRollOffDelivered.ToShortDateString
        newRow.Item("DateRollOffPickedUp") = If(rollOffObj.DateRollOffPickedUp Is Nothing, Date.Today.ToShortDateString, rollOffObj.DateRollOffPickedUp.Value.ToShortDateString)
        newRow.Item("RollOffSize") = rollOffObj.RollOffSize
        newRow.Item("RentalRate") = rollOffObj.RentalRate
        newRow.Item("RentalPeriod") = rollOffObj.RentalPeriod
        newRow.Item("ServiceCharge") = rollOffObj.ServiceCharge
        newRow.Item("DumpingFee") = rollOffObj.DumpingFee
        newRow.Item("Active") = rollOffObj.Active
        newRow.Item("FeeID") = rollOffObj.FeeObj.DatabaseID
        newRow.Item("AccountDataOnly") = rollOffObj.AccountDataOnly

        ' ----- Added September 2015
        newRow.Item("Notes") = rollOffObj.RollOffNotes

        ' ----- Added June 22 2016
        newRow.Item("UseSpecialBilling") = rollOffObj.UseRollOffBillingAddress
        newRow.Item("SpecialBillingName") = rollOffObj.RollOffBillingName

        ' ----- Serialize the service address 
        Dim pickupAdd As StringWriter = New StringWriter()
        Dim serializer As New XmlSerializer(GetType(CAddressBlock))
        serializer.Serialize(pickupAdd, rollOffObj.ServiceAddress)
        newRow.Item("ServiceAddress") = pickupAdd.ToString

        ' ----- Serialize the special billing address 
        Dim billAdd As StringWriter = New StringWriter()
        serializer.Serialize(billAdd, rollOffObj.RollOffBillingAddress)
        newRow.Item("SpecialBillingAddress") = billAdd.ToString


        ' ----- Add the row
        rollOffDataTable.Rows.Add(newRow)


        Dim cb As New OleDbCommandBuilder(rollOffDataAdapter)
        rollOffDataAdapter.Update(rollOffDataTable)

        ' ----- Close the database connection 
        db.Close()

        Return True

    End Function

    Public Shared Function UpdateRollOffData(rollOffObj As CRollOff) As Boolean

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim rollOffDataTable As New DataTable
        Dim rollOffDataSet As New DataSet
        rollOffDataSet.Tables.Add(rollOffDataTable)

        Dim rollOffDataAdapter As New OleDbDataAdapter
        rollOffDataAdapter = New OleDbDataAdapter(String.Format("SELECT * FROM RollOff WHERE ID = {0}", rollOffObj.DatabaseID), db)
        rollOffDataAdapter.Fill(rollOffDataTable)

        Dim editRow As DataRow = rollOffDataTable.Rows(0)

        editRow.Item("CustomerID") = rollOffObj.Customer.DatabaseID
        editRow.Item("RollOffPickedUp") = rollOffObj.RollOffPickedUp
        editRow.Item("DateRollOffDelivered") = rollOffObj.DateRollOffDelivered.ToShortDateString
        editRow.Item("DateRollOffPickedUp") = If(rollOffObj.DateRollOffPickedUp Is Nothing, Date.Today.ToShortDateString, rollOffObj.DateRollOffPickedUp.Value.ToShortDateString)
        editRow.Item("RollOffSize") = rollOffObj.RollOffSize
        editRow.Item("RentalRate") = rollOffObj.RentalRate
        editRow.Item("RentalPeriod") = rollOffObj.RentalPeriod
        editRow.Item("ServiceCharge") = rollOffObj.ServiceCharge
        editRow.Item("DumpingFee") = rollOffObj.DumpingFee
        editRow.Item("Active") = rollOffObj.Active
        editRow.Item("FeeID") = rollOffObj.FeeObj.DatabaseID
        editRow.Item("AccountDataOnly") = rollOffObj.AccountDataOnly

        ' ----- Added September 2015
        editRow.Item("Notes") = rollOffObj.RollOffNotes
        
                ' ----- Added June 22 2016
        editRow.Item("UseSpecialBilling") = rollOffObj.UseRollOffBillingAddress
        editRow.Item("SpecialBillingName") = rollOffObj.RollOffBillingName

        ' ----- Serialize the service address 
        Dim pickupAdd As StringWriter = New StringWriter()
        Dim serializer As New XmlSerializer(GetType(CAddressBlock))
        serializer.Serialize(pickupAdd, rollOffObj.ServiceAddress)
        editRow.Item("ServiceAddress") = pickupAdd.ToString

        ' ----- Serialize the special billing address 
        Dim billAdd As StringWriter = New StringWriter()
        serializer.Serialize(billAdd, rollOffObj.RollOffBillingAddress)
        editRow.Item("SpecialBillingAddress") = billAdd.ToString


        Dim cb As New OleDbCommandBuilder(rollOffDataAdapter)
        rollOffDataAdapter.Update(rollOffDataTable)

        ' ----- Close the database connection 
        db.Close()

        Return True

    End Function

    Public Shared Function DeleteRollOff(rollOffObj As CRollOff) As Boolean
        Return Delete("RollOff", rollOffObj.DatabaseID)
    End Function

    Public Shared Function GetListOfActiveRollOffs() As List(Of CRollOff)

        Dim rollOffList As New List(Of CRollOff)

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim strSQL As String = String.Format("SELECT * FROM RollOff WHERE Active = True AND AccountDataOnly = False")
        Dim rs As New OleDbCommand(strSQL, db)
        Dim rollOffReader As OleDbDataReader = rs.ExecuteReader

        If rollOffReader.HasRows Then

            Do While rollOffReader.Read
                Dim tempObj As New CRollOff
                tempObj.DatabaseID = rollOffReader("ID")
                tempObj.Customer = CurrentCustomerList.Where(Function(c) c.DatabaseID = rollOffReader("CustomerID")).Select(Function(c) c).FirstOrDefault
                tempObj.RollOffPickedUp = rollOffReader("RollOffPickedUp")
                tempObj.DateRollOffDelivered = rollOffReader("DateRollOffDelivered")
                tempObj.DateRollOffPickedUp = rollOffReader("DateRollOffPickedUp")
                tempObj.RollOffSize = rollOffReader("RollOffSize")
                tempObj.RentalRate = rollOffReader("RentalRate")
                tempObj.RentalPeriod = rollOffReader("RentalPeriod")
                tempObj.ServiceCharge = rollOffReader("ServiceCharge")
                tempObj.DumpingFee = rollOffReader("DumpingFee")
                tempObj.Active = rollOffReader("Active")
                tempObj.FeeObj = CurrentFeeList.Where(Function(f) f.DatabaseID = rollOffReader("FeeID")).Select(Function(f) f).FirstOrDefault
                tempObj.RollOffNotes = rollOffReader("Notes").ToString()

                ' ----- Pick up the service address 
                Try
                    Dim serviceAddressString As String = rollOffReader("ServiceAddress").ToString
                    Dim x As New Xml.Serialization.XmlSerializer(GetType(CAddressBlock))
                    Dim srServiceAddress As New IO.StringReader(serviceAddressString)
                    Dim tmpListing As CAddressBlock = CType(x.Deserialize(srServiceAddress), CAddressBlock)
                    tempObj.ServiceAddress = tmpListing
                Catch ex As Exception

                End Try

                tempObj.UseRollOffBillingAddress = rollOffReader("UseSpecialBilling")
                tempObj.RollOffBillingName = rollOffReader("SpecialBillingName").ToString()

                Try
                    Dim billingAddressString As String = rollOffReader("SpecialBillingAddress").ToString
                    Dim x As New Xml.Serialization.XmlSerializer(GetType(CAddressBlock))
                    Dim srServiceAddress As New IO.StringReader(billingAddressString)
                    Dim tmpListing As CAddressBlock = CType(x.Deserialize(srServiceAddress), CAddressBlock)
                    tempObj.RollOffBillingAddress = tmpListing
                Catch ex As Exception

                End Try

                rollOffList.Add(tempObj)
            Loop

        End If

        ' ----- Close everything up 
        rollOffReader.Close()
        db.Close()

        ' ----- Return the list 
        Return rollOffList

    End Function

    Public Shared Function GetListOfInActiveRollOffs() As List(Of CRollOff)

        Dim rollOffList As New List(Of CRollOff)

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim strSQL As String = String.Format("SELECT * FROM RollOff WHERE Active = False")
        Dim rs As New OleDbCommand(strSQL, db)
        Dim rollOffReader As OleDbDataReader = rs.ExecuteReader

        If rollOffReader.HasRows Then

            Do While rollOffReader.Read
                Dim tempObj As New CRollOff
                tempObj.DatabaseID = rollOffReader("ID")
                tempObj.Customer = CurrentCustomerList.Where(Function(c) c.DatabaseID = rollOffReader("CustomerID")).Select(Function(c) c).FirstOrDefault
                tempObj.RollOffPickedUp = rollOffReader("RollOffPickedUp")
                tempObj.DateRollOffDelivered = rollOffReader("DateRollOffDelivered")
                tempObj.DateRollOffPickedUp = rollOffReader("DateRollOffPickedUp")
                tempObj.RollOffSize = rollOffReader("RollOffSize")
                tempObj.RentalRate = rollOffReader("RentalRate")
                tempObj.RentalPeriod = rollOffReader("RentalPeriod")
                tempObj.ServiceCharge = rollOffReader("ServiceCharge")
                tempObj.DumpingFee = rollOffReader("DumpingFee")
                tempObj.Active = rollOffReader("Active")
                tempObj.RollOffNotes = rollOffReader("Notes").ToString()

                ' ----- Pick up the service address 
                Try
                    Dim serviceAddressString As String = rollOffReader("ServiceAddress").ToString
                    Dim x As New Xml.Serialization.XmlSerializer(GetType(CAddressBlock))
                    Dim srServiceAddress As New IO.StringReader(serviceAddressString)
                    Dim tmpListing As CAddressBlock = CType(x.Deserialize(srServiceAddress), CAddressBlock)
                    tempObj.ServiceAddress = tmpListing
                Catch ex As Exception

                End Try

                tempObj.UseRollOffBillingAddress = rollOffReader("UseSpecialBilling")
                tempObj.RollOffBillingName = rollOffReader("SpecialBillingName").ToString()

                Try
                    Dim billingAddressString As String = rollOffReader("SpecialBillingAddress").ToString
                    Dim x As New Xml.Serialization.XmlSerializer(GetType(CAddressBlock))
                    Dim srServiceAddress As New IO.StringReader(billingAddressString)
                    Dim tmpListing As CAddressBlock = CType(x.Deserialize(srServiceAddress), CAddressBlock)
                    tempObj.RollOffBillingAddress = tmpListing
                Catch ex As Exception

                End Try

                rollOffList.Add(tempObj)
            Loop

        End If

        ' ----- Close everything up 
        rollOffReader.Close()
        db.Close()

        ' ----- Return the list 
        Return rollOffList

    End Function

    Public Shared Function GetServiceAddress(rollOffID As Integer) As CAddressBlock
        Dim rollOffObj As CRollOff = GetRollOff(rollOffID)
        Return rollOffObj.ServiceAddress
    End Function

    Public Shared Function GetRollOff(databaseID As Integer) As CRollOff

        Dim tempObj As New CRollOff

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim strSQL As String = String.Format("SELECT * FROM RollOff WHERE ID = " & databaseID.ToString)
        Dim rs As New OleDbCommand(strSQL, db)
        Dim rollOffReader As OleDbDataReader = rs.ExecuteReader

        If rollOffReader.HasRows Then
            rollOffReader.Read()
            tempObj.DatabaseID = rollOffReader("ID")
            tempObj.Customer = CurrentCustomerList.Where(Function(c) c.DatabaseID = rollOffReader("CustomerID")).Select(Function(c) c).FirstOrDefault
            tempObj.RollOffPickedUp = rollOffReader("RollOffPickedUp")
            tempObj.DateRollOffDelivered = rollOffReader("DateRollOffDelivered")
            tempObj.DateRollOffPickedUp = rollOffReader("DateRollOffPickedUp")
            tempObj.RollOffSize = rollOffReader("RollOffSize")
            tempObj.RentalRate = rollOffReader("RentalRate")
            tempObj.RentalPeriod = rollOffReader("RentalPeriod")
            tempObj.ServiceCharge = rollOffReader("ServiceCharge")
            tempObj.DumpingFee = rollOffReader("DumpingFee")
            tempObj.Active = rollOffReader("Active")
            tempObj.FeeObj = CurrentFeeList.Where(Function(f) f.DatabaseID = rollOffReader("FeeID")).Select(Function(f) f).FirstOrDefault
            tempObj.RollOffNotes = rollOffReader("Notes").ToString()

            ' ----- Pick up the service address 
            Try
                Dim serviceAddressString As String = rollOffReader("ServiceAddress").ToString
                Dim x As New Xml.Serialization.XmlSerializer(GetType(CAddressBlock))
                Dim srServiceAddress As New IO.StringReader(serviceAddressString)
                Dim tmpListing As CAddressBlock = CType(x.Deserialize(srServiceAddress), CAddressBlock)
                tempObj.ServiceAddress = tmpListing
            Catch ex As Exception

            End Try

            tempObj.UseRollOffBillingAddress = rollOffReader("UseSpecialBilling")
            tempObj.RollOffBillingName = rollOffReader("SpecialBillingName").ToString()

            Try
                Dim billingAddressString As String = rollOffReader("SpecialBillingAddress").ToString
                Dim x As New Xml.Serialization.XmlSerializer(GetType(CAddressBlock))
                Dim srServiceAddress As New IO.StringReader(billingAddressString)
                Dim tmpListing As CAddressBlock = CType(x.Deserialize(srServiceAddress), CAddressBlock)
                tempObj.RollOffBillingAddress = tmpListing
            Catch ex As Exception

            End Try

        End If

        ' ----- Close everything up 
        rollOffReader.Close()
        db.Close()

        ' ----- Return the list 
        Return tempObj

    End Function

    Public Shared Function ReturnRollOffCharges(rollOffObj As CRollOff) As List(Of CRollOffHistoryBilling)

        Dim mainList As New List(Of CRollOffHistoryBilling)

        Dim billListing As New List(Of List(Of CRollOffHistoryBilling))

        For Each billObj As CBillingObject In ReturnBillsList(rollOffObj).OrderBy(Function(b) b.BillingDate)
            billListing.Add(billObj.ChargeListing)
        Next

        For Each list1 As List(Of CRollOffHistoryBilling) In billListing
            For Each tmpObj As CRollOffHistoryBilling In list1
                mainList.Add(tmpObj)
            Next
        Next

        Return mainList

    End Function

    Public Shared Function GetRollOffsForCustomer(customerID As Integer) As List(Of CRollOff)

        Dim rollOffListing As New List(Of CRollOff)

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim strSQL As String = String.Format("SELECT * FROM RollOff WHERE CustomerID = " & customerID.ToString)
        Dim rs As New OleDbCommand(strSQL, db)
        Dim rollOffReader As OleDbDataReader = rs.ExecuteReader

        If rollOffReader.HasRows Then
            Do While rollOffReader.Read()
                Dim tempObj As New CRollOff
                tempObj.DatabaseID = rollOffReader("ID")
                tempObj.Customer = CurrentCustomerList.Where(Function(c) c.DatabaseID = rollOffReader("CustomerID")).Select(Function(c) c).FirstOrDefault
                tempObj.RollOffPickedUp = rollOffReader("RollOffPickedUp")
                tempObj.DateRollOffDelivered = rollOffReader("DateRollOffDelivered")
                tempObj.DateRollOffPickedUp = rollOffReader("DateRollOffPickedUp")
                tempObj.RollOffSize = rollOffReader("RollOffSize")
                tempObj.RentalRate = rollOffReader("RentalRate")
                tempObj.RentalPeriod = rollOffReader("RentalPeriod")
                tempObj.ServiceCharge = rollOffReader("ServiceCharge")
                tempObj.DumpingFee = rollOffReader("DumpingFee")
                tempObj.Active = rollOffReader("Active")
                tempObj.FeeObj = CurrentFeeList.Where(Function(f) f.DatabaseID = rollOffReader("FeeID")).Select(Function(f) f).FirstOrDefault
                tempObj.RollOffNotes = rollOffReader("Notes").ToString()

                ' ----- Pick up the service address 
                Try
                    Dim serviceAddressString As String = rollOffReader("ServiceAddress").ToString
                    Dim x As New Xml.Serialization.XmlSerializer(GetType(CAddressBlock))
                    Dim srServiceAddress As New IO.StringReader(serviceAddressString)
                    Dim tmpListing As CAddressBlock = CType(x.Deserialize(srServiceAddress), CAddressBlock)
                    tempObj.ServiceAddress = tmpListing
                Catch ex As Exception

                End Try

                tempObj.UseRollOffBillingAddress = rollOffReader("UseSpecialBilling")
                tempObj.RollOffBillingName = rollOffReader("SpecialBillingName").ToString()

                Try
                    Dim billingAddressString As String = rollOffReader("SpecialBillingAddress").ToString
                    Dim x As New Xml.Serialization.XmlSerializer(GetType(CAddressBlock))
                    Dim srServiceAddress As New IO.StringReader(billingAddressString)
                    Dim tmpListing As CAddressBlock = CType(x.Deserialize(srServiceAddress), CAddressBlock)
                    tempObj.RollOffBillingAddress = tmpListing
                Catch ex As Exception

                End Try

                rollOffListing.Add(tempObj)

            Loop

        End If

        ' ----- Close everything up 
        rollOffReader.Close()
        db.Close()

        ' ----- Return the list 
        Return rollOffListing

    End Function

#End Region

#Region "Deposit / Payment Data"

    Public Shared Function SaveDepositPaymentData(depositObj As ITransaction, tableName As String) As Boolean

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim depositDataTable As New DataTable
        Dim depositDataSet As New DataSet
        depositDataSet.Tables.Add(depositDataTable)

        Dim depositDataAdapter As New OleDbDataAdapter
        depositDataAdapter = New OleDbDataAdapter(String.Format("SELECT * FROM {0}", tableName), db)
        depositDataAdapter.Fill(depositDataTable)

        Dim newRow As DataRow = depositDataTable.NewRow

        newRow.Item("TransactionDate") = depositObj.TransactionDate
        newRow.Item("Amount") = depositObj.Amount
        newRow.Item("Description") = depositObj.Description
        newRow.Item("CheckNumber") = depositObj.CheckNumber
        newRow.Item("RollOffID") = depositObj.RollOffObject.DatabaseID
        newRow.Item("HasBeenBilled") = depositObj.HasBeenBilled
        newRow.Item("BilledDate") = depositObj.BilledDate
        newRow.Item("Taxable") = depositObj.Taxable

        ' ----- added for CC
        newRow.Item("CreditCard") = depositObj.CreditCardTransaction
        newRow.Item("CreditCardAuthNumber") = depositObj.CreditCardAuthNumber
        newRow.Item("TransactionId") = depositObj.TransactionId

        depositDataTable.Rows.Add(newRow)

        Dim cb As New OleDbCommandBuilder(depositDataAdapter)
        depositDataAdapter.Update(depositDataTable)

        ' ----- Close the database connection 
        db.Close()

        Return True

    End Function

    Public Shared Function UpdateDepositPaymentData(depositObj As ITransaction, tableName As String) As Boolean

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim rollOffDataTable As New DataTable
        Dim rollOffDataSet As New DataSet
        rollOffDataSet.Tables.Add(rollOffDataTable)

        Dim rollOffDataAdapter As New OleDbDataAdapter
        rollOffDataAdapter = New OleDbDataAdapter(String.Format("SELECT * FROM {0} WHERE ID = {1}", tableName, depositObj.DatabaseID), db)
        rollOffDataAdapter.Fill(rollOffDataTable)

        Dim editRow As DataRow = rollOffDataTable.Rows(0)

        editRow.Item("TransactionDate") = depositObj.TransactionDate
        editRow.Item("Amount") = depositObj.Amount
        editRow.Item("Description") = depositObj.Description
        editRow.Item("CheckNumber") = depositObj.CheckNumber
        editRow.Item("RollOffID") = depositObj.RollOffObject.DatabaseID
        editRow.Item("HasBeenBilled") = depositObj.HasBeenBilled
        editRow.Item("BilledDate") = depositObj.BilledDate
        editRow.Item("Taxable") = depositObj.Taxable

        ' ----- added for CC
        editRow.Item("CreditCard") = depositObj.CreditCardTransaction
        editRow.Item("CreditCardAuthNumber") = depositObj.CreditCardAuthNumber
        editRow.Item("TransactionId") = depositObj.TransactionId

        Dim cb As New OleDbCommandBuilder(rollOffDataAdapter)
        rollOffDataAdapter.Update(rollOffDataTable)

        ' ----- Close the database connection 
        db.Close()

        Return True

    End Function

    Public Shared Function DeleteDepositPayment(depositObj As ITransaction, tableName As String) As Boolean
        Return Delete(tableName, depositObj.DatabaseID)
    End Function

    Public Shared Function GetDepositPaymentList(rollOffObj As CRollOff, tableName As String) As List(Of ITransaction)

        Dim chargeListing As New List(Of ITransaction)

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim strSQL As String = String.Format("SELECT * FROM {1} WHERE RollOffID = {0}", rollOffObj.DatabaseID, tableName)
        Dim rs As New OleDbCommand(strSQL, db)
        Dim rollOffReader As OleDbDataReader = rs.ExecuteReader

        If rollOffReader.HasRows Then

            Do While rollOffReader.Read
                Dim tempObj As New CDeposits
                tempObj.DatabaseID = rollOffReader("ID")
                tempObj.TransactionDate = rollOffReader("TransactionDate")
                tempObj.Amount = rollOffReader("Amount")
                tempObj.Description = rollOffReader("Description")
                tempObj.CheckNumber = rollOffReader("CheckNumber").ToString
                tempObj.RollOffObject = rollOffObj
                tempObj.HasBeenBilled = rollOffReader("HasBeenBilled")
                tempObj.BilledDate = rollOffReader("BilledDate")
                tempObj.Taxable = rollOffReader("Taxable")
                tempObj.CreditCardTransaction = rollOffReader("CreditCard")
                tempObj.CreditCardAuthNumber = rollOffReader("CreditCardAuthNumber").ToString()
                tempObj.TransactionId = rollOffReader("TransactionId").ToString()

                chargeListing.Add(tempObj)
            Loop

        End If

        ' ----- Close everything up 
        rollOffReader.Close()
        db.Close()

        ' ----- Return the list 
        Return chargeListing.OrderBy(Function(c) c.TransactionDate).ToList

    End Function

    Public Shared Function FindDepositPayment(databaseID As Integer, tableName As String) As ITransaction

        Dim tempObj As ITransaction = Nothing
        If tableName = "Deposits" Then
            tempObj = New CDeposits
        Else
            tempObj = New CPayments
        End If

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim strSQL As String = String.Format("SELECT * FROM {1} WHERE ID = {0}", databaseID, tableName)
        Dim rs As New OleDbCommand(strSQL, db)
        Dim rollOffReader As OleDbDataReader = rs.ExecuteReader

        If rollOffReader.HasRows Then
            rollOffReader.Read()
            tempObj.DatabaseID = rollOffReader("ID")
            tempObj.TransactionDate = rollOffReader("TransactionDate")
            tempObj.Amount = rollOffReader("Amount")
            tempObj.Description = rollOffReader("Description")
            tempObj.CheckNumber = rollOffReader("CheckNumber").ToString
            tempObj.RollOffObject = GetRollOff(rollOffReader("RollOffID"))
            tempObj.HasBeenBilled = rollOffReader("HasBeenBilled")
            tempObj.BilledDate = rollOffReader("BilledDate")
            tempObj.Taxable = rollOffReader("Taxable")
            tempObj.CreditCardTransaction = rollOffReader("CreditCard")
            tempObj.CreditCardAuthNumber = rollOffReader("CreditCardAuthNumber")
            tempObj.TransactionId = rollOffReader("TransactionId").ToString()
        End If

        ' ----- Close everything up 
        rollOffReader.Close()
        db.Close()

        ' ----- Return the list 
        Return tempObj

    End Function

    Public Shared Function GetDepositPaymentListForDateRange(startDate As Date, endDate As Date, tableName As String) As List(Of ITransaction)

        Dim chargeListing As New List(Of ITransaction)

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim strSQL As String = String.Format("SELECT * FROM {2} WHERE TransactionDate >= #{0}# AND TransactionDate <= #{1}#", startDate.ToShortDateString, endDate.ToShortDateString, tableName)
        Dim rs As New OleDbCommand(strSQL, db)
        Dim rollOffReader As OleDbDataReader = rs.ExecuteReader

        If rollOffReader.HasRows Then

            Do While rollOffReader.Read
                Dim tempObj As ITransaction
                If tableName = "Deposits" Then
                    tempObj = New CDeposits
                Else
                    tempObj = New CPayments
                End If
                tempObj.DatabaseID = rollOffReader("ID")
                tempObj.TransactionDate = rollOffReader("TransactionDate")
                tempObj.Amount = rollOffReader("Amount")
                tempObj.Description = rollOffReader("Description").ToString
                tempObj.CheckNumber = rollOffReader("CheckNumber").ToString
                tempObj.RollOffObject = GetRollOff(rollOffReader("RollOffID"))
                tempObj.HasBeenBilled = rollOffReader("HasBeenBilled")
                tempObj.BilledDate = rollOffReader("BilledDate")
                tempObj.Taxable = rollOffReader("Taxable")
                tempObj.CreditCardTransaction = rollOffReader("CreditCard")
                tempObj.CreditCardAuthNumber = rollOffReader("CreditCardAuthNumber").ToString()
                tempObj.TransactionId = rollOffReader("TransactionId").ToString()
                chargeListing.Add(tempObj)
            Loop

        End If

        ' ----- Close everything up 
        rollOffReader.Close()
        db.Close()

        ' ----- Return the list 
        Return chargeListing.OrderBy(Function(c) c.TransactionDate).OrderBy(Function(c) c.RollOffObject.Customer.BillingAddress.LastName).ToList

    End Function

    Public Shared Function GetAllTransactions() As List(Of CMainScreenData)

        Dim chargeListing As New List(Of CMainScreenData)

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        For iStep As Integer = 1 To 3

            Dim strSQL As String = ""

            Select Case iStep

                Case 1
                    strSQL += "SELECT RollOffID, 0 AS ChargeType, Amount AS TransAmount, 'Deposits' AS TransType, TransactionDate as ChargeDate FROM Deposits "
                    strSQL += "INNER JOIN RollOff ON Deposits.RollOffID = RollOff.ID WHERE Active = True "

                Case 2
                    strSQL += "SELECT RollOffID, ChargeType, Total AS TransAmount, 'Charges' AS TransType, ChargeDateEnd AS ChargeDate FROM Charges "
                    strSQL += "INNER JOIN RollOff ON Charges.RollOffID = RollOff.ID WHERE Active = True "

                Case 3
                    strSQL += "SELECT RollOffID, 0 AS ChargeType, Amount AS TransAmount, 'Payments' AS TransType, TransactionDate as ChargeDate FROM Payments "
                    strSQL += "INNER JOIN RollOff ON Payments.RollOffID = RollOff.ID WHERE Active = True "

            End Select

            ' ----- Create a SQL string to pull all of the transactions 
            'Dim strSQL As String = ""
            'strSQL += "SELECT RollOffID, 0 AS ChargeType, Amount AS TransAmount, 'Deposits' AS TransType, TransactionDate as ChargeDate FROM Deposits "
            'strSQL += "INNER JOIN RollOff ON Deposits.RollOffID = RollOff.ID WHERE Active = True "
            'strSQL += "UNION "
            'strSQL += "SELECT RollOffID, ChargeType, Total AS TransAmount, 'Charges' AS TransType, ChargeDateEnd AS ChargeDate FROM Charges "
            'strSQL += "INNER JOIN RollOff ON Charges.RollOffID = RollOff.ID WHERE Active = True "
            'strSQL += "UNION "
            'strSQL += "SELECT RollOffID, 0 AS ChargeType, Amount AS TransAmount, 'Payments' AS TransType, TransactionDate as ChargeDate FROM Payments "
            'strSQL += "INNER JOIN RollOff ON Payments.RollOffID = RollOff.ID WHERE Active = True "

            Dim rs As New OleDbCommand(strSQL, db)
            Dim rollOffReader As OleDbDataReader = rs.ExecuteReader

            ' ----- Loop through the items and create a list of objects to be used in the main listing 
            If rollOffReader.HasRows Then
                Do While rollOffReader.Read
                    Dim tempObj As New CMainScreenData
                    tempObj.RollOffID = rollOffReader("RollOffID")
                    tempObj.ChargeType = rollOffReader("ChargeType")
                    tempObj.TransactionType = rollOffReader("TransType")
                    tempObj.Amount = rollOffReader("TransAmount")
                    tempObj.ChargeDate = rollOffReader("ChargeDate")
                    chargeListing.Add(tempObj)
                Loop
            End If

            ' ----- Close everything up 
            rollOffReader.Close()

        Next

        ' ----- Close the database 
        db.Close()

        ' ----- Return the list 
        Return chargeListing

    End Function

#End Region

#Region "Charge Data"

    Public Shared Function SaveChargeData(chargeObj As CCharges) As Boolean

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim chargesDataTable As New DataTable
        Dim chargesDataSet As New DataSet
        chargesDataSet.Tables.Add(chargesDataTable)

        Dim chargesDataAdapter As New OleDbDataAdapter
        chargesDataAdapter = New OleDbDataAdapter("SELECT * FROM Charges", db)
        chargesDataAdapter.Fill(chargesDataTable)

        Dim newRow As DataRow = chargesDataTable.NewRow
        newRow.Item("ChargeDateBegin") = chargeObj.ChargeDateBegin.ToShortDateString
        newRow.Item("ChargeDateEnd") = chargeObj.ChargeDateEnd.ToShortDateString
        newRow.Item("ChargeType") = chargeObj.ChargeType
        newRow.Item("Unit") = chargeObj.Unit
        newRow.Item("Rate") = Convert.ToDouble(String.Format("{0:f2}", chargeObj.Rate))
        newRow.Item("Total") = Convert.ToDouble(String.Format("{0:f2}", chargeObj.Total))
        newRow.Item("Description") = chargeObj.Description
        newRow.Item("RollOffID") = chargeObj.RollOffObject.DatabaseID
        newRow.Item("HasBeenBilled") = chargeObj.HasBeenBilled
        newRow.Item("BilledDate") = chargeObj.BilledDate.ToShortDateString
        newRow.Item("Taxable") = chargeObj.Taxable
        chargesDataTable.Rows.Add(newRow)

        Dim cb As New OleDbCommandBuilder(chargesDataAdapter)
        chargesDataAdapter.Update(chargesDataTable)

        ' ----- Close the database connection 
        db.Close()

        Return True

    End Function

    Public Shared Function UpdateChargeData(chargeObj As CCharges) As Boolean

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim chargesDataTable As New DataTable
        Dim chargesDataSet As New DataSet
        chargesDataSet.Tables.Add(chargesDataTable)

        Dim chargesDataAdapter As New OleDbDataAdapter
        chargesDataAdapter = New OleDbDataAdapter(String.Format("SELECT * FROM Charges WHERE ID = {0}", chargeObj.DatabaseID), db)
        chargesDataAdapter.Fill(chargesDataTable)

        Dim editRow As DataRow = chargesDataTable.Rows(0)
        editRow.Item("ChargeDateBegin") = chargeObj.ChargeDateBegin.ToShortDateString
        editRow.Item("ChargeDateEnd") = chargeObj.ChargeDateEnd.ToShortDateString
        editRow.Item("ChargeType") = chargeObj.ChargeType
        editRow.Item("Unit") = chargeObj.Unit
        editRow.Item("Rate") = Convert.ToDouble(String.Format("{0:f2}", chargeObj.Rate))
        editRow.Item("Total") = Convert.ToDouble(String.Format("{0:f2}", chargeObj.Total))
        editRow.Item("Description") = chargeObj.Description
        editRow.Item("RollOffID") = chargeObj.RollOffObject.DatabaseID
        editRow.Item("HasBeenBilled") = chargeObj.HasBeenBilled
        editRow.Item("BilledDate") = chargeObj.BilledDate.ToShortDateString
        editRow.Item("Taxable") = chargeObj.Taxable

        Dim cb As New OleDbCommandBuilder(chargesDataAdapter)
        chargesDataAdapter.Update(chargesDataTable)

        ' ----- Close the database connection 
        db.Close()

        Return True

    End Function

    Public Shared Function DeleteCharge(chargeObj As CCharges) As Boolean
        Return Delete("Charges", chargeObj.DatabaseID)
    End Function

    Public Shared Function FindCharge(databaseID As Integer) As CCharges

        Dim tempObj As New CCharges

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim strSQL As String = String.Format("SELECT * FROM Charges WHERE ID = {0}", databaseID)
        Dim rs As New OleDbCommand(strSQL, db)
        Dim chargesReader As OleDbDataReader = rs.ExecuteReader

        If chargesReader.HasRows Then
            chargesReader.Read()
            tempObj.DatabaseID = chargesReader("ID")
            tempObj.ChargeDateBegin = chargesReader("ChargeDateBegin")
            tempObj.ChargeDateEnd = chargesReader("ChargeDateEnd")
            tempObj.ChargeType = chargesReader("ChargeType")
            tempObj.Unit = chargesReader("Unit")
            tempObj.Rate = chargesReader("Rate")
            tempObj.Total = chargesReader("Total")
            tempObj.Description = chargesReader("Description")
            tempObj.RollOffObject = GetRollOff(chargesReader("RollOffID"))
            tempObj.HasBeenBilled = chargesReader("HasBeenBilled")
            tempObj.BilledDate = chargesReader("BilledDate")
            tempObj.Taxable = chargesReader("Taxable")
        End If

        ' ----- Close everything up 
        chargesReader.Close()
        db.Close()

        ' ----- Return the list 
        Return tempObj

    End Function

    Public Shared Function GetChargeList(rollOffID As Integer) As List(Of CCharges)

        Dim chargeListing As New List(Of CCharges)

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim strSQL As String = String.Format("SELECT * FROM Charges WHERE RollOffID = {0}", rollOffID)
        Dim rs As New OleDbCommand(strSQL, db)
        Dim chargesReader As OleDbDataReader = rs.ExecuteReader

        If chargesReader.HasRows Then
            Do While chargesReader.Read()
                Dim tempObj As New CCharges
                tempObj.DatabaseID = chargesReader("ID")
                tempObj.ChargeDateBegin = chargesReader("ChargeDateBegin")
                tempObj.ChargeDateEnd = chargesReader("ChargeDateEnd")
                tempObj.ChargeType = chargesReader("ChargeType")
                tempObj.Unit = chargesReader("Unit")
                tempObj.Rate = chargesReader("Rate")
                tempObj.Total = Convert.ToDouble(String.Format("{0:f2}", chargesReader("Total")))
                tempObj.Description = chargesReader("Description")
                tempObj.RollOffObject = GetRollOff(chargesReader("RollOffID"))
                tempObj.HasBeenBilled = chargesReader("HasBeenBilled")
                tempObj.BilledDate = chargesReader("BilledDate")
                tempObj.Taxable = chargesReader("Taxable")
                chargeListing.Add(tempObj)
            Loop
        End If

        ' ----- Close everything up 
        chargesReader.Close()
        db.Close()

        ' ----- Return the list 
        Return chargeListing.OrderBy(Function(c) c.ChargeDateBegin).ToList

    End Function

    Public Shared Function ReturnAllCharges() As List(Of CCharges)

        Dim chargeListing As New List(Of CCharges)

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim strSQL As String = String.Format("SELECT * FROM Charges")
        Dim rs As New OleDbCommand(strSQL, db)
        Dim chargesReader As OleDbDataReader = rs.ExecuteReader

        If chargesReader.HasRows Then
            Do While chargesReader.Read()
                Dim tempObj As New CCharges
                tempObj.DatabaseID = chargesReader("ID")
                tempObj.ChargeDateBegin = chargesReader("ChargeDateBegin")
                tempObj.ChargeDateEnd = chargesReader("ChargeDateEnd")
                tempObj.ChargeType = chargesReader("ChargeType")
                tempObj.Unit = chargesReader("Unit")
                tempObj.Rate = chargesReader("Rate")
                tempObj.Total = chargesReader("Total")
                tempObj.Description = chargesReader("Description")
                tempObj.RollOffObject = GetRollOff(chargesReader("RollOffID"))
                tempObj.HasBeenBilled = chargesReader("HasBeenBilled")
                tempObj.BilledDate = chargesReader("BilledDate")
                tempObj.Taxable = chargesReader("Taxable")
                chargeListing.Add(tempObj)
            Loop
        End If

        ' ----- Close everything up 
        chargesReader.Close()
        db.Close()

        ' ----- Return the list 
        Return chargeListing

    End Function

#End Region

#Region "Waiting List"

    Public Shared Function SaveWaitingList(waitingListObj As CWaitingList) As Boolean

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim waitingListDataTable As New DataTable
        Dim waitingListDataSet As New DataSet
        waitingListDataSet.Tables.Add(waitingListDataTable)

        Dim waitingListDataAdapter As New OleDbDataAdapter
        waitingListDataAdapter = New OleDbDataAdapter("SELECT * FROM WaitingList", db)
        waitingListDataAdapter.Fill(waitingListDataTable)

        Dim newRow As DataRow = waitingListDataTable.NewRow

        newRow.Item("CustomerID") = waitingListObj.Customer.DatabaseID
        newRow.Item("NumberOnList") = waitingListObj.NumberOnList
        newRow.Item("CallDate") = waitingListObj.CallDate.ToShortDateString
        newRow.Item("WaitListStatus") = waitingListObj.WaitListStatus
        newRow.Item("RollOffSize") = waitingListObj.RollOffSize
        newRow.Item("RollOffUse") = waitingListObj.RollOffUse
        newRow.Item("Notes") = waitingListObj.Notes
        newRow.Item("CancelDate") = waitingListObj.CancelDate.ToShortDateString
        newRow.Item("WaitListStatus") = waitingListObj.WaitListStatus

        ' ----- Serialize the service address 
        Dim pickupAdd As StringWriter = New StringWriter()
        Dim serializer As New XmlSerializer(GetType(CAddressBlock))
        serializer.Serialize(pickupAdd, waitingListObj.ServiceAddress)
        newRow.Item("ServiceAddress") = pickupAdd.ToString

        waitingListDataTable.Rows.Add(newRow)

        Dim cb As New OleDbCommandBuilder(waitingListDataAdapter)
        waitingListDataAdapter.Update(waitingListDataTable)

        ' ----- Close the database connection 
        db.Close()

        Return True

    End Function

    Public Shared Function UpdateWaitingList(waitingListObj As CWaitingList) As Boolean

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim rollOffDataTable As New DataTable
        Dim rollOffDataSet As New DataSet
        rollOffDataSet.Tables.Add(rollOffDataTable)

        Dim rollOffDataAdapter As New OleDbDataAdapter
        rollOffDataAdapter = New OleDbDataAdapter(String.Format("SELECT * FROM WaitingList WHERE ID = {0}", waitingListObj.DatabaseID), db)
        rollOffDataAdapter.Fill(rollOffDataTable)

        Dim editRow As DataRow = rollOffDataTable.Rows(0)

        editRow.Item("CustomerID") = waitingListObj.Customer.DatabaseID
        editRow.Item("NumberOnList") = waitingListObj.NumberOnList
        editRow.Item("CallDate") = waitingListObj.CallDate.ToShortDateString
        editRow.Item("WaitListStatus") = waitingListObj.WaitListStatus
        editRow.Item("RollOffSize") = waitingListObj.RollOffSize
        editRow.Item("RollOffUse") = waitingListObj.RollOffUse
        editRow.Item("Notes") = waitingListObj.Notes '
        editRow.Item("CancelDate") = waitingListObj.CancelDate.ToShortDateString
        editRow.Item("WaitListStatus") = waitingListObj.WaitListStatus

        ' ----- Serialize the service address 
        Dim pickupAdd As StringWriter = New StringWriter()
        Dim serializer As New XmlSerializer(GetType(CAddressBlock))
        serializer.Serialize(pickupAdd, waitingListObj.ServiceAddress)
        editRow.Item("ServiceAddress") = pickupAdd.ToString

        Dim cb As New OleDbCommandBuilder(rollOffDataAdapter)
        rollOffDataAdapter.Update(rollOffDataTable)

        ' ----- Close the database connection 
        db.Close()

        Return True

    End Function

    Public Shared Function DeleteWaitingList(waitingListObj As CWaitingList) As Boolean
        Return Delete("WaitingList", waitingListObj.DatabaseID)
    End Function

    Public Shared Function GetCustomersOnWaitingList(listType As CWaitingList.WaitListStatusTypes) As List(Of CWaitingList)

        Dim waitingListObjList As New List(Of CWaitingList)

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        ' ----- Grab the current waiting list data 
        Dim strSQL As String = String.Format("SELECT * FROM WaitingList WHERE WaitListStatus = {0} ORDER BY NumberOnList, CallDate", listType.ToString("d"))
        Dim rs As New OleDbCommand(strSQL, db)
        Dim waitingListReader As OleDbDataReader = rs.ExecuteReader

        If waitingListReader.HasRows Then

            Do While waitingListReader.Read
                Dim tempObj As New CWaitingList
                tempObj.DatabaseID = waitingListReader("ID")
                tempObj.NumberOnList = waitingListReader("NumberOnList")
                tempObj.Customer = CurrentCustomerList.Where(Function(c) c.DatabaseID = waitingListReader("CustomerID")).Select(Function(c) c).FirstOrDefault
                tempObj.CallDate = waitingListReader("CallDate")
                tempObj.WaitListStatus = waitingListReader("WaitListStatus")
                tempObj.RollOffSize = waitingListReader("RollOffSize")
                tempObj.RollOffUse = waitingListReader("RollOffUse")
                tempObj.Notes = waitingListReader("Notes")
                tempObj.CancelDate = waitingListReader("CancelDate")
                tempObj.WaitListStatus = waitingListReader("WaitListStatus")

                ' ----- Pick up the service address 
                Try
                    Dim serviceAddressString As String = waitingListReader("ServiceAddress").ToString
                    Dim x As New Xml.Serialization.XmlSerializer(GetType(CAddressBlock))
                    Dim srServiceAddress As New IO.StringReader(serviceAddressString)
                    Dim tmpListing As CAddressBlock = CType(x.Deserialize(srServiceAddress), CAddressBlock)
                    tempObj.ServiceAddress = tmpListing
                Catch ex As Exception

                End Try


                waitingListObjList.Add(tempObj)
            Loop

        End If

        ' ----- Close everything up 
        waitingListReader.Close()
        db.Close()

        ' ----- Return the list 
        Return waitingListObjList

    End Function

    Public Shared Function GetMaxWaitingListNumber(listType As CWaitingList.WaitListStatusTypes) As Integer

        Dim waitingListObjList As New List(Of CWaitingList)

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        ' ----- Grab the current waiting list data 
        Dim strSQL As String = String.Format("SELECT Max(NumberOnList) AS MaxNumber FROM WaitingList WHERE WaitListStatus = {0}", listType.ToString("d"))
        Dim rs As New OleDbCommand(strSQL, db)

        ' ----- Execute the SQL to get the maximum number 
        Dim maxNumber As Integer = 0
        Try
            Integer.TryParse(rs.ExecuteScalar.ToString, maxNumber)
        Catch ex As Exception
        End Try

        ' ----- Close the database 
        db.Close()

        ' ----- Return the list 
        Return maxNumber

    End Function

#End Region

#Region "Roll Off Fees"

    Public Shared Function SaveRollOffFee(rollOffFeeObj As CRollOffFee)

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim rollOffFeeDataTable As New DataTable
        Dim rollOffFeeDataSet As New DataSet
        rollOffFeeDataSet.Tables.Add(rollOffFeeDataTable)

        Dim rollOffFeeDataAdapter As New OleDbDataAdapter
        rollOffFeeDataAdapter = New OleDbDataAdapter("SELECT * FROM RollOffFees", db)
        rollOffFeeDataAdapter.Fill(rollOffFeeDataTable)

        Dim newRow As DataRow = rollOffFeeDataTable.NewRow

        newRow.Item("RollOffSize") = rollOffFeeObj.RollOffSize
        newRow.Item("RentalAmount") = rollOffFeeObj.RentalAmount
        newRow.Item("DailyFee") = rollOffFeeObj.DailyFee
        newRow.Item("Description") = rollOffFeeObj.Description

        rollOffFeeDataTable.Rows.Add(newRow)

        Dim cb As New OleDbCommandBuilder(rollOffFeeDataAdapter)
        rollOffFeeDataAdapter.Update(rollOffFeeDataTable)

        ' ----- Close the database connection 
        db.Close()

        Return True

    End Function

    Public Shared Function UpdateRollOffFee(rollOffFeeObj As CRollOffFee)

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim rollOffFeeDataTable As New DataTable
        Dim rollOffFeeDataSet As New DataSet
        rollOffFeeDataSet.Tables.Add(rollOffFeeDataTable)

        Dim rollOffFeeDataAdapter As New OleDbDataAdapter
        rollOffFeeDataAdapter = New OleDbDataAdapter(String.Format("SELECT * FROM RollOffFees WHERE ID = {0}", rollOffFeeObj.DatabaseID), db)
        rollOffFeeDataAdapter.Fill(rollOffFeeDataTable)

        Dim editRow As DataRow = rollOffFeeDataTable.Rows(0)

        editRow.Item("RollOffSize") = rollOffFeeObj.RollOffSize
        editRow.Item("RentalAmount") = rollOffFeeObj.RentalAmount
        editRow.Item("DailyFee") = rollOffFeeObj.DailyFee
        editRow.Item("Description") = rollOffFeeObj.Description

        Dim cb As New OleDbCommandBuilder(rollOffFeeDataAdapter)
        rollOffFeeDataAdapter.Update(rollOffFeeDataTable)

        Return True

    End Function

    Public Shared Function GetRollOffFees() As List(Of CRollOffFee)

        Dim rollOffFeeObjList As New List(Of CRollOffFee)

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        ' ----- Grab the current waiting list data 
        Dim strSQL As String = String.Format("SELECT * FROM RollOffFees")
        Dim rs As New OleDbCommand(strSQL, db)
        Dim rollOffFeeReader As OleDbDataReader = rs.ExecuteReader

        If rollOffFeeReader.HasRows Then

            Do While rollOffFeeReader.Read
                Dim tempObj As New CRollOffFee
                tempObj.DatabaseID = rollOffFeeReader("ID")
                tempObj.RollOffSize = rollOffFeeReader("RollOffSize")
                tempObj.RentalAmount = rollOffFeeReader("RentalAmount")
                tempObj.DailyFee = rollOffFeeReader("DailyFee")
                tempObj.Description = rollOffFeeReader("Description")
                rollOffFeeObjList.Add(tempObj)
            Loop

        End If

        ' ----- Close everything up 
        rollOffFeeReader.Close()
        db.Close()

        ' ----- Return the list 
        Return rollOffFeeObjList

    End Function

#End Region

#Region "Billing"

    Public Shared Function SaveBilling(billingObj As CBillingObject, Optional updateBill As Boolean = False) As Boolean

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim billingDataTable As New DataTable
        Dim billingDataSet As New DataSet
        billingDataSet.Tables.Add(billingDataTable)

        Dim billingDataAdapter As New OleDbDataAdapter

        Dim strSQL As String = ""
        If updateBill Then
            strSQL = String.Format("SELECT * FROM Billing WHERE ID = {0}", billingObj.DatabaseID)
        Else
            strSQL = "SELECT * FROM Billing"
        End If

        billingDataAdapter = New OleDbDataAdapter(strSQL, db)
        billingDataAdapter.Fill(billingDataTable)

        Dim newRow As DataRow = Nothing
        If updateBill Then
            If billingDataTable.Rows.Count > 0 Then
                newRow = billingDataTable.Rows(0)
            Else
                Return False
            End If
        Else
            newRow = billingDataTable.NewRow
        End If

        newRow.Item("BillingDate") = billingObj.BillingDate.ToShortDateString
        newRow.Item("RollOffID") = billingObj.RollOffObject.DatabaseID
        newRow.Item("SubTotal") = billingObj.SubTotal
        newRow.Item("Tax") = billingObj.Tax
        newRow.Item("Total") = billingObj.Total

        ' ----- Serialize the charge listing 
        Dim sw As StringWriter = New StringWriter()
        Dim serializer As New XmlSerializer(GetType(List(Of CRollOffHistoryBilling)))
        serializer.Serialize(sw, billingObj.ChargeListing)

        ' ----- Save it to the database 
        newRow.Item("ChargeListing") = sw.ToString

        If Not updateBill Then billingDataTable.Rows.Add(newRow)

        Dim cb As New OleDbCommandBuilder(billingDataAdapter)
        billingDataAdapter.Update(billingDataTable)

        ' ----- Close the database connection 
        db.Close()

        Return True

    End Function

    Public Shared Function DeleteBilling(billingObj As CBillingObject)
        Return Delete("Billing", billingObj.DatabaseID)
    End Function

    Public Shared Function ReturnBillsList(roObj As CRollOff) As List(Of CBillingObject)

        Dim rollOffFeeObjList As New List(Of CBillingObject)

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        ' ----- Grab the current waiting list data 
        Dim strSQL As String = String.Format("SELECT * FROM Billing WHERE RollOffID = {0}", roObj.DatabaseID)
        Dim rs As New OleDbCommand(strSQL, db)
        Dim rollOffFeeReader As OleDbDataReader = rs.ExecuteReader

        If rollOffFeeReader.HasRows Then

            Do While rollOffFeeReader.Read
                Dim tempObj As New CBillingObject
                tempObj.DatabaseID = rollOffFeeReader("ID")
                tempObj.BillingDate = rollOffFeeReader("BillingDate")
                tempObj.RollOffObject = roObj
                tempObj.SubTotal = rollOffFeeReader("SubTotal")
                tempObj.Tax = rollOffFeeReader("Tax")
                tempObj.Total = rollOffFeeReader("Total")

                Dim objString As String = rollOffFeeReader("ChargeListing")
                Dim x As New Xml.Serialization.XmlSerializer(GetType(List(Of CRollOffHistoryBilling)))
                Dim sr As New IO.StringReader(objString)
                Dim tmpListing As List(Of CRollOffHistoryBilling) = CType(x.Deserialize(sr), List(Of CRollOffHistoryBilling))
                tempObj.ChargeListing = tmpListing

                rollOffFeeObjList.Add(tempObj)
            Loop

        End If

        ' ----- Close everything up 
        rollOffFeeReader.Close()
        db.Close()

        ' ----- Return the list 
        Return rollOffFeeObjList

    End Function

    Public Shared Function ReturnBillsListByDateRange(dteBillStart As DateTime, dteBillEnd As DateTime) As List(Of CBillingObject)

        Dim rollOffFeeObjList As New List(Of CBillingObject)

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        ' ----- Grab the current waiting list data 
        Dim strSQL As String = String.Format("SELECT * FROM Billing WHERE BillingDate >= #{0}# AND BillingDate <= #{1}#", dteBillStart.ToShortDateString, dteBillEnd.ToShortDateString)

        Dim rs As New OleDbCommand(strSQL, db)
        Dim rollOffFeeReader As OleDbDataReader = rs.ExecuteReader

        If rollOffFeeReader.HasRows Then

            Do While rollOffFeeReader.Read
                Dim tempObj As New CBillingObject
                tempObj.DatabaseID = rollOffFeeReader("ID")
                tempObj.BillingDate = rollOffFeeReader("BillingDate")
                tempObj.RollOffObject = roObj
                tempObj.SubTotal = rollOffFeeReader("SubTotal")
                tempObj.Tax = rollOffFeeReader("Tax")
                tempObj.Total = rollOffFeeReader("Total")

                Dim objString As String = rollOffFeeReader("ChargeListing")
                Dim x As New Xml.Serialization.XmlSerializer(GetType(List(Of CRollOffHistoryBilling)))
                Dim sr As New IO.StringReader(objString)
                Dim tmpListing As List(Of CRollOffHistoryBilling) = CType(x.Deserialize(sr), List(Of CRollOffHistoryBilling))
                tempObj.ChargeListing = tmpListing

                rollOffFeeObjList.Add(tempObj)
            Loop

        End If

        ' ----- Close everything up 
        rollOffFeeReader.Close()
        db.Close()

        ' ----- Return the list 
        Return rollOffFeeObjList

    End Function

#End Region

#Region "Customers"

    Public Shared Function SaveCustomer(customerObj As CCustomer, Optional updateCustomer As Boolean = False) As Boolean

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim customerDataTable As New DataTable
        Dim customerDataSet As New DataSet
        customerDataSet.Tables.Add(customerDataTable)

        Dim customerDataAdapter As New OleDbDataAdapter
        If updateCustomer Then
            customerDataAdapter = New OleDbDataAdapter(String.Format("SELECT * FROM Customers WHERE ID = {0}", customerObj.DatabaseID), db)
        Else
            customerDataAdapter = New OleDbDataAdapter("SELECT * FROM Customers", db)
        End If

        customerDataAdapter.Fill(customerDataTable)

        Dim newRow As DataRow = customerDataTable.NewRow
        If updateCustomer Then
            If customerDataTable.Rows.Count > 0 Then
                newRow = customerDataTable.Rows(0)
            Else
                Return False
            End If
        Else
            newRow = customerDataTable.NewRow
        End If

        newRow.Item("CustomerNumber") = customerObj.CustomerNumber
        newRow.Item("CustomerNumberBase") = customerObj.CustomerNumberBase
        newRow.Item("ContactName") = customerObj.ContactName
        newRow.Item("BusinessPhone") = customerObj.BusinessPhone
        newRow.Item("HomePhone") = customerObj.HomePhone
        newRow.Item("TaxRate") = customerObj.TaxRate
        newRow.Item("SendToCollections") = customerObj.SendToCollections
        newRow.Item("CurrentBalanceForCollection") = customerObj.CurrentBalanceForCollection
        newRow.Item("DateSentToCollections") = customerObj.CollectionBalanceAsOf
        newRow.Item("CustomerNotes") = customerObj.CustomerNotes

        ' ----- Serialize the charge listing 
        Dim billingAdd As StringWriter = New StringWriter()
        'Dim pickupAdd As StringWriter = New StringWriter()
        Dim serializer As New XmlSerializer(GetType(CAddressBlock))
        serializer.Serialize(billingAdd, customerObj.BillingAddress)
        'serializer.Serialize(pickupAdd, customerObj.PickUpAddress)

        newRow.Item("BillingAddress") = billingAdd.ToString
        'newRow.Item("PickupAddress") = pickupAdd.ToString

        If Not updateCustomer Then customerDataTable.Rows.Add(newRow)

        Dim cb As New OleDbCommandBuilder(customerDataAdapter)
        customerDataAdapter.Update(customerDataTable)

        ' ----- Close the database connection 
        db.Close()

        Return True

    End Function

    Public Shared Function SaveCustomerBatch(customerList As List(Of CCustomer)) As Boolean

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim customerDataTable As New DataTable
        Dim customerDataSet As New DataSet
        customerDataSet.Tables.Add(customerDataTable)

        Dim customerDataAdapter As New OleDbDataAdapter
        customerDataAdapter = New OleDbDataAdapter("SELECT * FROM Customers", db)
        customerDataAdapter.Fill(customerDataTable)

        For Each customerObj As CCustomer In customerList

            Dim newRow As DataRow = customerDataTable.NewRow

            newRow.Item("CustomerNumber") = customerObj.CustomerNumber
            newRow.Item("CustomerNumberBase") = customerObj.CustomerNumberBase
            newRow.Item("ContactName") = customerObj.ContactName
            newRow.Item("BusinessPhone") = customerObj.BusinessPhone
            newRow.Item("HomePhone") = customerObj.HomePhone
            newRow.Item("TaxRate") = customerObj.TaxRate
            newRow.Item("SendToCollections") = customerObj.SendToCollections

            ' ----- Serialize the charge listing 
            Dim billingAdd As StringWriter = New StringWriter()
            'Dim pickupAdd As StringWriter = New StringWriter()
            Dim serializer As New XmlSerializer(GetType(CAddressBlock))
            serializer.Serialize(billingAdd, customerObj.BillingAddress)
            'serializer.Serialize(pickupAdd, customerObj.PickUpAddress)

            newRow.Item("BillingAddress") = billingAdd.ToString
            'newRow.Item("PickupAddress") = pickupAdd.ToString

            customerDataTable.Rows.Add(newRow)

        Next

        Dim cb As New OleDbCommandBuilder(customerDataAdapter)
        customerDataAdapter.Update(customerDataTable)

        ' ----- Close the database connection 
        db.Close()

        Return True

    End Function

    Public Shared Function DeleteCustomer(customerObj As CCustomer)
        Return Delete("Customers", customerObj.DatabaseID)
    End Function

    Public Shared Function GetCustomerList() As List(Of CCustomer)

        Dim customerList As New List(Of CCustomer)

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim strSQL As String = String.Format("SELECT * FROM Customers")
        Dim rs As New OleDbCommand(strSQL, db)
        Dim customerReader As OleDbDataReader = rs.ExecuteReader

        If customerReader.HasRows Then

            Do While customerReader.Read
                Dim customerObj As New CCustomer
                customerObj.DatabaseID = customerReader("ID")
                customerObj.CustomerNumber = customerReader("CustomerNumber")
                customerObj.CustomerNumberBase = customerReader("CustomerNumberBase")
                customerObj.ContactName = customerReader("ContactName")
                customerObj.BusinessPhone = customerReader("BusinessPhone")
                customerObj.HomePhone = customerReader("HomePhone")
                customerObj.TaxRate = customerReader("TaxRate")
                customerObj.SendToCollections = customerReader("SendToCollections")
                customerObj.CustomerNotes = customerReader("CustomerNotes").ToString

                customerObj.CurrentBalanceForCollection = If(customerReader("CurrentBalanceForCollection").ToString = "", 0.0, customerReader("CurrentBalanceForCollection"))

                If customerReader("DateSentToCollections").Equals(DBNull.Value) Then
                    customerObj.CollectionBalanceAsOf = Date.Today
                Else
                    customerObj.CollectionBalanceAsOf = customerReader("DateSentToCollections")
                End If

                Dim billingAddressString As String = customerReader("BillingAddress")
                'Dim pickupAddressString As String = customerReader("PickupAddress")

                Dim x As New Xml.Serialization.XmlSerializer(GetType(CAddressBlock))

                Dim srBilling As New IO.StringReader(billingAddressString)
                Dim tmpListing As CAddressBlock = CType(x.Deserialize(srBilling), CAddressBlock)
                customerObj.BillingAddress = tmpListing

                'Dim srPickup As New IO.StringReader(pickupAddressString)
                'Dim pickListing As CAddressBlock = CType(x.Deserialize(srPickup), CAddressBlock)
                'customerObj.PickUpAddress = pickListing

                customerList.Add(customerObj)

            Loop

        End If

        ' ----- Close everything up 
        customerReader.Close()
        db.Close()

        ' ----- Return the list 
        Return customerList

    End Function

    Public Shared Function GetCustomersInCollection() As List(Of CCustomer)

        Dim customerList As New List(Of CCustomer)

        ' ----- Open the data connection 
        Dim db As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & DatabaseName)
        db.Open()

        Dim strSQL As String = String.Format("SELECT * FROM Customers WHERE SendToCollections = True")
        Dim rs As New OleDbCommand(strSQL, db)
        Dim customerReader As OleDbDataReader = rs.ExecuteReader

        If customerReader.HasRows Then

            Do While customerReader.Read
                Dim customerObj As New CCustomer
                customerObj.DatabaseID = customerReader("ID")
                customerObj.CustomerNumber = customerReader("CustomerNumber")
                customerObj.CustomerNumberBase = customerReader("CustomerNumberBase")
                customerObj.ContactName = customerReader("ContactName")
                customerObj.BusinessPhone = customerReader("BusinessPhone")
                customerObj.HomePhone = customerReader("HomePhone")
                customerObj.TaxRate = customerReader("TaxRate")
                customerObj.SendToCollections = customerReader("SendToCollections")
                customerObj.CurrentBalanceForCollection = If(customerReader("CurrentBalanceForCollection").ToString = "", 0.0, customerReader("CurrentBalanceForCollection"))

                If customerReader("DateSentToCollections").Equals(DBNull.Value) Then
                    customerObj.CollectionBalanceAsOf = Date.Today
                Else
                    customerObj.CollectionBalanceAsOf = customerReader("DateSentToCollections")
                End If

                customerObj.CustomerNotes = customerReader("CustomerNotes").ToString

                Dim billingAddressString As String = customerReader("BillingAddress")

                Dim x As New Xml.Serialization.XmlSerializer(GetType(CAddressBlock))

                Dim srBilling As New IO.StringReader(billingAddressString)
                Dim tmpListing As CAddressBlock = CType(x.Deserialize(srBilling), CAddressBlock)
                customerObj.BillingAddress = tmpListing

                customerList.Add(customerObj)

            Loop

        End If

        ' ----- Close everything up 
        customerReader.Close()
        db.Close()

        ' ----- Return the list 
        Return customerList

    End Function

#End Region

End Class

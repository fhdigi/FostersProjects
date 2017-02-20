Imports System.IO

Public Class CFPConversion

    Public Property AccountNumber As String = ""
    Public Property AccountType As String = ""
    Public Property CustomerName As String = ""
    Public Property RouteAddress As String = ""
    Public Property RouteCity As String = ""
    Public Property RouteState As String = ""
    Public Property RouteZipcode As String = ""
    Public Property BillingName As String = ""
    Public Property BillingAddress As String = ""
    Public Property BillingCity As String = ""
    Public Property BillingState As String = ""
    Public Property BillingZipcode As String = ""
    Public Property BusinessPhone As String = "'"
    Public Property HomePhone As String = "'"

    Public Property RollOff10Yard As String = ""
    Public Property RollOff20Yard As String = ""
    Public Property RollOff30Yard As String = ""
    Public Property RollOffDumpFee As String = ""

    Public Property TaxRate As String = ""

    Public Property RollOff10YardRental As String = ""
    Public Property RollOff20YardRental As String = ""
    Public Property RollOff30YardRental As String = ""

    Public Property LastPaymentAmount As String = ""
    Public Property LastPaymentDate As String = ""

    Public Property LastBillingDate As String = ""
    Public Property AdditionalChargeDesc1 As String = ""
    Public Property AdditionalChargeDesc2 As String = ""
    Public Property Balance As String = ""
    Public Property MonthsToBill As String = ""
    Public Property LastMonthBilled As String = ""
    Public Property PrintBill As String = ""
    Public Property CheckNumber As String = ""
    Public Property AdvancedBilling As String = ""
    Public Property AdditionalInfo As String = ""
    Public Property SequenceNumber As Integer = 0

    Public Property DumpsterCharge As String = ""
    Public Property RollOffCharge As String = ""
    Public Property Cart90GalCharge As String = ""
    Public Property CardboardCharge As String = ""
    Public Property MiscCharge As String = ""
    Public Property RecycleCharge As String = ""
    Public Property DumpsterRental As String = ""

    Public Property DepositAmount As String = ""

    Public Shared Sub ConvertFilePro()

        Dim headerFile(516) As Char
        Dim customerRecordArray(504) As Char
        Dim charTrim() As Char = {" "c, ControlChars.NullChar}

        Dim fileProFile As New StreamReader(My.Application.Info.DirectoryPath & "\KEY_ForRollOffs")

        Dim listOfCustomers As New List(Of CCustomer)

        fileProFile.ReadBlock(headerFile, 0, 516)

        Do
            ' ----- Read the customer line 
            fileProFile.ReadBlock(customerRecordArray, 0, 504)

            ' ----- Assign it to a string 
            Dim fileString As String = New String(customerRecordArray)

            ' ----- Create a new customer object 
            Dim tempObj As New CCustomer
            'tempObj.PickUpAddress = New CAddressBlock
            tempObj.BillingAddress = New CAddressBlock

            ' ----- Parse the information 
            tempObj.CustomerNumber = fileString.Substring(0, 15).Trim(charTrim)

            If tempObj.CustomerNumber.Trim <> "" Then
                Dim workingString As String = tempObj.CustomerNumber.Trim
                If workingString.Contains("-") Then
                    tempObj.CustomerNumberPrefix = workingString.Substring(0, workingString.IndexOf("-"))
                    tempObj.CustomerNumberBase = Convert.ToInt32(workingString.Substring(workingString.IndexOf("-") + 1))
                End If
            End If

            'tempObj.PickUpAddress.FirstName = fileString.Substring(15, 13).Trim(charTrim)
            'tempObj.PickUpAddress.LastName = fileString.Substring(28, 21).Trim(charTrim)
            'tempObj.PickUpAddress.Address = fileString.Substring(49, 24).Trim(charTrim)
            'tempObj.PickUpAddress.City = fileString.Substring(73, 15).Trim(charTrim)
            'tempObj.PickUpAddress.State = fileString.Substring(88, 2).Trim(charTrim)
            'tempObj.PickUpAddress.ZipCode = fileString.Substring(90, 10).Trim(charTrim)

            tempObj.BillingAddress.FirstName = fileString.Substring(100, 13).Trim(charTrim)
            tempObj.BillingAddress.LastName = fileString.Substring(113, 21).Trim(charTrim)
            tempObj.BillingAddress.Address = fileString.Substring(134, 24).Trim(charTrim)
            tempObj.BillingAddress.City = fileString.Substring(158, 15).Trim(charTrim)
            tempObj.BillingAddress.State = fileString.Substring(173, 2).Trim(charTrim)
            tempObj.BillingAddress.ZipCode = fileString.Substring(175, 10).Trim(charTrim)

            tempObj.BusinessPhone = fileString.Substring(185, 14).Trim(charTrim)
            tempObj.HomePhone = fileString.Substring(199, 14).Trim(charTrim)
            tempObj.TaxRate = fileString.Substring(253, 5).Trim(charTrim)
            tempObj.PrintBill = "" 'fileString.Substring(355, 1).Trim(charTrim)

            'tempObj.RollOff10Yard = "" ' fileString.Substring(213, 6).Trim(charTrim)
            'tempObj.RollOff20Yard = "" ' fileString.Substring(219, 6).Trim(charTrim)
            'tempObj.RollOff30Yard = "" ' fileString.Substring(225, 6).Trim(charTrim)
            'tempObj.DepositAmount = "" 'fileString.Substring(247, 6).Trim(charTrim)
            'tempObj.RollOff10YardRental = "" 'fileString.Substring(275, 5).Trim(charTrim)
            'tempObj.RollOff20YardRental = "" 'fileString.Substring(280, 5).Trim(charTrim)
            'tempObj.RollOff30YardRental = "" 'fileString.Substring(285, 5).Trim(charTrim)
            'tempObj.LastPaymentDate = "" ' fileString.Substring(356, 8).Trim(charTrim)
            'tempObj.LastPaymentAmount = "" 'fileString.Substring(364, 8).Trim(charTrim)

            ' ----- Try to read the date of pickup 
            'If Date.TryParse(fileString.Substring(436, 8).Trim(charTrim), tempObj.DateRollOffDelivered) = False Then
            '    tempObj.DateRollOffDelivered = Date.Today
            'End If

            listOfCustomers.Add(tempObj)

        Loop Until fileProFile.EndOfStream = True

        fileProFile.Close()

        CDataExtender.SaveCustomerBatch(listOfCustomers)
       
    End Sub

End Class

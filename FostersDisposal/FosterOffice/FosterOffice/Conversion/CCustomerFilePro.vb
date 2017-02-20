Imports System.IO

Public Class CCustomerFilePro

    Public Property AccountNumber As Integer = 0
    Public Property AccountType As String = ""
    Public Property RouteLastName As String = ""
    Public Property RouteFirstName As String = ""
    Public Property RouteAddress As String = ""
    Public Property RouteCity As String = ""
    Public Property RouteState As String = ""
    Public Property RouteZipcode As String = ""
    Public Property BillingLastName As String = ""
    Public Property BillingFirstName As String = ""
    Public Property BillingAddress As String = ""
    Public Property BillingCity As String = ""
    Public Property BillingState As String = ""
    Public Property BillingZipcode As String = ""
    Public Property LastBillingDate As String = ""
    Public Property LastPaymentDate As String = ""
    Public Property AdditionalChargeDesc1 As String = ""
    Public Property AdditionalChargeDesc2 As String = ""
    Public Property Balance As String = ""
    Public Property LastPaymentAmount As String = ""
    Public Property JanAmount As String = ""
    Public Property FebAmount As String = ""
    Public Property MarAmount As String = ""
    Public Property AprAmount As String = ""
    Public Property MayAmount As String = ""
    Public Property JunAmount As String = ""
    Public Property JulAmount As String = ""
    Public Property AugAmount As String = ""
    Public Property SepAmount As String = ""
    Public Property OctAmount As String = ""
    Public Property NovAmount As String = ""
    Public Property DecAmount As String = ""
    Public Property MonthsToBill As String = ""
    Public Property TaxRate As String = ""
    Public Property BusinessPhone As String = "'"
    Public Property LastMonthBilled As String = ""
    Public Property PrintBill As String = ""
    Public Property CheckNumber As String = ""
    Public Property HomePhone As String = ""
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

    Public Shared Function ConvertFileProCustomers() As List(Of CCustomerFilePro)

        Dim CustomerListing As New List(Of CCustomerFilePro)

        Dim headerFile(6444) As Char
        Dim customerRecordArray(536) As Char
        Dim charTrim() As Char = {" "c, ControlChars.NullChar}

        ' ----- Open the KEY file 
        Dim fileProFile As New StreamReader(My.Application.Info.DirectoryPath & "\KEY")

        ' ----- Read the header file 
        'fileProFile.ReadBlock(headerFile, 0, 6444)
        fileProFile.ReadBlock(headerFile, 0, 548)

        Do
            ' ----- Read the customer line 
            fileProFile.ReadBlock(customerRecordArray, 0, 536)

            ' ----- Assign it to a string 
            Dim fileString As String = New String(customerRecordArray)

            ' ----- Create a new customer object 
            Dim tempObj As New CCustomerFilePro

            ' ----- Parse the information 
            Integer.TryParse(fileString.Substring(0, 13).Trim(charTrim), tempObj.AccountNumber)

            tempObj.AccountType = fileString.Substring(13, 1)

            ' ----- Route information 
            tempObj.RouteFirstName = fileString.Substring(14, 10).Trim
            tempObj.RouteLastName = fileString.Substring(24, 18).Trim
            tempObj.RouteAddress = fileString.Substring(42, 24).Trim
            tempObj.RouteCity = fileString.Substring(66, 15).Trim
            tempObj.RouteState = fileString.Substring(81, 2).Trim
            tempObj.RouteZipcode = fileString.Substring(83, 10).Trim

            ' ----- Billing information 
            tempObj.BillingFirstName = fileString.Substring(93, 10).Trim
            tempObj.BillingLastName = fileString.Substring(103, 18).Trim
            tempObj.BillingAddress = fileString.Substring(121, 24).Trim
            tempObj.BillingCity = fileString.Substring(145, 15).Trim
            tempObj.BillingState = fileString.Substring(160, 2).Trim
            tempObj.BillingZipcode = fileString.Substring(162, 10).Trim

            ' ----- some dates
            tempObj.LastBillingDate = fileString.Substring(172, 8)
            tempObj.LastPaymentDate = fileString.Substring(180, 8)

            ' ----- Descriptions / Balances 
            tempObj.AdditionalChargeDesc1 = fileString.Substring(188, 60)
            tempObj.Balance = fileString.Substring(248, 8)
            tempObj.LastPaymentAmount = fileString.Substring(256, 7)

            ' ----- Monthly amounts
            tempObj.JanAmount = fileString.Substring(263, 7)
            tempObj.FebAmount = fileString.Substring(270, 7)
            tempObj.MarAmount = fileString.Substring(277, 7)
            tempObj.AprAmount = fileString.Substring(284, 7)
            tempObj.MayAmount = fileString.Substring(291, 7)
            tempObj.JunAmount = fileString.Substring(298, 7)
            tempObj.JulAmount = fileString.Substring(305, 7)
            tempObj.AugAmount = fileString.Substring(312, 7)
            tempObj.SepAmount = fileString.Substring(319, 7)
            tempObj.OctAmount = fileString.Substring(326, 7)
            tempObj.NovAmount = fileString.Substring(333, 7)
            tempObj.DecAmount = fileString.Substring(340, 7)

            tempObj.MonthsToBill = fileString.Substring(347, 1)
            tempObj.TaxRate = fileString.Substring(348, 6)

            ' ----- Phone numbers 
            tempObj.BusinessPhone = fileString.Substring(354, 14)
            tempObj.LastMonthBilled = fileString.Substring(368, 2)
            tempObj.PrintBill = fileString.Substring(370, 1)
            tempObj.CheckNumber = fileString.Substring(371, 10)
            tempObj.HomePhone = fileString.Substring(381, 14)
            tempObj.AdvancedBilling = fileString.Substring(395, 1)
            tempObj.AdditionalChargeDesc2 = fileString.Substring(396, 38)

            ' ----- Save out the sequence number 
            Integer.TryParse(fileString.Substring(434, 5).Trim(charTrim), tempObj.SequenceNumber)

            ' ----- Add it to the collection 
            If tempObj.RouteLastName <> "" Or tempObj.RouteFirstName <> "" Then
                CustomerListing.Add(tempObj)
            End If

        Loop Until fileProFile.EndOfStream = True

        ' ----- Close the file 
        fileProFile.Close()

        ' ----- Show the grid 
        Return CustomerListing

    End Function

    Public Shared Sub ConvertFileProRental()

        Dim headerFile(6444) As Char
        Dim customerRecordArray(536) As Char
        Dim charTrim() As Char = {" "c, ControlChars.NullChar}

        ' ----- Open the KEY file 
        Dim fileProFile As New StreamReader(My.Application.Info.DirectoryPath & "\Rental_KEY")

        ' ----- Read the header file
        fileProFile.ReadBlock(headerFile, 0, 406)

        Do
            ' ----- Read the customer line 
            fileProFile.ReadBlock(customerRecordArray, 0, 404)

            ' ----- Assign it to a string 
            Dim fileString As String = New String(customerRecordArray)

            ' ----- Create a new customer object 
            Dim tempObj As New PickupTransaction.RentalCustomer

            ' ----- the first twelve bytes are control characters
            fileString = fileString.Substring(12)

            ' ----- Parse the information 
            Integer.TryParse(fileString.Substring(0, 11).Trim(charTrim), tempObj.CustomerNumber)

            ' ----- See if an object already exists 
            Dim existingCustomer As PickupTransaction.RentalCustomer = PickupTransaction.RentalCustomer.GetRentalCustomer(My.Settings.DatabaseLocation, tempObj.CustomerNumber)

            If existingCustomer Is Nothing Then

                ' ----- Route information 
                tempObj.RouteLocation_FirstName = fileString.Substring(11, 13).Trim
                tempObj.RouteLocation_LastName = fileString.Substring(24, 21).Trim
                tempObj.RouteLocation_Address = fileString.Substring(45, 24).Trim
                tempObj.RouteLocation_City = fileString.Substring(69, 15).Trim
                tempObj.RouteLocation_State = fileString.Substring(84, 2).Trim
                tempObj.RouteLocation_ZipCode = fileString.Substring(86, 10).Trim

                ' ----- Billing information 
                tempObj.Billing_FirstName = fileString.Substring(96, 13).Trim
                tempObj.Billing_LastName = fileString.Substring(109, 21).Trim
                tempObj.Billing_Address = fileString.Substring(130, 24).Trim
                tempObj.Billing_City = fileString.Substring(154, 15).Trim
                tempObj.Billing_State = fileString.Substring(169, 2).Trim
                tempObj.Billing_ZipCode = fileString.Substring(171, 10).Trim

                ' ----- Phone numbers 
                tempObj.BusinessPhone = fileString.Substring(181, 14)
                tempObj.HomePhone = fileString.Substring(195, 14)
                tempObj.Fax = ""
                tempObj.EMailAddress = ""
                tempObj.SendBillViaEmail = False

                ' ----- Charges 
                tempObj.DumpsterCharge = ReturnDouble(fileString.Substring(209, 6))
                tempObj.RollOffCharge = ReturnDouble(fileString.Substring(215, 6))
                tempObj.Cart90GallonCharge = ReturnDouble(fileString.Substring(221, 6))
                tempObj.CardboardCharge = ReturnDouble(fileString.Substring(227, 6))
                tempObj.RecycleCharge = ReturnDouble(fileString.Substring(233, 6))
                tempObj.TaxRate = ReturnDouble(fileString.Substring(239, 5))

                ' ----- Some additional information 
                tempObj.DumpsterPUType = 0
                tempObj.CardboardPUType = 0
                tempObj.RecyclePUType = 0

                ' ----- Billing dates?
                tempObj.Balance = ReturnDouble(fileString.Substring(244, 7))
                tempObj.CurrentBalance = tempObj.Balance
                'tempObj.LastBillingDate = fileString.Substring(251, 8)

                ' ----- Rental amount 
                tempObj.DumpsterRental = ReturnDouble(fileString.Substring(259, 6))
                tempObj.RollOffRental = ReturnDouble(fileString.Substring(265, 5))
                tempObj.Cart90GallonRental = ReturnDouble(fileString.Substring(270, 5))
                tempObj.CardboardRental = ReturnDouble(fileString.Substring(275, 5))

                ' ----- No idea what this is 
                tempObj.AdditionalChargeDesc1 = fileString.Substring(280, 66)

                ' ----- Payment Dates
                tempObj.LastPaymentDate = ReturnDate(fileString.Substring(346, 8))
                tempObj.LastPaymentAmount = ReturnDouble(fileString.Substring(354, 7))
                'tempObj.CheckNumber = fileString.Substring(361, 10)

                ' ----- Set these as zeroes so that the program does not complain
                tempObj.PickupDay = 0
                tempObj.Route = 0

                Try
                    PickupTransaction.RentalCustomer.SaveRentalCustomer(My.Settings.DatabaseLocation, tempObj)
                Catch ex As Exception
                End Try

            Else

                ' ----- Route information 
                existingCustomer.RouteLocation_FirstName = fileString.Substring(11, 13).Trim
                existingCustomer.RouteLocation_LastName = fileString.Substring(24, 21).Trim
                existingCustomer.RouteLocation_Address = fileString.Substring(45, 24).Trim
                existingCustomer.RouteLocation_City = fileString.Substring(69, 15).Trim
                existingCustomer.RouteLocation_State = fileString.Substring(84, 2).Trim
                existingCustomer.RouteLocation_ZipCode = fileString.Substring(86, 10).Trim

                ' ----- Billing information 
                existingCustomer.Billing_FirstName = fileString.Substring(96, 13).Trim
                existingCustomer.Billing_LastName = fileString.Substring(109, 21).Trim
                existingCustomer.Billing_Address = fileString.Substring(130, 24).Trim
                existingCustomer.Billing_City = fileString.Substring(154, 15).Trim
                existingCustomer.Billing_State = fileString.Substring(169, 2).Trim
                existingCustomer.Billing_ZipCode = fileString.Substring(171, 10).Trim

                ' ----- Phone numbers 
                existingCustomer.BusinessPhone = fileString.Substring(181, 14)
                existingCustomer.HomePhone = fileString.Substring(195, 14)

                ' ----- Charges 
                existingCustomer.DumpsterCharge = ReturnDouble(fileString.Substring(209, 6))
                existingCustomer.RollOffCharge = ReturnDouble(fileString.Substring(215, 6))
                existingCustomer.Cart90GallonCharge = ReturnDouble(fileString.Substring(221, 6))
                existingCustomer.CardboardCharge = ReturnDouble(fileString.Substring(227, 6))
                existingCustomer.RecycleCharge = ReturnDouble(fileString.Substring(233, 6))
                existingCustomer.TaxRate = ReturnDouble(fileString.Substring(239, 5))

                ' ----- Billing dates?
                existingCustomer.Balance = ReturnDouble(fileString.Substring(244, 7))
                existingCustomer.CurrentBalance = existingCustomer.Balance
                'tempObj.LastBillingDate = fileString.Substring(251, 8)

                ' ----- Rental amount 
                existingCustomer.DumpsterRental = ReturnDouble(fileString.Substring(259, 6))
                existingCustomer.RollOffRental = ReturnDouble(fileString.Substring(265, 5))
                existingCustomer.Cart90GallonRental = ReturnDouble(fileString.Substring(270, 5))
                existingCustomer.CardboardRental = ReturnDouble(fileString.Substring(275, 5))

                ' ----- No idea what this is 
                existingCustomer.AdditionalChargeDesc1 = fileString.Substring(280, 66)

                ' ----- Payment Dates
                existingCustomer.LastPaymentDate = ReturnDate(fileString.Substring(346, 8))
                existingCustomer.LastPaymentAmount = ReturnDouble(fileString.Substring(354, 7))
                'tempObj.CheckNumber = fileString.Substring(361, 10)

                Try
                    existingCustomer.Update(My.Settings.DatabaseLocation)
                Catch ex As Exception
                End Try

            End If

        Loop Until fileProFile.EndOfStream = True

        ' ----- Close the file 
        fileProFile.Close()

    End Sub

    Private Shared Function ReturnDouble(tmpString As String) As Double

        Dim retDouble As Double = 0.0
        If Double.TryParse(tmpString, retDouble) Then
            Return retDouble
        Else
            Return 0.0
        End If

    End Function

    Private Shared Function ReturnDate(tmpString As String) As Date

        Dim retDate As Date = Nothing
        If Date.TryParse(tmpString, retDate) Then
            Return retDate
        Else
            Return New Date(2000, 1, 1)
        End If

    End Function

End Class

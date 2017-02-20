Public Class ConversionForm

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonReadFileProFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReadFileProFile.Click
        DataGridViewConvert.DataSource = (From c In CCustomerFilePro.ConvertFileProCustomers Order By c.SequenceNumber Select c).ToList
    End Sub

    Private Sub ButtonConvertData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonConvertData.Click

        ' ----- Blank out the label 
        LabelConversion.Text = ""

        Dim conversionNumber As Integer = 0

        ' ----- Create the list 
        Dim convCustomer As List(Of CCustomerFilePro) = CCustomerFilePro.ConvertFileProCustomers

        ' ----- Loop through the list 
        For Each convObj As CCustomerFilePro In convCustomer

            ' ----- Create a temp object 
            Dim dbCustomer As New PickupTransaction.Customer

            ' ----- Fill in the information 
            dbCustomer.Billing_Address = convObj.BillingAddress
            dbCustomer.Billing_City = convObj.BillingCity
            dbCustomer.Billing_FirstName = convObj.BillingFirstName
            dbCustomer.Billing_LastName = convObj.BillingLastName
            dbCustomer.Billing_State = convObj.BillingState
            dbCustomer.Billing_ZipCode = convObj.BillingZipcode

            ' ----- Wrap this in case the dictionary bombs out 
            Try
                dbCustomer.BillingType = ProgramDataObject.BillingTypeDictionary(convObj.AccountType)
            Catch ex As Exception
            End Try

            dbCustomer.BusinessPhone = convObj.BusinessPhone
            dbCustomer.CustomerNumber = convObj.AccountNumber
            dbCustomer.HomePhone = convObj.HomePhone
            dbCustomer.PickupDay = GetPickupDay(convObj.SequenceNumber)
            dbCustomer.RouteLocation_Address = convObj.RouteAddress
            dbCustomer.RouteLocation_City = convObj.RouteCity
            dbCustomer.RouteLocation_FirstName = convObj.RouteFirstName
            dbCustomer.RouteLocation_LastName = convObj.RouteLastName
            dbCustomer.RouteLocation_State = convObj.RouteState
            dbCustomer.RouteLocation_ZipCode = convObj.RouteZipcode
            dbCustomer.SequenceNumber = convObj.SequenceNumber
            dbCustomer.SpecialInstructions = ""
            dbCustomer.TaxRate = convObj.TaxRate

            ' ----- Added these two for the billing module on 12/12/11
            If dbCustomer.SequenceNumber >= 10008 And dbCustomer.SequenceNumber <= 13912 Then
                dbCustomer.Route = 1
            ElseIf dbCustomer.SequenceNumber >= 13916 And dbCustomer.SequenceNumber <= 15188 Then
                dbCustomer.Route = 2
            ElseIf dbCustomer.SequenceNumber >= 15208 And dbCustomer.SequenceNumber <= 16976 Then
                dbCustomer.Route = 3
            ElseIf dbCustomer.SequenceNumber >= 20020 And dbCustomer.SequenceNumber <= 24012 Then
                dbCustomer.Route = 1
            ElseIf dbCustomer.SequenceNumber >= 24020 And dbCustomer.SequenceNumber <= 24237 Then
                dbCustomer.Route = 2
            ElseIf dbCustomer.SequenceNumber >= 24506 And dbCustomer.SequenceNumber <= 24924 Then
                dbCustomer.Route = 2
            ElseIf dbCustomer.SequenceNumber >= 24238 And dbCustomer.SequenceNumber <= 24500 Then
                dbCustomer.Route = 3
            ElseIf dbCustomer.SequenceNumber >= 24928 And dbCustomer.SequenceNumber <= 28400 Then
                dbCustomer.Route = 3
            ElseIf dbCustomer.SequenceNumber >= 29000 And dbCustomer.SequenceNumber <= 29120 Then
                dbCustomer.Route = 4
            ElseIf dbCustomer.SequenceNumber >= 30000 And dbCustomer.SequenceNumber <= 33400 Then
                dbCustomer.Route = 1
            ElseIf dbCustomer.SequenceNumber >= 33410 And dbCustomer.SequenceNumber <= 34878 Then
                dbCustomer.Route = 2
            ElseIf dbCustomer.SequenceNumber >= 36020 And dbCustomer.SequenceNumber <= 39560 Then
                dbCustomer.Route = 3
            ElseIf dbCustomer.SequenceNumber >= 39568 And dbCustomer.SequenceNumber <= 39574 Then
                dbCustomer.Route = 4
            ElseIf dbCustomer.SequenceNumber >= 40000 And dbCustomer.SequenceNumber <= 43304 Then
                dbCustomer.Route = 1
            ElseIf dbCustomer.SequenceNumber >= 43384 And dbCustomer.SequenceNumber <= 44386 Then
                dbCustomer.Route = 2
            ElseIf dbCustomer.SequenceNumber >= 44388 And dbCustomer.SequenceNumber <= 48112 Then
                dbCustomer.Route = 3
            ElseIf dbCustomer.SequenceNumber >= 50000 And dbCustomer.SequenceNumber <= 52918 Then
                dbCustomer.Route = 1
            ElseIf dbCustomer.SequenceNumber >= 52922 And dbCustomer.SequenceNumber <= 53745 Then
                dbCustomer.Route = 2
            ElseIf dbCustomer.SequenceNumber >= 54594 And dbCustomer.SequenceNumber <= 57052 Then
                dbCustomer.Route = 3
            ElseIf dbCustomer.SequenceNumber >= 54504 And dbCustomer.SequenceNumber <= 54584 Then
                dbCustomer.Route = 4
            Else
                dbCustomer.Route = 0
            End If

            ' ----- Billing information 
            Integer.TryParse(convObj.LastMonthBilled.ToString, dbCustomer.LastMonthBilled)
            Integer.TryParse(convObj.MonthsToBill.ToString, dbCustomer.MonthsToBill)

            dbCustomer.LastPaymentAmount = 0.0
            Double.TryParse(convObj.LastPaymentAmount.ToString, dbCustomer.LastPaymentAmount)

            ' ----- Get the last payment date 
            dbCustomer.LastPaymentDate = Date.Today
            If IsDate(convObj.LastPaymentDate) Then
                Date.TryParse(convObj.LastPaymentDate.ToString, dbCustomer.LastPaymentDate)
            End If

            dbCustomer.Balance = 0.0
            Double.TryParse(convObj.Balance.ToString, dbCustomer.Balance)

            ' ----- Write out some of the additional descriptions 
            dbCustomer.AdditionalChargeDesc1 = convObj.AdditionalChargeDesc1.ToString
            dbCustomer.AdditionalChargeDesc2 = convObj.AdditionalChargeDesc2.ToString

            ' ----- Increase the conversion number and report it 
            conversionNumber += 1
            LabelConversion.Text = String.Format("Record {0} converted ({1},{2})", conversionNumber, dbCustomer.RouteLocation_LastName, dbCustomer.RouteLocation_FirstName)
            LabelConversion.Refresh()

            ' ------ Save the information to the database 
            dbCustomer.Save(My.Settings.DatabaseLocation)

        Next

    End Sub

    Private Function GetPickupDay(ByVal seqNum As String) As Integer

        If seqNum.Length > 1 Then

            Dim firstChar As String = seqNum.Substring(0, 1)

            Select Case firstChar
                Case "1"
                    Return 1
                Case "2"
                    Return 2
                Case "3"
                    Return 3
                Case "4"
                    Return 4
                Case "5"
                    Return 5
                Case Else
                    Return 0
            End Select

        Else

            Return 1

        End If

    End Function

End Class
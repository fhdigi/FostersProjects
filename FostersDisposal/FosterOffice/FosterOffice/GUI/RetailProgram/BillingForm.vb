Public Class BillingForm

    Private Sub BillingForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' ----- Set the billing date to yesterday 
        DateTimePickerBillingDate.Value = DateTime.Today

    End Sub

    Private Sub RefreshData(ByVal reportPeriod As Integer)

        Dim daysOfPickup(3) As Integer
        Dim dataPeriod As Integer = IIf(reportPeriod = 0, 1, reportPeriod)

        ' ----- This may take a while 
        Cursor = Cursors.WaitCursor

        ' ----- This gets the day of the week 
        Dim pickupDay As Integer = DateTimePickerBillingDate.Value.DayOfWeek

        ' ----- What year are we in
        Dim BillingYear As Integer = DateTimePickerBillingDate.Value.Year

        ' ----- find the last month that would have been billed 
        Dim LastBillingMonth As Integer = DateTimePickerBillingDate.Value.Month - dataPeriod

        ' ----- If the last month was last year, then adjust accordingly 
        If LastBillingMonth <= 0 Then
            LastBillingMonth += 12
            BillingYear -= 1
        End If

        Dim pickupStartDate As Date = Nothing
        Dim pickupEndDate As Date = Nothing

        ' ----- We need to find how many pickup days the customer had in each billing month
        Dim indexforMonth As Integer = 0
        For iMonthCounter As Integer = LastBillingMonth + 1 To LastBillingMonth + dataPeriod

            indexforMonth += 1

            If iMonthCounter > 12 Then
                daysOfPickup(indexforMonth) = DaysInMonthYear(pickupDay, iMonthCounter - 12, BillingYear + 1)
            Else
                daysOfPickup(indexforMonth) = DaysInMonthYear(pickupDay, iMonthCounter, BillingYear)
            End If

            ' ----- If this is the first month, set the date 
            If iMonthCounter = LastBillingMonth + 1 Then
                If iMonthCounter > 12 Then
                    pickupStartDate = New Date(BillingYear + 1, iMonthCounter - 12, 1)
                Else
                    pickupStartDate = New Date(BillingYear, iMonthCounter, 1)
                End If
            End If

            ' ----- If this is the last month, set the date 
            If iMonthCounter = LastBillingMonth + dataPeriod Then
                If iMonthCounter > 12 Then
                    pickupEndDate = New Date(BillingYear + 1, iMonthCounter - 12, Date.DaysInMonth(BillingYear + 1, iMonthCounter - 12))
                Else
                    pickupEndDate = New Date(BillingYear, iMonthCounter, Date.DaysInMonth(BillingYear, iMonthCounter))
                End If
            End If

        Next

        ' ----- This is a list of everything collected in this time period
        Dim itemListOfCollected As List(Of PickupTransaction.CollectionRecord) = PickupTransaction.CollectionRecord.GetCollectedItemsWithinRangeByDate(My.Settings.DatabaseLocation, pickupStartDate, pickupEndDate)

        ' ----- This gets the list of people that would be billed for the given period
        Dim tempCustomerList As List(Of PickupTransaction.CBillingData) = PickupTransaction.Customer.ReturnCustomersToBill(My.Settings.DatabaseLocation, LastBillingMonth, pickupDay, reportPeriod)

        Dim totalNumberOfCustomers As Integer = tempCustomerList.Count
        Dim customerCounter As Integer = 0

        ' ----- Add in the customer's rate 
        For Each obj As PickupTransaction.CBillingData In tempCustomerList

            ' ----- Show the status label 
            customerCounter += 1
            LabelStatus.Text = String.Format("Customer {0} of {1}", customerCounter, totalNumberOfCustomers)
            LabelStatus.Refresh()

            ' ----- Create a temporary variable 
            Dim useOnceObj As PickupTransaction.CBillingData = obj

            ' ----- Assuming we have a valid billing type 
            If Not useOnceObj.BillingType Is Nothing Then

                ' ----- Get the monthly charge 
                useOnceObj.MonthlyCharge = (From c In ProgramDataObject.BillingTypeObjectList Where c.Designation = useOnceObj.BillingType Select c.Amount).SingleOrDefault
                useOnceObj.TotalCharge = useOnceObj.MonthlyCharge * dataPeriod

                ' ----- Calculate the total number of bags that are allowed to be picked up this period
                For iBagCounter As Integer = 1 To dataPeriod
                    Dim bagsAllowed As Integer = (From c In ProgramDataObject.BillingTypeObjectList Where c.Designation = useOnceObj.BillingType Select c.WeeklyBagAllowance).SingleOrDefault
                    useOnceObj.BagsAllowedThisPeriod += bagsAllowed * daysOfPickup(iBagCounter)
                Next

                ' ----- Determine the number of bags that have been picked up during this period 
                'useOnceObj.BagsPickedUpThisPeriod = PickupTransaction.CollectionRecord.GetNumberCollectedBagsWithinRangeByCustomer(My.Settings.DatabaseLocation, useOnceObj.AccountNumber, pickupStartDate, pickupEndDate)
                useOnceObj.BagsPickedUpThisPeriod = (From i In itemListOfCollected Where i.CustomerID = useOnceObj.AccountNumber And i.ItemID = 1 Select i.Quantity).Sum

                Dim extraBagQty As Integer = useOnceObj.BagsPickedUpThisPeriod - (useOnceObj.BagsAllowedThisPeriod / 2)

                useOnceObj.ExtraBagsQty = If(extraBagQty > 0, extraBagQty, 0)

                'Dim tempList As List(Of PickupTransaction.CAdditionalItems) = PickupTransaction.CollectionRecord.GetNumberCollectedItemsWithinRange(My.Settings.DatabaseLocation, useOnceObj.AccountNumber, pickupStartDate, pickupEndDate)
                Dim tempList As List(Of PickupTransaction.CAdditionalItems) = (From i In itemListOfCollected
                                                                               Where i.CustomerID = useOnceObj.AccountNumber And i.ItemID <> 1
                                                                               Select New PickupTransaction.CAdditionalItems With
                                                                                      {
                                                                                          .AdditionalItems = i.ItemDescription,
                                                                                          .AdditionalItemCost = i.ItemPrice
                                                                                      }).ToList

                For Each strTemp As PickupTransaction.CAdditionalItems In tempList
                    useOnceObj.AdditionalItems &= strTemp.AdditionalItems & " "
                    useOnceObj.AdditionalItemCost += strTemp.AdditionalItemCost
                Next

            End If

        Next

        ' ----- Show the customer listing 
        DataGridViewBilling.DataSource = (From s In tempCustomerList Where s.ExtraBagsQty > 0 Order By s.SequenceNumber Select s).ToList

        ' ----- Reset the cursor 
        Cursor = Cursors.Default

    End Sub

    Private Function DaysInMonthYear(ByVal dayoftheWeek As Integer, ByVal month As Integer, ByVal year As Integer)

        Dim numberOfDaysInMonth As Integer = 0

        For iDayCounter As Integer = 1 To Date.DaysInMonth(year, month)

            Dim tempDate As New Date(year, month, iDayCounter)

            If tempDate.DayOfWeek = dayoftheWeek Then
                numberOfDaysInMonth += 1
            End If
        Next

        Return numberOfDaysInMonth

    End Function

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRefresh.Click
        RefreshData(ComboBoxBillingPeriod.SelectedIndex)
    End Sub

End Class
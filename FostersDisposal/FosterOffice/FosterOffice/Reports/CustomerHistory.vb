Public Class CustomerHistory

    Public Property CustomerNumber As Integer = 0
    Public Property YearToReview As Integer = 0

    Public Sub UpdateGrid()

        ' ----- The year when the program was run 
        Dim yearNow As Integer = YearToReview

        ' ----- From the start of this year 
        Dim intAddDaysToSunday As Integer = 7 - DateSerial(yearNow, 1, 1).DayOfWeek

        ' ----- Find the first Sunday 
        Dim ts As New TimeSpan(intAddDaysToSunday, 0, 0, 0)
        Dim startDate As Date = DateSerial(2011, 1, 1) + ts
        Dim weekCounter As Integer = 0
        Dim currentMonth As Integer = 0

        Do While startDate.Year = yearNow

            ' ----- Reset if we are at a new month 
            If currentMonth <> startDate.Month Then
                weekCounter = 0
                currentMonth = startDate.Month
            End If

            ' ----- Increment by 1 
            weekCounter += 1

            ' ----- This should be the following Saturday 
            Dim endDate As Date = startDate + New TimeSpan(6, 0, 0, 0)

            ' ----- Get the number of bags picked up during this period 
            Dim numberOfBags As Integer = PickupTransaction.CollectionRecord.GetNumberCollectedBagsWithinRangeByCustomer(My.Settings.DatabaseLocation, _CustomerNumber, startDate, endDate)

            ' ----- Add it to the correct place in the grid 
            Dim controlName As String = String.Format("tc{0:D2}{1:D2}", startDate.Month, weekCounter)
            Dim rowName As String = String.Format("XrTableRow{0:D2}", startDate.Month)

            If startDate.Month <= 6 Then
                Detail.Controls("XrTableJanJun").Controls(rowName).Controls(controlName).Text = numberOfBags.ToString
            Else
                Detail.Controls("XrTableJulDec").Controls(rowName).Controls(controlName).Text = numberOfBags.ToString
            End If

            ' ----- Tack on another 7 days and repeat 
            startDate += New TimeSpan(7, 0, 0, 0)

            If weekCounter = 1 Then

                ' ----- Set the period for the payments 
                Dim beginDateMonth As Date = DateSerial(startDate.Year, startDate.Month, 1)
                Dim endDateMonth As Date = DateSerial(startDate.Year, startDate.Month, Date.DaysInMonth(startDate.Year, startDate.Month))

                ' ----- Write out the payments 
                Dim payments As Integer = PickupTransaction.Payments.ReturnSumPaymentsWithinRange(My.Settings.DatabaseLocation, _CustomerNumber, beginDateMonth, endDateMonth)

                Dim payCell As String = String.Format("tc{0:D2}Pay", startDate.Month)

                If startDate.Month <= 6 Then
                    Detail.Controls("XrTableJanJun").Controls(rowName).Controls(payCell).Text = String.Format("{0:f2}", payments)
                Else
                    Detail.Controls("XrTableJulDec").Controls(rowName).Controls(payCell).Text = String.Format("{0:f2}", payments)
                End If

                ' ----- Write out the misc stuff
                Dim itemList As List(Of PickupTransaction.CAdditionalItems) = PickupTransaction.CollectionRecord.GetNumberCollectedItemsWithinRange(My.Settings.DatabaseLocation, _CustomerNumber, beginDateMonth, endDateMonth)

                Dim itemFlatList As String = ""
                For Each tempStr As PickupTransaction.CAdditionalItems In itemList
                    itemFlatList &= If(itemFlatList = "", "", ", ") & tempStr.AdditionalItems & " (" & tempStr.AdditionalItemCost.ToString("c2") & ")"
                Next

                Dim miscCell As String = String.Format("tc{0:D2}Misc", startDate.Month)

                If startDate.Month <= 6 Then
                    Detail.Controls("XrTableJanJun").Controls(rowName).Controls(miscCell).Text = itemFlatList
                Else
                    Detail.Controls("XrTableJulDec").Controls(rowName).Controls(miscCell).Text = itemFlatList
                End If

            End If

        Loop

    End Sub

End Class
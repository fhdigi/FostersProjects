Public Class BillingForm

    Public Property DatabaseLocation As String = ""

    Private Sub BillingForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' ----- Set the billing date to yesterday 
        DateTimePickerBillingDate.Value = DateTime.Today - New TimeSpan(1, 0, 0, 0)

    End Sub

    Private Sub RefreshData(ByVal reportPeriod As Integer)

        ' ----- This gets the day of the week 
        Dim pickupDay As Integer = DateTimePickerBillingDate.Value.DayOfWeek

        ' ----- find the last month to be looked at 
        Dim lastMonth As Integer = DateTimePickerBillingDate.Value.Month - 2
        If lastMonth < 0 Then lastMonth += 12

        ' ----- Sets the grid 
        Dim tempCustomerList As List(Of PickupTransaction.CBillingData) = PickupTransaction.Customer.ReturnCustomersToBill(DatabaseLocation, lastMonth, pickupDay, reportPeriod)

        For Each obj As PickupTransaction.CBillingData In tempCustomerList

        Next

        DataGridViewBilling.DataSource = tempCustomerList

    End Sub

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRefresh.Click
        RefreshData(2)
    End Sub

End Class
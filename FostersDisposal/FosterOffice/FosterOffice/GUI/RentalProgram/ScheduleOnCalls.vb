Public Class ScheduleOnCalls

    Private Sub ScheduleOnCalls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillList()
    End Sub

    Private Sub FillList()

        'For Each obj As PickupTransaction.RentalCustomer.RentalRouteInformation In PickupTransaction.RentalCustomer.GetCustomerOnCall(My.Settings.DatabaseLocation)
        '    With ListViewOnCalls
        '        Dim itmX As ListViewItem = .Items.Add(obj.CustomerNumber.ToString)
        '        itmX.SubItems.Add(obj.CustomerName)
        '        itmX.SubItems.Add(obj.CustomerAddress)
        '        itmX.SubItems.Add(obj.Container)
        '    End With
        'Next

    End Sub

End Class
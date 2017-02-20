Public Class ReportDisplayRental

    Public Property ShowDelinquentsOnly As Boolean = False

    Private Sub ReportDisplay_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RadioButtonAllAccounts.Checked = Not ShowDelinquentsOnly
        RadioButtonDelinquentAccounts.Checked = ShowDelinquentsOnly
        RunReports()
    End Sub

    Private Sub RunReports()

        Dim rpt As New AgingReportRental

        If RadioButtonAllAccounts.Checked Then

            rpt.BindingSource1.DataSource = (From c In PickupTransaction.RentalCustomer.ReturnCustomer(My.Settings.DatabaseLocation)
                                             Where If(RadioButtonCurrentAccounts.Checked, c.Inactive = False, If(RadioButtonClosedAccounts.Checked, c.Inactive = True, True))
                                             Order By c.Billing_FirstName, c.Billing_LastName
                                             Select c).ToList

        Else

            rpt.BindingSource1.DataSource = (From c In PickupTransaction.RentalCustomer.ReturnCustomer(My.Settings.DatabaseLocation)
                                             Where (c.AgingBalance3Month > 0.0 Or c.AgingBalance4Month > 0.0 Or c.AgingBalance5Month > 0) And If(RadioButtonCurrentAccounts.Checked, c.Inactive = False, If(RadioButtonClosedAccounts.Checked, c.Inactive = True, True))
                                             Order By c.Billing_FirstName, c.Billing_LastName
                                             Select c).ToList

        End If

        ' ----- display the report 
        PrintControlReportEngine.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()

    End Sub

    Private Sub ButtonRefreshReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRefreshReport.Click
        RunReports()
    End Sub

End Class
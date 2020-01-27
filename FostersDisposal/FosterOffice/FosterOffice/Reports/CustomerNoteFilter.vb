Imports DevExpress.XtraReports.UI

Public Class CustomerNoteFilter

    Public Property ReportToShow As Integer = 0
    Private Property CurrentBillingMonth As Date = Date.Today

    Private Sub CustomerNoteFilter_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Select Case ReportToShow
            Case 0
                Me.Text = "Customer Note Filter"
            Case 1
                Me.Text = "Aging Report Filter"
            Case 2
                Me.Text = "Customer Billing Filter"
            Case 3
                Me.Text = "Aging Report Filter"
            Case 4
                Me.Text = "Go In After Filter"
        End Select

        RB_AllDays.Checked = True
        RB_AllRoutes.Checked = True

        ' ----- Default to current billing 
        CheckBoxCurrentBilling.Checked = True

        ' ----- If we are less than the 10th day in the month, then we are probably billing for last month 
        If CurrentBillingMonth.Day <= 10 Then

            ' ----- Send it back to last month 
            CurrentBillingMonth -= New TimeSpan(10, 0, 0, 0)

        End If

        ' ----- Now set the month 
        TextBoxBillingMonth.Text = String.Format("{0:MMMM}", CurrentBillingMonth)
        TextBoxBillingMonth.Enabled = False

    End Sub

    Private Sub ButtonRunReport_Click(sender As System.Object, e As System.EventArgs) Handles ButtonRunReport.Click

        ' ----- Determine the day to show 
        Dim rptDay As Integer = 0
        If RB_Monday.Checked Then rptDay = 1
        If RB_Tuesday.Checked Then rptDay = 2
        If RB_Wednesday.Checked Then rptDay = 3
        If RB_Thursday.Checked Then rptDay = 4
        If RB_Friday.Checked Then rptDay = 5

        Dim rptRoute As Integer = 0
        If RB_Route1.Checked Then rptRoute = 1
        If RB_Route2.Checked Then rptRoute = 2
        If RB_Route3.Checked Then rptRoute = 3
        If RB_Route4.Checked Then rptRoute = 4

        Select Case ReportToShow

            Case 0

                Dim rpt As New CustomerNotes

                ' ----- Just look at the current billing cycle.
                If CheckBoxCurrentBilling.Checked Then

                    ' ----- Get the current month 
                    Dim lmbMonth3 As Integer = CurrentBillingMonth.Month - 3
                    If lmbMonth3 <= 0 Then lmbMonth3 += 12

                    Dim lmbMonth As Integer = CurrentBillingMonth.Month - 2
                    If lmbMonth <= 0 Then lmbMonth += 12

                    Dim lmbMonth1Mon As Integer = CurrentBillingMonth.Month - 1
                    If lmbMonth1Mon <= 0 Then lmbMonth1Mon += 12

                    If rptDay = 0 Then

                        Select Case rptRoute
                            Case 0
                                rpt.DataSource = PickupTransaction.Customer.ReturnCustomersWithCommentsThisBilling(My.Settings.DatabaseLocation, lmbMonth, lmbMonth1Mon, lmbMonth3)
                            Case Else
                                rpt.DataSource = From c In PickupTransaction.Customer.ReturnCustomersWithCommentsThisBilling(My.Settings.DatabaseLocation, lmbMonth, lmbMonth1Mon, lmbMonth3)
                                                 Where c.Route = rptRoute
                        End Select

                    Else

                        Select Case rptRoute
                            Case 0
                                rpt.DataSource = From c In PickupTransaction.Customer.ReturnCustomersWithCommentsThisBilling(My.Settings.DatabaseLocation, lmbMonth, lmbMonth1Mon, lmbMonth3)
                                                   Where c.PickupDay = rptDay
                            Case Else
                                rpt.DataSource = From c In PickupTransaction.Customer.ReturnCustomersWithCommentsThisBilling(My.Settings.DatabaseLocation, lmbMonth, lmbMonth1Mon, lmbMonth3)
                                                   Where c.PickupDay = rptDay And c.Route = rptRoute
                        End Select

                    End If

                Else

                    If rptDay = 0 Then

                        Select Case rptRoute
                            Case 0
                                rpt.DataSource = PickupTransaction.Customer.ReturnCustomersWithComments(My.Settings.DatabaseLocation)
                            Case Else
                                rpt.DataSource = From c In PickupTransaction.Customer.ReturnCustomersWithComments(My.Settings.DatabaseLocation)
                                                 Where c.Route = rptRoute
                        End Select

                    Else

                        Select Case rptRoute
                            Case 0
                                rpt.DataSource = From c In PickupTransaction.Customer.ReturnCustomersWithComments(My.Settings.DatabaseLocation)
                                                   Where c.PickupDay = rptDay
                            Case Else
                                rpt.DataSource = From c In PickupTransaction.Customer.ReturnCustomersWithComments(My.Settings.DatabaseLocation)
                                                   Where c.PickupDay = rptDay And c.Route = rptRoute
                        End Select

                    End If
                End If


                rpt.ShowPreview()


            Case 1

                Dim rpt As New AgingReport

                If rptDay = 0 Then

                    Select Case rptRoute
                        Case 0
                            rpt.DataSource = From c In PickupTransaction.Customer.ReturnCustomer(My.Settings.DatabaseLocation)
                                             Order By c.SequenceNumber
                        Case Else
                            rpt.DataSource = From c In PickupTransaction.Customer.ReturnCustomer(My.Settings.DatabaseLocation)
                                             Where c.Route = rptRoute
                                             Order By c.SequenceNumber
                    End Select

                Else

                    Select Case rptRoute
                        Case 0
                            rpt.DataSource = From c In PickupTransaction.Customer.ReturnCustomer(My.Settings.DatabaseLocation)
                                             Order By c.SequenceNumber
                                             Where c.PickupDay = rptDay
                        Case Else
                            rpt.DataSource = From c In PickupTransaction.Customer.ReturnCustomer(My.Settings.DatabaseLocation)
                                             Order By c.SequenceNumber
                                             Where c.PickupDay = rptDay And c.Route = rptRoute
                    End Select

                End If

                'Dim customerList As List(Of PickupTransaction.Customer) = (From c In PickupTransaction.Customer.ReturnCustomer(My.Settings.DatabaseLocation)
                '                                                           Where (c.CurrentBalance >= 41 And c.CurrentBalance < 42) Or (c.AgingBalance3Month >= 41 And c.AgingBalance3Month < 42) Or (c.AgingBalance4Month >= 41 And c.AgingBalance4Month < 42) Or (c.AgingBalance5Month >= 41 And c.AgingBalance5Month < 42) Or (c.AgingBalanceCurrent >= 41 And c.AgingBalanceCurrent < 42)
                '                                                           Order By c.SequenceNumber).ToList
                rpt.ShowPreview()

            Case 2

                Dim rpt As New CustomerListingSpecial

                If rptDay = 0 Then

                    Select Case rptRoute
                        Case 0
                            rpt.DataSource = From c In PickupTransaction.Customer.ReturnCustomer(My.Settings.DatabaseLocation)
                                             Where c.BillingType >= 4 And c.BillingType <= 6 And c.SequenceNumber < 80000
                                             Order By c.SequenceNumber
                        Case Else
                            rpt.DataSource = From c In PickupTransaction.Customer.ReturnCustomer(My.Settings.DatabaseLocation)
                                             Where c.Route = rptRoute And c.BillingType >= 4 And c.BillingType <= 6 And c.SequenceNumber < 80000
                                             Order By c.SequenceNumber
                    End Select

                Else

                    Select Case rptRoute
                        Case 0
                            rpt.DataSource = From c In PickupTransaction.Customer.ReturnCustomer(My.Settings.DatabaseLocation)
                                             Where c.PickupDay = rptDay And c.BillingType >= 4 And c.BillingType <= 6 And c.SequenceNumber < 80000
                                             Order By c.SequenceNumber
                        Case Else
                            rpt.DataSource = From c In PickupTransaction.Customer.ReturnCustomer(My.Settings.DatabaseLocation)
                                             Where c.PickupDay = rptDay And c.Route = rptRoute And c.BillingType >= 4 And c.BillingType <= 6 And c.SequenceNumber < 80000
                                             Order By c.SequenceNumber
                    End Select

                End If

                rpt.ShowPreview()

            Case 3

                Dim rpt As New AgingReportDel

                If rptDay = 0 Then

                    Select Case rptRoute
                        Case 0
                            rpt.DataSource = From c In PickupTransaction.Customer.ReturnCustomer(My.Settings.DatabaseLocation)
                                             Where (c.AgingBalance3Month > 0.0 Or c.AgingBalance4Month > 0.0 Or c.AgingBalance5Month > 0) And c.SendToCollections = False
                                             Order By c.SequenceNumber
                        Case Else
                            rpt.DataSource = From c In PickupTransaction.Customer.ReturnCustomer(My.Settings.DatabaseLocation)
                                             Where c.Route = rptRoute And (c.AgingBalance3Month > 0.0 Or c.AgingBalance4Month > 0.0 Or c.AgingBalance5Month > 0) And c.SendToCollections = False
                                             Order By c.SequenceNumber
                    End Select

                Else

                    Select Case rptRoute
                        Case 0
                            rpt.DataSource = From c In PickupTransaction.Customer.ReturnCustomer(My.Settings.DatabaseLocation)
                                             Where c.PickupDay = rptDay And (c.AgingBalance3Month > 0.0 Or c.AgingBalance4Month > 0.0 Or c.AgingBalance5Month > 0) And c.SendToCollections = False
                                             Order By c.SequenceNumber

                        Case Else
                            rpt.DataSource = From c In PickupTransaction.Customer.ReturnCustomer(My.Settings.DatabaseLocation)
                                             Where c.PickupDay = rptDay And c.Route = rptRoute And (c.AgingBalance3Month > 0.0 Or c.AgingBalance4Month > 0.0 Or c.AgingBalance5Month > 0) And c.SendToCollections = False
                                             Order By c.SequenceNumber

                    End Select

                End If

                rpt.ShowPreview()

            Case 4

                Dim rpt As New GoInAfterReport

                If rptDay = 0 Then

                    Select Case rptRoute
                        Case 0
                            rpt.DataSource = From c In PickupTransaction.Customer.ReturnCustomer(My.Settings.DatabaseLocation)
                                             Where c.GoInAfter = True And c.SequenceNumber < 80000
                                             Order By c.SequenceNumber
                        Case Else
                            rpt.DataSource = From c In PickupTransaction.Customer.ReturnCustomer(My.Settings.DatabaseLocation)
                                             Where c.Route = rptRoute And c.GoInAfter = True And c.SequenceNumber < 80000
                                             Order By c.SequenceNumber
                    End Select

                Else

                    Select Case rptRoute
                        Case 0
                            rpt.DataSource = From c In PickupTransaction.Customer.ReturnCustomer(My.Settings.DatabaseLocation)
                                             Where c.PickupDay = rptDay And c.GoInAfter = True And c.SequenceNumber < 80000
                                             Order By c.SequenceNumber
                        Case Else
                            rpt.DataSource = From c In PickupTransaction.Customer.ReturnCustomer(My.Settings.DatabaseLocation)
                                             Where c.PickupDay = rptDay And c.Route = rptRoute And c.GoInAfter = True And c.SequenceNumber < 80000
                                             Order By c.SequenceNumber
                    End Select

                End If

                rpt.ShowPreview()
        End Select

    End Sub

    Private Sub ButtonClose_Click(sender As System.Object, e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

End Class
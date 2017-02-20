Public Class CollectionAccounts

    Private CurrentIndex As Integer = 0

    Private Sub FillList()

        ' ----- Remove all of the items from the list 
        ListViewAccounts.Items.Clear()

        ' ----- Get the customers who have been sent to collections 
        Dim customerList As List(Of CCustomer) = CCustomer.GetCustomersInCollection()

        ' ----- Loop through the customers 
        For Each custObj As CCustomer In customerList.OrderBy(Function(c) c.BillingAddress.LastName)
            Dim itmX As ListViewItem = ListViewAccounts.Items.Add(custObj.CustomerNumber)
            itmX.SubItems.Add(custObj.BillingAddress.FullName)
            itmX.SubItems.Add(String.Format("{0:f2}", custObj.CurrentBalanceForCollection))
            itmX.SubItems.Add(String.Format("{0:MM/dd/yyyy}", custObj.CollectionBalanceAsOf))
            itmX.Tag = custObj
        Next

        ' ----- If we have at least one item, select the current index 
        If ListViewAccounts.Items.Count > 0 Then
            Try
                ListViewAccounts.Items(CurrentIndex).Selected = True
                ListViewAccounts.EnsureVisible(CurrentIndex)
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub CollectionAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillList()
    End Sub

    Private Sub CreateAccountOnlyRollOff(selCustomer As CCustomer)

        Dim newRollOff As New CRollOff
        newRollOff.AccountDataOnly = True

        newRollOff.Customer = selCustomer
        newRollOff.ServiceAddress = Nothing
        newRollOff.DateRollOffDelivered = Date.Today
        newRollOff.RentalRate = 0.0
        newRollOff.RollOffSize = 0.0
        newRollOff.ServiceCharge = 0.0
        newRollOff.DumpingFee = 0.0
        newRollOff.RollOffPickedUp = True
        newRollOff.DateRollOffPickedUp = Date.Today
        newRollOff.RentalPeriod = 0

        ' ----- Just create a dummy fee 
        Dim tempFee As New CRollOffFee
        tempFee.DatabaseID = 1
        newRollOff.FeeObj = tempFee

        newRollOff.Save()

    End Sub

    Private Function GetSelectedCustomer() As CCustomer

        ' ----- First see if there is a roll off associated with this customer 
        If ListViewAccounts.SelectedItems.Count > 0 Then

            ' ----- Set the index from the list 
            CurrentIndex = ListViewAccounts.SelectedItems(0).Index

            ' ----- Get the selected item 
            Dim itmX As ListViewItem = ListViewAccounts.SelectedItems(0)

            ' ----- Get the selected customer
            Return DirectCast(itmX.Tag, CCustomer)

        Else

            Return Nothing

        End If

    End Function

    Private Function GetAccountRollOff() As CRollOff

        ' ----- Get the selected customer
        Dim selCustomer As CCustomer = GetSelectedCustomer()

        If Not selCustomer Is Nothing Then

            ' ----- Pull of the rolloff
            Dim tempRollOff As List(Of CRollOff) = Nothing
            tempRollOff = CRollOff.GetRollOffsForCustomer(selCustomer.DatabaseID)

            ' ----- Create the roll off if one does not exist 
            If tempRollOff.Count = 0 Then

                CreateAccountOnlyRollOff(selCustomer)
                tempRollOff = CRollOff.GetRollOffsForCustomer(selCustomer.DatabaseID)

            End If

            Return tempRollOff(0)

        Else

            Return Nothing

        End If

    End Function

    Private Sub ButtonEnterPayment_Click(sender As Object, e As EventArgs) Handles ButtonEnterPayment.Click

        Dim accountRO As CRollOff = GetAccountRollOff()

        If Not accountRO Is Nothing Then
            Dim frm As New CustomerPayments
            frm.SelectedCustomer = accountRO.Customer
            frm.SelectedRollOff = accountRO
            frm.ShowDialog()
        End If

    End Sub

    Private Sub ButtonViewRecord_Click(sender As Object, e As EventArgs) Handles ButtonViewRecord.Click

        Dim selectedCustomer As CCustomer = GetSelectedCustomer()

        If Not selectedCustomer Is Nothing Then
            Dim frm As New CustomerList
            frm.TextBoxSearch.Text = selectedCustomer.CustomerNumber
            frm.ForceRefresh = True
            frm.ShowDialog()
            FillList()
        End If

    End Sub

    Private Sub ListViewAccounts_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListViewAccounts.MouseDoubleClick
        ButtonViewRecord.PerformClick()
    End Sub

    Private Sub ButtonEnterCharge_Click(sender As Object, e As EventArgs) Handles ButtonEnterCharge.Click

        Dim accountRO As CRollOff = GetAccountRollOff()

        If Not accountRO Is Nothing Then
            Dim frm As New CustomerCharges
            frm.SelectedCustomer = accountRO.Customer
            frm.SelectedRollOff = accountRO
            frm.ShowDialog()
        End If

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

End Class
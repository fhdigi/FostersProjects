Public Class SequenceNumberAdjust

    Private Sub ButtonReSequence_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReSequence.Click

        ' ----- Get the two sequence numbers
        Dim startingNumber As Integer = 0
        Dim endingNumber As Integer = 0
        Integer.TryParse(TextBoxStartingSeqNumber.Text, startingNumber)
        Integer.TryParse(TextBoxEndingSeqNumber.Text, endingNumber)

        ' ----- Make sure the ending number is greater than the starting number 
        If endingNumber < startingNumber Then Exit Sub

        ' ----- Remove any existing rows 
        DataGridViewData.Rows.Clear()

        ' ----- Get a list of customers within the range
        Dim custList As List(Of PickupTransaction.Customer) = PickupTransaction.Customer.ReturnCustomerWithinSequence(My.Settings.DatabaseLocation, startingNumber, endingNumber)

        ' ----- Customer count
        Dim customerCount As Integer = custList.Count - 1

        ' ----- Calculated step
        Dim seqStep As Integer = (endingNumber - startingNumber) \ customerCount

        ' ----- Set the counter 
        Dim indexCounter As Integer = -seqStep

        For Each custObj As PickupTransaction.Customer In custList

            Dim newRow As Integer = DataGridViewData.Rows.Add()
            DataGridViewData.Rows(newRow).Cells(0).Value = custObj.CustomerNumber
            DataGridViewData.Rows(newRow).Cells(1).Value = custObj.FullName
            DataGridViewData.Rows(newRow).Cells(2).Value = custObj.SequenceNumber

            indexCounter += seqStep
            DataGridViewData.Rows(newRow).Cells(3).Value = startingNumber + indexCounter

        Next

    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub ButtonCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCommit.Click

        If MessageBox.Show("Are you sure you would like to modify the sequence numbers of the customers listed?  This process may take several minutes to complete.", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

            Cursor = Cursors.WaitCursor

            For Each dgr As DataGridViewRow In DataGridViewData.Rows
                PickupTransaction.Customer.UpdateSequenceNumber(My.Settings.DatabaseLocation, dgr.Cells(0).Value, dgr.Cells(3).Value)
            Next

            Cursor = Cursors.Default

        End If

    End Sub

    #Region "New Sequence Duplicate Section"

    Private Sub FindSequenceDuplicates()

        Dim dupCustomers As New List(Of PickupTransaction .Customer)
        dupCustomers = PickupTransaction .Customer .FindCustomersWithDuplicateSeqNumbers (My.Settings .DatabaseLocation )

        ListViewDuplicates .Items .Clear 

        For Each cust As PickupTransaction .Customer In dupCustomers 
            Dim itmX As ListViewItem = ListViewDuplicates .Items .Add (cust.FullName )
            itmX .SubItems .Add (cust.SequenceNumber )
            itmX.Tag = cust 
        Next

    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        FindSequenceDuplicates()
    End Sub

    Private Sub ListViewDuplicates_DoubleClick(sender As Object, e As EventArgs) Handles ListViewDuplicates.DoubleClick

        ' ----- Get the customer 
        If ListViewDuplicates.SelectedItems.Count > 0 Then

            Dim selCust As PickupTransaction.Customer = DirectCast(ListViewDuplicates.SelectedItems(0).Tag, PickupTransaction.Customer)

            If Not selCust Is Nothing Then
                Dim custForm As New CustomerEntry() With {.EditMode = True, .CustomerNumber = selCust.CustomerNumber}
                custForm .ShowDialog 
            End If

        End If
    End Sub

    #End Region


End Class
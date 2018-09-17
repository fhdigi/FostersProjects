Imports System.Net
Imports System.IO

Public Class ReviewPickedUpItems

    Private Sub GetItemsCollected(Optional ByVal searchString As String = "")

        Dim routeDescription As String = ComboBoxRoute.Text

        ' ----- This list will become the datasource 
        Dim pickupRecords As New List(Of PickupTransaction.CollectionRecord.PickupRecords)

        ' ----- Get the grid 
        Dim selectedDate As Date = DateTimePickerItems.Value

        pickupRecords = PickupTransaction.CollectionRecord.RetrieveCollectedItemsByDate(My.Settings.DatabaseLocation, selectedDate, routeDescription)

        If searchString Is String.Empty Then
            DataGridViewCollectedItems.DataSource = pickupRecords
        Else
            DataGridViewCollectedItems.DataSource = (From f In pickupRecords
                                                     Where (f.CustomerName.ToUpper.Contains(searchString.ToUpper) Or f.SequenceNumber.ToString.Contains(searchString.ToUpper) Or f.AccountNumber.ToString.Contains(searchString.ToUpper))
                                                     Select f).ToList
        End If

        ' ----- Now style the rows 
        For Each dr As DataGridViewRow In DataGridViewCollectedItems.Rows

            ' ----- Set the tool tip address 
            dr.Cells("colCustomer").ToolTipText = dr.Cells("colAddress").Value

            If dr.Cells("colBags").Value > 0 Then
                dr.Cells("colAdditionalItem").ReadOnly = True
                dr.Cells("colItemPrice").ReadOnly = True
                dr.Cells("colAdditionalItem").Style.BackColor = Color.LightGray
                dr.Cells("colItemPrice").Style.BackColor = Color.LightGray
            Else
                dr.Cells("colBags").ReadOnly = True
                dr.Cells("colBags").Style.BackColor = Color.LightGray
            End If

        Next

    End Sub

    Private Sub DateTimePickerItems_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePickerItems.ValueChanged
        GetItemsCollected()
    End Sub

    Private Sub FillInRouteInformationFromDatabase()

        ' ----- Fill in the route information from the database
        ComboBoxRoute.Items.Clear()
        ComboBoxRoute.Items.AddRange(PickupTransaction.CollectionRecord.ReturnUniqueRouteDescriptions(My.Settings.DatabaseLocation).ToArray)

        ' ----- Set the drop down to the first item (if there are items)
        If ComboBoxRoute.Items.Count > 0 Then ComboBoxRoute.SelectedIndex = 0

    End Sub

    Private Sub ReviewPickedUpItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' ----- Fill in the list box 
        RefreshCollectionFileList()

        ' ----- Create a drop down of information 
        FillInRouteInformationFromDatabase()

    End Sub

    Private Sub ComboBoxRoute_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxRoute.SelectedIndexChanged
        GetItemsCollected()
    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub DataGridViewCollectedItems_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewCollectedItems.CellEndEdit

        ' ----- Get the database ID
        Dim dbID As Integer = DataGridViewCollectedItems.Rows(e.RowIndex).Cells("DatabaseID").Value

        ' ----- Get the values from the cells and update the record 
        Dim updateObj As New PickupTransaction.CollectionRecord

        ' ----- Get the values from the grid 
        With DataGridViewCollectedItems.Rows(e.RowIndex)
            updateObj.ID = dbID
            Date.TryParse(.Cells("colPickupDate").Value.ToString, updateObj.DateCollected)
            Integer.TryParse(.Cells("colBags").Value.ToString, updateObj.Quantity)
            updateObj.ItemDescription = .Cells("colAdditionalItem").Value
            Double.TryParse(.Cells("colItemPrice").Value.ToString, updateObj.ItemPrice)
        End With

        ' ----- Save the data 
        PickupTransaction.CollectionRecord.UpdateCollectedItem(My.Settings.DatabaseLocation, updateObj)

    End Sub

    Private Sub ButtonImportSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonImportSelected.Click

        Dim frmWait As New WaitForm
        frmWait.Label1.Text = "Importing Records"
        frmWait.Show(Me)
        frmWait.Refresh()

        ' ----- Show the wait cursor since the process takes a few minutes 
        Cursor = Cursors.WaitCursor

        ' ----- Check to make sure an item is selected 
        If ListBoxRoutesToImport.SelectedIndex >= 0 Then

            ' ----- Get the file name 
            Dim fileToImport As String = ListBoxRoutesToImport.SelectedItem

            ' ----- If this is an FTP file, download it to the shared location
            If RadioButtonFTP.Checked Then

                ' ----- Establish the source and destination files 
                Dim sourceFile As String = fileToImport
                Dim destinationFile As String = Path.Combine(My.Settings.SharedLocation, fileToImport)

                Dim ftpHelp As FTPHelper.Client = New FTPHelper.Client("ftp://www.lccsny.com/foster", "0083045|lccsnycom00", "captmo28")
                Dim response As String = ftpHelp.DownloadFile(sourceFile, destinationFile)

                ' ----- Just do this so that the parser can find the file (the shared location is appended)
                fileToImport = destinationFile

                ' ----- If we had a successful transfer, delete the file 
                If response.StartsWith("226") Then ftpHelp.DeleteFile(sourceFile)

            End If

            ' ----- Save the contents of that file to the database 
            Dim currentCount As Integer = 0
            Dim previousCount As Integer = 0
            Dim returnCode As PickupTransaction.CollectionRecord.ImportReturnCodes = PickupTransaction.CollectionRecord.ReadXML(My.Settings.DatabaseLocation, fileToImport, previousCount, currentCount)

            If returnCode = PickupTransaction.CollectionRecord.ImportReturnCodes.Duplicates Then

                Dim strMessage As String = String.Format("The program is attempting to import {0} records but has determined there are {1} duplicate database records for this date and route.  This may indicate the route has already been imported.  Please contact LCCS for support.", currentCount, previousCount)
                MessageBox.Show(strMessage, "Duplicates", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf returnCode = PickupTransaction.CollectionRecord.ImportReturnCodes.ImportSuccessful Then

                ' ----- Pull out the base file name 
                Dim baseFileName As String = My.Computer.FileSystem.GetName(fileToImport)

                ' ----- Move this file from the main location to the saved location 
                My.Computer.FileSystem.MoveFile(fileToImport, My.Settings.SharedLocation & "\SavedCollections\" & baseFileName, True)

                ' ----- Refresh the data screen 
                FillInRouteInformationFromDatabase()

                ' ----- Refresh the list box 
                RefreshCollectionFileList()

            End If

        End If

        ' ----- Restore the cursor back to the user default 
        Cursor = Cursors.Default

        ' ----- Close the wait form 
        frmWait.Close()

    End Sub

    ''' <summary>
    ''' Routine to refresh the list box that contains that routes that have not been processed
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub RefreshCollectionFileList()
        Try
            ListBoxRoutesToImport.Items.Clear()

            If RadioButtonLocal.Checked Then
                For Each fn As String In My.Computer.FileSystem.GetFiles(My.Settings.SharedLocation, FileIO.SearchOption.SearchTopLevelOnly, {"*.fcf"})
                    ListBoxRoutesToImport.Items.Add(fn)
                Next

            Else
                Dim fileListing As List(Of String) = ListFTPSiteFiles()
                ListBoxRoutesToImport.Items.AddRange(fileListing.ToArray)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButtonFTP_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonFTP.CheckedChanged
        RefreshCollectionFileList()
    End Sub

    Private Function ListFTPSiteFiles() As List(Of String)

        Dim ftpHelp As FTPHelper.Client = New FTPHelper.Client("ftp://www.lccsny.com/foster", "0083045|lccsnycom00", "captmo28")
        Return ftpHelp.ListDirectory().Where(Function(e) e.EndsWith(".fcf")).ToList

    End Function

    Private Sub ButtonSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearch.Click
        GetItemsCollected(TextBoxSearch.Text)
    End Sub

    Private Sub TextBoxSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call ButtonSearch_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub TextBoxSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxSearch.KeyPress
        If e.KeyChar = ControlChars.Cr Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridViewCollectedItems_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewCollectedItems.CellContentClick

        If DataGridViewCollectedItems.Columns(e.ColumnIndex).Name = "colCustomer" Then

            ' ----- Get the account number 
            Dim accountNumber As Integer = Convert.ToInt32(DataGridViewCollectedItems.Rows(e.RowIndex).Cells("AccountNumber").Value)

            Dim frm As New EditPickupItems
            frm.CustomerNumber = accountNumber
            frm.ShowDialog()

        End If

    End Sub

End Class
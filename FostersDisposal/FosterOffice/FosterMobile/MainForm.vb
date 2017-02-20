Imports PickupTransaction
Imports System.Xml
Imports System.IO
Imports System.Speech.Synthesis

Public Class MainForm

    Private TempRouteDescription As String = "Monday - A"

    Public Class DisplayListing
        Public Property ItemNumber As Integer = 0
        Public Property ItemDescription As String

        Public Overrides Function ToString() As String
            Return _ItemDescription
        End Function
    End Class

    Private Enum RecordMoveProcess
        PreviousCustomer
        NextCustomer
    End Enum

    ' ----- This flag should get set by the startup screen 
    Public Property StartMode As Integer = 0

    Private SelectedCustomerItemIndex As Integer = 0

    ' ----- This object contains all of our customer on this route in sequence number order 
    Private CustomerListing As List(Of PickupTransaction.Customer.CCustomerList)

    ' ----- Create an object to hold the collection record
    Private CollectionRecordList As List(Of PickupTransaction.CollectionRecord) = Nothing

    ' ----- A dictionary that is indexed to look up a description
    Private ItemsCollectedLookup As New Dictionary(Of Integer, DisplayListing)

    ' ----- A dictionary that is indexed by count for listing on the screen 
    Private ItemsCollectedByIndex As New Dictionary(Of Integer, PickupTransaction.ItemsCollected)

    ' ----- A garbage bag is the most popular item to save
    Private GargbageBagItem As New PickupTransaction.ItemsCollected

    Private CurrentItemPage As Integer = 1
    Private MaxiumItemIndex As Integer = -1
    Private MaximumPageNumber As Integer = 0
    Private ButtonControlsOnScreen As Integer = 6

    Dim spsynthesizer As SpeechSynthesizer

    Private UseSpeechEngine As Boolean = False

    'Private RouteStartTime As Date = Nothing
    'Private RouteEndTime As Date = Nothing

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' ----- Prepare the sound engine 
        spsynthesizer = New SpeechSynthesizer()
        spsynthesizer.Volume = 100
        spsynthesizer.Rate = 2

        ' ----- Create the customer list 
        'CustomerListing = PickupTransaction.Customer.ReturnCustomerListByDayAndRoute(My.Settings.DatabaseLocation, My.Settings.SelectedRouteDay, My.Settings.SelectedRouteNumber)

        ' ----- Create a customer list from the data object 
        CustomerListing = PickupTransaction.Customer.ReturnCustomerListByDayAndRoute_V2(My.Settings.SelectedRouteDay, My.Settings.SelectedRouteNumber)

        ' ----- Set the route description 
        TempRouteDescription = "Truck - " & My.Settings.SelectedRouteNumber.ToString

        ' ----- Fill the screen list and the dictionary
        FillCollectedItemsList()

        ' ----- Display the collection items on the buttons
        UpdateScreen()

        ' ----- Record the time the route started
        'If StartMode = 1 Then RecordStartTime()

        ' ----- Show the first person in the sequence
        GoToCustomer()

    End Sub

    Private Sub GoToCustomer()

        ' ----- Write customer specific information 
        LabelSeqNum.Text = CustomerListing(SelectedCustomerItemIndex).SequenceNumber
        LabelName.Text = CustomerListing(SelectedCustomerItemIndex).CustomerName
        LabelCustAddress.Text = CustomerListing(SelectedCustomerItemIndex).CustomerAddress
        LabelBillingRate.Text = IIf(CustomerListing(SelectedCustomerItemIndex).BillingBagRate = 3, "(4)", "(" & CustomerListing(SelectedCustomerItemIndex).BillingBagRate.ToString & ")")

        ' ----- Announce the next name 
        SpeakToUser(LabelName.Text)

        DisplayCustomerItemsCollected()

        ' ----- Do this for the Yellow Tab customers 
        Try
            If CustomerListing(SelectedCustomerItemIndex).YellowTab = True Then
                Dim frm As New SpecialInstructionForm
                frm.Label1.Text = "YELLOW TAB CUSTOMER - DO NOT PICKUP"
                frm.ShowDialog()
            End If
        Catch ex As Exception

        End Try

        ' ----- Show the special instructions 
        If CustomerListing(SelectedCustomerItemIndex).SpecialInstructions <> "" Then
            Dim frm As New SpecialInstructionForm
            frm.Label1.Text = CustomerListing(SelectedCustomerItemIndex).SpecialInstructions
            frm.ShowDialog()
        End If

    End Sub

    Private Sub DisplayCustomerItemsCollected()

        Dim tempBag As Integer = 0

        ' ----- Clear all from the list of collected items 
        ListBoxCollectedItems.Items.Clear()

        ' ----- Query the database and get the current list 
        For Each obj As CollectionRecord In PickupTransaction.CollectionRecord.RetrieveCollectedItems(My.Settings.DatabaseLocation, CustomerListing(SelectedCustomerItemIndex).AccountNumber)

            If obj.ItemID = 1 Then

                ' ----- Show the garbage bags and quantity
                Dim newDisplayItem As New DisplayListing()
                newDisplayItem.ItemNumber = 1
                newDisplayItem.ItemDescription = String.Format("Garbage Bags: {0}", obj.Quantity)
                ListBoxCollectedItems.Items.Add(newDisplayItem)

                tempBag = obj.Quantity

            Else

                ' ----- Everything else 
                ListBoxCollectedItems.Items.Add(ItemsCollectedLookup(obj.ItemID))

            End If

        Next

        ' ----- Set the flag for the minus button 
        ButtonMinusBag.Enabled = IIf(tempBag > 0, True, False)

    End Sub

    Private Sub Button1Bag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1Bag.Click, Button2Bag.Click, Button3Bag.Click, Button4Bag.Click, Button5Bag.Click, Button6Bag.Click

        ' ----- Which button was pressed 
        Dim selButton As Button = DirectCast(sender, Button)

        ' ----- Establish a bag number variable
        Dim bagNumber As Integer = 0

        ' ----- If we have a number, save it to the collection 
        If Integer.TryParse(selButton.Text, bagNumber) Then

            ' ----- check and see if they already have a garbage bag listed
            For listIndex As Integer = 0 To ListBoxCollectedItems.Items.Count - 1

                ' ----- Get out of the routine if they pressed the new quantity by accident 
                Dim lbText As String = ListBoxCollectedItems.Items(listIndex).ToString
                If lbText.StartsWith("Garbage Bag") Then
                    If MessageBox.Show("You have already entered a garbage bag for this customer.  If you want to change the quantity, please press OK.  If you need to change the customer first, please press CANCEL and then press NEXT CUSTOMER", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Cancel Then
                        Exit Sub
                    End If
                End If

            Next

            ' ----- Create an object and save it to the database 
            Dim newObj As New CollectionRecord(CustomerListing(SelectedCustomerItemIndex).AccountNumber, Now, bagNumber, 1, "", 0.0, TempRouteDescription)
            PickupTransaction.CollectionRecord.SaveCollectedItemMobile(My.Settings.DatabaseLocation, newObj)

            ' ----- Refresh the listing 
            DisplayCustomerItemsCollected()

            ' ----- Speak it
            SpeakToUser(bagNumber.ToString & IIf(bagNumber = 1, " Garbage Bag", " Garbage Bags"))

        End If

    End Sub

    Private Sub ButtonPlusBag_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonPlusBag.Click

        Dim numBags As Integer = PickupTransaction.CollectionRecord.GetNumberCollectedBags(My.Settings.DatabaseLocation, CustomerListing(SelectedCustomerItemIndex).AccountNumber)

        ' ----- Create an object and save it to the database 
        Dim newObj As New CollectionRecord(CustomerListing(SelectedCustomerItemIndex).AccountNumber, Now, numBags + 1, 1, "", 0.0, TempRouteDescription)
        PickupTransaction.CollectionRecord.SaveCollectedItemMobile(My.Settings.DatabaseLocation, newObj)

        ' ----- Refresh the listing 
        DisplayCustomerItemsCollected()

    End Sub

    Private Sub ButtonMinusBag_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonMinusBag.Click

        Dim numBags As Integer = PickupTransaction.CollectionRecord.GetNumberCollectedBags(My.Settings.DatabaseLocation, CustomerListing(SelectedCustomerItemIndex).AccountNumber)

        If numBags > 0 Then

            ' ----- Create an object and save it to the database 
            Dim newObj As New CollectionRecord(CustomerListing(SelectedCustomerItemIndex).AccountNumber, Now, numBags - 1, 1, "", 0.0, TempRouteDescription)
            PickupTransaction.CollectionRecord.SaveCollectedItemMobile(My.Settings.DatabaseLocation, newObj)

            ' ----- Refresh the listing 
            DisplayCustomerItemsCollected()

        End If

    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click, ButtonItem2.Click, ButtonItem3.Click, ButtonItem4.Click, ButtonItem5.Click, ButtonItem6.Click

        ' ------ Get the button
        Dim clickedButton As Button = DirectCast(sender, Button)

        ' ----- Get the selected item
        Dim selItem As PickupTransaction.ItemsCollected = DirectCast(clickedButton.Tag, PickupTransaction.ItemsCollected)

        ' ----- Just in case 
        If selItem Is Nothing Then Exit Sub

        ' ----- Save it to the current collection 
        Dim newObj As New CollectionRecord(CustomerListing(SelectedCustomerItemIndex).AccountNumber, Now, 1, selItem.ID, selItem.ItemDescription, selItem.MaximumPrice, TempRouteDescription)
        PickupTransaction.CollectionRecord.SaveCollectedItemMobile(My.Settings.DatabaseLocation, newObj)

        ' ----- Refresh the listing 
        DisplayCustomerItemsCollected()

        ' ----- Speak it
        SpeakToUser(clickedButton.Text)

    End Sub

    Private Sub ButtonRemove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonRemove.Click

        ' ----- Get the item from the listing 
        Dim selItem As DisplayListing = DirectCast(ListBoxCollectedItems.SelectedItem, DisplayListing)

        ' ----- Make sure it is valid 
        If selItem Is Nothing Then Exit Sub

        ' ----- Get the item ID and delete it from the collection 
        Dim colObj As New CollectionRecord(CustomerListing(SelectedCustomerItemIndex).AccountNumber, Now, 0, selItem.ItemNumber, "", 0.0, TempRouteDescription)
        PickupTransaction.CollectionRecord.RemoveCollectedItem(My.Settings.DatabaseLocation, colObj)

        ' ----- Refresh the list 
        DisplayCustomerItemsCollected()

    End Sub

    Private Sub ChangeCustomerProcess(ByVal moveProcess As RecordMoveProcess)

        ' ----- Get the details of the customer that is being moved to.  Open the database and fill in 
        '       the collection object if data exists.  If there is no data, start with a blank screen.
        Select Case moveProcess

            Case RecordMoveProcess.NextCustomer
                If SelectedCustomerItemIndex + 1 < CustomerListing.Count Then
                    SelectedCustomerItemIndex += 1
                End If

            Case RecordMoveProcess.PreviousCustomer
                If SelectedCustomerItemIndex > 0 Then
                    SelectedCustomerItemIndex -= 1
                End If

        End Select

        ' ----- Refresh the title block
        GoToCustomer()

    End Sub

    Private Sub ButtonNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNext.Click, ButtonPrior.Click

        Dim btnType As Button = DirectCast(sender, Button)

        ' ----- Call the process to change the customer 
        If btnType Is ButtonNext Then
            ChangeCustomerProcess(RecordMoveProcess.NextCustomer)
        Else
            ChangeCustomerProcess(RecordMoveProcess.PreviousCustomer)
        End If

    End Sub

#Region "Code Related to Items that can be Collected"

    Private Sub FillCollectedItemsList()

        Dim itemCount As Integer = 0

        ' ----- Clear out the dictionary 
        ItemsCollectedByIndex.Clear()

        ' ----- Create the item list
        For Each obj As PickupTransaction.ItemsCollected In ProgramDataObject.ReturnItemList

            If obj.ID > 1 Then

                itemCount += 1
                ItemsCollectedByIndex.Add(itemCount, obj)
                MaxiumItemIndex = itemCount

            ElseIf obj.ID = 1 Then

                ' ----- Define the garbage bag item 
                GargbageBagItem = obj

            End If

            Dim newDisplayObj As New DisplayListing
            newDisplayObj.ItemNumber = obj.ID
            newDisplayObj.ItemDescription = obj.ItemDescription
            ItemsCollectedLookup.Add(obj.ID, newDisplayObj)

        Next

        ' ----- Determine the maximum number of pages that should be displayed 
        MaximumPageNumber = MaxiumItemIndex \ ButtonControlsOnScreen + 1

    End Sub

    Private Sub ButtonItemPageNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItemPageNext.Click

        If CurrentItemPage < MaximumPageNumber Then
            CurrentItemPage += 1
            UpdateScreen()
        End If

    End Sub

    Private Sub ButtonItemPagePrevious_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonItemPagePrevious.Click

        If CurrentItemPage > 1 Then
            CurrentItemPage -= 1
            UpdateScreen()
        End If

    End Sub

    Private Sub UpdateScreen()

        Dim startIndex As Integer = (CurrentItemPage - 1) * ButtonControlsOnScreen + 1
        Dim endIndex As Integer = CurrentItemPage * ButtonControlsOnScreen
        Dim controlCounter As Integer = 0

        For buttonCounter As Integer = startIndex To endIndex

            controlCounter += 1

            If buttonCounter <= MaxiumItemIndex Then
                Me.Controls("GroupboxOtherItems").Controls("ButtonItem" & controlCounter.ToString).Text = ItemsCollectedByIndex(buttonCounter).ItemDescription
                Me.Controls("GroupboxOtherItems").Controls("ButtonItem" & controlCounter.ToString).Tag = ItemsCollectedByIndex(buttonCounter)
                Me.Controls("GroupboxOtherItems").Controls("ButtonItem" & controlCounter.ToString).Visible = True
            Else
                Me.Controls("GroupboxOtherItems").Controls("ButtonItem" & controlCounter.ToString).Text = ""
                Me.Controls("GroupboxOtherItems").Controls("ButtonItem" & controlCounter.ToString).Tag = Nothing
                Me.Controls("GroupboxOtherItems").Controls("ButtonItem" & controlCounter.ToString).Visible = False
            End If

        Next

    End Sub

#End Region

    Private Sub SpeakToUser(ByVal textToSay As String)

        If UseSpeechEngine Then
            spsynthesizer.SpeakAsync(textToSay)
        End If

    End Sub

    Private Sub ButtonEndShift_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEndShift.Click

        Dim frm As New AskToUpload

        Dim response As DialogResult = frm.ShowDialog

        If response = DialogResult.OK Then

            ' ----- This becomes the file name 
            Dim shiftFile As String = String.Format("CollectionData_Day{0}_Route{1}_{2}{3}{4}.fcf", My.Settings.SelectedRouteDay, My.Settings.SelectedRouteNumber, Date.Today.Day, MonthDictionary(Date.Today.Month), Date.Today.Year)

            ' ----- Make one more route close backup
            Try
                If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\" & shiftFile) Then

                    ' ----- This creates a unique time stamp
                    Dim backupFileTimeStamp As String = Date.Now.ToString("yyyyMMdd_hhmmss")

                    ' ----- Creates the name with the time stamp
                    Dim backupFile As String = String.Format("CollectionData_Day{0}_Route{1}_{2}.bak", My.Settings.SelectedRouteDay, My.Settings.SelectedRouteNumber, backupFileTimeStamp)

                    ' ----- Make a copy of the file 
                    My.Computer.FileSystem.CopyFile(String.Format("{0}\{1}", My.Application.Info.DirectoryPath, shiftFile), String.Format("{0}\{1}", My.Application.Info.DirectoryPath, backupFile), True)

                End If
            Catch ex As Exception

            End Try

            ' ----- Create the file name for the uploaded data 
            Dim uploadedDataFileName As String = My.Application.Info.DirectoryPath & "\" & shiftFile

            ' ----- Write the file to the directory 
            PickupTransaction.CollectionRecord.GenerateXML(My.Settings.DatabaseLocation, uploadedDataFileName)

            ' ----- Close everything up 
            Me.Close()
            End

        End If

    End Sub

    'Public Sub UploadDataFile(ByVal uploadedDataFileName As String)

    '    Cursor = Cursors.WaitCursor

    '    Try

    '        ' ----- Create an instance of the FTP client 
    '        Dim ftpCli As New Utilities.FTP.FTPclient("ftp://www.lccsny.com/foster", "0083045|lccsnycom00", "captmo28")

    '        ' ----- Upload the file 
    '        Dim uploaded As Boolean = ftpCli.Upload(uploadedDataFileName)

    '        If uploaded Then
    '            MessageBox.Show("The route information was successfully uploaded to the server.  Thank you.", "Uploaded", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If

    '    Catch ex As Exception

    '        Dim errorMsg As String = String.Format("There was an error uploading the route information.  The error message was {0}.", ex.Message)
    '        MessageBox.Show(errorMsg, "Uploaded", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    '    End Try

    '    Cursor = Cursors.Default

    '    Me.Close()

    'End Sub

    Private Sub ButtonJumpTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonJumpTo.Click

        Dim frm As New CustomerListing

        If frm.ShowDialog() = DialogResult.OK Then
            SelectedCustomerItemIndex = frm.SelectedCustomer
            GoToCustomer()
        End If

    End Sub

End Class

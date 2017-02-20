Imports System.Net
Imports System.Xml
Imports System.IO

Public Class ShiftStartOptions

    Public Property ReturnValueFromUser As Integer = 0
    Dim newThread As System.Threading.Thread

    Private Sub ShiftStartOptions_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Try
            If newThread.IsAlive Then
                newThread.Abort()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ShiftStartOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' ----- This allows me to change the button from the thread 
        CheckForIllegalCrossThreadCalls = False

        ' ----- Check for an update file on the internet
        Try
            newThread = New System.Threading.Thread(AddressOf CheckForUpdates)
            newThread.Start()
        Catch ex As Exception

        End Try

        ' ----- Write out when the database was downloaded
        LabelDBDownload.Text = String.Format("Database Location: {0}", My.Settings.DatabaseLocation)

        ' ----- Set the last route day and route number 
        ComboBoxRouteDay.SelectedIndex = My.Settings.SelectedRouteDay - 1
        ComboBoxRouteNumber.SelectedIndex = My.Settings.SelectedRouteNumber - 1

    End Sub

    Private Sub ButtonStartRoute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStartRoute.Click

        ' ----- First make sure this is what they want to do 
        Dim ans As DialogResult = MessageBox.Show("This will start the program with a clean route and will erase any previously saved route data on this computer.  Would you like to continue?", "Continue", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If ans <> DialogResult.Yes Then Exit Sub

        ' ----- Get the latest version of the data base 
        Cursor = Cursors.WaitCursor

        ' ----- Create a backup file
        Try
            Dim dateString As String = Date.Now.ToString("yyyyMMdd_hhmmss")
            Dim backupfileName As String = My.Application.Info.DirectoryPath & "\" & String.Format("RouteBackup_{0}.bak", dateString)
            PickupTransaction.CollectionRecord.GenerateXML(My.Settings.DatabaseLocation, backupfileName)
        Catch ex As Exception

        End Try

        Try

            ' ----- Remove all of the existing items from the route
            PickupTransaction.CollectionRecord.DeleteRoute(My.Settings.DatabaseLocation)

            ' ----- Go to the main screen 
            ReturnValueFromUser = 1
            Me.Close()


        Catch ex As Exception

            Dim errorMsg As String = String.Format("There was an error uploading the route information.  The error message was:{0}{1}.", ControlChars.CrLf, ex.Message)
            MessageBox.Show(errorMsg, "Uploaded", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

        ' ----- Save the data that was entered 
        My.Settings.SelectedRouteDay = ComboBoxRouteDay.SelectedIndex + 1
        My.Settings.SelectedRouteNumber = ComboBoxRouteNumber.SelectedIndex + 1
        My.Settings.Save()

        ' ----- Return the cursor to normal 
        Cursor = Cursors.Default

    End Sub

    Private Sub ButtonResumePreviousRoute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonResumePreviousRoute.Click
        ReturnValueFromUser = 2
        Me.Close()
    End Sub

    Private Sub ButtonCloseProgram_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCloseProgram.Click

        ' ----- Save the data that was entered 
        My.Settings.SelectedRouteDay = ComboBoxRouteDay.SelectedIndex + 1
        My.Settings.SelectedRouteNumber = ComboBoxRouteNumber.SelectedIndex + 1
        My.Settings.Save()

        ' ----- Just close the program 
        ReturnValueFromUser = 3
        Me.Close()

    End Sub

#Region "Auto-Updating Routines"

    Private Sub CheckForUpdates()

        Dim serverprogramVersion As Long = 0
        Dim localprogramVersion As Long = 0

        Dim serverinstallfile As Boolean = False
        Dim LocalInstallFile As Boolean = False

        Dim AskToUpdate As Boolean = False

        ' ----- First delete the updates.xml file 
        Try
            Kill(My.Application.Info.DirectoryPath & "\updates.xml")
        Catch ex As Exception

        End Try

        ' ----- Try to get the file 
        If GetInternetFile() Then

            ' ----- Check the version on the internet
            Try

                ' ----- Load and read the XML document we just got from the web 
                Dim xmldoc As New XmlDocument
                xmldoc.Load(My.Application.Info.DirectoryPath & "\updates.xml")

                ' ----- Read the database version 
                Long.TryParse(xmldoc.ChildNodes(0).ChildNodes(0).InnerText, serverprogramVersion)

                serverinstallfile = True

            Catch ex As Exception

            End Try

            ' ----- Now check the version on the hard drive
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\installed.xml") Then

                Try

                    Dim xmlInstalled As New XmlDocument
                    xmlInstalled.Load(My.Application.Info.DirectoryPath & "\installed.xml")

                    ' ----- Read the database version 
                    If Long.TryParse(xmlInstalled.ChildNodes(0).ChildNodes(0).InnerText, localprogramVersion) Then
                        LocalInstallFile = True
                    Else
                        LocalInstallFile = False
                    End If

                Catch ex As Exception
                    LocalInstallFile = False
                End Try

            Else

                LocalInstallFile = False

            End If

            ' ----- If there is a server file but not a local file then ask to update
            If serverinstallfile And Not LocalInstallFile Then
                AskToUpdate = True
            End If

            ' ----- If the local version is less than the server version, then ask to update
            If localprogramVersion < serverprogramVersion Then
                AskToUpdate = True
            End If

            ' ----- Ask the user if they want to download the updates
            If AskToUpdate Then

                ButtonUpdate.Enabled = True

            End If

        End If

    End Sub

    Private Sub ButtonUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUpdate.Click

        ' ----- Shell off to the update EXE
        System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\FosterUpdater.exe")

        ' ----- Close the program 
        End

    End Sub

    Private Function GetInternetFile() As Boolean

        Dim returnFlag As Boolean = True
        Dim serverName As String = ""
        Dim serverFolder As String = ""

        ' ----- Establish the server location 
        Dim serverAddressAndFile As String = "http://www.lccsny.com/foster/updates.xml"

        ' ----- Get a web request 
        Dim wr As HttpWebRequest = CType(System.Net.WebRequest.Create(serverAddressAndFile), HttpWebRequest)
        wr.Credentials = CredentialCache.DefaultCredentials

        Try

            Dim ws As HttpWebResponse = CType(wr.GetResponse(), HttpWebResponse)
            Dim str As Stream = ws.GetResponseStream()

            Dim inBuf(10000000) As Byte
            Dim bytesToRead As Integer = CInt(inBuf.Length)
            Dim bytesRead As Integer = 0

            While bytesToRead > 0
                Dim n As Integer = str.Read(inBuf, bytesRead, bytesToRead)
                If n = 0 Then
                    Exit While
                End If
                bytesRead += n
                bytesToRead -= n
            End While

            Dim fstr As New FileStream(My.Application.Info.DirectoryPath & "\updates.xml", FileMode.OpenOrCreate, FileAccess.Write)
            fstr.Write(inBuf, 0, bytesRead)
            str.Close()
            fstr.Close()

            returnFlag = True

        Catch ex As WebException

            returnFlag = False

        End Try

        Return returnFlag

    End Function

#End Region

    Private Sub ButtonGetLatestDatabase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGetLatestDatabase.Click

        Dim frm As New SetupForm
        frm.ShowDialog()

        '' ----- First make sure this is what they want to do 
        'Dim ans As DialogResult = MessageBox.Show("This will download a new database from the Foster server and erase the current database.  Would you like to continue?", "Continue", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        'If ans <> DialogResult.Yes Then Exit Sub

        'Try
        '    Dim savedFile As String = String.Format("DisposalData{0}{1}{2}.sdf", Today.Year, Today.Month, Today.Day)
        '    My.Computer.FileSystem.CopyFile(My.Application.Info.DirectoryPath & "\DisposalData.sdf", savedFile)
        'Catch ex As Exception

        'End Try

        '' ----- Get the latest version of the data base 
        'Cursor = Cursors.WaitCursor

        'Try

        '    ' ----- Create an instance of the FTP client 
        '    Dim ftpCli As New Utilities.FTP.FTPclient("ftp://www.lccsny.com/foster", "0083045|lccsnycom00", "captmo28")

        '    ' ----- Upload the file 
        '    Dim uploaded As Boolean = ftpCli.Download("DisposalData.sdf", My.Application.Info.DirectoryPath & "\DisposalData.sdf", True)

        '    If uploaded Then

        '        MessageBox.Show("The latest database has been downloaded successfully.  You may proceed with running a route", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '        My.Settings.LastDatabaseDownload = Date.Now
        '        My.Settings.Save()

        '    End If

        'Catch ex As Exception

        '    Dim errorMsg As String = String.Format("There was an error downloaded the latest database.  The error message was:{0}{1}.", ControlChars.CrLf, ex.Message)
        '    MessageBox.Show(errorMsg, "Uploaded", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        'End Try

        '' ----- Return the cursor to normal 
        'Cursor = Cursors.Default

        ' ----- Write out when the database was downloaded
        LabelDBDownload.Text = String.Format("Database Location: {0}", My.Settings.DatabaseLocation)

    End Sub

End Class
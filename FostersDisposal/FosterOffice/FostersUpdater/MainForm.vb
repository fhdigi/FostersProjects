Imports system.net
Imports System.IO

Public Class MainForm

    Private webRequest As HttpWebRequest
    Private webResponse As HttpWebResponse
    Private downloadThreadStatus As Integer = 0
    Private downloadThreadMessage As String = ""

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' ----- Now show the first label
        Label1.Font = New Font(Label1.Font, FontStyle.Bold)
        Label2.Font = New Font(Label2.Font, FontStyle.Regular)
        Label3.Font = New Font(Label3.Font, FontStyle.Regular)
        Me.Refresh()

        TimerStart.Enabled = True

        ' ----- First remove anything that might already be in the directory
        Try
            Kill(My.Application.Info.DirectoryPath & "\FosterUpdate.zip")
        Catch ex As Exception

        End Try

    End Sub

    Private Function EstablishServerConnection() As Boolean

        Dim returnFlag As Boolean = True
        Dim serverName As String = ""
        Dim serverFolder As String = ""

        ' ----- Establish the server location 
        Dim serverAddressAndFile As String = "http://www.lccsny.com/foster/FosterUpdate.zip"

        ' ----- Get a web request 
        webRequest = CType(System.Net.WebRequest.Create(serverAddressAndFile), HttpWebRequest)

        Try

            ' ----- Get a web response 
            webResponse = CType(webRequest.GetResponse(), HttpWebResponse)

        Catch

            Return False

        End Try

        Return True

    End Function

    Private Sub DownloadingFile()

        Try

            ' ----- Open the response stream 
            Dim str As Stream = webResponse.GetResponseStream()

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

            Dim fstr As New FileStream(My.Application.Info.DirectoryPath & "\FosterUpdate.zip", FileMode.OpenOrCreate, FileAccess.Write)
            fstr.Write(inBuf, 0, bytesRead)
            str.Close()
            fstr.Close()
            downloadThreadStatus = 1

        Catch ex As WebException

            downloadThreadStatus = 2
            downloadThreadMessage = ex.Message
            MessageBox.Show(ex.Message, "Error Reading File", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try

    End Sub

    Private Sub TimerStart_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TimerStart.Tick

        ' ----- We no longer need the timer 
        TimerStart.Enabled = False

        ' ----- Try to contact the server 
        If EstablishServerConnection() Then

            ' ----- Now show the first label
            Label1.Font = New Font(Label1.Font, FontStyle.Regular)
            Label2.Font = New Font(Label2.Font, FontStyle.Bold)
            Label3.Font = New Font(Label3.Font, FontStyle.Regular)
            Me.Refresh()

            ' ----- Create a new thread for downloading the file 
            Dim downloadThread As New Threading.Thread(AddressOf DownloadingFile)
            downloadThread.Start()

            Do

                Select Case downloadThreadStatus
                    Case 2
                        MessageBox.Show(downloadThreadMessage)
                End Select

                If downloadThreadStatus > 0 Then

                    ' ----- Now show the first label
                    Label1.Font = New Font(Label1.Font, FontStyle.Regular)
                    Label2.Font = New Font(Label2.Font, FontStyle.Regular)
                    Label3.Font = New Font(Label3.Font, FontStyle.Bold)
                    Me.Refresh()
                    UnZipUpdateFiles()

                End If

            Loop

        Else

            MessageBox.Show("The program failed to contact the server.  This may be a temporary problem with the connection.  Please try again at a later time.  Now restarting the application.", "Error Contacting Server", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        End
    End Sub

    Public Sub RestartApplication()

        ' ----- Get the file names 
        Dim oldFile As String = My.Application.Info.DirectoryPath & "\updates.xml"
        Dim newFile As String = My.Application.Info.DirectoryPath & "\installed.xml"

        ' ----- Copy update file to installed file 
        If File.Exists(oldFile) Then
            My.Computer.FileSystem.CopyFile(oldFile, newFile, True)
        End If

        ' ----- Start the ProPrograms again
        System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\FosterMobile.exe")

        ' ----- Close this program
        End

    End Sub

    Public Sub UnZipUpdateFiles()

        Dim fastZip As New ICSharpCode.SharpZipLib.Zip.FastZip()

        Try
            fastZip.ExtractZip(My.Application.Info.DirectoryPath & "\FosterUpdate.zip", My.Application.Info.DirectoryPath, ICSharpCode.SharpZipLib.Zip.FastZip.Overwrite.Always, Nothing, "", "", True)

        Catch ex As Exception

            MessageBox.Show("There was an error unzipping the update files.  The error message is " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try

        RestartApplication()

    End Sub

End Class

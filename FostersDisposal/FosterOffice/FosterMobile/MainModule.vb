Module MainModule

    Public ProgramDataObject As New PickupTransaction.CDataExtender
    Public MonthDictionary As New Dictionary(Of Integer, String)

    Public Sub Main()

        Application.EnableVisualStyles()

        MonthDictionary.Add(1, "JAN")
        MonthDictionary.Add(2, "FEB")
        MonthDictionary.Add(3, "MAR")
        MonthDictionary.Add(4, "APR")
        MonthDictionary.Add(5, "MAY")
        MonthDictionary.Add(6, "JUN")
        MonthDictionary.Add(7, "JUL")
        MonthDictionary.Add(8, "AUG")
        MonthDictionary.Add(9, "SEP")
        MonthDictionary.Add(10, "OCT")
        MonthDictionary.Add(11, "NOV")
        MonthDictionary.Add(12, "DEC")

        ' ----- Show the startup screen 
        Dim frmStart As New ShiftStartOptions
        frmStart.ShowDialog()

        ' ----- This gets us out of the program 
        If frmStart.ReturnValueFromUser = 3 Then End

        ' ----- Set up the data class 
        ProgramDataObject.Init(My.Settings.DatabaseLocation)

        ' ----- Run the main loop 
        Dim frmMain As New MainForm
        frmMain.StartMode = frmStart.ReturnValueFromUser
        Application.Run(frmMain)

    End Sub

End Module

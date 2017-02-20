Module FosterOfficeModule

    Public Enum RTBOperations
        Cut = 1
        Copy = 2
        Paste = 3
    End Enum

    ' ----- Data object that interfaces with the mobile software 
    Public ProgramDataObject As New PickupTransaction.CDataExtender

    Public Property CustomPrintQue As New List(Of CCustomerBill)

    Public Sub RichEditOperations(tsm As ToolStripMenuItem, oper As RTBOperations )

        Dim myItem As ToolStripMenuItem = CType(tsm, ToolStripMenuItem)
        Dim cms As ContextMenuStrip = CType(myItem.Owner, ContextMenuStrip)
        Dim rtb As RichTextBox = cms.SourceControl 

        Select Case oper

            Case RTBOperations.Cut 
                rtb.Cut 
                
            Case RTBOperations.Copy
                rtb.Copy 

            Case RTBOperations.Paste 
                rtb.Paste 

        End Select

    End Sub

End Module

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleOnCalls
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListViewOnCalls = New System.Windows.Forms.ListView()
        Me.chAccountNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCustomer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'ListViewOnCalls
        '
        Me.ListViewOnCalls.CheckBoxes = True
        Me.ListViewOnCalls.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chAccountNumber, Me.chCustomer, Me.chAddress, Me.chType})
        Me.ListViewOnCalls.FullRowSelect = True
        Me.ListViewOnCalls.Location = New System.Drawing.Point(12, 28)
        Me.ListViewOnCalls.Name = "ListViewOnCalls"
        Me.ListViewOnCalls.Size = New System.Drawing.Size(617, 307)
        Me.ListViewOnCalls.TabIndex = 0
        Me.ListViewOnCalls.UseCompatibleStateImageBehavior = False
        Me.ListViewOnCalls.View = System.Windows.Forms.View.Details
        '
        'chAccountNumber
        '
        Me.chAccountNumber.Text = "Account"
        Me.chAccountNumber.Width = 80
        '
        'chCustomer
        '
        Me.chCustomer.Text = "Customer"
        Me.chCustomer.Width = 150
        '
        'chAddress
        '
        Me.chAddress.Text = "Address"
        Me.chAddress.Width = 225
        '
        'chType
        '
        Me.chType.Text = "Type"
        Me.chType.Width = 80
        '
        'ScheduleOnCalls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 347)
        Me.Controls.Add(Me.ListViewOnCalls)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ScheduleOnCalls"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Schedule On Calls"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListViewOnCalls As System.Windows.Forms.ListView
    Friend WithEvents chAccountNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents chCustomer As System.Windows.Forms.ColumnHeader
    Friend WithEvents chAddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents chType As System.Windows.Forms.ColumnHeader
End Class

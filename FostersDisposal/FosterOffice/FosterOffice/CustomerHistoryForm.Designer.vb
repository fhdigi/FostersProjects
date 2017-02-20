<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerHistoryForm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PrintControlHistory = New DevExpress.XtraPrinting.Control.PrintControl()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBoxYear = New System.Windows.Forms.ComboBox()
        Me.SimpleButtonClose = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'PrintControlHistory
        '
        Me.PrintControlHistory.BackColor = System.Drawing.Color.Empty
        Me.PrintControlHistory.ForeColor = System.Drawing.Color.Empty
        Me.PrintControlHistory.IsMetric = False
        Me.PrintControlHistory.Location = New System.Drawing.Point(15, 44)
        Me.PrintControlHistory.Name = "PrintControlHistory"
        Me.PrintControlHistory.Size = New System.Drawing.Size(662, 446)
        Me.PrintControlHistory.TabIndex = 6
        Me.PrintControlHistory.TooltipFont = New System.Drawing.Font("Tahoma", 8.25!)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Year"
        '
        'ComboBoxYear
        '
        Me.ComboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxYear.FormattingEnabled = True
        Me.ComboBoxYear.Location = New System.Drawing.Point(47, 17)
        Me.ComboBoxYear.Name = "ComboBoxYear"
        Me.ComboBoxYear.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxYear.TabIndex = 4
        '
        'SimpleButtonClose
        '
        Me.SimpleButtonClose.Location = New System.Drawing.Point(602, 496)
        Me.SimpleButtonClose.Name = "SimpleButtonClose"
        Me.SimpleButtonClose.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButtonClose.TabIndex = 7
        Me.SimpleButtonClose.Text = "Close"
        '
        'CustomerHistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 531)
        Me.Controls.Add(Me.SimpleButtonClose)
        Me.Controls.Add(Me.PrintControlHistory)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ComboBoxYear)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustomerHistoryForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Customer History Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintControlHistory As DevExpress.XtraPrinting.Control.PrintControl
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxYear As System.Windows.Forms.ComboBox
    Friend WithEvents SimpleButtonClose As DevExpress.XtraEditors.SimpleButton
End Class

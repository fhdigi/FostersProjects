<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RollOffFees
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonAddNewOption = New System.Windows.Forms.Button()
        Me.ButtonDeleteOption = New System.Windows.Forms.Button()
        Me.ListBoxFees = New System.Windows.Forms.ListBox()
        Me.PropertyGridFees = New System.Windows.Forms.PropertyGrid()
        Me.CRollOffFeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxDumpingFee = New System.Windows.Forms.TextBox()
        CType(Me.CRollOffFeeBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Current Options"
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.Location = New System.Drawing.Point(574, 16)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(87, 30)
        Me.ButtonClose.TabIndex = 7
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = true
        '
        'ButtonAddNewOption
        '
        Me.ButtonAddNewOption.Location = New System.Drawing.Point(12, 313)
        Me.ButtonAddNewOption.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonAddNewOption.Name = "ButtonAddNewOption"
        Me.ButtonAddNewOption.Size = New System.Drawing.Size(145, 30)
        Me.ButtonAddNewOption.TabIndex = 5
        Me.ButtonAddNewOption.Text = "Add New Option..."
        Me.ButtonAddNewOption.UseVisualStyleBackColor = true
        '
        'ButtonDeleteOption
        '
        Me.ButtonDeleteOption.Location = New System.Drawing.Point(413, 313)
        Me.ButtonDeleteOption.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonDeleteOption.Name = "ButtonDeleteOption"
        Me.ButtonDeleteOption.Size = New System.Drawing.Size(145, 30)
        Me.ButtonDeleteOption.TabIndex = 6
        Me.ButtonDeleteOption.Text = "Delete Option..."
        Me.ButtonDeleteOption.UseVisualStyleBackColor = true
        '
        'ListBoxFees
        '
        Me.ListBoxFees.FormattingEnabled = true
        Me.ListBoxFees.ItemHeight = 17
        Me.ListBoxFees.Location = New System.Drawing.Point(12, 114)
        Me.ListBoxFees.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBoxFees.Name = "ListBoxFees"
        Me.ListBoxFees.Size = New System.Drawing.Size(206, 191)
        Me.ListBoxFees.TabIndex = 3
        '
        'PropertyGridFees
        '
        Me.PropertyGridFees.HelpVisible = false
        Me.PropertyGridFees.Location = New System.Drawing.Point(239, 114)
        Me.PropertyGridFees.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PropertyGridFees.Name = "PropertyGridFees"
        Me.PropertyGridFees.Size = New System.Drawing.Size(319, 191)
        Me.PropertyGridFees.TabIndex = 4
        '
        'CRollOffFeeBindingSource
        '
        Me.CRollOffFeeBindingSource.DataSource = GetType(FosterRollOff.CRollOffFee)
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dumping Fee"
        '
        'TextBoxDumpingFee
        '
        Me.TextBoxDumpingFee.Location = New System.Drawing.Point(118, 26)
        Me.TextBoxDumpingFee.Name = "TextBoxDumpingFee"
        Me.TextBoxDumpingFee.Size = New System.Drawing.Size(100, 25)
        Me.TextBoxDumpingFee.TabIndex = 1
        '
        'RollOffFees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 356)
        Me.Controls.Add(Me.TextBoxDumpingFee)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PropertyGridFees)
        Me.Controls.Add(Me.ListBoxFees)
        Me.Controls.Add(Me.ButtonDeleteOption)
        Me.Controls.Add(Me.ButtonAddNewOption)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "RollOffFees"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Roll Off Fees"
        CType(Me.CRollOffFeeBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CRollOffFeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ButtonAddNewOption As System.Windows.Forms.Button
    Friend WithEvents ButtonDeleteOption As System.Windows.Forms.Button
    Friend WithEvents ListBoxFees As System.Windows.Forms.ListBox
    Friend WithEvents PropertyGridFees As System.Windows.Forms.PropertyGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDumpingFee As System.Windows.Forms.TextBox
End Class

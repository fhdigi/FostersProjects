<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConversionForm
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
        Me.DataGridViewConvert = New System.Windows.Forms.DataGridView()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonReadFileProFile = New System.Windows.Forms.Button()
        Me.ButtonConvertData = New System.Windows.Forms.Button()
        Me.LabelConversion = New System.Windows.Forms.Label()
        CType(Me.DataGridViewConvert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewConvert
        '
        Me.DataGridViewConvert.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewConvert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewConvert.Location = New System.Drawing.Point(12, 44)
        Me.DataGridViewConvert.Name = "DataGridViewConvert"
        Me.DataGridViewConvert.Size = New System.Drawing.Size(1269, 601)
        Me.DataGridViewConvert.TabIndex = 0
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.Location = New System.Drawing.Point(1205, 651)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClose.TabIndex = 1
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonReadFileProFile
        '
        Me.ButtonReadFileProFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonReadFileProFile.Location = New System.Drawing.Point(12, 651)
        Me.ButtonReadFileProFile.Name = "ButtonReadFileProFile"
        Me.ButtonReadFileProFile.Size = New System.Drawing.Size(134, 23)
        Me.ButtonReadFileProFile.TabIndex = 1
        Me.ButtonReadFileProFile.Text = "Read FilePro Data..."
        Me.ButtonReadFileProFile.UseVisualStyleBackColor = True
        '
        'ButtonConvertData
        '
        Me.ButtonConvertData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonConvertData.Location = New System.Drawing.Point(1040, 651)
        Me.ButtonConvertData.Name = "ButtonConvertData"
        Me.ButtonConvertData.Size = New System.Drawing.Size(134, 23)
        Me.ButtonConvertData.TabIndex = 2
        Me.ButtonConvertData.Text = "Convert the Data"
        Me.ButtonConvertData.UseVisualStyleBackColor = True
        '
        'LabelConversion
        '
        Me.LabelConversion.AutoSize = True
        Me.LabelConversion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConversion.Location = New System.Drawing.Point(9, 18)
        Me.LabelConversion.Name = "LabelConversion"
        Me.LabelConversion.Size = New System.Drawing.Size(0, 16)
        Me.LabelConversion.TabIndex = 3
        '
        'ConversionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1293, 686)
        Me.Controls.Add(Me.LabelConversion)
        Me.Controls.Add(Me.ButtonConvertData)
        Me.Controls.Add(Me.ButtonReadFileProFile)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.DataGridViewConvert)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConversionForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Conversion Form"
        CType(Me.DataGridViewConvert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewConvert As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ButtonReadFileProFile As System.Windows.Forms.Button
    Friend WithEvents ButtonConvertData As System.Windows.Forms.Button
    Friend WithEvents LabelConversion As System.Windows.Forms.Label
End Class

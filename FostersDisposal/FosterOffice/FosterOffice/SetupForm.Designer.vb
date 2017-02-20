<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetupForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxDatabaseLocation = New System.Windows.Forms.TextBox()
        Me.ButtonBrowse = New System.Windows.Forms.Button()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.OpenFileDialogDB = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxSharedLocation = New System.Windows.Forms.TextBox()
        Me.ButtonBrowseShare = New System.Windows.Forms.Button()
        Me.FolderBrowserDialogShare = New System.Windows.Forms.FolderBrowserDialog()
        Me.TabControlSetup = New System.Windows.Forms.TabControl()
        Me.TabPageGeneral = New System.Windows.Forms.TabPage()
        Me.TextBoxDefaultTaxRate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPageFileLocations = New System.Windows.Forms.TabPage()
        Me.TabControlSetup.SuspendLayout()
        Me.TabPageGeneral.SuspendLayout()
        Me.TabPageFileLocations.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Database Location"
        '
        'TextBoxDatabaseLocation
        '
        Me.TextBoxDatabaseLocation.Location = New System.Drawing.Point(9, 31)
        Me.TextBoxDatabaseLocation.Name = "TextBoxDatabaseLocation"
        Me.TextBoxDatabaseLocation.Size = New System.Drawing.Size(379, 21)
        Me.TextBoxDatabaseLocation.TabIndex = 1
        '
        'ButtonBrowse
        '
        Me.ButtonBrowse.Location = New System.Drawing.Point(313, 58)
        Me.ButtonBrowse.Name = "ButtonBrowse"
        Me.ButtonBrowse.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBrowse.TabIndex = 2
        Me.ButtonBrowse.Text = "Browse..."
        Me.ButtonBrowse.UseVisualStyleBackColor = True
        '
        'ButtonOK
        '
        Me.ButtonOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonOK.Location = New System.Drawing.Point(267, 220)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOK.TabIndex = 1
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCancel.Location = New System.Drawing.Point(348, 220)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 2
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'OpenFileDialogDB
        '
        Me.OpenFileDialogDB.Filter = "Data Files (*.sdf)|*.sdf|All Files (*.*)|*.*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Shared Location"
        '
        'TextBoxSharedLocation
        '
        Me.TextBoxSharedLocation.Location = New System.Drawing.Point(9, 102)
        Me.TextBoxSharedLocation.Name = "TextBoxSharedLocation"
        Me.TextBoxSharedLocation.Size = New System.Drawing.Size(379, 21)
        Me.TextBoxSharedLocation.TabIndex = 7
        '
        'ButtonBrowseShare
        '
        Me.ButtonBrowseShare.Location = New System.Drawing.Point(313, 129)
        Me.ButtonBrowseShare.Name = "ButtonBrowseShare"
        Me.ButtonBrowseShare.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBrowseShare.TabIndex = 8
        Me.ButtonBrowseShare.Text = "Browse..."
        Me.ButtonBrowseShare.UseVisualStyleBackColor = True
        '
        'TabControlSetup
        '
        Me.TabControlSetup.Controls.Add(Me.TabPageGeneral)
        Me.TabControlSetup.Controls.Add(Me.TabPageFileLocations)
        Me.TabControlSetup.Location = New System.Drawing.Point(12, 12)
        Me.TabControlSetup.Name = "TabControlSetup"
        Me.TabControlSetup.SelectedIndex = 0
        Me.TabControlSetup.Size = New System.Drawing.Size(412, 194)
        Me.TabControlSetup.TabIndex = 0
        '
        'TabPageGeneral
        '
        Me.TabPageGeneral.Controls.Add(Me.TextBoxDefaultTaxRate)
        Me.TabPageGeneral.Controls.Add(Me.Label3)
        Me.TabPageGeneral.Location = New System.Drawing.Point(4, 22)
        Me.TabPageGeneral.Name = "TabPageGeneral"
        Me.TabPageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGeneral.Size = New System.Drawing.Size(404, 168)
        Me.TabPageGeneral.TabIndex = 0
        Me.TabPageGeneral.Text = "General"
        Me.TabPageGeneral.UseVisualStyleBackColor = True
        '
        'TextBoxDefaultTaxRate
        '
        Me.TextBoxDefaultTaxRate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.FosterOffice.MySettings.Default, "TaxRate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxDefaultTaxRate.Location = New System.Drawing.Point(112, 18)
        Me.TextBoxDefaultTaxRate.Name = "TextBoxDefaultTaxRate"
        Me.TextBoxDefaultTaxRate.Size = New System.Drawing.Size(85, 21)
        Me.TextBoxDefaultTaxRate.TabIndex = 1
        Me.TextBoxDefaultTaxRate.Text = Global.FosterOffice.MySettings.Default.TaxRate
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Default Tax Rate"
        '
        'TabPageFileLocations
        '
        Me.TabPageFileLocations.Controls.Add(Me.Label1)
        Me.TabPageFileLocations.Controls.Add(Me.Label2)
        Me.TabPageFileLocations.Controls.Add(Me.TextBoxDatabaseLocation)
        Me.TabPageFileLocations.Controls.Add(Me.ButtonBrowseShare)
        Me.TabPageFileLocations.Controls.Add(Me.TextBoxSharedLocation)
        Me.TabPageFileLocations.Controls.Add(Me.ButtonBrowse)
        Me.TabPageFileLocations.Location = New System.Drawing.Point(4, 22)
        Me.TabPageFileLocations.Name = "TabPageFileLocations"
        Me.TabPageFileLocations.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageFileLocations.Size = New System.Drawing.Size(404, 168)
        Me.TabPageFileLocations.TabIndex = 1
        Me.TabPageFileLocations.Text = "File Locations"
        Me.TabPageFileLocations.UseVisualStyleBackColor = True
        '
        'SetupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 253)
        Me.Controls.Add(Me.TabControlSetup)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonOK)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SetupForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Setup Form"
        Me.TabControlSetup.ResumeLayout(False)
        Me.TabPageGeneral.ResumeLayout(False)
        Me.TabPageGeneral.PerformLayout()
        Me.TabPageFileLocations.ResumeLayout(False)
        Me.TabPageFileLocations.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDatabaseLocation As System.Windows.Forms.TextBox
    Friend WithEvents ButtonBrowse As System.Windows.Forms.Button
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialogDB As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSharedLocation As System.Windows.Forms.TextBox
    Friend WithEvents ButtonBrowseShare As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialogShare As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TabControlSetup As System.Windows.Forms.TabControl
    Friend WithEvents TabPageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents TextBoxDefaultTaxRate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabPageFileLocations As System.Windows.Forms.TabPage
End Class

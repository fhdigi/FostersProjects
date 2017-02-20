<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddToWaitingList
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
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonAddNewCustomer = New System.Windows.Forms.Button()
        Me.DateTimePickerCallTime = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxRollOffUse = New System.Windows.Forms.TextBox()
        Me.ComboBoxRollOff = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxNotes = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxServiceLastName = New System.Windows.Forms.TextBox()
        Me.TextBoxServiceFirstName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxZipCode = New System.Windows.Forms.TextBox()
        Me.TextBoxState = New System.Windows.Forms.TextBox()
        Me.TextBoxCity = New System.Windows.Forms.TextBox()
        Me.TextBoxAddress = New System.Windows.Forms.TextBox()
        Me.ComboBoxCustomers = New System.Windows.Forms.ComboBox()
        Me.ListBoxPreviousAddresses = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonEditCustomer = New System.Windows.Forms.Button()
        Me.LabelCustNotes = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Date Called"
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCancel.Location = New System.Drawing.Point(661, 484)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(87, 30)
        Me.ButtonCancel.TabIndex = 15
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSave.Location = New System.Drawing.Point(568, 484)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(87, 30)
        Me.ButtonSave.TabIndex = 14
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonAddNewCustomer
        '
        Me.ButtonAddNewCustomer.Location = New System.Drawing.Point(401, 25)
        Me.ButtonAddNewCustomer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonAddNewCustomer.Name = "ButtonAddNewCustomer"
        Me.ButtonAddNewCustomer.Size = New System.Drawing.Size(168, 30)
        Me.ButtonAddNewCustomer.TabIndex = 2
        Me.ButtonAddNewCustomer.TabStop = False
        Me.ButtonAddNewCustomer.Text = "Add New Customer..."
        Me.ButtonAddNewCustomer.UseVisualStyleBackColor = True
        '
        'DateTimePickerCallTime
        '
        Me.DateTimePickerCallTime.Location = New System.Drawing.Point(78, 306)
        Me.DateTimePickerCallTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePickerCallTime.Name = "DateTimePickerCallTime"
        Me.DateTimePickerCallTime.Size = New System.Drawing.Size(233, 25)
        Me.DateTimePickerCallTime.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Customer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(330, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Roll Off Size "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(512, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Use of Roll Off"
        '
        'TextBoxRollOffUse
        '
        Me.TextBoxRollOffUse.Location = New System.Drawing.Point(515, 305)
        Me.TextBoxRollOffUse.Multiline = True
        Me.TextBoxRollOffUse.Name = "TextBoxRollOffUse"
        Me.TextBoxRollOffUse.Size = New System.Drawing.Size(233, 26)
        Me.TextBoxRollOffUse.TabIndex = 11
        '
        'ComboBoxRollOff
        '
        Me.ComboBoxRollOff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRollOff.FormattingEnabled = True
        Me.ComboBoxRollOff.Location = New System.Drawing.Point(333, 306)
        Me.ComboBoxRollOff.Name = "ComboBoxRollOff"
        Me.ComboBoxRollOff.Size = New System.Drawing.Size(161, 25)
        Me.ComboBoxRollOff.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Notes / Call Log"
        '
        'TextBoxNotes
        '
        Me.TextBoxNotes.Location = New System.Drawing.Point(78, 364)
        Me.TextBoxNotes.Multiline = True
        Me.TextBoxNotes.Name = "TextBoxNotes"
        Me.TextBoxNotes.Size = New System.Drawing.Size(670, 81)
        Me.TextBoxNotes.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TextBoxServiceLastName)
        Me.GroupBox1.Controls.Add(Me.TextBoxServiceFirstName)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBoxZipCode)
        Me.GroupBox1.Controls.Add(Me.TextBoxState)
        Me.GroupBox1.Controls.Add(Me.TextBoxCity)
        Me.GroupBox1.Controls.Add(Me.TextBoxAddress)
        Me.GroupBox1.Location = New System.Drawing.Point(77, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 196)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Service Location"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(164, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 17)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Last Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 17)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "First Name"
        '
        'TextBoxServiceLastName
        '
        Me.TextBoxServiceLastName.Location = New System.Drawing.Point(167, 47)
        Me.TextBoxServiceLastName.Name = "TextBoxServiceLastName"
        Me.TextBoxServiceLastName.Size = New System.Drawing.Size(145, 25)
        Me.TextBoxServiceLastName.TabIndex = 3
        '
        'TextBoxServiceFirstName
        '
        Me.TextBoxServiceFirstName.Location = New System.Drawing.Point(21, 47)
        Me.TextBoxServiceFirstName.Name = "TextBoxServiceFirstName"
        Me.TextBoxServiceFirstName.Size = New System.Drawing.Size(140, 25)
        Me.TextBoxServiceFirstName.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(240, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 17)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Zip Code"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(191, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "State"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "City"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Address"
        '
        'TextBoxZipCode
        '
        Me.TextBoxZipCode.Location = New System.Drawing.Point(243, 154)
        Me.TextBoxZipCode.Name = "TextBoxZipCode"
        Me.TextBoxZipCode.Size = New System.Drawing.Size(69, 25)
        Me.TextBoxZipCode.TabIndex = 11
        Me.TextBoxZipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxState
        '
        Me.TextBoxState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxState.Location = New System.Drawing.Point(194, 154)
        Me.TextBoxState.Name = "TextBoxState"
        Me.TextBoxState.Size = New System.Drawing.Size(34, 25)
        Me.TextBoxState.TabIndex = 9
        Me.TextBoxState.Text = "NY"
        Me.TextBoxState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxCity
        '
        Me.TextBoxCity.Location = New System.Drawing.Point(21, 154)
        Me.TextBoxCity.Name = "TextBoxCity"
        Me.TextBoxCity.Size = New System.Drawing.Size(167, 25)
        Me.TextBoxCity.TabIndex = 7
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Location = New System.Drawing.Point(21, 102)
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(291, 25)
        Me.TextBoxAddress.TabIndex = 5
        '
        'ComboBoxCustomers
        '
        Me.ComboBoxCustomers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxCustomers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxCustomers.FormattingEnabled = True
        Me.ComboBoxCustomers.Location = New System.Drawing.Point(77, 29)
        Me.ComboBoxCustomers.Name = "ComboBoxCustomers"
        Me.ComboBoxCustomers.Size = New System.Drawing.Size(307, 25)
        Me.ComboBoxCustomers.TabIndex = 1
        '
        'ListBoxPreviousAddresses
        '
        Me.ListBoxPreviousAddresses.FormattingEnabled = True
        Me.ListBoxPreviousAddresses.ItemHeight = 17
        Me.ListBoxPreviousAddresses.Location = New System.Drawing.Point(432, 98)
        Me.ListBoxPreviousAddresses.Name = "ListBoxPreviousAddresses"
        Me.ListBoxPreviousAddresses.Size = New System.Drawing.Size(315, 157)
        Me.ListBoxPreviousAddresses.TabIndex = 5
        Me.ListBoxPreviousAddresses.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(429, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(167, 17)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Previous Service Addresses"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FosterRollOff.My.Resources.Resources._005_Task_48x48_72
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'ButtonEditCustomer
        '
        Me.ButtonEditCustomer.Location = New System.Drawing.Point(580, 25)
        Me.ButtonEditCustomer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonEditCustomer.Name = "ButtonEditCustomer"
        Me.ButtonEditCustomer.Size = New System.Drawing.Size(168, 29)
        Me.ButtonEditCustomer.TabIndex = 17
        Me.ButtonEditCustomer.TabStop = False
        Me.ButtonEditCustomer.Text = "Edit Customer..."
        Me.ButtonEditCustomer.UseVisualStyleBackColor = True
        '
        'LabelCustNotes
        '
        Me.LabelCustNotes.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCustNotes.ForeColor = System.Drawing.Color.Red
        Me.LabelCustNotes.Location = New System.Drawing.Point(78, 462)
        Me.LabelCustNotes.Name = "LabelCustNotes"
        Me.LabelCustNotes.Size = New System.Drawing.Size(484, 66)
        Me.LabelCustNotes.TabIndex = 18
        '
        'AddToWaitingList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 555)
        Me.Controls.Add(Me.LabelCustNotes)
        Me.Controls.Add(Me.ButtonEditCustomer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ListBoxPreviousAddresses)
        Me.Controls.Add(Me.ComboBoxCustomers)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxNotes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBoxRollOff)
        Me.Controls.Add(Me.TextBoxRollOffUse)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePickerCallTime)
        Me.Controls.Add(Me.ButtonAddNewCustomer)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddToWaitingList"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add to Waiting List"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonAddNewCustomer As System.Windows.Forms.Button
    Friend WithEvents DateTimePickerCallTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxRollOffUse As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxRollOff As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNotes As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxZipCode As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxState As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCity As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAddress As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxCustomers As System.Windows.Forms.ComboBox
    Friend WithEvents ListBoxPreviousAddresses As System.Windows.Forms.ListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBoxServiceLastName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxServiceFirstName As System.Windows.Forms.TextBox
    Friend WithEvents ButtonEditCustomer As System.Windows.Forms.Button
    Friend WithEvents LabelCustNotes As System.Windows.Forms.Label
End Class

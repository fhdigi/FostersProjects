<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerData
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
        Dim AddressLabel1 As System.Windows.Forms.Label
        Dim CityLabel1 As System.Windows.Forms.Label
        Dim FirstNameLabel1 As System.Windows.Forms.Label
        Dim LastNameLabel1 As System.Windows.Forms.Label
        Dim StateLabel1 As System.Windows.Forms.Label
        Dim ZipCodeLabel1 As System.Windows.Forms.Label
        Dim BusinessPhoneLabel As System.Windows.Forms.Label
        Dim HomePhoneLabel As System.Windows.Forms.Label
        Dim CustomerNumberLabel As System.Windows.Forms.Label
        Dim ContactNameLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.GroupBoxBilling = New System.Windows.Forms.GroupBox()
        Me.BillingAddressTextBox = New System.Windows.Forms.TextBox()
        Me.BillingCityTextBox = New System.Windows.Forms.TextBox()
        Me.BillingFirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.BillingLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.BillingStateTextBox = New System.Windows.Forms.TextBox()
        Me.BillingZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerNumberTextBox = New System.Windows.Forms.TextBox()
        Me.HomePhoneTextBox = New System.Windows.Forms.TextBox()
        Me.BusinessPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNameTextBox = New System.Windows.Forms.TextBox()
        Me.CheckBoxCollections = New System.Windows.Forms.CheckBox()
        Me.TextBoxTaxRate = New System.Windows.Forms.TextBox()
        Me.TextBoxCurrentBalance = New System.Windows.Forms.TextBox()
        Me.DateTimePickerCollectionBalance = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxNotes = New System.Windows.Forms.TextBox()
        AddressLabel1 = New System.Windows.Forms.Label()
        CityLabel1 = New System.Windows.Forms.Label()
        FirstNameLabel1 = New System.Windows.Forms.Label()
        LastNameLabel1 = New System.Windows.Forms.Label()
        StateLabel1 = New System.Windows.Forms.Label()
        ZipCodeLabel1 = New System.Windows.Forms.Label()
        BusinessPhoneLabel = New System.Windows.Forms.Label()
        HomePhoneLabel = New System.Windows.Forms.Label()
        CustomerNumberLabel = New System.Windows.Forms.Label()
        ContactNameLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Me.GroupBoxBilling.SuspendLayout
        Me.SuspendLayout
        '
        'AddressLabel1
        '
        AddressLabel1.AutoSize = true
        AddressLabel1.Location = New System.Drawing.Point(33, 72)
        AddressLabel1.Name = "AddressLabel1"
        AddressLabel1.Size = New System.Drawing.Size(59, 17)
        AddressLabel1.TabIndex = 4
        AddressLabel1.Text = "Address:"
        '
        'CityLabel1
        '
        CityLabel1.AutoSize = true
        CityLabel1.Location = New System.Drawing.Point(56, 105)
        CityLabel1.Name = "CityLabel1"
        CityLabel1.Size = New System.Drawing.Size(32, 17)
        CityLabel1.TabIndex = 6
        CityLabel1.Text = "City:"
        '
        'FirstNameLabel1
        '
        FirstNameLabel1.AutoSize = true
        FirstNameLabel1.Location = New System.Drawing.Point(19, 39)
        FirstNameLabel1.Name = "FirstNameLabel1"
        FirstNameLabel1.Size = New System.Drawing.Size(74, 17)
        FirstNameLabel1.TabIndex = 0
        FirstNameLabel1.Text = "First Name:"
        '
        'LastNameLabel1
        '
        LastNameLabel1.AutoSize = true
        LastNameLabel1.Location = New System.Drawing.Point(220, 35)
        LastNameLabel1.Name = "LastNameLabel1"
        LastNameLabel1.Size = New System.Drawing.Size(73, 17)
        LastNameLabel1.TabIndex = 2
        LastNameLabel1.Text = "Last Name:"
        '
        'StateLabel1
        '
        StateLabel1.AutoSize = true
        StateLabel1.Location = New System.Drawing.Point(222, 106)
        StateLabel1.Name = "StateLabel1"
        StateLabel1.Size = New System.Drawing.Size(40, 17)
        StateLabel1.TabIndex = 8
        StateLabel1.Text = "State:"
        '
        'ZipCodeLabel1
        '
        ZipCodeLabel1.AutoSize = true
        ZipCodeLabel1.Location = New System.Drawing.Point(332, 106)
        ZipCodeLabel1.Name = "ZipCodeLabel1"
        ZipCodeLabel1.Size = New System.Drawing.Size(64, 17)
        ZipCodeLabel1.TabIndex = 10
        ZipCodeLabel1.Text = "Zip Code:"
        '
        'BusinessPhoneLabel
        '
        BusinessPhoneLabel.AutoSize = true
        BusinessPhoneLabel.Location = New System.Drawing.Point(335, 60)
        BusinessPhoneLabel.Name = "BusinessPhoneLabel"
        BusinessPhoneLabel.Size = New System.Drawing.Size(100, 17)
        BusinessPhoneLabel.TabIndex = 6
        BusinessPhoneLabel.Text = "Business Phone:"
        '
        'HomePhoneLabel
        '
        HomePhoneLabel.AutoSize = true
        HomePhoneLabel.Location = New System.Drawing.Point(351, 25)
        HomePhoneLabel.Name = "HomePhoneLabel"
        HomePhoneLabel.Size = New System.Drawing.Size(86, 17)
        HomePhoneLabel.TabIndex = 4
        HomePhoneLabel.Text = "Home Phone:"
        '
        'CustomerNumberLabel
        '
        CustomerNumberLabel.AutoSize = true
        CustomerNumberLabel.Location = New System.Drawing.Point(14, 25)
        CustomerNumberLabel.Name = "CustomerNumberLabel"
        CustomerNumberLabel.Size = New System.Drawing.Size(119, 17)
        CustomerNumberLabel.TabIndex = 0
        CustomerNumberLabel.Text = "Customer Number:"
        '
        'ContactNameLabel
        '
        ContactNameLabel.AutoSize = true
        ContactNameLabel.Location = New System.Drawing.Point(35, 60)
        ContactNameLabel.Name = "ContactNameLabel"
        ContactNameLabel.Size = New System.Drawing.Size(94, 17)
        ContactNameLabel.TabIndex = 2
        ContactNameLabel.Text = "Contact Name:"
        '
        'Label1
        '
        Label1.AutoSize = true
        Label1.Location = New System.Drawing.Point(67, 92)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(60, 17)
        Label1.TabIndex = 8
        Label1.Text = "Tax Rate:"
        '
        'Label2
        '
        Label2.AutoSize = true
        Label2.Location = New System.Drawing.Point(34, 455)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(99, 17)
        Label2.TabIndex = 14
        Label2.Text = "Current Balance"
        '
        'Label3
        '
        Label3.AutoSize = true
        Label3.Location = New System.Drawing.Point(215, 455)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(40, 17)
        Label3.TabIndex = 16
        Label3.Text = "As Of"
        '
        'Label4
        '
        Label4.AutoSize = true
        Label4.Location = New System.Drawing.Point(14, 301)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(43, 17)
        Label4.TabIndex = 11
        Label4.Text = "Notes"
        '
        'ButtonSave
        '
        Me.ButtonSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ButtonSave.Location = New System.Drawing.Point(379, 497)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(87, 30)
        Me.ButtonSave.TabIndex = 18
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = true
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ButtonCancel.Location = New System.Drawing.Point(473, 497)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(87, 30)
        Me.ButtonCancel.TabIndex = 19
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = true
        '
        'GroupBoxBilling
        '
        Me.GroupBoxBilling.Controls.Add(Me.BillingAddressTextBox)
        Me.GroupBoxBilling.Controls.Add(Me.BillingCityTextBox)
        Me.GroupBoxBilling.Controls.Add(Me.BillingFirstNameTextBox)
        Me.GroupBoxBilling.Controls.Add(Me.BillingLastNameTextBox)
        Me.GroupBoxBilling.Controls.Add(Me.BillingStateTextBox)
        Me.GroupBoxBilling.Controls.Add(Me.BillingZipCodeTextBox)
        Me.GroupBoxBilling.Controls.Add(FirstNameLabel1)
        Me.GroupBoxBilling.Controls.Add(LastNameLabel1)
        Me.GroupBoxBilling.Controls.Add(AddressLabel1)
        Me.GroupBoxBilling.Controls.Add(CityLabel1)
        Me.GroupBoxBilling.Controls.Add(ZipCodeLabel1)
        Me.GroupBoxBilling.Controls.Add(StateLabel1)
        Me.GroupBoxBilling.Location = New System.Drawing.Point(38, 144)
        Me.GroupBoxBilling.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBoxBilling.Name = "GroupBoxBilling"
        Me.GroupBoxBilling.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBoxBilling.Size = New System.Drawing.Size(519, 149)
        Me.GroupBoxBilling.TabIndex = 10
        Me.GroupBoxBilling.TabStop = false
        Me.GroupBoxBilling.Text = "Billing Information "
        '
        'BillingAddressTextBox
        '
        Me.BillingAddressTextBox.Location = New System.Drawing.Point(98, 68)
        Me.BillingAddressTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BillingAddressTextBox.Name = "BillingAddressTextBox"
        Me.BillingAddressTextBox.Size = New System.Drawing.Size(391, 25)
        Me.BillingAddressTextBox.TabIndex = 5
        '
        'BillingCityTextBox
        '
        Me.BillingCityTextBox.Location = New System.Drawing.Point(98, 101)
        Me.BillingCityTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BillingCityTextBox.Name = "BillingCityTextBox"
        Me.BillingCityTextBox.Size = New System.Drawing.Size(116, 25)
        Me.BillingCityTextBox.TabIndex = 7
        '
        'BillingFirstNameTextBox
        '
        Me.BillingFirstNameTextBox.Location = New System.Drawing.Point(98, 35)
        Me.BillingFirstNameTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BillingFirstNameTextBox.Name = "BillingFirstNameTextBox"
        Me.BillingFirstNameTextBox.Size = New System.Drawing.Size(116, 25)
        Me.BillingFirstNameTextBox.TabIndex = 1
        '
        'BillingLastNameTextBox
        '
        Me.BillingLastNameTextBox.Location = New System.Drawing.Point(298, 31)
        Me.BillingLastNameTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BillingLastNameTextBox.Name = "BillingLastNameTextBox"
        Me.BillingLastNameTextBox.Size = New System.Drawing.Size(191, 25)
        Me.BillingLastNameTextBox.TabIndex = 3
        '
        'BillingStateTextBox
        '
        Me.BillingStateTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BillingStateTextBox.Location = New System.Drawing.Point(268, 102)
        Me.BillingStateTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BillingStateTextBox.Name = "BillingStateTextBox"
        Me.BillingStateTextBox.Size = New System.Drawing.Size(58, 25)
        Me.BillingStateTextBox.TabIndex = 9
        '
        'BillingZipCodeTextBox
        '
        Me.BillingZipCodeTextBox.Location = New System.Drawing.Point(402, 103)
        Me.BillingZipCodeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BillingZipCodeTextBox.Name = "BillingZipCodeTextBox"
        Me.BillingZipCodeTextBox.Size = New System.Drawing.Size(87, 25)
        Me.BillingZipCodeTextBox.TabIndex = 11
        '
        'CustomerNumberTextBox
        '
        Me.CustomerNumberTextBox.Enabled = false
        Me.CustomerNumberTextBox.Location = New System.Drawing.Point(134, 21)
        Me.CustomerNumberTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CustomerNumberTextBox.Name = "CustomerNumberTextBox"
        Me.CustomerNumberTextBox.Size = New System.Drawing.Size(142, 25)
        Me.CustomerNumberTextBox.TabIndex = 1
        '
        'HomePhoneTextBox
        '
        Me.HomePhoneTextBox.Location = New System.Drawing.Point(441, 21)
        Me.HomePhoneTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.HomePhoneTextBox.Name = "HomePhoneTextBox"
        Me.HomePhoneTextBox.Size = New System.Drawing.Size(116, 25)
        Me.HomePhoneTextBox.TabIndex = 5
        '
        'BusinessPhoneTextBox
        '
        Me.BusinessPhoneTextBox.Location = New System.Drawing.Point(441, 56)
        Me.BusinessPhoneTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BusinessPhoneTextBox.Name = "BusinessPhoneTextBox"
        Me.BusinessPhoneTextBox.Size = New System.Drawing.Size(116, 25)
        Me.BusinessPhoneTextBox.TabIndex = 7
        '
        'ContactNameTextBox
        '
        Me.ContactNameTextBox.Location = New System.Drawing.Point(134, 56)
        Me.ContactNameTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ContactNameTextBox.Name = "ContactNameTextBox"
        Me.ContactNameTextBox.Size = New System.Drawing.Size(142, 25)
        Me.ContactNameTextBox.TabIndex = 3
        '
        'CheckBoxCollections
        '
        Me.CheckBoxCollections.AutoSize = true
        Me.CheckBoxCollections.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CheckBoxCollections.ForeColor = System.Drawing.Color.Blue
        Me.CheckBoxCollections.Location = New System.Drawing.Point(16, 434)
        Me.CheckBoxCollections.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxCollections.Name = "CheckBoxCollections"
        Me.CheckBoxCollections.Size = New System.Drawing.Size(193, 17)
        Me.CheckBoxCollections.TabIndex = 13
        Me.CheckBoxCollections.Text = "Send Customer To Collections"
        Me.CheckBoxCollections.UseVisualStyleBackColor = true
        '
        'TextBoxTaxRate
        '
        Me.TextBoxTaxRate.Location = New System.Drawing.Point(134, 89)
        Me.TextBoxTaxRate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxTaxRate.Name = "TextBoxTaxRate"
        Me.TextBoxTaxRate.Size = New System.Drawing.Size(60, 25)
        Me.TextBoxTaxRate.TabIndex = 9
        Me.TextBoxTaxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxCurrentBalance
        '
        Me.TextBoxCurrentBalance.Location = New System.Drawing.Point(139, 452)
        Me.TextBoxCurrentBalance.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxCurrentBalance.Name = "TextBoxCurrentBalance"
        Me.TextBoxCurrentBalance.Size = New System.Drawing.Size(70, 25)
        Me.TextBoxCurrentBalance.TabIndex = 15
        '
        'DateTimePickerCollectionBalance
        '
        Me.DateTimePickerCollectionBalance.Location = New System.Drawing.Point(261, 452)
        Me.DateTimePickerCollectionBalance.Name = "DateTimePickerCollectionBalance"
        Me.DateTimePickerCollectionBalance.Size = New System.Drawing.Size(234, 25)
        Me.DateTimePickerCollectionBalance.TabIndex = 17
        '
        'TextBoxNotes
        '
        Me.TextBoxNotes.Location = New System.Drawing.Point(17, 322)
        Me.TextBoxNotes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxNotes.Multiline = true
        Me.TextBoxNotes.Name = "TextBoxNotes"
        Me.TextBoxNotes.Size = New System.Drawing.Size(540, 98)
        Me.TextBoxNotes.TabIndex = 12
        '
        'CustomerData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 540)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.TextBoxNotes)
        Me.Controls.Add(Me.DateTimePickerCollectionBalance)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.TextBoxCurrentBalance)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TextBoxTaxRate)
        Me.Controls.Add(Me.CheckBoxCollections)
        Me.Controls.Add(ContactNameLabel)
        Me.Controls.Add(Me.ContactNameTextBox)
        Me.Controls.Add(Me.BusinessPhoneTextBox)
        Me.Controls.Add(Me.HomePhoneTextBox)
        Me.Controls.Add(Me.CustomerNumberTextBox)
        Me.Controls.Add(Me.GroupBoxBilling)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(CustomerNumberLabel)
        Me.Controls.Add(HomePhoneLabel)
        Me.Controls.Add(BusinessPhoneLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "CustomerData"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Data"
        Me.GroupBoxBilling.ResumeLayout(false)
        Me.GroupBoxBilling.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBoxBilling As System.Windows.Forms.GroupBox
    Friend WithEvents BillingAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BillingCityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BillingFirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BillingLastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BillingStateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BillingZipCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HomePhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BusinessPhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxCollections As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxTaxRate As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCurrentBalance As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePickerCollectionBalance As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBoxNotes As System.Windows.Forms.TextBox
End Class

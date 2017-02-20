<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentalCustomerEntry
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
        Dim Billing_FirstNameLabel As System.Windows.Forms.Label
        Dim Billing_LastNameLabel As System.Windows.Forms.Label
        Dim BusinessPhoneLabel As System.Windows.Forms.Label
        Dim CustomerNumberLabel As System.Windows.Forms.Label
        Dim HomePhoneLabel As System.Windows.Forms.Label
        Dim RouteLocation_AddressLabel As System.Windows.Forms.Label
        Dim RouteLocation_CityLabel As System.Windows.Forms.Label
        Dim RouteLocation_StateLabel As System.Windows.Forms.Label
        Dim RouteLocation_ZipCodeLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim SequenceNumberLabel As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim CardboardRentalLabel As System.Windows.Forms.Label
        Dim Cart90GallonRentalLabel As System.Windows.Forms.Label
        Dim RollOffRentalLabel As System.Windows.Forms.Label
        Dim DumpsterRentalLabel As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim Label23 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label24 As System.Windows.Forms.Label
        Dim Label25 As System.Windows.Forms.Label
        Dim Label26 As System.Windows.Forms.Label
        Dim Label27 As System.Windows.Forms.Label
        Dim Label28 As System.Windows.Forms.Label
        Dim Label29 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Me.Billing_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Billing_CityTextBox = New System.Windows.Forms.TextBox()
        Me.Billing_FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Billing_LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Billing_StateTextBox = New System.Windows.Forms.TextBox()
        Me.Billing_ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.BusinessPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerNumberTextBox = New System.Windows.Forms.TextBox()
        Me.HomePhoneTextBox = New System.Windows.Forms.TextBox()
        Me.RouteLocation_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.RouteLocation_CityTextBox = New System.Windows.Forms.TextBox()
        Me.RouteLocation_FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.RouteLocation_LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.RouteLocation_StateTextBox = New System.Windows.Forms.TextBox()
        Me.RouteLocation_ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBoxRoute = New System.Windows.Forms.GroupBox()
        Me.CheckBoxSameAsRoute = New System.Windows.Forms.CheckBox()
        Me.GroupBoxBillingAddress = New System.Windows.Forms.GroupBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.TabControlCustomer = New System.Windows.Forms.TabControl()
        Me.TabPageCustomerInfo = New System.Windows.Forms.TabPage()
        Me.CheckBoxPrintBill = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSendBillEmail = New System.Windows.Forms.CheckBox()
        Me.TextBoxOwner = New System.Windows.Forms.TextBox()
        Me.TextBoxContact = New System.Windows.Forms.TextBox()
        Me.TextBoxLMB = New System.Windows.Forms.TextBox()
        Me.TextBoxMonthsToBill = New System.Windows.Forms.TextBox()
        Me.TextBoxFax = New System.Windows.Forms.TextBox()
        Me.TextBoxEMailAddress = New System.Windows.Forms.TextBox()
        Me.TabPagePickupDays = New System.Windows.Forms.TabPage()
        Me.ComboBoxCartPUCharge = New System.Windows.Forms.ComboBox()
        Me.CheckBoxRequiresPaperwork = New System.Windows.Forms.CheckBox()
        Me.ButtonDeleteSelectedLine = New System.Windows.Forms.Button()
        Me.CheckBoxUsePOForAll = New System.Windows.Forms.CheckBox()
        Me.ComboBoxRecyclePUCharge = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCardboardPUCharge = New System.Windows.Forms.ComboBox()
        Me.ComboBoxDumpsterPUCharge = New System.Windows.Forms.ComboBox()
        Me.DataGridViewPickupDays = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSeqNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colDays = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colLoadType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colDumpsterSize = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colRoute = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMisc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTruckNotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBoxTaxRate = New System.Windows.Forms.TextBox()
        Me.TextBoxRecycleRental = New System.Windows.Forms.TextBox()
        Me.CardboardRentalTextBox = New System.Windows.Forms.TextBox()
        Me.Cart90GallonRentalTextBox = New System.Windows.Forms.TextBox()
        Me.RollOffRentalTextBox = New System.Windows.Forms.TextBox()
        Me.DumpsterRentalTextBox = New System.Windows.Forms.TextBox()
        Me.TextBoxRecycleCharge = New System.Windows.Forms.TextBox()
        Me.TextBoxCardboardCharge = New System.Windows.Forms.TextBox()
        Me.TextBox90GallonCarts = New System.Windows.Forms.TextBox()
        Me.TextBoxRollOffCharge = New System.Windows.Forms.TextBox()
        Me.TextBoxDumpsterCharge = New System.Windows.Forms.TextBox()
        Me.ComboBoxRouteNumber = New System.Windows.Forms.ComboBox()
        Me.SequenceNumberTextBox = New System.Windows.Forms.TextBox()
        Me.TextBoxPO = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TabPageComments = New System.Windows.Forms.TabPage()
        Me.RichTextBoxComments = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStripRTB = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPageCloseAccount = New System.Windows.Forms.TabPage()
        Me.CheckBoxInactive = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RichTextBoxCollectionNotes = New System.Windows.Forms.RichTextBox()
        Me.CheckBoxSentToCollections = New System.Windows.Forms.CheckBox()
        Me.ButtonSaveAndClose = New System.Windows.Forms.Button()
        Billing_FirstNameLabel = New System.Windows.Forms.Label()
        Billing_LastNameLabel = New System.Windows.Forms.Label()
        BusinessPhoneLabel = New System.Windows.Forms.Label()
        CustomerNumberLabel = New System.Windows.Forms.Label()
        HomePhoneLabel = New System.Windows.Forms.Label()
        RouteLocation_AddressLabel = New System.Windows.Forms.Label()
        RouteLocation_CityLabel = New System.Windows.Forms.Label()
        RouteLocation_StateLabel = New System.Windows.Forms.Label()
        RouteLocation_ZipCodeLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        SequenceNumberLabel = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        CardboardRentalLabel = New System.Windows.Forms.Label()
        Cart90GallonRentalLabel = New System.Windows.Forms.Label()
        RollOffRentalLabel = New System.Windows.Forms.Label()
        DumpsterRentalLabel = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        Label23 = New System.Windows.Forms.Label()
        Label20 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label24 = New System.Windows.Forms.Label()
        Label25 = New System.Windows.Forms.Label()
        Label26 = New System.Windows.Forms.Label()
        Label27 = New System.Windows.Forms.Label()
        Label28 = New System.Windows.Forms.Label()
        Label29 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        CType(Me.CustomerBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBoxRoute.SuspendLayout
        Me.GroupBoxBillingAddress.SuspendLayout
        Me.TabControlCustomer.SuspendLayout
        Me.TabPageCustomerInfo.SuspendLayout
        Me.TabPagePickupDays.SuspendLayout
        CType(Me.DataGridViewPickupDays,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPageComments.SuspendLayout
        Me.ContextMenuStripRTB.SuspendLayout
        Me.TabPageCloseAccount.SuspendLayout
        Me.SuspendLayout
        '
        'Billing_FirstNameLabel
        '
        Billing_FirstNameLabel.AutoSize = true
        Billing_FirstNameLabel.Location = New System.Drawing.Point(12, 26)
        Billing_FirstNameLabel.Name = "Billing_FirstNameLabel"
        Billing_FirstNameLabel.Size = New System.Drawing.Size(58, 13)
        Billing_FirstNameLabel.TabIndex = 0
        Billing_FirstNameLabel.Text = "First Name"
        '
        'Billing_LastNameLabel
        '
        Billing_LastNameLabel.AutoSize = true
        Billing_LastNameLabel.Location = New System.Drawing.Point(124, 26)
        Billing_LastNameLabel.Name = "Billing_LastNameLabel"
        Billing_LastNameLabel.Size = New System.Drawing.Size(57, 13)
        Billing_LastNameLabel.TabIndex = 2
        Billing_LastNameLabel.Text = "Last Name"
        '
        'BusinessPhoneLabel
        '
        BusinessPhoneLabel.AutoSize = true
        BusinessPhoneLabel.Location = New System.Drawing.Point(194, 279)
        BusinessPhoneLabel.Name = "BusinessPhoneLabel"
        BusinessPhoneLabel.Size = New System.Drawing.Size(81, 13)
        BusinessPhoneLabel.TabIndex = 10
        BusinessPhoneLabel.Text = "Business Phone"
        '
        'CustomerNumberLabel
        '
        CustomerNumberLabel.AutoSize = true
        CustomerNumberLabel.Location = New System.Drawing.Point(13, 252)
        CustomerNumberLabel.Name = "CustomerNumberLabel"
        CustomerNumberLabel.Size = New System.Drawing.Size(86, 13)
        CustomerNumberLabel.TabIndex = 2
        CustomerNumberLabel.Text = "Account Number"
        '
        'HomePhoneLabel
        '
        HomePhoneLabel.AutoSize = true
        HomePhoneLabel.Location = New System.Drawing.Point(208, 252)
        HomePhoneLabel.Name = "HomePhoneLabel"
        HomePhoneLabel.Size = New System.Drawing.Size(67, 13)
        HomePhoneLabel.TabIndex = 8
        HomePhoneLabel.Text = "Home Phone"
        '
        'RouteLocation_AddressLabel
        '
        RouteLocation_AddressLabel.AutoSize = true
        RouteLocation_AddressLabel.Location = New System.Drawing.Point(12, 77)
        RouteLocation_AddressLabel.Name = "RouteLocation_AddressLabel"
        RouteLocation_AddressLabel.Size = New System.Drawing.Size(37, 13)
        RouteLocation_AddressLabel.TabIndex = 5
        RouteLocation_AddressLabel.Text = "Street"
        '
        'RouteLocation_CityLabel
        '
        RouteLocation_CityLabel.AutoSize = true
        RouteLocation_CityLabel.Location = New System.Drawing.Point(12, 126)
        RouteLocation_CityLabel.Name = "RouteLocation_CityLabel"
        RouteLocation_CityLabel.Size = New System.Drawing.Size(26, 13)
        RouteLocation_CityLabel.TabIndex = 7
        RouteLocation_CityLabel.Text = "City"
        '
        'RouteLocation_StateLabel
        '
        RouteLocation_StateLabel.AutoSize = true
        RouteLocation_StateLabel.Location = New System.Drawing.Point(118, 126)
        RouteLocation_StateLabel.Name = "RouteLocation_StateLabel"
        RouteLocation_StateLabel.Size = New System.Drawing.Size(33, 13)
        RouteLocation_StateLabel.TabIndex = 9
        RouteLocation_StateLabel.Text = "State"
        '
        'RouteLocation_ZipCodeLabel
        '
        RouteLocation_ZipCodeLabel.AutoSize = true
        RouteLocation_ZipCodeLabel.Location = New System.Drawing.Point(180, 126)
        RouteLocation_ZipCodeLabel.Name = "RouteLocation_ZipCodeLabel"
        RouteLocation_ZipCodeLabel.Size = New System.Drawing.Size(49, 13)
        RouteLocation_ZipCodeLabel.TabIndex = 11
        RouteLocation_ZipCodeLabel.Text = "Zip Code"
        '
        'Label1
        '
        Label1.AutoSize = true
        Label1.Location = New System.Drawing.Point(12, 126)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(26, 13)
        Label1.TabIndex = 6
        Label1.Text = "City"
        '
        'Label2
        '
        Label2.AutoSize = true
        Label2.Location = New System.Drawing.Point(118, 126)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(33, 13)
        Label2.TabIndex = 8
        Label2.Text = "State"
        '
        'Label3
        '
        Label3.AutoSize = true
        Label3.Location = New System.Drawing.Point(180, 126)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(49, 13)
        Label3.TabIndex = 10
        Label3.Text = "Zip Code"
        '
        'Label4
        '
        Label4.AutoSize = true
        Label4.Location = New System.Drawing.Point(12, 77)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(37, 13)
        Label4.TabIndex = 4
        Label4.Text = "Street"
        '
        'Label5
        '
        Label5.AutoSize = true
        Label5.Location = New System.Drawing.Point(118, 26)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(57, 13)
        Label5.TabIndex = 3
        Label5.Text = "Last Name"
        '
        'Label6
        '
        Label6.AutoSize = true
        Label6.Location = New System.Drawing.Point(12, 26)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(58, 13)
        Label6.TabIndex = 1
        Label6.Text = "First Name"
        '
        'Label12
        '
        Label12.AutoSize = true
        Label12.Enabled = false
        Label12.Location = New System.Drawing.Point(334, 360)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(70, 13)
        Label12.TabIndex = 19
        Label12.Text = "Months to Bill"
        '
        'Label14
        '
        Label14.AutoSize = true
        Label14.Location = New System.Drawing.Point(32, 21)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(57, 13)
        Label14.TabIndex = 5
        Label14.Text = "Comments"
        '
        'Label16
        '
        Label16.AutoSize = true
        Label16.Enabled = false
        Label16.Location = New System.Drawing.Point(489, 360)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(87, 13)
        Label16.TabIndex = 21
        Label16.Text = "Last Month Billed"
        '
        'SequenceNumberLabel
        '
        SequenceNumberLabel.AutoSize = true
        SequenceNumberLabel.Location = New System.Drawing.Point(489, 131)
        SequenceNumberLabel.Name = "SequenceNumberLabel"
        SequenceNumberLabel.Size = New System.Drawing.Size(94, 13)
        SequenceNumberLabel.TabIndex = 30
        SequenceNumberLabel.Text = "Sequence Number"
        SequenceNumberLabel.Visible = false
        '
        'Label10
        '
        Label10.AutoSize = true
        Label10.Location = New System.Drawing.Point(507, 105)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(76, 13)
        Label10.TabIndex = 28
        Label10.Text = "Route Number"
        '
        'CardboardRentalLabel
        '
        CardboardRentalLabel.AutoSize = true
        CardboardRentalLabel.Location = New System.Drawing.Point(299, 133)
        CardboardRentalLabel.Name = "CardboardRentalLabel"
        CardboardRentalLabel.Size = New System.Drawing.Size(92, 13)
        CardboardRentalLabel.TabIndex = 18
        CardboardRentalLabel.Text = "Cardboard Rental"
        '
        'Cart90GallonRentalLabel
        '
        Cart90GallonRentalLabel.AutoSize = true
        Cart90GallonRentalLabel.Location = New System.Drawing.Point(306, 106)
        Cart90GallonRentalLabel.Name = "Cart90GallonRentalLabel"
        Cart90GallonRentalLabel.Size = New System.Drawing.Size(85, 13)
        Cart90GallonRentalLabel.TabIndex = 13
        Cart90GallonRentalLabel.Text = "90 Gallon Rental"
        '
        'RollOffRentalLabel
        '
        RollOffRentalLabel.AutoSize = true
        RollOffRentalLabel.Location = New System.Drawing.Point(314, 79)
        RollOffRentalLabel.Name = "RollOffRentalLabel"
        RollOffRentalLabel.Size = New System.Drawing.Size(77, 13)
        RollOffRentalLabel.TabIndex = 8
        RollOffRentalLabel.Text = "Roll Off Rental"
        '
        'DumpsterRentalLabel
        '
        DumpsterRentalLabel.AutoSize = true
        DumpsterRentalLabel.Location = New System.Drawing.Point(304, 52)
        DumpsterRentalLabel.Name = "DumpsterRentalLabel"
        DumpsterRentalLabel.Size = New System.Drawing.Size(87, 13)
        DumpsterRentalLabel.TabIndex = 4
        DumpsterRentalLabel.Text = "Dumpster Rental"
        '
        'Label22
        '
        Label22.AutoSize = true
        Label22.Location = New System.Drawing.Point(39, 159)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(82, 13)
        Label22.TabIndex = 20
        Label22.Text = "Recycle Charge"
        '
        'Label23
        '
        Label23.AutoSize = true
        Label23.Location = New System.Drawing.Point(25, 132)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(96, 13)
        Label23.TabIndex = 15
        Label23.Text = "Cardboard Charge"
        '
        'Label20
        '
        Label20.AutoSize = true
        Label20.Location = New System.Drawing.Point(40, 105)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(81, 13)
        Label20.TabIndex = 10
        Label20.Text = "90-Gallon Carts"
        '
        'Label15
        '
        Label15.AutoSize = true
        Label15.Location = New System.Drawing.Point(39, 78)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(82, 13)
        Label15.TabIndex = 6
        Label15.Text = "Roll-Off Charge"
        '
        'Label7
        '
        Label7.AutoSize = true
        Label7.Location = New System.Drawing.Point(30, 51)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(91, 13)
        Label7.TabIndex = 1
        Label7.Text = "Dumpster Charge"
        '
        'Label9
        '
        Label9.AutoSize = true
        Label9.Location = New System.Drawing.Point(532, 158)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(51, 13)
        Label9.TabIndex = 32
        Label9.Text = "Tax Rate"
        '
        'Label24
        '
        Label24.AutoSize = true
        Label24.Location = New System.Drawing.Point(250, 306)
        Label24.Name = "Label24"
        Label24.Size = New System.Drawing.Size(25, 13)
        Label24.TabIndex = 12
        Label24.Text = "Fax"
        '
        'Label25
        '
        Label25.AutoSize = true
        Label25.Location = New System.Drawing.Point(392, 252)
        Label25.Name = "Label25"
        Label25.Size = New System.Drawing.Size(73, 13)
        Label25.TabIndex = 14
        Label25.Text = "Email Address"
        '
        'Label26
        '
        Label26.AutoSize = true
        Label26.Font = New System.Drawing.Font("Tahoma", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Label26.ForeColor = System.Drawing.Color.Blue
        Label26.Location = New System.Drawing.Point(24, 14)
        Label26.Name = "Label26"
        Label26.Size = New System.Drawing.Size(78, 23)
        Label26.TabIndex = 0
        Label26.Text = "Charges"
        '
        'Label27
        '
        Label27.AutoSize = true
        Label27.Font = New System.Drawing.Font("Tahoma", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Label27.ForeColor = System.Drawing.Color.Blue
        Label27.Location = New System.Drawing.Point(24, 194)
        Label27.Name = "Label27"
        Label27.Size = New System.Drawing.Size(110, 23)
        Label27.TabIndex = 34
        Label27.Text = "Pickup Days"
        '
        'Label28
        '
        Label28.AutoSize = true
        Label28.Location = New System.Drawing.Point(54, 306)
        Label28.Name = "Label28"
        Label28.Size = New System.Drawing.Size(45, 13)
        Label28.TabIndex = 6
        Label28.Text = "Contact"
        '
        'Label29
        '
        Label29.AutoSize = true
        Label29.Location = New System.Drawing.Point(60, 279)
        Label29.Name = "Label29"
        Label29.Size = New System.Drawing.Size(39, 13)
        Label29.TabIndex = 4
        Label29.Text = "Owner"
        '
        'Label11
        '
        Label11.AutoSize = true
        Label11.Font = New System.Drawing.Font("Tahoma", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Label11.ForeColor = System.Drawing.Color.Blue
        Label11.Location = New System.Drawing.Point(24, 14)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(193, 23)
        Label11.TabIndex = 23
        Label11.Text = "Customer Information"
        '
        'Label8
        '
        Label8.AutoSize = true
        Label8.Location = New System.Drawing.Point(313, 160)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(78, 13)
        Label8.TabIndex = 23
        Label8.Text = "Recycle Rental"
        '
        'Billing_AddressTextBox
        '
        Me.Billing_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Billing_Address", true))
        Me.Billing_AddressTextBox.Location = New System.Drawing.Point(15, 93)
        Me.Billing_AddressTextBox.Name = "Billing_AddressTextBox"
        Me.Billing_AddressTextBox.Size = New System.Drawing.Size(236, 21)
        Me.Billing_AddressTextBox.TabIndex = 5
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataSource = GetType(PickupTransaction.RentalCustomer)
        '
        'Billing_CityTextBox
        '
        Me.Billing_CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Billing_City", true))
        Me.Billing_CityTextBox.Location = New System.Drawing.Point(15, 142)
        Me.Billing_CityTextBox.Name = "Billing_CityTextBox"
        Me.Billing_CityTextBox.Size = New System.Drawing.Size(100, 21)
        Me.Billing_CityTextBox.TabIndex = 7
        '
        'Billing_FirstNameTextBox
        '
        Me.Billing_FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Billing_FirstName", true))
        Me.Billing_FirstNameTextBox.Location = New System.Drawing.Point(15, 42)
        Me.Billing_FirstNameTextBox.Name = "Billing_FirstNameTextBox"
        Me.Billing_FirstNameTextBox.Size = New System.Drawing.Size(100, 21)
        Me.Billing_FirstNameTextBox.TabIndex = 1
        '
        'Billing_LastNameTextBox
        '
        Me.Billing_LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Billing_LastName", true))
        Me.Billing_LastNameTextBox.Location = New System.Drawing.Point(121, 42)
        Me.Billing_LastNameTextBox.Name = "Billing_LastNameTextBox"
        Me.Billing_LastNameTextBox.Size = New System.Drawing.Size(130, 21)
        Me.Billing_LastNameTextBox.TabIndex = 3
        '
        'Billing_StateTextBox
        '
        Me.Billing_StateTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Billing_StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Billing_State", true))
        Me.Billing_StateTextBox.Location = New System.Drawing.Point(121, 142)
        Me.Billing_StateTextBox.Name = "Billing_StateTextBox"
        Me.Billing_StateTextBox.Size = New System.Drawing.Size(56, 21)
        Me.Billing_StateTextBox.TabIndex = 9
        '
        'Billing_ZipCodeTextBox
        '
        Me.Billing_ZipCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Billing_ZipCode", true))
        Me.Billing_ZipCodeTextBox.Location = New System.Drawing.Point(183, 142)
        Me.Billing_ZipCodeTextBox.Name = "Billing_ZipCodeTextBox"
        Me.Billing_ZipCodeTextBox.Size = New System.Drawing.Size(68, 21)
        Me.Billing_ZipCodeTextBox.TabIndex = 11
        '
        'BusinessPhoneTextBox
        '
        Me.BusinessPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "BusinessPhone", true))
        Me.BusinessPhoneTextBox.Location = New System.Drawing.Point(281, 276)
        Me.BusinessPhoneTextBox.Name = "BusinessPhoneTextBox"
        Me.BusinessPhoneTextBox.Size = New System.Drawing.Size(83, 21)
        Me.BusinessPhoneTextBox.TabIndex = 11
        '
        'CustomerNumberTextBox
        '
        Me.CustomerNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CustomerNumber", true))
        Me.CustomerNumberTextBox.Location = New System.Drawing.Point(105, 249)
        Me.CustomerNumberTextBox.Name = "CustomerNumberTextBox"
        Me.CustomerNumberTextBox.Size = New System.Drawing.Size(83, 21)
        Me.CustomerNumberTextBox.TabIndex = 3
        '
        'HomePhoneTextBox
        '
        Me.HomePhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "HomePhone", true))
        Me.HomePhoneTextBox.Location = New System.Drawing.Point(281, 249)
        Me.HomePhoneTextBox.Name = "HomePhoneTextBox"
        Me.HomePhoneTextBox.Size = New System.Drawing.Size(83, 21)
        Me.HomePhoneTextBox.TabIndex = 9
        '
        'RouteLocation_AddressTextBox
        '
        Me.RouteLocation_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "RouteLocation_Address", true))
        Me.RouteLocation_AddressTextBox.Location = New System.Drawing.Point(15, 93)
        Me.RouteLocation_AddressTextBox.Name = "RouteLocation_AddressTextBox"
        Me.RouteLocation_AddressTextBox.Size = New System.Drawing.Size(236, 21)
        Me.RouteLocation_AddressTextBox.TabIndex = 6
        '
        'RouteLocation_CityTextBox
        '
        Me.RouteLocation_CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "RouteLocation_City", true))
        Me.RouteLocation_CityTextBox.Location = New System.Drawing.Point(15, 142)
        Me.RouteLocation_CityTextBox.Name = "RouteLocation_CityTextBox"
        Me.RouteLocation_CityTextBox.Size = New System.Drawing.Size(100, 21)
        Me.RouteLocation_CityTextBox.TabIndex = 8
        '
        'RouteLocation_FirstNameTextBox
        '
        Me.RouteLocation_FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "RouteLocation_FirstName", true))
        Me.RouteLocation_FirstNameTextBox.Location = New System.Drawing.Point(15, 42)
        Me.RouteLocation_FirstNameTextBox.Name = "RouteLocation_FirstNameTextBox"
        Me.RouteLocation_FirstNameTextBox.Size = New System.Drawing.Size(100, 21)
        Me.RouteLocation_FirstNameTextBox.TabIndex = 2
        '
        'RouteLocation_LastNameTextBox
        '
        Me.RouteLocation_LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "RouteLocation_LastName", true))
        Me.RouteLocation_LastNameTextBox.Location = New System.Drawing.Point(121, 42)
        Me.RouteLocation_LastNameTextBox.Name = "RouteLocation_LastNameTextBox"
        Me.RouteLocation_LastNameTextBox.Size = New System.Drawing.Size(130, 21)
        Me.RouteLocation_LastNameTextBox.TabIndex = 4
        '
        'RouteLocation_StateTextBox
        '
        Me.RouteLocation_StateTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RouteLocation_StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "RouteLocation_State", true))
        Me.RouteLocation_StateTextBox.Location = New System.Drawing.Point(121, 142)
        Me.RouteLocation_StateTextBox.Name = "RouteLocation_StateTextBox"
        Me.RouteLocation_StateTextBox.Size = New System.Drawing.Size(56, 21)
        Me.RouteLocation_StateTextBox.TabIndex = 10
        '
        'RouteLocation_ZipCodeTextBox
        '
        Me.RouteLocation_ZipCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "RouteLocation_ZipCode", true))
        Me.RouteLocation_ZipCodeTextBox.Location = New System.Drawing.Point(183, 142)
        Me.RouteLocation_ZipCodeTextBox.Name = "RouteLocation_ZipCodeTextBox"
        Me.RouteLocation_ZipCodeTextBox.Size = New System.Drawing.Size(68, 21)
        Me.RouteLocation_ZipCodeTextBox.TabIndex = 12
        '
        'GroupBoxRoute
        '
        Me.GroupBoxRoute.Controls.Add(Me.CheckBoxSameAsRoute)
        Me.GroupBoxRoute.Controls.Add(RouteLocation_AddressLabel)
        Me.GroupBoxRoute.Controls.Add(Me.RouteLocation_LastNameTextBox)
        Me.GroupBoxRoute.Controls.Add(Label6)
        Me.GroupBoxRoute.Controls.Add(Me.RouteLocation_ZipCodeTextBox)
        Me.GroupBoxRoute.Controls.Add(Me.RouteLocation_FirstNameTextBox)
        Me.GroupBoxRoute.Controls.Add(RouteLocation_ZipCodeLabel)
        Me.GroupBoxRoute.Controls.Add(Me.RouteLocation_StateTextBox)
        Me.GroupBoxRoute.Controls.Add(RouteLocation_StateLabel)
        Me.GroupBoxRoute.Controls.Add(Label5)
        Me.GroupBoxRoute.Controls.Add(Me.RouteLocation_CityTextBox)
        Me.GroupBoxRoute.Controls.Add(RouteLocation_CityLabel)
        Me.GroupBoxRoute.Controls.Add(Me.RouteLocation_AddressTextBox)
        Me.GroupBoxRoute.Location = New System.Drawing.Point(16, 48)
        Me.GroupBoxRoute.Name = "GroupBoxRoute"
        Me.GroupBoxRoute.Size = New System.Drawing.Size(268, 179)
        Me.GroupBoxRoute.TabIndex = 0
        Me.GroupBoxRoute.TabStop = false
        Me.GroupBoxRoute.Text = "Route Address"
        '
        'CheckBoxSameAsRoute
        '
        Me.CheckBoxSameAsRoute.AutoSize = true
        Me.CheckBoxSameAsRoute.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CustomerBindingSource, "BillingSameAsRoute", true))
        Me.CheckBoxSameAsRoute.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CheckBoxSameAsRoute.Location = New System.Drawing.Point(110, 0)
        Me.CheckBoxSameAsRoute.Name = "CheckBoxSameAsRoute"
        Me.CheckBoxSameAsRoute.Size = New System.Drawing.Size(152, 17)
        Me.CheckBoxSameAsRoute.TabIndex = 0
        Me.CheckBoxSameAsRoute.Text = "Billing Address is the Same"
        Me.CheckBoxSameAsRoute.UseVisualStyleBackColor = true
        '
        'GroupBoxBillingAddress
        '
        Me.GroupBoxBillingAddress.Controls.Add(Label4)
        Me.GroupBoxBillingAddress.Controls.Add(Me.Billing_CityTextBox)
        Me.GroupBoxBillingAddress.Controls.Add(Me.Billing_ZipCodeTextBox)
        Me.GroupBoxBillingAddress.Controls.Add(Billing_FirstNameLabel)
        Me.GroupBoxBillingAddress.Controls.Add(Label3)
        Me.GroupBoxBillingAddress.Controls.Add(Me.Billing_StateTextBox)
        Me.GroupBoxBillingAddress.Controls.Add(Me.Billing_FirstNameTextBox)
        Me.GroupBoxBillingAddress.Controls.Add(Me.Billing_AddressTextBox)
        Me.GroupBoxBillingAddress.Controls.Add(Billing_LastNameLabel)
        Me.GroupBoxBillingAddress.Controls.Add(Label2)
        Me.GroupBoxBillingAddress.Controls.Add(Me.Billing_LastNameTextBox)
        Me.GroupBoxBillingAddress.Controls.Add(Label1)
        Me.GroupBoxBillingAddress.Location = New System.Drawing.Point(395, 48)
        Me.GroupBoxBillingAddress.Name = "GroupBoxBillingAddress"
        Me.GroupBoxBillingAddress.Size = New System.Drawing.Size(268, 179)
        Me.GroupBoxBillingAddress.TabIndex = 1
        Me.GroupBoxBillingAddress.TabStop = false
        Me.GroupBoxBillingAddress.Text = "Billing Address"
        '
        'ButtonSave
        '
        Me.ButtonSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ButtonSave.Location = New System.Drawing.Point(347, 458)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(151, 23)
        Me.ButtonSave.TabIndex = 1
        Me.ButtonSave.Text = "Save and Add New"
        Me.ButtonSave.UseVisualStyleBackColor = true
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ButtonCancel.Location = New System.Drawing.Point(661, 458)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 3
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = true
        '
        'TabControlCustomer
        '
        Me.TabControlCustomer.Controls.Add(Me.TabPageCustomerInfo)
        Me.TabControlCustomer.Controls.Add(Me.TabPagePickupDays)
        Me.TabControlCustomer.Controls.Add(Me.TabPageComments)
        Me.TabControlCustomer.Controls.Add(Me.TabPageCloseAccount)
        Me.TabControlCustomer.Location = New System.Drawing.Point(12, 12)
        Me.TabControlCustomer.Name = "TabControlCustomer"
        Me.TabControlCustomer.SelectedIndex = 0
        Me.TabControlCustomer.Size = New System.Drawing.Size(724, 440)
        Me.TabControlCustomer.TabIndex = 1
        '
        'TabPageCustomerInfo
        '
        Me.TabPageCustomerInfo.AutoScroll = true
        Me.TabPageCustomerInfo.Controls.Add(Me.CheckBoxPrintBill)
        Me.TabPageCustomerInfo.Controls.Add(Label11)
        Me.TabPageCustomerInfo.Controls.Add(Me.CheckBoxSendBillEmail)
        Me.TabPageCustomerInfo.Controls.Add(Me.TextBoxOwner)
        Me.TabPageCustomerInfo.Controls.Add(Label28)
        Me.TabPageCustomerInfo.Controls.Add(Label29)
        Me.TabPageCustomerInfo.Controls.Add(Me.TextBoxContact)
        Me.TabPageCustomerInfo.Controls.Add(Me.TextBoxLMB)
        Me.TabPageCustomerInfo.Controls.Add(Label16)
        Me.TabPageCustomerInfo.Controls.Add(Me.TextBoxMonthsToBill)
        Me.TabPageCustomerInfo.Controls.Add(Label12)
        Me.TabPageCustomerInfo.Controls.Add(CustomerNumberLabel)
        Me.TabPageCustomerInfo.Controls.Add(Me.TextBoxFax)
        Me.TabPageCustomerInfo.Controls.Add(Me.HomePhoneTextBox)
        Me.TabPageCustomerInfo.Controls.Add(Me.GroupBoxBillingAddress)
        Me.TabPageCustomerInfo.Controls.Add(Me.GroupBoxRoute)
        Me.TabPageCustomerInfo.Controls.Add(Label25)
        Me.TabPageCustomerInfo.Controls.Add(BusinessPhoneLabel)
        Me.TabPageCustomerInfo.Controls.Add(Label24)
        Me.TabPageCustomerInfo.Controls.Add(HomePhoneLabel)
        Me.TabPageCustomerInfo.Controls.Add(Me.TextBoxEMailAddress)
        Me.TabPageCustomerInfo.Controls.Add(Me.BusinessPhoneTextBox)
        Me.TabPageCustomerInfo.Controls.Add(Me.CustomerNumberTextBox)
        Me.TabPageCustomerInfo.Location = New System.Drawing.Point(4, 22)
        Me.TabPageCustomerInfo.Name = "TabPageCustomerInfo"
        Me.TabPageCustomerInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCustomerInfo.Size = New System.Drawing.Size(716, 414)
        Me.TabPageCustomerInfo.TabIndex = 0
        Me.TabPageCustomerInfo.Text = "Information"
        Me.TabPageCustomerInfo.UseVisualStyleBackColor = true
        '
        'CheckBoxPrintBill
        '
        Me.CheckBoxPrintBill.AutoSize = true
        Me.CheckBoxPrintBill.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CustomerBindingSource, "PrintBill", true))
        Me.CheckBoxPrintBill.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CheckBoxPrintBill.Location = New System.Drawing.Point(16, 356)
        Me.CheckBoxPrintBill.Name = "CheckBoxPrintBill"
        Me.CheckBoxPrintBill.Size = New System.Drawing.Size(72, 17)
        Me.CheckBoxPrintBill.TabIndex = 24
        Me.CheckBoxPrintBill.Text = "Print Bill"
        Me.CheckBoxPrintBill.UseVisualStyleBackColor = true
        '
        'CheckBoxSendBillEmail
        '
        Me.CheckBoxSendBillEmail.AutoSize = true
        Me.CheckBoxSendBillEmail.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CustomerBindingSource, "SendBillViaEmail", true))
        Me.CheckBoxSendBillEmail.Location = New System.Drawing.Point(554, 298)
        Me.CheckBoxSendBillEmail.Name = "CheckBoxSendBillEmail"
        Me.CheckBoxSendBillEmail.Size = New System.Drawing.Size(109, 17)
        Me.CheckBoxSendBillEmail.TabIndex = 16
        Me.CheckBoxSendBillEmail.Text = "Send bill via EMail"
        Me.CheckBoxSendBillEmail.UseVisualStyleBackColor = true
        '
        'TextBoxOwner
        '
        Me.TextBoxOwner.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Owner", true))
        Me.TextBoxOwner.Location = New System.Drawing.Point(105, 276)
        Me.TextBoxOwner.Name = "TextBoxOwner"
        Me.TextBoxOwner.Size = New System.Drawing.Size(83, 21)
        Me.TextBoxOwner.TabIndex = 5
        '
        'TextBoxContact
        '
        Me.TextBoxContact.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Contact", true))
        Me.TextBoxContact.Location = New System.Drawing.Point(105, 303)
        Me.TextBoxContact.Name = "TextBoxContact"
        Me.TextBoxContact.Size = New System.Drawing.Size(83, 21)
        Me.TextBoxContact.TabIndex = 7
        '
        'TextBoxLMB
        '
        Me.TextBoxLMB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "LastMonthBilled", true))
        Me.TextBoxLMB.Enabled = false
        Me.TextBoxLMB.Location = New System.Drawing.Point(582, 357)
        Me.TextBoxLMB.Name = "TextBoxLMB"
        Me.TextBoxLMB.Size = New System.Drawing.Size(62, 21)
        Me.TextBoxLMB.TabIndex = 22
        '
        'TextBoxMonthsToBill
        '
        Me.TextBoxMonthsToBill.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "MonthsToBill", true))
        Me.TextBoxMonthsToBill.Enabled = false
        Me.TextBoxMonthsToBill.Location = New System.Drawing.Point(410, 357)
        Me.TextBoxMonthsToBill.Name = "TextBoxMonthsToBill"
        Me.TextBoxMonthsToBill.Size = New System.Drawing.Size(62, 21)
        Me.TextBoxMonthsToBill.TabIndex = 20
        '
        'TextBoxFax
        '
        Me.TextBoxFax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Fax", true))
        Me.TextBoxFax.Location = New System.Drawing.Point(281, 303)
        Me.TextBoxFax.Name = "TextBoxFax"
        Me.TextBoxFax.Size = New System.Drawing.Size(83, 21)
        Me.TextBoxFax.TabIndex = 13
        '
        'TextBoxEMailAddress
        '
        Me.TextBoxEMailAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "EMailAddress", true))
        Me.TextBoxEMailAddress.Location = New System.Drawing.Point(395, 271)
        Me.TextBoxEMailAddress.Name = "TextBoxEMailAddress"
        Me.TextBoxEMailAddress.Size = New System.Drawing.Size(268, 21)
        Me.TextBoxEMailAddress.TabIndex = 15
        '
        'TabPagePickupDays
        '
        Me.TabPagePickupDays.Controls.Add(Me.ComboBoxCartPUCharge)
        Me.TabPagePickupDays.Controls.Add(Me.CheckBoxRequiresPaperwork)
        Me.TabPagePickupDays.Controls.Add(Me.ButtonDeleteSelectedLine)
        Me.TabPagePickupDays.Controls.Add(Me.CheckBoxUsePOForAll)
        Me.TabPagePickupDays.Controls.Add(Me.ComboBoxRecyclePUCharge)
        Me.TabPagePickupDays.Controls.Add(Me.ComboBoxCardboardPUCharge)
        Me.TabPagePickupDays.Controls.Add(Me.ComboBoxDumpsterPUCharge)
        Me.TabPagePickupDays.Controls.Add(Me.DataGridViewPickupDays)
        Me.TabPagePickupDays.Controls.Add(Me.TextBoxTaxRate)
        Me.TabPagePickupDays.Controls.Add(Label9)
        Me.TabPagePickupDays.Controls.Add(Label8)
        Me.TabPagePickupDays.Controls.Add(CardboardRentalLabel)
        Me.TabPagePickupDays.Controls.Add(Me.TextBoxRecycleRental)
        Me.TabPagePickupDays.Controls.Add(Me.CardboardRentalTextBox)
        Me.TabPagePickupDays.Controls.Add(Cart90GallonRentalLabel)
        Me.TabPagePickupDays.Controls.Add(Me.Cart90GallonRentalTextBox)
        Me.TabPagePickupDays.Controls.Add(RollOffRentalLabel)
        Me.TabPagePickupDays.Controls.Add(Me.RollOffRentalTextBox)
        Me.TabPagePickupDays.Controls.Add(DumpsterRentalLabel)
        Me.TabPagePickupDays.Controls.Add(Me.DumpsterRentalTextBox)
        Me.TabPagePickupDays.Controls.Add(Me.TextBoxRecycleCharge)
        Me.TabPagePickupDays.Controls.Add(Label22)
        Me.TabPagePickupDays.Controls.Add(Me.TextBoxCardboardCharge)
        Me.TabPagePickupDays.Controls.Add(Label23)
        Me.TabPagePickupDays.Controls.Add(Me.TextBox90GallonCarts)
        Me.TabPagePickupDays.Controls.Add(Label20)
        Me.TabPagePickupDays.Controls.Add(Me.TextBoxRollOffCharge)
        Me.TabPagePickupDays.Controls.Add(Label15)
        Me.TabPagePickupDays.Controls.Add(Me.TextBoxDumpsterCharge)
        Me.TabPagePickupDays.Controls.Add(Label27)
        Me.TabPagePickupDays.Controls.Add(Label26)
        Me.TabPagePickupDays.Controls.Add(Label7)
        Me.TabPagePickupDays.Controls.Add(Me.ComboBoxRouteNumber)
        Me.TabPagePickupDays.Controls.Add(Label10)
        Me.TabPagePickupDays.Controls.Add(Me.SequenceNumberTextBox)
        Me.TabPagePickupDays.Controls.Add(SequenceNumberLabel)
        Me.TabPagePickupDays.Controls.Add(Me.TextBoxPO)
        Me.TabPagePickupDays.Controls.Add(Me.Label21)
        Me.TabPagePickupDays.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePickupDays.Name = "TabPagePickupDays"
        Me.TabPagePickupDays.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePickupDays.Size = New System.Drawing.Size(716, 414)
        Me.TabPagePickupDays.TabIndex = 4
        Me.TabPagePickupDays.Text = "Charges / Pickup Days"
        Me.TabPagePickupDays.UseVisualStyleBackColor = true
        '
        'ComboBoxCartPUCharge
        '
        Me.ComboBoxCartPUCharge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCartPUCharge.FormattingEnabled = true
        Me.ComboBoxCartPUCharge.Items.AddRange(New Object() {"Per Month", "Per Pickup"})
        Me.ComboBoxCartPUCharge.Location = New System.Drawing.Point(189, 102)
        Me.ComboBoxCartPUCharge.Name = "ComboBoxCartPUCharge"
        Me.ComboBoxCartPUCharge.Size = New System.Drawing.Size(87, 21)
        Me.ComboBoxCartPUCharge.TabIndex = 12
        '
        'CheckBoxRequiresPaperwork
        '
        Me.CheckBoxRequiresPaperwork.AutoSize = true
        Me.CheckBoxRequiresPaperwork.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CheckBoxRequiresPaperwork.Location = New System.Drawing.Point(390, 194)
        Me.CheckBoxRequiresPaperwork.Name = "CheckBoxRequiresPaperwork"
        Me.CheckBoxRequiresPaperwork.Size = New System.Drawing.Size(198, 17)
        Me.CheckBoxRequiresPaperwork.TabIndex = 32
        Me.CheckBoxRequiresPaperwork.Text = "Customer Requires Paperwork"
        Me.CheckBoxRequiresPaperwork.UseVisualStyleBackColor = true
        '
        'ButtonDeleteSelectedLine
        '
        Me.ButtonDeleteSelectedLine.Location = New System.Drawing.Point(27, 383)
        Me.ButtonDeleteSelectedLine.Name = "ButtonDeleteSelectedLine"
        Me.ButtonDeleteSelectedLine.Size = New System.Drawing.Size(156, 23)
        Me.ButtonDeleteSelectedLine.TabIndex = 35
        Me.ButtonDeleteSelectedLine.Text = "Delete Selected Line..."
        Me.ButtonDeleteSelectedLine.UseVisualStyleBackColor = true
        '
        'CheckBoxUsePOForAll
        '
        Me.CheckBoxUsePOForAll.AutoSize = true
        Me.CheckBoxUsePOForAll.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CustomerBindingSource, "UsePONumberForAll", true))
        Me.CheckBoxUsePOForAll.Location = New System.Drawing.Point(589, 76)
        Me.CheckBoxUsePOForAll.Name = "CheckBoxUsePOForAll"
        Me.CheckBoxUsePOForAll.Size = New System.Drawing.Size(75, 17)
        Me.CheckBoxUsePOForAll.TabIndex = 27
        Me.CheckBoxUsePOForAll.Text = "Use for All"
        Me.CheckBoxUsePOForAll.UseVisualStyleBackColor = true
        '
        'ComboBoxRecyclePUCharge
        '
        Me.ComboBoxRecyclePUCharge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRecyclePUCharge.FormattingEnabled = true
        Me.ComboBoxRecyclePUCharge.Items.AddRange(New Object() {"Per Month", "Per Pickup"})
        Me.ComboBoxRecyclePUCharge.Location = New System.Drawing.Point(189, 156)
        Me.ComboBoxRecyclePUCharge.Name = "ComboBoxRecyclePUCharge"
        Me.ComboBoxRecyclePUCharge.Size = New System.Drawing.Size(87, 21)
        Me.ComboBoxRecyclePUCharge.TabIndex = 22
        '
        'ComboBoxCardboardPUCharge
        '
        Me.ComboBoxCardboardPUCharge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCardboardPUCharge.FormattingEnabled = true
        Me.ComboBoxCardboardPUCharge.Items.AddRange(New Object() {"Per Month", "Per Pickup"})
        Me.ComboBoxCardboardPUCharge.Location = New System.Drawing.Point(189, 129)
        Me.ComboBoxCardboardPUCharge.Name = "ComboBoxCardboardPUCharge"
        Me.ComboBoxCardboardPUCharge.Size = New System.Drawing.Size(87, 21)
        Me.ComboBoxCardboardPUCharge.TabIndex = 17
        '
        'ComboBoxDumpsterPUCharge
        '
        Me.ComboBoxDumpsterPUCharge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDumpsterPUCharge.FormattingEnabled = true
        Me.ComboBoxDumpsterPUCharge.Items.AddRange(New Object() {"Per Month", "Per Pickup"})
        Me.ComboBoxDumpsterPUCharge.Location = New System.Drawing.Point(189, 48)
        Me.ComboBoxDumpsterPUCharge.Name = "ComboBoxDumpsterPUCharge"
        Me.ComboBoxDumpsterPUCharge.Size = New System.Drawing.Size(87, 21)
        Me.ComboBoxDumpsterPUCharge.TabIndex = 3
        '
        'DataGridViewPickupDays
        '
        Me.DataGridViewPickupDays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPickupDays.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colSeqNumber, Me.colType, Me.colDays, Me.colLoadType, Me.colDumpsterSize, Me.colRoute, Me.colMisc, Me.colTruckNotes})
        Me.DataGridViewPickupDays.Location = New System.Drawing.Point(28, 223)
        Me.DataGridViewPickupDays.Name = "DataGridViewPickupDays"
        Me.DataGridViewPickupDays.Size = New System.Drawing.Size(682, 154)
        Me.DataGridViewPickupDays.TabIndex = 35
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = false
        '
        'colSeqNumber
        '
        Me.colSeqNumber.HeaderText = "Seq. Num"
        Me.colSeqNumber.Name = "colSeqNumber"
        Me.colSeqNumber.Visible = false
        '
        'colType
        '
        Me.colType.HeaderText = "Type"
        Me.colType.Items.AddRange(New Object() {"Dumpster", "Cardboard", "Recycle", "90-Gallon Cart", "95-Gallon Cart", "Roll Off"})
        Me.colType.Name = "colType"
        '
        'colDays
        '
        Me.colDays.HeaderText = "Days"
        Me.colDays.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "On Call"})
        Me.colDays.Name = "colDays"
        '
        'colLoadType
        '
        Me.colLoadType.HeaderText = "Load Type"
        Me.colLoadType.Items.AddRange(New Object() {"Front Load", "Rear Load"})
        Me.colLoadType.Name = "colLoadType"
        '
        'colDumpsterSize
        '
        Me.colDumpsterSize.HeaderText = "Size"
        Me.colDumpsterSize.Items.AddRange(New Object() {"2 yd", "3 yd", "4 yd", "6 yd", "8 yd", "10 yd", "20 yd", "30 yd", "40 yd"})
        Me.colDumpsterSize.Name = "colDumpsterSize"
        Me.colDumpsterSize.Width = 90
        '
        'colRoute
        '
        Me.colRoute.HeaderText = "Route"
        Me.colRoute.Name = "colRoute"
        Me.colRoute.Visible = false
        Me.colRoute.Width = 50
        '
        'colMisc
        '
        Me.colMisc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colMisc.HeaderText = "Misc"
        Me.colMisc.Name = "colMisc"
        '
        'colTruckNotes
        '
        Me.colTruckNotes.HeaderText = "Truck Notes"
        Me.colTruckNotes.Name = "colTruckNotes"
        Me.colTruckNotes.Width = 125
        '
        'TextBoxTaxRate
        '
        Me.TextBoxTaxRate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "TaxRate", true))
        Me.TextBoxTaxRate.Location = New System.Drawing.Point(589, 155)
        Me.TextBoxTaxRate.Name = "TextBoxTaxRate"
        Me.TextBoxTaxRate.Size = New System.Drawing.Size(56, 21)
        Me.TextBoxTaxRate.TabIndex = 33
        Me.TextBoxTaxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxRecycleRental
        '
        Me.TextBoxRecycleRental.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "RecycleRental", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0.00", "N2"))
        Me.TextBoxRecycleRental.Location = New System.Drawing.Point(397, 157)
        Me.TextBoxRecycleRental.Name = "TextBoxRecycleRental"
        Me.TextBoxRecycleRental.Size = New System.Drawing.Size(56, 21)
        Me.TextBoxRecycleRental.TabIndex = 24
        Me.TextBoxRecycleRental.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CardboardRentalTextBox
        '
        Me.CardboardRentalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CardboardRental", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0.00", "N2"))
        Me.CardboardRentalTextBox.Location = New System.Drawing.Point(397, 130)
        Me.CardboardRentalTextBox.Name = "CardboardRentalTextBox"
        Me.CardboardRentalTextBox.Size = New System.Drawing.Size(56, 21)
        Me.CardboardRentalTextBox.TabIndex = 19
        Me.CardboardRentalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Cart90GallonRentalTextBox
        '
        Me.Cart90GallonRentalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cart90GallonRental", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0.00", "N2"))
        Me.Cart90GallonRentalTextBox.Location = New System.Drawing.Point(397, 103)
        Me.Cart90GallonRentalTextBox.Name = "Cart90GallonRentalTextBox"
        Me.Cart90GallonRentalTextBox.Size = New System.Drawing.Size(56, 21)
        Me.Cart90GallonRentalTextBox.TabIndex = 14
        Me.Cart90GallonRentalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RollOffRentalTextBox
        '
        Me.RollOffRentalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "RollOffRental", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0.00", "N2"))
        Me.RollOffRentalTextBox.Location = New System.Drawing.Point(397, 76)
        Me.RollOffRentalTextBox.Name = "RollOffRentalTextBox"
        Me.RollOffRentalTextBox.Size = New System.Drawing.Size(56, 21)
        Me.RollOffRentalTextBox.TabIndex = 9
        Me.RollOffRentalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DumpsterRentalTextBox
        '
        Me.DumpsterRentalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "DumpsterRental", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0.00", "N2"))
        Me.DumpsterRentalTextBox.Location = New System.Drawing.Point(397, 49)
        Me.DumpsterRentalTextBox.Name = "DumpsterRentalTextBox"
        Me.DumpsterRentalTextBox.Size = New System.Drawing.Size(56, 21)
        Me.DumpsterRentalTextBox.TabIndex = 5
        Me.DumpsterRentalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxRecycleCharge
        '
        Me.TextBoxRecycleCharge.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "RecycleCharge", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0.00", "N2"))
        Me.TextBoxRecycleCharge.Location = New System.Drawing.Point(127, 156)
        Me.TextBoxRecycleCharge.Name = "TextBoxRecycleCharge"
        Me.TextBoxRecycleCharge.Size = New System.Drawing.Size(56, 21)
        Me.TextBoxRecycleCharge.TabIndex = 21
        Me.TextBoxRecycleCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxCardboardCharge
        '
        Me.TextBoxCardboardCharge.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CardboardCharge", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0.00", "N2"))
        Me.TextBoxCardboardCharge.Location = New System.Drawing.Point(127, 129)
        Me.TextBoxCardboardCharge.Name = "TextBoxCardboardCharge"
        Me.TextBoxCardboardCharge.Size = New System.Drawing.Size(56, 21)
        Me.TextBoxCardboardCharge.TabIndex = 16
        Me.TextBoxCardboardCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox90GallonCarts
        '
        Me.TextBox90GallonCarts.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cart90GallonCharge", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0.00", "N2"))
        Me.TextBox90GallonCarts.Location = New System.Drawing.Point(127, 102)
        Me.TextBox90GallonCarts.Name = "TextBox90GallonCarts"
        Me.TextBox90GallonCarts.Size = New System.Drawing.Size(56, 21)
        Me.TextBox90GallonCarts.TabIndex = 11
        Me.TextBox90GallonCarts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxRollOffCharge
        '
        Me.TextBoxRollOffCharge.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "RollOffCharge", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0.00", "N2"))
        Me.TextBoxRollOffCharge.Location = New System.Drawing.Point(127, 75)
        Me.TextBoxRollOffCharge.Name = "TextBoxRollOffCharge"
        Me.TextBoxRollOffCharge.Size = New System.Drawing.Size(56, 21)
        Me.TextBoxRollOffCharge.TabIndex = 7
        Me.TextBoxRollOffCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxDumpsterCharge
        '
        Me.TextBoxDumpsterCharge.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "DumpsterCharge", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0.00", "N2"))
        Me.TextBoxDumpsterCharge.Location = New System.Drawing.Point(127, 48)
        Me.TextBoxDumpsterCharge.Name = "TextBoxDumpsterCharge"
        Me.TextBoxDumpsterCharge.Size = New System.Drawing.Size(56, 21)
        Me.TextBoxDumpsterCharge.TabIndex = 2
        Me.TextBoxDumpsterCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ComboBoxRouteNumber
        '
        Me.ComboBoxRouteNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRouteNumber.FormattingEnabled = true
        Me.ComboBoxRouteNumber.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.ComboBoxRouteNumber.Location = New System.Drawing.Point(589, 102)
        Me.ComboBoxRouteNumber.Name = "ComboBoxRouteNumber"
        Me.ComboBoxRouteNumber.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxRouteNumber.TabIndex = 29
        '
        'SequenceNumberTextBox
        '
        Me.SequenceNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "SequenceNumber", true))
        Me.SequenceNumberTextBox.Location = New System.Drawing.Point(589, 128)
        Me.SequenceNumberTextBox.Name = "SequenceNumberTextBox"
        Me.SequenceNumberTextBox.Size = New System.Drawing.Size(100, 21)
        Me.SequenceNumberTextBox.TabIndex = 31
        Me.SequenceNumberTextBox.Visible = false
        '
        'TextBoxPO
        '
        Me.TextBoxPO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "PONumber", true))
        Me.TextBoxPO.Location = New System.Drawing.Point(589, 48)
        Me.TextBoxPO.Name = "TextBoxPO"
        Me.TextBoxPO.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxPO.TabIndex = 26
        '
        'Label21
        '
        Me.Label21.AutoSize = true
        Me.Label21.Location = New System.Drawing.Point(501, 51)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(82, 13)
        Me.Label21.TabIndex = 25
        Me.Label21.Text = "Purchase Order"
        '
        'TabPageComments
        '
        Me.TabPageComments.Controls.Add(Me.RichTextBoxComments)
        Me.TabPageComments.Controls.Add(Label14)
        Me.TabPageComments.Location = New System.Drawing.Point(4, 22)
        Me.TabPageComments.Name = "TabPageComments"
        Me.TabPageComments.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageComments.Size = New System.Drawing.Size(716, 414)
        Me.TabPageComments.TabIndex = 2
        Me.TabPageComments.Text = "Comments"
        Me.TabPageComments.UseVisualStyleBackColor = true
        '
        'RichTextBoxComments
        '
        Me.RichTextBoxComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBoxComments.ContextMenuStrip = Me.ContextMenuStripRTB
        Me.RichTextBoxComments.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Comments", true))
        Me.RichTextBoxComments.Location = New System.Drawing.Point(95, 21)
        Me.RichTextBoxComments.Name = "RichTextBoxComments"
        Me.RichTextBoxComments.Size = New System.Drawing.Size(598, 374)
        Me.RichTextBoxComments.TabIndex = 7
        Me.RichTextBoxComments.Text = ""
        '
        'ContextMenuStripRTB
        '
        Me.ContextMenuStripRTB.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.ContextMenuStripRTB.Name = "ContextMenuStripRTB"
        Me.ContextMenuStripRTB.Size = New System.Drawing.Size(103, 70)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.CutToolStripMenuItem.Text = "C&ut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'TabPageCloseAccount
        '
        Me.TabPageCloseAccount.Controls.Add(Me.CheckBoxInactive)
        Me.TabPageCloseAccount.Controls.Add(Me.Label13)
        Me.TabPageCloseAccount.Controls.Add(Me.RichTextBoxCollectionNotes)
        Me.TabPageCloseAccount.Controls.Add(Me.CheckBoxSentToCollections)
        Me.TabPageCloseAccount.Location = New System.Drawing.Point(4, 22)
        Me.TabPageCloseAccount.Name = "TabPageCloseAccount"
        Me.TabPageCloseAccount.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCloseAccount.Size = New System.Drawing.Size(716, 414)
        Me.TabPageCloseAccount.TabIndex = 3
        Me.TabPageCloseAccount.Text = "Close Account"
        Me.TabPageCloseAccount.UseVisualStyleBackColor = true
        '
        'CheckBoxInactive
        '
        Me.CheckBoxInactive.AutoSize = true
        Me.CheckBoxInactive.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CustomerBindingSource, "Inactive", true))
        Me.CheckBoxInactive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CheckBoxInactive.ForeColor = System.Drawing.Color.Red
        Me.CheckBoxInactive.Location = New System.Drawing.Point(28, 28)
        Me.CheckBoxInactive.Name = "CheckBoxInactive"
        Me.CheckBoxInactive.Size = New System.Drawing.Size(131, 17)
        Me.CheckBoxInactive.TabIndex = 25
        Me.CheckBoxInactive.Text = "Inactive Customer"
        Me.CheckBoxInactive.UseVisualStyleBackColor = true
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label13.Location = New System.Drawing.Point(25, 110)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Notes"
        '
        'RichTextBoxCollectionNotes
        '
        Me.RichTextBoxCollectionNotes.ContextMenuStrip = Me.ContextMenuStripRTB
        Me.RichTextBoxCollectionNotes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CollectionNotes", true))
        Me.RichTextBoxCollectionNotes.Location = New System.Drawing.Point(28, 132)
        Me.RichTextBoxCollectionNotes.Name = "RichTextBoxCollectionNotes"
        Me.RichTextBoxCollectionNotes.Size = New System.Drawing.Size(624, 265)
        Me.RichTextBoxCollectionNotes.TabIndex = 3
        Me.RichTextBoxCollectionNotes.Text = ""
        '
        'CheckBoxSentToCollections
        '
        Me.CheckBoxSentToCollections.AutoSize = true
        Me.CheckBoxSentToCollections.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CustomerBindingSource, "SendToCollections", true))
        Me.CheckBoxSentToCollections.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CheckBoxSentToCollections.ForeColor = System.Drawing.Color.Blue
        Me.CheckBoxSentToCollections.Location = New System.Drawing.Point(28, 70)
        Me.CheckBoxSentToCollections.Name = "CheckBoxSentToCollections"
        Me.CheckBoxSentToCollections.Size = New System.Drawing.Size(257, 17)
        Me.CheckBoxSentToCollections.TabIndex = 1
        Me.CheckBoxSentToCollections.Text = "This account has been sent to collections"
        Me.CheckBoxSentToCollections.UseVisualStyleBackColor = true
        '
        'ButtonSaveAndClose
        '
        Me.ButtonSaveAndClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ButtonSaveAndClose.Location = New System.Drawing.Point(504, 458)
        Me.ButtonSaveAndClose.Name = "ButtonSaveAndClose"
        Me.ButtonSaveAndClose.Size = New System.Drawing.Size(151, 23)
        Me.ButtonSaveAndClose.TabIndex = 2
        Me.ButtonSaveAndClose.Text = "Save and Close"
        Me.ButtonSaveAndClose.UseVisualStyleBackColor = true
        '
        'RentalCustomerEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 493)
        Me.Controls.Add(Me.ButtonSaveAndClose)
        Me.Controls.Add(Me.TabControlCustomer)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonSave)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "RentalCustomerEntry"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Rental Customer Entry"
        CType(Me.CustomerBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBoxRoute.ResumeLayout(false)
        Me.GroupBoxRoute.PerformLayout
        Me.GroupBoxBillingAddress.ResumeLayout(false)
        Me.GroupBoxBillingAddress.PerformLayout
        Me.TabControlCustomer.ResumeLayout(false)
        Me.TabPageCustomerInfo.ResumeLayout(false)
        Me.TabPageCustomerInfo.PerformLayout
        Me.TabPagePickupDays.ResumeLayout(false)
        Me.TabPagePickupDays.PerformLayout
        CType(Me.DataGridViewPickupDays,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPageComments.ResumeLayout(false)
        Me.TabPageComments.PerformLayout
        Me.ContextMenuStripRTB.ResumeLayout(false)
        Me.TabPageCloseAccount.ResumeLayout(false)
        Me.TabPageCloseAccount.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Billing_AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Billing_CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Billing_FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Billing_LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Billing_StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Billing_ZipCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BusinessPhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HomePhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RouteLocation_AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RouteLocation_CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RouteLocation_FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RouteLocation_LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RouteLocation_StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RouteLocation_ZipCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxRoute As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxBillingAddress As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxSameAsRoute As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents TabControlCustomer As System.Windows.Forms.TabControl
    Friend WithEvents TabPageCustomerInfo As System.Windows.Forms.TabPage
    Friend WithEvents ButtonSaveAndClose As System.Windows.Forms.Button
    Friend WithEvents TextBoxMonthsToBill As System.Windows.Forms.TextBox
    Friend WithEvents TabPageComments As System.Windows.Forms.TabPage
    Friend WithEvents TextBoxLMB As System.Windows.Forms.TextBox
    Friend WithEvents TabPageCloseAccount As System.Windows.Forms.TabPage
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents RichTextBoxCollectionNotes As System.Windows.Forms.RichTextBox
    Friend WithEvents CheckBoxSentToCollections As System.Windows.Forms.CheckBox
    Friend WithEvents TabPagePickupDays As System.Windows.Forms.TabPage
    Friend WithEvents TextBoxPO As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxRouteNumber As System.Windows.Forms.ComboBox
    Friend WithEvents SequenceNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxFax As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEMailAddress As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTaxRate As System.Windows.Forms.TextBox
    Friend WithEvents CardboardRentalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cart90GallonRentalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RollOffRentalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DumpsterRentalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxRecycleCharge As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCardboardCharge As System.Windows.Forms.TextBox
    Friend WithEvents TextBox90GallonCarts As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxRollOffCharge As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDumpsterCharge As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxSendBillEmail As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxOwner As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxContact As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxRecyclePUCharge As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxCardboardPUCharge As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxDumpsterPUCharge As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewPickupDays As System.Windows.Forms.DataGridView
    Friend WithEvents CheckBoxUsePOForAll As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonDeleteSelectedLine As System.Windows.Forms.Button
    Friend WithEvents CheckBoxRequiresPaperwork As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBoxCartPUCharge As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxRecycleRental As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxPrintBill As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxInactive As System.Windows.Forms.CheckBox
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSeqNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colType As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colDays As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colLoadType As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colDumpsterSize As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colRoute As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMisc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTruckNotes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RichTextBoxComments As System.Windows.Forms.RichTextBox
    Friend WithEvents ContextMenuStripRTB As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

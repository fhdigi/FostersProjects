<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RollOffServiceEdit
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
        Me.TextBoxAddress = New System.Windows.Forms.TextBox()
        Me.TextBoxCity = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxState = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxZipCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.GroupBoxRollOffBilling = New System.Windows.Forms.GroupBox()
        Me.CheckBoxUseRollingBillingInfo = New System.Windows.Forms.CheckBox()
        Me.TextBoxRollOffBillingZipCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxRollOffBillingState = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxRollOffBillingCity = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxRollOffBillingAddress = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxRollOffBillingName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBoxRollOffBilling.SuspendLayout
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Address"
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Location = New System.Drawing.Point(15, 39)
        Me.TextBoxAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(331, 25)
        Me.TextBoxAddress.TabIndex = 1
        '
        'TextBoxCity
        '
        Me.TextBoxCity.Location = New System.Drawing.Point(15, 103)
        Me.TextBoxCity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxCity.Name = "TextBoxCity"
        Me.TextBoxCity.Size = New System.Drawing.Size(167, 25)
        Me.TextBoxCity.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(12, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "City"
        '
        'TextBoxState
        '
        Me.TextBoxState.Location = New System.Drawing.Point(190, 103)
        Me.TextBoxState.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxState.Name = "TextBoxState"
        Me.TextBoxState.Size = New System.Drawing.Size(58, 25)
        Me.TextBoxState.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(187, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "State"
        '
        'TextBoxZipCode
        '
        Me.TextBoxZipCode.Location = New System.Drawing.Point(256, 103)
        Me.TextBoxZipCode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxZipCode.Name = "TextBoxZipCode"
        Me.TextBoxZipCode.Size = New System.Drawing.Size(90, 25)
        Me.TextBoxZipCode.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(252, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Zip Code"
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ButtonCancel.Location = New System.Drawing.Point(290, 437)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(87, 30)
        Me.ButtonCancel.TabIndex = 11
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = true
        '
        'ButtonSave
        '
        Me.ButtonSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ButtonSave.Location = New System.Drawing.Point(196, 437)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(87, 30)
        Me.ButtonSave.TabIndex = 10
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = true
        '
        'GroupBoxRollOffBilling
        '
        Me.GroupBoxRollOffBilling.Controls.Add(Me.TextBoxRollOffBillingName)
        Me.GroupBoxRollOffBilling.Controls.Add(Me.Label9)
        Me.GroupBoxRollOffBilling.Controls.Add(Me.TextBoxRollOffBillingZipCode)
        Me.GroupBoxRollOffBilling.Controls.Add(Me.Label5)
        Me.GroupBoxRollOffBilling.Controls.Add(Me.TextBoxRollOffBillingState)
        Me.GroupBoxRollOffBilling.Controls.Add(Me.Label6)
        Me.GroupBoxRollOffBilling.Controls.Add(Me.TextBoxRollOffBillingCity)
        Me.GroupBoxRollOffBilling.Controls.Add(Me.Label7)
        Me.GroupBoxRollOffBilling.Controls.Add(Me.TextBoxRollOffBillingAddress)
        Me.GroupBoxRollOffBilling.Controls.Add(Me.Label8)
        Me.GroupBoxRollOffBilling.Enabled = false
        Me.GroupBoxRollOffBilling.Location = New System.Drawing.Point(15, 191)
        Me.GroupBoxRollOffBilling.Name = "GroupBoxRollOffBilling"
        Me.GroupBoxRollOffBilling.Size = New System.Drawing.Size(362, 218)
        Me.GroupBoxRollOffBilling.TabIndex = 9
        Me.GroupBoxRollOffBilling.TabStop = false
        '
        'CheckBoxUseRollingBillingInfo
        '
        Me.CheckBoxUseRollingBillingInfo.AutoSize = true
        Me.CheckBoxUseRollingBillingInfo.Location = New System.Drawing.Point(15, 168)
        Me.CheckBoxUseRollingBillingInfo.Name = "CheckBoxUseRollingBillingInfo"
        Me.CheckBoxUseRollingBillingInfo.Size = New System.Drawing.Size(246, 21)
        Me.CheckBoxUseRollingBillingInfo.TabIndex = 8
        Me.CheckBoxUseRollingBillingInfo.Text = "Use Name / Address Below for Billing"
        Me.CheckBoxUseRollingBillingInfo.UseVisualStyleBackColor = true
        '
        'TextBoxRollOffBillingZipCode
        '
        Me.TextBoxRollOffBillingZipCode.Location = New System.Drawing.Point(257, 167)
        Me.TextBoxRollOffBillingZipCode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxRollOffBillingZipCode.Name = "TextBoxRollOffBillingZipCode"
        Me.TextBoxRollOffBillingZipCode.Size = New System.Drawing.Size(90, 25)
        Me.TextBoxRollOffBillingZipCode.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(253, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Zip Code"
        '
        'TextBoxRollOffBillingState
        '
        Me.TextBoxRollOffBillingState.Location = New System.Drawing.Point(191, 167)
        Me.TextBoxRollOffBillingState.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxRollOffBillingState.Name = "TextBoxRollOffBillingState"
        Me.TextBoxRollOffBillingState.Size = New System.Drawing.Size(58, 25)
        Me.TextBoxRollOffBillingState.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(188, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "State"
        '
        'TextBoxRollOffBillingCity
        '
        Me.TextBoxRollOffBillingCity.Location = New System.Drawing.Point(16, 167)
        Me.TextBoxRollOffBillingCity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxRollOffBillingCity.Name = "TextBoxRollOffBillingCity"
        Me.TextBoxRollOffBillingCity.Size = New System.Drawing.Size(167, 25)
        Me.TextBoxRollOffBillingCity.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(13, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "City"
        '
        'TextBoxRollOffBillingAddress
        '
        Me.TextBoxRollOffBillingAddress.Location = New System.Drawing.Point(16, 103)
        Me.TextBoxRollOffBillingAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxRollOffBillingAddress.Name = "TextBoxRollOffBillingAddress"
        Me.TextBoxRollOffBillingAddress.Size = New System.Drawing.Size(331, 25)
        Me.TextBoxRollOffBillingAddress.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Location = New System.Drawing.Point(13, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Address"
        '
        'TextBoxRollOffBillingName
        '
        Me.TextBoxRollOffBillingName.Location = New System.Drawing.Point(17, 38)
        Me.TextBoxRollOffBillingName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxRollOffBillingName.Name = "TextBoxRollOffBillingName"
        Me.TextBoxRollOffBillingName.Size = New System.Drawing.Size(331, 25)
        Me.TextBoxRollOffBillingName.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Location = New System.Drawing.Point(14, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Name"
        '
        'RollOffServiceEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 480)
        Me.Controls.Add(Me.CheckBoxUseRollingBillingInfo)
        Me.Controls.Add(Me.GroupBoxRollOffBilling)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.TextBoxZipCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxState)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxCity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxAddress)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "RollOffServiceEdit"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Service Address"
        Me.GroupBoxRollOffBilling.ResumeLayout(false)
        Me.GroupBoxRollOffBilling.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxAddress As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCity As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxState As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxZipCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents GroupBoxRollOffBilling As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxRollOffBillingName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBoxRollOffBillingZipCode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxRollOffBillingState As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxRollOffBillingCity As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxRollOffBillingAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxUseRollingBillingInfo As System.Windows.Forms.CheckBox
End Class

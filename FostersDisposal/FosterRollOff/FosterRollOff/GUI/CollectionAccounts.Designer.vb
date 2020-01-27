<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CollectionAccounts
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
        Me.ListViewAccounts = New System.Windows.Forms.ListView()
        Me.ColumnHeaderAccountNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderCustomer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderBalance = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderDateAsOf = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ButtonEnterPayment = New System.Windows.Forms.Button()
        Me.ButtonViewRecord = New System.Windows.Forms.Button()
        Me.ButtonEnterCharge = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ColumnHeaderBillingAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderRollOffAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Active Accounts Sent to Collections"
        '
        'ListViewAccounts
        '
        Me.ListViewAccounts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewAccounts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderAccountNumber, Me.ColumnHeaderCustomer, Me.ColumnHeaderBillingAddress, Me.ColumnHeaderRollOffAddress, Me.ColumnHeaderBalance, Me.ColumnHeaderDateAsOf})
        Me.ListViewAccounts.FullRowSelect = True
        Me.ListViewAccounts.HideSelection = False
        Me.ListViewAccounts.Location = New System.Drawing.Point(27, 50)
        Me.ListViewAccounts.Name = "ListViewAccounts"
        Me.ListViewAccounts.Size = New System.Drawing.Size(1011, 345)
        Me.ListViewAccounts.TabIndex = 1
        Me.ListViewAccounts.UseCompatibleStateImageBehavior = False
        Me.ListViewAccounts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderAccountNumber
        '
        Me.ColumnHeaderAccountNumber.Text = "Account"
        Me.ColumnHeaderAccountNumber.Width = 100
        '
        'ColumnHeaderCustomer
        '
        Me.ColumnHeaderCustomer.Text = "Customer"
        Me.ColumnHeaderCustomer.Width = 250
        '
        'ColumnHeaderBalance
        '
        Me.ColumnHeaderBalance.Text = "Balance"
        Me.ColumnHeaderBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderBalance.Width = 80
        '
        'ColumnHeaderDateAsOf
        '
        Me.ColumnHeaderDateAsOf.Text = "Date Sent"
        Me.ColumnHeaderDateAsOf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeaderDateAsOf.Width = 100
        '
        'ButtonEnterPayment
        '
        Me.ButtonEnterPayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonEnterPayment.Location = New System.Drawing.Point(1055, 50)
        Me.ButtonEnterPayment.Name = "ButtonEnterPayment"
        Me.ButtonEnterPayment.Size = New System.Drawing.Size(180, 25)
        Me.ButtonEnterPayment.TabIndex = 2
        Me.ButtonEnterPayment.Text = "Enter Payment"
        Me.ButtonEnterPayment.UseVisualStyleBackColor = True
        '
        'ButtonViewRecord
        '
        Me.ButtonViewRecord.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonViewRecord.Location = New System.Drawing.Point(1055, 112)
        Me.ButtonViewRecord.Name = "ButtonViewRecord"
        Me.ButtonViewRecord.Size = New System.Drawing.Size(180, 25)
        Me.ButtonViewRecord.TabIndex = 3
        Me.ButtonViewRecord.Text = "View Customer Record..."
        Me.ButtonViewRecord.UseVisualStyleBackColor = True
        '
        'ButtonEnterCharge
        '
        Me.ButtonEnterCharge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonEnterCharge.Location = New System.Drawing.Point(1055, 81)
        Me.ButtonEnterCharge.Name = "ButtonEnterCharge"
        Me.ButtonEnterCharge.Size = New System.Drawing.Size(180, 25)
        Me.ButtonEnterCharge.TabIndex = 4
        Me.ButtonEnterCharge.Text = "Enter Charge"
        Me.ButtonEnterCharge.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.Location = New System.Drawing.Point(1055, 143)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(180, 25)
        Me.ButtonClose.TabIndex = 5
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ColumnHeaderBillingAddress
        '
        Me.ColumnHeaderBillingAddress.Text = "Billing Address"
        Me.ColumnHeaderBillingAddress.Width = 225
        '
        'ColumnHeaderRollOffAddress
        '
        Me.ColumnHeaderRollOffAddress.Text = "Roll Off Address"
        Me.ColumnHeaderRollOffAddress.Width = 225
        '
        'CollectionAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1249, 407)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonEnterCharge)
        Me.Controls.Add(Me.ButtonViewRecord)
        Me.Controls.Add(Me.ButtonEnterPayment)
        Me.Controls.Add(Me.ListViewAccounts)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CollectionAccounts"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Collection Accounts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListViewAccounts As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeaderAccountNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderCustomer As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderBalance As System.Windows.Forms.ColumnHeader
    Friend WithEvents ButtonEnterPayment As System.Windows.Forms.Button
    Friend WithEvents ButtonViewRecord As System.Windows.Forms.Button
    Friend WithEvents ButtonEnterCharge As System.Windows.Forms.Button
    Friend WithEvents ColumnHeaderDateAsOf As System.Windows.Forms.ColumnHeader
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ColumnHeaderBillingAddress As ColumnHeader
    Friend WithEvents ColumnHeaderRollOffAddress As ColumnHeader
End Class

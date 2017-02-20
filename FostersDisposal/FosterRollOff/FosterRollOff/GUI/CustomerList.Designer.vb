<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerList
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
        Me.PropertyGridCustomer = New System.Windows.Forms.PropertyGrid()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ListViewCustomers = New System.Windows.Forms.ListView()
        Me.chAcctNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PropertyGridCustomer
        '
        Me.PropertyGridCustomer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PropertyGridCustomer.Location = New System.Drawing.Point(682, 51)
        Me.PropertyGridCustomer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PropertyGridCustomer.Name = "PropertyGridCustomer"
        Me.PropertyGridCustomer.Size = New System.Drawing.Size(372, 583)
        Me.PropertyGridCustomer.TabIndex = 4
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(12, 642)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(87, 30)
        Me.ButtonDelete.TabIndex = 5
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ListViewCustomers
        '
        Me.ListViewCustomers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chAcctNumber, Me.chName, Me.chAddress})
        Me.ListViewCustomers.FullRowSelect = True
        Me.ListViewCustomers.Location = New System.Drawing.Point(14, 51)
        Me.ListViewCustomers.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListViewCustomers.Name = "ListViewCustomers"
        Me.ListViewCustomers.Size = New System.Drawing.Size(640, 583)
        Me.ListViewCustomers.TabIndex = 3
        Me.ListViewCustomers.UseCompatibleStateImageBehavior = False
        Me.ListViewCustomers.View = System.Windows.Forms.View.Details
        '
        'chAcctNumber
        '
        Me.chAcctNumber.Text = "Acct #"
        Me.chAcctNumber.Width = 80
        '
        'chName
        '
        Me.chName.Text = "Client Name"
        Me.chName.Width = 200
        '
        'chAddress
        '
        Me.chAddress.Text = "Address"
        Me.chAddress.Width = 325
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(68, 16)
        Me.TextBoxSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(290, 25)
        Me.TextBoxSearch.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search"
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(365, 13)
        Me.ButtonRefresh.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(87, 30)
        Me.ButtonRefresh.TabIndex = 2
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.Location = New System.Drawing.Point(967, 642)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(87, 30)
        Me.ButtonClose.TabIndex = 7
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'CustomerList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 685)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.ListViewCustomers)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.PropertyGridCustomer)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustomerList"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PropertyGridCustomer As System.Windows.Forms.PropertyGrid
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ListViewCustomers As System.Windows.Forms.ListView
    Friend WithEvents chAcctNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents chName As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBoxSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents chAddress As System.Windows.Forms.ColumnHeader
End Class

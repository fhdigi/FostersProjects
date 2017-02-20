<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InactiveRollOffs
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
        Me.ListViewRollOffs = New System.Windows.Forms.ListView()
        Me.chCustomer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonMakeActive = New System.Windows.Forms.Button()
        Me.ButtonViewBillingHistory = New System.Windows.Forms.Button()
        Me.TimerMain = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonRollOffInfo = New System.Windows.Forms.Button()
        Me.chServiceAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chBillingAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListViewRollOffs
        '
        Me.ListViewRollOffs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chCustomer, Me.chDate, Me.chServiceAddress, Me.chBillingAddress})
        Me.ListViewRollOffs.FullRowSelect = True
        Me.ListViewRollOffs.HideSelection = False
        Me.ListViewRollOffs.Location = New System.Drawing.Point(16, 46)
        Me.ListViewRollOffs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListViewRollOffs.Name = "ListViewRollOffs"
        Me.ListViewRollOffs.Size = New System.Drawing.Size(938, 301)
        Me.ListViewRollOffs.TabIndex = 4
        Me.ListViewRollOffs.UseCompatibleStateImageBehavior = False
        Me.ListViewRollOffs.View = System.Windows.Forms.View.Details
        '
        'chCustomer
        '
        Me.chCustomer.Text = "Customer"
        Me.chCustomer.Width = 297
        '
        'chDate
        '
        Me.chDate.Text = "Drop Off Date"
        Me.chDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chDate.Width = 169
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inactive Roll Offs"
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.Location = New System.Drawing.Point(867, 360)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(87, 30)
        Me.ButtonClose.TabIndex = 8
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonMakeActive
        '
        Me.ButtonMakeActive.Location = New System.Drawing.Point(16, 360)
        Me.ButtonMakeActive.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonMakeActive.Name = "ButtonMakeActive"
        Me.ButtonMakeActive.Size = New System.Drawing.Size(133, 30)
        Me.ButtonMakeActive.TabIndex = 5
        Me.ButtonMakeActive.Text = "Make Active"
        Me.ButtonMakeActive.UseVisualStyleBackColor = True
        '
        'ButtonViewBillingHistory
        '
        Me.ButtonViewBillingHistory.Enabled = False
        Me.ButtonViewBillingHistory.Location = New System.Drawing.Point(353, 360)
        Me.ButtonViewBillingHistory.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonViewBillingHistory.Name = "ButtonViewBillingHistory"
        Me.ButtonViewBillingHistory.Size = New System.Drawing.Size(180, 30)
        Me.ButtonViewBillingHistory.TabIndex = 7
        Me.ButtonViewBillingHistory.Text = "View Billing History..."
        Me.ButtonViewBillingHistory.UseVisualStyleBackColor = True
        '
        'TimerMain
        '
        Me.TimerMain.Enabled = True
        '
        'ButtonRollOffInfo
        '
        Me.ButtonRollOffInfo.Enabled = False
        Me.ButtonRollOffInfo.Location = New System.Drawing.Point(161, 360)
        Me.ButtonRollOffInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonRollOffInfo.Name = "ButtonRollOffInfo"
        Me.ButtonRollOffInfo.Size = New System.Drawing.Size(180, 30)
        Me.ButtonRollOffInfo.TabIndex = 6
        Me.ButtonRollOffInfo.Text = "View RollOff Info..."
        Me.ButtonRollOffInfo.UseVisualStyleBackColor = True
        '
        'chServiceAddress
        '
        Me.chServiceAddress.Text = "Service Address"
        Me.chServiceAddress.Width = 225
        '
        'chBillingAddress
        '
        Me.chBillingAddress.Text = "Billing Address"
        Me.chBillingAddress.Width = 225
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(455, 14)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(418, 25)
        Me.TextBoxSearch.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Image = Global.FosterRollOff.My.Resources.Resources.Note_Book_Search
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(378, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Search"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(879, 12)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(75, 27)
        Me.ButtonClear.TabIndex = 3
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'InactiveRollOffs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 403)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.ButtonRollOffInfo)
        Me.Controls.Add(Me.ButtonViewBillingHistory)
        Me.Controls.Add(Me.ButtonMakeActive)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListViewRollOffs)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InactiveRollOffs"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inactive Roll Offs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListViewRollOffs As System.Windows.Forms.ListView
    Friend WithEvents chCustomer As System.Windows.Forms.ColumnHeader
    Friend WithEvents chDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ButtonMakeActive As System.Windows.Forms.Button
    Friend WithEvents ButtonViewBillingHistory As System.Windows.Forms.Button
    Friend WithEvents TimerMain As System.Windows.Forms.Timer
    Friend WithEvents ButtonRollOffInfo As System.Windows.Forms.Button
    Friend WithEvents chServiceAddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents chBillingAddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBoxSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
End Class

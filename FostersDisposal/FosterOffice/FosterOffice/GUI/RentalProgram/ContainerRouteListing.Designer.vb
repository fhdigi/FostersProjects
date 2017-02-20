<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContainerRouteListing
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
        Dim ListViewGroup11 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Unassigned Route", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup12 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Route 1", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup13 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Route 2", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup14 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Route 3", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup15 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Route 4", System.Windows.Forms.HorizontalAlignment.Left)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxDay = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxRoute = New System.Windows.Forms.ComboBox()
        Me.ListViewRoutes = New System.Windows.Forms.ListView()
        Me.ColumnHeaderCustomer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListViewMainList = New System.Windows.Forms.ListView()
        Me.colCustomer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colLoadType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ButtonAddToRoute = New System.Windows.Forms.Button()
        Me.ButtonSaveRoute = New System.Windows.Forms.Button()
        Me.ButtonRemoveFromRoute = New System.Windows.Forms.Button()
        Me.ButtonMasterTruckRoute = New System.Windows.Forms.Button()
        Me.ButtonViewCustomer = New System.Windows.Forms.Button()
        Me.ButtonMasterOfficeRoute = New System.Windows.Forms.Button()
        Me.ButtonSaveRouteAndClose = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonMoveToRoute1 = New System.Windows.Forms.Button()
        Me.ButtonMoveToRoute2 = New System.Windows.Forms.Button()
        Me.ButtonMoveToRoute3 = New System.Windows.Forms.Button()
        Me.ButtonMoveToRoute4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonTablet1 = New System.Windows.Forms.Button()
        Me.ButtonTablet2 = New System.Windows.Forms.Button()
        Me.ButtonTablet3 = New System.Windows.Forms.Button()
        Me.ButtonCreateRecycleListing = New System.Windows.Forms.Button()
        Me.ButtonRename = New System.Windows.Forms.Button()
        Me.ButtonDeleteRouteListDesc = New System.Windows.Forms.Button()
        Me.ButtonRemoveManual = New System.Windows.Forms.Button()
        Me.TimerMain = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Day"
        '
        'ComboBoxDay
        '
        Me.ComboBoxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDay.FormattingEnabled = True
        Me.ComboBoxDay.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        Me.ComboBoxDay.Location = New System.Drawing.Point(12, 25)
        Me.ComboBoxDay.Name = "ComboBoxDay"
        Me.ComboBoxDay.Size = New System.Drawing.Size(173, 21)
        Me.ComboBoxDay.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(385, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Route/Tablet"
        '
        'ComboBoxRoute
        '
        Me.ComboBoxRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRoute.FormattingEnabled = True
        Me.ComboBoxRoute.Items.AddRange(New Object() {"Route 1", "Route 2", "Route 3", "Route 4", "Tablet 1", "Tablet 2", "Tablet 3"})
        Me.ComboBoxRoute.Location = New System.Drawing.Point(388, 25)
        Me.ComboBoxRoute.Name = "ComboBoxRoute"
        Me.ComboBoxRoute.Size = New System.Drawing.Size(312, 21)
        Me.ComboBoxRoute.TabIndex = 7
        '
        'ListViewRoutes
        '
        Me.ListViewRoutes.AllowDrop = True
        Me.ListViewRoutes.CheckBoxes = True
        Me.ListViewRoutes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderCustomer, Me.ColumnHeaderAddress})
        Me.ListViewRoutes.FullRowSelect = True
        Me.ListViewRoutes.Location = New System.Drawing.Point(731, 96)
        Me.ListViewRoutes.Name = "ListViewRoutes"
        Me.ListViewRoutes.Size = New System.Drawing.Size(438, 384)
        Me.ListViewRoutes.TabIndex = 8
        Me.ListViewRoutes.UseCompatibleStateImageBehavior = False
        Me.ListViewRoutes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderCustomer
        '
        Me.ColumnHeaderCustomer.Text = "Customer"
        Me.ColumnHeaderCustomer.Width = 200
        '
        'ColumnHeaderAddress
        '
        Me.ColumnHeaderAddress.Text = "Address"
        Me.ColumnHeaderAddress.Width = 200
        '
        'ListViewMainList
        '
        Me.ListViewMainList.CheckBoxes = True
        Me.ListViewMainList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colCustomer, Me.colAddress, Me.colSize, Me.colLoadType, Me.colType})
        Me.ListViewMainList.FullRowSelect = True
        ListViewGroup11.Header = "Unassigned Route"
        ListViewGroup11.Name = "ListViewGroupUnassigned"
        ListViewGroup12.Header = "Route 1"
        ListViewGroup12.Name = "ListViewGroupRoute1"
        ListViewGroup13.Header = "Route 2"
        ListViewGroup13.Name = "ListViewGroupRoute2"
        ListViewGroup14.Header = "Route 3"
        ListViewGroup14.Name = "ListViewGroupRoute3"
        ListViewGroup15.Header = "Route 4"
        ListViewGroup15.Name = "ListViewGroupRoute4"
        Me.ListViewMainList.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup11, ListViewGroup12, ListViewGroup13, ListViewGroup14, ListViewGroup15})
        Me.ListViewMainList.Location = New System.Drawing.Point(12, 96)
        Me.ListViewMainList.Name = "ListViewMainList"
        Me.ListViewMainList.Size = New System.Drawing.Size(596, 384)
        Me.ListViewMainList.TabIndex = 2
        Me.ListViewMainList.UseCompatibleStateImageBehavior = False
        Me.ListViewMainList.View = System.Windows.Forms.View.Details
        '
        'colCustomer
        '
        Me.colCustomer.Text = "Customer"
        Me.colCustomer.Width = 150
        '
        'colAddress
        '
        Me.colAddress.Text = "Address"
        Me.colAddress.Width = 200
        '
        'colSize
        '
        Me.colSize.Text = "Size"
        Me.colSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'colLoadType
        '
        Me.colLoadType.Text = "Load"
        Me.colLoadType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'colType
        '
        Me.colType.Text = "Type"
        Me.colType.Width = 100
        '
        'ButtonAddToRoute
        '
        Me.ButtonAddToRoute.Location = New System.Drawing.Point(614, 96)
        Me.ButtonAddToRoute.Name = "ButtonAddToRoute"
        Me.ButtonAddToRoute.Size = New System.Drawing.Size(111, 23)
        Me.ButtonAddToRoute.TabIndex = 4
        Me.ButtonAddToRoute.Text = "Add to Route"
        Me.ButtonAddToRoute.UseVisualStyleBackColor = True
        '
        'ButtonSaveRoute
        '
        Me.ButtonSaveRoute.Location = New System.Drawing.Point(932, 486)
        Me.ButtonSaveRoute.Name = "ButtonSaveRoute"
        Me.ButtonSaveRoute.Size = New System.Drawing.Size(139, 23)
        Me.ButtonSaveRoute.TabIndex = 12
        Me.ButtonSaveRoute.Text = "Save Route"
        Me.ButtonSaveRoute.UseVisualStyleBackColor = True
        '
        'ButtonRemoveFromRoute
        '
        Me.ButtonRemoveFromRoute.Location = New System.Drawing.Point(614, 125)
        Me.ButtonRemoveFromRoute.Name = "ButtonRemoveFromRoute"
        Me.ButtonRemoveFromRoute.Size = New System.Drawing.Size(111, 23)
        Me.ButtonRemoveFromRoute.TabIndex = 5
        Me.ButtonRemoveFromRoute.Text = "Remove from Route"
        Me.ButtonRemoveFromRoute.UseVisualStyleBackColor = True
        '
        'ButtonMasterTruckRoute
        '
        Me.ButtonMasterTruckRoute.Location = New System.Drawing.Point(731, 486)
        Me.ButtonMasterTruckRoute.Name = "ButtonMasterTruckRoute"
        Me.ButtonMasterTruckRoute.Size = New System.Drawing.Size(186, 23)
        Me.ButtonMasterTruckRoute.TabIndex = 9
        Me.ButtonMasterTruckRoute.Text = "Master Truck Route List"
        Me.ButtonMasterTruckRoute.UseVisualStyleBackColor = True
        '
        'ButtonViewCustomer
        '
        Me.ButtonViewCustomer.Location = New System.Drawing.Point(12, 486)
        Me.ButtonViewCustomer.Name = "ButtonViewCustomer"
        Me.ButtonViewCustomer.Size = New System.Drawing.Size(191, 23)
        Me.ButtonViewCustomer.TabIndex = 3
        Me.ButtonViewCustomer.Text = "View Customer Information..."
        Me.ButtonViewCustomer.UseVisualStyleBackColor = True
        Me.ButtonViewCustomer.Visible = False
        '
        'ButtonMasterOfficeRoute
        '
        Me.ButtonMasterOfficeRoute.Location = New System.Drawing.Point(731, 515)
        Me.ButtonMasterOfficeRoute.Name = "ButtonMasterOfficeRoute"
        Me.ButtonMasterOfficeRoute.Size = New System.Drawing.Size(186, 23)
        Me.ButtonMasterOfficeRoute.TabIndex = 10
        Me.ButtonMasterOfficeRoute.Text = "Master Office Route List"
        Me.ButtonMasterOfficeRoute.UseVisualStyleBackColor = True
        '
        'ButtonSaveRouteAndClose
        '
        Me.ButtonSaveRouteAndClose.Location = New System.Drawing.Point(932, 515)
        Me.ButtonSaveRouteAndClose.Name = "ButtonSaveRouteAndClose"
        Me.ButtonSaveRouteAndClose.Size = New System.Drawing.Size(139, 23)
        Me.ButtonSaveRouteAndClose.TabIndex = 13
        Me.ButtonSaveRouteAndClose.Text = "Save Route and Close"
        Me.ButtonSaveRouteAndClose.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(1077, 486)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(91, 23)
        Me.ButtonCancel.TabIndex = 14
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonMoveToRoute1
        '
        Me.ButtonMoveToRoute1.Location = New System.Drawing.Point(811, 4)
        Me.ButtonMoveToRoute1.Name = "ButtonMoveToRoute1"
        Me.ButtonMoveToRoute1.Size = New System.Drawing.Size(26, 23)
        Me.ButtonMoveToRoute1.TabIndex = 15
        Me.ButtonMoveToRoute1.Text = "1"
        Me.ButtonMoveToRoute1.UseVisualStyleBackColor = True
        '
        'ButtonMoveToRoute2
        '
        Me.ButtonMoveToRoute2.Location = New System.Drawing.Point(843, 4)
        Me.ButtonMoveToRoute2.Name = "ButtonMoveToRoute2"
        Me.ButtonMoveToRoute2.Size = New System.Drawing.Size(26, 23)
        Me.ButtonMoveToRoute2.TabIndex = 15
        Me.ButtonMoveToRoute2.Text = "2"
        Me.ButtonMoveToRoute2.UseVisualStyleBackColor = True
        '
        'ButtonMoveToRoute3
        '
        Me.ButtonMoveToRoute3.Location = New System.Drawing.Point(875, 4)
        Me.ButtonMoveToRoute3.Name = "ButtonMoveToRoute3"
        Me.ButtonMoveToRoute3.Size = New System.Drawing.Size(26, 23)
        Me.ButtonMoveToRoute3.TabIndex = 15
        Me.ButtonMoveToRoute3.Text = "3"
        Me.ButtonMoveToRoute3.UseVisualStyleBackColor = True
        '
        'ButtonMoveToRoute4
        '
        Me.ButtonMoveToRoute4.Location = New System.Drawing.Point(907, 4)
        Me.ButtonMoveToRoute4.Name = "ButtonMoveToRoute4"
        Me.ButtonMoveToRoute4.Size = New System.Drawing.Size(26, 23)
        Me.ButtonMoveToRoute4.TabIndex = 15
        Me.ButtonMoveToRoute4.Text = "4"
        Me.ButtonMoveToRoute4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(727, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Move to Route"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(727, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Move to Tablet"
        '
        'ButtonTablet1
        '
        Me.ButtonTablet1.Location = New System.Drawing.Point(811, 33)
        Me.ButtonTablet1.Name = "ButtonTablet1"
        Me.ButtonTablet1.Size = New System.Drawing.Size(26, 23)
        Me.ButtonTablet1.TabIndex = 15
        Me.ButtonTablet1.Text = "1"
        Me.ButtonTablet1.UseVisualStyleBackColor = True
        '
        'ButtonTablet2
        '
        Me.ButtonTablet2.Location = New System.Drawing.Point(843, 33)
        Me.ButtonTablet2.Name = "ButtonTablet2"
        Me.ButtonTablet2.Size = New System.Drawing.Size(26, 23)
        Me.ButtonTablet2.TabIndex = 15
        Me.ButtonTablet2.Text = "2"
        Me.ButtonTablet2.UseVisualStyleBackColor = True
        '
        'ButtonTablet3
        '
        Me.ButtonTablet3.Location = New System.Drawing.Point(875, 33)
        Me.ButtonTablet3.Name = "ButtonTablet3"
        Me.ButtonTablet3.Size = New System.Drawing.Size(26, 23)
        Me.ButtonTablet3.TabIndex = 15
        Me.ButtonTablet3.Text = "3"
        Me.ButtonTablet3.UseVisualStyleBackColor = True
        '
        'ButtonCreateRecycleListing
        '
        Me.ButtonCreateRecycleListing.Location = New System.Drawing.Point(979, 9)
        Me.ButtonCreateRecycleListing.Name = "ButtonCreateRecycleListing"
        Me.ButtonCreateRecycleListing.Size = New System.Drawing.Size(189, 23)
        Me.ButtonCreateRecycleListing.TabIndex = 16
        Me.ButtonCreateRecycleListing.Text = "Create Recycle Listing..."
        Me.ButtonCreateRecycleListing.UseVisualStyleBackColor = True
        '
        'ButtonRename
        '
        Me.ButtonRename.Location = New System.Drawing.Point(979, 38)
        Me.ButtonRename.Name = "ButtonRename"
        Me.ButtonRename.Size = New System.Drawing.Size(189, 23)
        Me.ButtonRename.TabIndex = 17
        Me.ButtonRename.Text = "Rename Recyle List Description..."
        Me.ButtonRename.UseVisualStyleBackColor = True
        '
        'ButtonDeleteRouteListDesc
        '
        Me.ButtonDeleteRouteListDesc.Location = New System.Drawing.Point(979, 67)
        Me.ButtonDeleteRouteListDesc.Name = "ButtonDeleteRouteListDesc"
        Me.ButtonDeleteRouteListDesc.Size = New System.Drawing.Size(189, 23)
        Me.ButtonDeleteRouteListDesc.TabIndex = 18
        Me.ButtonDeleteRouteListDesc.Text = "Delete Recyle List Description..."
        Me.ButtonDeleteRouteListDesc.UseVisualStyleBackColor = True
        '
        'ButtonRemoveManual
        '
        Me.ButtonRemoveManual.Enabled = False
        Me.ButtonRemoveManual.Location = New System.Drawing.Point(417, 486)
        Me.ButtonRemoveManual.Name = "ButtonRemoveManual"
        Me.ButtonRemoveManual.Size = New System.Drawing.Size(191, 23)
        Me.ButtonRemoveManual.TabIndex = 19
        Me.ButtonRemoveManual.Text = "Remove Manual from Listing..."
        Me.ButtonRemoveManual.UseVisualStyleBackColor = True
        '
        'TimerMain
        '
        Me.TimerMain.Enabled = True
        Me.TimerMain.Interval = 1000
        '
        'ContainerRouteListing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 547)
        Me.Controls.Add(Me.ButtonRemoveManual)
        Me.Controls.Add(Me.ButtonDeleteRouteListDesc)
        Me.Controls.Add(Me.ButtonRename)
        Me.Controls.Add(Me.ButtonCreateRecycleListing)
        Me.Controls.Add(Me.ButtonMoveToRoute4)
        Me.Controls.Add(Me.ButtonTablet3)
        Me.Controls.Add(Me.ButtonMoveToRoute3)
        Me.Controls.Add(Me.ButtonTablet2)
        Me.Controls.Add(Me.ButtonMoveToRoute2)
        Me.Controls.Add(Me.ButtonTablet1)
        Me.Controls.Add(Me.ButtonMoveToRoute1)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonViewCustomer)
        Me.Controls.Add(Me.ButtonMasterOfficeRoute)
        Me.Controls.Add(Me.ButtonMasterTruckRoute)
        Me.Controls.Add(Me.ButtonRemoveFromRoute)
        Me.Controls.Add(Me.ButtonSaveRouteAndClose)
        Me.Controls.Add(Me.ButtonSaveRoute)
        Me.Controls.Add(Me.ButtonAddToRoute)
        Me.Controls.Add(Me.ListViewMainList)
        Me.Controls.Add(Me.ListViewRoutes)
        Me.Controls.Add(Me.ComboBoxRoute)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxDay)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ContainerRouteListing"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Container Route Listing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxDay As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxRoute As System.Windows.Forms.ComboBox
    Friend WithEvents ListViewRoutes As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeaderCustomer As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderAddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListViewMainList As System.Windows.Forms.ListView
    Friend WithEvents colCustomer As System.Windows.Forms.ColumnHeader
    Friend WithEvents colAddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents ButtonAddToRoute As System.Windows.Forms.Button
    Friend WithEvents ButtonSaveRoute As System.Windows.Forms.Button
    Friend WithEvents ButtonRemoveFromRoute As System.Windows.Forms.Button
    Friend WithEvents ButtonMasterTruckRoute As System.Windows.Forms.Button
    Friend WithEvents ButtonViewCustomer As System.Windows.Forms.Button
    Friend WithEvents colType As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSize As System.Windows.Forms.ColumnHeader
    Friend WithEvents colLoadType As System.Windows.Forms.ColumnHeader
    Friend WithEvents ButtonMasterOfficeRoute As System.Windows.Forms.Button
    Friend WithEvents ButtonSaveRouteAndClose As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonMoveToRoute1 As System.Windows.Forms.Button
    Friend WithEvents ButtonMoveToRoute2 As System.Windows.Forms.Button
    Friend WithEvents ButtonMoveToRoute3 As System.Windows.Forms.Button
    Friend WithEvents ButtonMoveToRoute4 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ButtonTablet1 As System.Windows.Forms.Button
    Friend WithEvents ButtonTablet2 As System.Windows.Forms.Button
    Friend WithEvents ButtonTablet3 As System.Windows.Forms.Button
    Friend WithEvents ButtonCreateRecycleListing As System.Windows.Forms.Button
    Friend WithEvents ButtonRename As System.Windows.Forms.Button
    Friend WithEvents ButtonDeleteRouteListDesc As System.Windows.Forms.Button
    Friend WithEvents ButtonRemoveManual As System.Windows.Forms.Button
    Friend WithEvents TimerMain As System.Windows.Forms.Timer
End Class

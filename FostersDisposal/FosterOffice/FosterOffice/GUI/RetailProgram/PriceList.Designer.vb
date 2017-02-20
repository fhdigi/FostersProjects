<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PriceList
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
        Me.GridControlItemsCollected = New DevExpress.XtraGrid.GridControl()
        Me.ItemsCollectedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridViewItemsCollected = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMinimumPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaximumPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ButtonAddNewItem = New System.Windows.Forms.Button()
        Me.ButtonDeleteItem = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        CType(Me.GridControlItemsCollected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsCollectedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewItemsCollected, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControlItemsCollected
        '
        Me.GridControlItemsCollected.DataSource = Me.ItemsCollectedBindingSource
        Me.GridControlItemsCollected.Location = New System.Drawing.Point(12, 12)
        Me.GridControlItemsCollected.MainView = Me.GridViewItemsCollected
        Me.GridControlItemsCollected.Name = "GridControlItemsCollected"
        Me.GridControlItemsCollected.Size = New System.Drawing.Size(491, 295)
        Me.GridControlItemsCollected.TabIndex = 0
        Me.GridControlItemsCollected.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewItemsCollected})
        '
        'ItemsCollectedBindingSource
        '
        Me.ItemsCollectedBindingSource.DataSource = GetType(PickupTransaction.ItemsCollected)
        '
        'GridViewItemsCollected
        '
        Me.GridViewItemsCollected.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemDescription, Me.colMinimumPrice, Me.colMaximumPrice, Me.colID})
        Me.GridViewItemsCollected.GridControl = Me.GridControlItemsCollected
        Me.GridViewItemsCollected.Name = "GridViewItemsCollected"
        '
        'colItemDescription
        '
        Me.colItemDescription.FieldName = "ItemDescription"
        Me.colItemDescription.Name = "colItemDescription"
        Me.colItemDescription.Visible = True
        Me.colItemDescription.VisibleIndex = 0
        Me.colItemDescription.Width = 200
        '
        'colMinimumPrice
        '
        Me.colMinimumPrice.AppearanceCell.Options.UseTextOptions = True
        Me.colMinimumPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMinimumPrice.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colMinimumPrice.DisplayFormat.FormatString = "N2"
        Me.colMinimumPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMinimumPrice.FieldName = "MinimumPrice"
        Me.colMinimumPrice.Name = "colMinimumPrice"
        Me.colMinimumPrice.Visible = True
        Me.colMinimumPrice.VisibleIndex = 1
        Me.colMinimumPrice.Width = 89
        '
        'colMaximumPrice
        '
        Me.colMaximumPrice.AppearanceCell.Options.UseTextOptions = True
        Me.colMaximumPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaximumPrice.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colMaximumPrice.DisplayFormat.FormatString = "N2"
        Me.colMaximumPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMaximumPrice.FieldName = "MaximumPrice"
        Me.colMaximumPrice.Name = "colMaximumPrice"
        Me.colMaximumPrice.Visible = True
        Me.colMaximumPrice.VisibleIndex = 2
        Me.colMaximumPrice.Width = 89
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'ButtonAddNewItem
        '
        Me.ButtonAddNewItem.Location = New System.Drawing.Point(12, 322)
        Me.ButtonAddNewItem.Name = "ButtonAddNewItem"
        Me.ButtonAddNewItem.Size = New System.Drawing.Size(112, 23)
        Me.ButtonAddNewItem.TabIndex = 1
        Me.ButtonAddNewItem.Text = "Add New Item..."
        Me.ButtonAddNewItem.UseVisualStyleBackColor = True
        '
        'ButtonDeleteItem
        '
        Me.ButtonDeleteItem.Location = New System.Drawing.Point(130, 322)
        Me.ButtonDeleteItem.Name = "ButtonDeleteItem"
        Me.ButtonDeleteItem.Size = New System.Drawing.Size(112, 23)
        Me.ButtonDeleteItem.TabIndex = 2
        Me.ButtonDeleteItem.Text = "Delete Item"
        Me.ButtonDeleteItem.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(428, 322)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClose.TabIndex = 3
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'PriceList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 357)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonDeleteItem)
        Me.Controls.Add(Me.ButtonAddNewItem)
        Me.Controls.Add(Me.GridControlItemsCollected)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PriceList"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Price List"
        CType(Me.GridControlItemsCollected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsCollectedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewItemsCollected, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControlItemsCollected As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewItemsCollected As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ItemsCollectedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colItemDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMinimumPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaximumPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ButtonAddNewItem As System.Windows.Forms.Button
    Friend WithEvents ButtonDeleteItem As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
End Class

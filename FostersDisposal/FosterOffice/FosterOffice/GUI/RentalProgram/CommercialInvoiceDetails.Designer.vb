<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class CommercialInvoiceDetails
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabelDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelQty = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelDescription = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelUnitPrice = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelExtPrice = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabelDate, Me.XrLabelQty, Me.XrLabelDescription, Me.XrLabelUnitPrice, Me.XrLabelExtPrice})
        Me.Detail.HeightF = 23.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabelDate
        '
        Me.XrLabelDate.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabelDate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ServiceDate", "{0:MM/dd}")})
        Me.XrLabelDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabelDate.ForeColor = System.Drawing.Color.Black
        Me.XrLabelDate.LocationFloat = New DevExpress.Utils.PointFloat(15.0!, 0.0!)
        Me.XrLabelDate.Name = "XrLabelDate"
        Me.XrLabelDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelDate.SizeF = New System.Drawing.SizeF(75.0!, 23.0!)
        Me.XrLabelDate.StylePriority.UseBorders = False
        Me.XrLabelDate.StylePriority.UseFont = False
        Me.XrLabelDate.StylePriority.UseForeColor = False
        Me.XrLabelDate.StylePriority.UseTextAlignment = False
        Me.XrLabelDate.Text = "XrLabelDate"
        Me.XrLabelDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabelQty
        '
        Me.XrLabelQty.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabelQty.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Qty")})
        Me.XrLabelQty.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabelQty.ForeColor = System.Drawing.Color.Black
        Me.XrLabelQty.LocationFloat = New DevExpress.Utils.PointFloat(95.0!, 0.0!)
        Me.XrLabelQty.Name = "XrLabelQty"
        Me.XrLabelQty.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelQty.SizeF = New System.Drawing.SizeF(50.00009!, 23.0!)
        Me.XrLabelQty.StylePriority.UseBorders = False
        Me.XrLabelQty.StylePriority.UseFont = False
        Me.XrLabelQty.StylePriority.UseForeColor = False
        Me.XrLabelQty.StylePriority.UseTextAlignment = False
        Me.XrLabelQty.Text = "XrLabelQty"
        Me.XrLabelQty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabelDescription
        '
        Me.XrLabelDescription.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabelDescription.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Description")})
        Me.XrLabelDescription.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabelDescription.ForeColor = System.Drawing.Color.Black
        Me.XrLabelDescription.LocationFloat = New DevExpress.Utils.PointFloat(161.7501!, 0.0!)
        Me.XrLabelDescription.Name = "XrLabelDescription"
        Me.XrLabelDescription.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelDescription.SizeF = New System.Drawing.SizeF(427.833!, 23.0!)
        Me.XrLabelDescription.StylePriority.UseBorders = False
        Me.XrLabelDescription.StylePriority.UseFont = False
        Me.XrLabelDescription.StylePriority.UseForeColor = False
        Me.XrLabelDescription.StylePriority.UseTextAlignment = False
        Me.XrLabelDescription.Text = "XrLabelDescription"
        Me.XrLabelDescription.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelUnitPrice
        '
        Me.XrLabelUnitPrice.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabelUnitPrice.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "UnitPrice")})
        Me.XrLabelUnitPrice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabelUnitPrice.ForeColor = System.Drawing.Color.Black
        Me.XrLabelUnitPrice.LocationFloat = New DevExpress.Utils.PointFloat(589.5831!, 0.0!)
        Me.XrLabelUnitPrice.Name = "XrLabelUnitPrice"
        Me.XrLabelUnitPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelUnitPrice.SizeF = New System.Drawing.SizeF(101.0418!, 23.0!)
        Me.XrLabelUnitPrice.StylePriority.UseBorders = False
        Me.XrLabelUnitPrice.StylePriority.UseFont = False
        Me.XrLabelUnitPrice.StylePriority.UseForeColor = False
        Me.XrLabelUnitPrice.StylePriority.UseTextAlignment = False
        Me.XrLabelUnitPrice.Text = "XrLabelUnitPrice"
        Me.XrLabelUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabelExtPrice
        '
        Me.XrLabelExtPrice.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabelExtPrice.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Amount", "{0:f2}")})
        Me.XrLabelExtPrice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabelExtPrice.ForeColor = System.Drawing.Color.Black
        Me.XrLabelExtPrice.LocationFloat = New DevExpress.Utils.PointFloat(690.6249!, 0.0!)
        Me.XrLabelExtPrice.Name = "XrLabelExtPrice"
        Me.XrLabelExtPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelExtPrice.SizeF = New System.Drawing.SizeF(87.50012!, 23.0!)
        Me.XrLabelExtPrice.StylePriority.UseBorders = False
        Me.XrLabelExtPrice.StylePriority.UseFont = False
        Me.XrLabelExtPrice.StylePriority.UseForeColor = False
        Me.XrLabelExtPrice.StylePriority.UseTextAlignment = False
        Me.XrLabelExtPrice.Text = "XrLabelExtPrice"
        Me.XrLabelExtPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'PageHeader
        '
        Me.PageHeader.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageHeader.HeightF = 0.0!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.StylePriority.UseFont = False
        '
        'PageFooter
        '
        Me.PageFooter.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageFooter.HeightF = 0.0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.StylePriority.UseFont = False
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 0.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 0.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = GetType(FosterOffice.CRentalBillLineItems)
        '
        'CommercialInvoiceDetails
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.DataSource = Me.BindingSource1
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        Me.Version = "11.2"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLabelExtPrice As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelUnitPrice As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelDescription As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelQty As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
End Class

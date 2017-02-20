<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RevenueReport
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
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelTotalCollectedLessTax = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelMonthOf = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BindingSource1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel12, Me.XrLabel14, Me.XrLabel5, Me.XrLabel8, Me.XrLabel19, Me.XrLabel18, Me.XrLabel17, Me.XrLabel16, Me.XrLine2, Me.XrLabel15, Me.XrLabel13, Me.XrLabelTotalCollectedLessTax, Me.XrLabel11, Me.XrLine1, Me.XrLabel10, Me.XrLabel7, Me.XrLabel6, Me.XrLabel4, Me.XrLabel3})
        Me.Detail.Dpi = 100!
        Me.Detail.HeightF = 313.5417!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.Dpi = 100!
        Me.XrLabel12.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(47.91667!, 206.5833!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(203.125!, 23!)
        Me.XrLabel12.StylePriority.UseFont = false
        Me.XrLabel12.StylePriority.UseTextAlignment = false
        Me.XrLabel12.Text = "Total Cash / Check Other"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel14
        '
        Me.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalNonCreditCollected", "{0:c2}")})
        Me.XrLabel14.Dpi = 100!
        Me.XrLabel14.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(262.5!, 206.5833!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel14.StylePriority.UseFont = false
        Me.XrLabel14.StylePriority.UseTextAlignment = false
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel5
        '
        Me.XrLabel5.Dpi = 100!
        Me.XrLabel5.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(47.91667!, 232.625!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(203.125!, 23!)
        Me.XrLabel5.StylePriority.UseFont = false
        Me.XrLabel5.StylePriority.UseTextAlignment = false
        Me.XrLabel5.Text = "Total Credit Card"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalCreditCollected", "{0:c2}")})
        Me.XrLabel8.Dpi = 100!
        Me.XrLabel8.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(262.5!, 232.625!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel8.StylePriority.UseFont = false
        Me.XrLabel8.StylePriority.UseTextAlignment = false
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel19
        '
        Me.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalCollected", "{0:c2}")})
        Me.XrLabel19.Dpi = 100!
        Me.XrLabel19.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(262.5!, 258.6667!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel19.StylePriority.UseFont = false
        Me.XrLabel19.StylePriority.UseTextAlignment = false
        Me.XrLabel19.Text = "XrLabel7"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel18
        '
        Me.XrLabel18.Dpi = 100!
        Me.XrLabel18.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(47.91667!, 258.6667!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(203.125!, 23!)
        Me.XrLabel18.StylePriority.UseFont = false
        Me.XrLabel18.StylePriority.UseTextAlignment = false
        Me.XrLabel18.Text = "Total Collected"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel17
        '
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalTax", "{0:c2}")})
        Me.XrLabel17.Dpi = 100!
        Me.XrLabel17.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(262.5!, 151.375!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel17.StylePriority.UseFont = false
        Me.XrLabel17.StylePriority.UseTextAlignment = false
        Me.XrLabel17.Text = "XrLabel7"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel16
        '
        Me.XrLabel16.Dpi = 100!
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(47.91667!, 151.375!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(203.125!, 23!)
        Me.XrLabel16.StylePriority.UseTextAlignment = false
        Me.XrLabel16.Text = "Total Tax Collected"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine2
        '
        Me.XrLine2.Dpi = 100!
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(47.91667!, 149.375!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(314.5833!, 2!)
        '
        'XrLabel15
        '
        Me.XrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TaxCollected8Tax", "{0:c2}")})
        Me.XrLabel15.Dpi = 100!
        Me.XrLabel15.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(262.5!, 126.375!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel15.StylePriority.UseFont = false
        Me.XrLabel15.StylePriority.UseTextAlignment = false
        Me.XrLabel15.Text = "XrLabel7"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel13
        '
        Me.XrLabel13.Dpi = 100!
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(47.91667!, 126.375!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(203.125!, 23!)
        Me.XrLabel13.StylePriority.UseTextAlignment = false
        Me.XrLabel13.Text = "Tax Collected - 8%"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelTotalCollectedLessTax
        '
        Me.XrLabelTotalCollectedLessTax.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalIncome", "{0:c2}")})
        Me.XrLabelTotalCollectedLessTax.Dpi = 100!
        Me.XrLabelTotalCollectedLessTax.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold)
        Me.XrLabelTotalCollectedLessTax.LocationFloat = New DevExpress.Utils.PointFloat(262.5!, 82.37503!)
        Me.XrLabelTotalCollectedLessTax.Name = "XrLabelTotalCollectedLessTax"
        Me.XrLabelTotalCollectedLessTax.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelTotalCollectedLessTax.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelTotalCollectedLessTax.StylePriority.UseFont = false
        Me.XrLabelTotalCollectedLessTax.StylePriority.UseTextAlignment = false
        Me.XrLabelTotalCollectedLessTax.Text = "XrLabel7"
        Me.XrLabelTotalCollectedLessTax.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel11
        '
        Me.XrLabel11.Dpi = 100!
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(47.91667!, 82.37494!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(203.125!, 23!)
        Me.XrLabel11.StylePriority.UseTextAlignment = false
        Me.XrLabel11.Text = "Total Collected (Less Tax)"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine1
        '
        Me.XrLine1.Dpi = 100!
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(47.91667!, 80.37502!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(314.5833!, 2!)
        '
        'XrLabel10
        '
        Me.XrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Income8Tax", "{0:c2}")})
        Me.XrLabel10.Dpi = 100!
        Me.XrLabel10.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(262.5!, 57.375!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel10.StylePriority.UseFont = false
        Me.XrLabel10.StylePriority.UseTextAlignment = false
        Me.XrLabel10.Text = "XrLabel7"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IncomeNoTax", "{0:c2}")})
        Me.XrLabel7.Dpi = 100!
        Me.XrLabel7.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(262.5!, 34.375!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel7.StylePriority.UseFont = false
        Me.XrLabel7.StylePriority.UseTextAlignment = false
        Me.XrLabel7.Text = "XrLabel7"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel6
        '
        Me.XrLabel6.Dpi = 100!
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(47.91667!, 57.375!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(203.125!, 23!)
        Me.XrLabel6.StylePriority.UseTextAlignment = false
        Me.XrLabel6.Text = "From Collections - 8%"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.Dpi = 100!
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(47.91667!, 34.375!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(203.125!, 23!)
        Me.XrLabel4.StylePriority.UseTextAlignment = false
        Me.XrLabel4.Text = "From Collections - No Tax"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Dpi = 100!
        Me.XrLabel3.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(45.83333!, 0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(72.91667!, 23!)
        Me.XrLabel3.StylePriority.UseFont = false
        Me.XrLabel3.Text = "Income:"
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 100!
        Me.TopMargin.HeightF = 47.91667!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 100!
        Me.BottomMargin.HeightF = 100!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine3, Me.XrLabel21, Me.XrLabel20, Me.XrLabelMonthOf, Me.XrLabel9, Me.XrLabel2, Me.XrLabel1})
        Me.PageHeader.Dpi = 100!
        Me.PageHeader.HeightF = 123.875!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLine3
        '
        Me.XrLine3.Dpi = 100!
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(47.91667!, 90.62498!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(468.75!, 2!)
        '
        'XrLabel21
        '
        Me.XrLabel21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ReportEndDate", "{0:MMMM dd, yyyy}")})
        Me.XrLabel21.Dpi = 100!
        Me.XrLabel21.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold)
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(348.4999!, 67.625!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(151.6249!, 23!)
        Me.XrLabel21.StylePriority.UseFont = false
        Me.XrLabel21.StylePriority.UseTextAlignment = false
        Me.XrLabel21.Text = "Month Of:"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel20
        '
        Me.XrLabel20.Dpi = 100!
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(312.0416!, 67.625!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(26.04166!, 23!)
        Me.XrLabel20.StylePriority.UseTextAlignment = false
        Me.XrLabel20.Text = "to"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabelMonthOf
        '
        Me.XrLabelMonthOf.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ReportStartDate", "{0:MMMM dd, yyyy}")})
        Me.XrLabelMonthOf.Dpi = 100!
        Me.XrLabelMonthOf.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold)
        Me.XrLabelMonthOf.LocationFloat = New DevExpress.Utils.PointFloat(151.0417!, 67.625!)
        Me.XrLabelMonthOf.Name = "XrLabelMonthOf"
        Me.XrLabelMonthOf.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelMonthOf.SizeF = New System.Drawing.SizeF(148.4999!, 23!)
        Me.XrLabelMonthOf.StylePriority.UseFont = false
        Me.XrLabelMonthOf.StylePriority.UseTextAlignment = false
        Me.XrLabelMonthOf.Text = "Month Of:"
        Me.XrLabelMonthOf.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.Dpi = 100!
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(47.91667!, 67.625!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(103.125!, 23!)
        Me.XrLabel9.StylePriority.UseTextAlignment = false
        Me.XrLabel9.Text = "Report Range:"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.Dpi = 100!
        Me.XrLabel2.Font = New System.Drawing.Font("Verdana", 8!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(401.6667!, 0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(338.3333!, 23!)
        Me.XrLabel2.StylePriority.UseFont = false
        Me.XrLabel2.StylePriority.UseTextAlignment = false
        Me.XrLabel2.Text = "Revenue Report"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel1
        '
        Me.XrLabel1.Dpi = 100!
        Me.XrLabel1.Font = New System.Drawing.Font("Verdana", 12!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline),System.Drawing.FontStyle))
        Me.XrLabel1.ForeColor = System.Drawing.Color.Navy
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(313.4999!, 23!)
        Me.XrLabel1.StylePriority.UseFont = false
        Me.XrLabel1.StylePriority.UseForeColor = false
        Me.XrLabel1.Text = "Foster's Disposal Service LLC"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = GetType(PickupTransaction.Payments.CRevenueReport)
        '
        'RevenueReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader})
        Me.DataSource = Me.BindingSource1
        Me.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 48, 100)
        Me.Version = "16.1"
        CType(Me.BindingSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelTotalCollectedLessTax As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelMonthOf As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
End Class

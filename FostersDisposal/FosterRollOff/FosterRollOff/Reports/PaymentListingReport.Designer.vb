<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class PaymentListingReport
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
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTablePaymentSummary = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelCompanyHeader = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrSubreportCreditsIssued = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelTotal = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabelTotalChecks = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelTotalCash = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.BindingSourcePaymentData = New System.Windows.Forms.BindingSource(Me.components)
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelTotalCredit = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.XrTablePaymentSummary,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.XrTable2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.XrTable1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BindingSourcePaymentData,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTablePaymentSummary})
        Me.Detail.Dpi = 100!
        Me.Detail.HeightF = 25!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTablePaymentSummary
        '
        Me.XrTablePaymentSummary.Dpi = 100!
        Me.XrTablePaymentSummary.Font = New System.Drawing.Font("Arial", 8!)
        Me.XrTablePaymentSummary.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTablePaymentSummary.Name = "XrTablePaymentSummary"
        Me.XrTablePaymentSummary.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTablePaymentSummary.SizeF = New System.Drawing.SizeF(750!, 25!)
        Me.XrTablePaymentSummary.StylePriority.UseFont = false
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell7, Me.XrTableCell6})
        Me.XrTableRow1.Dpi = 100!
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AccountNumber")})
        Me.XrTableCell1.Dpi = 100!
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseTextAlignment = false
        Me.XrTableCell1.Text = "XrTableCell1"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell1.Weight = 0.21030381037594526R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customer")})
        Me.XrTableCell2.Dpi = 100!
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseTextAlignment = false
        Me.XrTableCell2.Text = "XrTableCell2"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell2.Weight = 0.80152041279897546R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CustomerBillingAddress")})
        Me.XrTableCell3.Dpi = 100!
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseTextAlignment = false
        Me.XrTableCell3.Text = "XrTableCell3"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell3.Weight = 0.8163123130099087R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TransDate", "{0:M/d/yyyy}")})
        Me.XrTableCell4.Dpi = 100!
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseTextAlignment = false
        Me.XrTableCell4.Text = "XrTableCell4"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell4.Weight = 0.30914627323158489R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DepositAmount", "{0:$0.00}")})
        Me.XrTableCell5.Dpi = 100!
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseTextAlignment = false
        Me.XrTableCell5.Text = "XrTableCell5"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell5.Weight = 0.30340689219580486R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TransAmount", "{0:$0.00}")})
        Me.XrTableCell7.Dpi = 100!
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StylePriority.UseTextAlignment = false
        Me.XrTableCell7.Text = "XrTableCell7"
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell7.Weight = 0.29495188892132579R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CheckNumber")})
        Me.XrTableCell6.Dpi = 100!
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StylePriority.UseTextAlignment = false
        Me.XrTableCell6.Text = "XrTableCell6"
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell6.Weight = 0.31081103735203719R
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 100!
        Me.TopMargin.HeightF = 50!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 100!
        Me.BottomMargin.HeightF = 50!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrLabelCompanyHeader})
        Me.PageHeader.Dpi = 100!
        Me.PageHeader.HeightF = 42.70833!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel1
        '
        Me.XrLabel1.Dpi = 100!
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.ForeColor = System.Drawing.Color.Blue
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(509.3749!, 0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(240.6251!, 21.4583!)
        Me.XrLabel1.StylePriority.UseFont = false
        Me.XrLabel1.StylePriority.UseForeColor = false
        Me.XrLabel1.StylePriority.UseTextAlignment = false
        Me.XrLabel1.Text = "Payment Listing Report"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabelCompanyHeader
        '
        Me.XrLabelCompanyHeader.Dpi = 100!
        Me.XrLabelCompanyHeader.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold)
        Me.XrLabelCompanyHeader.ForeColor = System.Drawing.Color.Blue
        Me.XrLabelCompanyHeader.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabelCompanyHeader.Name = "XrLabelCompanyHeader"
        Me.XrLabelCompanyHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelCompanyHeader.SizeF = New System.Drawing.SizeF(415.625!, 23!)
        Me.XrLabelCompanyHeader.StylePriority.UseFont = false
        Me.XrLabelCompanyHeader.StylePriority.UseForeColor = false
        Me.XrLabelCompanyHeader.Text = "FOSTER'S DISPOSAL SERVICE LLC"
        '
        'XrTable2
        '
        Me.XrTable2.BackColor = System.Drawing.Color.Silver
        Me.XrTable2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTable2.Dpi = 100!
        Me.XrTable2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Bold)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(750.0001!, 29.16667!)
        Me.XrTable2.StylePriority.UseBackColor = false
        Me.XrTable2.StylePriority.UseBorders = false
        Me.XrTable2.StylePriority.UseFont = false
        Me.XrTable2.StylePriority.UseTextAlignment = false
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell15, Me.XrTableCell16, Me.XrTableCell17, Me.XrTableCell18, Me.XrTableCell19, Me.XrTableCell20, Me.XrTableCell21})
        Me.XrTableRow3.Dpi = 100!
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.Dpi = 100!
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.StylePriority.UseTextAlignment = false
        Me.XrTableCell15.Text = "Number"
        Me.XrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell15.Weight = 0.21030381037594526R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.Dpi = 100!
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.StylePriority.UseTextAlignment = false
        Me.XrTableCell16.Text = "Name"
        Me.XrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell16.Weight = 0.80152041279897546R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.Dpi = 100!
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.StylePriority.UseTextAlignment = false
        Me.XrTableCell17.Text = "Address"
        Me.XrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell17.Weight = 0.8163122682464008R
        '
        'XrTableCell18
        '
        Me.XrTableCell18.Dpi = 100!
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.StylePriority.UseTextAlignment = false
        Me.XrTableCell18.Text = "Payment Date"
        Me.XrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell18.Weight = 0.30914624120846734R
        '
        'XrTableCell19
        '
        Me.XrTableCell19.Dpi = 100!
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.StylePriority.UseTextAlignment = false
        Me.XrTableCell19.Text = "Deposit"
        Me.XrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell19.Weight = 0.30340688393177639R
        '
        'XrTableCell20
        '
        Me.XrTableCell20.Dpi = 100!
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.StylePriority.UseTextAlignment = false
        Me.XrTableCell20.Text = "Payment"
        Me.XrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell20.Weight = 0.29495197397197964R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.Dpi = 100!
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.StylePriority.UseTextAlignment = false
        Me.XrTableCell21.Text = "Check #"
        Me.XrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell21.Weight = 0.31081103735203719R
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.GroupFooter1.Dpi = 100!
        Me.GroupFooter1.HeightF = 29.16667!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrTable1
        '
        Me.XrTable1.BackColor = System.Drawing.Color.Silver
        Me.XrTable1.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrTable1.Dpi = 100!
        Me.XrTable1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Bold)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(750!, 25!)
        Me.XrTable1.StylePriority.UseBackColor = false
        Me.XrTable1.StylePriority.UseBorders = false
        Me.XrTable1.StylePriority.UseFont = false
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell10, Me.XrTableCell11, Me.XrTableCell12, Me.XrTableCell13, Me.XrTableCell14})
        Me.XrTableRow2.Dpi = 100!
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Dpi = 100!
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Weight = 0.21030381037594526R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Dpi = 100!
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Weight = 0.80152041279897546R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Dpi = 100!
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Weight = 0.59629068267908547R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Dpi = 100!
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100!)
        Me.XrTableCell11.StylePriority.UsePadding = false
        Me.XrTableCell11.StylePriority.UseTextAlignment = false
        Me.XrTableCell11.Text = "Total Amount : "
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell11.Weight = 0.52916793455252664R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DepositAmount")})
        Me.XrTableCell12.Dpi = 100!
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.StylePriority.UseTextAlignment = false
        XrSummary1.FormatString = "{0:$0.00}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell12.Summary = XrSummary1
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell12.Weight = 0.30340689219580486R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TransAmount")})
        Me.XrTableCell13.Dpi = 100!
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.StylePriority.UseTextAlignment = false
        XrSummary2.FormatString = "{0:$0.00}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell13.Summary = XrSummary2
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell13.Weight = 0.2949518579312071R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.Dpi = 100!
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.Weight = 0.31081103735203719R
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabelTotalCredit, Me.XrLabel6, Me.XrSubreportCreditsIssued, Me.XrLine2, Me.XrLabel5, Me.XrLabelTotal, Me.XrLabel4, Me.XrLine1, Me.XrLabelTotalChecks, Me.XrLabelTotalCash, Me.XrLabel3, Me.XrLabel2})
        Me.ReportFooter.Dpi = 100!
        Me.ReportFooter.HeightF = 245.8333!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrSubreportCreditsIssued
        '
        Me.XrSubreportCreditsIssued.Dpi = 100!
        Me.XrSubreportCreditsIssued.LocationFloat = New DevExpress.Utils.PointFloat(0!, 212.8333!)
        Me.XrSubreportCreditsIssued.Name = "XrSubreportCreditsIssued"
        Me.XrSubreportCreditsIssued.SizeF = New System.Drawing.SizeF(750!, 23!)
        '
        'XrLine2
        '
        Me.XrLine2.Dpi = 100!
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(51.77428!, 50.08335!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(213.8507!, 23!)
        '
        'XrLabel5
        '
        Me.XrLabel5.Dpi = 100!
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.ForeColor = System.Drawing.Color.Blue
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(51.77428!, 27.08333!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(213.8507!, 23!)
        Me.XrLabel5.StylePriority.UseFont = false
        Me.XrLabel5.StylePriority.UseForeColor = false
        Me.XrLabel5.Text = "Report Summation"
        '
        'XrLabelTotal
        '
        Me.XrLabelTotal.Dpi = 100!
        Me.XrLabelTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabelTotal.LocationFloat = New DevExpress.Utils.PointFloat(165.625!, 169.7917!)
        Me.XrLabelTotal.Name = "XrLabelTotal"
        Me.XrLabelTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelTotal.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelTotal.StylePriority.UseFont = false
        Me.XrLabelTotal.StylePriority.UseTextAlignment = false
        Me.XrLabelTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel4
        '
        Me.XrLabel4.Dpi = 100!
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(51.77428!, 169.7917!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel4.StylePriority.UseFont = false
        Me.XrLabel4.StylePriority.UseTextAlignment = false
        Me.XrLabel4.Text = "Total"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine1
        '
        Me.XrLine1.Dpi = 100!
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(51.77428!, 146.7917!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(213.8507!, 23!)
        '
        'XrLabelTotalChecks
        '
        Me.XrLabelTotalChecks.Dpi = 100!
        Me.XrLabelTotalChecks.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabelTotalChecks.LocationFloat = New DevExpress.Utils.PointFloat(165.625!, 77.7916!)
        Me.XrLabelTotalChecks.Name = "XrLabelTotalChecks"
        Me.XrLabelTotalChecks.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelTotalChecks.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelTotalChecks.StylePriority.UseFont = false
        Me.XrLabelTotalChecks.StylePriority.UseTextAlignment = false
        Me.XrLabelTotalChecks.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabelTotalCash
        '
        Me.XrLabelTotalCash.Dpi = 100!
        Me.XrLabelTotalCash.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabelTotalCash.LocationFloat = New DevExpress.Utils.PointFloat(165.625!, 100.7916!)
        Me.XrLabelTotalCash.Name = "XrLabelTotalCash"
        Me.XrLabelTotalCash.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelTotalCash.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelTotalCash.StylePriority.UseFont = false
        Me.XrLabelTotalCash.StylePriority.UseTextAlignment = false
        Me.XrLabelTotalCash.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel3
        '
        Me.XrLabel3.Dpi = 100!
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(51.77428!, 100.7916!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel3.StylePriority.UseFont = false
        Me.XrLabel3.StylePriority.UseTextAlignment = false
        Me.XrLabel3.Text = "Total Cash"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.Dpi = 100!
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(51.77428!, 77.7916!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel2.StylePriority.UseFont = false
        Me.XrLabel2.StylePriority.UseTextAlignment = false
        Me.XrLabel2.Text = "Total Checks"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.GroupHeader1.Dpi = 100!
        Me.GroupHeader1.HeightF = 29.16667!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatEveryPage = true
        '
        'BindingSourcePaymentData
        '
        Me.BindingSourcePaymentData.DataSource = GetType(FosterRollOff.CReportObjects.CPaymentSummary)
        '
        'XrLabel6
        '
        Me.XrLabel6.Dpi = 100!
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(51.77428!, 123.7916!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel6.StylePriority.UseFont = false
        Me.XrLabel6.StylePriority.UseTextAlignment = false
        Me.XrLabel6.Text = "Total Credit"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelTotalCredit
        '
        Me.XrLabelTotalCredit.Dpi = 100!
        Me.XrLabelTotalCredit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabelTotalCredit.LocationFloat = New DevExpress.Utils.PointFloat(165.625!, 123.7916!)
        Me.XrLabelTotalCredit.Name = "XrLabelTotalCredit"
        Me.XrLabelTotalCredit.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelTotalCredit.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelTotalCredit.StylePriority.UseFont = false
        Me.XrLabelTotalCredit.StylePriority.UseTextAlignment = false
        Me.XrLabelTotalCredit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'PaymentListingReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.GroupFooter1, Me.ReportFooter, Me.GroupHeader1})
        Me.DataSource = Me.BindingSourcePaymentData
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "16.1"
        CType(Me.XrTablePaymentSummary,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.XrTable2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.XrTable1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BindingSourcePaymentData,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabelCompanyHeader As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTablePaymentSummary As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents BindingSourcePaymentData As System.Windows.Forms.BindingSource
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabelTotalChecks As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelTotalCash As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrSubreportCreditsIssued As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrLabelTotalCredit As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
End Class

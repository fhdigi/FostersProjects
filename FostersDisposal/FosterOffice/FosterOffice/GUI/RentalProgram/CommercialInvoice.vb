Public Class CommercialInvoice

    Public Sub HidePanels()

        XrPanelHeader.Visible = False
        XrPanelDescHeader.Visible = False
        XrPanelFooter.Visible = False
        XrPanelSubTotal.Borders = DevExpress.XtraPrinting.BorderSide.None

    End Sub

    Private Sub Detail_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Detail.BeforePrint

        ' ----- Get the line item listing from the current record
        Dim dataObj As List(Of CRentalBillLineItems) = GetCurrentColumnValue("LineItems")

        Dim objRpt As New CommercialInvoiceDetails

        ' ----- Set the data source and order by date 
        objRpt.BindingSource1.DataSource = dataObj.OrderBy(Function(t) t.ServiceDate)
        XrSubreportBilling.ReportSource = objRpt

    End Sub

End Class
Public Class RollOffBill

    Public Sub HidePanels()

        XrLabelCompanyHeader.Visible = False
        XrShapeBlueLine.Visible = False
        XrShapeGreyLine.Visible = False
        XrLabel1.Visible = False
        XrLabel2.Visible = False
        XrLabel3.Visible = False

        ' ----- the amount due block 
        XrShape1.Visible = False
        XrLabel4.Visible = False

        ' ----- address lines
        XrLabel7.Visible = False
        XrLabel8.Visible = False

        ' ------ the transaction header
        XrLabel20.Visible = False
        XrLabel21.Visible = False
        XrLabel22.Visible = False
        XrLabel23.Visible = False
        XrLabel24.Visible = False

        ' ------ the footer section 
        XrLabel17.Visible = False
        XrLabel18.Visible = False
        XrLabel19.Visible = False

        ' ------ the subtotal, total section 
        XrLabel25.Visible = False
        XrLabel26.Visible = False
        XrLabel27.Visible = False

        ' ----- now hide borders 
        XrLabelSubtotal.Borders = DevExpress.XtraPrinting.BorderSide.None
        XrLabelTax.Borders = DevExpress.XtraPrinting.BorderSide.None
        XrLabelTotal.Borders = DevExpress.XtraPrinting.BorderSide.None
        XrTableCellTransDate.Borders = DevExpress.XtraPrinting.BorderSide.None
        XrTableCellQty.Borders = DevExpress.XtraPrinting.BorderSide.None
        XrTableCellDesc.Borders = DevExpress.XtraPrinting.BorderSide.None
        XrTableCellUnitAmount.Borders = DevExpress.XtraPrinting.BorderSide.None
        XrTableCellAmount.Borders = DevExpress.XtraPrinting.BorderSide.None

    End Sub

End Class
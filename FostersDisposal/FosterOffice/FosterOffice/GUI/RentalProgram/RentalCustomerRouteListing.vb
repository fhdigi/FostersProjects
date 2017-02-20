Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting

Public Class RentalCustomerRouteListing

    Private Sub Detail_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Detail.BeforePrint

        If GetCurrentColumnValue("Container") = "F/L" Then
            XrTableCellSize.ForeColor = Color.Blue
            XrTableCellName.ForeColor = Color.Blue
            XrTableCellContainer.ForeColor = Color.Blue
            XrTableCellAddress.ForeColor = Color.Blue
        Else
            XrTableCellSize.ForeColor = Color.Black
            XrTableCellName.ForeColor = Color.Black
            XrTableCellContainer.ForeColor = Color.Black
            XrTableCellAddress.ForeColor = Color.Black
        End If

    End Sub

    Private Sub RentalCustomerRouteListing_FillEmptySpace(sender As Object, e As DevExpress.XtraReports.UI.BandEventArgs) Handles Me.FillEmptySpace

        Dim labelsCount As Integer = Convert.ToInt32(e.Band.Height \ Me.XrTableCellSize.Height)
        Dim targetSize As New Size((Me.PageWidth - Me.Margins.Left - Me.Margins.Right), e.Band.Height)
        Dim labelSize As New Size(Me.XrTableCellSize.Width - 2, Me.XrTableCellSize.Height)
        Dim targetSizeInPixels As Size = XRConvert.Convert(targetSize, GraphicsDpi.HundredthsOfAnInch, GraphicsDpi.Pixel)
        Dim labelSizeInPixels As Size = XRConvert.Convert(labelSize, GraphicsDpi.HundredthsOfAnInch, GraphicsDpi.Pixel)

        Dim targetBitmap As New Bitmap(targetSizeInPixels.Width, targetSizeInPixels.Height)
        Dim gr As Graphics = Graphics.FromImage(targetBitmap)
        Dim pt As New Point(0, 0)
        Dim sz As New Size(targetSizeInPixels.Width, labelSizeInPixels.Height)

        Dim szCell1 As Size = XRConvert.Convert(labelSize, GraphicsDpi.HundredthsOfAnInch, GraphicsDpi.Pixel)
        Dim szCell2 As Size = XRConvert.Convert(New Size(Me.XrTableCellName.Width + 1, Me.XrTableCellName.Height), GraphicsDpi.HundredthsOfAnInch, GraphicsDpi.Pixel)
        Dim szCell3 As Size = XRConvert.Convert(New Size(Me.XrTableCellContainer.Width, Me.XrTableCellContainer.Height), GraphicsDpi.HundredthsOfAnInch, GraphicsDpi.Pixel)
        Dim szCell4 As Size = XRConvert.Convert(New Size(Me.XrTableCell5.Width - 1, Me.XrTableCell5.Height), GraphicsDpi.HundredthsOfAnInch, GraphicsDpi.Pixel)
        Dim szCell5 As Size = XRConvert.Convert(New Size(Me.XrTableCellAddress.Width, Me.XrTableCellAddress.Height), GraphicsDpi.HundredthsOfAnInch, GraphicsDpi.Pixel)
        Dim szCell6 As Size = XRConvert.Convert(New Size(Me.XrTableCell4.Width, Me.XrTableCell4.Height), GraphicsDpi.HundredthsOfAnInch, GraphicsDpi.Pixel)
        Dim szCell7 As Size = XRConvert.Convert(New Size(Me.XrTableCell3.Width, Me.XrTableCell3.Height), GraphicsDpi.HundredthsOfAnInch, GraphicsDpi.Pixel)

        For i As Integer = 0 To labelsCount - 1

            pt.X = 0
            gr.FillRectangle(Brushes.White, New Rectangle(pt, szCell1))
            gr.DrawRectangle(Pens.Black, New Rectangle(pt, szCell1))

            pt.X += szCell1.Width
            gr.FillRectangle(Brushes.White, New Rectangle(pt, szCell2))
            gr.DrawRectangle(Pens.Black, New Rectangle(pt, szCell2))

            pt.X += szCell2.Width
            gr.FillRectangle(Brushes.White, New Rectangle(pt, szCell3))
            gr.DrawRectangle(Pens.Black, New Rectangle(pt, szCell3))

            pt.X += szCell3.Width
            gr.FillRectangle(Brushes.White, New Rectangle(pt, szCell4))
            gr.DrawRectangle(Pens.Black, New Rectangle(pt, szCell4))

            pt.X += szCell4.Width
            gr.FillRectangle(Brushes.White, New Rectangle(pt, szCell5))
            gr.DrawRectangle(Pens.Black, New Rectangle(pt, szCell5))

            pt.X += szCell5.Width
            gr.FillRectangle(Brushes.White, New Rectangle(pt, szCell6))
            gr.DrawRectangle(Pens.Black, New Rectangle(pt, szCell6))

            pt.X += szCell6.Width
            gr.FillRectangle(Brushes.White, New Rectangle(pt, szCell7))
            gr.DrawRectangle(Pens.Black, New Rectangle(pt, szCell7))

            pt.Y += labelSizeInPixels.Height

        Next i

        Dim pictureBox As New XRPictureBox()
        pictureBox.BackColor = Color.Transparent
        pictureBox.Size = targetSize
        pictureBox.Location = New Point(0, 0)
        pictureBox.Image = targetBitmap
        e.Band.Controls.Add(pictureBox)

    End Sub

End Class
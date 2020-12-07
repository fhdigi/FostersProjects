Public Class BillingSheetSingleRotated

    Private Sub GroupHeader1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GroupHeaderBillSingle.BeforePrint

        Dim lineItems As List(Of CBillLineItems) = DirectCast(GetCurrentColumnValue("LineItems"), List(Of CBillLineItems))

        Dim rowCounter As Integer = 0

        For iIndex As Integer = 1 To 8
            GroupHeaderBillSingle.Controls("XrLabelDesc" & iIndex.ToString).Text = ""
            GroupHeaderBillSingle.Controls("XrLabelAmt" & iIndex.ToString).Text = ""
        Next

        If Not lineItems Is Nothing Then
            rowCounter = 0
            For Each obj As CBillLineItems In lineItems

                rowCounter += 1
                GroupHeaderBillSingle.Controls("XrLabelDesc" & rowCounter.ToString).Text = obj.Description

                ' ----- Do not show zero amounts
                If obj.Amount <> 0.0 Then
                    GroupHeaderBillSingle.Controls("XrLabelAmt" & rowCounter.ToString).Text = String.Format("{0:c2}", obj.Amount)
                End If

            Next
        End If

    End Sub

End Class
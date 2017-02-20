Public Class PaymentListingReport

    Dim sumOfChecks As Double = 0.0
    Dim sumOfCashOther As Double = 0.0
    Dim sumOfCredit As Double = 0.0

    Private Sub Detail_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Detail.BeforePrint

        Dim cashOrCheck As String = GetCurrentColumnValue("CheckNumber")
        Dim tempDepAmount As Double = Convert.ToDouble(GetCurrentColumnValue("DepositAmount"))
        Dim tempPayAmount As Double = Convert.ToDouble(GetCurrentColumnValue("TransAmount"))

        If Not cashOrCheck Is Nothing Then
            If cashOrCheck.Trim.ToUpper = "CASH" Then
                sumOfCashOther += tempDepAmount + tempPayAmount
            ElseIf cashOrCheck.Trim.ToUpper = "CREDIT" then 
                sumOfCredit += tempDepAmount + tempPayAmount
            Else
                sumOfChecks += tempDepAmount + tempPayAmount
            End If
        End If

    End Sub

    Private Sub GroupFooter1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles GroupFooter1.BeforePrint
        XrLabelTotalChecks.Text = String.Format("{0:c2}", sumOfChecks)
        XrLabelTotalCash.Text = String.Format("{0:c2}", sumOfCashOther)
        XrLabelTotalCredit.Text = String.Format("{0:c2}", sumOfCredit)
        XrLabelTotal.Text = String.Format("{0:c2}", sumOfChecks + sumOfCashOther + sumOfCredit)
    End Sub

End Class
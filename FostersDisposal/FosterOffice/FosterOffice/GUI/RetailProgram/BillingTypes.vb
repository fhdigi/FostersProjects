Public Class BillingTypes

    Private Sub BillingTypes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridViewBillingTypes.DataSource = (From b In ProgramDataObject.BillingTypeObjectList Order By b.Designation Select b).ToList
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click

        ' ----- Remove the listing 
        ProgramDataObject.BillingTypeObjectList.Clear()

        For Each dr As DataGridViewRow In DataGridViewBillingTypes.Rows

            If dr.Cells(1).Value <> "" Then

                Dim newObj As New PickupTransaction.BillingTypes

                newObj.Amount = 0.0

                If Single.TryParse(dr.Cells(2).Value.ToString, newObj.Amount) Then
                    newObj.Designation = dr.Cells(1).Value.ToString
                    ProgramDataObject.BillingTypeObjectList.Add(newObj)
                End If

            End If

        Next

        ' ----- Save the data file 
        PickupTransaction.BillingTypes.SaveBillingFile(ProgramDataObject.BillingTypeObjectList)

        ' ----- Close the screen 
        Me.Close()

    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

End Class
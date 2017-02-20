
Public Class RollOffFees

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click

        dim dumpingFee as Double = Convert.ToDouble(TextBoxDumpingFee.Text)
        if IsNumeric(dumpingFee) then FosterRollOff.DumpingFee.SaveDumpingFee(dumpingFee)

        ' ----- Close the screen 
        Close()

    End Sub

    Private Sub FillGrid()
        ListBoxFees.Items.AddRange(CRollOffFee.GetRollOffFees.ToArray)
    End Sub

    Private Sub RollOffFees_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' ----- Get the dumping fee 
        TextBoxDumpingFee.Text = String.Format ("{0:f2}", DumpingFee .GetDumpingFee())

        ' ----- Fill in the rest of the grid 
        FillGrid()

    End Sub

    Private Sub ButtonAddNewOption_Click(sender As Object, e As EventArgs) Handles ButtonAddNewOption.Click

        Dim newFee As New CRollOffFee
        newFee.Description = "New Fee"
        newFee.RentalAmount = 0.0
        newFee.RollOffSize = 0
        newFee.DailyFee = 0.0
        newFee.Save()

        FillGrid()

    End Sub

    Private Sub ListBoxFees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxFees.SelectedIndexChanged
        PropertyGridFees.SelectedObject = DirectCast(ListBoxFees.SelectedItem, CRollOffFee)
    End Sub

    Private Sub PropertyGridFees_PropertyValueChanged(s As Object, e As PropertyValueChangedEventArgs) Handles PropertyGridFees.PropertyValueChanged
        Dim rollOffFee As CRollOffFee = DirectCast(PropertyGridFees.SelectedObject, CRollOffFee)
        rollOffFee.Update()
    End Sub

End Class
Public Class VacationCreditForm

    Public Property CustomerObject As PickupTransaction.Customer
    Public Property ExistingID As Integer = -99

    Private Sub VacationCredit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ' ----- Show the customer 
        If Not CustomerObject Is Nothing Then
            LabelCustomerName.Text = CustomerObject.FullName
        End If

        If ExistingID <> -99 Then
            Dim vc As PickupTransaction.VacationCredit = PickupTransaction.VacationCredit.GetVacationCreditObject(My.Settings.DatabaseLocation, ExistingID)
            DateTimePickerVacStart.Value = vc.DateStart
            DateTimePickerVacEnd.Value = vc.DateEnd
        End If

    End Sub

    Private Sub ButtonSave_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSave.Click

        ' ----- Create an object 
        Dim newVC As New PickupTransaction.VacationCredit

        ' ----- Fill in the data 
        newVC.DateStart = DateTimePickerVacStart.Value.Date
        newVC.DateEnd = DateTimePickerVacEnd.Value.Date

        If ExistingID = -99 Then
            newVC.CustomerNumber = CustomerObject.CustomerNumber
            newVC.SaveVacationDates(My.Settings.DatabaseLocation)
        Else
            newVC.EditVacationDates(My.Settings.DatabaseLocation, ExistingID)
        End If

        ' ----- Close the screen 
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click

        ' ----- Close the screen 
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub

End Class
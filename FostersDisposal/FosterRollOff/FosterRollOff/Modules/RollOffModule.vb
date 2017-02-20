Module RollOffModule

    Public CurrentCustomerList As List(Of CCustomer)
    Public CurrentFeeList As List(Of CRollOffFee)
    Public CurrentTransactions As List(Of CDataExtender.CMainScreenData)

    Public Sub FillGlobalLists()

        ' ----- The list of fees 
        CurrentFeeList = New List(Of CRollOffFee)
        CurrentFeeList = CRollOffFee.GetRollOffFees()

        ' ----- A complete list of current customers 
        CurrentCustomerList = New List(Of CCustomer)
        CurrentCustomerList = CCustomer.GetCustomerList()

    End Sub

    Public Sub FillTransactions()
        CurrentTransactions = New List(Of CDataExtender.CMainScreenData)
        CurrentTransactions = CDataExtender.GetAllTransactions
    End Sub

    Public Function MakeUpperFirstLetter(val As String) As String

        Dim convertedString As String = ""
        Dim charSpace() As Char = {" "c}

        Select Case val.Length
            Case 0
                convertedString = ""
            Case 1
                convertedString = val.ToUpper
            Case Else
                Dim wordArray() As String = val.Split(charSpace, 5, StringSplitOptions.RemoveEmptyEntries)
                For Each strItem As String In wordArray
                    If strItem.Length > 1 Then
                        convertedString += strItem.Substring(0, 1).ToUpper & strItem.Substring(1) & " "
                    Else
                        convertedString += strItem.ToUpper & " "
                    End If
                Next
        End Select

        Return convertedString.Trim

    End Function

End Module

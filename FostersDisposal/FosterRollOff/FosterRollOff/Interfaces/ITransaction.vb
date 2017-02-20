Public Interface ITransaction

    Property DatabaseID As Integer
    Property TransactionDate As Date
    Property Amount As Double
    Property Description As String
    Property CheckNumber As String
    Property RollOffID As Integer
    Property RollOffObject As CRollOff
    Property HasBeenBilled As Boolean
    Property BilledDate As Date
    Property Taxable As Boolean
    Property CreditCardTransaction as Boolean   
    Property CreditCardAuthNumber As String 
    Property TransactionId As string 

    Function RemoveBillFlag(dteVal As Date) As Boolean
    Function MarkAsBilled(dteBill As Date) As Boolean
    
End Interface

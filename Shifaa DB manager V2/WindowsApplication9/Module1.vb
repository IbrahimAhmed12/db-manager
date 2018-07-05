Imports System.Data
Imports System.Data.OleDb

Module Module1
    'These are variables that need to be accessed in all areas of the code
    Public Username, ID, wName, ChosenOrder, shopName, shopID, searchID, table As String
    Public HowManyProducts, NumbersOfSale As Integer
    Public confirm As Boolean
    Public products(4) As String
    Public price(4), amount(4) As Decimal
End Module

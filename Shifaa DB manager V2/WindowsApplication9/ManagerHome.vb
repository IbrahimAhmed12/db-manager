Public Class ManagerHome
    Public managername As String
    Public correctrow As Integer
    Public products As New DBController
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This will make sure that the manager cannot add multiple sales(orderlines) of the same product in one order to avoid complication
        Products.MakeQuery("SELECT * FROM Product")
        HowManyProducts = Products.recordcount
        products.clearDT()
        LBLWelcome.Text = "Welcome " & wName
    End Sub
    Private Sub BTNDatabaseManagement_Click(sender As Object, e As EventArgs) Handles BTNDatabaseManagement.Click
        TableManager.Show()
    End Sub

    Private Sub BTNAnalysis_Click(sender As Object, e As EventArgs) Handles BTNAnalysis.Click
        Search.Show()
    End Sub
End Class
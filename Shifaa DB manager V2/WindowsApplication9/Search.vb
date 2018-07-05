Public Class Search
    Public shop, product As New DBController

    Private Sub CBXTable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBXTable.SelectedIndexChanged
        'any time the selected item in the table combo box is changed the contents of the name combobox changes into the table selected
        shop.MakeQuery("SELECT * FROM Shop")
        product.MakeQuery("SELECT * FROM Product")
        'this makes sure the code does not break f somehow there is nothing in a combobox
        If String.IsNullOrEmpty(CBXTable.SelectedItem) = False Then
            If CBXTable.SelectedItem = "Shop" Then
                'this makes it so that u get no duplicates in the comboboxes
                CBXName.Refresh()
                'fills the combo boxes with things inside the database
                For Each r As DataRow In shop.DT.Rows
                    CBXName.Items.Add(r("Shop_Name"))
                Next
            ElseIf CBXTable.SelectedItem = "Product" Then
                CBXName.Refresh()
                For Each r As DataRow In product.DT.Rows
                    CBXName.Items.Add(r("Product_Name"))
                Next
            End If
        End If
    End Sub

    Private Sub BTNGo_Click(sender As Object, e As EventArgs) Handles BTNGo.Click
        Dim validentry As Boolean
        'checks what combination of results the user gives
        If String.IsNullOrEmpty(CBXName.SelectedItem) = False And String.IsNullOrEmpty(CBXTable.SelectedItem) = False Then
            'this is if the user chose to select names from a table
            MsgBox(String.IsNullOrEmpty(CBXName.SelectedItem))
            MsgBox(String.IsNullOrEmpty(CBXTable.SelectedItem))
            If CBXTable.SelectedItem = "Shop" Then
                'stores valid data needed in the anlysis into global variables to be used later
                shop.clearDT()
                shop.AddParameters("@name", CBXName.SelectedItem)
                shop.MakeQuery("SELECT * FROM Shop WHERE Shop_Name = @name")
                searchID = shop.DT.Rows(0)("Shop_ID")
                table = "Shop"
            Else
                product.clearDT()
                product.AddParameters("@name", CBXName.SelectedItem)
                product.MakeQuery("SELECT * FROM Product WHERE Product_Name = @name")
                searchID = product.DT.Rows(0)("Product_ID")
                table = "Product"
            End If
            'shows the anlysis form
            Analysis.Show()
        ElseIf TXTPkey.Text IsNot "" Then
            'this is if the user entered a primary key
            shop.clearDT()
            'this check if the primary key is valid
            shop.AddParameters("@ID", TXTPkey.Text)
            shop.MakeQuery("SELECT * FROM Shop WHERE Shop_ID = @ID")
            If shop.recordcount = 1 Then
                validentry = True
                searchID = TXTPkey.Text
                table = "Shop"
            Else
                product.clearDT()
                product.AddParameters("@ID", TXTPkey.Text)
                product.MakeQuery("SELECT * FROM Product WHERE Product_ID = @ID")
                If product.recordcount = 1 Then
                    'stores valid data needed in the anlysis into global variables to be used later
                    validentry = True
                    searchID = TXTPkey.Text
                    table = "Product"
                End If
            End If
            If validentry = True Then
                'opens analysis if the primary key is valid
                searchID = TXTPkey.Text
                Analysis.Show()
            Else
                'error message
                MsgBox("ID does not exist")
            End If
        Else
            'error message
            MsgBox("Enter valid data")
        End If
    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'fills in the combo box with 2 tables
        CBXTable.Items.Add("Shop")
        CBXTable.Items.Add("Product")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'help message
        MsgBox("Enter a combination of table and name or just enter the ID of the item of the anylysis")
    End Sub
End Class
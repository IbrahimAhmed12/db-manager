Public Class Form9
    Public products As New DBController
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Makes query to find all products so it can fill the dropdown menu(combo box)
        products.MakeQuery("SELECT * From Product")
        'Part of the code which fills combo box
        For Each r As DataRow In products.DT.Rows
            CBXProducts.Items.Add(r("Product_Name"))
        Next
    End Sub

    Private Sub BTNAdd_Click(sender As Object, e As EventArgs) Handles BTNAdd.Click
        If String.IsNullOrEmpty(CBXProducts.SelectedItem) = False Then
            'This button only saves the details of the orderline in an array in the module. This makes it so that you cannot
            'prematurly save an orderline without the order
            'adds a certain amount of data rows so you cannot add an nfinate amount of repeated items in the orderline
            AddOrder.tempsale.Rows.Add(HowManyProducts)
            'editing the null refrences in the datatable to useful data
            AddOrder.tempsale.Rows(NumbersOfSale)("Products") = CBXProducts.SelectedItem.ToString
            AddOrder.tempsale.Rows(NumbersOfSale)("Amount") = TXTAmount.Text.ToString
            'The next time this form is opened it will move on to the next form
            NumbersOfSale += 1
            'this makes it so that you cannot add any more orderlines once you have added an orderline for every
            'product that the company sells
            If NumbersOfSale = HowManyProducts Then
                AddOrder.BTNAddsale.Visible = False
            End If
            Me.Close()
        Else
            MsgBox("Select an item")
        End If
    End Sub
End Class
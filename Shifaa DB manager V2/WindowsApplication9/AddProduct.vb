Public Class AddProduct
    'Loads the sql control object
    Dim product As New DBController
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNAdd.Click
        Dim PID, copy, query As String
        'This checks if all the fields are entered if not it ddoes not save into database
        If TXTBPrice.Text = "" Or TXTCaseSize.Text = "" Or TXTPName.Text = "" Or TXTSPrice.Text = "" Then
            'error message
            MsgBox("Fill in all fields.")
        Else
            'This part makes the first 3 letters of the ID
            copy = TXTPName.Text.ToCharArray
            PID = copy(0) & copy(1) & copy(2)
            'This checks how many copies of the same product code there is
            product.AddParameters("@ID", "%" & PID & "%")
            query = "SELECT * FROM Product WHERE Product_ID LIKE @ID"
            product.MakeQuery(query)
            'This creates a unique ID all the time
            PID = PID & (100 + product.recordcount)
            'setting up parameters for the insert command
            product.AddParameters("@ID", PID)
            product.AddParameters("@Name", TXTPName.Text)
            product.AddParameters("@Case", TXTCaseSize.Text)
            product.AddParameters("@BPrice", TXTBPrice.Text)
            product.AddParameters("@SPrice", TXTSPrice.Text)
            'executing the insert command
            product.MakeQuery("INSERT INTO Product (Product_ID, Product_Name, Case_Size, Cost_Price, Sale_Price) " &
                              "VALUES (@ID, @Name, @Case, @Bprice, @SPrice)")
            'the user can tell when the record has been saved into the database
            MsgBox("Saved")
        End If
    End Sub
End Class
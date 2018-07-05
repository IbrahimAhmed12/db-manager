Public Class AddOrder
    Public shops, Products, addorder, addorderline, drivers As New DBController
    Public tempsale As New DataTable



    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumbersOfSale = 0
        'Fills combobox with all the shops in the database that the company delivers too
        shops.MakeQuery("SELECT Shop_Name FROM Shop")
        For Each r As DataRow In shops.DT.Rows
            CBXShop.Items.Add(r("Shop_Name"))
        Next
        shops.clearDT()
        drivers.MakeQuery("SELECT * FROM Driver")
        For Each r As DataRow In drivers.DT.Rows
            CBXDriver.Items.Add(r("Driver_FirstName"))
        Next
        'Forming the two columns in the datatable
        tempsale.Columns.Add("Products")
        tempsale.Columns.Add("Amount")
        'allowing the users to see the changes they made to the orderlines
        DGVOrderlines.DataSource = tempsale
    End Sub

    Private Sub BTNAdd_Order_Click(sender As Object, e As EventArgs) Handles BTNAdd_Order.Click
        Dim sID, pID(HowManyProducts - 1), dID, oID, sIDcopy, IDcopy As String
        Dim Amount(HowManyProducts - 1) As Integer
        Dim grossp(HowManyProducts - 1), grossprofit, netprofit, Number As Decimal
        'checks if all the data is valid
        If Decimal.TryParse(TXTExpenses.Text, number) = False Or String.IsNullOrEmpty(CBXDriver.SelectedItem) Or String.IsNullOrEmpty(CBXShop.SelectedItem) Then
            'error message
            If Decimal.TryParse(TXTExpenses.Text, Number) = False Then
                MsgBox("Enter a number")
            ElseIf String.IsNullOrEmpty(CBXDriver.SelectedItem) Or String.IsNullOrEmpty(CBXShop.SelectedItem) Then
                MsgBox("Pick a table or name")
            End If
        Else
            'finds the shopID from the name
            shops.AddParameters("@ShopName", CBXShop.SelectedItem)
            shops.MakeQuery("SELECT Shop_ID FROM Shop WHERE Shop_Name = @ShopName")
            'saves the shop ID
            sID = shops.DT.Rows(0)("Shop_ID").ToString

            For x = 0 To NumbersOfSale - 1
                'stops the program from crashing if there is no value in the datatable
                If tempsale.Rows(x)("Products").Equals("") Then

                Else
                    Products.AddParameters("@Productname", tempsale(x)("Products"))
                    Products.MakeQuery("Select * FROM Product WHERE Product_Name = @ProductName")
                    pID(x) = Products.DT.Rows(0)("Product_ID")
                    Amount(x) = Integer.Parse(tempsale(x)("Amount"))
                    grossp(x) = Amount(x) * Decimal.Parse(Products.DT.Rows(0)("Sale_Price"))
                End If
            Next
            'finds the driver id from the name entered
            drivers.clearDT()
            drivers.AddParameters("@name", CBXDriver.SelectedItem)
            drivers.MakeQuery("SELECT * FROM Driver WHERE Driver_FirstName = @name")
            dID = drivers.DT.Rows(0)("Driver_ID")

            'Makes Unique OrderID
            IDcopy = ID
        IDcopy.ToCharArray()
        sIDcopy = sID
        sIDcopy.ToCharArray()
        oID = sIDcopy(0) & sIDcopy(1) & IDcopy(1)
        addorder.AddParameters("@ID", "%" & oID & "%")
        addorder.MakeQuery("SELECT * FROM Orders WHERE Order_ID LIKE @ID")
        oID = oID & (100 + addorder.recordcount).ToString
        For x = 0 To (NumbersOfSale - 1)
            'works out the total gross prof
            grossprofit = grossprofit + grossp(x)
        Next
            'loads in all the data needed in the sql injection below
            netprofit = grossprofit - Decimal.Parse(TXTExpenses.Text)
            addorder.AddParameters("@oID", oID)
            addorder.AddParameters("@dID", dID)
            addorder.AddParameters("@mID", ID)
            addorder.AddParameters("@sID", sID)
            addorder.AddParameters("@date", DTPOrder.Value.Date)
            addorder.AddParameters("@GP", grossprofit)
            addorder.AddParameters("@EX", Decimal.Parse(TXTExpenses.Text))
            addorder.AddParameters("@NP", netprofit)
            addorder.MakeQuery("INSERT INTO Orders (Order_ID,Driver_ID,Manager_ID,Shop_ID,Order_Date,Gross_Profit,Expenses,Net_Profit) " &
                               "VALUES (@oID,@dID,@mID,@sID,@date,@GP,@EX,@NP) ")
            'sql injection for the orderlines
            For x = 0 To NumbersOfSale - 1
                addorderline.AddParameters("@oID", oID)
                addorderline.AddParameters("@pID", pID(x))
                addorderline.AddParameters("@amount", Amount(x))
                addorderline.AddParameters("@GP", grossp(x))
                addorderline.MakeQuery("INSERT INTO Orderline (Order_ID,Product_ID,Quantity,Gross_Profit)" &
                                       "VALUES (@oID,@pID,@amount,@GP)")
            Next
            MsgBox("saved")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNAddsale.Click
        Form9.Show()

    End Sub
End Class
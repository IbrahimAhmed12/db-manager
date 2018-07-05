Public Class OrderDetails
    Public Orderline, Shop, product As New DBController

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Loads parameters in for order ID to find the shop ID asscociated with it
        Shop.AddParameters("@OrderID", ChosenOrder)
        Shop.MakeQuery("SELECT Shop_ID FROM Orders WHERE Order_ID = @OrderID")
        'This adds adds a parameter for the Shop ID for the next SQL query
        Shop.AddParameters("@ShopID", Shop.DT.Rows(0)("Shop_ID").ToString)
        'Clears the datatable to be used for the next query
        Shop.clearDT()
        'Query takes out all valid infomation about the shop that need to be delivered to e later displayed to the Driver
        Shop.MakeQuery("SELECT * FROM Shop Where Shop_ID = @ShopID")
        'display all the ifomation in labels
        LBLShopName.Text = "Shop name: " & Shop.DT.Rows(0)("Shop_Name").ToString
        LBLPostcode.Text = "Shop Address: " & Shop.DT.Rows(0)("Postcode") & " " & Shop.DT.Rows(0)("Address")
        'sets up the order ID as a parameter to make a search in the orderline table from all the products being delivered to 
        'the Shop on that specific date
        Orderline.AddParameters("@OrderID", ChosenOrder)
        'Query finds all the prducts meant to be delivered
        Orderline.MakeQuery("SELECT Product_ID, Quantity, Delivered FROM OrderLine WHERE Order_ID = @OrderID")
        'Products and quantity diplayed on a data grid
        DGVOrderline.DataSource = Orderline.DT

    End Sub


    Private Sub BTNPrint_Click(sender As Object, e As EventArgs) Handles BTNPrint.Click
        'before loading all the forms i sae sall the infomation about the order into variables from the module so it can be loaded
        'into the invoice later on
        shopName = Shop.DT.Rows(0)("Shop_Name").ToString
        shopID = Shop.DT.Rows(0)("Shop_ID")
        'this checks if the order has any orderlines just to make sute the program does not crash
        If Orderline.recordcount < 0 Then

        Else
            'this makes a loop that repeats itself for every orderline in an order and collects valid infomatiion from the orderlines
            For x = 0 To Orderline.recordcount - 1
                product.AddParameters("@ID", Orderline.DT.Rows(x)("Product_ID"))
                product.MakeQuery("SELECT * FROM Product WHERE Product_ID = @ID")
                products(x) = product.DT.Rows(x)("product_Name").ToString
                amount(x) = Integer.Parse(Orderline.DT.Rows(x)("Quantity"))
                price(x) = Decimal.Parse(product.DT.Rows(x)("Sale_Price")) * Integer.Parse(Orderline.DT.Rows(x)("Quantity"))
            Next
        End If
        Invoice.Show()
    End Sub
End Class
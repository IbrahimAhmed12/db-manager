Public Class Analysis
    Public product, shop, order, orderline As New DBController
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sname As String
        Dim NPS, NP, percent As Decimal
        'this loads up all the valid data before being viewed but bfore we need to find out if we need to be anlaysing a shop or product
        If table = "Shop" Then
            shop.AddParameters("@ID", searchID)
            shop.MakeQuery("SELECT * FROM Shop WHERE Shop_ID = @ID")
            'this finds the name of the shop
            sname = shop.DT.Rows(0)("Shop_Name")
            'this finds all the orders the shop is asscoiciated with
            order.AddParameters("@ID", searchID)
            order.MakeQuery("SELECT * FROM orders WHERE Shop_ID = @ID")
            'finds the total net profit from all the orders that this shop is asscociated to
            For x = 0 To order.recordcount - 1
                NPS = NPS + Decimal.Parse(order.DT.Rows(x)("Net_Profit"))
            Next
            order.clearDT()
            'this part of the code finds all the net profit from all the orders that have ever been made 
            order.MakeQuery("SELECT * FROM orders")
            For x = 0 To order.recordcount - 1
                NP = NP + Decimal.Parse(order.DT.Rows(x)("Net_Profit"))
            Next
            'finds the percentage of profit from this shop
            percent = (NPS / NP) * 100
            'Displays all the infomation into the form
            LBLname.Text = sname
            LBLProfit.Text = "The profit from this shop is: £" & NPS
            LBLPercent.Text = "The percentage profit it has made is: " & percent & "%"
        Else
            'Finds the name of the product
            product.AddParameters("@ID", searchID)
            product.MakeQuery("SELECT * FROM Product WHERE Product_ID = @ID")
            sname = product.DT.Rows(0)("Product_Name")
            'finds all the orderlines that the product is ascociated with.
            orderline.AddParameters("@ID", searchID)
            orderline.MakeQuery("SELECT * FROM orderline WHERE Product_ID = @ID")
            'adds up the net profits made from the product
            For x = 0 To orderline.recordcount - 1
                NPS = NPS + Decimal.Parse(orderline.DT.Rows(x)("Gross_Profit"))
            Next
            orderline.clearDT()
            ' finds the netprofits from all orderlines that were ever created
            orderline.MakeQuery("SELECT * FROM orderline")
            For x = 0 To orderline.recordcount - 1
                NP = NP + Decimal.Parse(orderline.DT.Rows(x)("Gross_Profit"))
            Next
            'finds the percentage of profits the roduct m=has made in comparison to the whole
            percent = (NPS / NP) * 100
            'displays all the infomation on the form
            LBLname.Text = sname
            LBLProfit.Text = "The profit from this product is: £" & NPS
            LBLPercent.Text = "The percentage profit it has made is: " & percent & "%"
        End If
    End Sub
End Class
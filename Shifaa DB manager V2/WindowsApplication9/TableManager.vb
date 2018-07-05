Public Class TableManager
    Public orders, products, shops, contactdetails, Drivers, OrderLine As New DBController
    Public table, IdentifyDS As String
    Public form8 As New AddOrder
    Sub DTwipe()
        orders.DT.Clear()
        products.DT.Clear()
        shops.DT.Clear()
        contactdetails.DT.Clear()
        Drivers.DT.Clear()
    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub display(DB As DBController, Table As String)
        Dim PKEY
        'clears all datatables to allow them to be filled witout combinng  getting repeats of data from diferrent tables 
        DTwipe()
        'Makes it impssible for you to delete any records from any of the tbles
        BTNDelete.Visible = False
        'Checks if any parameters have been entered
        Select Case Table
            Case "Driver"
                PKEY = "Driver_ID"
            Case "Orders"
                PKEY = "Order_ID"
            Case "Orderline"
                PKEY = "Order_ID"
            Case "Product"
                PKEY = "Product_ID"
            Case "Shop"
                PKEY = "Shop_ID"
            Case "ContactDetails"
                PKEY = "Contact_ID"
        End Select
        If TXTSearch.Text = "" Then
            'if there is no parameters then it calls up all the records from the table
            DB.MakeQuery("SELECT * FROM " & Table)
        Else
            'if there is a parameter and performs a wild card search
            DB.AddParameters("@ID", "%" & TXTSearch.Text & "%")
            DB.MakeQuery("SELECT * FROM " & Table & " WHERE " & PKEY & " LIKE @ID")
        End If
        'sets the source of the datagridview as the datatable
        DGVDataEditor.DataSource = DB.DT
        'This is how we can identiy which datatable is in use currently elsewhere in te code 
        IdentifyDS = Table & ".DT"
    End Sub
    Private Sub BTNDescription_Click(sender As Object, e As EventArgs) Handles BTNDescription.Click
        'description about hoow primarykeys are maden in a seperate form
    End Sub

    Private Sub BTNDelete_Click(sender As Object, e As EventArgs) Handles BTNDelete.Click
        Dim x As Integer
        Dim param, param2 As String
        'add a warning screen 
        'delete selected rows
        Warning.ShowDialog()

        If confirm = True Then
            For Each r As DataGridViewRow In DGVDataEditor.SelectedRows
                x = Integer.Parse(r.Index.ToString())
                If x = DGVDataEditor.Rows.Count - 1 Then

                Else
                    'This case statement identifies which table is being shown
                    Select Case IdentifyDS
                        Case "Orders.DT"
                            'deletes te record first from the datagrid then from the database
                            param = orders.DT.Rows(x)("Order_ID")
                            DGVDataEditor.Rows.Remove(r)
                            orders.AddParameters("@ID", param)
                            orders.MakeQuery("DELETE FROM Orders WHERE Order_ID = @ID")
                            'It then deleetes all linked orderlines
                            OrderLine.AddParameters("@ID", param)
                            OrderLine.MakeQuery("DELETE FROM OrderLine WHERE Order_ID = @ID")
                        Case "ContactDetails.DT"
                            param = contactdetails.DT.Rows(x)("Contact_ID")
                            DGVDataEditor.Rows.Remove(r)
                            contactdetails.AddParameters("@ID", param)
                            contactdetails.MakeQuery("DELETE FROM ContactDetails WHERE Contact_ID = @ID")
                        Case "OrderLine.DT"
                            param = OrderLine.DT.Rows(x)("Order_ID")
                            param2 = OrderLine.DT.Rows(x)("Product_ID")
                            DGVDataEditor.Rows.Remove(r)
                            OrderLine.AddParameters("@OID", param)
                            OrderLine.AddParameters("@PID", param2)
                            orders.MakeQuery("DELETE FROM OrderLine WHERE Order_ID = @OID AND Product_ID = @PID")
                        Case Else
                            MsgBox(DGVDataEditor.DataSource.ToString())
                    End Select

                End If
            Next
        Else
        End If


    End Sub

    Private Sub BTNSave_Click(sender As Object, e As EventArgs) Handles BTNSave.Click
        Dim x As Integer
        Dim gross, net As Integer
        DGVDataEditor.Update()
        'Picks up all the updated rows from the datagrid and goes through them one at a time
        For Each r As DataGridViewRow In DGVDataEditor.Rows
            x = Integer.Parse(r.Index.ToString())
            If x = DGVDataEditor.Rows.Count - 1 Then

            Else
                'the below case statements find which table is open at the moment then goes on to update whichever table is being viewed in the database.
                Select Case IdentifyDS
                    Case "OrderLine.DT"
                        OrderLine.AddParameters("@quant", OrderLine.DT.Rows(x)("Quantity"))

                        'works out grossprofit from products table and multiplying y the quantity state in orderline
                        products.AddParameters("@ID", OrderLine.DT.Rows(x)("Product_ID"))
                        products.MakeQuery("SELECT * FROM Product WHERE Product_ID = @ID")
                        gross = OrderLine.DT.Rows(x)("Quantity") * products.DT.Rows(0)("Sale_Price")
                        OrderLine.AddParameters("@grossP", gross)

                        OrderLine.AddParameters("@delivered", OrderLine.DT.Rows(x)("Delivered"))
                        OrderLine.AddParameters("@OID", OrderLine.DT.Rows(x)("Order_ID"))
                        OrderLine.AddParameters("@PID", OrderLine.DT.Rows(x)("Product_ID"))
                        OrderLine.MakeQuery("UPDATE OrderLine SET Quantity=@quant, Gross_Profit=@GrossP," &
                                             " Delivered=@Delivered WHERE Product_ID = @PID AND Order_ID = @OID")
                    Case "ContactDetails.DT"
                        contactdetails.AddParameters("@PNo", contactdetails.DT.Rows(x)("PhoneNumber"))
                        contactdetails.AddParameters("@EMail", contactdetails.DT.Rows(x)("E-mail_Address"))
                        contactdetails.AddParameters("@CID", contactdetails.DT.Rows(x)("Contact_ID"))
                        contactdetails.MakeQuery("UPDATE ContactDetail SET PhoneNumber=@Pno," &
                                                 " E-mail_Address=EMail WHERE Contact_ID = @CID")

                    Case "Orders.DT"
                        orders.AddParameters("@SID", orders.DT.Rows(x)("Shop_ID"))
                        orders.AddParameters("@DID", orders.DT.Rows(x)("Driver_ID"))

                        'Works out the total gross profit for te order usng th orderlines
                        OrderLine.AddParameters("@ID", orders.DT.Rows(x)("Order_ID"))
                        OrderLine.MakeQuery("SELECT * FROM OrderLine WHERE Order_ID = @ID")
                        'searchs throught orderline table to find all related orderlines
                        For z = 0 To OrderLine.recordcount - 1
                            gross = gross + OrderLine.DT.Rows(z)("Gross_Profit")
                        Next

                        orders.AddParameters("@GPro", gross)
                        orders.AddParameters("@exp", orders.DT.Rows(x)("Expenses"))

                        'Works out net profit by subtracting the expenses from the gross profit
                        net = gross - Integer.Parse(orders.DT.Rows(x)("Expenses"))
                        orders.AddParameters("@Npro", net)

                        orders.AddParameters("@Date", orders.DT.Rows(x)("Order_Date"))
                        orders.AddParameters("@OID", orders.DT.Rows(x)("Order_ID"))
                        orders.MakeQuery("UPDATE Orders SET Shop_ID=@SID, " &
                                         "Driver_ID=@DID, Gross_Profit=@GPro, Expenses=@exp, Net_Profit=@Npro " &
                                         "Order_Date=@Date WHERE Order_ID = @OID")
                    Case "Product.DT"

                        products.AddParameters("@Name", products.DT.Rows(x)("Product_Name"))
                        products.AddParameters("@CSize", products.DT.Rows(x)("Case_Size"))
                        products.AddParameters("@CPrice", products.DT.Rows(x)("Cost_Price"))
                        products.AddParameters("@SPrice", products.DT.Rows(x)("Sale_Price"))
                        products.AddParameters("@ID", products.DT.Rows(x)("Product_ID"))
                        products.MakeQuery("UPDATE Product SET Product_Name=@Name, Case_Size=@CSize" &
                                           " Cost_Price=@CPrice, Sale_Price=@SPrice WHERE Product_ID = @ID")
                    Case "Driver.DT"

                        Drivers.AddParameters("@Cap", Drivers.DT.Rows(x)("Maximum_Case_Capacity"))
                        Drivers.AddParameters("@User", Drivers.DT.Rows(x)("Driver_Username"))
                        Drivers.AddParameters("@Pass", Drivers.DT.Rows(x)("Driver_Password"))
                        Drivers.AddParameters("@ID", Drivers.DT.Rows(x)("Driver_ID"))
                        Drivers.MakeQuery("UPDATE Driver SET Maximum_Case_Capacity=@Cap, Driver_Username=@User," &
                                          " Driver_Password=@pass WHERE Driver_ID = @ID")
                    Case "Shop.DT"

                        shops.AddParameters("@Add", shops.DT.Rows(x)("Address"))
                        shops.AddParameters("@Post", shops.DT.Rows(x)("Postcode"))
                        shops.AddParameters("@Name", shops.DT.Rows(x)("Shop_Name"))
                        shops.AddParameters("@ID", shops.DT.Rows(x)("Shop_ID"))
                        shops.MakeQuery("UPDATE Shop SET Address=@Add, Postcode=@Post, Shop_Name=@Name WHERE Shop_ID = @ID")
                End Select
                DGVDataEditor.Update()
            End If
        Next

    End Sub

    Private Sub DriverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DriverToolStripMenuItem.Click
        AddDriver.Show()
    End Sub

    Private Sub OrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderToolStripMenuItem.Click
        AddOrder.Show()
    End Sub

    Private Sub ContactDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactDetailsToolStripMenuItem.Click
        AddContact.Show()
    End Sub

    Private Sub NewShopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewShopToolStripMenuItem.Click
        AddShop.Show()
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem.Click
        AddProduct.Show()
    End Sub

    Private Sub OrderlinesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrderlinesToolStripMenuItem1.Click
        display(OrderLine, "OrderLine")
        'This chunk of code makes it so that the user cannot edit cells which he/she is not meant to edit
        DGVDataEditor.Columns("Gross_Profit").ReadOnly = True
        DGVDataEditor.Columns("Order_ID").ReadOnly = True
        DGVDataEditor.Columns("Product_ID").ReadOnly = True
        'Because you want to make it possible for orders and orderlines to be deleted the orderline table will
        'show the delete button
        BTNDelete.Visible = True
    End Sub

    Private Sub ContactDetailsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ContactDetailsToolStripMenuItem1.Click
        display(contactdetails, "ContactDetails")
        'This chunk of code makes it so that the user cannot edit cells which he/she is not meant to edit
        DGVDataEditor.Columns("Shop_ID").ReadOnly = True
        DGVDataEditor.Columns("Contact_ID").ReadOnly = True
        'Allows the user to delete contact details
        BTNDelete.Visible = True
    End Sub

    Private Sub ShopToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ShopToolStripMenuItem1.Click
        display(shops, "Shop")
        'This chunk of code makes it so that the user cannot edit cells which he/she is not meant to edit
        DGVDataEditor.Columns("Shop_ID").ReadOnly = True
    End Sub

    Private Sub DriversToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DriversToolStripMenuItem.Click
        display(Drivers, "Driver")
        'This chunk of code makes it so that the user cannot edit cells which he/she is not meant to edit
        DGVDataEditor.Columns("Driver_ID").ReadOnly = True
        DGVDataEditor.Columns("Driver_FirstName").ReadOnly = True
        DGVDataEditor.Columns("Driver_LastName").ReadOnly = True
    End Sub

    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
        display(products, "Product")
        'This chunk of code makes it so that the user cannot edit cells which he/she is not meant to edit
        DGVDataEditor.Columns("Product_ID").ReadOnly = True
    End Sub

    Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdersToolStripMenuItem.Click
        display(orders, "Orders")
        'This chunk of code makes it so that the user cannot edit cells which he/she is not meant to edit
        DGVDataEditor.Columns("Gross_Profit").ReadOnly = True
        DGVDataEditor.Columns("Net_Profit").ReadOnly = True
        DGVDataEditor.Columns("Manager_ID").ReadOnly = True
        DGVDataEditor.Columns("Order_ID").ReadOnly = True
        'allows the user to delete records from this table
        BTNDelete.Visible = True
    End Sub
End Class
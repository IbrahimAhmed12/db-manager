Public Class Invoice
    Public obj As New OrderDetails
    Public contact, product As New DBController

    Private Sub BTNPrint_Click(sender As Object, e As EventArgs) Handles BTNPrint.Click
        'makes it so that the print button is not in the printout
        BTNPrint.Visible = False
        'makes a printout
        Printform.Form = Me
        Printform.PrintAction = Printing.PrintAction.PrintToPrinter
        Printform.Print()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'All of this is to set up the invoice for the relevant data for the invoice. Most of this data was taken
        'from the previous form and saved into the module
        LBLName.Text = shopName
        contact.AddParameters("@ID", "%" & shopID & "%")
        contact.MakeQuery("SELECT * FROM contactDetails WHERE Contact_ID like @ID")
        Try
            LBLEmail.Text = "Email: " & contact.DT.Rows(0)("E_Mail_Address")
        Catch ex As Exception
            LBLEmail.Text = ""
        End Try
        Try
            LBLTelNo.Text = "Tel No: " & contact.DT.Rows(0)("PhoneNumber")
        Catch ex As Exception
            LBLTelNo.Text = ""
        End Try
        LBLOrderID.Text = "Order No: " & ChosenOrder
        LBLProduct1.Text = products(0)
        LBLProduct2.Text = products(1)
        LBLProduct1Price.Text = price(0)
        LBLProductPrice.Text = price(1)
        LBlTotalPrice.Text = price(0) + price(1)
        LBLQuantity1.Text = amount(0)
        LBLquanttity2.Text = amount(1)
        LBLDate.Text = "Date:" & DateAndTime.DateString
    End Sub
End Class
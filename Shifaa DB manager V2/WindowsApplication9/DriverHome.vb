Public Class DriverHome
    Private orders As New DBController
    Private D As String
    Public OrderChosen As String
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Gets the date of today
        D = Date.Now.Date
        'Displays valid info to the driver
        LBLDate.Text = ("Date: " & D)
        LBLwelcome.Text = ("Welcome " & wName)
        LBLid.Text = ("DriverID: " & ID)
        'Adds the values needed to make a detailed search int the lists of parameters
        orders.AddParameters("@Driver_ID", ID)
        orders.AddParameters("@Date", D)
        'Makes the SQL statement that will be run
        orders.MakeQuery("SELECT Order_ID, Shop_ID FROM Orders WHERE Driver_ID = @Driver_ID AND @Date = Order_Date")
        'Displays the datatable in the datagrid
        DGVorders.DataSource = orders.DT
        'Fills the combobox with the all the orders in the table
        For Each R As DataRow In orders.DT.Rows
            CBXorders.Items.Add(R("Order_ID"))
        Next
    End Sub

    Private Sub BTNShowDeatails_Click(sender As Object, e As EventArgs) Handles BTNShowDeatails.Click
        Dim obj As New OrderDetails
        'checks if the combobox has an item selected to stop the program from crashing
        If String.IsNullOrEmpty(CBXorders.SelectedItem) = False Then
            'checks what item you have selected on the combobox
            OrderChosen = CBXorders.SelectedItem.ToString
            'Displays the OrderID in the next form
            obj.LBLOrderID.Text = "Order: " & OrderChosen
            'Saves the orderchosen in the module so it can be used anywhere in the program
            ChosenOrder = OrderChosen
            obj.Show()
        Else
            'error message
            MsgBox("Select an order")
        End If

    End Sub

    Private Sub BTNChangeDet_Click(sender As Object, e As EventArgs) Handles BTNChangeDet.Click
        Form6.Show()
    End Sub
End Class
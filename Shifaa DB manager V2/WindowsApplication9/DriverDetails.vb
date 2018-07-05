Public Class Form6
    Public Edit As New DBController


    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Loads up all the previous data for the driver
        Edit.AddParameters("@ID", ID)
        Edit.MakeQuery("SELECT * FROM Driver WHERE Driver_ID = @ID")
        TXTCarCapacity.Text = Edit.DT.Rows(0)("Maximum_Case_Capacity")
        TXTPassword.Text = Edit.DT.Rows(0)("Driver_Password")
        TXTUsername.Text = Edit.DT.Rows(0)("Driver_Username")
    End Sub

    Private Sub BTNSave_Click(sender As Object, e As EventArgs) Handles BTNSave.Click
        'Puts in all the data thats going to be replacing the old data as parameters for the query
        Edit.AddParameters("@CC", TXTCarCapacity.Text)

        Edit.AddParameters("@pass", TXTPassword.Text)

        Edit.AddParameters("@user", TXTUsername.Text)

        Edit.AddParameters("@ID", ID)
        'SQL statement for updating a database
        Edit.MakeQuery("UPDATE Driver SET Maximum_case_capacity=@cc, Driver_Password=@pass, Driver_Username=@user" &
        " WHERE Driver_ID = @ID")

    End Sub
End Class
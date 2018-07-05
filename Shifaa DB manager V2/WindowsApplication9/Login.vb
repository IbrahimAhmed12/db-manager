
Public Class Login
    Private Drivers, Managers As New DBController
    Public correctrow As Integer



    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles Loginbtn.Click
        'Loads up the parameters and runs a search in the drver table
        Drivers.AddParameters("@Driver_Username", TXTUsername.Text.ToString)
        Drivers.AddParameters("@Driver_Password", TXTPassword.Text.ToString)
        Drivers.MakeQuery("SELECT Driver_Username, Driver_Password, Driver_ID, Driver_FirstName FROM Driver WHERE Driver_Username = @Driver_Username 
                          AND Driver_Password = @Driver_Password")
        'If the combination of password and username in the table then he record count would = 1 so if it does exist it checks if it is correct
        If Drivers.recordcount = 1 Then
            ID = Drivers.DT.Rows(0)("Driver_ID").ToString()
            wName = Drivers.DT.Rows(0)("Driver_FirstName").ToString()
            DriverHome.Show()
            Drivers.DT.Clear()
        Else
            'the same tasks ares then repeated for managers
            Managers.AddParameters("@Manager_Username", TXTUsername.Text.ToString)
            Managers.AddParameters("@Manager_Password", TXTPassword.Text.ToString)
            Managers.MakeQuery("SELECT Manager_Username, Manager_Password, Manager_ID, Manager_Name FROM SaleManager WHERE Manager_Username = @Manager_Username 
                          AND Manager_Password = @Manager_Password")

            If Managers.recordcount = 1 Then
                ID = Managers.DT.Rows(0)("Manager_ID").ToString
                wName = Managers.DT.Rows(0)("Manager_Name").ToString
                ManagerHome.Show()
                Managers.DT.Clear()
            Else
                'if there are no records found in either one o the tables a messsage is showed hat says on f e fields are wrong
                MsgBox("Enter correct username and password")
            End If
        End If
    End Sub
End Class

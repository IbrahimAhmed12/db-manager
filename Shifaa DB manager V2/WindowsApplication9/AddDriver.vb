Public Class AddDriver
    Public insert As New DBController
    Public username, password, DID As String
    Public chars(20) As Char



    Public cc As Integer

    Private Sub BTNSaveRecord_Click(sender As Object, e As EventArgs) Handles BTNSaveRecord.Click
        Dim number As Integer
        'this checks of the user entered a number into carcapacity field or if any of them havnt been filled out
        If TXTFirstName.Text = "" Or TXTLastName.Text = "" Or Integer.TryParse(TXTCarCapacity.Text, number) = False Then
            'error message
            MsgBox("Please fill out all Fields with valid data")
        Else
            'This checks how many people in the database has the same 3 letters for their ID then adds the amount of people with same surname to the end creating a unique ID
            chars = TXTLastName.Text.ToCharArray
            DID = chars(0) & chars(1) & chars(2)
            insert.AddParameters("@ID", "%" & DID & "%")
            insert.MakeQuery("SELECT Driver_ID FROM Driver WHERE Driver_ID = @ID")
            DID = DID & (insert.recordcount + 120).ToString
            insert.clearDT()
            'conerts the calue in the textbox into an integer
            cc = Integer.Parse(TXTCarCapacity.Text)
            'Creates a Username frome their firstname and lastname
            username = TXTFirstName.Text & TXTLastName.Text.First
            'This sets up all the parameters in the order they will be called in the querry
            insert.AddParameters("@ID", DID)
            insert.AddParameters("@CarCap", cc)
            insert.AddParameters("@user", username)
            insert.AddParameters("@pass", "Password1")
            insert.AddParameters("@Fname", TXTFirstName.Text)
            insert.AddParameters("@Lname", TXTLastName.Text)
            'This is the main sql query that will insert a new record in the table
            insert.MakeQuery("INSERT INTO Driver (Driver_ID,Maximum_Case_Capacity,Driver_Username,Driver_Password,Driver_FirstName,Driver_LastName) " &
                             "VALUES (@ID,@CarCap,@user,@pass,@Fname,@Lname);")
            'to show the user new record has been been saved
            MsgBox("Saved")
        End If
    End Sub
End Class
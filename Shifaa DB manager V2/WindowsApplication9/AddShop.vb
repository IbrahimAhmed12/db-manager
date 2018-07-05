Public Class AddShop
    Public shop, contact As New DBController
    Public namecopy, postcopy, SID, CID As String
    Private Sub BTNDescription_Click(sender As Object, e As EventArgs) Handles BTNDescription.Click
        MsgBox("The First three boxes must be filled out and atleast a Phonenumber or E-mail should be entered")
    End Sub

    Private Sub BTNSave_Click(sender As Object, e As EventArgs) Handles BTNSave.Click
        If TXTAddress.Text = "" Or TXTName.Text = "" Or TXTPostCode.Text = "" Then
            MsgBox("Please fill out all the fields")
        Else
            'checks if both contacts where not filled out
            If TXTEmail.Text = "" And TXTPhone.Text = "" Then
                MsgBox("Add a contact detail")
            Else
                'Creates a unique primary key
                namecopy = TXTName.Text
                namecopy.ToUpper()
                namecopy.ToCharArray()
                postcopy = TXTPostCode.Text
                postcopy.ToUpper()
                postcopy.ToCharArray()
                SID = namecopy(0) & namecopy(1) & postcopy(0)
                'This finds how many records have the same 3 initials and changes the nubers after
                shop.AddParameters("@ID", "%" & SID & "%")
                shop.MakeQuery("SELECT * FROM Shop WHERE Shop_ID LIKE @ID")
                SID = SID & (shop.recordcount + 100).ToString
                'This inserts all the valid info in the aql statement
                shop.AddParameters("@ID", SID)
                shop.AddParameters("@Name", TXTName.Text)
                shop.AddParameters("@Address", TXTAddress.Text)
                shop.AddParameters("@Postcode", TXTPostCode.Text)
                shop.MakeQuery("INSERT INTO Shop (Shop_ID,Shop_Name,Address,Postcode) " &
                               "VALUES (@ID,@Name,@Address,@Postcode)")
                'makes the first contactID for the shop
                CID = SID & "1"
                'checks which combination of contact details the user inputted and saves it accordingl into the database
                If TXTEmail.Text = "" Then

                    contact.AddParameters("@ID", CID)
                    contact.AddParameters("@SID", SID)
                    contact.AddParameters("@Phone", TXTPhone.Text)
                    contact.MakeQuery("INSERT INTO ContactDetails (Contact_ID,Shop_ID,PhoneNumber) " &
                                      "VALUES (@ID,@SID,@Phone)")
                    'tells the user a the shop has been inserted along with the contact details
                    MsgBox("Saved")
                ElseIf LBLPhone.Text = "" Then
                    contact.AddParameters("@ID", CID)
                    contact.AddParameters("@SID", SID)
                    contact.AddParameters("@Phone", TXTPhone.Text)
                    contact.AddParameters("@Email", TXTEmail.Text)
                    contact.MakeQuery("INSERT INTO ContactDetails (Contact_ID,Shop_ID,PhoneNumber,E_Mail_Address) " &
                                      "VALUES (@ID,@SID,@Phone,@Email)")
                    'tells the user a the shop has been inserted along with the contact details
                    MsgBox("Saved")
                Else
                    contact.AddParameters("@ID", CID)
                    contact.AddParameters("@Email", TXTEmail.Text)
                    contact.AddParameters("@SID", SID)
                    contact.AddParameters("@Phone", TXTPhone.Text)
                    contact.MakeQuery("INSERT INTO ContactDetails (Contact_ID,E_Mail_Address,Shop_ID,PhoneNumber) " &
                                      "VALUES (@ID,@Email,@SID,@Phone)")
                    'tells the user a the shop has been inserted along with the contact details
                    MsgBox("Saved")
                End If

            End If
        End If
    End Sub
End Class
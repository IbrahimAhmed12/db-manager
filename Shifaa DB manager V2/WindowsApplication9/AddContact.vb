Public Class AddContact
    Public contact, shop As New DBController
    Public CID, SID As String
    Private Sub BTNSave_Click(sender As Object, e As EventArgs) Handles BTNSave.Click
        If String.IsNullOrEmpty(CBXShopNames.SelectedItem) = False Then
            shop.clearDT()
            'finds the ID of the shop that was selected
            shop.AddParameters("@Name", CBXShopNames.SelectedItem.ToString)
            shop.MakeQuery("SELECT Shop_ID FROM Shop WHERE Shop_Name = @name")
            SID = shop.DT.Rows(0)("Shop_ID")
            'finds how many contacts the shop has and generates a new unique ID from it
            contact.AddParameters("@ID", "%" & shop.DT.Rows(0)("Shop_ID") & "%")
            contact.MakeQuery("SELECT * FROM ContactDetails WHERE Contact_ID LIKE @ID")
            CID = SID & (contact.recordcount).ToString
            'clears he datatable so no infomation is kept
            shop.clearDT()
            'checks if the user entered an email or phonenumber or both or none and saves it in the database
            If TXTEmail.Text = "" And TXTPhoneNumber.Text IsNot "" Then
                contact.AddParameters("@ID", CID)
                contact.AddParameters("@Phone", TXTPhoneNumber.Text)
                contact.AddParameters("@SID", SID)
                contact.MakeQuery("INSERT INTO ContactDetails (Contact_ID,PhoneNumber,Shop_ID) " &
                                  "VALUES (@ID,@Phone,@SID)")
                'tells the user new record has been saved
                MsgBox("saved")
            ElseIf TXTPhoneNumber.Text = "" And TXTEmail.Text = "" Then
                MsgBox("Add a contact detail")
            ElseIf TXTPhoneNumber.Text = "" And TXTEmail.Text IsNot "" Then
                contact.AddParameters("@ID", CID)
                contact.AddParameters("@Email", TXTEmail.Text)
                contact.AddParameters("@SID", SID)
                contact.MakeQuery("INSERT INTO ContactDetails (Contact_ID,E_Mail_Address,Shop_ID) " &
                                  "VALUES (@ID,@Email,@SID)")
                'tells the user new record has been saved
                MsgBox("saved")
            Else
                contact.AddParameters("@ID", CID)
                contact.AddParameters("@Email", TXTEmail.Text)
                contact.AddParameters("@SID", SID)
                contact.AddParameters("@Phone", TXTPhoneNumber.Text)
                contact.MakeQuery("INSERT INTO ContactDetails (Contact_ID,E_Mail_Address,Shop_ID,PhoneNumber) " &
                                  "VALUES (@ID,@Email,@SID,@Phone)")
                'tells the user new record has been saved
                MsgBox("saved")
            End If
        Else
            'creates an error message
            MsgBox("Select a shop name")
        End If
    End Sub

    Private Sub AddContact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'fills the combobox with all the shop names
        shop.MakeQuery("SELECT * FROM Shop")
        For Each r As DataRow In shop.DT.Rows
            CBXShopNames.Items.Add(r("Shop_Name"))
        Next
    End Sub
End Class
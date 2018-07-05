Public Class Warning
    Private Sub BTNYes_Click(sender As Object, e As EventArgs) Handles BTNYes.Click
        confirm = True
        TableManager.Pause.Start()
        TableManager.Pause.Stop()
        Me.Hide()
    End Sub

    Private Sub BTNNo_Click(sender As Object, e As EventArgs) Handles BTNNo.Click
        confirm = False
        TableManager.Pause.Start()
        TableManager.Pause.Stop()
        Me.Hide()
    End Sub
End Class
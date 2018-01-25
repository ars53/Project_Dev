Public Class SignIn
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtPassword.Clear()
        txtUser.Clear()
        txtUser.Focus()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If txtUser.Text.ToLower = "arshephe" And txtPassword.Text = "Password" Then
            MsgBox("Congrats")
        Else
            MsgBox("Wrong Password")
        End If
    End Sub
End Class
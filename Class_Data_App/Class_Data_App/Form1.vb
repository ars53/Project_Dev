Public Class Form1
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        SignIn.Show()
        Me.Dispose()
    End Sub
End Class

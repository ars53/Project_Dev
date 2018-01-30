Public Class Form1
    Protected db As New db
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        SignIn.Show()
        Me.Dispose()
    End Sub
    Protected Sub loadClasses()
        db.sql = "Select * FROM CLASS"
        db.fill(dgvDisplay)
    End Sub

    Private Sub dgvDisplay_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDisplay.CellContentClick

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadClasses()

    End Sub
End Class

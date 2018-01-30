Public Class Form1
    Protected db As New db
    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        SignIn.Show()
        Me.Dispose()
    End Sub
    Protected Sub loadClasses()
        db.sql = "Select * FROM STUDENT"
        db.fill(dgvDisplay)
    End Sub

    Private Sub dgvDisplay_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDisplay.CellContentClick

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadClasses()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        SignIn.Show()
        Me.Dispose()

    End Sub

    Private Sub StudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem.Click
        AddStudent.ShowDialog()
        loadClasses()

    End Sub

    Private Sub CourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CourseToolStripMenuItem.Click
        AddClass.ShowDialog()

    End Sub

    Private Sub InstructorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstructorToolStripMenuItem.Click
        AddTeacher.ShowDialog()

    End Sub
End Class

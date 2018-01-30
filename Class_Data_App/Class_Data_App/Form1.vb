Public Class Form1
    Protected db As New db
    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        SignIn.Show()
        Me.Dispose()
    End Sub
    Protected Sub loadClasses()
        db.sql = "Select * FROM CLASS"
        db.fill(dgvClass)
        dgvClass.Visible = True
        dgvStudent.Visible = False
        dgvInstructor.Visible = False
        picHome.Visible = False

    End Sub
    Protected Sub loadStudents()
        db.sql = "Select * FROM STUDENT"
        db.fill(dgvStudent)
        dgvClass.Visible = False
        dgvStudent.Visible = True
        dgvInstructor.Visible = False
        picHome.Visible = False
    End Sub
    Protected Sub loadInstructors()
        db.sql = "Select * FROM Instructor"

        db.fill(dgvInstructor)
        dgvClass.Visible = False
        dgvStudent.Visible = False
        dgvInstructor.Visible = True
        picHome.Visible = False

    End Sub

    Private Sub dgvDisplay_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClass.CellContentClick

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        SignIn.Show()
        Me.Dispose()

    End Sub

    Private Sub StudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem.Click
        AddStudent.ShowDialog()
        loadStudents()


    End Sub

    Private Sub CourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CourseToolStripMenuItem.Click
        AddClass.ShowDialog()
        loadClasses()


    End Sub

    Private Sub InstructorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstructorToolStripMenuItem.Click
        AddTeacher.ShowDialog()
        loadInstructors()


    End Sub

    Private Sub ClassesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassesToolStripMenuItem.Click
        loadClasses()

    End Sub

    Private Sub StudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentsToolStripMenuItem.Click
        loadStudents()

    End Sub

    Private Sub InstructorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstructorsToolStripMenuItem.Click
        loadInstructors()

    End Sub
    Public Function getStudentID() As Integer
        Return getStudentValue("SID")
    End Function
    Public Function getStudentvalue(ByVal column As String)
        Return dgvStudent.Item(column, dgvStudent.CurrentRow.Index).Value
    End Function
    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        If dgvStudent.Visible = True Then
            Dim UpdateStudent As New UpdateStudent(getStudentID())
            UpdateStudent.Enabled = True
            UpdateStudent.ShowDialog()
            loadStudents()
        ElseIf dgvInstructor.Visible = True Then
            Dim updateInstructor As New UpdateInstructor(getInstructorID())
            updateInstructor.ShowDialog()
            loadInstructors()
        ElseIf dgvClass.Visible = True Then
            Dim updateClass As New UpdateClass(getClassName())
            updateClass.ShowDialog()

            loadClasses()

        End If
    End Sub
    Public Function getInstructorID() As Integer
        Return getInstructorValue("TID")
    End Function
    Public Function getInstructorValue(ByVal column As String)
        Return dgvInstructor.Item(column, dgvInstructor.CurrentRow.Index).Value
    End Function
    Public Function getClassName() As String
        Return getClassValue("Name")
    End Function
    Public Function getClassValue(ByVal column As String)
        Return dgvClass.Item(column, dgvClass.CurrentRow.Index).Value
    End Function
End Class

Public Class Form1
    Protected db As New db
    Private Sub btnLogout_Click(sender As Object, e As EventArgs)

        SignIn.Show()


        Me.Close()
    End Sub
    Protected Sub loadClasses()
        db.sql = "Select * FROM CLASS"
        db.fill(dgvClass)
        dgvClass.Visible = True
        dgvStudent.Visible = False
        dgvInstructor.Visible = False
        picHome.Visible = False
        StudentDetailstoolStrip.Enabled = False
        InstructordetailsToolStrip.Enabled = False
        ClassHeadToolStrip.Enabled = True
        btnFirst.Visible = True
        btnNext.Visible = True
        btnLast.Visible = True
        btnPrev.Visible = True

    End Sub
    Protected Sub loadStudents()
        db.sql = "Select * FROM STUDENT"
        db.fill(dgvStudent)
        dgvClass.Visible = False
        dgvStudent.Visible = True
        dgvInstructor.Visible = False
        picHome.Visible = False
        InstructordetailsToolStrip.Enabled = False
        ClassHeadToolStrip.Enabled = False
        StudentDetailstoolStrip.Enabled = True
        btnFirst.Visible = True
        btnNext.Visible = True
        btnLast.Visible = True
        btnPrev.Visible = True

    End Sub
    Protected Sub loadInstructors()
        db.sql = "Select * FROM Instructor"

        db.fill(dgvInstructor)
        dgvClass.Visible = False
        dgvStudent.Visible = False
        dgvInstructor.Visible = True
        picHome.Visible = False
        StudentDetailstoolStrip.Enabled = False
        ClassHeadToolStrip.Enabled = False
        InstructordetailsToolStrip.Enabled = True
        btnFirst.Visible = True
        btnNext.Visible = True
        btnLast.Visible = True
        btnPrev.Visible = True

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





    Private Sub StudentToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StudentDetailstoolStrip.Click
        If picHome.Visible = True Then

        Else
            Dim studentDetails As New DetailsStudent(getStudentID())
            studentDetails.ShowDialog()
            loadStudents()
        End If

    End Sub

    Private Sub InstructorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InstructordetailsToolStrip.Click
        If picHome.Visible = True Then

        Else
            Dim iDetails As New DetailsInstructor(getInstructorID())
            iDetails.ShowDialog()
            loadInstructors()
        End If

    End Sub

    Private Sub RosterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RosterToolStripMenuItem.Click
        If picHome.Visible = True Then
        Else
            Dim cDetails As New ClassRoster(getClassName())
            cDetails.ShowDialog()
            loadClasses()
        End If


    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        If dgvClass.Visible = True Then
            dgvClass.CurrentCell = dgvClass.Item(0, 0)
        ElseIf dgvInstructor.Visible = True Then
            dgvInstructor.CurrentCell = dgvInstructor.Item(0, 0)
        ElseIf dgvStudent.Visible = True Then
            dgvStudent.CurrentCell = dgvStudent.Item(0, 0)
        End If


    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        dgvClass.Visible = False
        dgvInstructor.Visible = False
        dgvStudent.Visible = False
        picHome.Visible = True
        InstructordetailsToolStrip.Enabled = True
        StudentDetailstoolStrip.Enabled = True
        ClassHeadToolStrip.Enabled = True
        btnFirst.Visible = False
        btnNext.Visible = False
        btnLast.Visible = False
        btnPrev.Visible = False
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If dgvClass.Visible = True Then
            Dim current_ROW As Integer = dgvClass.CurrentCell.RowIndex
            Dim next_Row As Integer = dgvClass.CurrentCell.RowIndex + 1
            Dim Max_row As Integer = dgvClass.Rows.Count

            If Max_row = current_ROW Then
                MsgBox("You have reached the end of the line")
            ElseIf current_ROW < Max_row Then
                dgvClass.CurrentCell = dgvClass.Item(0, next_Row)
            End If
        ElseIf dgvStudent.Visible = True Then
            Dim current_ROW As Integer = dgvStudent.CurrentCell.RowIndex
            Dim next_Row As Integer = dgvStudent.CurrentCell.RowIndex + 1
            Dim Max_row As Integer = dgvStudent.Rows.Count

            If Max_row = current_ROW Then
            Else
                dgvStudent.CurrentCell = dgvStudent.Item(0, next_Row)
            End If
        ElseIf dgvInstructor.Visible = True Then
            Dim current_ROW As Integer = dgvInstructor.CurrentCell.RowIndex
            Dim next_Row As Integer = dgvInstructor.CurrentCell.RowIndex + 1
            Dim Max_row As Integer = dgvInstructor.Rows.Count

            If Max_row = current_ROW Then
            Else
                dgvInstructor.CurrentCell = dgvInstructor.Item(0, next_Row)
            End If

        End If
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If dgvClass.Visible = True Then
            Dim current_ROW As Integer = dgvClass.CurrentCell.RowIndex
            Dim next_Row As Integer = dgvClass.CurrentCell.RowIndex - 1
            Dim Max_row As Integer = dgvClass.Rows.Count

            If Max_row = current_ROW Then
                MsgBox("You have reached the end of the line")
            ElseIf current_ROW < Max_row Then
                dgvClass.CurrentCell = dgvClass.Item(0, next_Row)
            End If
        ElseIf dgvStudent.Visible = True Then
            Dim current_ROW As Integer = dgvStudent.CurrentCell.RowIndex
            Dim next_Row As Integer = dgvStudent.CurrentCell.RowIndex - 1
            Dim Max_row As Integer = dgvStudent.Rows.Count

            If Max_row = current_ROW Then
            Else
                dgvStudent.CurrentCell = dgvStudent.Item(0, next_Row)
            End If
        ElseIf dgvInstructor.Visible = True Then
            Dim current_ROW As Integer = dgvInstructor.CurrentCell.RowIndex
            Dim next_Row As Integer = dgvInstructor.CurrentCell.RowIndex - 1
            Dim Max_row As Integer = dgvInstructor.Rows.Count

            If Max_row = current_ROW Then
            Else
                dgvInstructor.CurrentCell = dgvInstructor.Item(0, next_Row)
            End If

        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        If dgvClass.Visible = True Then
            Dim max_row As Integer = dgvClass.Rows.Count - 1
            Dim max_index As Integer = dgvClass.Rows(max_row).Index
            dgvClass.CurrentCell = dgvClass.Item(0, max_index)
        ElseIf dgvStudent.Visible = True Then
            Dim max_row As Integer = dgvStudent.Rows.Count - 1
            Dim max_index As Integer = dgvStudent.Rows(max_row).Index
            dgvStudent.CurrentCell = dgvStudent.Item(0, max_index)
        ElseIf dgvInstructor.Visible = True Then
            Dim max_row As Integer = dgvInstructor.Rows.Count - 1
            Dim max_index As Integer = dgvInstructor.Rows(max_row).Index
            dgvInstructor.CurrentCell = dgvInstructor.Item(0, max_index)
        End If
    End Sub


End Class

Public Class AddStudent
    Protected db As New db
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If IsNumeric(txtAge.Text) Then
            'do this
            db.sql = "INSERT INTO STUDENT VALUES (@name, @major, @gradelvl, @age)"
            db.bind("@name", txtName.Text)
            db.bind("@major", txtMajor.Text)
            db.bind("@gradelvl", txtGrade.Text)
            db.bind("@age", txtAge.Text)
            db.execute()
            Me.Dispose()


        Else
            MsgBox("Age must be a number")
        End If
    End Sub
End Class
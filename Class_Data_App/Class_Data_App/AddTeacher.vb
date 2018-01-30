Public Class AddTeacher
    Protected db As New db
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If IsNumeric(txtTid.Text) = True Then
            db.sql = "INSERT INTO INSTRUCTOR VALUES (@tid, @name);"
            db.bind("@tid", txtTid.Text)
            db.bind("@name", txtName.Text)
            db.execute()
            Me.Dispose()
        Else
            MsgBox("Instructor ID must be a number")
        End If


    End Sub
End Class
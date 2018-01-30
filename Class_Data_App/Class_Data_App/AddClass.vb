Public Class AddClass
    Protected db As New db
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If IsNumeric(txtTid.Text) = True Then
            db.sql = "INSERT INTO CLASS VALUES (@name, @time, @tid, @room);"
            db.bind("@name", txtName.Text)
            db.bind("@time", txtTime.Text)
            db.bind("@tid", txtTid.Text)
            db.bind("@room", txtRoom.Text)
            db.execute()
            Me.Dispose()
        Else
            MsgBox("Instructor ID must be numeric")
        End If
    End Sub
End Class
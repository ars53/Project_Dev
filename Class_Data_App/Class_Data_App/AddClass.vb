Imports System.Data.SqlClient
Public Class AddClass
    Protected db As New db
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=arshephe; Trusted_Connection=yes"}
        Dim command As New SqlCommand("Select * FROM Instructor where TID = @tid", connection)
        command.Parameters.Add("@tid", SqlDbType.SmallInt).Value = txtTid.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("This instructor ID is not present in the Instructors table")
        ElseIf IsNumeric(txtTid.Text) = True Then
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
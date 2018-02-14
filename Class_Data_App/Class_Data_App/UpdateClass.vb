Imports System.Data.SqlClient
Public Class UpdateClass
    Protected db As New db
    Protected ClassName As String
    Public Sub New(ByVal Name As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ClassName = Name
        txtName.Text = Form1.getClassValue("Name").ToString
        txtTime.Text = Form1.getClassValue("CLSTime").ToString
        txtTID.Text = Form1.getClassValue("TID").ToString
        txtRoom.Text = Form1.getClassValue("Room").ToString

    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=arshephe; Trusted_Connection=yes"}
        Dim command As New SqlCommand("Select * FROM Instructor where TID = @tid", connection)
        command.Parameters.Add("@tid", SqlDbType.SmallInt).Value = txtTID.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("This instructor ID is not present in the Instructors table")
        Else
            db.sql = "UPDATE Class set Name = @name, CLSTIME = @time, TID = @tid, room = @room"
            db.bind("@name", txtName.Text)
            db.bind("@time", txtTime.Text)
            db.bind("@tid", txtTID.Text)
            db.bind("@room", txtRoom.Text)
            db.execute()
            Me.Dispose()


        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
End Class
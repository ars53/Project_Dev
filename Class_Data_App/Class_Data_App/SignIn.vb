Imports System.Data.SqlClient


Public Class SignIn

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=arshephe; Trusted_Connection=yes"}
        Dim command As New SqlCommand("Select * FROM Logins where USERNAME = @username AND Password = @password", connection)
        command.Parameters.Add("@username", SqlDbType.VarChar).Value = txtUser.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = txtPassword.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Wrong password")
        Else
            Form1.Show()
            Me.Dispose()
        End If
        'txtPassword.Clear()
        'txtUser.Clear()
        'txtUser.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtPassword.Clear()
        txtUser.Clear()
        txtUser.Focus()
    End Sub

    Private Sub SignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Focus()
    End Sub
End Class
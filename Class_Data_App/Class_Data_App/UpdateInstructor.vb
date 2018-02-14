Public Class UpdateInstructor
    Protected db As New db
    Protected instructorID As New Integer
    Public Sub New(ByVal TID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        instructorID = TID
        txtTid.Text = Form1.getInstructorValue("TID").ToString
        txtName.Text = Form1.getInstructorValue("Name").ToString
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtName.Text.Length > 0 Then
            db.sql = "UPDATE Instructor set name = @name WHERE TID = @tid"
            db.bind("@name", txtName.Text)
            db.bind("@tid", txtTid.Text)
            db.execute()
            Me.Dispose()

        Else
            MsgBox("Name field cannot be empty")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
End Class
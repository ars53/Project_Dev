Public Class UpdateStudent
    Protected db As New db
    Protected studentID As New Integer
    Public Sub New(ByVal sid As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        studentID = sid

        txtSid.Text = Form1.getStudentvalue("SID").ToString
        txtName.Text = Form1.getStudentvalue("Name").ToString
        txtMajor.Text = Form1.getStudentvalue("Major").ToString
        txtGrade.Text = Form1.getStudentvalue("GradeLVL").ToString
        txtAge.Text = Form1.getStudentvalue("Age").ToString


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If IsNumeric(txtAge.Text) = True And txtGrade.Text.Length > 0 And txtMajor.Text.Length > 0 And txtName.Text.Length > 0 Then
            db.sql = "UPDATE STUDENT SET Name = @name, major = @major, GRADELVL = @grade, age = @age WHERE SID = @sid"
            db.bind("@name", txtName.Text)
            db.bind("@major", txtMajor.Text)
            db.bind("@grade", txtGrade.Text)
            db.bind("@age", txtAge.Text)
            db.bind("@sid", txtSid.Text)
            db.execute()
            Me.Dispose()

        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
End Class
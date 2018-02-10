Public Class DetailsStudent
    Protected db As New db
    Protected SID As Integer
    Public Sub New(ByVal id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        SID = id

    End Sub

    Private Sub DetailsStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.sql = "SELECT ClassName AS Class, Time, Room, InstructorName FROM StudentDetails WHERE Student_ID = @id"
        db.bind("@id", SID)

        db.fill(DataGridView1)

    End Sub
End Class
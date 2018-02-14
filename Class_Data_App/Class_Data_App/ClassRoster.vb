Public Class ClassRoster
    Protected db As New db
    Protected cname As String
    Public Sub New(ByVal Name As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        cname = Name
    End Sub
    Private Sub ClassRoster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.sql = "SELECT s.NAME, s.GRADELVL, s.MAJOR, s.SID, s.AGE FROM CLASS c JOIN Enroll e on e.CLASSNAME = c.NAME JOIN STUDENT s on e.STUNUM = s.SID WHERE c.NAME = @name"
        db.bind("@name", cname)
        db.fill(dgvRoster)
    End Sub
End Class
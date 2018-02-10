Public Class DetailsInstructor
    Protected db As New db
    Protected TID As Integer
    Public Sub New(ByVal id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TID = id
    End Sub

    Private Sub DetailsInstructor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.sql = "SELECT COUNT(@id) AS Total_Classes_Teaching, Name, CLSTIME, ROOM, Currently_Enrolled from InstructorDetails WHERE TID = @id Group BY name, clstime, room, Currently_Enrolled "
        db.bind("@id", TID)

        db.fill(dgvInstructor)
    End Sub
End Class
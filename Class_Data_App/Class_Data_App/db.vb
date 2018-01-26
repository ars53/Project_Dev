Imports System.Data.SqlClient

Public Class db
    'login to db server'
    Protected connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283F1715; Trusted_Connection=yes"}
    'prep query'
    Protected command As New SqlCommand With {.Connection = connection}

    'set ang get sql command
    Public Property sql() As String
        Get
            Return command.CommandText
        End Get
        Set(value As String)
            command.CommandText = value
        End Set
    End Property
    Public Sub bind(ByVal parameter As String, ByRef value As Object)
        command.Parameters.AddWithValue(parameter, value)
    End Sub

End Class

Imports System.Data.SqlClient
Public Class Connection
    Public conn = New SqlConnection
    Dim sql As String = "Data Source=.\SQLEXPRESS;Initial Catalog=PC_SB_MODUL2;Integrated Security=True"

    Public Sub open()
        Try
            conn = New SqlConnection(sql)
            conn.Open()
        Catch ex As Exception
            MsgBox("Connection error")
        End Try
    End Sub
    Public Sub close()
        Try
            conn.Close()
        Catch ex As Exception
            MsgBox("Connection already closed")
        End Try
    End Sub
End Class

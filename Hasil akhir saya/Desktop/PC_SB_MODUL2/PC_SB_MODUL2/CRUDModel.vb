Imports System.Data.SqlClient
Public Class CRUDModel
    Dim Conn As New Connection
    Public Sub Create(table_name, column(), data())
        Try
            Conn.Open()
            Dim cmd As New SqlCommand
            Dim queryInsert = "INSERT INTO " & table_name & " (" & String.Join(", ", column) & ") VALUES ("

            For i = 0 To data.Length - 1
                If Not i = data.Length - 1 Then
                    queryInsert &= " '" & data(i) & "', "
                Else
                    queryInsert &= " '" & data(i) & "')"
                End If
            Next
            MsgBox(queryInsert)
            cmd = New SqlCommand(Conn.conn, queryInsert)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Insert Failed")
        Finally
            Conn.Close()
        End Try
    End Sub
    Public Function Read(query) As SqlDataReader
        Dim dr As SqlDataReader
        Try
            Conn.Open()
            Dim cmd As New SqlCommand

            cmd = New SqlCommand(query, Conn.conn)
            dr = cmd.ExecuteReader

        Catch ex As Exception
            MsgBox("Kesalahan dalam menampilkan data")
        End Try
        Return dr
    End Function
End Class

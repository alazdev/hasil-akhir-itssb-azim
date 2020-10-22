Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Public Class LoginForm
    Dim CRUDModel As New CRUDModel()

    'Dim emailPattern As String = "^([0-9A-Za-z]([-\.\w]*[0-9A-Za-z])*@([0-9A-Za-z][-\w]*[0-9A-Za-z]\.)+[A-Za-z]{2,9})$"
    'Dim passwordPattern As String = "^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).*$"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        validasi()
    End Sub
    Private Sub validasi()
        Dim read = CRUDModel.Read("SELECT Name, Password FROM Employee WHERE Name='" & TextBox1.Text & "' AND Password='" & TextBox2.Text & "'")
        If read.HasRows Then
            While read.Read
                If Regex.IsMatch(TextBox2.Text, read.Item("Password")) Then
                    Dim MainForm As New MainForm()
                    MainForm.Show()
                    MainForm.username = TextBox1.Text
                    Me.Hide()
                Else
                    MsgBox("Please Try Again, Your Data Is Not Valid!")
                End If
            End While
        Else
            MsgBox("Please Try Again, Your Data Is Not Valid!")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
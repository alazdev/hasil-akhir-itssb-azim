Public Class MainForm
    Public username = ""
    Private Sub changePanel(ByVal form As Form)
        SplitContainer1.Panel2.Controls.Clear()
        form.TopLevel = False
        SplitContainer1.Panel2.Controls.Add(form)
        form.Show()
    End Sub
    Public Sub changeButt(btn As Button)
        Dim button As Button() = {Button3, Button4, Button5, Button6, Button7, Button8}
        For Each a As Button In button
            a.Visible = True
            If button Is btn Then
                a.Visible = False
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        changeButt(Button3)
        changePanel(New EmployeeForm)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        changeButt(Button4)
        changePanel(New ServiceForm)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        changeButt(Button5)
        changePanel(New PackageForm)
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        changeButt(Button6)
        changePanel(New TransactionDepositForm)
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        changeButt(Button7)
        changePanel(New PrepaidPackageForm)
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        changeButt(Button8)
        changePanel(New ViewTransactionForm)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim LoginForm = New LoginForm()
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = "Hai, " & username
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Hide" Then
            SplitContainer1.Panel1.Hide()
            SplitContainer1.Panel1Collapsed = True
            Button1.Text = "Show"
        Else
            SplitContainer1.Panel1.Show()
            SplitContainer1.Panel1Collapsed = False
            Button1.Text = "Hide"
        End If
    End Sub
End Class
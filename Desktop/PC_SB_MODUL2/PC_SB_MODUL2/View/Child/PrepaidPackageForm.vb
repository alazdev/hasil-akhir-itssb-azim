Public Class PrepaidPackageForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim AddCus As New AddCustomerForm()
        AddCus.Show()
    End Sub

    Private Sub PrepaidPackageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PC_SB_MODUL2DataSet.View_PrepaidPackage' table. You can move, or remove it, as needed.
        Me.View_PrepaidPackageTableAdapter.Fill(Me.PC_SB_MODUL2DataSet.View_PrepaidPackage)

    End Sub
End Class
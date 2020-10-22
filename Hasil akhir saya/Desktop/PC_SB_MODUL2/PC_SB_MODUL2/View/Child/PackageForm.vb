Public Class PackageForm
    Private Sub PackageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PC_SB_MODUL2DataSet.View_Pacakge_Service' table. You can move, or remove it, as needed.
        Me.View_Pacakge_ServiceTableAdapter.Fill(Me.PC_SB_MODUL2DataSet.View_Pacakge_Service)

    End Sub
End Class
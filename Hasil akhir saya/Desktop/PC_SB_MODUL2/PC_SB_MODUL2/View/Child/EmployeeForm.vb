Public Class EmployeeForm
    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PC_SB_MODUL2DataSet.View_Employee_Job' table. You can move, or remove it, as needed.
        Me.View_Employee_JobTableAdapter.Fill(Me.PC_SB_MODUL2DataSet.View_Employee_Job)

    End Sub
End Class
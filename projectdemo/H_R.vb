Public Class H_R
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        LogPage.Show()
        Me.Close()
    End Sub

    Private Sub Add_operator_Click(sender As Object, e As EventArgs) Handles Add_operator.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Emp_details_Click(sender As Object, e As EventArgs) Handles Emp_details.Click
        Me.Hide()
        emp_dtls.Show()
    End Sub

    Private Sub view_expense_Click(sender As Object, e As EventArgs) Handles view_expense.Click
        monthlyexpenses.Show()
        Me.Hide()
    End Sub
End Class
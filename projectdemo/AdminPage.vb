Public Class AdminPage
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
End Class
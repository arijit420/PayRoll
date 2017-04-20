Public Class Form2
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub LOGOUT_Click(sender As Object, e As EventArgs) Handles LOGOUT.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class
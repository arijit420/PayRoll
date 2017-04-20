Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click


    End Sub

    Private Sub ADDEMPLOYEE_Click(sender As Object, e As EventArgs) Handles ADDEMPLOYEE.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub LOAN_Click(sender As Object, e As EventArgs) Handles LOAN.Click
        Me.Hide()
        Form7.Show()

    End Sub

    Private Sub EDIT_Click(sender As Object, e As EventArgs) Handles EDIT.Click
        Me.Hide()
        Form5.Show()

    End Sub
End Class
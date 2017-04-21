Public Class Form5
    Private Sub REMOVEEMPLOYEE_Click(sender As Object, e As EventArgs) Handles REMOVEEMPLOYEE.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub BACK_Click(sender As Object, e As EventArgs) Handles BACK.Click
        GroupBox1.Visible = False
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        GroupBox1.Visible = False
        GroupBox2.Visible = False
    End Sub



    Private Sub BACK2_Click(sender As Object, e As EventArgs) Handles BACK2.Click
        GroupBox2.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GroupBox2.Visible = True
    End Sub

    Private Sub PREV_Click(sender As Object, e As EventArgs) Handles PREV.Click
        Me.Hide()
        Form1.Show()

    End Sub
End Class
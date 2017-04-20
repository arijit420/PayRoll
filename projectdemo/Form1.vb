Public Class Form1
    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Visible = False
    End Sub

    Private Sub ADDEMPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDEMPToolStripMenuItem.Click
        GroupBox1.Visible = True
    End Sub
End Class
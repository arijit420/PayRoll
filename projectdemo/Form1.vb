Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub NXT_Click(sender As Object, e As EventArgs) Handles NXT.Click
        '  SplitContainer.vi
    End Sub

    Private Sub ADDEmp_Click(sender As Object, e As EventArgs) Handles ADDEmp.Click
        Panelsky.Visible = True

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint
        Panelsky.Visible = False
        Panelgreen.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplitContainer1.Visible = False
    End Sub

    Private Sub Panelsky_Paint(sender As Object, e As PaintEventArgs) Handles Panelsky.Paint

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles update.Click

    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles backtoprev.Click
        Panelsky.Visible = False
        SplitContainer1.Panel2.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BACKK.Click
        SplitContainer1.Visible = False

    End Sub



    Private Sub backtoprev2_Click(sender As Object, e As EventArgs) Handles backtoprev2.Click
        Panelgreen.Visible = False
        SplitContainer1.Panel2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles deltemployee.Click
        Panelgreen.Visible = True
    End Sub
End Class
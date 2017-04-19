Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub NXT_Click(sender As Object, e As EventArgs) Handles NXT.Click
        ' SplitContainer.vi
    End Sub

    Private Sub ADDEmp_Click(sender As Object, e As EventArgs) Handles ADDEmp.Click
        Panelsky.Visible = True

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint
        Panelsky.Visible = False
    End Sub
End Class
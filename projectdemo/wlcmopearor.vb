Public Class wlcmopearor
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click


    End Sub

    Private Sub ADDEMPLOYEE_Click(sender As Object, e As EventArgs) Handles ADDEMPLOYEE.Click
        Me.Hide()
        emplye.Show()

    End Sub

    Private Sub LOAN_Click(sender As Object, e As EventArgs) Handles LOAN.Click
        Me.Hide()
        l_o_a_n_page.Show()

    End Sub

    Private Sub EDIT_Click(sender As Object, e As EventArgs) Handles EDIT.Click
        Me.Hide()
        edtemplye.Show()

    End Sub
End Class
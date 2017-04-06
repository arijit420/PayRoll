Public Class Form1
    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = False
        ComboBox1.Visible = False
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label1.Visible = True
        ComboBox1.Visible = True
    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        If (RadioButton1.Checked = True) Then
            If (TextBox1.Text = "admin" AndAlso TextBox2.Text = "1234") Then
                Me.Hide()
                Form2.Show()
            Else
                MsgBox("Please check your Userid & Password", vbCritical, "Login Error!")
            End If
        ElseIf (RadioButton2.checked = True) Then
        Else
            MsgBox("Please choose the user type!", vbInformation, "Login error")
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label1.Visible = False
        ComboBox1.Visible = False
    End Sub
End Class

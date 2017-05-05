Public Class LogPage
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
                H_R.Show()
            Else
                MsgBox("Please check your Userid & Password", vbCritical, "Login Error!")
            End If
        ElseIf (RadioButton2.Checked = True) Then
            If TextBox1.Text = "" Then
                MessageBox.Show("Please enter your Student User Name to login", "Payroll Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox1.Focus()
            ElseIf TextBox2.Text = "" Then
                MessageBox.Show("Please enter your Password to login", "Payroll Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox2.Focus()
            ElseIf ComboBox1.Text = "" Then
                MessageBox.Show("Please select your Branch to login", "Payroll Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim conLogin As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\DELL\Documents\vb_net.accdb")
                Dim commLogin As New OleDb.OleDbCommand("SELECT * FROM login_operator WHERE ID = @ID AND Password = @Password And Branch = @Branch", conLogin)
                Dim usernameParam As New OleDb.OleDbParameter("@ID", Me.TextBox1.Text)
                Dim passwordParam As New OleDb.OleDbParameter("@Password", Me.TextBox2.Text)
                Dim statusParam As New OleDb.OleDbParameter("@Branch", Me.ComboBox1.SelectedItem)

                commLogin.Parameters.Add(usernameParam)
                commLogin.Parameters.Add(passwordParam)
                commLogin.Parameters.Add(statusParam)
                commLogin.Connection.Open()
                Dim reader As OleDb.OleDbDataReader = commLogin.ExecuteReader()
                If reader.HasRows Then
                    wlcmopearor.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid  Data! Please enter correct  Data.", "Payroll Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TextBox1.Clear()
                    TextBox2.Clear()
                    ComboBox1.Text = ""
                    TextBox1.Focus()
                End If
                commLogin.Connection.Close()
            End If
        Else
            MsgBox("Please choose the user type!", vbInformation, "Login error")
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label1.Visible = False
        ComboBox1.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class

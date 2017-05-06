Imports System.Data.OleDb
Public Class l_o_a_n_page
    Dim provider As String
    Dim dataFile As String
    Dim connstring As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim con As New OleDbConnection
    Dim dt As New DataTable()
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        GroupBox1.Visible = False
        Dim s As String
        s = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\DELL\Documents\vb_net.accdb"
        con.ConnectionString = s

        con.Open()
        Dim odc As New OleDbDataAdapter(New OleDbCommand("SELECT * FROM emp", con))

        odc.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ComboBox1.Items.Add(dr(0))
        Next
        con.Close()
        odc.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        wlcmopearor.Show()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        For Each dr As DataRow In dt.Rows
            If dr(0) = ComboBox1.Text Then
                TextBox1.Text = dr(1)
                TextBox2.Text = dr(10)
            End If
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (TextBox4.Text = "") Then
            MsgBox("Please Enter an amount", vbInformation, "Loan Page")

        ElseIf (Val(TextBox4.Text) > 200000) Then
            MsgBox("Maximum Loan Amount is 2 lacks", vbInformation, "loan")
            TextBox4.Clear()
        ElseIf ((Val(TextBox4.Text) < 200000)) Then

            If (RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False And RadioButton4.Checked = False) Then
                MsgBox("Please select a Range", vbCritical, "Loan error")
            End If
            If (RadioButton1.Checked = True) Then
                TextBox6.Text = Val(TextBox5.Text) / 6
                TextBox5.Text = Val(TextBox4.Text) + (Val(TextBox4.Text) * (Val(TextBox3.Text) / 100))
            ElseIf (RadioButton2.Checked = True) Then
                TextBox6.Text = Val(TextBox5.Text) / 12
                TextBox5.Text = Val(TextBox4.Text) + (Val(TextBox4.Text) * (Val(TextBox3.Text) / 100))
            ElseIf (RadioButton3.Checked = True) Then
                TextBox6.Text = Val(TextBox5.Text) / 24
                TextBox5.Text = Val(TextBox4.Text) + (Val(TextBox4.Text) * (Val(TextBox3.Text) / 100))
            ElseIf (RadioButton4.Checked = True) Then
                TextBox6.Text = Val(TextBox5.Text) / 36
                TextBox5.Text = Val(TextBox4.Text) + (Val(TextBox4.Text) * (Val(TextBox3.Text) / 100))
            End If
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TextBox3.Text = "9.68"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TextBox3.Text = "10.68"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TextBox3.Text = "11.68"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        TextBox3.Text = "12.68"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\DELL\Documents\vb_net.accdb"
        connstring = provider & dataFile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim str As String
        str = "Insert into Loans([ID],[Name],[Salary],[Loan],[Time],[Permonthpay]) values(?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.Parameters.Add(New OleDbParameter("ID", CType(ComboBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Name", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Salary", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Loan", CType(TextBox5.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Time", CType(RadioButton1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Permonthpay", CType(TextBox6.Text, String)))
        MsgBox("Record added", vbInformation, "Load submit")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox2.Clear()
            TextBox4.Clear()
            TextBox6.Clear()
            TextBox5.Clear()
            ComboBox1.Text = ""
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox2.Clear()
        TextBox4.Clear()
        TextBox6.Clear()
        TextBox5.Clear()
        ComboBox1.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
    End Sub
End Class
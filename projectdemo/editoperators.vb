Imports System.Data.OleDb
Public Class editoperators
    Dim provider As String
    Dim dataFile As String
    Dim connstring As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim con As New OleDbConnection
    Dim dt As New DataTable()
    Private Sub editoperators_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        Me.WindowState = FormWindowState.Maximized
        Dim s As String
        s = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\DELL\Documents\vb_net.accdb"
        con.ConnectionString = s

        con.Open()
        Dim odc As New OleDbDataAdapter(New OleDbCommand("SELECT * FROM operator", con))

        odc.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ComboBox1.Items.Add(dr(0))
        Next
        con.Close()
        odc.Dispose()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        GroupBox1.Visible = True
        GroupBox2.Visible = False
    End Sub

    Private Sub extbutton_Click(sender As Object, e As EventArgs) Handles extbutton.Click
        GroupBox1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GroupBox2.Visible = True
        GroupBox1.Visible = False
    End Sub

    Private Sub extbttn_Click(sender As Object, e As EventArgs) Handles extbttn.Click
        GroupBox2.Visible = False
    End Sub

    Private Sub Buttonback_Click(sender As Object, e As EventArgs) Handles Buttonback.Click
        Me.Hide()
        H_R.Show()
    End Sub

    Private Sub btndlt_Click(sender As Object, e As EventArgs) Handles btndlt.Click
        Dim con As OleDbConnection
        Dim com As OleDbCommand
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\DELL\Documents\vb_net.accdb")
        com = New OleDbCommand("delete from operator where ID =@ID", con)
        con.Open()
        com.Parameters.AddWithValue("@ID", TextBox1.Text)
        com.ExecuteNonQuery()
        MsgBox("Record Deleted", vbInformation, "Delete successfull")
        TextBox1.Text = ""
        con.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        For Each dr As DataRow In dt.Rows
            If dr(0) = ComboBox1.Text Then
                TextBox2.Text = dr(1)
                TextBox10.Text = dr(7)
                TextBox6.Text = dr(5)
                TextBox5.Text = dr(4)
                TextBox7.Text = dr(6)
                TextBox4.Text = dr(3)
                TextBox3.Text = dr(2)
                TextBox9.Text = dr(8)
            End If
        Next
    End Sub

    Private Sub btnsve_Click(sender As Object, e As EventArgs) Handles btnsve.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\DELL\Documents\vb_net.accdb"
        connstring = provider & dataFile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim str As String
        str = "Update [operator] set [empname]='" & TextBox2.Text & "',[branch]='" & TextBox3.Text & "',[qualification]='" & TextBox4.Text & "',[gender]='" & TextBox5.Text & "',[address]='" & TextBox6.Text & "',[city]='" & TextBox7.Text & "',[phone]='" & TextBox10.Text & "',[email]='" & TextBox9.Text & "' where [ID]= " & ComboBox1.Text & ""
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        MsgBox("Record Updated", vbInformation, "Upadate Successfull")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            ComboBox1.Text = ""
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox4.Clear()
            TextBox10.Clear()
            TextBox7.Clear()
            TextBox9.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
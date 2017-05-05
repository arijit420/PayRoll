Imports System.Data.OleDb
Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class emplye
    Private Function emailcheck(ByVal emailaddress As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailaddress, pattern)
        If emailAddressMatch.Success Then
        Else
            MsgBox("invalid email")
            TextBox7.Text = ""
        End If
    End Function
    Dim provider As String
    Dim dataFile As String
    Dim connstring As String
    Dim myconnection As OleDbConnection = New OleDbConnection

    Private Sub LOGOUT_Click(sender As Object, e As EventArgs) Handles LOGOUT.Click
        Me.Hide()
        wlcmopearor.Show()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\DELL\Documents\vb_net.accdb"
        connstring = provider & dataFile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim str As String
        str = "Insert into emp([empname],[branch],[qualif],[desig],[gender],[city],[ph],[mail],[add],[Basic]) values(?,?,?,?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.Parameters.Add(New OleDbParameter("empname", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("branch", CType(ComboBox4.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("qualif", CType(ComboBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("desig", CType(ComboBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("gender", CType(ComboBox3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("city", CType(TextBox5.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("ph ", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("mail", CType(TextBox7.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("add", CType(TextBox4.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Basic", CType(TextBox3.Text, String)))
        MsgBox("Record added", vbInformation, "Employee Added")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox5.Clear()
            TextBox4.Clear()
            ComboBox4.Text = ""
            TextBox7.Clear()
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub TextBox7_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox7.Validating
        Dim Myemail As String = TextBox7.Text
        emailcheck(Myemail)

    End Sub

    Private Sub RESET_Click(sender As Object, e As EventArgs) Handles RESET.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox5.Clear()
        TextBox4.Clear()
        ComboBox4.Text = ""
        TextBox7.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
    End Sub
End Class
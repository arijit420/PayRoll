Imports System.Data.OleDb
Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class Form3
    Dim provider As String
    Dim dataFile As String
    Dim connstring As String
    Dim myconnection As OleDbConnection = New OleDbConnection

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        fdlg.Title = "Choose a Profile Photo"
        fdlg.InitialDirectory = "c:\"
        fdlg.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        'fdlg.FilterIndex = 2
        ' fdlg.
        fdlg.RestoreDirectory = True
        If fdlg.ShowDialog() = DialogResult.OK Then
            If fdlg.CheckFileExists = False Then
                MessageBox.Show("Sorry, The File You Specified Does Not Exist.")
            Else
                PictureBox1.ImageLocation = fdlg.FileName

            End If

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        H_R.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\DELL\Documents\vb_net.accdb"
        connstring = provider & dataFile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim str As String
        str = "Insert into operator([ID],[empname],[branch],[qualification],[gender],[address],[city],[phone],[email]) values(?,?,?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.Parameters.Add(New OleDbParameter("ID", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("empname", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("branch", CType(ComboBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("qualification", CType(ComboBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("gender", CType(ComboBox3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("address", CType(TextBox3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("city", CType(TextBox4.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("phone ", CType(TextBox6.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("email", CType(TextBox7.Text, String)))
        MsgBox("Record added", vbInformation, "Operator Added")
        Refresh()
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\DELL\Documents\vb_net.accdb"
        connstring = provider & dataFile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim str As String
        str = "Update [operator] set [empname]='" & TextBox2.Text & "',[branch]='" & ComboBox1.Text & "',[qualification]='" & ComboBox2.Text & "',[gender]='" & ComboBox3.Text & "',[address]='" & TextBox3.Text & "',[city]='" & TextBox4.Text & "',[phone]='" & TextBox6.Text & "',[email]='" & TextBox7.Text & "' where [ID]= " & TextBox1.Text & ""
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        MsgBox("Record Updated", vbInformation, "Upadate Successfull")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TextBox7_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox7.Validating
        Dim temp As String
        temp = TextBox7.Text
        Dim conditon As Boolean
        emailaddresscheck(temp)
        If emailaddresscheck(conditon) = False Then
            MsgBox("@ is not present in your email id!", vbInformation, "Incorrect Email Entry")
            TextBox7.Text = ""
        Else
            TextBox7.BackColor = Color.White
        End If

    End Sub


    Private Function emailaddresscheck(ByVal emailaddress As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailaddress, pattern)
        If emailAddressMatch.Success Then
            emailaddresscheck = True
        Else
            emailaddresscheck = False
        End If
    End Function

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        TextBox7.BackColor = Color.White
        Dim temp As String
        temp = TextBox7.Text
        Dim conditon As Boolean
        emailaddresscheck(temp)
        If emailaddresscheck(conditon) = True Then
            MessageBox.Show("Please enter your email address correctly", "Incorrect Email Entry")
            TextBox7.Text = ""

        Else
            TextBox7.BackColor = Color.White
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
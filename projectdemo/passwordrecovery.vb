Imports System.Data.OleDb
Public Class passwordrecovery
    Dim provider As String
    Dim dataFile As String
    Dim connstring As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim con As New OleDbConnection
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        provider = "provider = Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\DELL\Documents\vb_net.accdb"
        connstring = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "update [login_operator] Set [Password] = '" & TextBox2.Text & "', [Branch] = '" & ComboBox1.Text & "' Where [ID] = '" & TextBox1.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        MsgBox("Password  Updated", vbInformation, "Password Recovery")
        Try
            cmd.ExecuteNonQuery()
            cmd.dispose()
            myconnection.Close()
            ComboBox1.Text = ""
            TextBox1.Clear()
            TextBox2.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub passwordrecovery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LogPage.Show()
        Me.Hide()
    End Sub
End Class
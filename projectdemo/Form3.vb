Imports System.Data.OleDb

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
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\DELL\Documents\vb_net.accdb"
        connstring = provider & dataFile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim str As String
        str = "Insert into employee([ID],[empname],[branch],[qualification],[gender],[address],[city],[phone],[email]) values(?,?,?,?,?,?,?,?,?)"
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
        MsgBox("record added")
        Refresh()
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
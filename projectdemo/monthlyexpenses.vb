Imports System.Data.OleDb
Public Class monthlyexpenses
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Visible = True
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\DELL\Documents\vb_net.accdb"
        Dim MyConn As OleDbConnection
        Dim da As OleDbDataAdapter
        Dim ds As DataSet
        Dim tables As DataTableCollection
        Dim source1 As New BindingSource
        MyConn = New OleDbConnection
        MyConn.ConnectionString = connString
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select * from [pay] where Dates <='" & Format(DateTimePicker1.Value, "dd-mm-yyyy") & "'And dates>='" & Format(DateTimePicker2.Value, "dd-mm-yyyy") & "'", MyConn)
        da.Fill(ds, "pay")
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        DataGridView1.DataSource = view

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        DataGridView1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        H_R.Show()
    End Sub
End Class
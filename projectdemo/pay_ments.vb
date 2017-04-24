Imports System.Data.OleDb
Public Class pay_ments
    Dim connstring As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim con As New OleDbConnection
    Dim dt As New DataTable()
    Private Sub CLEAR_Click(sender As Object, e As EventArgs) Handles CLEAR.Click
        ComboBox1.Text = " "
        EmployeeName.Text = " "
        TextBox1.Text = " "
        WorkingDay.Text = " "
        OverTime.Text = " "
        OverTimeRate.Text = " "
        Salary.Text = " "
        LOANamt.Text = " "
        Basicamt.Text = " "
        DA.Text = " "
        HRA.Text = " "
        ESI.Text = " "
        PF.Text = " "
        MEDICAL.Text = " "
        LTA.Text = " "
        GROSS.Text = " "
        DeductSalary.Text = " "
        LOANAdj.Text = " "
        NETPAYMENT.Text = " "
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        DateTimePicker1.MinDate = DateTimePicker1.Value
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        For Each dr As DataRow In dt.Rows
            If dr(0) = ComboBox1.Text Then
                EmployeeName.Text = dr(1)
                MblNo.Text = dr(7)
                branh.Text = dr(2)
                TextBox1.Text = dr(4)
                Salary.Text = dr(10)
            End If
        Next
    End Sub

    Private Sub EmployeeName_TextChanged(sender As Object, e As EventArgs) Handles EmployeeName.TextChanged

    End Sub

    Private Sub SAVE_Click(sender As Object, e As EventArgs) Handles SAVE.Click

        Dim sqlquery As New OleDb.OleDbCommand
        con.ConnectionString = "provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\DELL\Documents\vb_net.accdb"
        sqlquery.Connection = con
        con.Open()
        sqlquery.CommandText = "INSERT INTO pay(ID, Branch,empname,designation,salary,loan,netpayment,Dates)VALUES(@ID, @Branch,@empname,@designation,@salary,@loan,@netpayment,@Dates)"
        sqlquery.Parameters.AddWithValue("@ID", ComboBox1.Text)
        sqlquery.Parameters.AddWithValue("@Branch", branh.Text)

        sqlquery.Parameters.AddWithValue("@empname", EmployeeName.Text)
        sqlquery.Parameters.AddWithValue("@designation", TextBox1.Text)
        sqlquery.Parameters.AddWithValue("@salary", Val(Salary.Text))
        sqlquery.Parameters.AddWithValue("@loan", Val(LOANamt.Text))
        sqlquery.Parameters.AddWithValue("@netpayment", Val(NETPAYMENT.Text))
        sqlquery.Parameters.AddWithValue("@Dates", (DateTimePicker1.Value).ToShortDateString)
        sqlquery.ExecuteReader()
        MsgBox("Data Saved", vbInformation, "payment successfull")
        con.Close()
        ComboBox1.Text = " "
        EmployeeName.Text = " "
        TextBox1.Text = " "
        WorkingDay.Text = " "
        OverTime.Text = " "
        OverTimeRate.Text = " "
        Salary.Text = " "
        LOANamt.Text = " "
        Basicamt.Text = " "
        DA.Text = " "
        HRA.Text = " "
        ESI.Text = " "
        branh.Text = ""
        PF.Text = " "
        MblNo.Text = ""
        MEDICAL.Text = " "
        LTA.Text = " "
        GROSS.Text = " "
        DeductSalary.Text = " "
        LOANAdj.Text = " "
        NETPAYMENT.Text = " "
    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Basicamt.Text = Val(Salary.Text) * (40 / 100)
        DA.Text = Val(Basicamt.Text) * (30 / 100)
        HRA.Text = Val(Basicamt.Text) * (15 / 100)
        ESI.Text = Val(Salary.Text) * (4.75 / 100)
        PF.Text = (Val(Basicamt.Text) + Val(DA.Text)) * (12 / 100)
        MEDICAL.Text = (Val(Salary.Text) + Val(Basicamt.Text) - Val(DA.Text) - Val(HRA.Text)) * (30 / 100)
        LTA.Text = (Val(Salary.Text) + Val(Basicamt.Text) - Val(DA.Text) - Val(HRA.Text)) * (35 / 100)
        GROSS.Text = Val(Basicamt.Text) + Val(DA.Text) + Val(HRA.Text) + Val(ESI.Text) + Val(PF.Text) + Val(MEDICAL.Text)
        If (Val(WorkingDay.Text < 26)) Then
            DeductSalary.Text = Val(Salary.Text) * (10 / 100)
        Else
            DeductSalary.Text = 0
        End If
        NETPAYMENT.Text = (Val(GROSS.Text) - Val(DeductSalary.Text) - Val(LOANAdj.Text))

    End Sub
    Public Sub AutoNumber_Check(TableName As String, connectionString As String)
        Dim connection As New OleDbConnection(connectionString)
        Dim query As String = "DBCC CHECKIDENT ('" & TableName & "',RESEED, 0)"
        Dim command As New OleDbCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub
End Class
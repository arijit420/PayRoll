Imports System.Data.OleDb
Public Class Form4
    Dim provider As String
    Dim dataFile As String
    Dim connstring As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim dt As New DataTable()

    Private Sub ADD_Click(sender As Object, e As EventArgs) Handles ADD.Click
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

    Private Sub CLEAR_Click(sender As Object, e As EventArgs) Handles CLEAR.Click
        ComboBox1.Text =
        EmployeeName.Text = " "
        ComboBox2.Text = " "
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

    Private Sub EXITT_Click(sender As Object, e As EventArgs) Handles EXITT.Click
        End
    End Sub

    Private Sub GROSS_TextChanged(sender As Object, e As EventArgs) Handles GROSS.TextChanged

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        DateTimePicker1.MinDate = DateTimePicker1.Value
        Dim s As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\DELL\Documents\vb_net.accdb"
        Dim con As New OleDbConnection(s)
        con.Open()
        Dim odc As New OleDbDataAdapter(New OleDbCommand("SELECT * FROM employee", con))

        odc.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ComboBox1.Items.Add(dr(0))
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        For Each dr As DataRow In dt.Rows
            If dr(0) = ComboBox1.Text Then
                EmployeeName.Text = dr(1)
                MblNo.Text = dr(7)
                branh.Text = dr(2)
            End If
        Next
    End Sub

    Private Sub EmployeeName_TextChanged(sender As Object, e As EventArgs) Handles EmployeeName.TextChanged

    End Sub

    Private Sub SAVE_Click(sender As Object, e As EventArgs) Handles SAVE.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\DELL\Documents\vb_net.accdb"
        connstring = provider & dataFile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim str As String
        str = "Insert into transaction([ID],[Branch],[empname],[designation],[salary],[loan],[netpayment]) values(?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.Parameters.Add(New OleDbParameter("ID", CType(ComboBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Branch", CType(branh.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("empname", CType(EmployeeName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("designation", CType(ComboBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("salary", CType(Salary.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("loan", CType(LOANamt.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("netpayment", CType(NETPAYMENT.Text, String)))
        MsgBox("record added")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
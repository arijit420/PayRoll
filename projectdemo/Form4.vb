Public Class Form4
    Dim d As Integer

    Private Sub ADD_Click(sender As Object, e As EventArgs) Handles ADD.Click
        Basicamt.Text = Val(Salary.Text) * (40 / 100)
        DA.Text = Val(Basicamt.Text) * (30 / 100)
        HRA.Text = Val(Basicamt.Text) * (15 / 100)
        ESI.Text = Val(Salary.Text) * (4.75 / 100)
        PF.Text = (Val(Basicamt.Text) + Val(DA.Text)) * (12 / 100)
        MEDICAL.Text = (Val(Salary.Text) + Val(Basicamt.Text) - Val(DA.Text) - Val(HRA.Text)) * (30 / 100)
        LTA.Text = (Val(Salary.Text) + Val(Basicamt.Text) - Val(DA.Text) - Val(HRA.Text)) * (35 / 100)
        GROSS.Text = Val(Basicamt.Text) + Val(DA.Text) + Val(HRA.Text) + Val(ESI.Text) + Val(PF.Text) + Val(MEDICAL.Text)
        DeductSalary.Text = If(d < 26) Then
                              DeductSalary.Text = Val(Salary.Text) * (10 / 100)
        NETPAYMENT.Text = (Val(GROSS.Text) + Val(DeductSalary.Text) + Val(LOANAdj.Text))


    End Sub

    Private Sub CLEAR_Click(sender As Object, e As EventArgs) Handles CLEAR.Click
        EmployeeID.Text = " "
        EmployeeName.Text = " "
        Designation.Text = " "
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
End Class
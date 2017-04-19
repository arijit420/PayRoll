<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class H_R
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(H_R))
        Me.Add_operator = New System.Windows.Forms.Label()
        Me.Emp_details = New System.Windows.Forms.Label()
        Me.view_expense = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.reset = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Add_operator
        '
        Me.Add_operator.AutoSize = True
        Me.Add_operator.BackColor = System.Drawing.Color.Transparent
        Me.Add_operator.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Add_operator.Font = New System.Drawing.Font("Lucida Sans Typewriter", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_operator.ForeColor = System.Drawing.Color.Coral
        Me.Add_operator.Location = New System.Drawing.Point(529, 442)
        Me.Add_operator.Name = "Add_operator"
        Me.Add_operator.Size = New System.Drawing.Size(142, 22)
        Me.Add_operator.TabIndex = 1
        Me.Add_operator.Text = "Add Operator"
        '
        'Emp_details
        '
        Me.Emp_details.AutoSize = True
        Me.Emp_details.BackColor = System.Drawing.Color.Transparent
        Me.Emp_details.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Emp_details.Font = New System.Drawing.Font("Lucida Sans Typewriter", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_details.ForeColor = System.Drawing.Color.Brown
        Me.Emp_details.Location = New System.Drawing.Point(907, 314)
        Me.Emp_details.Name = "Emp_details"
        Me.Emp_details.Size = New System.Drawing.Size(186, 22)
        Me.Emp_details.TabIndex = 3
        Me.Emp_details.Text = "Employee Details"
        '
        'view_expense
        '
        Me.view_expense.AutoSize = True
        Me.view_expense.BackColor = System.Drawing.Color.Transparent
        Me.view_expense.Cursor = System.Windows.Forms.Cursors.Hand
        Me.view_expense.Font = New System.Drawing.Font("Lucida Sans Typewriter", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.view_expense.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.view_expense.Location = New System.Drawing.Point(199, 373)
        Me.view_expense.Name = "view_expense"
        Me.view_expense.Size = New System.Drawing.Size(142, 22)
        Me.view_expense.TabIndex = 5
        Me.view_expense.Text = "View Expense"
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(-23, -46)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'reset
        '
        Me.reset.AutoSize = True
        Me.reset.BackColor = System.Drawing.Color.Transparent
        Me.reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.reset.Font = New System.Drawing.Font("Lucida Sans Typewriter", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset.ForeColor = System.Drawing.Color.DarkCyan
        Me.reset.Location = New System.Drawing.Point(599, 217)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(164, 22)
        Me.reset.TabIndex = 8
        Me.reset.Text = "Reset Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(1204, 481)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 22)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Logout"
        '
        'H_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1223, 733)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.view_expense)
        Me.Controls.Add(Me.Emp_details)
        Me.Controls.Add(Me.Add_operator)
        Me.Name = "H_R"
        Me.Text = "Welcome HR"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Add_operator As Label
    Friend WithEvents Emp_details As Label
    Friend WithEvents view_expense As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents reset As Label
    Friend WithEvents Label1 As Label
End Class

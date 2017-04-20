<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ADDEMPLOYEE = New System.Windows.Forms.Label()
        Me.EDIT = New System.Windows.Forms.Label()
        Me.LOAN = New System.Windows.Forms.Label()
        Me.PAYMENT = New System.Windows.Forms.Label()
        Me.LOGOUT = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(242, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "System Managment"
        '
        'ADDEMPLOYEE
        '
        Me.ADDEMPLOYEE.AutoSize = True
        Me.ADDEMPLOYEE.BackColor = System.Drawing.Color.RosyBrown
        Me.ADDEMPLOYEE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADDEMPLOYEE.Location = New System.Drawing.Point(124, 132)
        Me.ADDEMPLOYEE.Name = "ADDEMPLOYEE"
        Me.ADDEMPLOYEE.Size = New System.Drawing.Size(113, 16)
        Me.ADDEMPLOYEE.TabIndex = 1
        Me.ADDEMPLOYEE.Text = "ADD EMPLOYEE"
        '
        'EDIT
        '
        Me.EDIT.AutoSize = True
        Me.EDIT.BackColor = System.Drawing.Color.RosyBrown
        Me.EDIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EDIT.Location = New System.Drawing.Point(142, 177)
        Me.EDIT.Name = "EDIT"
        Me.EDIT.Size = New System.Drawing.Size(39, 16)
        Me.EDIT.TabIndex = 2
        Me.EDIT.Text = "EDIT"
        '
        'LOAN
        '
        Me.LOAN.AutoSize = True
        Me.LOAN.BackColor = System.Drawing.Color.RosyBrown
        Me.LOAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOAN.Location = New System.Drawing.Point(167, 226)
        Me.LOAN.Name = "LOAN"
        Me.LOAN.Size = New System.Drawing.Size(44, 16)
        Me.LOAN.TabIndex = 3
        Me.LOAN.Text = "LOAN"
        '
        'PAYMENT
        '
        Me.PAYMENT.AutoSize = True
        Me.PAYMENT.BackColor = System.Drawing.Color.RosyBrown
        Me.PAYMENT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PAYMENT.Location = New System.Drawing.Point(423, 342)
        Me.PAYMENT.Name = "PAYMENT"
        Me.PAYMENT.Size = New System.Drawing.Size(74, 16)
        Me.PAYMENT.TabIndex = 4
        Me.PAYMENT.Text = "PAYMENT"
        '
        'LOGOUT
        '
        Me.LOGOUT.AutoSize = True
        Me.LOGOUT.BackColor = System.Drawing.Color.Gray
        Me.LOGOUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOGOUT.Location = New System.Drawing.Point(652, 404)
        Me.LOGOUT.Name = "LOGOUT"
        Me.LOGOUT.Size = New System.Drawing.Size(74, 16)
        Me.LOGOUT.TabIndex = 5
        Me.LOGOUT.Text = "LOG OUT"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(731, 429)
        Me.Controls.Add(Me.LOGOUT)
        Me.Controls.Add(Me.PAYMENT)
        Me.Controls.Add(Me.LOAN)
        Me.Controls.Add(Me.EDIT)
        Me.Controls.Add(Me.ADDEMPLOYEE)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ADDEMPLOYEE As Label
    Friend WithEvents EDIT As Label
    Friend WithEvents LOAN As Label
    Friend WithEvents PAYMENT As Label
    Friend WithEvents LOGOUT As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wlcmopearor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wlcmopearor))
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
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(522, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Operator Window"
        '
        'ADDEMPLOYEE
        '
        Me.ADDEMPLOYEE.AutoSize = True
        Me.ADDEMPLOYEE.BackColor = System.Drawing.Color.Transparent
        Me.ADDEMPLOYEE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADDEMPLOYEE.Location = New System.Drawing.Point(125, 118)
        Me.ADDEMPLOYEE.Name = "ADDEMPLOYEE"
        Me.ADDEMPLOYEE.Size = New System.Drawing.Size(111, 17)
        Me.ADDEMPLOYEE.TabIndex = 1
        Me.ADDEMPLOYEE.Text = "Add Employee"
        '
        'EDIT
        '
        Me.EDIT.AutoSize = True
        Me.EDIT.BackColor = System.Drawing.Color.Transparent
        Me.EDIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EDIT.Location = New System.Drawing.Point(338, 118)
        Me.EDIT.Name = "EDIT"
        Me.EDIT.Size = New System.Drawing.Size(111, 17)
        Me.EDIT.TabIndex = 2
        Me.EDIT.Text = "Edit Employee"
        '
        'LOAN
        '
        Me.LOAN.AutoSize = True
        Me.LOAN.BackColor = System.Drawing.Color.Transparent
        Me.LOAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOAN.Location = New System.Drawing.Point(792, 118)
        Me.LOAN.Name = "LOAN"
        Me.LOAN.Size = New System.Drawing.Size(44, 17)
        Me.LOAN.TabIndex = 3
        Me.LOAN.Text = "Loan"
        '
        'PAYMENT
        '
        Me.PAYMENT.AutoSize = True
        Me.PAYMENT.BackColor = System.Drawing.Color.Transparent
        Me.PAYMENT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PAYMENT.Location = New System.Drawing.Point(957, 118)
        Me.PAYMENT.Name = "PAYMENT"
        Me.PAYMENT.Size = New System.Drawing.Size(70, 17)
        Me.PAYMENT.TabIndex = 4
        Me.PAYMENT.Text = "Payment"
        '
        'LOGOUT
        '
        Me.LOGOUT.AutoSize = True
        Me.LOGOUT.BackColor = System.Drawing.Color.Transparent
        Me.LOGOUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOGOUT.Location = New System.Drawing.Point(1157, 23)
        Me.LOGOUT.Name = "LOGOUT"
        Me.LOGOUT.Size = New System.Drawing.Size(62, 13)
        Me.LOGOUT.TabIndex = 5
        Me.LOGOUT.Text = "LOG OUT"
        '
        'wlcmopearor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1177, 429)
        Me.Controls.Add(Me.LOGOUT)
        Me.Controls.Add(Me.PAYMENT)
        Me.Controls.Add(Me.LOAN)
        Me.Controls.Add(Me.EDIT)
        Me.Controls.Add(Me.ADDEMPLOYEE)
        Me.Controls.Add(Me.Label1)
        Me.Name = "wlcmopearor"
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

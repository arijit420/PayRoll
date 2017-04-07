<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ADDEmployee = New System.Windows.Forms.Button()
        Me.EDITEmployee = New System.Windows.Forms.Button()
        Me.DELETEEmployee = New System.Windows.Forms.Button()
        Me.LOAN = New System.Windows.Forms.Button()
        Me.TRANSACTION = New System.Windows.Forms.Button()
        Me.operatorr = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(226, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'ADDEmployee
        '
        Me.ADDEmployee.Location = New System.Drawing.Point(24, 140)
        Me.ADDEmployee.Name = "ADDEmployee"
        Me.ADDEmployee.Size = New System.Drawing.Size(146, 23)
        Me.ADDEmployee.TabIndex = 1
        Me.ADDEmployee.Text = "ADD Employee"
        Me.ADDEmployee.UseVisualStyleBackColor = True
        '
        'EDITEmployee
        '
        Me.EDITEmployee.Location = New System.Drawing.Point(24, 201)
        Me.EDITEmployee.Name = "EDITEmployee"
        Me.EDITEmployee.Size = New System.Drawing.Size(146, 23)
        Me.EDITEmployee.TabIndex = 2
        Me.EDITEmployee.Text = "EDIT Employee"
        Me.EDITEmployee.UseVisualStyleBackColor = True
        '
        'DELETEEmployee
        '
        Me.DELETEEmployee.Location = New System.Drawing.Point(24, 266)
        Me.DELETEEmployee.Name = "DELETEEmployee"
        Me.DELETEEmployee.Size = New System.Drawing.Size(146, 23)
        Me.DELETEEmployee.TabIndex = 3
        Me.DELETEEmployee.Text = "DELETE Employee"
        Me.DELETEEmployee.UseVisualStyleBackColor = True
        '
        'LOAN
        '
        Me.LOAN.Location = New System.Drawing.Point(24, 328)
        Me.LOAN.Name = "LOAN"
        Me.LOAN.Size = New System.Drawing.Size(146, 23)
        Me.LOAN.TabIndex = 4
        Me.LOAN.Text = "LOAN"
        Me.LOAN.UseVisualStyleBackColor = True
        '
        'TRANSACTION
        '
        Me.TRANSACTION.Location = New System.Drawing.Point(24, 390)
        Me.TRANSACTION.Name = "TRANSACTION"
        Me.TRANSACTION.Size = New System.Drawing.Size(146, 23)
        Me.TRANSACTION.TabIndex = 5
        Me.TRANSACTION.Text = "TRANSACTION"
        Me.TRANSACTION.UseVisualStyleBackColor = True
        '
        'operatorr
        '
        Me.operatorr.AutoSize = True
        Me.operatorr.Font = New System.Drawing.Font("Lucida Sans Typewriter", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.operatorr.Location = New System.Drawing.Point(209, 23)
        Me.operatorr.Name = "operatorr"
        Me.operatorr.Size = New System.Drawing.Size(392, 42)
        Me.operatorr.TabIndex = 6
        Me.operatorr.Text = " WELCOME OPERATOR"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 524)
        Me.Controls.Add(Me.operatorr)
        Me.Controls.Add(Me.TRANSACTION)
        Me.Controls.Add(Me.LOAN)
        Me.Controls.Add(Me.DELETEEmployee)
        Me.Controls.Add(Me.EDITEmployee)
        Me.Controls.Add(Me.ADDEmployee)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ADDEmployee As Button
    Friend WithEvents EDITEmployee As Button
    Friend WithEvents DELETEEmployee As Button
    Friend WithEvents LOAN As Button
    Friend WithEvents TRANSACTION As Button
    Friend WithEvents operatorr As Label
End Class

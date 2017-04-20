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
        Me.REMOVEEMPLOYEE = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DELETE = New System.Windows.Forms.Button()
        Me.BACK = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'REMOVEEMPLOYEE
        '
        Me.REMOVEEMPLOYEE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REMOVEEMPLOYEE.Location = New System.Drawing.Point(78, 79)
        Me.REMOVEEMPLOYEE.Name = "REMOVEEMPLOYEE"
        Me.REMOVEEMPLOYEE.Size = New System.Drawing.Size(114, 44)
        Me.REMOVEEMPLOYEE.TabIndex = 0
        Me.REMOVEEMPLOYEE.Text = "REMOVE EMPLOYEE"
        Me.REMOVEEMPLOYEE.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(78, 187)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 44)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "UPDATE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BACK)
        Me.GroupBox1.Controls.Add(Me.DELETE)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(269, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 301)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(121, 106)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 46)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee ID"
        '
        'DELETE
        '
        Me.DELETE.Location = New System.Drawing.Point(135, 187)
        Me.DELETE.Name = "DELETE"
        Me.DELETE.Size = New System.Drawing.Size(109, 33)
        Me.DELETE.TabIndex = 2
        Me.DELETE.Text = "DELETE"
        Me.DELETE.UseVisualStyleBackColor = True
        '
        'BACK
        '
        Me.BACK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BACK.Location = New System.Drawing.Point(290, 272)
        Me.BACK.Name = "BACK"
        Me.BACK.Size = New System.Drawing.Size(75, 23)
        Me.BACK.TabIndex = 3
        Me.BACK.Text = "BACK"
        Me.BACK.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 462)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.REMOVEEMPLOYEE)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents REMOVEEMPLOYEE As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BACK As Button
    Friend WithEvents DELETE As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
End Class

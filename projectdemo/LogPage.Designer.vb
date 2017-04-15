<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogPage))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.login = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("High Tower Text", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(119, 444)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("High Tower Text", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(120, 506)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 34)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(282, 446)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(201, 30)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.AcceptsReturn = True
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(280, 499)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(201, 49)
        Me.TextBox2.TabIndex = 4
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(282, 318)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(118, 35)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Admin"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(406, 318)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(141, 35)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Operator"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("High Tower Text", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(120, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 34)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "User Type"
        '
        'login
        '
        Me.login.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login.Location = New System.Drawing.Point(187, 557)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(75, 23)
        Me.login.TabIndex = 8
        Me.login.Text = "Login"
        Me.login.UseVisualStyleBackColor = True
        '
        'reset
        '
        Me.reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset.Location = New System.Drawing.Point(381, 557)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(75, 23)
        Me.reset.TabIndex = 9
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(119, 386)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 34)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Select Branch"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Kolkata", "Mumbai", "Delhi ", "Hyderabad"})
        Me.ComboBox1.Location = New System.Drawing.Point(315, 392)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(153, 21)
        Me.ComboBox1.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(940, 579)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Welcome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents login As Button
    Friend WithEvents reset As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class

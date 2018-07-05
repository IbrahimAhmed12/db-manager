<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Me.LBLlogin = New System.Windows.Forms.Label()
        Me.LBLUsername = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBLPassword = New System.Windows.Forms.Label()
        Me.TXTUsername = New System.Windows.Forms.TextBox()
        Me.TXTPassword = New System.Windows.Forms.TextBox()
        Me.Loginbtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LBLlogin
        '
        Me.LBLlogin.AutoSize = True
        Me.LBLlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLlogin.Location = New System.Drawing.Point(78, 28)
        Me.LBLlogin.Name = "LBLlogin"
        Me.LBLlogin.Size = New System.Drawing.Size(115, 42)
        Me.LBLlogin.TabIndex = 0
        Me.LBLlogin.Text = "Login"
        '
        'LBLUsername
        '
        Me.LBLUsername.AutoSize = True
        Me.LBLUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLUsername.Location = New System.Drawing.Point(44, 115)
        Me.LBLUsername.Name = "LBLUsername"
        Me.LBLUsername.Size = New System.Drawing.Size(83, 16)
        Me.LBLUsername.TabIndex = 1
        Me.LBLUsername.Text = "Username:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 2
        '
        'LBLPassword
        '
        Me.LBLPassword.AutoSize = True
        Me.LBLPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPassword.Location = New System.Drawing.Point(44, 174)
        Me.LBLPassword.Name = "LBLPassword"
        Me.LBLPassword.Size = New System.Drawing.Size(80, 16)
        Me.LBLPassword.TabIndex = 3
        Me.LBLPassword.Text = "Password:"
        '
        'TXTUsername
        '
        Me.TXTUsername.Location = New System.Drawing.Point(134, 110)
        Me.TXTUsername.Name = "TXTUsername"
        Me.TXTUsername.Size = New System.Drawing.Size(100, 20)
        Me.TXTUsername.TabIndex = 4
        '
        'TXTPassword
        '
        Me.TXTPassword.Location = New System.Drawing.Point(134, 169)
        Me.TXTPassword.Name = "TXTPassword"
        Me.TXTPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTPassword.Size = New System.Drawing.Size(100, 20)
        Me.TXTPassword.TabIndex = 5
        '
        'Loginbtn
        '
        Me.Loginbtn.Location = New System.Drawing.Point(95, 207)
        Me.Loginbtn.Name = "Loginbtn"
        Me.Loginbtn.Size = New System.Drawing.Size(89, 43)
        Me.Loginbtn.TabIndex = 6
        Me.Loginbtn.Text = "Go"
        Me.Loginbtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Loginbtn)
        Me.Controls.Add(Me.TXTPassword)
        Me.Controls.Add(Me.TXTUsername)
        Me.Controls.Add(Me.LBLPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBLUsername)
        Me.Controls.Add(Me.LBLlogin)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLlogin As Label
    Friend WithEvents LBLUsername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LBLPassword As Label
    Friend WithEvents TXTUsername As TextBox
    Friend WithEvents TXTPassword As TextBox
    Friend WithEvents Loginbtn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class

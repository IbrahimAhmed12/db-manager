<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.LBLDescription = New System.Windows.Forms.Label()
        Me.LBLCarCapacity = New System.Windows.Forms.Label()
        Me.LBLUserName = New System.Windows.Forms.Label()
        Me.LBLPassword = New System.Windows.Forms.Label()
        Me.LBLConfirmPassword = New System.Windows.Forms.Label()
        Me.TXTCarCapacity = New System.Windows.Forms.TextBox()
        Me.TXTUsername = New System.Windows.Forms.TextBox()
        Me.TXTPassword = New System.Windows.Forms.TextBox()
        Me.TXTConfirmPass = New System.Windows.Forms.TextBox()
        Me.BTNBack = New System.Windows.Forms.Button()
        Me.BTNSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBLDescription
        '
        Me.LBLDescription.AutoSize = True
        Me.LBLDescription.Location = New System.Drawing.Point(12, 9)
        Me.LBLDescription.Name = "LBLDescription"
        Me.LBLDescription.Size = New System.Drawing.Size(243, 26)
        Me.LBLDescription.TabIndex = 0
        Me.LBLDescription.Text = "To change your details enter your new ones in the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "textboxes below"
        '
        'LBLCarCapacity
        '
        Me.LBLCarCapacity.AutoSize = True
        Me.LBLCarCapacity.Location = New System.Drawing.Point(13, 64)
        Me.LBLCarCapacity.Name = "LBLCarCapacity"
        Me.LBLCarCapacity.Size = New System.Drawing.Size(67, 13)
        Me.LBLCarCapacity.TabIndex = 1
        Me.LBLCarCapacity.Text = "CarCapacity:"
        '
        'LBLUserName
        '
        Me.LBLUserName.AutoSize = True
        Me.LBLUserName.Location = New System.Drawing.Point(13, 95)
        Me.LBLUserName.Name = "LBLUserName"
        Me.LBLUserName.Size = New System.Drawing.Size(58, 13)
        Me.LBLUserName.TabIndex = 2
        Me.LBLUserName.Text = "Username:"
        '
        'LBLPassword
        '
        Me.LBLPassword.AutoSize = True
        Me.LBLPassword.Location = New System.Drawing.Point(13, 123)
        Me.LBLPassword.Name = "LBLPassword"
        Me.LBLPassword.Size = New System.Drawing.Size(56, 13)
        Me.LBLPassword.TabIndex = 3
        Me.LBLPassword.Text = "Password:"
        '
        'LBLConfirmPassword
        '
        Me.LBLConfirmPassword.AutoSize = True
        Me.LBLConfirmPassword.Location = New System.Drawing.Point(13, 152)
        Me.LBLConfirmPassword.Name = "LBLConfirmPassword"
        Me.LBLConfirmPassword.Size = New System.Drawing.Size(94, 13)
        Me.LBLConfirmPassword.TabIndex = 4
        Me.LBLConfirmPassword.Text = "Confirm Password:"
        '
        'TXTCarCapacity
        '
        Me.TXTCarCapacity.Location = New System.Drawing.Point(86, 61)
        Me.TXTCarCapacity.Name = "TXTCarCapacity"
        Me.TXTCarCapacity.Size = New System.Drawing.Size(100, 20)
        Me.TXTCarCapacity.TabIndex = 5
        '
        'TXTUsername
        '
        Me.TXTUsername.Location = New System.Drawing.Point(75, 92)
        Me.TXTUsername.Name = "TXTUsername"
        Me.TXTUsername.Size = New System.Drawing.Size(100, 20)
        Me.TXTUsername.TabIndex = 6
        '
        'TXTPassword
        '
        Me.TXTPassword.Location = New System.Drawing.Point(75, 120)
        Me.TXTPassword.Name = "TXTPassword"
        Me.TXTPassword.Size = New System.Drawing.Size(100, 20)
        Me.TXTPassword.TabIndex = 7
        '
        'TXTConfirmPass
        '
        Me.TXTConfirmPass.Location = New System.Drawing.Point(113, 149)
        Me.TXTConfirmPass.Name = "TXTConfirmPass"
        Me.TXTConfirmPass.Size = New System.Drawing.Size(100, 20)
        Me.TXTConfirmPass.TabIndex = 8
        '
        'BTNBack
        '
        Me.BTNBack.Location = New System.Drawing.Point(44, 213)
        Me.BTNBack.Name = "BTNBack"
        Me.BTNBack.Size = New System.Drawing.Size(75, 23)
        Me.BTNBack.TabIndex = 9
        Me.BTNBack.Text = "Back"
        Me.BTNBack.UseVisualStyleBackColor = True
        '
        'BTNSave
        '
        Me.BTNSave.Location = New System.Drawing.Point(171, 213)
        Me.BTNSave.Name = "BTNSave"
        Me.BTNSave.Size = New System.Drawing.Size(75, 23)
        Me.BTNSave.TabIndex = 10
        Me.BTNSave.Text = "Save"
        Me.BTNSave.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 261)
        Me.Controls.Add(Me.BTNSave)
        Me.Controls.Add(Me.BTNBack)
        Me.Controls.Add(Me.TXTConfirmPass)
        Me.Controls.Add(Me.TXTPassword)
        Me.Controls.Add(Me.TXTUsername)
        Me.Controls.Add(Me.TXTCarCapacity)
        Me.Controls.Add(Me.LBLConfirmPassword)
        Me.Controls.Add(Me.LBLPassword)
        Me.Controls.Add(Me.LBLUserName)
        Me.Controls.Add(Me.LBLCarCapacity)
        Me.Controls.Add(Me.LBLDescription)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLDescription As Label
    Friend WithEvents LBLCarCapacity As Label
    Friend WithEvents LBLUserName As Label
    Friend WithEvents LBLPassword As Label
    Friend WithEvents LBLConfirmPassword As Label
    Friend WithEvents TXTCarCapacity As TextBox
    Friend WithEvents TXTUsername As TextBox
    Friend WithEvents TXTPassword As TextBox
    Friend WithEvents TXTConfirmPass As TextBox
    Friend WithEvents BTNBack As Button
    Friend WithEvents BTNSave As Button
End Class

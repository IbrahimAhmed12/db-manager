<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddShop
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
        Me.LBLName = New System.Windows.Forms.Label()
        Me.LBLAddress = New System.Windows.Forms.Label()
        Me.LBLPostCode = New System.Windows.Forms.Label()
        Me.LBLEmail = New System.Windows.Forms.Label()
        Me.LBLPhone = New System.Windows.Forms.Label()
        Me.TXTName = New System.Windows.Forms.TextBox()
        Me.TXTAddress = New System.Windows.Forms.TextBox()
        Me.TXTPostCode = New System.Windows.Forms.TextBox()
        Me.TXTEmail = New System.Windows.Forms.TextBox()
        Me.TXTPhone = New System.Windows.Forms.TextBox()
        Me.BTNDescription = New System.Windows.Forms.Button()
        Me.BTNSave = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBLName
        '
        Me.LBLName.AutoSize = True
        Me.LBLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLName.Location = New System.Drawing.Point(20, 31)
        Me.LBLName.Name = "LBLName"
        Me.LBLName.Size = New System.Drawing.Size(55, 20)
        Me.LBLName.TabIndex = 0
        Me.LBLName.Text = "Name:"
        '
        'LBLAddress
        '
        Me.LBLAddress.AutoSize = True
        Me.LBLAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLAddress.Location = New System.Drawing.Point(20, 57)
        Me.LBLAddress.Name = "LBLAddress"
        Me.LBLAddress.Size = New System.Drawing.Size(72, 20)
        Me.LBLAddress.TabIndex = 1
        Me.LBLAddress.Text = "Address:"
        '
        'LBLPostCode
        '
        Me.LBLPostCode.AutoSize = True
        Me.LBLPostCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPostCode.Location = New System.Drawing.Point(20, 83)
        Me.LBLPostCode.Name = "LBLPostCode"
        Me.LBLPostCode.Size = New System.Drawing.Size(83, 20)
        Me.LBLPostCode.TabIndex = 2
        Me.LBLPostCode.Text = "PostCode:"
        '
        'LBLEmail
        '
        Me.LBLEmail.AutoSize = True
        Me.LBLEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLEmail.Location = New System.Drawing.Point(20, 112)
        Me.LBLEmail.Name = "LBLEmail"
        Me.LBLEmail.Size = New System.Drawing.Size(52, 20)
        Me.LBLEmail.TabIndex = 3
        Me.LBLEmail.Text = "Email:"
        '
        'LBLPhone
        '
        Me.LBLPhone.AutoSize = True
        Me.LBLPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPhone.Location = New System.Drawing.Point(20, 138)
        Me.LBLPhone.Name = "LBLPhone"
        Me.LBLPhone.Size = New System.Drawing.Size(113, 20)
        Me.LBLPhone.TabIndex = 4
        Me.LBLPhone.Text = "Phonenumber:"
        '
        'TXTName
        '
        Me.TXTName.Location = New System.Drawing.Point(81, 31)
        Me.TXTName.Name = "TXTName"
        Me.TXTName.Size = New System.Drawing.Size(100, 20)
        Me.TXTName.TabIndex = 5
        '
        'TXTAddress
        '
        Me.TXTAddress.Location = New System.Drawing.Point(98, 57)
        Me.TXTAddress.Name = "TXTAddress"
        Me.TXTAddress.Size = New System.Drawing.Size(100, 20)
        Me.TXTAddress.TabIndex = 6
        '
        'TXTPostCode
        '
        Me.TXTPostCode.Location = New System.Drawing.Point(105, 83)
        Me.TXTPostCode.Name = "TXTPostCode"
        Me.TXTPostCode.Size = New System.Drawing.Size(100, 20)
        Me.TXTPostCode.TabIndex = 7
        '
        'TXTEmail
        '
        Me.TXTEmail.Location = New System.Drawing.Point(82, 112)
        Me.TXTEmail.Name = "TXTEmail"
        Me.TXTEmail.Size = New System.Drawing.Size(100, 20)
        Me.TXTEmail.TabIndex = 8
        '
        'TXTPhone
        '
        Me.TXTPhone.Location = New System.Drawing.Point(139, 138)
        Me.TXTPhone.Name = "TXTPhone"
        Me.TXTPhone.Size = New System.Drawing.Size(100, 20)
        Me.TXTPhone.TabIndex = 9
        '
        'BTNDescription
        '
        Me.BTNDescription.Location = New System.Drawing.Point(221, 30)
        Me.BTNDescription.Name = "BTNDescription"
        Me.BTNDescription.Size = New System.Drawing.Size(18, 21)
        Me.BTNDescription.TabIndex = 10
        Me.BTNDescription.Text = "?"
        Me.BTNDescription.UseVisualStyleBackColor = True
        '
        'BTNSave
        '
        Me.BTNSave.Location = New System.Drawing.Point(150, 174)
        Me.BTNSave.Name = "BTNSave"
        Me.BTNSave.Size = New System.Drawing.Size(66, 27)
        Me.BTNSave.TabIndex = 11
        Me.BTNSave.Text = "Save"
        Me.BTNSave.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(78, 174)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(66, 27)
        Me.Back.TabIndex = 12
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'AddShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 213)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.BTNSave)
        Me.Controls.Add(Me.BTNDescription)
        Me.Controls.Add(Me.TXTPhone)
        Me.Controls.Add(Me.TXTEmail)
        Me.Controls.Add(Me.TXTPostCode)
        Me.Controls.Add(Me.TXTAddress)
        Me.Controls.Add(Me.TXTName)
        Me.Controls.Add(Me.LBLPhone)
        Me.Controls.Add(Me.LBLEmail)
        Me.Controls.Add(Me.LBLPostCode)
        Me.Controls.Add(Me.LBLAddress)
        Me.Controls.Add(Me.LBLName)
        Me.Name = "AddShop"
        Me.Text = "Add Shop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLName As Label
    Friend WithEvents LBLAddress As Label
    Friend WithEvents LBLPostCode As Label
    Friend WithEvents LBLEmail As Label
    Friend WithEvents LBLPhone As Label
    Friend WithEvents TXTName As TextBox
    Friend WithEvents TXTAddress As TextBox
    Friend WithEvents TXTPostCode As TextBox
    Friend WithEvents TXTEmail As TextBox
    Friend WithEvents TXTPhone As TextBox
    Friend WithEvents BTNDescription As Button
    Friend WithEvents BTNSave As Button
    Friend WithEvents Back As Button
End Class

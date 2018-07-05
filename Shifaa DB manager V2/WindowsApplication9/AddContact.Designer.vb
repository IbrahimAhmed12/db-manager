<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddContact
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
        Me.CBXShopNames = New System.Windows.Forms.ComboBox()
        Me.LBLEmail = New System.Windows.Forms.Label()
        Me.LBLPhoneNumber = New System.Windows.Forms.Label()
        Me.LBLShopName = New System.Windows.Forms.Label()
        Me.TXTPhoneNumber = New System.Windows.Forms.TextBox()
        Me.TXTEmail = New System.Windows.Forms.TextBox()
        Me.BTNSave = New System.Windows.Forms.Button()
        Me.BTNBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CBXShopNames
        '
        Me.CBXShopNames.FormattingEnabled = True
        Me.CBXShopNames.Location = New System.Drawing.Point(111, 10)
        Me.CBXShopNames.Name = "CBXShopNames"
        Me.CBXShopNames.Size = New System.Drawing.Size(121, 21)
        Me.CBXShopNames.TabIndex = 0
        '
        'LBLEmail
        '
        Me.LBLEmail.AutoSize = True
        Me.LBLEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLEmail.Location = New System.Drawing.Point(12, 66)
        Me.LBLEmail.Name = "LBLEmail"
        Me.LBLEmail.Size = New System.Drawing.Size(48, 20)
        Me.LBLEmail.TabIndex = 1
        Me.LBLEmail.Text = "Email"
        '
        'LBLPhoneNumber
        '
        Me.LBLPhoneNumber.AutoSize = True
        Me.LBLPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPhoneNumber.Location = New System.Drawing.Point(12, 95)
        Me.LBLPhoneNumber.Name = "LBLPhoneNumber"
        Me.LBLPhoneNumber.Size = New System.Drawing.Size(115, 20)
        Me.LBLPhoneNumber.TabIndex = 2
        Me.LBLPhoneNumber.Text = "PhoneNumber:"
        '
        'LBLShopName
        '
        Me.LBLShopName.AutoSize = True
        Me.LBLShopName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLShopName.Location = New System.Drawing.Point(12, 11)
        Me.LBLShopName.Name = "LBLShopName"
        Me.LBLShopName.Size = New System.Drawing.Size(93, 20)
        Me.LBLShopName.TabIndex = 3
        Me.LBLShopName.Text = "ShopName:"
        '
        'TXTPhoneNumber
        '
        Me.TXTPhoneNumber.Location = New System.Drawing.Point(134, 94)
        Me.TXTPhoneNumber.Name = "TXTPhoneNumber"
        Me.TXTPhoneNumber.Size = New System.Drawing.Size(100, 20)
        Me.TXTPhoneNumber.TabIndex = 4
        '
        'TXTEmail
        '
        Me.TXTEmail.Location = New System.Drawing.Point(67, 65)
        Me.TXTEmail.Name = "TXTEmail"
        Me.TXTEmail.Size = New System.Drawing.Size(100, 20)
        Me.TXTEmail.TabIndex = 5
        '
        'BTNSave
        '
        Me.BTNSave.Location = New System.Drawing.Point(134, 130)
        Me.BTNSave.Name = "BTNSave"
        Me.BTNSave.Size = New System.Drawing.Size(75, 36)
        Me.BTNSave.TabIndex = 6
        Me.BTNSave.Text = "Save"
        Me.BTNSave.UseVisualStyleBackColor = True
        '
        'BTNBack
        '
        Me.BTNBack.Location = New System.Drawing.Point(43, 130)
        Me.BTNBack.Name = "BTNBack"
        Me.BTNBack.Size = New System.Drawing.Size(75, 36)
        Me.BTNBack.TabIndex = 7
        Me.BTNBack.Text = "Back"
        Me.BTNBack.UseVisualStyleBackColor = True
        '
        'AddContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 178)
        Me.Controls.Add(Me.BTNBack)
        Me.Controls.Add(Me.BTNSave)
        Me.Controls.Add(Me.TXTEmail)
        Me.Controls.Add(Me.TXTPhoneNumber)
        Me.Controls.Add(Me.LBLShopName)
        Me.Controls.Add(Me.LBLPhoneNumber)
        Me.Controls.Add(Me.LBLEmail)
        Me.Controls.Add(Me.CBXShopNames)
        Me.Name = "AddContact"
        Me.Text = "AddContact"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBXShopNames As ComboBox
    Friend WithEvents LBLEmail As Label
    Friend WithEvents LBLPhoneNumber As Label
    Friend WithEvents LBLShopName As Label
    Friend WithEvents TXTPhoneNumber As TextBox
    Friend WithEvents TXTEmail As TextBox
    Friend WithEvents BTNSave As Button
    Friend WithEvents BTNBack As Button
End Class

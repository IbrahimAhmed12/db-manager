<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProduct
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
        Me.LBLPName = New System.Windows.Forms.Label()
        Me.LBLCaseSize = New System.Windows.Forms.Label()
        Me.LBLBPrice = New System.Windows.Forms.Label()
        Me.LBLSPrice = New System.Windows.Forms.Label()
        Me.TXTPName = New System.Windows.Forms.TextBox()
        Me.TXTCaseSize = New System.Windows.Forms.TextBox()
        Me.TXTBPrice = New System.Windows.Forms.TextBox()
        Me.TXTSPrice = New System.Windows.Forms.TextBox()
        Me.BTNAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBLPName
        '
        Me.LBLPName.AutoSize = True
        Me.LBLPName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPName.Location = New System.Drawing.Point(22, 27)
        Me.LBLPName.Name = "LBLPName"
        Me.LBLPName.Size = New System.Drawing.Size(114, 20)
        Me.LBLPName.TabIndex = 0
        Me.LBLPName.Text = "Product Name:"
        '
        'LBLCaseSize
        '
        Me.LBLCaseSize.AutoSize = True
        Me.LBLCaseSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCaseSize.Location = New System.Drawing.Point(22, 57)
        Me.LBLCaseSize.Name = "LBLCaseSize"
        Me.LBLCaseSize.Size = New System.Drawing.Size(81, 20)
        Me.LBLCaseSize.TabIndex = 1
        Me.LBLCaseSize.Text = "Case Size"
        '
        'LBLBPrice
        '
        Me.LBLBPrice.AutoSize = True
        Me.LBLBPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBPrice.Location = New System.Drawing.Point(22, 86)
        Me.LBLBPrice.Name = "LBLBPrice"
        Me.LBLBPrice.Size = New System.Drawing.Size(155, 20)
        Me.LBLBPrice.TabIndex = 2
        Me.LBLBPrice.Text = "Production/Buy Price"
        '
        'LBLSPrice
        '
        Me.LBLSPrice.AutoSize = True
        Me.LBLSPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSPrice.Location = New System.Drawing.Point(22, 117)
        Me.LBLSPrice.Name = "LBLSPrice"
        Me.LBLSPrice.Size = New System.Drawing.Size(80, 20)
        Me.LBLSPrice.TabIndex = 3
        Me.LBLSPrice.Text = "Sale Price"
        '
        'TXTPName
        '
        Me.TXTPName.Location = New System.Drawing.Point(143, 26)
        Me.TXTPName.Name = "TXTPName"
        Me.TXTPName.Size = New System.Drawing.Size(100, 20)
        Me.TXTPName.TabIndex = 4
        '
        'TXTCaseSize
        '
        Me.TXTCaseSize.Location = New System.Drawing.Point(110, 56)
        Me.TXTCaseSize.Name = "TXTCaseSize"
        Me.TXTCaseSize.Size = New System.Drawing.Size(100, 20)
        Me.TXTCaseSize.TabIndex = 5
        '
        'TXTBPrice
        '
        Me.TXTBPrice.Location = New System.Drawing.Point(184, 85)
        Me.TXTBPrice.Name = "TXTBPrice"
        Me.TXTBPrice.Size = New System.Drawing.Size(100, 20)
        Me.TXTBPrice.TabIndex = 6
        '
        'TXTSPrice
        '
        Me.TXTSPrice.Location = New System.Drawing.Point(109, 116)
        Me.TXTSPrice.Name = "TXTSPrice"
        Me.TXTSPrice.Size = New System.Drawing.Size(100, 20)
        Me.TXTSPrice.TabIndex = 7
        '
        'BTNAdd
        '
        Me.BTNAdd.Location = New System.Drawing.Point(110, 163)
        Me.BTNAdd.Name = "BTNAdd"
        Me.BTNAdd.Size = New System.Drawing.Size(75, 23)
        Me.BTNAdd.TabIndex = 8
        Me.BTNAdd.Text = "Add"
        Me.BTNAdd.UseVisualStyleBackColor = True
        '
        'AddProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 209)
        Me.Controls.Add(Me.BTNAdd)
        Me.Controls.Add(Me.TXTSPrice)
        Me.Controls.Add(Me.TXTBPrice)
        Me.Controls.Add(Me.TXTCaseSize)
        Me.Controls.Add(Me.TXTPName)
        Me.Controls.Add(Me.LBLSPrice)
        Me.Controls.Add(Me.LBLBPrice)
        Me.Controls.Add(Me.LBLCaseSize)
        Me.Controls.Add(Me.LBLPName)
        Me.Name = "AddProduct"
        Me.Text = "AddProduct"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLPName As Label
    Friend WithEvents LBLCaseSize As Label
    Friend WithEvents LBLBPrice As Label
    Friend WithEvents LBLSPrice As Label
    Friend WithEvents TXTPName As TextBox
    Friend WithEvents TXTCaseSize As TextBox
    Friend WithEvents TXTBPrice As TextBox
    Friend WithEvents TXTSPrice As TextBox
    Friend WithEvents BTNAdd As Button
End Class

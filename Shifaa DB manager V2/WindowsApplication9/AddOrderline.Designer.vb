<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.LBLProduct = New System.Windows.Forms.Label()
        Me.CBXProducts = New System.Windows.Forms.ComboBox()
        Me.LBLAmount = New System.Windows.Forms.Label()
        Me.TXTAmount = New System.Windows.Forms.TextBox()
        Me.BTNAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBLProduct
        '
        Me.LBLProduct.AutoSize = True
        Me.LBLProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLProduct.Location = New System.Drawing.Point(11, 26)
        Me.LBLProduct.Name = "LBLProduct"
        Me.LBLProduct.Size = New System.Drawing.Size(68, 20)
        Me.LBLProduct.TabIndex = 0
        Me.LBLProduct.Text = "Product:"
        '
        'CBXProducts
        '
        Me.CBXProducts.FormattingEnabled = True
        Me.CBXProducts.Location = New System.Drawing.Point(86, 24)
        Me.CBXProducts.Name = "CBXProducts"
        Me.CBXProducts.Size = New System.Drawing.Size(121, 21)
        Me.CBXProducts.TabIndex = 1
        '
        'LBLAmount
        '
        Me.LBLAmount.AutoSize = True
        Me.LBLAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLAmount.Location = New System.Drawing.Point(11, 59)
        Me.LBLAmount.Name = "LBLAmount"
        Me.LBLAmount.Size = New System.Drawing.Size(69, 20)
        Me.LBLAmount.TabIndex = 2
        Me.LBLAmount.Text = "Amount:"
        '
        'TXTAmount
        '
        Me.TXTAmount.Location = New System.Drawing.Point(86, 59)
        Me.TXTAmount.Name = "TXTAmount"
        Me.TXTAmount.Size = New System.Drawing.Size(100, 20)
        Me.TXTAmount.TabIndex = 3
        '
        'BTNAdd
        '
        Me.BTNAdd.Location = New System.Drawing.Point(86, 107)
        Me.BTNAdd.Name = "BTNAdd"
        Me.BTNAdd.Size = New System.Drawing.Size(75, 23)
        Me.BTNAdd.TabIndex = 4
        Me.BTNAdd.Text = "Add"
        Me.BTNAdd.UseVisualStyleBackColor = True
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 142)
        Me.Controls.Add(Me.BTNAdd)
        Me.Controls.Add(Me.TXTAmount)
        Me.Controls.Add(Me.LBLAmount)
        Me.Controls.Add(Me.CBXProducts)
        Me.Controls.Add(Me.LBLProduct)
        Me.Name = "Form9"
        Me.Text = "Form9"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLProduct As Label
    Friend WithEvents CBXProducts As ComboBox
    Friend WithEvents LBLAmount As Label
    Friend WithEvents TXTAmount As TextBox
    Friend WithEvents BTNAdd As Button
End Class

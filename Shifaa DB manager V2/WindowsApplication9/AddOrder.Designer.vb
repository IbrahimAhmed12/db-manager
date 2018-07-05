<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddOrder
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
        Me.CBXShop = New System.Windows.Forms.ComboBox()
        Me.LBLTransDate = New System.Windows.Forms.Label()
        Me.DTPOrder = New System.Windows.Forms.DateTimePicker()
        Me.BTNAddsale = New System.Windows.Forms.Button()
        Me.DGVOrderlines = New System.Windows.Forms.DataGridView()
        Me.BTNAdd_Order = New System.Windows.Forms.Button()
        Me.LBLDriver = New System.Windows.Forms.Label()
        Me.CBXDriver = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBLExpenses = New System.Windows.Forms.Label()
        Me.TXTExpenses = New System.Windows.Forms.TextBox()
        CType(Me.DGVOrderlines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Shop:"
        '
        'CBXShop
        '
        Me.CBXShop.FormattingEnabled = True
        Me.CBXShop.Location = New System.Drawing.Point(82, 27)
        Me.CBXShop.Name = "CBXShop"
        Me.CBXShop.Size = New System.Drawing.Size(121, 21)
        Me.CBXShop.TabIndex = 1
        '
        'LBLTransDate
        '
        Me.LBLTransDate.AutoSize = True
        Me.LBLTransDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTransDate.Location = New System.Drawing.Point(25, 137)
        Me.LBLTransDate.Name = "LBLTransDate"
        Me.LBLTransDate.Size = New System.Drawing.Size(135, 20)
        Me.LBLTransDate.TabIndex = 2
        Me.LBLTransDate.Text = "Transaction Date:"
        '
        'DTPOrder
        '
        Me.DTPOrder.Location = New System.Drawing.Point(29, 160)
        Me.DTPOrder.Name = "DTPOrder"
        Me.DTPOrder.Size = New System.Drawing.Size(200, 20)
        Me.DTPOrder.TabIndex = 3
        '
        'BTNAddsale
        '
        Me.BTNAddsale.Location = New System.Drawing.Point(29, 289)
        Me.BTNAddsale.Name = "BTNAddsale"
        Me.BTNAddsale.Size = New System.Drawing.Size(75, 23)
        Me.BTNAddsale.TabIndex = 4
        Me.BTNAddsale.Text = "Add Sale"
        Me.BTNAddsale.UseVisualStyleBackColor = True
        '
        'DGVOrderlines
        '
        Me.DGVOrderlines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOrderlines.Location = New System.Drawing.Point(29, 186)
        Me.DGVOrderlines.Name = "DGVOrderlines"
        Me.DGVOrderlines.Size = New System.Drawing.Size(240, 79)
        Me.DGVOrderlines.TabIndex = 5
        '
        'BTNAdd_Order
        '
        Me.BTNAdd_Order.Location = New System.Drawing.Point(168, 288)
        Me.BTNAdd_Order.Name = "BTNAdd_Order"
        Me.BTNAdd_Order.Size = New System.Drawing.Size(75, 23)
        Me.BTNAdd_Order.TabIndex = 6
        Me.BTNAdd_Order.Text = "Add Order"
        Me.BTNAdd_Order.UseVisualStyleBackColor = True
        '
        'LBLDriver
        '
        Me.LBLDriver.AutoSize = True
        Me.LBLDriver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDriver.Location = New System.Drawing.Point(26, 69)
        Me.LBLDriver.Name = "LBLDriver"
        Me.LBLDriver.Size = New System.Drawing.Size(54, 20)
        Me.LBLDriver.TabIndex = 7
        Me.LBLDriver.Text = "Driver:"
        '
        'CBXDriver
        '
        Me.CBXDriver.FormattingEnabled = True
        Me.CBXDriver.Location = New System.Drawing.Point(86, 68)
        Me.CBXDriver.Name = "CBXDriver"
        Me.CBXDriver.Size = New System.Drawing.Size(121, 21)
        Me.CBXDriver.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 9
        '
        'LBLExpenses
        '
        Me.LBLExpenses.AutoSize = True
        Me.LBLExpenses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLExpenses.Location = New System.Drawing.Point(26, 105)
        Me.LBLExpenses.Name = "LBLExpenses"
        Me.LBLExpenses.Size = New System.Drawing.Size(83, 20)
        Me.LBLExpenses.TabIndex = 10
        Me.LBLExpenses.Text = "Expenses:"
        '
        'TXTExpenses
        '
        Me.TXTExpenses.Location = New System.Drawing.Point(115, 105)
        Me.TXTExpenses.Name = "TXTExpenses"
        Me.TXTExpenses.Size = New System.Drawing.Size(128, 20)
        Me.TXTExpenses.TabIndex = 11
        '
        'AddOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 323)
        Me.Controls.Add(Me.TXTExpenses)
        Me.Controls.Add(Me.LBLExpenses)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBXDriver)
        Me.Controls.Add(Me.LBLDriver)
        Me.Controls.Add(Me.BTNAdd_Order)
        Me.Controls.Add(Me.DGVOrderlines)
        Me.Controls.Add(Me.BTNAddsale)
        Me.Controls.Add(Me.DTPOrder)
        Me.Controls.Add(Me.LBLTransDate)
        Me.Controls.Add(Me.CBXShop)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddOrder"
        Me.Text = "Form8"
        CType(Me.DGVOrderlines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CBXShop As ComboBox
    Friend WithEvents LBLTransDate As Label
    Friend WithEvents DTPOrder As DateTimePicker
    Friend WithEvents BTNAddsale As Button
    Friend WithEvents DGVOrderlines As DataGridView
    Friend WithEvents BTNAdd_Order As Button
    Friend WithEvents LBLDriver As Label
    Friend WithEvents CBXDriver As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LBLExpenses As Label
    Friend WithEvents TXTExpenses As TextBox
End Class

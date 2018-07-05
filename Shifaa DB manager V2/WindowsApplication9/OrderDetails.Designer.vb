<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderDetails
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
        Me.LBLOrderID = New System.Windows.Forms.Label()
        Me.LBLShopName = New System.Windows.Forms.Label()
        Me.LBLPostcode = New System.Windows.Forms.Label()
        Me.DGVOrderline = New System.Windows.Forms.DataGridView()
        Me.BTNPrint = New System.Windows.Forms.Button()
        CType(Me.DGVOrderline, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBLOrderID
        '
        Me.LBLOrderID.AutoSize = True
        Me.LBLOrderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLOrderID.Location = New System.Drawing.Point(88, 9)
        Me.LBLOrderID.Name = "LBLOrderID"
        Me.LBLOrderID.Size = New System.Drawing.Size(101, 31)
        Me.LBLOrderID.TabIndex = 0
        Me.LBLOrderID.Text = "Label1"
        '
        'LBLShopName
        '
        Me.LBLShopName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLShopName.AutoSize = True
        Me.LBLShopName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLShopName.Location = New System.Drawing.Point(23, 72)
        Me.LBLShopName.Name = "LBLShopName"
        Me.LBLShopName.Size = New System.Drawing.Size(66, 24)
        Me.LBLShopName.TabIndex = 1
        Me.LBLShopName.Text = "Label1"
        '
        'LBLPostcode
        '
        Me.LBLPostcode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLPostcode.AutoSize = True
        Me.LBLPostcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPostcode.Location = New System.Drawing.Point(23, 105)
        Me.LBLPostcode.Name = "LBLPostcode"
        Me.LBLPostcode.Size = New System.Drawing.Size(66, 24)
        Me.LBLPostcode.TabIndex = 2
        Me.LBLPostcode.Text = "Label1"
        '
        'DGVOrderline
        '
        Me.DGVOrderline.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVOrderline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOrderline.Location = New System.Drawing.Point(27, 152)
        Me.DGVOrderline.Name = "DGVOrderline"
        Me.DGVOrderline.Size = New System.Drawing.Size(339, 116)
        Me.DGVOrderline.TabIndex = 3
        '
        'BTNPrint
        '
        Me.BTNPrint.Location = New System.Drawing.Point(159, 274)
        Me.BTNPrint.Name = "BTNPrint"
        Me.BTNPrint.Size = New System.Drawing.Size(73, 48)
        Me.BTNPrint.TabIndex = 4
        Me.BTNPrint.Text = "Make an invoice"
        Me.BTNPrint.UseVisualStyleBackColor = True
        '
        'OrderDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 330)
        Me.Controls.Add(Me.BTNPrint)
        Me.Controls.Add(Me.DGVOrderline)
        Me.Controls.Add(Me.LBLPostcode)
        Me.Controls.Add(Me.LBLShopName)
        Me.Controls.Add(Me.LBLOrderID)
        Me.Name = "OrderDetails"
        Me.Text = "Form4"
        CType(Me.DGVOrderline, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLOrderID As Label
    Friend WithEvents LBLShopName As Label
    Friend WithEvents LBLPostcode As Label
    Friend WithEvents DGVOrderline As DataGridView
    Friend WithEvents BTNPrint As Button
End Class

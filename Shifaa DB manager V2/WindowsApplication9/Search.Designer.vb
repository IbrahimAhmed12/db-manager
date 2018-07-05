<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search
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
        Me.LBLTable = New System.Windows.Forms.Label()
        Me.LBLName = New System.Windows.Forms.Label()
        Me.LBLPkey = New System.Windows.Forms.Label()
        Me.CBXTable = New System.Windows.Forms.ComboBox()
        Me.CBXName = New System.Windows.Forms.ComboBox()
        Me.TXTPkey = New System.Windows.Forms.TextBox()
        Me.BTNGo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBLTable
        '
        Me.LBLTable.AutoSize = True
        Me.LBLTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTable.Location = New System.Drawing.Point(31, 32)
        Me.LBLTable.Name = "LBLTable"
        Me.LBLTable.Size = New System.Drawing.Size(52, 20)
        Me.LBLTable.TabIndex = 0
        Me.LBLTable.Text = "Table:"
        '
        'LBLName
        '
        Me.LBLName.AutoSize = True
        Me.LBLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLName.Location = New System.Drawing.Point(31, 63)
        Me.LBLName.Name = "LBLName"
        Me.LBLName.Size = New System.Drawing.Size(55, 20)
        Me.LBLName.TabIndex = 1
        Me.LBLName.Text = "Name:"
        '
        'LBLPkey
        '
        Me.LBLPkey.AutoSize = True
        Me.LBLPkey.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPkey.Location = New System.Drawing.Point(31, 100)
        Me.LBLPkey.Name = "LBLPkey"
        Me.LBLPkey.Size = New System.Drawing.Size(95, 20)
        Me.LBLPkey.TabIndex = 2
        Me.LBLPkey.Text = "Primary Key:"
        '
        'CBXTable
        '
        Me.CBXTable.FormattingEnabled = True
        Me.CBXTable.Location = New System.Drawing.Point(89, 31)
        Me.CBXTable.Name = "CBXTable"
        Me.CBXTable.Size = New System.Drawing.Size(121, 21)
        Me.CBXTable.TabIndex = 3
        '
        'CBXName
        '
        Me.CBXName.FormattingEnabled = True
        Me.CBXName.Location = New System.Drawing.Point(93, 61)
        Me.CBXName.Name = "CBXName"
        Me.CBXName.Size = New System.Drawing.Size(121, 21)
        Me.CBXName.TabIndex = 4
        '
        'TXTPkey
        '
        Me.TXTPkey.Location = New System.Drawing.Point(133, 99)
        Me.TXTPkey.Name = "TXTPkey"
        Me.TXTPkey.Size = New System.Drawing.Size(100, 20)
        Me.TXTPkey.TabIndex = 5
        '
        'BTNGo
        '
        Me.BTNGo.Location = New System.Drawing.Point(107, 147)
        Me.BTNGo.Name = "BTNGo"
        Me.BTNGo.Size = New System.Drawing.Size(75, 23)
        Me.BTNGo.TabIndex = 6
        Me.BTNGo.Text = "Go"
        Me.BTNGo.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(232, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(21, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "?"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 191)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTNGo)
        Me.Controls.Add(Me.TXTPkey)
        Me.Controls.Add(Me.CBXName)
        Me.Controls.Add(Me.CBXTable)
        Me.Controls.Add(Me.LBLPkey)
        Me.Controls.Add(Me.LBLName)
        Me.Controls.Add(Me.LBLTable)
        Me.Name = "Search"
        Me.Text = "Form10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLTable As Label
    Friend WithEvents LBLName As Label
    Friend WithEvents LBLPkey As Label
    Friend WithEvents CBXTable As ComboBox
    Friend WithEvents CBXName As ComboBox
    Friend WithEvents TXTPkey As TextBox
    Friend WithEvents BTNGo As Button
    Friend WithEvents Button1 As Button
End Class

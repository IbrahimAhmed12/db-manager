<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Analysis
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
        Me.LBLname = New System.Windows.Forms.Label()
        Me.LBLProfit = New System.Windows.Forms.Label()
        Me.LBLPercent = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LBLname
        '
        Me.LBLname.AutoSize = True
        Me.LBLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLname.Location = New System.Drawing.Point(103, 21)
        Me.LBLname.Name = "LBLname"
        Me.LBLname.Size = New System.Drawing.Size(57, 20)
        Me.LBLname.TabIndex = 0
        Me.LBLname.Text = "Label1"
        '
        'LBLProfit
        '
        Me.LBLProfit.AutoSize = True
        Me.LBLProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLProfit.Location = New System.Drawing.Point(12, 64)
        Me.LBLProfit.Name = "LBLProfit"
        Me.LBLProfit.Size = New System.Drawing.Size(57, 20)
        Me.LBLProfit.TabIndex = 1
        Me.LBLProfit.Text = "Label2"
        '
        'LBLPercent
        '
        Me.LBLPercent.AutoSize = True
        Me.LBLPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPercent.Location = New System.Drawing.Point(12, 117)
        Me.LBLPercent.Name = "LBLPercent"
        Me.LBLPercent.Size = New System.Drawing.Size(57, 20)
        Me.LBLPercent.TabIndex = 2
        Me.LBLPercent.Text = "Label3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 177)
        Me.Controls.Add(Me.LBLPercent)
        Me.Controls.Add(Me.LBLProfit)
        Me.Controls.Add(Me.LBLname)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLname As Label
    Friend WithEvents LBLProfit As Label
    Friend WithEvents LBLPercent As Label
End Class

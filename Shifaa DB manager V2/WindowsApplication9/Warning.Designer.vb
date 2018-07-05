<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Warning
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
        Me.LBLWarning = New System.Windows.Forms.Label()
        Me.BTNYes = New System.Windows.Forms.Button()
        Me.BTNNo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBLWarning
        '
        Me.LBLWarning.AutoSize = True
        Me.LBLWarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLWarning.Location = New System.Drawing.Point(12, 35)
        Me.LBLWarning.Name = "LBLWarning"
        Me.LBLWarning.Size = New System.Drawing.Size(313, 32)
        Me.LBLWarning.TabIndex = 0
        Me.LBLWarning.Text = "Once you delete a record it cannot be undone." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ae you sure you want to delete the" &
    " records chosen?"
        '
        'BTNYes
        '
        Me.BTNYes.Location = New System.Drawing.Point(78, 92)
        Me.BTNYes.Name = "BTNYes"
        Me.BTNYes.Size = New System.Drawing.Size(75, 23)
        Me.BTNYes.TabIndex = 1
        Me.BTNYes.Text = "Yes"
        Me.BTNYes.UseVisualStyleBackColor = True
        '
        'BTNNo
        '
        Me.BTNNo.Location = New System.Drawing.Point(185, 91)
        Me.BTNNo.Name = "BTNNo"
        Me.BTNNo.Size = New System.Drawing.Size(75, 23)
        Me.BTNNo.TabIndex = 2
        Me.BTNNo.Text = "No"
        Me.BTNNo.UseVisualStyleBackColor = True
        '
        'Warning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 127)
        Me.Controls.Add(Me.BTNNo)
        Me.Controls.Add(Me.BTNYes)
        Me.Controls.Add(Me.LBLWarning)
        Me.Name = "Warning"
        Me.Text = "Warning"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLWarning As Label
    Friend WithEvents BTNYes As Button
    Friend WithEvents BTNNo As Button
End Class

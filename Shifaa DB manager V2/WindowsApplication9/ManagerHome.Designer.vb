<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerHome
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
        Me.components = New System.ComponentModel.Container()
        Me.BTNAnalysis = New System.Windows.Forms.Button()
        Me.BTNDatabaseManagement = New System.Windows.Forms.Button()
        Me.LBLWelcome = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'BTNAnalysis
        '
        Me.BTNAnalysis.AccessibleName = ""
        Me.BTNAnalysis.Location = New System.Drawing.Point(120, 58)
        Me.BTNAnalysis.Name = "BTNAnalysis"
        Me.BTNAnalysis.Size = New System.Drawing.Size(98, 38)
        Me.BTNAnalysis.TabIndex = 1
        Me.BTNAnalysis.Text = "Analysis"
        Me.BTNAnalysis.UseVisualStyleBackColor = True
        '
        'BTNDatabaseManagement
        '
        Me.BTNDatabaseManagement.AccessibleName = "BTNDatabaseManagement"
        Me.BTNDatabaseManagement.Location = New System.Drawing.Point(16, 58)
        Me.BTNDatabaseManagement.Name = "BTNDatabaseManagement"
        Me.BTNDatabaseManagement.Size = New System.Drawing.Size(98, 38)
        Me.BTNDatabaseManagement.TabIndex = 2
        Me.BTNDatabaseManagement.Text = "Database Managment"
        Me.BTNDatabaseManagement.UseVisualStyleBackColor = True
        '
        'LBLWelcome
        '
        Me.LBLWelcome.AutoSize = True
        Me.LBLWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLWelcome.Location = New System.Drawing.Point(12, 9)
        Me.LBLWelcome.Name = "LBLWelcome"
        Me.LBLWelcome.Size = New System.Drawing.Size(25, 20)
        Me.LBLWelcome.TabIndex = 5
        Me.LBLWelcome.Text = "W"
        '
        'ManagerHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 131)
        Me.Controls.Add(Me.LBLWelcome)
        Me.Controls.Add(Me.BTNDatabaseManagement)
        Me.Controls.Add(Me.BTNAnalysis)
        Me.Name = "ManagerHome"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNAnalysis As Button
    Friend WithEvents BTNDatabaseManagement As Button
    Friend WithEvents LBLWelcome As Label
    Friend WithEvents Timer1 As Timer
End Class

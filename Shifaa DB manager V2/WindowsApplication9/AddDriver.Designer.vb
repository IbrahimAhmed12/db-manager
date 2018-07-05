<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddDriver
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LBLDLastName = New System.Windows.Forms.Label()
        Me.LBLCarCapacity = New System.Windows.Forms.Label()
        Me.LBLDFirstName = New System.Windows.Forms.Label()
        Me.TXTFirstName = New System.Windows.Forms.TextBox()
        Me.TXTLastName = New System.Windows.Forms.TextBox()
        Me.TXTCarCapacity = New System.Windows.Forms.TextBox()
        Me.BTNSaveRecord = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBLDLastName
        '
        Me.LBLDLastName.AutoSize = True
        Me.LBLDLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDLastName.Location = New System.Drawing.Point(12, 36)
        Me.LBLDLastName.Name = "LBLDLastName"
        Me.LBLDLastName.Size = New System.Drawing.Size(88, 20)
        Me.LBLDLastName.TabIndex = 0
        Me.LBLDLastName.Text = "Last name:"
        '
        'LBLCarCapacity
        '
        Me.LBLCarCapacity.AutoSize = True
        Me.LBLCarCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCarCapacity.Location = New System.Drawing.Point(12, 59)
        Me.LBLCarCapacity.Name = "LBLCarCapacity"
        Me.LBLCarCapacity.Size = New System.Drawing.Size(103, 20)
        Me.LBLCarCapacity.TabIndex = 1
        Me.LBLCarCapacity.Text = "Car Capacity:"
        '
        'LBLDFirstName
        '
        Me.LBLDFirstName.AutoSize = True
        Me.LBLDFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDFirstName.Location = New System.Drawing.Point(12, 13)
        Me.LBLDFirstName.Name = "LBLDFirstName"
        Me.LBLDFirstName.Size = New System.Drawing.Size(90, 20)
        Me.LBLDFirstName.TabIndex = 2
        Me.LBLDFirstName.Text = "First Name:"
        '
        'TXTFirstName
        '
        Me.TXTFirstName.Location = New System.Drawing.Point(105, 13)
        Me.TXTFirstName.Name = "TXTFirstName"
        Me.TXTFirstName.Size = New System.Drawing.Size(100, 20)
        Me.TXTFirstName.TabIndex = 3
        '
        'TXTLastName
        '
        Me.TXTLastName.Location = New System.Drawing.Point(106, 36)
        Me.TXTLastName.Name = "TXTLastName"
        Me.TXTLastName.Size = New System.Drawing.Size(100, 20)
        Me.TXTLastName.TabIndex = 4
        '
        'TXTCarCapacity
        '
        Me.TXTCarCapacity.Location = New System.Drawing.Point(121, 59)
        Me.TXTCarCapacity.Name = "TXTCarCapacity"
        Me.TXTCarCapacity.Size = New System.Drawing.Size(100, 20)
        Me.TXTCarCapacity.TabIndex = 5
        '
        'BTNSaveRecord
        '
        Me.BTNSaveRecord.Location = New System.Drawing.Point(73, 100)
        Me.BTNSaveRecord.Name = "BTNSaveRecord"
        Me.BTNSaveRecord.Size = New System.Drawing.Size(75, 23)
        Me.BTNSaveRecord.TabIndex = 6
        Me.BTNSaveRecord.Text = "Save"
        Me.BTNSaveRecord.UseVisualStyleBackColor = True
        '
        'DriverChanges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 136)
        Me.Controls.Add(Me.BTNSaveRecord)
        Me.Controls.Add(Me.TXTCarCapacity)
        Me.Controls.Add(Me.TXTLastName)
        Me.Controls.Add(Me.TXTFirstName)
        Me.Controls.Add(Me.LBLDFirstName)
        Me.Controls.Add(Me.LBLCarCapacity)
        Me.Controls.Add(Me.LBLDLastName)
        Me.Name = "DriverChanges"
        Me.Text = "Form7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLDLastName As Label
    Friend WithEvents LBLCarCapacity As Label
    Friend WithEvents LBLDFirstName As Label
    Friend WithEvents TXTFirstName As TextBox
    Friend WithEvents TXTLastName As TextBox
    Friend WithEvents TXTCarCapacity As TextBox
    Friend WithEvents BTNSaveRecord As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DriverHome
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
        Me.components = New System.ComponentModel.Container()
        Me.LBLwelcome = New System.Windows.Forms.Label()
        Me.DGVorders = New System.Windows.Forms.DataGridView()
        Me.LBLid = New System.Windows.Forms.Label()
        Me.CBXorders = New System.Windows.Forms.ComboBox()
        Me.LBLDate = New System.Windows.Forms.Label()
        Me.BTNChangeDet = New System.Windows.Forms.Button()
        Me.LBLDescription = New System.Windows.Forms.Label()
        Me.BTNShowDeatails = New System.Windows.Forms.Button()
        Me.TMRdatasave = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DGVorders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBLwelcome
        '
        Me.LBLwelcome.AutoSize = True
        Me.LBLwelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLwelcome.Location = New System.Drawing.Point(13, 12)
        Me.LBLwelcome.Name = "LBLwelcome"
        Me.LBLwelcome.Size = New System.Drawing.Size(101, 31)
        Me.LBLwelcome.TabIndex = 0
        Me.LBLwelcome.Text = "Label1"
        '
        'DGVorders
        '
        Me.DGVorders.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVorders.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVorders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVorders.Location = New System.Drawing.Point(19, 141)
        Me.DGVorders.Name = "DGVorders"
        Me.DGVorders.ReadOnly = True
        Me.DGVorders.Size = New System.Drawing.Size(337, 120)
        Me.DGVorders.TabIndex = 1
        '
        'LBLid
        '
        Me.LBLid.AutoSize = True
        Me.LBLid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LBLid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLid.Location = New System.Drawing.Point(18, 59)
        Me.LBLid.Name = "LBLid"
        Me.LBLid.Size = New System.Drawing.Size(86, 24)
        Me.LBLid.TabIndex = 2
        Me.LBLid.Text = "Driver ID:"
        '
        'CBXorders
        '
        Me.CBXorders.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBXorders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBXorders.FormattingEnabled = True
        Me.CBXorders.Location = New System.Drawing.Point(19, 112)
        Me.CBXorders.Name = "CBXorders"
        Me.CBXorders.Size = New System.Drawing.Size(162, 21)
        Me.CBXorders.TabIndex = 3
        '
        'LBLDate
        '
        Me.LBLDate.AutoSize = True
        Me.LBLDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LBLDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDate.Location = New System.Drawing.Point(197, 59)
        Me.LBLDate.Name = "LBLDate"
        Me.LBLDate.Size = New System.Drawing.Size(66, 24)
        Me.LBLDate.TabIndex = 4
        Me.LBLDate.Text = "Label1"
        '
        'BTNChangeDet
        '
        Me.BTNChangeDet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNChangeDet.Location = New System.Drawing.Point(294, 9)
        Me.BTNChangeDet.Name = "BTNChangeDet"
        Me.BTNChangeDet.Size = New System.Drawing.Size(62, 45)
        Me.BTNChangeDet.TabIndex = 5
        Me.BTNChangeDet.Text = "Change Details"
        Me.BTNChangeDet.UseVisualStyleBackColor = True
        '
        'LBLDescription
        '
        Me.LBLDescription.AutoSize = True
        Me.LBLDescription.Location = New System.Drawing.Point(19, 83)
        Me.LBLDescription.Name = "LBLDescription"
        Me.LBLDescription.Size = New System.Drawing.Size(336, 26)
        Me.LBLDescription.TabIndex = 6
        Me.LBLDescription.Text = "To View details of an Order click the Order ID on the drop down menu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and press s" &
    "how details."
        '
        'BTNShowDeatails
        '
        Me.BTNShowDeatails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNShowDeatails.AutoSize = True
        Me.BTNShowDeatails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTNShowDeatails.Location = New System.Drawing.Point(188, 112)
        Me.BTNShowDeatails.Name = "BTNShowDeatails"
        Me.BTNShowDeatails.Size = New System.Drawing.Size(79, 23)
        Me.BTNShowDeatails.TabIndex = 7
        Me.BTNShowDeatails.Text = "Show Details"
        Me.BTNShowDeatails.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 273)
        Me.Controls.Add(Me.BTNShowDeatails)
        Me.Controls.Add(Me.LBLDescription)
        Me.Controls.Add(Me.BTNChangeDet)
        Me.Controls.Add(Me.LBLDate)
        Me.Controls.Add(Me.CBXorders)
        Me.Controls.Add(Me.LBLid)
        Me.Controls.Add(Me.DGVorders)
        Me.Controls.Add(Me.LBLwelcome)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DGVorders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLwelcome As Label
    Friend WithEvents DGVorders As DataGridView
    Friend WithEvents LBLid As Label
    Friend WithEvents CBXorders As ComboBox
    Friend WithEvents LBLDate As Label
    Friend WithEvents BTNChangeDet As Button
    Friend WithEvents LBLDescription As Label
    Friend WithEvents BTNShowDeatails As Button
    Friend WithEvents TMRdatasave As Timer
End Class

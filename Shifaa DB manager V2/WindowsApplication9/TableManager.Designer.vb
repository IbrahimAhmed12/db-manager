<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableManager
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
        Me.DGVDataEditor = New System.Windows.Forms.DataGridView()
        Me.BTNDelete = New System.Windows.Forms.Button()
        Me.BTNSave = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShopToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactDetailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DriversToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderlinesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewShopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DriverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TXTSearch = New System.Windows.Forms.TextBox()
        Me.LBLSearch = New System.Windows.Forms.Label()
        Me.BTNDescription = New System.Windows.Forms.Button()
        Me.Pause = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DGVDataEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVDataEditor
        '
        Me.DGVDataEditor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDataEditor.Location = New System.Drawing.Point(22, 55)
        Me.DGVDataEditor.Name = "DGVDataEditor"
        Me.DGVDataEditor.Size = New System.Drawing.Size(650, 380)
        Me.DGVDataEditor.TabIndex = 0
        '
        'BTNDelete
        '
        Me.BTNDelete.Location = New System.Drawing.Point(237, 498)
        Me.BTNDelete.Name = "BTNDelete"
        Me.BTNDelete.Size = New System.Drawing.Size(75, 38)
        Me.BTNDelete.TabIndex = 1
        Me.BTNDelete.Text = "Delete"
        Me.BTNDelete.UseVisualStyleBackColor = True
        Me.BTNDelete.Visible = False
        '
        'BTNSave
        '
        Me.BTNSave.Location = New System.Drawing.Point(375, 498)
        Me.BTNSave.Name = "BTNSave"
        Me.BTNSave.Size = New System.Drawing.Size(75, 38)
        Me.BTNSave.TabIndex = 2
        Me.BTNSave.Text = "Save"
        Me.BTNSave.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayToolStripMenuItem, Me.AddToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(693, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShopToolStripMenuItem1, Me.DriversToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.OrdersToolStripMenuItem})
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.DisplayToolStripMenuItem.Text = "Display"
        '
        'ShopToolStripMenuItem1
        '
        Me.ShopToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContactDetailsToolStripMenuItem1})
        Me.ShopToolStripMenuItem1.Name = "ShopToolStripMenuItem1"
        Me.ShopToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.ShopToolStripMenuItem1.Text = "Shop"
        '
        'ContactDetailsToolStripMenuItem1
        '
        Me.ContactDetailsToolStripMenuItem1.Name = "ContactDetailsToolStripMenuItem1"
        Me.ContactDetailsToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.ContactDetailsToolStripMenuItem1.Text = "Contact details"
        '
        'DriversToolStripMenuItem
        '
        Me.DriversToolStripMenuItem.Name = "DriversToolStripMenuItem"
        Me.DriversToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.DriversToolStripMenuItem.Text = "Drivers"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.ProductsToolStripMenuItem.Text = "Products"
        '
        'OrdersToolStripMenuItem
        '
        Me.OrdersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderlinesToolStripMenuItem1})
        Me.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem"
        Me.OrdersToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.OrdersToolStripMenuItem.Text = "Orders"
        '
        'OrderlinesToolStripMenuItem1
        '
        Me.OrderlinesToolStripMenuItem1.Name = "OrderlinesToolStripMenuItem1"
        Me.OrderlinesToolStripMenuItem1.Size = New System.Drawing.Size(128, 22)
        Me.OrderlinesToolStripMenuItem1.Text = "Orderlines"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductToolStripMenuItem, Me.ShopToolStripMenuItem, Me.DriverToolStripMenuItem, Me.OrderToolStripMenuItem})
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'ProductToolStripMenuItem
        '
        Me.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        Me.ProductToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProductToolStripMenuItem.Text = "Product"
        '
        'ShopToolStripMenuItem
        '
        Me.ShopToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContactDetailsToolStripMenuItem, Me.NewShopToolStripMenuItem})
        Me.ShopToolStripMenuItem.Name = "ShopToolStripMenuItem"
        Me.ShopToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ShopToolStripMenuItem.Text = "Shop"
        '
        'ContactDetailsToolStripMenuItem
        '
        Me.ContactDetailsToolStripMenuItem.Name = "ContactDetailsToolStripMenuItem"
        Me.ContactDetailsToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ContactDetailsToolStripMenuItem.Text = "Contact Details"
        '
        'NewShopToolStripMenuItem
        '
        Me.NewShopToolStripMenuItem.Name = "NewShopToolStripMenuItem"
        Me.NewShopToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.NewShopToolStripMenuItem.Text = "New Shop"
        '
        'DriverToolStripMenuItem
        '
        Me.DriverToolStripMenuItem.Name = "DriverToolStripMenuItem"
        Me.DriverToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DriverToolStripMenuItem.Text = "Driver"
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OrderToolStripMenuItem.Text = "Order"
        '
        'TXTSearch
        '
        Me.TXTSearch.Location = New System.Drawing.Point(84, 29)
        Me.TXTSearch.Name = "TXTSearch"
        Me.TXTSearch.Size = New System.Drawing.Size(100, 20)
        Me.TXTSearch.TabIndex = 4
        '
        'LBLSearch
        '
        Me.LBLSearch.AutoSize = True
        Me.LBLSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSearch.Location = New System.Drawing.Point(18, 29)
        Me.LBLSearch.Name = "LBLSearch"
        Me.LBLSearch.Size = New System.Drawing.Size(60, 20)
        Me.LBLSearch.TabIndex = 5
        Me.LBLSearch.Text = "Search"
        '
        'BTNDescription
        '
        Me.BTNDescription.Location = New System.Drawing.Point(190, 29)
        Me.BTNDescription.Name = "BTNDescription"
        Me.BTNDescription.Size = New System.Drawing.Size(18, 21)
        Me.BTNDescription.TabIndex = 6
        Me.BTNDescription.Text = "?"
        Me.BTNDescription.UseVisualStyleBackColor = True
        '
        'TableManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 594)
        Me.Controls.Add(Me.BTNDescription)
        Me.Controls.Add(Me.LBLSearch)
        Me.Controls.Add(Me.TXTSearch)
        Me.Controls.Add(Me.BTNSave)
        Me.Controls.Add(Me.BTNDelete)
        Me.Controls.Add(Me.DGVDataEditor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "TableManager"
        Me.ShowIcon = False
        Me.Text = "TableManager"
        CType(Me.DGVDataEditor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVDataEditor As DataGridView
    Friend WithEvents BTNDelete As Button
    Friend WithEvents BTNSave As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DisplayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShopToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ContactDetailsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DriversToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewShopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DriverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrderlinesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TXTSearch As TextBox
    Friend WithEvents LBLSearch As Label
    Friend WithEvents BTNDescription As Button
    Friend WithEvents Pause As Timer
    Friend WithEvents OrderToolStripMenuItem As ToolStripMenuItem
End Class

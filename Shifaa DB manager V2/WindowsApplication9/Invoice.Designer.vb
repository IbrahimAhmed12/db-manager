<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Invoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Invoice))
        Me.LBLDetails = New System.Windows.Forms.Label()
        Me.LBLOrderID = New System.Windows.Forms.Label()
        Me.LBLProduct1 = New System.Windows.Forms.Label()
        Me.LBLProduct2 = New System.Windows.Forms.Label()
        Me.LBLProduct1Price = New System.Windows.Forms.Label()
        Me.LBLProductPrice = New System.Windows.Forms.Label()
        Me.LBlTotalPrice = New System.Windows.Forms.Label()
        Me.LBLQuantity2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBLName = New System.Windows.Forms.Label()
        Me.LBLTelNo = New System.Windows.Forms.Label()
        Me.LBLEmail = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBLProduct = New System.Windows.Forms.Label()
        Me.LBLPrice = New System.Windows.Forms.Label()
        Me.BTNPrint = New System.Windows.Forms.Button()
        Me.LBLLeagalities = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBLQuantity1 = New System.Windows.Forms.Label()
        Me.LBLquanttity2 = New System.Windows.Forms.Label()
        Me.LBLBillings = New System.Windows.Forms.Label()
        Me.LBLDate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Printform = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'LBLDetails
        '
        Me.LBLDetails.AutoSize = True
        Me.LBLDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDetails.Location = New System.Drawing.Point(12, 8)
        Me.LBLDetails.Name = "LBLDetails"
        Me.LBLDetails.Size = New System.Drawing.Size(188, 96)
        Me.LBLDetails.TabIndex = 0
        Me.LBLDetails.Text = "       FROM:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shifa-E-Kaamila" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tel no: 020 7101 4062" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Email: info@shifaekamila.co" &
    "m" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Account No: 29809860" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sort Code: 30-96-26"
        '
        'LBLOrderID
        '
        Me.LBLOrderID.AutoSize = True
        Me.LBLOrderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLOrderID.Location = New System.Drawing.Point(12, 220)
        Me.LBLOrderID.Name = "LBLOrderID"
        Me.LBLOrderID.Size = New System.Drawing.Size(57, 20)
        Me.LBLOrderID.TabIndex = 1
        Me.LBLOrderID.Text = "Label1"
        '
        'LBLProduct1
        '
        Me.LBLProduct1.AutoSize = True
        Me.LBLProduct1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLProduct1.Location = New System.Drawing.Point(13, 289)
        Me.LBLProduct1.Name = "LBLProduct1"
        Me.LBLProduct1.Size = New System.Drawing.Size(57, 20)
        Me.LBLProduct1.TabIndex = 2
        Me.LBLProduct1.Text = "Label1"
        '
        'LBLProduct2
        '
        Me.LBLProduct2.AutoSize = True
        Me.LBLProduct2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLProduct2.Location = New System.Drawing.Point(13, 319)
        Me.LBLProduct2.Name = "LBLProduct2"
        Me.LBLProduct2.Size = New System.Drawing.Size(57, 20)
        Me.LBLProduct2.TabIndex = 3
        Me.LBLProduct2.Text = "Label1"
        '
        'LBLProduct1Price
        '
        Me.LBLProduct1Price.AutoSize = True
        Me.LBLProduct1Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLProduct1Price.Location = New System.Drawing.Point(332, 289)
        Me.LBLProduct1Price.Name = "LBLProduct1Price"
        Me.LBLProduct1Price.Size = New System.Drawing.Size(57, 20)
        Me.LBLProduct1Price.TabIndex = 4
        Me.LBLProduct1Price.Text = "Label1"
        '
        'LBLProductPrice
        '
        Me.LBLProductPrice.AutoSize = True
        Me.LBLProductPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLProductPrice.Location = New System.Drawing.Point(332, 319)
        Me.LBLProductPrice.Name = "LBLProductPrice"
        Me.LBLProductPrice.Size = New System.Drawing.Size(57, 20)
        Me.LBLProductPrice.TabIndex = 5
        Me.LBLProductPrice.Text = "Label1"
        '
        'LBlTotalPrice
        '
        Me.LBlTotalPrice.AutoSize = True
        Me.LBlTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBlTotalPrice.Location = New System.Drawing.Point(332, 352)
        Me.LBlTotalPrice.Name = "LBlTotalPrice"
        Me.LBlTotalPrice.Size = New System.Drawing.Size(57, 20)
        Me.LBlTotalPrice.TabIndex = 6
        Me.LBlTotalPrice.Text = "Label1"
        '
        'LBLQuantity2
        '
        Me.LBLQuantity2.AutoSize = True
        Me.LBLQuantity2.Location = New System.Drawing.Point(7, 339)
        Me.LBLQuantity2.Name = "LBLQuantity2"
        Me.LBLQuantity2.Size = New System.Drawing.Size(382, 13)
        Me.LBLQuantity2.TabIndex = 7
        Me.LBLQuantity2.Text = "---------------------------------------------------------------------------------" &
    "--------------------------------------------"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(245, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "       To:"
        '
        'LBLName
        '
        Me.LBLName.AutoSize = True
        Me.LBLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLName.Location = New System.Drawing.Point(206, 28)
        Me.LBLName.Name = "LBLName"
        Me.LBLName.Size = New System.Drawing.Size(68, 16)
        Me.LBLName.TabIndex = 9
        Me.LBLName.Text = "LBLName"
        '
        'LBLTelNo
        '
        Me.LBLTelNo.AutoSize = True
        Me.LBLTelNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTelNo.Location = New System.Drawing.Point(206, 48)
        Me.LBLTelNo.Name = "LBLTelNo"
        Me.LBLTelNo.Size = New System.Drawing.Size(49, 16)
        Me.LBLTelNo.TabIndex = 10
        Me.LBLTelNo.Text = "Label1"
        '
        'LBLEmail
        '
        Me.LBLEmail.AutoSize = True
        Me.LBLEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLEmail.Location = New System.Drawing.Point(206, 68)
        Me.LBLEmail.Name = "LBLEmail"
        Me.LBLEmail.Size = New System.Drawing.Size(49, 16)
        Me.LBLEmail.TabIndex = 11
        Me.LBLEmail.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 12
        '
        'LBLProduct
        '
        Me.LBLProduct.AutoSize = True
        Me.LBLProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLProduct.Location = New System.Drawing.Point(13, 256)
        Me.LBLProduct.Name = "LBLProduct"
        Me.LBLProduct.Size = New System.Drawing.Size(71, 20)
        Me.LBLProduct.TabIndex = 13
        Me.LBLProduct.Text = "Product"
        '
        'LBLPrice
        '
        Me.LBLPrice.AutoSize = True
        Me.LBLPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPrice.Location = New System.Drawing.Point(332, 256)
        Me.LBLPrice.Name = "LBLPrice"
        Me.LBLPrice.Size = New System.Drawing.Size(49, 20)
        Me.LBLPrice.TabIndex = 14
        Me.LBLPrice.Text = "Price"
        '
        'BTNPrint
        '
        Me.BTNPrint.Location = New System.Drawing.Point(125, 509)
        Me.BTNPrint.Name = "BTNPrint"
        Me.BTNPrint.Size = New System.Drawing.Size(75, 23)
        Me.BTNPrint.TabIndex = 16
        Me.BTNPrint.Text = "Print"
        Me.BTNPrint.UseVisualStyleBackColor = True
        '
        'LBLLeagalities
        '
        Me.LBLLeagalities.AutoSize = True
        Me.LBLLeagalities.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLLeagalities.Location = New System.Drawing.Point(7, 409)
        Me.LBLLeagalities.Name = "LBLLeagalities"
        Me.LBLLeagalities.Size = New System.Drawing.Size(350, 78)
        Me.LBLLeagalities.TabIndex = 17
        Me.LBLLeagalities.Text = resources.GetString("LBLLeagalities.Text")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(179, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Quantity"
        '
        'LBLQuantity1
        '
        Me.LBLQuantity1.AutoSize = True
        Me.LBLQuantity1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLQuantity1.Location = New System.Drawing.Point(179, 289)
        Me.LBLQuantity1.Name = "LBLQuantity1"
        Me.LBLQuantity1.Size = New System.Drawing.Size(57, 20)
        Me.LBLQuantity1.TabIndex = 20
        Me.LBLQuantity1.Text = "Label1"
        '
        'LBLquanttity2
        '
        Me.LBLquanttity2.AutoSize = True
        Me.LBLquanttity2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLquanttity2.Location = New System.Drawing.Point(179, 319)
        Me.LBLquanttity2.Name = "LBLquanttity2"
        Me.LBLquanttity2.Size = New System.Drawing.Size(57, 20)
        Me.LBLquanttity2.TabIndex = 21
        Me.LBLquanttity2.Text = "Label1"
        '
        'LBLBillings
        '
        Me.LBLBillings.AutoSize = True
        Me.LBLBillings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBillings.Location = New System.Drawing.Point(12, 155)
        Me.LBLBillings.Name = "LBLBillings"
        Me.LBLBillings.Size = New System.Drawing.Size(328, 48)
        Me.LBLBillings.TabIndex = 22
        Me.LBLBillings.Text = "Bill to:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Organic and me " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Unit 9, 50 James Road Tyseley, Birmingham, B11 2BA"
        '
        'LBLDate
        '
        Me.LBLDate.AutoSize = True
        Me.LBLDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDate.Location = New System.Drawing.Point(12, 139)
        Me.LBLDate.Name = "LBLDate"
        Me.LBLDate.Size = New System.Drawing.Size(49, 16)
        Me.LBLDate.TabIndex = 23
        Me.LBLDate.Text = "Label1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 273)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(382, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "---------------------------------------------------------------------------------" &
    "--------------------------------------------"
        '
        'Printform
        '
        Me.Printform.DocumentName = "document"
        Me.Printform.Form = Me
        Me.Printform.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.Printform.PrinterSettings = CType(resources.GetObject("Printform.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.Printform.PrintFileName = Nothing
        '
        'Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 544)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LBLDate)
        Me.Controls.Add(Me.LBLBillings)
        Me.Controls.Add(Me.LBLquanttity2)
        Me.Controls.Add(Me.LBLQuantity1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LBLLeagalities)
        Me.Controls.Add(Me.BTNPrint)
        Me.Controls.Add(Me.LBLPrice)
        Me.Controls.Add(Me.LBLProduct)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LBLEmail)
        Me.Controls.Add(Me.LBLTelNo)
        Me.Controls.Add(Me.LBLName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBLQuantity2)
        Me.Controls.Add(Me.LBlTotalPrice)
        Me.Controls.Add(Me.LBLProductPrice)
        Me.Controls.Add(Me.LBLProduct1Price)
        Me.Controls.Add(Me.LBLProduct2)
        Me.Controls.Add(Me.LBLProduct1)
        Me.Controls.Add(Me.LBLOrderID)
        Me.Controls.Add(Me.LBLDetails)
        Me.Name = "Invoice"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLDetails As Label
    Friend WithEvents LBLOrderID As Label
    Friend WithEvents LBLProduct1 As Label
    Friend WithEvents LBLProduct2 As Label
    Friend WithEvents LBLProduct1Price As Label
    Friend WithEvents LBLProductPrice As Label
    Friend WithEvents LBlTotalPrice As Label
    Friend WithEvents LBLQuantity2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LBLName As Label
    Friend WithEvents LBLTelNo As Label
    Friend WithEvents LBLEmail As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LBLProduct As Label
    Friend WithEvents LBLPrice As Label
    Friend WithEvents BTNPrint As Button
    Friend WithEvents LBLLeagalities As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LBLQuantity1 As Label
    Friend WithEvents LBLquanttity2 As Label
    Friend WithEvents LBLBillings As Label
    Friend WithEvents LBLDate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Printform As PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class

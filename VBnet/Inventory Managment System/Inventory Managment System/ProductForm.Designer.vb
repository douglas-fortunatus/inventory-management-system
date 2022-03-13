<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbCategory = New System.Windows.Forms.ComboBox()
        Me.cbWeight = New System.Windows.Forms.ComboBox()
        Me.inpUnitPrice = New System.Windows.Forms.TextBox()
        Me.inpProductName = New System.Windows.Forms.TextBox()
        Me.inpProductCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ViewProduct = New System.Windows.Forms.Button()
        Me.EditProduct = New System.Windows.Forms.Button()
        Me.SaveProduct = New System.Windows.Forms.Button()
        Me.NewProeduct = New System.Windows.Forms.Button()
        Me.DeleteProduct = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.cbCategory)
        Me.GroupBox1.Controls.Add(Me.cbWeight)
        Me.GroupBox1.Controls.Add(Me.inpUnitPrice)
        Me.GroupBox1.Controls.Add(Me.inpProductName)
        Me.GroupBox1.Controls.Add(Me.inpProductCode)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 218)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Details"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(570, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(102, 218)
        Me.Panel1.TabIndex = 1
        '
        'cbCategory
        '
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Location = New System.Drawing.Point(167, 99)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(198, 21)
        Me.cbCategory.TabIndex = 9
        '
        'cbWeight
        '
        Me.cbWeight.FormattingEnabled = True
        Me.cbWeight.Location = New System.Drawing.Point(167, 137)
        Me.cbWeight.Name = "cbWeight"
        Me.cbWeight.Size = New System.Drawing.Size(198, 21)
        Me.cbWeight.TabIndex = 8
        '
        'inpUnitPrice
        '
        Me.inpUnitPrice.Location = New System.Drawing.Point(167, 176)
        Me.inpUnitPrice.Name = "inpUnitPrice"
        Me.inpUnitPrice.Size = New System.Drawing.Size(141, 20)
        Me.inpUnitPrice.TabIndex = 7
        '
        'inpProductName
        '
        Me.inpProductName.Location = New System.Drawing.Point(167, 65)
        Me.inpProductName.Name = "inpProductName"
        Me.inpProductName.Size = New System.Drawing.Size(252, 20)
        Me.inpProductName.TabIndex = 6
        '
        'inpProductCode
        '
        Me.inpProductCode.BackColor = System.Drawing.SystemColors.Control
        Me.inpProductCode.Location = New System.Drawing.Point(167, 33)
        Me.inpProductCode.Name = "inpProductCode"
        Me.inpProductCode.Size = New System.Drawing.Size(132, 20)
        Me.inpProductCode.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Unit Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Weight"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Code"
        '
        'ViewProduct
        '
        Me.ViewProduct.Location = New System.Drawing.Point(619, 40)
        Me.ViewProduct.Name = "ViewProduct"
        Me.ViewProduct.Size = New System.Drawing.Size(75, 29)
        Me.ViewProduct.TabIndex = 0
        Me.ViewProduct.Text = "&View"
        Me.ViewProduct.UseVisualStyleBackColor = True
        '
        'EditProduct
        '
        Me.EditProduct.Location = New System.Drawing.Point(619, 144)
        Me.EditProduct.Name = "EditProduct"
        Me.EditProduct.Size = New System.Drawing.Size(75, 29)
        Me.EditProduct.TabIndex = 1
        Me.EditProduct.Text = "&Edit"
        Me.EditProduct.UseVisualStyleBackColor = True
        '
        'SaveProduct
        '
        Me.SaveProduct.Location = New System.Drawing.Point(619, 110)
        Me.SaveProduct.Name = "SaveProduct"
        Me.SaveProduct.Size = New System.Drawing.Size(75, 29)
        Me.SaveProduct.TabIndex = 2
        Me.SaveProduct.Text = "&Save"
        Me.SaveProduct.UseVisualStyleBackColor = True
        '
        'NewProeduct
        '
        Me.NewProeduct.Location = New System.Drawing.Point(619, 75)
        Me.NewProeduct.Name = "NewProeduct"
        Me.NewProeduct.Size = New System.Drawing.Size(75, 29)
        Me.NewProeduct.TabIndex = 3
        Me.NewProeduct.Text = "&New"
        Me.NewProeduct.UseVisualStyleBackColor = True
        '
        'DeleteProduct
        '
        Me.DeleteProduct.Location = New System.Drawing.Point(619, 183)
        Me.DeleteProduct.Name = "DeleteProduct"
        Me.DeleteProduct.Size = New System.Drawing.Size(75, 29)
        Me.DeleteProduct.TabIndex = 4
        Me.DeleteProduct.Text = "&Delete"
        Me.DeleteProduct.UseVisualStyleBackColor = True
        '
        'ProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(767, 269)
        Me.Controls.Add(Me.DeleteProduct)
        Me.Controls.Add(Me.NewProeduct)
        Me.Controls.Add(Me.SaveProduct)
        Me.Controls.Add(Me.EditProduct)
        Me.Controls.Add(Me.ViewProduct)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ProductForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbCategory As ComboBox
    Friend WithEvents cbWeight As ComboBox
    Friend WithEvents inpUnitPrice As TextBox
    Friend WithEvents inpProductName As TextBox
    Friend WithEvents inpProductCode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ViewProduct As Button
    Friend WithEvents EditProduct As Button
    Friend WithEvents SaveProduct As Button
    Friend WithEvents NewProeduct As Button
    Friend WithEvents DeleteProduct As Button
End Class

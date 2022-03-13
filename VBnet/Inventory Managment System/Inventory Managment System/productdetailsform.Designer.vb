<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productdetailsform
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
        Me.TabsBody = New System.Windows.Forms.TabControl()
        Me.AllProducts = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabBody = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Resetbtn = New System.Windows.Forms.Button()
        Me.inpSearchP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbPName = New System.Windows.Forms.ComboBox()
        Me.ProductWeight = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Resetbtn2 = New System.Windows.Forms.Button()
        Me.cbProductWeight = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProductCategory = New System.Windows.Forms.TabPage()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbpCategory = New System.Windows.Forms.ComboBox()
        Me.Resetbtn3 = New System.Windows.Forms.Button()
        Me.TabsBody.SuspendLayout()
        Me.AllProducts.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabBody.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.ProductWeight.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.ProductCategory.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabsBody
        '
        Me.TabsBody.Controls.Add(Me.AllProducts)
        Me.TabsBody.Controls.Add(Me.TabBody)
        Me.TabsBody.Controls.Add(Me.ProductWeight)
        Me.TabsBody.Controls.Add(Me.ProductCategory)
        Me.TabsBody.Location = New System.Drawing.Point(9, 7)
        Me.TabsBody.Name = "TabsBody"
        Me.TabsBody.SelectedIndex = 0
        Me.TabsBody.Size = New System.Drawing.Size(842, 604)
        Me.TabsBody.TabIndex = 0
        '
        'AllProducts
        '
        Me.AllProducts.BackColor = System.Drawing.Color.WhiteSmoke
        Me.AllProducts.Controls.Add(Me.DataGridView1)
        Me.AllProducts.Controls.Add(Me.GroupBox1)
        Me.AllProducts.Location = New System.Drawing.Point(4, 22)
        Me.AllProducts.Name = "AllProducts"
        Me.AllProducts.Padding = New System.Windows.Forms.Padding(3)
        Me.AllProducts.Size = New System.Drawing.Size(834, 578)
        Me.AllProducts.TabIndex = 0
        Me.AllProducts.Text = "All Products"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(815, 498)
        Me.DataGridView1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(815, 63)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(692, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 46)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Get Data"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabBody
        '
        Me.TabBody.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabBody.Controls.Add(Me.DataGridView2)
        Me.TabBody.Controls.Add(Me.GroupBox3)
        Me.TabBody.Location = New System.Drawing.Point(4, 22)
        Me.TabBody.Name = "TabBody"
        Me.TabBody.Padding = New System.Windows.Forms.Padding(3)
        Me.TabBody.Size = New System.Drawing.Size(834, 578)
        Me.TabBody.TabIndex = 1
        Me.TabBody.Text = "Product by name"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(9, 77)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(815, 498)
        Me.DataGridView2.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Resetbtn)
        Me.GroupBox3.Controls.Add(Me.inpSearchP)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.cbPName)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(815, 63)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'Resetbtn
        '
        Me.Resetbtn.Location = New System.Drawing.Point(687, 11)
        Me.Resetbtn.Name = "Resetbtn"
        Me.Resetbtn.Size = New System.Drawing.Size(96, 42)
        Me.Resetbtn.TabIndex = 4
        Me.Resetbtn.Text = "&Reset"
        Me.Resetbtn.UseVisualStyleBackColor = True
        '
        'inpSearchP
        '
        Me.inpSearchP.Location = New System.Drawing.Point(368, 31)
        Me.inpSearchP.Name = "inpSearchP"
        Me.inpSearchP.Size = New System.Drawing.Size(236, 20)
        Me.inpSearchP.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(377, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search Product"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product Name"
        '
        'cbPName
        '
        Me.cbPName.FormattingEnabled = True
        Me.cbPName.Location = New System.Drawing.Point(32, 30)
        Me.cbPName.Name = "cbPName"
        Me.cbPName.Size = New System.Drawing.Size(196, 21)
        Me.cbPName.TabIndex = 0
        '
        'ProductWeight
        '
        Me.ProductWeight.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ProductWeight.Controls.Add(Me.DataGridView3)
        Me.ProductWeight.Controls.Add(Me.GroupBox4)
        Me.ProductWeight.Location = New System.Drawing.Point(4, 22)
        Me.ProductWeight.Name = "ProductWeight"
        Me.ProductWeight.Padding = New System.Windows.Forms.Padding(3)
        Me.ProductWeight.Size = New System.Drawing.Size(834, 578)
        Me.ProductWeight.TabIndex = 2
        Me.ProductWeight.Text = "Product by weight"
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(9, 77)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(815, 498)
        Me.DataGridView3.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Resetbtn2)
        Me.GroupBox4.Controls.Add(Me.cbProductWeight)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(821, 63)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'Resetbtn2
        '
        Me.Resetbtn2.Location = New System.Drawing.Point(657, 14)
        Me.Resetbtn2.Name = "Resetbtn2"
        Me.Resetbtn2.Size = New System.Drawing.Size(127, 43)
        Me.Resetbtn2.TabIndex = 2
        Me.Resetbtn2.Text = "&Reset"
        Me.Resetbtn2.UseVisualStyleBackColor = True
        '
        'cbProductWeight
        '
        Me.cbProductWeight.FormattingEnabled = True
        Me.cbProductWeight.Location = New System.Drawing.Point(61, 36)
        Me.cbProductWeight.Name = "cbProductWeight"
        Me.cbProductWeight.Size = New System.Drawing.Size(216, 21)
        Me.cbProductWeight.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Product Weight"
        '
        'ProductCategory
        '
        Me.ProductCategory.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ProductCategory.Controls.Add(Me.DataGridView4)
        Me.ProductCategory.Controls.Add(Me.GroupBox2)
        Me.ProductCategory.Location = New System.Drawing.Point(4, 22)
        Me.ProductCategory.Name = "ProductCategory"
        Me.ProductCategory.Padding = New System.Windows.Forms.Padding(3)
        Me.ProductCategory.Size = New System.Drawing.Size(834, 578)
        Me.ProductCategory.TabIndex = 3
        Me.ProductCategory.Text = "Product by Category"
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(9, 77)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(815, 498)
        Me.DataGridView4.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cbpCategory)
        Me.GroupBox2.Controls.Add(Me.Resetbtn3)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(821, 63)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Product Category"
        '
        'cbpCategory
        '
        Me.cbpCategory.FormattingEnabled = True
        Me.cbpCategory.Location = New System.Drawing.Point(76, 32)
        Me.cbpCategory.Name = "cbpCategory"
        Me.cbpCategory.Size = New System.Drawing.Size(221, 21)
        Me.cbpCategory.TabIndex = 1
        '
        'Resetbtn3
        '
        Me.Resetbtn3.Location = New System.Drawing.Point(572, 16)
        Me.Resetbtn3.Name = "Resetbtn3"
        Me.Resetbtn3.Size = New System.Drawing.Size(100, 41)
        Me.Resetbtn3.TabIndex = 0
        Me.Resetbtn3.Text = "&Reset"
        Me.Resetbtn3.UseVisualStyleBackColor = True
        '
        'productdetailsform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(840, 601)
        Me.Controls.Add(Me.TabsBody)
        Me.Name = "productdetailsform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Details"
        Me.TabsBody.ResumeLayout(False)
        Me.AllProducts.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabBody.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ProductWeight.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ProductCategory.ResumeLayout(False)
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabsBody As TabControl
    Friend WithEvents AllProducts As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TabBody As TabPage
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Resetbtn As Button
    Friend WithEvents inpSearchP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbPName As ComboBox
    Friend WithEvents ProductWeight As TabPage
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Resetbtn2 As Button
    Friend WithEvents cbProductWeight As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ProductCategory As TabPage
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbpCategory As ComboBox
    Friend WithEvents Resetbtn3 As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inveCategoryForm
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
        Me.inpCtgryName = New System.Windows.Forms.TextBox()
        Me.inpCtgryID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.View_category = New System.Windows.Forms.Button()
        Me.Save_category = New System.Windows.Forms.Button()
        Me.Update_categoty = New System.Windows.Forms.Button()
        Me.Delete_category = New System.Windows.Forms.Button()
        Me.new_category = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.inpCtgryName)
        Me.GroupBox1.Controls.Add(Me.inpCtgryID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 122)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Category Form"
        '
        'inpCtgryName
        '
        Me.inpCtgryName.Location = New System.Drawing.Point(153, 78)
        Me.inpCtgryName.Name = "inpCtgryName"
        Me.inpCtgryName.Size = New System.Drawing.Size(178, 20)
        Me.inpCtgryName.TabIndex = 53
        '
        'inpCtgryID
        '
        Me.inpCtgryID.BackColor = System.Drawing.SystemColors.Control
        Me.inpCtgryID.Location = New System.Drawing.Point(153, 31)
        Me.inpCtgryID.Name = "inpCtgryID"
        Me.inpCtgryID.Size = New System.Drawing.Size(141, 20)
        Me.inpCtgryID.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Category Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Category ID"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.View_category)
        Me.Panel1.Controls.Add(Me.Save_category)
        Me.Panel1.Controls.Add(Me.Update_categoty)
        Me.Panel1.Controls.Add(Me.Delete_category)
        Me.Panel1.Controls.Add(Me.new_category)
        Me.Panel1.Location = New System.Drawing.Point(22, 146)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(407, 61)
        Me.Panel1.TabIndex = 1
        '
        'View_category
        '
        Me.View_category.Location = New System.Drawing.Point(323, 15)
        Me.View_category.Name = "View_category"
        Me.View_category.Size = New System.Drawing.Size(72, 31)
        Me.View_category.TabIndex = 4
        Me.View_category.Text = "&View"
        Me.View_category.UseVisualStyleBackColor = True
        '
        'Save_category
        '
        Me.Save_category.Location = New System.Drawing.Point(89, 15)
        Me.Save_category.Name = "Save_category"
        Me.Save_category.Size = New System.Drawing.Size(72, 31)
        Me.Save_category.TabIndex = 3
        Me.Save_category.Text = "&save"
        Me.Save_category.UseVisualStyleBackColor = True
        '
        'Update_categoty
        '
        Me.Update_categoty.Location = New System.Drawing.Point(245, 15)
        Me.Update_categoty.Name = "Update_categoty"
        Me.Update_categoty.Size = New System.Drawing.Size(72, 31)
        Me.Update_categoty.TabIndex = 2
        Me.Update_categoty.Text = "&Update"
        Me.Update_categoty.UseVisualStyleBackColor = True
        '
        'Delete_category
        '
        Me.Delete_category.Location = New System.Drawing.Point(167, 15)
        Me.Delete_category.Name = "Delete_category"
        Me.Delete_category.Size = New System.Drawing.Size(72, 31)
        Me.Delete_category.TabIndex = 1
        Me.Delete_category.Text = "&Delete"
        Me.Delete_category.UseVisualStyleBackColor = True
        '
        'new_category
        '
        Me.new_category.Location = New System.Drawing.Point(13, 13)
        Me.new_category.Name = "new_category"
        Me.new_category.Size = New System.Drawing.Size(72, 31)
        Me.new_category.TabIndex = 0
        Me.new_category.Text = "&New"
        Me.new_category.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(300, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 21)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'inveCategoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(441, 232)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "inveCategoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "inveCategoryForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents inpCtgryName As TextBox
    Friend WithEvents inpCtgryID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents View_category As Button
    Friend WithEvents Save_category As Button
    Friend WithEvents Update_categoty As Button
    Friend WithEvents Delete_category As Button
    Friend WithEvents new_category As Button
    Friend WithEvents Button1 As Button
End Class

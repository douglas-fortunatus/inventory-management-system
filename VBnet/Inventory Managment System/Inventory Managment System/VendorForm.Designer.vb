<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VendorForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.inpVendorID = New System.Windows.Forms.TextBox()
        Me.inpPhone = New System.Windows.Forms.TextBox()
        Me.inpZip = New System.Windows.Forms.TextBox()
        Me.inpCty = New System.Windows.Forms.TextBox()
        Me.inpVendorlandmark = New System.Windows.Forms.TextBox()
        Me.inpVendorAddress = New System.Windows.Forms.TextBox()
        Me.inpVendorName = New System.Windows.Forms.TextBox()
        Me.inpFax = New System.Windows.Forms.TextBox()
        Me.inpMobile = New System.Windows.Forms.TextBox()
        Me.inpEmail = New System.Windows.Forms.TextBox()
        Me.inpNotes = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Update_Record = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.NewRecord = New System.Windows.Forms.Button()
        Me.cbState = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vendor Details"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Vendor ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Landmark"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "City"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "State"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 276)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Zip/Postal Code"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 314)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Phone"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 348)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Email"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(35, 386)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Mobile No"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(35, 424)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Fax No"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(36, 458)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Notes"
        '
        'inpVendorID
        '
        Me.inpVendorID.BackColor = System.Drawing.SystemColors.Control
        Me.inpVendorID.Location = New System.Drawing.Point(165, 70)
        Me.inpVendorID.Name = "inpVendorID"
        Me.inpVendorID.Size = New System.Drawing.Size(189, 20)
        Me.inpVendorID.TabIndex = 13
        '
        'inpPhone
        '
        Me.inpPhone.Location = New System.Drawing.Point(165, 311)
        Me.inpPhone.Name = "inpPhone"
        Me.inpPhone.Size = New System.Drawing.Size(189, 20)
        Me.inpPhone.TabIndex = 14
        '
        'inpZip
        '
        Me.inpZip.Location = New System.Drawing.Point(165, 273)
        Me.inpZip.Name = "inpZip"
        Me.inpZip.Size = New System.Drawing.Size(97, 20)
        Me.inpZip.TabIndex = 15
        '
        'inpCty
        '
        Me.inpCty.Location = New System.Drawing.Point(165, 207)
        Me.inpCty.Name = "inpCty"
        Me.inpCty.Size = New System.Drawing.Size(189, 20)
        Me.inpCty.TabIndex = 17
        '
        'inpVendorlandmark
        '
        Me.inpVendorlandmark.Location = New System.Drawing.Point(165, 174)
        Me.inpVendorlandmark.Name = "inpVendorlandmark"
        Me.inpVendorlandmark.Size = New System.Drawing.Size(273, 20)
        Me.inpVendorlandmark.TabIndex = 18
        '
        'inpVendorAddress
        '
        Me.inpVendorAddress.Location = New System.Drawing.Point(165, 140)
        Me.inpVendorAddress.Name = "inpVendorAddress"
        Me.inpVendorAddress.Size = New System.Drawing.Size(273, 20)
        Me.inpVendorAddress.TabIndex = 19
        '
        'inpVendorName
        '
        Me.inpVendorName.Location = New System.Drawing.Point(165, 105)
        Me.inpVendorName.Name = "inpVendorName"
        Me.inpVendorName.Size = New System.Drawing.Size(273, 20)
        Me.inpVendorName.TabIndex = 20
        '
        'inpFax
        '
        Me.inpFax.Location = New System.Drawing.Point(165, 424)
        Me.inpFax.Name = "inpFax"
        Me.inpFax.Size = New System.Drawing.Size(160, 20)
        Me.inpFax.TabIndex = 21
        '
        'inpMobile
        '
        Me.inpMobile.Location = New System.Drawing.Point(165, 386)
        Me.inpMobile.Name = "inpMobile"
        Me.inpMobile.Size = New System.Drawing.Size(189, 20)
        Me.inpMobile.TabIndex = 22
        '
        'inpEmail
        '
        Me.inpEmail.Location = New System.Drawing.Point(165, 348)
        Me.inpEmail.Name = "inpEmail"
        Me.inpEmail.Size = New System.Drawing.Size(273, 20)
        Me.inpEmail.TabIndex = 23
        '
        'inpNotes
        '
        Me.inpNotes.Location = New System.Drawing.Point(165, 458)
        Me.inpNotes.Multiline = True
        Me.inpNotes.Name = "inpNotes"
        Me.inpNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.inpNotes.Size = New System.Drawing.Size(251, 67)
        Me.inpNotes.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Update_Record)
        Me.GroupBox1.Controls.Add(Me.Delete)
        Me.GroupBox1.Controls.Add(Me.Save)
        Me.GroupBox1.Controls.Add(Me.NewRecord)
        Me.GroupBox1.Location = New System.Drawing.Point(501, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(134, 200)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(16, 19)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(99, 29)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "&View"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Update_Record
        '
        Me.Update_Record.Location = New System.Drawing.Point(16, 121)
        Me.Update_Record.Name = "Update_Record"
        Me.Update_Record.Size = New System.Drawing.Size(99, 29)
        Me.Update_Record.TabIndex = 3
        Me.Update_Record.Text = "&Update"
        Me.Update_Record.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(16, 156)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(99, 29)
        Me.Delete.TabIndex = 2
        Me.Delete.Text = "&Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(16, 86)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(99, 29)
        Me.Save.TabIndex = 1
        Me.Save.Text = "&Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'NewRecord
        '
        Me.NewRecord.Location = New System.Drawing.Point(16, 54)
        Me.NewRecord.Name = "NewRecord"
        Me.NewRecord.Size = New System.Drawing.Size(99, 29)
        Me.NewRecord.TabIndex = 0
        Me.NewRecord.Text = "&New"
        Me.NewRecord.UseVisualStyleBackColor = True
        '
        'cbState
        '
        Me.cbState.FormattingEnabled = True
        Me.cbState.Location = New System.Drawing.Point(165, 241)
        Me.cbState.Name = "cbState"
        Me.cbState.Size = New System.Drawing.Size(207, 21)
        Me.cbState.TabIndex = 26
        '
        'VendorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(651, 575)
        Me.Controls.Add(Me.cbState)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.inpNotes)
        Me.Controls.Add(Me.inpEmail)
        Me.Controls.Add(Me.inpMobile)
        Me.Controls.Add(Me.inpFax)
        Me.Controls.Add(Me.inpVendorName)
        Me.Controls.Add(Me.inpVendorAddress)
        Me.Controls.Add(Me.inpVendorlandmark)
        Me.Controls.Add(Me.inpCty)
        Me.Controls.Add(Me.inpZip)
        Me.Controls.Add(Me.inpPhone)
        Me.Controls.Add(Me.inpVendorID)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "VendorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendor Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents inpVendorID As TextBox
    Friend WithEvents inpPhone As TextBox
    Friend WithEvents inpZip As TextBox
    Friend WithEvents inpCty As TextBox
    Friend WithEvents inpVendorlandmark As TextBox
    Friend WithEvents inpVendorAddress As TextBox
    Friend WithEvents inpVendorName As TextBox
    Friend WithEvents inpFax As TextBox
    Friend WithEvents inpMobile As TextBox
    Friend WithEvents inpEmail As TextBox
    Friend WithEvents inpNotes As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Update_Record As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Save As Button
    Friend WithEvents NewRecord As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents cbState As ComboBox
End Class

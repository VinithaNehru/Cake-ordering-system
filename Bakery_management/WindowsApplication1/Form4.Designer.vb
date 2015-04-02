<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.contact = New System.Windows.Forms.TextBox()
        Me.qty = New System.Windows.Forms.TextBox()
        Me.cname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.address = New System.Windows.Forms.TextBox()
        Me.deldate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.amt = New System.Windows.Forms.TextBox()
        Me.item = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("French Script MT", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Your bill!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("French Script MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("French Script MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(261, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 27)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Quantity (kg) :"
        '
        'contact
        '
        Me.contact.Font = New System.Drawing.Font("French Script MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contact.Location = New System.Drawing.Point(180, 352)
        Me.contact.Name = "contact"
        Me.contact.ReadOnly = True
        Me.contact.Size = New System.Drawing.Size(194, 35)
        Me.contact.TabIndex = 20
        '
        'qty
        '
        Me.qty.Font = New System.Drawing.Font("French Script MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qty.Location = New System.Drawing.Point(249, 183)
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        Me.qty.Size = New System.Drawing.Size(100, 35)
        Me.qty.TabIndex = 19
        '
        'cname
        '
        Me.cname.Font = New System.Drawing.Font("French Script MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cname.Location = New System.Drawing.Point(139, 88)
        Me.cname.Name = "cname"
        Me.cname.ReadOnly = True
        Me.cname.Size = New System.Drawing.Size(111, 35)
        Me.cname.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("French Script MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(73, 354)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 27)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Contact :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("French Script MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(73, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 27)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Address :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("French Script MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 27)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Name :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("French Script MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(297, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 27)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Delivery date :"
        '
        'address
        '
        Me.address.Font = New System.Drawing.Font("French Script MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.Location = New System.Drawing.Point(180, 297)
        Me.address.Multiline = True
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        Me.address.Size = New System.Drawing.Size(279, 36)
        Me.address.TabIndex = 24
        '
        'deldate
        '
        Me.deldate.Font = New System.Drawing.Font("French Script MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deldate.Location = New System.Drawing.Point(433, 85)
        Me.deldate.Name = "deldate"
        Me.deldate.ReadOnly = True
        Me.deldate.Size = New System.Drawing.Size(100, 35)
        Me.deldate.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("French Script MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(430, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 27)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Amount"
        '
        'amt
        '
        Me.amt.Font = New System.Drawing.Font("French Script MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amt.Location = New System.Drawing.Point(416, 183)
        Me.amt.Name = "amt"
        Me.amt.ReadOnly = True
        Me.amt.Size = New System.Drawing.Size(100, 35)
        Me.amt.TabIndex = 27
        '
        'item
        '
        Me.item.Font = New System.Drawing.Font("French Script MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item.Location = New System.Drawing.Point(76, 183)
        Me.item.Name = "item"
        Me.item.ReadOnly = True
        Me.item.Size = New System.Drawing.Size(127, 35)
        Me.item.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("French Script MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(42, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 40)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Finish"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("French Script MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(220, 415)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 40)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Home"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("French Script MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(407, 415)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 40)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "Print"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(577, 466)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.item)
        Me.Controls.Add(Me.amt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.deldate)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.contact)
        Me.Controls.Add(Me.qty)
        Me.Controls.Add(Me.cname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("French Script MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form4"
        Me.Text = "Bill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents contact As System.Windows.Forms.TextBox
    Friend WithEvents qty As System.Windows.Forms.TextBox
    Friend WithEvents cname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents address As System.Windows.Forms.TextBox
    Friend WithEvents deldate As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents amt As System.Windows.Forms.TextBox
    Friend WithEvents item As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class

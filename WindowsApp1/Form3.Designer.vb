<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.nup1 = New System.Windows.Forms.NumericUpDown()
        Me.totalPrice = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb3 = New System.Windows.Forms.RadioButton()
        Me.rb4 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.nup1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Room Size"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number Of Bed"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Price"
        '
        'cb1
        '
        Me.cb1.FormattingEnabled = True
        Me.cb1.Items.AddRange(New Object() {"Small", "Med", "Large"})
        Me.cb1.Location = New System.Drawing.Point(191, 177)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(150, 24)
        Me.cb1.TabIndex = 3
        Me.cb1.Text = "Select Room Size"
        '
        'nup1
        '
        Me.nup1.Location = New System.Drawing.Point(203, 223)
        Me.nup1.Name = "nup1"
        Me.nup1.Size = New System.Drawing.Size(120, 22)
        Me.nup1.TabIndex = 4
        '
        'totalPrice
        '
        Me.totalPrice.Location = New System.Drawing.Point(173, 267)
        Me.totalPrice.Name = "totalPrice"
        Me.totalPrice.ReadOnly = True
        Me.totalPrice.Size = New System.Drawing.Size(150, 22)
        Me.totalPrice.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(37, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "bocked"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb2)
        Me.GroupBox1.Controls.Add(Me.rb1)
        Me.GroupBox1.Location = New System.Drawing.Point(467, 282)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Indoor or outdoor bathroom"
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Location = New System.Drawing.Point(6, 48)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(78, 21)
        Me.rb2.TabIndex = 1
        Me.rb2.TabStop = True
        Me.rb2.Text = "outdoor"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Location = New System.Drawing.Point(6, 21)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(69, 21)
        Me.rb1.TabIndex = 0
        Me.rb1.TabStop = True
        Me.rb1.Text = "indoor"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb3)
        Me.GroupBox2.Controls.Add(Me.rb4)
        Me.GroupBox2.Location = New System.Drawing.Point(467, 397)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 99)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "The view"
        '
        'rb3
        '
        Me.rb3.AutoSize = True
        Me.rb3.Location = New System.Drawing.Point(6, 21)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(107, 21)
        Me.rb3.TabIndex = 1
        Me.rb3.TabStop = True
        Me.rb3.Text = "Normal View"
        Me.rb3.UseVisualStyleBackColor = True
        '
        'rb4
        '
        Me.rb4.AutoSize = True
        Me.rb4.Location = New System.Drawing.Point(6, 48)
        Me.rb4.Name = "rb4"
        Me.rb4.Size = New System.Drawing.Size(112, 21)
        Me.rb4.TabIndex = 0
        Me.rb4.TabStop = True
        Me.rb4.Text = "on the beach"
        Me.rb4.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(271, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(271, 78)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Booking"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ClientSize = New System.Drawing.Size(896, 610)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.totalPrice)
        Me.Controls.Add(Me.nup1)
        Me.Controls.Add(Me.cb1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Name = "Form3"
        Me.Text = "Booking form"
        CType(Me.nup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cb1 As ComboBox
    Friend WithEvents nup1 As NumericUpDown
    Friend WithEvents totalPrice As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rb3 As RadioButton
    Friend WithEvents rb4 As RadioButton
    Friend WithEvents Label4 As Label
End Class

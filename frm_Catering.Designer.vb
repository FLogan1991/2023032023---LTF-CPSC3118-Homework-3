<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Catering
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Catering))
        Me.lbl_Catering = New System.Windows.Forms.Label()
        Me.lbl_StoreName = New System.Windows.Forms.Label()
        Me.lbl_PleasePay = New System.Windows.Forms.Label()
        Me.lbl_Display = New System.Windows.Forms.Label()
        Me.lbl_Loyalty = New System.Windows.Forms.Label()
        Me.txt_Points = New System.Windows.Forms.TextBox()
        Me.pic_Platter = New System.Windows.Forms.PictureBox()
        Me.btn_Calculate = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.box_PlatterSelect = New System.Windows.Forms.GroupBox()
        Me.rad_Fruit = New System.Windows.Forms.RadioButton()
        Me.rad_Sausage = New System.Windows.Forms.RadioButton()
        Me.rad_Veggie = New System.Windows.Forms.RadioButton()
        Me.rad_Wraps = New System.Windows.Forms.RadioButton()
        Me.rad_Cheese = New System.Windows.Forms.RadioButton()
        Me.box_PaymentSelect = New System.Windows.Forms.GroupBox()
        Me.rad_Pickup = New System.Windows.Forms.RadioButton()
        Me.rad_Prepay = New System.Windows.Forms.RadioButton()
        CType(Me.pic_Platter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.box_PlatterSelect.SuspendLayout()
        Me.box_PaymentSelect.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Catering
        '
        Me.lbl_Catering.AutoSize = True
        Me.lbl_Catering.Font = New System.Drawing.Font("Gill Sans MT", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Catering.Location = New System.Drawing.Point(126, 15)
        Me.lbl_Catering.Name = "lbl_Catering"
        Me.lbl_Catering.Size = New System.Drawing.Size(115, 34)
        Me.lbl_Catering.TabIndex = 0
        Me.lbl_Catering.Text = "Catering"
        '
        'lbl_StoreName
        '
        Me.lbl_StoreName.AutoSize = True
        Me.lbl_StoreName.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_StoreName.Location = New System.Drawing.Point(140, 52)
        Me.lbl_StoreName.Name = "lbl_StoreName"
        Me.lbl_StoreName.Size = New System.Drawing.Size(91, 19)
        Me.lbl_StoreName.TabIndex = 1
        Me.lbl_StoreName.Text = "Star Market"
        '
        'lbl_PleasePay
        '
        Me.lbl_PleasePay.AutoSize = True
        Me.lbl_PleasePay.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PleasePay.Location = New System.Drawing.Point(96, 451)
        Me.lbl_PleasePay.Name = "lbl_PleasePay"
        Me.lbl_PleasePay.Size = New System.Drawing.Size(107, 23)
        Me.lbl_PleasePay.TabIndex = 2
        Me.lbl_PleasePay.Text = "Please Pay:"
        '
        'lbl_Display
        '
        Me.lbl_Display.AutoSize = True
        Me.lbl_Display.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Display.Location = New System.Drawing.Point(209, 453)
        Me.lbl_Display.MaximumSize = New System.Drawing.Size(450, 0)
        Me.lbl_Display.Name = "lbl_Display"
        Me.lbl_Display.Size = New System.Drawing.Size(60, 21)
        Me.lbl_Display.TabIndex = 3
        Me.lbl_Display.Text = "Label2"
        '
        'lbl_Loyalty
        '
        Me.lbl_Loyalty.AutoSize = True
        Me.lbl_Loyalty.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Loyalty.Location = New System.Drawing.Point(451, 302)
        Me.lbl_Loyalty.Name = "lbl_Loyalty"
        Me.lbl_Loyalty.Size = New System.Drawing.Size(122, 21)
        Me.lbl_Loyalty.TabIndex = 4
        Me.lbl_Loyalty.Text = "Loyalty Points:"
        '
        'txt_Points
        '
        Me.txt_Points.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Points.Location = New System.Drawing.Point(623, 299)
        Me.txt_Points.Name = "txt_Points"
        Me.txt_Points.Size = New System.Drawing.Size(47, 28)
        Me.txt_Points.TabIndex = 5
        '
        'pic_Platter
        '
        Me.pic_Platter.Image = CType(resources.GetObject("pic_Platter.Image"), System.Drawing.Image)
        Me.pic_Platter.Location = New System.Drawing.Point(388, 12)
        Me.pic_Platter.Name = "pic_Platter"
        Me.pic_Platter.Size = New System.Drawing.Size(400, 278)
        Me.pic_Platter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Platter.TabIndex = 6
        Me.pic_Platter.TabStop = False
        '
        'btn_Calculate
        '
        Me.btn_Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Calculate.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Calculate.Location = New System.Drawing.Point(434, 356)
        Me.btn_Calculate.Name = "btn_Calculate"
        Me.btn_Calculate.Size = New System.Drawing.Size(102, 33)
        Me.btn_Calculate.TabIndex = 7
        Me.btn_Calculate.Text = "Calculate"
        Me.btn_Calculate.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Clear.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.Location = New System.Drawing.Point(597, 356)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(102, 33)
        Me.btn_Clear.TabIndex = 8
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'box_PlatterSelect
        '
        Me.box_PlatterSelect.BackColor = System.Drawing.Color.MistyRose
        Me.box_PlatterSelect.Controls.Add(Me.rad_Fruit)
        Me.box_PlatterSelect.Controls.Add(Me.rad_Sausage)
        Me.box_PlatterSelect.Controls.Add(Me.rad_Veggie)
        Me.box_PlatterSelect.Controls.Add(Me.rad_Wraps)
        Me.box_PlatterSelect.Controls.Add(Me.rad_Cheese)
        Me.box_PlatterSelect.Location = New System.Drawing.Point(31, 85)
        Me.box_PlatterSelect.Name = "box_PlatterSelect"
        Me.box_PlatterSelect.Size = New System.Drawing.Size(321, 205)
        Me.box_PlatterSelect.TabIndex = 9
        Me.box_PlatterSelect.TabStop = False
        '
        'rad_Fruit
        '
        Me.rad_Fruit.AutoSize = True
        Me.rad_Fruit.Font = New System.Drawing.Font("Book Antiqua", 11.25!)
        Me.rad_Fruit.Location = New System.Drawing.Point(23, 152)
        Me.rad_Fruit.Name = "rad_Fruit"
        Me.rad_Fruit.Size = New System.Drawing.Size(107, 24)
        Me.rad_Fruit.TabIndex = 4
        Me.rad_Fruit.TabStop = True
        Me.rad_Fruit.Text = "Fruit $29.99"
        Me.rad_Fruit.UseVisualStyleBackColor = True
        '
        'rad_Sausage
        '
        Me.rad_Sausage.AutoSize = True
        Me.rad_Sausage.Font = New System.Drawing.Font("Book Antiqua", 11.25!)
        Me.rad_Sausage.Location = New System.Drawing.Point(23, 118)
        Me.rad_Sausage.Name = "rad_Sausage"
        Me.rad_Sausage.Size = New System.Drawing.Size(210, 24)
        Me.rad_Sausage.TabIndex = 3
        Me.rad_Sausage.TabStop = True
        Me.rad_Sausage.Text = "Sausage and Cheese $49.99"
        Me.rad_Sausage.UseVisualStyleBackColor = True
        '
        'rad_Veggie
        '
        Me.rad_Veggie.AutoSize = True
        Me.rad_Veggie.Font = New System.Drawing.Font("Book Antiqua", 11.25!)
        Me.rad_Veggie.Location = New System.Drawing.Point(23, 85)
        Me.rad_Veggie.Name = "rad_Veggie"
        Me.rad_Veggie.Size = New System.Drawing.Size(120, 24)
        Me.rad_Veggie.TabIndex = 2
        Me.rad_Veggie.TabStop = True
        Me.rad_Veggie.Text = "Veggie $29.99"
        Me.rad_Veggie.UseVisualStyleBackColor = True
        '
        'rad_Wraps
        '
        Me.rad_Wraps.AutoSize = True
        Me.rad_Wraps.Font = New System.Drawing.Font("Book Antiqua", 11.25!)
        Me.rad_Wraps.Location = New System.Drawing.Point(23, 52)
        Me.rad_Wraps.Name = "rad_Wraps"
        Me.rad_Wraps.Size = New System.Drawing.Size(185, 24)
        Me.rad_Wraps.TabIndex = 1
        Me.rad_Wraps.TabStop = True
        Me.rad_Wraps.Text = "Pinwheel Wraps $59.99"
        Me.rad_Wraps.UseVisualStyleBackColor = True
        '
        'rad_Cheese
        '
        Me.rad_Cheese.AutoSize = True
        Me.rad_Cheese.Font = New System.Drawing.Font("Book Antiqua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_Cheese.Location = New System.Drawing.Point(23, 20)
        Me.rad_Cheese.Name = "rad_Cheese"
        Me.rad_Cheese.Size = New System.Drawing.Size(185, 24)
        Me.rad_Cheese.TabIndex = 0
        Me.rad_Cheese.TabStop = True
        Me.rad_Cheese.Text = "Gourmet Cheese $49.99"
        Me.rad_Cheese.UseVisualStyleBackColor = True
        '
        'box_PaymentSelect
        '
        Me.box_PaymentSelect.BackColor = System.Drawing.Color.MistyRose
        Me.box_PaymentSelect.Controls.Add(Me.rad_Pickup)
        Me.box_PaymentSelect.Controls.Add(Me.rad_Prepay)
        Me.box_PaymentSelect.Location = New System.Drawing.Point(100, 310)
        Me.box_PaymentSelect.Name = "box_PaymentSelect"
        Me.box_PaymentSelect.Size = New System.Drawing.Size(200, 100)
        Me.box_PaymentSelect.TabIndex = 10
        Me.box_PaymentSelect.TabStop = False
        '
        'rad_Pickup
        '
        Me.rad_Pickup.AutoSize = True
        Me.rad_Pickup.Font = New System.Drawing.Font("Book Antiqua", 11.25!)
        Me.rad_Pickup.Location = New System.Drawing.Point(20, 55)
        Me.rad_Pickup.Name = "rad_Pickup"
        Me.rad_Pickup.Size = New System.Drawing.Size(141, 24)
        Me.rad_Pickup.TabIndex = 1
        Me.rad_Pickup.TabStop = True
        Me.rad_Pickup.Text = "Pay upon Pickup"
        Me.rad_Pickup.UseVisualStyleBackColor = True
        '
        'rad_Prepay
        '
        Me.rad_Prepay.AutoSize = True
        Me.rad_Prepay.Font = New System.Drawing.Font("Book Antiqua", 11.25!)
        Me.rad_Prepay.Location = New System.Drawing.Point(20, 20)
        Me.rad_Prepay.Name = "rad_Prepay"
        Me.rad_Prepay.Size = New System.Drawing.Size(79, 24)
        Me.rad_Prepay.TabIndex = 0
        Me.rad_Prepay.TabStop = True
        Me.rad_Prepay.Text = "Pre-Pay"
        Me.rad_Prepay.UseVisualStyleBackColor = True
        '
        'frm_Catering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.ClientSize = New System.Drawing.Size(800, 532)
        Me.Controls.Add(Me.box_PaymentSelect)
        Me.Controls.Add(Me.box_PlatterSelect)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Calculate)
        Me.Controls.Add(Me.pic_Platter)
        Me.Controls.Add(Me.txt_Points)
        Me.Controls.Add(Me.lbl_Loyalty)
        Me.Controls.Add(Me.lbl_Display)
        Me.Controls.Add(Me.lbl_PleasePay)
        Me.Controls.Add(Me.lbl_StoreName)
        Me.Controls.Add(Me.lbl_Catering)
        Me.Name = "frm_Catering"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catering"
        CType(Me.pic_Platter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.box_PlatterSelect.ResumeLayout(False)
        Me.box_PlatterSelect.PerformLayout()
        Me.box_PaymentSelect.ResumeLayout(False)
        Me.box_PaymentSelect.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Catering As Label
    Friend WithEvents lbl_StoreName As Label
    Friend WithEvents lbl_PleasePay As Label
    Friend WithEvents lbl_Display As Label
    Friend WithEvents lbl_Loyalty As Label
    Friend WithEvents txt_Points As TextBox
    Friend WithEvents pic_Platter As PictureBox
    Friend WithEvents btn_Calculate As Button
    Friend WithEvents btn_Clear As Button
    Friend WithEvents box_PlatterSelect As GroupBox
    Friend WithEvents rad_Fruit As RadioButton
    Friend WithEvents rad_Sausage As RadioButton
    Friend WithEvents rad_Veggie As RadioButton
    Friend WithEvents rad_Wraps As RadioButton
    Friend WithEvents rad_Cheese As RadioButton
    Friend WithEvents box_PaymentSelect As GroupBox
    Friend WithEvents rad_Pickup As RadioButton
    Friend WithEvents rad_Prepay As RadioButton
End Class

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
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.txb_password = New System.Windows.Forms.TextBox()
        Me.btn_register = New System.Windows.Forms.Button()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.txb_username = New System.Windows.Forms.TextBox()
        Me.txb_carID = New System.Windows.Forms.TextBox()
        Me.Txb_carPower = New System.Windows.Forms.TextBox()
        Me.txb_price = New System.Windows.Forms.TextBox()
        Me.txb_productionYear = New System.Windows.Forms.TextBox()
        Me.Txb_manual_automatic = New System.Windows.Forms.TextBox()
        Me.txb_fuel = New System.Windows.Forms.TextBox()
        Me.txb_carType = New System.Windows.Forms.TextBox()
        Me.txb_kilometers = New System.Windows.Forms.TextBox()
        Me.lbl_carID = New System.Windows.Forms.Label()
        Me.lbl_carType = New System.Windows.Forms.Label()
        Me.lbl_manual_automatic = New System.Windows.Forms.Label()
        Me.lbl_carPower = New System.Windows.Forms.Label()
        Me.lbl_kilometers = New System.Windows.Forms.Label()
        Me.lbl_fuel = New System.Windows.Forms.Label()
        Me.lbl_productionYear = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.btn_registerCar = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.BackColor = System.Drawing.Color.Moccasin
        Me.lbl_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(37, 57)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(61, 13)
        Me.lbl_username.TabIndex = 9
        Me.lbl_username.Text = "username"
        '
        'txb_password
        '
        Me.txb_password.Location = New System.Drawing.Point(108, 149)
        Me.txb_password.Name = "txb_password"
        Me.txb_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txb_password.Size = New System.Drawing.Size(100, 20)
        Me.txb_password.TabIndex = 8
        '
        'btn_register
        '
        Me.btn_register.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_register.Location = New System.Drawing.Point(40, 279)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(109, 35)
        Me.btn_register.TabIndex = 12
        Me.btn_register.Text = "register new admin"
        Me.btn_register.UseVisualStyleBackColor = True
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password.Location = New System.Drawing.Point(37, 152)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(60, 13)
        Me.lbl_password.TabIndex = 10
        Me.lbl_password.Text = "password"
        '
        'txb_username
        '
        Me.txb_username.Location = New System.Drawing.Point(108, 54)
        Me.txb_username.Name = "txb_username"
        Me.txb_username.Size = New System.Drawing.Size(100, 20)
        Me.txb_username.TabIndex = 11
        '
        'txb_carID
        '
        Me.txb_carID.Location = New System.Drawing.Point(392, 33)
        Me.txb_carID.Name = "txb_carID"
        Me.txb_carID.Size = New System.Drawing.Size(100, 20)
        Me.txb_carID.TabIndex = 13
        '
        'Txb_carPower
        '
        Me.Txb_carPower.Location = New System.Drawing.Point(392, 200)
        Me.Txb_carPower.Name = "Txb_carPower"
        Me.Txb_carPower.Size = New System.Drawing.Size(100, 20)
        Me.Txb_carPower.TabIndex = 14
        '
        'txb_price
        '
        Me.txb_price.Location = New System.Drawing.Point(611, 200)
        Me.txb_price.Name = "txb_price"
        Me.txb_price.Size = New System.Drawing.Size(100, 20)
        Me.txb_price.TabIndex = 15
        '
        'txb_productionYear
        '
        Me.txb_productionYear.Location = New System.Drawing.Point(611, 146)
        Me.txb_productionYear.Name = "txb_productionYear"
        Me.txb_productionYear.Size = New System.Drawing.Size(100, 20)
        Me.txb_productionYear.TabIndex = 16
        '
        'Txb_manual_automatic
        '
        Me.Txb_manual_automatic.Location = New System.Drawing.Point(392, 146)
        Me.Txb_manual_automatic.Name = "Txb_manual_automatic"
        Me.Txb_manual_automatic.Size = New System.Drawing.Size(100, 20)
        Me.Txb_manual_automatic.TabIndex = 17
        '
        'txb_fuel
        '
        Me.txb_fuel.Location = New System.Drawing.Point(611, 88)
        Me.txb_fuel.Name = "txb_fuel"
        Me.txb_fuel.Size = New System.Drawing.Size(100, 20)
        Me.txb_fuel.TabIndex = 18
        '
        'txb_carType
        '
        Me.txb_carType.Location = New System.Drawing.Point(392, 88)
        Me.txb_carType.Name = "txb_carType"
        Me.txb_carType.Size = New System.Drawing.Size(100, 20)
        Me.txb_carType.TabIndex = 19
        '
        'txb_kilometers
        '
        Me.txb_kilometers.Location = New System.Drawing.Point(611, 33)
        Me.txb_kilometers.Name = "txb_kilometers"
        Me.txb_kilometers.Size = New System.Drawing.Size(100, 20)
        Me.txb_kilometers.TabIndex = 20
        '
        'lbl_carID
        '
        Me.lbl_carID.AutoSize = True
        Me.lbl_carID.Location = New System.Drawing.Point(312, 33)
        Me.lbl_carID.Name = "lbl_carID"
        Me.lbl_carID.Size = New System.Drawing.Size(36, 13)
        Me.lbl_carID.TabIndex = 21
        Me.lbl_carID.Text = "car ID"
        '
        'lbl_carType
        '
        Me.lbl_carType.AutoSize = True
        Me.lbl_carType.Location = New System.Drawing.Point(312, 88)
        Me.lbl_carType.Name = "lbl_carType"
        Me.lbl_carType.Size = New System.Drawing.Size(45, 13)
        Me.lbl_carType.TabIndex = 22
        Me.lbl_carType.Text = "car type"
        '
        'lbl_manual_automatic
        '
        Me.lbl_manual_automatic.AutoSize = True
        Me.lbl_manual_automatic.Location = New System.Drawing.Point(284, 149)
        Me.lbl_manual_automatic.Name = "lbl_manual_automatic"
        Me.lbl_manual_automatic.Size = New System.Drawing.Size(102, 13)
        Me.lbl_manual_automatic.TabIndex = 23
        Me.lbl_manual_automatic.Text = "manual or automatic"
        '
        'lbl_carPower
        '
        Me.lbl_carPower.AutoSize = True
        Me.lbl_carPower.Location = New System.Drawing.Point(271, 203)
        Me.lbl_carPower.Name = "lbl_carPower"
        Me.lbl_carPower.Size = New System.Drawing.Size(115, 13)
        Me.lbl_carPower.TabIndex = 24
        Me.lbl_carPower.Text = "car power(horsepower)"
        '
        'lbl_kilometers
        '
        Me.lbl_kilometers.AutoSize = True
        Me.lbl_kilometers.Location = New System.Drawing.Point(545, 33)
        Me.lbl_kilometers.Name = "lbl_kilometers"
        Me.lbl_kilometers.Size = New System.Drawing.Size(54, 13)
        Me.lbl_kilometers.TabIndex = 25
        Me.lbl_kilometers.Text = "kilometers"
        '
        'lbl_fuel
        '
        Me.lbl_fuel.AutoSize = True
        Me.lbl_fuel.Location = New System.Drawing.Point(545, 88)
        Me.lbl_fuel.Name = "lbl_fuel"
        Me.lbl_fuel.Size = New System.Drawing.Size(24, 13)
        Me.lbl_fuel.TabIndex = 26
        Me.lbl_fuel.Text = "fuel"
        '
        'lbl_productionYear
        '
        Me.lbl_productionYear.AutoSize = True
        Me.lbl_productionYear.Location = New System.Drawing.Point(525, 146)
        Me.lbl_productionYear.Name = "lbl_productionYear"
        Me.lbl_productionYear.Size = New System.Drawing.Size(80, 13)
        Me.lbl_productionYear.TabIndex = 27
        Me.lbl_productionYear.Text = "production year"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Location = New System.Drawing.Point(545, 200)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(30, 13)
        Me.lbl_price.TabIndex = 28
        Me.lbl_price.Text = "price"
        Me.lbl_price.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_registerCar
        '
        Me.btn_registerCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registerCar.Location = New System.Drawing.Point(376, 277)
        Me.btn_registerCar.Name = "btn_registerCar"
        Me.btn_registerCar.Size = New System.Drawing.Size(116, 37)
        Me.btn_registerCar.TabIndex = 29
        Me.btn_registerCar.Text = "register new car"
        Me.btn_registerCar.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(40, 48)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(198, 28)
        Me.btn_back.TabIndex = 30
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(529, 48)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(183, 28)
        Me.btn_exit.TabIndex = 31
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Enabled = False
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(601, 277)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(110, 36)
        Me.btn_delete.TabIndex = 32
        Me.btn_delete.Text = "delete car by ID"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.btn_register)
        Me.Panel1.Controls.Add(Me.lbl_password)
        Me.Panel1.Controls.Add(Me.lbl_username)
        Me.Panel1.Controls.Add(Me.txb_password)
        Me.Panel1.Controls.Add(Me.txb_username)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(238, 468)
        Me.Panel1.TabIndex = 34
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumBlue
        Me.Panel2.Controls.Add(Me.btn_back)
        Me.Panel2.Controls.Add(Me.btn_exit)
        Me.Panel2.Location = New System.Drawing.Point(-1, 338)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(802, 127)
        Me.Panel2.TabIndex = 35
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_registerCar)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_productionYear)
        Me.Controls.Add(Me.lbl_fuel)
        Me.Controls.Add(Me.lbl_kilometers)
        Me.Controls.Add(Me.lbl_carPower)
        Me.Controls.Add(Me.lbl_manual_automatic)
        Me.Controls.Add(Me.lbl_carType)
        Me.Controls.Add(Me.lbl_carID)
        Me.Controls.Add(Me.txb_kilometers)
        Me.Controls.Add(Me.txb_carType)
        Me.Controls.Add(Me.txb_fuel)
        Me.Controls.Add(Me.Txb_manual_automatic)
        Me.Controls.Add(Me.txb_productionYear)
        Me.Controls.Add(Me.txb_price)
        Me.Controls.Add(Me.Txb_carPower)
        Me.Controls.Add(Me.txb_carID)
        Me.Name = "Form3"
        Me.Text = "Administrator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_username As Label
    Friend WithEvents txb_password As TextBox
    Friend WithEvents btn_register As Button
    Friend WithEvents lbl_password As Label
    Friend WithEvents txb_username As TextBox
    Friend WithEvents txb_carID As TextBox
    Friend WithEvents Txb_carPower As TextBox
    Friend WithEvents txb_price As TextBox
    Friend WithEvents txb_productionYear As TextBox
    Friend WithEvents Txb_manual_automatic As TextBox
    Friend WithEvents txb_fuel As TextBox
    Friend WithEvents txb_carType As TextBox
    Friend WithEvents txb_kilometers As TextBox
    Friend WithEvents lbl_carID As Label
    Friend WithEvents lbl_carType As Label
    Friend WithEvents lbl_manual_automatic As Label
    Friend WithEvents lbl_carPower As Label
    Friend WithEvents lbl_kilometers As Label
    Friend WithEvents lbl_fuel As Label
    Friend WithEvents lbl_productionYear As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents btn_registerCar As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class

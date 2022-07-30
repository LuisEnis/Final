<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btn_login = New System.Windows.Forms.Button()
        Me.txb_password = New System.Windows.Forms.TextBox()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.txb_username = New System.Windows.Forms.TextBox()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_showAll = New System.Windows.Forms.Button()
        Me.btn_filter = New System.Windows.Forms.Button()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_productionYear = New System.Windows.Forms.Label()
        Me.lbl_fuel = New System.Windows.Forms.Label()
        Me.lbl_kilometers = New System.Windows.Forms.Label()
        Me.lbl_carPower = New System.Windows.Forms.Label()
        Me.lbl_manual_automatic = New System.Windows.Forms.Label()
        Me.lbl_carType = New System.Windows.Forms.Label()
        Me.lbl_carID = New System.Windows.Forms.Label()
        Me.txb_kilometers = New System.Windows.Forms.TextBox()
        Me.txb_carType = New System.Windows.Forms.TextBox()
        Me.txb_fuel = New System.Windows.Forms.TextBox()
        Me.Txb_manual_automatic = New System.Windows.Forms.TextBox()
        Me.txb_productionYear = New System.Windows.Forms.TextBox()
        Me.txb_price = New System.Windows.Forms.TextBox()
        Me.Txb_carPower = New System.Windows.Forms.TextBox()
        Me.txb_carID = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_login
        '
        Me.btn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.Location = New System.Drawing.Point(24, 386)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(147, 41)
        Me.btn_login.TabIndex = 0
        Me.btn_login.Text = "LOGIN"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'txb_password
        '
        Me.txb_password.Location = New System.Drawing.Point(106, 290)
        Me.txb_password.Name = "txb_password"
        Me.txb_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txb_password.Size = New System.Drawing.Size(100, 20)
        Me.txb_password.TabIndex = 1
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(24, 225)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(61, 13)
        Me.lbl_username.TabIndex = 2
        Me.lbl_username.Text = "username"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password.Location = New System.Drawing.Point(25, 301)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(60, 13)
        Me.lbl_password.TabIndex = 3
        Me.lbl_password.Text = "password"
        '
        'txb_username
        '
        Me.txb_username.Location = New System.Drawing.Point(106, 225)
        Me.txb_username.Name = "txb_username"
        Me.txb_username.Size = New System.Drawing.Size(100, 20)
        Me.txb_username.TabIndex = 4
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(682, 21)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(109, 41)
        Me.btn_exit.TabIndex = 5
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_showAll
        '
        Me.btn_showAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_showAll.Location = New System.Drawing.Point(505, 21)
        Me.btn_showAll.Name = "btn_showAll"
        Me.btn_showAll.Size = New System.Drawing.Size(103, 41)
        Me.btn_showAll.TabIndex = 7
        Me.btn_showAll.Text = "SHOW ALL"
        Me.btn_showAll.UseVisualStyleBackColor = True
        '
        'btn_filter
        '
        Me.btn_filter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_filter.Location = New System.Drawing.Point(332, 21)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(117, 41)
        Me.btn_filter.TabIndex = 8
        Me.btn_filter.Text = "FILTER"
        Me.btn_filter.UseVisualStyleBackColor = True
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Location = New System.Drawing.Point(619, 206)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(52, 13)
        Me.lbl_price.TabIndex = 44
        Me.lbl_price.Text = "max price"
        Me.lbl_price.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_productionYear
        '
        Me.lbl_productionYear.AutoSize = True
        Me.lbl_productionYear.Location = New System.Drawing.Point(574, 155)
        Me.lbl_productionYear.Name = "lbl_productionYear"
        Me.lbl_productionYear.Size = New System.Drawing.Size(105, 13)
        Me.lbl_productionYear.TabIndex = 43
        Me.lbl_productionYear.Text = "production year(max)"
        '
        'lbl_fuel
        '
        Me.lbl_fuel.AutoSize = True
        Me.lbl_fuel.Location = New System.Drawing.Point(619, 94)
        Me.lbl_fuel.Name = "lbl_fuel"
        Me.lbl_fuel.Size = New System.Drawing.Size(24, 13)
        Me.lbl_fuel.TabIndex = 42
        Me.lbl_fuel.Text = "fuel"
        '
        'lbl_kilometers
        '
        Me.lbl_kilometers.AutoSize = True
        Me.lbl_kilometers.Location = New System.Drawing.Point(603, 42)
        Me.lbl_kilometers.Name = "lbl_kilometers"
        Me.lbl_kilometers.Size = New System.Drawing.Size(76, 13)
        Me.lbl_kilometers.TabIndex = 41
        Me.lbl_kilometers.Text = "max kilometers"
        '
        'lbl_carPower
        '
        Me.lbl_carPower.AutoSize = True
        Me.lbl_carPower.Location = New System.Drawing.Point(323, 209)
        Me.lbl_carPower.Name = "lbl_carPower"
        Me.lbl_carPower.Size = New System.Drawing.Size(137, 13)
        Me.lbl_carPower.TabIndex = 40
        Me.lbl_carPower.Text = "max car power(horsepower)"
        '
        'lbl_manual_automatic
        '
        Me.lbl_manual_automatic.AutoSize = True
        Me.lbl_manual_automatic.Location = New System.Drawing.Point(358, 155)
        Me.lbl_manual_automatic.Name = "lbl_manual_automatic"
        Me.lbl_manual_automatic.Size = New System.Drawing.Size(102, 13)
        Me.lbl_manual_automatic.TabIndex = 39
        Me.lbl_manual_automatic.Text = "manual or automatic"
        '
        'lbl_carType
        '
        Me.lbl_carType.AutoSize = True
        Me.lbl_carType.Location = New System.Drawing.Point(386, 94)
        Me.lbl_carType.Name = "lbl_carType"
        Me.lbl_carType.Size = New System.Drawing.Size(45, 13)
        Me.lbl_carType.TabIndex = 38
        Me.lbl_carType.Text = "car type"
        '
        'lbl_carID
        '
        Me.lbl_carID.AutoSize = True
        Me.lbl_carID.Location = New System.Drawing.Point(386, 39)
        Me.lbl_carID.Name = "lbl_carID"
        Me.lbl_carID.Size = New System.Drawing.Size(36, 13)
        Me.lbl_carID.TabIndex = 37
        Me.lbl_carID.Text = "car ID"
        '
        'txb_kilometers
        '
        Me.txb_kilometers.Location = New System.Drawing.Point(685, 39)
        Me.txb_kilometers.Name = "txb_kilometers"
        Me.txb_kilometers.Size = New System.Drawing.Size(100, 20)
        Me.txb_kilometers.TabIndex = 36
        '
        'txb_carType
        '
        Me.txb_carType.Location = New System.Drawing.Point(466, 94)
        Me.txb_carType.Name = "txb_carType"
        Me.txb_carType.Size = New System.Drawing.Size(100, 20)
        Me.txb_carType.TabIndex = 35
        '
        'txb_fuel
        '
        Me.txb_fuel.Location = New System.Drawing.Point(685, 94)
        Me.txb_fuel.Name = "txb_fuel"
        Me.txb_fuel.Size = New System.Drawing.Size(100, 20)
        Me.txb_fuel.TabIndex = 34
        '
        'Txb_manual_automatic
        '
        Me.Txb_manual_automatic.Location = New System.Drawing.Point(466, 152)
        Me.Txb_manual_automatic.Name = "Txb_manual_automatic"
        Me.Txb_manual_automatic.Size = New System.Drawing.Size(100, 20)
        Me.Txb_manual_automatic.TabIndex = 33
        '
        'txb_productionYear
        '
        Me.txb_productionYear.Location = New System.Drawing.Point(685, 152)
        Me.txb_productionYear.Name = "txb_productionYear"
        Me.txb_productionYear.Size = New System.Drawing.Size(100, 20)
        Me.txb_productionYear.TabIndex = 32
        '
        'txb_price
        '
        Me.txb_price.Location = New System.Drawing.Point(685, 206)
        Me.txb_price.Name = "txb_price"
        Me.txb_price.Size = New System.Drawing.Size(100, 20)
        Me.txb_price.TabIndex = 31
        '
        'Txb_carPower
        '
        Me.Txb_carPower.Location = New System.Drawing.Point(466, 206)
        Me.Txb_carPower.Name = "Txb_carPower"
        Me.Txb_carPower.Size = New System.Drawing.Size(100, 20)
        Me.Txb_carPower.TabIndex = 30
        '
        'txb_carID
        '
        Me.txb_carID.Location = New System.Drawing.Point(466, 39)
        Me.txb_carID.Name = "txb_carID"
        Me.txb_carID.Size = New System.Drawing.Size(100, 20)
        Me.txb_carID.TabIndex = 29
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Controls.Add(Me.btn_showAll)
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Controls.Add(Me.btn_filter)
        Me.Panel1.Location = New System.Drawing.Point(-6, 360)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(811, 100)
        Me.Panel1.TabIndex = 45
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel2.Controls.Add(Me.btn_login)
        Me.Panel2.Controls.Add(Me.txb_password)
        Me.Panel2.Controls.Add(Me.lbl_password)
        Me.Panel2.Controls.Add(Me.txb_username)
        Me.Panel2.Controls.Add(Me.lbl_username)
        Me.Panel2.Location = New System.Drawing.Point(-3, -5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(215, 462)
        Me.Panel2.TabIndex = 46
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
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
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_login As Button
    Friend WithEvents txb_password As TextBox
    Friend WithEvents lbl_username As Label
    Friend WithEvents lbl_password As Label
    Friend WithEvents txb_username As TextBox
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_showAll As Button
    Friend WithEvents btn_filter As Button
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_productionYear As Label
    Friend WithEvents lbl_fuel As Label
    Friend WithEvents lbl_kilometers As Label
    Friend WithEvents lbl_carPower As Label
    Friend WithEvents lbl_manual_automatic As Label
    Friend WithEvents lbl_carType As Label
    Friend WithEvents lbl_carID As Label
    Friend WithEvents txb_kilometers As TextBox
    Friend WithEvents txb_carType As TextBox
    Friend WithEvents txb_fuel As TextBox
    Friend WithEvents Txb_manual_automatic As TextBox
    Friend WithEvents txb_productionYear As TextBox
    Friend WithEvents txb_price As TextBox
    Friend WithEvents Txb_carPower As TextBox
    Friend WithEvents txb_carID As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class

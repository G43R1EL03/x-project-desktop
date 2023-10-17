<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnSetting = New FontAwesome.Sharp.IconButton()
        Me.btnMarketing = New FontAwesome.Sharp.IconButton()
        Me.btnCustomers = New FontAwesome.Sharp.IconButton()
        Me.btnProducts = New FontAwesome.Sharp.IconButton()
        Me.btnOrders = New FontAwesome.Sharp.IconButton()
        Me.btnDashboard = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.imgHome = New System.Windows.Forms.PictureBox()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnSetting)
        Me.PanelMenu.Controls.Add(Me.btnMarketing)
        Me.PanelMenu.Controls.Add(Me.btnCustomers)
        Me.PanelMenu.Controls.Add(Me.btnProducts)
        Me.PanelMenu.Controls.Add(Me.btnOrders)
        Me.PanelMenu.Controls.Add(Me.btnDashboard)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 500)
        Me.PanelMenu.TabIndex = 0
        '
        'btnSetting
        '
        Me.btnSetting.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSetting.FlatAppearance.BorderSize = 0
        Me.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetting.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Tools
        Me.btnSetting.IconColor = System.Drawing.Color.Gainsboro
        Me.btnSetting.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSetting.IconSize = 32
        Me.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSetting.Location = New System.Drawing.Point(0, 440)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnSetting.Size = New System.Drawing.Size(220, 60)
        Me.btnSetting.TabIndex = 6
        Me.btnSetting.Text = "Settings"
        Me.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSetting.UseVisualStyleBackColor = True
        '
        'btnMarketing
        '
        Me.btnMarketing.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMarketing.FlatAppearance.BorderSize = 0
        Me.btnMarketing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMarketing.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMarketing.IconChar = FontAwesome.Sharp.IconChar.MailBulk
        Me.btnMarketing.IconColor = System.Drawing.Color.Gainsboro
        Me.btnMarketing.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMarketing.IconSize = 32
        Me.btnMarketing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMarketing.Location = New System.Drawing.Point(0, 380)
        Me.btnMarketing.Name = "btnMarketing"
        Me.btnMarketing.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnMarketing.Size = New System.Drawing.Size(220, 60)
        Me.btnMarketing.TabIndex = 5
        Me.btnMarketing.Text = "Marketing"
        Me.btnMarketing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMarketing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMarketing.UseVisualStyleBackColor = True
        '
        'btnCustomers
        '
        Me.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCustomers.FlatAppearance.BorderSize = 0
        Me.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomers.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCustomers.IconChar = FontAwesome.Sharp.IconChar.User
        Me.btnCustomers.IconColor = System.Drawing.Color.Gainsboro
        Me.btnCustomers.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCustomers.IconSize = 32
        Me.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.Location = New System.Drawing.Point(0, 320)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnCustomers.Size = New System.Drawing.Size(220, 60)
        Me.btnCustomers.TabIndex = 4
        Me.btnCustomers.Text = "Customers"
        Me.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnProducts
        '
        Me.btnProducts.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProducts.FlatAppearance.BorderSize = 0
        Me.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProducts.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnProducts.IconChar = FontAwesome.Sharp.IconChar.Tag
        Me.btnProducts.IconColor = System.Drawing.Color.Gainsboro
        Me.btnProducts.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnProducts.IconSize = 32
        Me.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducts.Location = New System.Drawing.Point(0, 260)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnProducts.Size = New System.Drawing.Size(220, 60)
        Me.btnProducts.TabIndex = 3
        Me.btnProducts.Text = "Products"
        Me.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'btnOrders
        '
        Me.btnOrders.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOrders.FlatAppearance.BorderSize = 0
        Me.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrders.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnOrders.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.btnOrders.IconColor = System.Drawing.Color.Gainsboro
        Me.btnOrders.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnOrders.IconSize = 32
        Me.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrders.Location = New System.Drawing.Point(0, 200)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnOrders.Size = New System.Drawing.Size(220, 60)
        Me.btnOrders.TabIndex = 2
        Me.btnOrders.Text = "Orders"
        Me.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOrders.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.LineChart
        Me.btnDashboard.IconColor = System.Drawing.Color.Gainsboro
        Me.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDashboard.IconSize = 32
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 140)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(220, 60)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.imgHome)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(220, 140)
        Me.PanelLogo.TabIndex = 0
        '
        'imgHome
        '
        Me.imgHome.Location = New System.Drawing.Point(57, 46)
        Me.imgHome.Name = "imgHome"
        Me.imgHome.Size = New System.Drawing.Size(100, 50)
        Me.imgHome.TabIndex = 0
        Me.imgHome.TabStop = False
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelTitleBar.Controls.Add(Me.lblFormTitle)
        Me.PanelTitleBar.Controls.Add(Me.IconCurrentForm)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(220, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(582, 75)
        Me.PanelTitleBar.TabIndex = 1
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTitle.Location = New System.Drawing.Point(58, 35)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(44, 16)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Home"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.MediumPurple
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        Me.IconCurrentForm.IconColor = System.Drawing.Color.MediumPurple
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.Location = New System.Drawing.Point(19, 27)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(32, 32)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(220, 75)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(582, 425)
        Me.PanelDesktop.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 500)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "Form1"
        Me.Text = " "
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents btnMarketing As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCustomers As FontAwesome.Sharp.IconButton
    Friend WithEvents btnProducts As FontAwesome.Sharp.IconButton
    Friend WithEvents btnOrders As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSetting As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents PanelDesktop As Panel
End Class

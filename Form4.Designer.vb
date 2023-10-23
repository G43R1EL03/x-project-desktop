<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Me.btnHelp = New FontAwesome.Sharp.IconButton()
        Me.btnUsers = New FontAwesome.Sharp.IconButton()
        Me.btnBlog = New FontAwesome.Sharp.IconButton()
        Me.btnChat = New FontAwesome.Sharp.IconButton()
        Me.btnTickets = New FontAwesome.Sharp.IconButton()
        Me.btnCustomers = New FontAwesome.Sharp.IconButton()
        Me.btnSales = New FontAwesome.Sharp.IconButton()
        Me.btnInventory = New FontAwesome.Sharp.IconButton()
        Me.btnHome = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.PanelMenu.SuspendLayout()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnHelp)
        Me.PanelMenu.Controls.Add(Me.btnUsers)
        Me.PanelMenu.Controls.Add(Me.btnBlog)
        Me.PanelMenu.Controls.Add(Me.btnChat)
        Me.PanelMenu.Controls.Add(Me.btnTickets)
        Me.PanelMenu.Controls.Add(Me.btnCustomers)
        Me.PanelMenu.Controls.Add(Me.btnSales)
        Me.PanelMenu.Controls.Add(Me.btnInventory)
        Me.PanelMenu.Controls.Add(Me.btnHome)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 703)
        Me.PanelMenu.TabIndex = 0
        '
        'btnHelp
        '
        Me.btnHelp.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnHelp.FlatAppearance.BorderSize = 0
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnHelp.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle
        Me.btnHelp.IconColor = System.Drawing.Color.Gainsboro
        Me.btnHelp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHelp.IconSize = 32
        Me.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHelp.Location = New System.Drawing.Point(0, 643)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnHelp.Size = New System.Drawing.Size(220, 60)
        Me.btnHelp.TabIndex = 9
        Me.btnHelp.Text = "Ayuda"
        Me.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUsers.FlatAppearance.BorderSize = 0
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnUsers.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        Me.btnUsers.IconColor = System.Drawing.Color.Gainsboro
        Me.btnUsers.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUsers.IconSize = 32
        Me.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.Location = New System.Drawing.Point(0, 560)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnUsers.Size = New System.Drawing.Size(220, 60)
        Me.btnUsers.TabIndex = 8
        Me.btnUsers.Text = "Usuarios"
        Me.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'btnBlog
        '
        Me.btnBlog.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBlog.FlatAppearance.BorderSize = 0
        Me.btnBlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBlog.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnBlog.IconChar = FontAwesome.Sharp.IconChar.Globe
        Me.btnBlog.IconColor = System.Drawing.Color.Gainsboro
        Me.btnBlog.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBlog.IconSize = 32
        Me.btnBlog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBlog.Location = New System.Drawing.Point(0, 500)
        Me.btnBlog.Name = "btnBlog"
        Me.btnBlog.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnBlog.Size = New System.Drawing.Size(220, 60)
        Me.btnBlog.TabIndex = 7
        Me.btnBlog.Text = "blog"
        Me.btnBlog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBlog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBlog.UseVisualStyleBackColor = True
        '
        'btnChat
        '
        Me.btnChat.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnChat.FlatAppearance.BorderSize = 0
        Me.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChat.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnChat.IconChar = FontAwesome.Sharp.IconChar.Comment
        Me.btnChat.IconColor = System.Drawing.Color.Gainsboro
        Me.btnChat.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnChat.IconSize = 32
        Me.btnChat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChat.Location = New System.Drawing.Point(0, 440)
        Me.btnChat.Name = "btnChat"
        Me.btnChat.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnChat.Size = New System.Drawing.Size(220, 60)
        Me.btnChat.TabIndex = 6
        Me.btnChat.Text = "Chat"
        Me.btnChat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnChat.UseVisualStyleBackColor = True
        '
        'btnTickets
        '
        Me.btnTickets.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTickets.FlatAppearance.BorderSize = 0
        Me.btnTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTickets.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnTickets.IconChar = FontAwesome.Sharp.IconChar.Ticket
        Me.btnTickets.IconColor = System.Drawing.Color.Gainsboro
        Me.btnTickets.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnTickets.IconSize = 32
        Me.btnTickets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTickets.Location = New System.Drawing.Point(0, 380)
        Me.btnTickets.Name = "btnTickets"
        Me.btnTickets.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnTickets.Size = New System.Drawing.Size(220, 60)
        Me.btnTickets.TabIndex = 5
        Me.btnTickets.Text = "Tickets"
        Me.btnTickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTickets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTickets.UseVisualStyleBackColor = True
        '
        'btnCustomers
        '
        Me.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCustomers.FlatAppearance.BorderSize = 0
        Me.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomers.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCustomers.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.btnCustomers.IconColor = System.Drawing.Color.Gainsboro
        Me.btnCustomers.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCustomers.IconSize = 32
        Me.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.Location = New System.Drawing.Point(0, 320)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnCustomers.Size = New System.Drawing.Size(220, 60)
        Me.btnCustomers.TabIndex = 4
        Me.btnCustomers.Text = "Clientes"
        Me.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnSales
        '
        Me.btnSales.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSales.FlatAppearance.BorderSize = 0
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSales.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSales.IconChar = FontAwesome.Sharp.IconChar.Wallet
        Me.btnSales.IconColor = System.Drawing.Color.Gainsboro
        Me.btnSales.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSales.IconSize = 32
        Me.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSales.Location = New System.Drawing.Point(0, 260)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnSales.Size = New System.Drawing.Size(220, 60)
        Me.btnSales.TabIndex = 3
        Me.btnSales.Text = "Ventas"
        Me.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnInventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnInventory.IconChar = FontAwesome.Sharp.IconChar.Cube
        Me.btnInventory.IconColor = System.Drawing.Color.Gainsboro
        Me.btnInventory.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnInventory.IconSize = 32
        Me.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.Location = New System.Drawing.Point(0, 200)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnInventory.Size = New System.Drawing.Size(220, 60)
        Me.btnInventory.TabIndex = 2
        Me.btnInventory.Text = "Inventario"
        Me.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInventory.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnHome.IconChar = FontAwesome.Sharp.IconChar.House
        Me.btnHome.IconColor = System.Drawing.Color.Gainsboro
        Me.btnHome.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHome.IconSize = 32
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(0, 140)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnHome.Size = New System.Drawing.Size(220, 60)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Home"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'PanelLogo
        '
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(220, 140)
        Me.PanelLogo.TabIndex = 0
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.PanelTitleBar.Controls.Add(Me.lblFormTitle)
        Me.PanelTitleBar.Controls.Add(Me.IconCurrentForm)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(220, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(953, 75)
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
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        Me.IconCurrentForm.IconColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.Location = New System.Drawing.Point(19, 27)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(32, 32)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(220, 75)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(953, 628)
        Me.PanelDesktop.TabIndex = 2
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 703)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "Form2"
        Me.Text = " "
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnHome As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents btnTickets As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCustomers As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSales As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInventory As FontAwesome.Sharp.IconButton
    Friend WithEvents btnChat As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents btnBlog As FontAwesome.Sharp.IconButton
    Friend WithEvents btnHelp As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUsers As FontAwesome.Sharp.IconButton
End Class

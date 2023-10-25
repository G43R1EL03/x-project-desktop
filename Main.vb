Imports FontAwesome.Sharp
Public Class Main
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)
        Me.BackColor = Color.Black ' Establece el color de fondo del formulario a negro
        Me.IsMdiContainer = True
    End Sub

    'Methods'
    Private Sub ActivateButton(senderBtn As Object, customColor As Color, formTitle As String)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(43, 52, 65)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border'
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current Form icon'
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor
            lblFormTitle.Text = formTitle
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(22, 29, 33)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ActivateButton(sender, RGBColors.Purple, "Home")
        Home.MdiParent = Me
        Home.WindowState = FormWindowState.Maximized
        Home.FormBorderStyle = FormBorderStyle.None
        Home.Show()

    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        ActivateButton(sender, RGBColors.Pink, "Inventario")
        Inventario.MdiParent = Me
        Inventario.WindowState = FormWindowState.Maximized
        Inventario.FormBorderStyle = FormBorderStyle.None
        Inventario.Show()
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        ActivateButton(sender, RGBColors.PalePink, "Ventas")
        Ventas.MdiParent = Me
        Ventas.WindowState = FormWindowState.Maximized
        Ventas.FormBorderStyle = FormBorderStyle.None
        Ventas.Show()
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        ActivateButton(sender, RGBColors.ShadeBlue, "Clientes")
        Clientes.MdiParent = Me
        Clientes.WindowState = FormWindowState.Maximized
        Clientes.FormBorderStyle = FormBorderStyle.None
        Clientes.Show()
    End Sub

    Private Sub btnTickets_Click(sender As Object, e As EventArgs) Handles btnTickets.Click
        ActivateButton(sender, RGBColors.ShadePink, "Tickets")
        Tickets.MdiParent = Me
        Tickets.WindowState = FormWindowState.Maximized
        Tickets.FormBorderStyle = FormBorderStyle.None
        Tickets.Show()
    End Sub

    Private Sub btnChat_Click(sender As Object, e As EventArgs) Handles btnChat.Click
        ActivateButton(sender, RGBColors.LightBlue, "Chat")
        Chat.MdiParent = Me
        Chat.WindowState = FormWindowState.Maximized
        Chat.FormBorderStyle = FormBorderStyle.None
        Chat.Show()
    End Sub

    Private Sub btnBlog_Click(sender As Object, e As EventArgs) Handles btnBlog.Click
        ActivateButton(sender, RGBColors.SugarCaneGreen, "Blog")
        Blog.MdiParent = Me
        Blog.WindowState = FormWindowState.Maximized
        Blog.FormBorderStyle = FormBorderStyle.None
        Blog.Show()
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        ActivateButton(sender, RGBColors.Ambar, "Usuarios")
        Usuario.MdiParent = Me
        Usuario.WindowState = FormWindowState.Maximized
        Usuario.FormBorderStyle = FormBorderStyle.None
        Usuario.Show()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        ActivateButton(sender, RGBColors.LimeGreen, "Ayuda")
        Ayuda.MdiParent = Me
        Ayuda.WindowState = FormWindowState.Maximized
        Ayuda.FormBorderStyle = FormBorderStyle.None
        Ayuda.Show()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Home.MdiParent = Me
        Home.WindowState = FormWindowState.Normal
        Home.FormBorderStyle = FormBorderStyle.None
        Home.Show()
    End Sub
End Class

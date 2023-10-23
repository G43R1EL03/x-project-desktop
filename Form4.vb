Imports FontAwesome.Sharp
Public Class Form4
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

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ActivateButton(sender, RGBColors.color1, "Home")

    End Sub

    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        ActivateButton(sender, RGBColors.color2, "Inventario")

    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        ActivateButton(sender, RGBColors.color3, "Ventas")
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        ActivateButton(sender, RGBColors.color4, "Clientes")
    End Sub

    Private Sub btnMarketing_Click(sender As Object, e As EventArgs) Handles btnTickets.Click
        ActivateButton(sender, RGBColors.color5, "Tickets")
    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnChat.Click
        ActivateButton(sender, RGBColors.color6, "Chat")
    End Sub

    Private Sub btnBlog_Click(sender As Object, e As EventArgs) Handles btnBlog.Click
        ActivateButton(sender, RGBColors.color7, "Blog")
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        ActivateButton(sender, RGBColors.color8, "Usuarios")
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        ActivateButton(sender, RGBColors.color9, "Ayuda")
    End Sub


End Class

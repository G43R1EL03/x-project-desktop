Public Class frmInventario
    Private Sub frmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubMenu()
    End Sub

    Private Sub hideSubMenu()
        panelSplitButonInventario.Visible = False
        panelSplitButonEntradas.Visible = False
    End Sub

    Private Sub showSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregarInventario.Click
        showSubMenu(panelSplitButonInventario)
    End Sub

    Private Sub btnAgregarEntradas_Click(sender As Object, e As EventArgs) Handles btnAgregarEntradas.Click
        showSubMenu(panelSplitButonEntradas)
    End Sub
End Class
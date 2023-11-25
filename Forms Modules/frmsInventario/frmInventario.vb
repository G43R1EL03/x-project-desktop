Public Class frmInventario
    Private Sub frmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = RGBColors.Purple

        hideSubMenu()
    End Sub

    Private Sub hideSubMenu()
        panelSplitButonOpciones.Visible = False
    End Sub

    Private Sub showSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        showSubMenu(panelSplitButonOpciones)
    End Sub
End Class
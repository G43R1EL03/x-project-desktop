Imports System.Windows.Documents
Imports FontAwesome.Sharp

Public Class frmAyuda

    Private Sub frmAyuda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomButton(btnAyudaPedidos, IconChar.CartShopping, "#0d1117", 35)
        CustomButton(btnAyudaDevo, IconChar.Ticket, "#0d1117", 35)
        CustomButton(btnAyudaPago, IconChar.MoneyCheckDollar, "#0d1117", 35)
        CustomButton(btnAyudaEntrega, IconChar.BoxOpen, "#0d1117", 35)
        CustomButton(btnAyudaUsuario, IconChar.UserAlt, "#0d1117", 35)
        CustomButton(btnAyudaPoliticas, IconChar.Passport, "#0d1117", 35)
    End Sub

    Private Sub btnAyudaPedidos_Click(sender As Object, e As EventArgs) Handles btnAyudaPedidos.Click
        SetPanel(New frmAyudaPedidos, frmMenu.PanelContent)
    End Sub

    Private Sub btnAyudaDevo_Click(sender As Object, e As EventArgs) Handles btnAyudaDevo.Click
        SetPanel(New frmAyudaDevolucion(), frmMenu.PanelContent)
    End Sub

    Private Sub btnAyudaPago_Click(sender As Object, e As EventArgs) Handles btnAyudaPago.Click
        SetPanel(New frmAyudaPagoPromociones(), frmMenu.PanelContent)
    End Sub

    Private Sub btnAyudaEntrega_Click(sender As Object, e As EventArgs) Handles btnAyudaEntrega.Click
        SetPanel(New frmAyudaEntrega(), frmMenu.PanelContent)
    End Sub

    Private Sub btnAyudaUsuario_Click(sender As Object, e As EventArgs) Handles btnAyudaUsuario.Click
        SetPanel(New frmAyudaUsuario(), frmMenu.PanelContent)
    End Sub

    Private Sub btnAyudaPoliticas_Click(sender As Object, e As EventArgs) Handles btnAyudaPoliticas.Click
        SetPanel(New frmAyudaPoliticas(), frmMenu.PanelContent)
    End Sub
End Class
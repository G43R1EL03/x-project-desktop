Public Class frmAgregarCategoria

    Private Sub FrmAgregarCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientSize = New Size(panelFrmAgregarCategoria.Width, panelFrmAgregarCategoria.Height)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
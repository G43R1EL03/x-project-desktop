Public Class FrmAgregarCategoria

    Private Sub FrmAgregarCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientSize = New Size(pnlAgregarCategoria.Width, pnlAgregarCategoria.Height)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
Public Class frmAgregarCategoria
    Private Sub frmAgregarCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ajusta el tamaño del form al panel
        Me.ClientSize = New Size(pnlAgregarCategoria.Width, pnlAgregarCategoria.Height)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        ' Cerrar el formulario
        Me.Close()
    End Sub
End Class
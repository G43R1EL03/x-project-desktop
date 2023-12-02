Imports FontAwesome.Sharp
Public Class frmAgregarProducto
    Private Sub frmAgregarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If BoxCategoria.Items.Count = 0 Then
            BoxCategoria.Items.Add("Electrónica")
            BoxCategoria.Items.Add("Ropa")
            BoxCategoria.Items.Add("Hogar")
        End If

        If BoxMarca.Items.Count = 0 Then
            BoxMarca.Items.Add("Samsung")
            BoxMarca.Items.Add("Nike")
            BoxMarca.Items.Add("KitchenAid")
        End If
    End Sub
End Class
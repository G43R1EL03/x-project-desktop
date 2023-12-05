Imports System.IO
Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient

Public Class frmAgregarProducto
    Dim myConnectionDB As MySqlConnection
    Dim productoDao As New inventaryDAO(myConnectionDB)

    Public Sub New()
        DB_Conecction.conexionDB()

        myConnectionDB = DB_Conecction.myConnectionDB

        InitializeComponent()

        ComboBoxMarca()

        ComboBoxCategoria()
    End Sub



    Private Sub ComboBoxMarca()
        Dim marcaQuery As String = "SELECT id_marca, nombre FROM Marca"
        Dim marcaDataAdapter As New MySqlDataAdapter(marcaQuery, myConnectionDB)
        Dim marcaDataTable As New DataTable()
        marcaDataAdapter.Fill(marcaDataTable)
        BoxMarca.DataSource = marcaDataTable
        BoxMarca.DisplayMember = "nombre"
        BoxMarca.ValueMember = "id_marca"
    End Sub

    Private Sub ComboBoxCategoria()
        Dim categoriaQuery As String = "SELECT id_categoria, nombre FROM Categoria"
        Dim categoriaDataAdapter As New MySqlDataAdapter(categoriaQuery, myConnectionDB)
        Dim categoriaDataTable As New DataTable()
        categoriaDataAdapter.Fill(categoriaDataTable)
        BoxCategoria.DataSource = categoriaDataTable
        BoxCategoria.DisplayMember = "nombre"
        BoxCategoria.ValueMember = "id_categoria"
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If String.IsNullOrEmpty(txtNomProducto.Text) Or String.IsNullOrEmpty(txtPrecioU.Text) Then
            MessageBox.Show("Por favor, complete los campos obligatorios.")
            Return
        End If

        If Not Decimal.TryParse(txtPrecioU.Text, Nothing) Then
            MessageBox.Show("Ingrese un precio válido.")
            Return
        End If

        Try
            Dim selectedImage As Image = BoxPicture.Image

            ' Llamar a la función de la clase productoDao
            If productoDao.InsertarProducto(
                txtNomProducto.Text,
                Decimal.Parse(txtPrecioU.Text),
                If(String.IsNullOrEmpty(txtCantPCajas.Text), Nothing, CInt(txtCantPCajas.Text)),
                If(String.IsNullOrEmpty(txtReorden.Text), Nothing, CInt(txtReorden.Text)),
                If(String.IsNullOrEmpty(txtCantidad.Text), Nothing, CInt(txtCantidad.Text)),
                CInt(BoxMarca.SelectedValue),
                CInt(BoxCategoria.SelectedValue),
                selectedImage
            ) Then
                MessageBox.Show("Producto agregado correctamente.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al agregar el producto: " & ex.Message)
        Finally
        End Try
    End Sub
End Class

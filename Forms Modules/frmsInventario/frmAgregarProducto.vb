Imports System.IO
Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient
Public Class frmAgregarProducto
    Dim myConnectionDB As MySqlConnection

    Public Sub New()
        InitializeComponent()

        DB_Conecction.conexionDB()

        myConnectionDB = DB_Conecction.myConnectionDB

        ComboBoxMarca()

        ComboBoxCategoria()
    End Sub


    'Esto no se si este del todo correcto, pero es para traer los datos a los combobox
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
            myConnectionDB.Open()

            Using glCommand As New MySqlCommand("sp_InsertarProducto", myConnectionDB)
                glCommand.CommandType = CommandType.StoredProcedure

                glCommand.Parameters.AddWithValue("@p_nombre", txtNomProducto.Text)
                glCommand.Parameters.AddWithValue("@p_precio_unit", Decimal.Parse(txtPrecioU.Text))
                glCommand.Parameters.AddWithValue("@p_cantidad_por_cajas", If(String.IsNullOrEmpty(txtCantPCajas.Text), DBNull.Value, CInt(txtCantidad.Text)))

                Dim selectedImage As Image = BoxPicture.Image

                Dim photoBytes As Byte() = Nothing
                If selectedImage IsNot Nothing Then
                    Using ms As New MemoryStream()
                        selectedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                        photoBytes = ms.ToArray()
                    End Using
                End If


                glCommand.Parameters.AddWithValue("@p_punto_reorden", If(String.IsNullOrEmpty(txtReorden.Text), DBNull.Value, CInt(txtReorden.Text)))
                glCommand.Parameters.AddWithValue("@p_cantidad_cajas", If(String.IsNullOrEmpty(txtCantidad.Text), DBNull.Value, CInt(txtCantidad.Text)))
                glCommand.Parameters.AddWithValue("@p_marca_id", BoxMarca.SelectedValue)
                glCommand.Parameters.AddWithValue("@p_categoria_id", BoxCategoria.SelectedValue)
                glCommand.ExecuteNonQuery()

                MessageBox.Show("Producto agregado correctamente.")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al agregar el producto: " & ex.Message)
        Finally
            ' Cerrar la conexión a la base de datos
            myConnectionDB.Close()
        End Try
    End Sub

    'Aqui solo funciona para mostrar la imagen que se carga, no envia nada a la base de datos
    Private Sub BtnChoose_Click(sender As Object, e As EventArgs) Handles BtnChoose.Click
        ' Configurar el cuadro de diálogo para seleccionar archivos de imagen
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Archivos de imagen|*.bmp;*.jpg;*.jpeg;*.png;*.gif"
        openFileDialog.Title = "Seleccione una imagen"

        ' Mostrar el cuadro de diálogo
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Obtener la ruta del archivo seleccionado
            Dim selectedImagePath As String = openFileDialog.FileName

            ' Cargar la imagen en el control ImageProducto y ajustar el tamaño
            Try
                Dim selectedImage As Image = Image.FromFile(selectedImagePath)

                ' Ajustar el tamaño de la imagen al tamaño del control ImageProducto
                BoxPicture.SizeMode = PictureBoxSizeMode.Zoom
                BoxPicture.Image = ResizeImage(selectedImage, BoxPicture.Size)
            Catch ex As Exception
                MessageBox.Show("Error al cargar la imagen.")
            End Try
        End If
    End Sub

    Private Function ResizeImage(image As Image, newSize As Size) As Image
        ' Función para ajustar el tamaño de la imagen
        Dim newBitmap As New Bitmap(newSize.Width, newSize.Height)
        Using g As Graphics = Graphics.FromImage(newBitmap)
            g.DrawImage(image, New Rectangle(0, 0, newSize.Width, newSize.Height))
        End Using
        Return newBitmap
    End Function

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        BoxPicture.Image = Nothing

    End Sub
End Class
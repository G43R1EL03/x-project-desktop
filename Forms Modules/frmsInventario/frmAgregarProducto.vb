Imports System.IO
Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient

Public Class frmAgregarProducto
    Dim myConnectionDB As MySqlConnection
    Dim productoDao As New inventaryDAO(myConnectionDB)

    Public Sub New()
        ' Inicializar la conexión a la base de datos
        DB_Conecction.conexionDB()

        ' Obtener la conexión
        myConnectionDB = DB_Conecction.myConnectionDB

        InitializeComponent()

        ' Poblar ComboBox de Marca
        ComboBoxMarca()

        ' Poblar ComboBox de Categoría
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

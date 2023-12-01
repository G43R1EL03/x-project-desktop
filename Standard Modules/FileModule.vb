Imports MySql.Data.MySqlClient
Imports System.IO

Module FileModule

    'Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
    '    Verificar si se ha seleccionado una imagen
    '    If PictureBox1.Image IsNot Nothing Then
    '        Convertir la imagen en bytes
    '        Dim imageBytes As Byte() = ImageToByteArray(PictureBox1.Image)

    '        Conectar a la base de datos MySQL (ajusta la cadena de conexión según tu configuración)
    '        Dim connectionString As String = "Server=tu_servidor;Database=tu_base_de_datos;User ID=tu_usuario;Password=tu_contraseña;"
    '        Using connection As New MySqlConnection(connectionString)
    '            connection.Open()

    '            Insertar la imagen en la base de datos
    '            Dim query As String = "INSERT INTO tu_tabla (nombre_columna_imagen) VALUES (@imagen)"
    '            Using command As New MySqlCommand(query, connection)
    '                command.Parameters.AddWithValue("@imagen", imageBytes)
    '                command.ExecuteNonQuery()
    '            End Using
    '        End Using

    '        MessageBox.Show("Imagen almacenada en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Else
    '        MessageBox.Show("Por favor, seleccione una imagen antes de cargarla en la base de datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    End If
    'End Sub

    ' Convierte una imagen en un array de bytes
    Private Function ImageToByteArray(image As Image) As Byte()
        Using ms As New MemoryStream()
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) ' Puedes ajustar el formato según tus necesidades
            Return ms.ToArray()
        End Using
    End Function
End Module

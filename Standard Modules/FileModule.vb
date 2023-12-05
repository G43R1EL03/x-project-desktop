Imports System.Drawing.Imaging
Imports System.IO

Module FileModule

    Sub DialogoArchivo(ByRef pbPreview As PictureBox)
        Dim openFileDialog As New OpenFileDialog With {
           .Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp",
           .Title = "Seleccionar imagen"
       }
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            pbPreview.ImageLocation = openFileDialog.FileName
            pbPreview.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Function VerificarImagen(ByRef pbPreview As PictureBox) As Boolean
        Return If(pbPreview.Image Is Nothing, False, True)
    End Function

    Function CodificarImagen(ByVal image As Image, ByRef pbox As PictureBox) As String
        Using ms As New MemoryStream()
            image.Save(ms, EncodeType(pbox))
            Dim imageBytes As Byte() = ms.ToArray()
            Dim base64String As String = Convert.ToBase64String(imageBytes)
            Return base64String
        End Using
    End Function

    Function DecodificarImagen(ByVal base64Image As String) As Image
        Dim imageBytes As Byte() = Convert.FromBase64String(base64Image)
        Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)
        Dim normalImage As Image = Image.FromStream(ms, True)
        Return normalImage
    End Function

    Private Function EncodeType(ByVal picbox As PictureBox) As ImageFormat
        Dim encode As ImageFormat = ImageFormat.Jpeg
        If picbox.ImageLocation.ToLower.EndsWith(".jpg") Then
            encode = ImageFormat.Jpeg
        ElseIf picbox.ImageLocation.ToLower.EndsWith(".png") Then
            encode = ImageFormat.Png
        ElseIf picbox.ImageLocation.ToLower.EndsWith(".bmp") Then
            encode = ImageFormat.Bmp
        End If
        Return encode
    End Function

    Function ImagenPredeterminada()
        Dim rutaImagenPorDefecto As String = "\x-project-desktop\Resources\sin_imagen.png"

        ' Verificar si la ruta de la imagen por defecto existe
        If IO.File.Exists(rutaImagenPorDefecto) Then
            ' Crear una instancia de la clase Bitmap con la imagen por defecto
            Dim imagenPorDefecto As New Bitmap(rutaImagenPorDefecto)

            ' Asignar la imagen por defecto al PictureBox
            ImagenPredeterminada = imagenPorDefecto
        Else
            ' Manejar el caso en que la imagen por defecto no existe
            MessageBox.Show("La imagen por defecto no pudo ser cargada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ImagenPredeterminada = Nothing
        End If

    End Function

End Module
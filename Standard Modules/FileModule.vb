Imports System.Drawing.Imaging
Imports System.IO

Module FileModule

    Sub DialogoArchivo(ByRef pbPreview As PictureBox)
        Dim openFileDialog As New OpenFileDialog With {
           .Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp",
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

    Function CodificarImagen(ByVal image As Image) As String
        Using ms As New MemoryStream()
            image.Save(ms, ImageFormat.Jpeg)
            Dim imageBytes As Byte() = ms.ToArray()
            Dim base64String As String = Convert.ToBase64String(imageBytes)
            Return base64String
        End Using
    End Function


    Function DecodificarImagen() As String
        DecodificarImagen = ""
        'Estamos para continuar este
    End Function
End Module

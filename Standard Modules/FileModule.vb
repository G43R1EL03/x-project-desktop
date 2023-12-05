Imports System.Drawing.Imaging
Imports System.IO

Module FileModule

    Function ManejoDeArchivos(ByVal imagePath As String) As String
        Dim documentsFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim destinationFolder As String = Path.Combine(documentsFolder, "x-project-desktop", "Resources", "img")
        If Not Directory.Exists(destinationFolder) Then
            Directory.CreateDirectory(destinationFolder)
        End If
        Dim destinationPath As String = Path.Combine(destinationFolder, Path.GetFileName(imagePath))
        Try
            File.Copy(imagePath, destinationPath, True)
            MsgBox("Imagen almacenada en: " & destinationPath)
        Catch ex As Exception
            MsgBox("Error al guardar la imagen: " & ex.Message, MsgBoxStyle.Critical)
        End Try
        Return destinationPath
    End Function

    Function CodificarImagen(ByVal image As Image) As String
        Using ms As New MemoryStream()
            image.Save(ms, ImageFormat.Jpeg)
            Dim imageBytes As Byte() = ms.ToArray()
            Dim base64String As String = Convert.ToBase64String(imageBytes)
            Return base64String
        End Using
    End Function


    Function DecodificarImagen()

    End Function
End Module

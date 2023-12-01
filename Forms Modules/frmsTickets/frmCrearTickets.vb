Imports FontAwesome.Sharp

Public Class frmCrearTickets
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        ' Configurar el OpenFileDialog
        Dim openFileDialog As New OpenFileDialog With {
            .Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp",
            .Title = "Seleccionar imagen"
        }

        ' Mostrar el diálogo y verificar si el usuario hizo clic en "Aceptar"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Obtener la ruta del archivo seleccionado
            Dim imagePath As String = openFileDialog.FileName
            lblEvidencia.Text = imagePath

            ' Mostrar la imagen en un PictureBox (o realizar otras operaciones según tus necesidades)
            'PictureBox1.Image = Image.FromFile(imagePath)
        End If
    End Sub

    Private Sub frmCrearTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomButton(btnSeleccionar, IconChar.FileImage, "#0d1117", 10)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub
End Class
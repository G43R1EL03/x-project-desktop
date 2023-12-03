Public Class frmAgregarMarca
    Dim marcaDao As New MarcaDAO(myConnectionDB)
    Private Sub frmAgregarMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexionDB()
            myConnectionDB.Open()
            Dim marcasDataTable As DataTable = marcaDao.mostrarMarcas

            ' Limpiar el ListView antes de agregar nuevos elementos
            lsvVerMarcas.Items.Clear()

            ' Recorrer las filas del DataTable y agregar elementos al ListView
            For Each row As DataRow In marcasDataTable.Rows
                Dim item As New ListViewItem(row("nombre").ToString())
                item.Name = row("id_marca").ToString()

                lsvVerMarcas.Items.Add(item)
            Next
        Catch ex As Exception
            MsgBox("Error al realizar la conexión" & vbCrLf & "Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If myConnectionDB.State <> ConnectionState.Closed Then myConnectionDB.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lsvVerMarcas.Visible = True
    End Sub
End Class
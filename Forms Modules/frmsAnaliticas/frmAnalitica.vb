Public Class frmAnalitica
    Private Sub frmAnalitica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexionDB()
            myConnectionDB.Open()
            'MsgBox("Conexion Exitosa")
        Catch ex As Exception
            MsgBox("Error al realizar la conexion", "Error: ", ex)
        Finally
            If myConnectionDB.State <> ConnectionState.Closed Then myConnectionDB.Close()
        End Try
    End Sub
    Private Sub VENTASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VENTASToolStripMenuItem.Click
        Dim frmAnaliticaVentas As New frmAnaliticaVentas(New analitycDAO(myConnectionDB))
        frmAnaliticaVentas.MdiParent = Me
        frmAnaliticaVentas.WindowState = FormWindowState.Maximized
        frmAnaliticaVentas.Show()
    End Sub


End Class
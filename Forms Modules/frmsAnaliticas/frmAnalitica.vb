Public Class frmAnalitica
    Private Sub frmAnalitica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexionDB()
            myConnectionDB.Open()
            'MsgBox("Conexion Exitosa")
        Catch ex As Exception
            MsgBox("Error al realizar la conexion", "Error: ", ex.Message)
        Finally
            If myConnectionDB.State <> ConnectionState.Closed Then myConnectionDB.Close()
        End Try
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        SetPanel(frmMenuReportes, panelModulo5)
    End Sub

End Class
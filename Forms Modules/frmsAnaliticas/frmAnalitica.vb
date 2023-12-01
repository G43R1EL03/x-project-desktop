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


End Class
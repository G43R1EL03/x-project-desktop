Imports MySql.Data.MySqlClient
Public Class analitycDAO
    Implements analitycInterfaces

    Private myConecctionDB As MySqlConnection

    Public Sub New(myConnection As MySqlConnection)
        Me.myConecctionDB = myConecctionDB
    End Sub

    Public Function ObtenerVentasPorId(id_venta As Integer) As DataTable Implements analitycInterfaces.ObtenerVentasPorId
        Try
            Using glCommand As New MySqlCommand("SP_ObtenerVentasPorID", myConnectionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure

                Using adapter As New MySqlDataAdapter(glCommand)
                    Dim datatable As New DataTable()
                    adapter.Fill(datatable)
                    Return datatable
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al procesar la operacion", ex)
        Finally
            If myConnectionDB.State <> ConnectionState.Closed Then myConnectionDB.Close()
        End Try
    End Function

    Public Function InsertarVenta(nombre As String, monto As Double) As Integer Implements analitycInterfaces.InsertarVenta

    End Function


End Class

Imports MySql.Data.MySqlClient
Public Class ticketsDAO
    Implements ticketsInterfaces
    Private myConecctionDB As MySqlConnection
    Public Sub New(myConnection As MySqlConnection)
        Me.myConecctionDB = myConnection
    End Sub
    Public Function ObtenerReclamos() As DataTable Implements ticketsInterfaces.ObtenerReclamos
        Try
            Using glCommand As New MySqlCommand("SP_ObtenerReclamos", myConecctionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure
                Using adapter As New MySqlDataAdapter(glCommand)
                    Dim dtReclamos As New DataTable()
                    adapter.Fill(dtReclamos)
                    Return dtReclamos
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al procesar la operación", ex)
        Finally
            If myConecctionDB.State <> ConnectionState.Closed Then myConecctionDB.Close()
        End Try
    End Function
End Class

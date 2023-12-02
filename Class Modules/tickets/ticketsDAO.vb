Imports MySql.Data.MySqlClient
Imports MySqlConnector
Imports Mysqlx.XDevAPI.Common
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

    Public Function InsertarTicket() As Integer Implements ticketsInterfaces.InsertarTicket
        Dim resultado As Integer = 0
        Try
            'Dim result As Integer
            'Using glCommand As New MySqlCommand("SP_InsertarTicket", myConecctionDB)
            '    glCommand.CommandTimeout = 0
            '    glCommand.CommandType = CommandType.StoredProcedure
            '    glCommand.Parameters.AddWithValue("@p_id_cliente", id_cliente)
            '    glCommand.Parameters.AddWithValue("@p_numero_cuenta", numero_cuenta)
            '    glCommand.Parameters.AddWithValue("@p_tipo", tipo)
            '    glCommand.Parameters.AddWithValue("@p_saldo", saldo)
            '    glCommand.Parameters.AddWithValue("@p_fecha_creacion", DateTime.Now)
            '    glCommand.Parameters.AddWithValue("@p_fecha_modificacion", DateTime.Now)
            '    glCommand.Parameters.AddWithValue("@p_resultado", MySqlDbType.Int32)
            '    glCommand.Parameters("@p_resultado").Direction = ParameterDirection.Output
            '    Return result = glCommand.ExecuteNonQuery()
            'End Using
            Return resultado
        Catch ex As Exception
            Throw New Exception("Error al procesar la operación", ex)
        Finally
            If myConecctionDB.State <> ConnectionState.Closed Then myConecctionDB.Close()
        End Try
    End Function
End Class
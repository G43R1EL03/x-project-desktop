Imports MySql.Data.MySqlClient
Public Class MarcaDAO
    Implements marcaInterface

    Private myConecctionDB As MySqlConnection

    Public Sub New(myConnection As MySqlConnection)
        Me.myConecctionDB = myConecctionDB
    End Sub

    Public Function actualizarMarcas() As DataTable Implements marcaInterface.actualizarMarcas
        Try
            Using glCommand As New MySqlCommand("SP_ActualizarMarcas", myConnectionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure

                Using adapter As New MySqlDataAdapter(glCommand)
                    Dim datatable As New DataTable()
                    adapter.Fill(datatable)
                    Return datatable
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al procesar la operacion:", ex)
        End Try
    End Function


    Public Function insertarMarcas() As DataTable Implements marcaInterface.insertarMarcas
        Try
            Using glCommand As New MySqlCommand("SP_InsertarMarcas", myConnectionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure

                Using adapter As New MySqlDataAdapter(glCommand)
                    Dim datatable As New DataTable()
                    adapter.Fill(datatable)
                    Return datatable
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al procesar la operacion:", ex)
        End Try

    End Function


    Public Function mostrarMarcas() As DataTable Implements marcaInterface.mostrarMarcas
        Try
            Using glCommand As New MySqlCommand("SP_MostrarMarcas", myConnectionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure

                Using adapter As New MySqlDataAdapter(glCommand)
                    Dim datatable As New DataTable()
                    adapter.Fill(datatable)
                    Return datatable
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al procesar la operacion:", ex)
        End Try
    End Function
End Class

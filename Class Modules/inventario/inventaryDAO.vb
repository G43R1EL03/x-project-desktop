Imports System.IO
Imports MySql.Data.MySqlClient
Public Class inventaryDAO
    Implements inventaryInterfaces

    Private myConecctionDB As MySqlConnection

    Public Sub New(myConnection As MySqlConnection)
        Me.myConecctionDB = myConecctionDB
    End Sub

    Public Function LlenarDGVInventario() As DataTable Implements inventaryInterfaces.LlenarDGVInventario
        Try
            Using glCommand As New MySqlCommand("SP_LlenarDGVInventario", myConnectionDB)
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

    Public Function InsertarProducto(nombre As String, precioUnitario As Decimal, cantidadPorCajas As Integer?, puntoReorden As Integer?, cantidadCajas As Integer?, marcaId As Integer, categoriaId As Integer, imagen As Image) As Boolean Implements inventaryInterfaces.InsertarProducto
        Try
            myConnectionDB.Open()

            Using glCommand As New MySqlCommand("sp_InsertarProducto", myConnectionDB)
                glCommand.CommandType = CommandType.StoredProcedure

                glCommand.Parameters.AddWithValue("@p_nombre", nombre)
                glCommand.Parameters.AddWithValue("@p_precio_unit", precioUnitario)
                glCommand.Parameters.AddWithValue("@p_cantidad_por_cajas", If(cantidadPorCajas.HasValue, cantidadPorCajas.Value, DBNull.Value))
                glCommand.Parameters.AddWithValue("@p_punto_reorden", If(puntoReorden.HasValue, puntoReorden.Value, DBNull.Value))
                glCommand.Parameters.AddWithValue("@p_cantidad_cajas", If(cantidadCajas.HasValue, cantidadCajas.Value, DBNull.Value))
                glCommand.Parameters.AddWithValue("@p_marca_id", marcaId)
                glCommand.Parameters.AddWithValue("@p_categoria_id", categoriaId)

                ' Convertir la imagen a un arreglo de bytes
                Dim photoBytes As Byte() = Nothing
                If imagen IsNot Nothing Then
                    Using ms As New MemoryStream()
                        imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                        photoBytes = ms.ToArray()
                    End Using
                End If

                ' Agregar el parámetro para la imagen
                glCommand.Parameters.AddWithValue("@p_imagen", If(photoBytes IsNot Nothing, photoBytes, DBNull.Value))

                ' Ejecutar el procedimiento almacenado
                glCommand.ExecuteNonQuery()

                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al agregar el producto: " & ex.Message)
            Return False
        Finally
            ' Cerrar la conexión a la base de datos
            myConnectionDB.Close()
        End Try
    End Function


End Class

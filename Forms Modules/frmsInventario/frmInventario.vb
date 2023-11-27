Imports MySql.Data.MySqlClient

Public Class frmInventario
    Private Sub frmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarDGVInventario()
    End Sub

    Private Sub LlenarDGVInventario()
        Dim sqlDa As MySqlDataAdapter
        Dim dtResultado As New DataTable
        Try
            conexionDB()
            myConnection.Open()

            Dim cmd As New MySqlCommand("SP_LlenarDGVInventario", myConnection)
            cmd.CommandType = CommandType.StoredProcedure

            sqlDa = New MySqlDataAdapter(cmd)
            sqlDa.Fill(dtResultado)

            If dtResultado.Rows.Count <> 0 Then
                dgvInv.DataSource = dtResultado
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If myConnection.State <> ConnectionState.Closed Then myConnection.Close()
        End Try
    End Sub

    Private Sub tsMarcaInv_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tsProductoInv_Click(sender As Object, e As EventArgs) Handles tsProductoInv.Click

    End Sub

    Private Sub tsCategoriaInv_Click(sender As Object, e As EventArgs) Handles tsCategoriaInv.Click

    End Sub

    Private Sub tsRealizarCompraInv_Click(sender As Object, e As EventArgs) Handles tsRealizarCompraInv.Click

    End Sub
End Class
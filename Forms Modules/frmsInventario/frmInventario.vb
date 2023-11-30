Imports MySql.Data.MySqlClient

Public Class frmInventario
    Private Sub frmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LlenarDGVInventario()
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
        'Debes llamar al metodo y pasarle 2 argumentos
        'El primer argumento es el formulario que quieres abrir y el segundo el panel que contendra el formulario
        'SetPanel(frmAgregar_Marca, panelFrmInventario)
    End Sub

    Private Sub tsProductoInv_Click(sender As Object, e As EventArgs) Handles tsProductoInv.Click
        SetPanel(frmAgregarProducto, panelFrmInventario)
    End Sub

    Private Sub tsCategoriaInv_Click(sender As Object, e As EventArgs) Handles tsCategoriaInv.Click
        'SetPanel(frmAgregarCategoria, panelFrmInventario)
        frmAgregarCategoria.Show()
    End Sub

    Private Sub tsRealizarCompraInv_Click(sender As Object, e As EventArgs) Handles tsRealizarCompraInv.Click

    End Sub

    Private Sub tsMarcaEnt_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tsProductoEnt_Click(sender As Object, e As EventArgs) Handles tsProductoEnt.Click
        SetPanel(frmAgregarProducto, panelFrmInventario)
    End Sub

    Private Sub tsCategoriaEnt_Click(sender As Object, e As EventArgs) Handles tsCategoriaEnt.Click
        'SetPanel(frmAgregarCategoria, panelFrmInventario)
        frmAgregarCategoria.Show()
    End Sub

    Private Sub tsRealizarCompraEnt_Click(sender As Object, e As EventArgs) Handles tsRealizarCompraEnt.Click

    End Sub

End Class
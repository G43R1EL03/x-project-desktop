Imports MySql.Data.MySqlClient

Public Class frmInventario
    Private Sub frmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubMenu()
        LlenarDGVInventario()
    End Sub

    Private Sub hideSubMenu()
        panelSplitButonInventario.Visible = False
        panelSplitButonEntradas.Visible = False
    End Sub

    Private Sub showSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregarInventario.Click
        showSubMenu(panelSplitButonInventario)
    End Sub

    Private Sub btnAgregarEntradas_Click(sender As Object, e As EventArgs) Handles btnAgregarEntradas.Click
        showSubMenu(panelSplitButonEntradas)
    End Sub

    Private Sub btnMarca_Click(sender As Object, e As EventArgs) Handles btnMarca.Click

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
                dgvInventario.DataSource = dtResultado
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If myConnection.State <> ConnectionState.Closed Then myConnection.Close()
        End Try
    End Sub
End Class
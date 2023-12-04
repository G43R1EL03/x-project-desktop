Imports System.Windows.Controls
Imports FontAwesome.Sharp

Public Class frmAgregarMarca
    Dim invenatyDao As New inventaryDAO(myConnectionDB)
    Public MouseDownPosition
    Private Sub frmAgregarMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexionDB()
            myConnectionDB.Open()
            Dim marcasDataTable As DataTable = invenatyDao.MostarMarcas

            For Each row As DataRow In marcasDataTable.Rows
                Dim btn As New IconButton
                btn.IconChar = 62212
                dgvVerMarcas.Rows.Add(row("id_marca"), row("nombre"))
            Next

        Catch ex As Exception
            MsgBox("Error al realizar la conexión" & vbCrLf & "Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If myConnectionDB.State <> ConnectionState.Closed Then myConnectionDB.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dgvVerMarcas.Visible Then
            dgvVerMarcas.Visible = False
        Else
            dgvVerMarcas.Visible = True
        End If
    End Sub


    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown

        ' Guarda la posición del mouse
        MouseDownPosition = e.Location

    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

        ' Si el datagridview está visible y el mouse no está sobre el botón y el
        ' mouse no está sobre la posición del click inicial, lo oculta
        If dgvVerMarcas.Visible Then
            If Not dgvVerMarcas.HitTest(e.X, e.Y) Is Button1 And Not e.Location = MouseDownPosition Then
                dgvVerMarcas.Visible = False
            End If
        End If

    End Sub

    Private Sub dgvVerMarcas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVerMarcas.CellContentClick
        If dgvVerMarcas.Columns(e.ColumnIndex).Name = "editar" Then
            'aqui se obtiene el id del (la columna del DataGridView se llama id)
        Else
            'elimina la marca
        End If
    End Sub
End Class
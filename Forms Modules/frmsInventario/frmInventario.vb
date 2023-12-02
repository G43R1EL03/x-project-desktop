Imports MySql.Data.MySqlClient

Public Class frmInventario

    'Private invenatyDao As inventaryDAO

    'Public Sub New(inventaryDAO As inventaryDAO)
    ' Esta llamada es exigida por el diseñador.
    'InitializeComponent()
    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    'Me.invenatyDao = inventaryDAO
    'End Sub

    Private Sub frmAnalitica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim id_venta
            'Dim ventasDataTable As DataTable = invenatyDao.LlenarDGVInventario
            'dgvInv.DataSource = ventasDataTable

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tsMarcaInv_Click(sender As Object, e As EventArgs)
        'Debes llamar al metodo y pasarle 2 argumentos
        'El primer argumento es el formulario que quieres abrir y el segundo el panel que contendra el formulario
        SetPanel(frmAgregarMarca, panelFrmInventario)
    End Sub

    Private Sub tsProductoInv_Click(sender As Object, e As EventArgs) Handles tsProductoInv.Click
        SetPanel(frmAgregarProducto, panelFrmInventario)
    End Sub

    Private Sub tsCategoriaInv_Click(sender As Object, e As EventArgs) Handles tsCategoriaInv.Click
        Dim userInput As String
        userInput = InputBox("Introduzca el nombre de la categoria que desee agregar:", "Agregar Categoria")
    End Sub

    Private Sub tsRealizarCompraInv_Click(sender As Object, e As EventArgs) Handles tsRealizarCompraInv.Click

    End Sub

    Private Sub tsMarcaEnt_Click(sender As Object, e As EventArgs)
        SetPanel(frmAgregarMarca, panelFrmInventario)
    End Sub

    Private Sub tsProductoEnt_Click(sender As Object, e As EventArgs) Handles tsProductoEnt.Click
        SetPanel(frmAgregarProducto, panelFrmInventario)
    End Sub

    Private Sub tsCategoriaEnt_Click(sender As Object, e As EventArgs) Handles tsCategoriaEnt.Click
        Dim userInput As String
        userInput = InputBox("Introduzca el nombre de la categoria que desee agregar:", "Agregar Categoria")
    End Sub

    Private Sub tsRealizarCompraEnt_Click(sender As Object, e As EventArgs) Handles tsRealizarCompraEnt.Click

    End Sub

    Private Sub tsAgregarInv_Click(sender As Object, e As EventArgs)

    End Sub
End Class
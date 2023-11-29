Public Class frmAnaliticaVentas
    Private analiticDAo As analitycInterfaces

    Public Sub New(analiticDAO As analitycInterfaces)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.analiticDAo = analiticDAO
    End Sub

    Private Sub frmAnalitica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim id_venta
            Dim ventasDataTable As DataTable = analiticDAo.ObtenerVentasPorId(id_venta)
            dgvVentasPorID.DataSource = ventasDataTable
            dgvVentasPorID.Columns("id_venta").HeaderText = "Identificador de venta"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
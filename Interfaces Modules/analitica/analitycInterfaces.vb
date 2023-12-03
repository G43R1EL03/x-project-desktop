Public Interface analitycInterfaces
    Function ObtenerVentasPorId(id_venta As Integer) As DataTable
    Function InsertarVenta(nombre As String, monto As Double) As Integer
End Interface

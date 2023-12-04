Public Interface inventaryInterfaces
    Function LlenarDGVInventario() As DataTable
    Function InsertarProducto(nombre As String, precioUnitario As Decimal, cantidadPorCajas As Integer?, puntoReorden As Integer?, cantidadCajas As Integer?, marcaId As Integer, categoriaId As Integer, imagen As Image) As Boolean

    Function MostarMarcas() As DataTable

    Function mostrarMarcas() As DataTable
    Function insertarMarcas() As DataTable
    Function actualizarMarcas() As DataTable

End Interface

Imports System.Collections.Generic

Public Class entradaLibros

    Public Property numComprobante() As Integer
    Public Property numFactura() As Integer
    Public Property numNotaPedido() As Integer

    Public detalleEntrada As New List(Of entradaLibrosDet)()

End Class

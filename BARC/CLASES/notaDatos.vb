Imports System.Collections.Generic

Public Class notaDatos

    Public Property fechaEmision() As DateTime
    Public Property compNotaPedido() As Integer
    Public Property nSoliCompra() As Integer
    Public Property nomProveedor() As String

    Public Detail As New List(Of notaDetalles)()

End Class

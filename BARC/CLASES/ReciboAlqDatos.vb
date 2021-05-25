Imports System.Collections.Generic
Public Class ReciboAlqDatos

    Public Property NRecibo() As Integer
    Public Property FechaEmision() As DateTime '  "
    Public Property FechaHasta() As DateTime '    "
    Public Property FechaVenceAlq() As DateTime
    Public Property FechaTopeAlq() As DateTime
    Public Property TipoDocumento() As String ' Recibo
    Public Property IdenDocumento() As String ' C
    Public Property CopiaDocumento() As String ' original Copia
    Public Property DNISocio() As Integer
    Public Property ApeNombre() As String
    Public Property CondicionIVA() As String
    Public Property DomicilioSocio() As String
    Public Property condVenta() As String
    Public Property SubTotal() As Decimal
    Public Property Total() As Decimal
    Public Property TotalLetrasR() As String
    Public Property CantSemanas() As String

    Public Detail As New List(Of ReciboAlqArt)()

End Class

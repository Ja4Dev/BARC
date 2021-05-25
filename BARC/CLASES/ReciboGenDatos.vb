Imports System.Collections.Generic
Public Class ReciboGenDatos

    Public Property NRecibo() As Integer
    Public Property FechaEmision() As DateTime '  "
    Public Property FechaHasta() As String '    "
    Public Property FechaVenceAlq() As String
    Public Property FechaTopeAlq() As String
    Public Property TipoDocumento() As String ' Recibo
    Public Property IdenDocumento() As String ' nadaxd
    Public Property CopiaDocumento() As String ' original Copia
    Public Property DNISocio() As Integer
    Public Property ApeNombre() As String
    Public Property CondicionIVA() As String
    Public Property DomicilioSocio() As String
    Public Property condVenta() As String
    Public Property SubTotal() As Decimal
    Public Property Total() As Decimal
    Public Property TotalLetrasR() As String
    Public Property CantSemanas() As String ' MOTIVOO

End Class

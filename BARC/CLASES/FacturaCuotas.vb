Imports System.Collections.Generic

Public Class FacturaCuotas

    ' Datos del encabezado

    Public Property CodFactura() As Integer
    Public Property SubtotalFactura() As Decimal
    Public Property FechaFacturacion() As DateTime
    Public Property HastaFecha() As DateTime
    Public Property VenceFecha() As DateTime
    Public Property TipoDocumento() As String
    Public Property IdenDocumento() As String
    Public Property CopiaDocumento() As String
    Public Property DNISocio() As Integer
    Public Property ApeNombre() As String
    Public Property CondicionIVA() As String
    Public Property DomicilioSocio() As String
    Public Property condVenta() As String
    Public Property TotalLetras() As String
    Public Property CantCuotas() As String

    Public Detail As New List(Of FacturaCuotasArt)()

End Class

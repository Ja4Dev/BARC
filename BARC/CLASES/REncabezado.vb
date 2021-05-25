Imports System.Collections.Generic

Public Class REncabezado

    Public Property CodRemito() As Integer
    Public Property SubtotalRemito() As Decimal
    Public Property FechaRemito() As DateTime
    Public Property TipoDocumento() As String
    Public Property IdenDocumento() As String
    Public Property CopiaDocumento() As String
    Public Property DNISocio() As Integer
    Public Property ApeNombre() As String
    Public Property CondicionIVA() As String
    Public Property DomicilioSocio() As String
    Public Property TotalLetras() As String
    Public Property SubTotalSem() As Decimal
    Public Property CantSemanas() As String

    Public Detail As New List(Of FacturaCuotasArt)()

End Class

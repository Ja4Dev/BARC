Imports Microsoft.Reporting.WinForms

Public Class notapedidoPreview

    Public notaDatos As New List(Of notaDatos)()

    Public notaDetalle As New List(Of notaDetalles)()

    Private Sub notapedidoPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ReportViewer1.LocalReport.DataSources.Clear()

        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("notaPedidoDatos", notaDatos))

        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("notaPedidoDetalles", notaDetalle))

        ReportViewer1.RefreshReport()

    End Sub
End Class
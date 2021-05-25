Imports Microsoft.Reporting.WinForms

Public Class entradaPreview

    Public Invoice As New List(Of entradaLibros)()
    Public Detail As New List(Of entradaLibrosDet)()

    Private Sub entradaPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ReportViewer1.LocalReport.DataSources.Clear()

        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("CompEntradaLibros", Invoice))
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("CompEntradaLibrosDet", Detail))

        ReportViewer1.RefreshReport()

    End Sub
End Class
Imports Microsoft.Reporting.WinForms

Public Class remitoPreview

    Public Invoice As New List(Of REncabezado)()
    Public Detail As New List(Of FacturaCuotasArt)()

    Private Sub remitoPreview_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Limpiemos el DataSource del informe
        ReportViewer1.LocalReport.DataSources.Clear()
        '

        '
        'Establezcamos la lista como Datasource del informe
        '
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("remitoEncabezado", Invoice))
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("remitoDetalle", Detail))
        '

        '
        'Hagamos un refresh al reportViewer
        '
        ReportViewer1.RefreshReport()

    End Sub
End Class
Imports Microsoft.Reporting.WinForms
Public Class ReciboGenericoPreview

    Public Invoice As New List(Of ReciboGenDatos)()

    Private Sub ReciboGenericoPreview_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Limpiemos el DataSource del informe
        ReportViewer1.LocalReport.DataSources.Clear()
        '

        '
        'Establezcamos la lista como Datasource del informe
        '
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Encabezado", Invoice))
        '

        '
        'Hagamos un refresh al reportViewer
        '
        ReportViewer1.RefreshReport()
    End Sub
End Class
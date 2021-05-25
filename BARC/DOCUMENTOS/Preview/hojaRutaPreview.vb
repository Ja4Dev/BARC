Imports Microsoft.Reporting.WinForms

Public Class hojaRutaPreview

    Public Ehojaruta As New List(Of hdruta)()
    Public Dhojaruta As New List(Of hdrutaDetalle)()

    Private Sub hojaRutaPreview_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ReportViewer1.LocalReport.DataSources.Clear()

        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("datosHojaRuta", Ehojaruta))
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("detHojaRuta", Dhojaruta))

        ReportViewer1.RefreshReport()

    End Sub
End Class
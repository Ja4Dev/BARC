Imports Microsoft.Reporting.WinForms

Public Class asistEventos

    Public EvenDatos As New List(Of asistEventosDatos)()

    Private Sub asistEventos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ReportViewer1.LocalReport.DataSources.Clear()

        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("datosEvento", EvenDatos))

        ReportViewer1.RefreshReport()

    End Sub
End Class
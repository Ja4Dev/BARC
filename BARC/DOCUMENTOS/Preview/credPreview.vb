Imports Microsoft.Reporting.WinForms

Public Class credPreview

    Public SocDatos As New List(Of SocioDatos)()

    Private Sub credPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ReportViewer2.LocalReport.DataSources.Clear()

        ReportViewer2.LocalReport.DataSources.Add(New ReportDataSource("DatosSocio", SocDatos))

        ReportViewer2.RefreshReport()

    End Sub

End Class
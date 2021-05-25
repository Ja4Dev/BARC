Imports Microsoft.Reporting.WinForms
Imports System.Threading.Thread
Imports System.Globalization


Public Class chequePreview

    Public CheqDatos As New List(Of chequeDatos)()

    Private Sub chequePreview_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("EN-US")
    End Sub


    Private Sub chequePreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ReportViewer1.LocalReport.DataSources.Clear()

        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("ChequeDatos", CheqDatos))

        ReportViewer1.RefreshReport()

    End Sub
End Class
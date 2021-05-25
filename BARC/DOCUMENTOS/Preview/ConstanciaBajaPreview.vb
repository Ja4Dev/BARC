Imports Microsoft.Reporting.WinForms

Public Class ConstanciaBajaPreview

    Public SocDatos As New List(Of ConstanciaBajaDatos)()

    Private Sub ConstanciaBajaPreview_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If formulario = "darbajasocio" Then
            MsgBox("Socio dado de Baja Satisfactoriamente", MsgBoxStyle.OkOnly, "Aviso")
            Baja.Close()
            DataSocios.Show()
            Socios.Show()
            formulario = "modulo_socios"
        End If
    End Sub

    Private Sub ConstanciaBajaPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewerCB.LocalReport.DataSources.Clear()

        Me.ReportViewerCB.LocalReport.DataSources.Add(New ReportDataSource("Constancia", SocDatos))

        Me.ReportViewerCB.RefreshReport()
    End Sub

End Class
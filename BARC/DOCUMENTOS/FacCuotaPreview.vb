Imports Microsoft.Reporting.WinForms

Public Class FacCuotaPreview

    '
    'Cree dos listas una para el Encabezado y otra para el detalle
    '
    Public Invoice As New List(Of FacturaCuotas)()
    Public Detail As New List(Of FacturaCuotasArt)()

    Private Sub facCupta_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing


        If formulario = "modulo_socios" Then

        ElseIf formulario = "modulo_cobros" Then


        ElseIf formulario = "modulo_compras" Then
            MsgBox("Compra realizada Satisfactoriamente.")
            Facturacion.Close()
            VentasAlquileres.Close()
            CatalogoLibros.Close()
            splash.Focus()
            splash.BringToFront()
            Main.Show()
            Main.Focus()

        End If

    End Sub
    '
    'Cree las propiedades publicas Titulo y Empresa
    '

    Private Sub FacturaCuotas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Limpiemos el DataSource del informe
        ReportViewerCuotasFac.LocalReport.DataSources.Clear()
        '

        '
        'Establezcamos la lista como Datasource del informe
        '
        ReportViewerCuotasFac.LocalReport.DataSources.Add(New ReportDataSource("Encabezado", Invoice))
        ReportViewerCuotasFac.LocalReport.DataSources.Add(New ReportDataSource("Detalle", Detail))
        '

        '
        'Hagamos un refresh al reportViewer
        '
        ReportViewerCuotasFac.RefreshReport()

    End Sub

End Class
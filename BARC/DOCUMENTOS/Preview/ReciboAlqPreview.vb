Imports Microsoft.Reporting.WinForms
Public Class ReciboAlqPreview

    Public Invoice As New List(Of ReciboAlqDatos)()
    Public Detail As New List(Of ReciboAlqArt)()

    Private Sub ReciboPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Limpiemos el DataSource del informe
        ReportViewer3.LocalReport.DataSources.Clear()
        '

        '
        'Establezcamos la lista como Datasource del informe
        '
        ReportViewer3.LocalReport.DataSources.Add(New ReportDataSource("Encabezado", Invoice))
        ReportViewer3.LocalReport.DataSources.Add(New ReportDataSource("Detalle", Detail))
        '

        '
        'Hagamos un refresh al reportViewer
        '
        ReportViewer3.RefreshReport()
    End Sub

    Private Sub ReciboAlqPreview_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing


        If formulario = "modulo_socios" Then

        ElseIf formulario = "modulo_cobros" Then


        ElseIf formulario = "modulo_compras" Then
            MsgBox("Alquiler Realizado Satisfactoriamente.")
            Facturacion.Close()
            VentasAlquileres.Close()
            CatalogoLibros.Close()
            splash.Focus()
            splash.BringToFront()
            Main.Show()
            Main.Focus()

        End If

    End Sub
End Class
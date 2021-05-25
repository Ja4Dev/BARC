Imports Microsoft.Reporting.WinForms

Public Class FacCuotasPreview

    Public Invoice As New List(Of FacturaCuotas)()
    Public Detail As New List(Of FacturaCuotasArt)()


    Private Sub facremPreview_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing


        If formulario = "modulo_socios" Then

        ElseIf formulario = "modulo_cobros" Then


        ElseIf formulario = "modulo_compras" Then
            If nuevo = True Then
                InvoiceGenerate("ConstanciaAdmision")
            Else
                MsgBox("Compra realizada Satisfactoriamente.")
                Facturacion.Close()
                VentasAlquileres.Close()
                CatalogoLibros.Close()
                splash.Focus()
                splash.BringToFront()
                Main.Show()
                Main.Focus()
            End If

        End If

    End Sub

    Private Sub FacCuotasPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Limpiemos el DataSource del informe
        ReportViewer1.LocalReport.DataSources.Clear()
        '

        '
        'Establezcamos la lista como Datasource del informe
        '
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Encabezado", Invoice))
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Detalle", Detail))
        '

        '
        'Hagamos un refresh al reportViewer
        '
        ReportViewer1.RefreshReport()

    End Sub
End Class
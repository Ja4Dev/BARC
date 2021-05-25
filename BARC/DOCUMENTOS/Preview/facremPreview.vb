Imports Microsoft.Reporting.WinForms

Public Class facremPreview

    '
    'Cree dos listas una para el Encabezado y otra para el detalle
    '
    Public Invoice As New List(Of FEncabezado)()
    Public Detail As New List(Of FArticulo)()

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
    '
    'Cree las propiedades publicas Titulo y Empresa
    '

    Private Sub FacturaRpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Limpiemos el DataSource del informe
        ReportViewer1.LocalReport.DataSources.Clear()
        '

        '
        'Establezcamos la lista como Datasource del informe
        '
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("EncabezadoF", Invoice))
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Detalle", Detail))
        '

        '
        'Hagamos un refresh al reportViewer
        '
        ReportViewer1.RefreshReport()

    End Sub

End Class
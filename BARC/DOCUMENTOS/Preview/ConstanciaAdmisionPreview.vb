Imports Microsoft.Reporting.WinForms

Public Class ConstanciaAdmisionPreview

    Public SocDatos As New List(Of ConstanciaAdmisionDatos)()

    Private Sub ConstanciaAdmisionPreview_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MsgBox("Compra realizada Satisfactoriamente.")
        nuevo = False
        Facturacion.Close()
        VentasAlquileres.Close()
        CatalogoLibros.Close()
        splash.Focus()
        splash.BringToFront()
        Main.Show()
        Main.Focus()
    End Sub

    Private Sub ConstanciaBajaPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.LocalReport.DataSources.Clear()

        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Constancia", SocDatos))

        Me.ReportViewer1.RefreshReport()

    End Sub

End Class
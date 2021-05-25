Public Class frmEventos

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub btnCrearEv_Click(sender As System.Object, e As System.EventArgs) Handles btnCrearEv.Click
        Me.Close()
        CrearEvento.Show()
    End Sub

    Private Sub btnEventos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEventos.Click
        Me.Close()
        EventosLista.Show()
    End Sub

    Private Sub btnRegistrarAsis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarAsis.Click
        Me.Close()
        RegistrarAsis.Show()
    End Sub

    Private Sub frmEventos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Eventos - Sesion iniciada como : " & user
    End Sub
End Class
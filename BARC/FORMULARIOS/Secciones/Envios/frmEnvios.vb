Public Class frmEnvios

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub btnhojasRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhojasRuta.Click
        Me.Close()
        HojasRuta.Show()
    End Sub

    Private Sub btnEnvios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnvios.Click
        Me.Close()
        EnviosVer.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        EnviosActualizar.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        CorredoresEdicion.Show()
    End Sub

    Private Sub btnRecorridos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecorridos.Click
        Me.Close()
        RecorridosCorredores.Show()
    End Sub

    Private Sub frmEnvios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Envios - Sesion iniciada como : " & user
    End Sub
End Class
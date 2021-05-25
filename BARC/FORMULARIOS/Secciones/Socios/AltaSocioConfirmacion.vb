Public Class AltaSocioConfirmacion

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        DataSocios.Show()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Consulta("update socios set estado = 'Al dia' where codsocio = " & codsoc & "")
        Me.Close()
        DataSocios.Close()
        Socios.Show()
    End Sub
End Class
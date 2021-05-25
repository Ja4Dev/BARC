Public Class DataSocios

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        Socios.Show()
    End Sub

    Private Sub btnBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click
        If SocioBaja = True Then
            Me.Hide()
            AltaSocioConfirmacion.Show()
        Else
            Me.Hide()
            Baja.Show()
        End If
    End Sub

    Private Sub btnCompras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompras.Click
        Me.Hide()
        operacion = False
        ComprasSocio.Show()
    End Sub

    Private Sub btnAlquileres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlquileres.Click
        Me.Hide()
        operacion = True
        ComprasSocio.Show()
    End Sub

    Private Sub DataSocios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If user = "administracion" Then
            btnBaja.Enabled = False
        End If
        If SocioBaja = True Then
            btnBaja.Text = "Dar de Alta"
            btnConstanciaBaja.Enabled = True
            btnConstanciaBaja.Visible = True
            Height = 388
            Width = 379
        Else
            btnBaja.Text = "Dar de Baja"
            Height = 338
            Width = 379
        End If
    End Sub

    Private Sub btnCredencial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCredencial.Click
        InvoiceGenerate("CredSocio")
    End Sub

    Private Sub btnConstanciaBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConstanciaBaja.Click
        InvoiceGenerate("Constanciabaja")
    End Sub
End Class
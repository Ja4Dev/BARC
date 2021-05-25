Public Class FacturaOrecibo

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFactura.Click
        InvoiceGenerate("Factura_Ver")
        Me.Close()
    End Sub

    Private Sub btnRecibo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecibo.Click
        InvoiceGenerate("ReciboGen")
        Me.Close()
    End Sub
End Class
Public Class RegistrarPago
    Dim Corredor As Integer

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If formulario = "modulo_cobros" Then
            ComprasSocio.btnCambEstado.Enabled = False
            Me.Close()
            ComprasSocio.Show()
        End If
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        ComprasSocio.btnCambEstado.Enabled = False
        If operacion = False Then
            Consulta("UPDATE Compras SET Estado = 'Pagado' WHERE Codcompra = " & CodCompra)
            ComprasSocio.lstOperacion.Items(IndiceOperacion).SubItems(2).Text = "Pagado"
            MsgBox("Pago Registrado Satisfactoriamente", MsgBoxStyle.OkOnly, "Cobros")
            If Interes = 0 Then
                Consulta("INSERT INTO Recibos VALUES ('', CURDATE()," & codsoc & ", " & total & ", " & CodCompra & ", NULL, " & codigoCorredor & ", 0, 'Pago de Compra')")
            Else
                Consulta("INSERT INTO Recibos VALUES ('', CURDATE()," & codsoc & ", " & total & ", " & CodCompra & ", NULL, " & codigoCorredor & ", " & Interes & ", 'Pago de Compra')")
            End If
            Consulta("SELECT NRecibo FROM Recibos WHERE CodCompra = " & CodCompra)
            rd.Read()
        Else
            Consulta("UPDATE Alquileres SET Estadopago = 'Pagado' WHERE CodAlquiler = " & CodCompra)
            ComprasSocio.lstAlquileres.Items(IndiceOperacion).SubItems(2).Text = "Pagado"
            MsgBox("Pago Registrado Satisfactoriamente", MsgBoxStyle.OkOnly, "Cobros")
            If Interes = 0 Then
                Consulta("INSERT INTO Recibos VALUES ('', CURDATE()," & codsoc & ", " & total & ", NULL, " & CodCompra & ", " & codigoCorredor & ", 0, 'Pago de Alquiler')")
            Else
                Consulta("INSERT INTO Recibos VALUES ('', CURDATE()," & codsoc & ", " & total & ", NULL, " & CodCompra & ", " & codigoCorredor & ", " & Interes & ", 'Pago de Alquiler')")
            End If
            Consulta("SELECT NRecibo FROM Recibos WHERE CodAlquiler = " & CodCompra)
            rd.Read()
        End If
        NumRecibo = rd(0)
        InvoiceGenerate("ReciboGen")

        Me.Close()
        ComprasSocio.Show()
    End Sub

    Private Sub btnBuscarCorredor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCorredor.Click
        formulario = "RegistrarPago"
        buscarCorredor.ShowDialog()
    End Sub

    Private Sub RegistrarPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnRegistrar.Enabled = False
        lblCorredorCod.Visible = False
        lblCorredorNom.Visible = False
        lblSeleccionar.Visible = True
    End Sub
End Class
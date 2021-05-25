Public Class CambiarestadoConf
    Dim Corredor As Integer

    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click
        If formulario = "modulo_cobros" Then
            ComprasSocio.btnCambEstado.Enabled = False
            Me.Close()
            ComprasSocio.Show()
        End If
    End Sub

    Private Sub btnSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSi.Click
        ComprasSocio.btnCambEstado.Enabled = False
        If operacion = False Then
            Consulta("UPDATE Compras SET Estado = 'Pagado' WHERE Codcompra = " & CodCompra)
            ComprasSocio.lstOperacion.Items(IndiceOperacion).SubItems(2).Text = "Pagado"
            MsgBox("Pago Registrado Satisfactoriamente", MsgBoxStyle.OkOnly, "Cobros")
            MsgBox("Generar Recibo de Pago")
            If Interes = 0 Then
                Consulta("INSERT INTO Recibos VALUES ('', CURDATE()," & codsoc & ", " & total & ", " & CodCompra & ", NULL, " & Corredor & ", NULL, 'Pago de Compra')")
            Else
                Consulta("INSERT INTO Recibos VALUES ('', CURDATE()," & codsoc & ", " & total & ", " & CodCompra & ", NULL, " & Corredor & ", " & Interes & ", 'Pago de Compra')")
            End If
        Else
            Consulta("UPDATE Alquileres SET Estadopago = 'Pagado' WHERE CodAlquiler = " & CodCompra)
            ComprasSocio.lstAlquileres.Items(IndiceOperacion).SubItems(2).Text = "Pagado"
            MsgBox("Pago Registrado Satisfactoriamente", MsgBoxStyle.OkOnly, "Cobros")
            MsgBox("Generar Recibo de Pago")
            If Interes = 0 Then
                Consulta("INSERT INTO Recibos VALUES ('', CURDATE()," & codsoc & ", " & total & ", NULL, " & CodCompra & ", " & Corredor & ", NULL, 'Pago de Alquiler')")
            Else
                Consulta("INSERT INTO Recibos VALUES ('', CURDATE()," & codsoc & ", " & total & ", NULL, " & CodCompra & ", " & Corredor & ", " & Interes & ", 'Pago de Alquiler')")
            End If
        End If
        Me.Close()
        ComprasSocio.Show()
    End Sub

    Private Sub btnValidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValidar.Click
        If Trim(txtCorredor.Text) = "" Then
            MsgBox("Ingrese un Dato Valido", MsgBoxStyle.OkOnly, "Aviso")
        Else
            Consulta("SELECT CodCorredor, Nombre, Apellido FROM Corredores WHERE CodCorredor = " & Val(txtCorredor.Text))
            If rd.Read Then
                Corredor = rd(0)
                lblCorredorData.Text = rd(1) & " " & rd(2)
            Else
                MsgBox("El corredor no Existe, Ingrese uno valido", MsgBoxStyle.OkOnly, "Atencion")
                txtCorredor.Clear()
                txtCorredor.Focus()
            End If
        End If
    End Sub
End Class
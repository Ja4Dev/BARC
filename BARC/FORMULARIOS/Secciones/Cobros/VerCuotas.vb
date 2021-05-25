Public Class VerCuotas
    Dim indice As Integer
    Dim ans As Integer
    Dim pagadostodo As Boolean

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        pagadostodo = True
        For Each item In lstCuotas.Items
            If item.SubItems(4).Text = "No Pagado" Then
                pagadostodo = False
            End If
        Next item
        If pagadostodo = True Then
            Consulta("UPDATE Compras SET Estado = 'Pagado' WHERE CodCompra = " & CodCompra)
        End If
        Me.Close()
        ComprasSocio.Show()
    End Sub

    Private Sub VerCuotas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        indice = 0
        Consulta("SELECT * FROM Cuotas WHERE CodCompra = " & CodCompra)
        BanderaRS = 1
        While rd.Read
            lstCuotas.Items.Add(rd(1))
            lstCuotas.Items(indice).SubItems.Add(Format(rd(2), "dd/MM/yyyy"))
            Consulta("SELECT DATEDIFF(CURDATE(), " & Format(rd(2), "yyyyMMdd") & ")")
            rd2.Read()
            If rd2(0) > 0 Then
                Consulta("CALL InteresesProce(" & rd2(0) & ", @Dias)")
                Consulta("SELECT @Dias")
                rd2.Read()
                Consulta("SELECT Porcentaje FROM Intereses WHERE DiasAtrasados = " & rd2(0))
                rd2.Read()
                Interes = rd2(0)
                total = rd(3)
                lstCuotas.Items(indice).SubItems.Add(total + ((total * Interes) / 100))
            Else
                lstCuotas.Items(indice).SubItems.Add(rd(3))
            End If
            If IsDBNull(rd(4)) Then
                lstCuotas.Items(indice).SubItems.Add("-")
            Else
                lstCuotas.Items(indice).SubItems.Add(Format(rd(4), "dd/MM/yyyy"))
            End If
            If rd(5) = 0 Then
                lstCuotas.Items(indice).SubItems.Add("No Pagado")
            Else
                lstCuotas.Items(indice).SubItems.Add("Pagado")
            End If
            indice += 1
        End While
        BanderaRS = 0
    End Sub

    Private Sub lstCuotas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCuotas.SelectedIndexChanged

        If formulario = "modulo_cobros" Then

            If lstCuotas.FocusedItem.SubItems(4).Text = "No Pagado" Then
                btnPagar.Enabled = True
            Else
                btnPagar.Enabled = False
            End If

        End If

        If lstCuotas.FocusedItem.SubItems(4).Text = "No Pagado" Then
            btnReciboCuota.Enabled = False
        Else

            btnReciboCuota.Enabled = True
        End If

    End Sub

    Private Sub btnVerFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerFactura.Click
        'cantcuota & " cuotas de $" & preciocuota
        Consulta("SELECT COUNT(*), Monto FROM Cuotas WHERE CodCompra = " & CodCompra)
        rd.Read()
        cantcuota = rd(0)
        preciocuota = rd(1)
        InvoiceGenerate("FacturaCuota_Ver")
    End Sub

    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click
        buscarCorredor.ShowDialog()
        ans = MsgBox("Seguro que Desea Registrar el Pago?", MsgBoxStyle.YesNo, "Atencion")
        If ans = 6 Then
            Consulta("UPDATE Cuotas SET FPago = CURDATE(), EstadoPago = 1 WHERE CodCompra = " & CodCompra & " AND NumCuota = " & Val(lstCuotas.FocusedItem.Text))
            Consulta("SELECT FVencimiento FROM Cuotas WHERE CodCompra = " & CodCompra & " AND NumCuota = " & Val(lstCuotas.FocusedItem.Text))
            rd.Read()
            Consulta("SELECT DATEDIFF(CURDATE(), " & Format(rd(0), "yyyyMMdd") & ")")
            rd.Read()
            If rd(0) > 0 Then
                Consulta("CALL InteresesProce(" & rd(0) & ", @Dias)")
                Consulta("SELECT @Dias")
                rd.Read()
                Consulta("SELECT Porcentaje FROM Intereses WHERE DiasAtrasados = " & rd(0))
                rd.Read()
                Interes = rd(0)
                total = Val(lstCuotas.FocusedItem.SubItems(2).Text)
                total = total + ((total * Interes) / 100)
            Else
                total = Val(lstCuotas.FocusedItem.SubItems(2).Text)
                Interes = 0
            End If
            Consulta("INSERT INTO Recibos VALUES ('', CURDATE(), " & codsoc & ", " & total & ", " & CodCompra & ", NULL, " & codigoCorredor & ", " & Interes & ", 'Pago de Cuota Numero " & lstCuotas.FocusedItem.Text & "')")
            lstCuotas.FocusedItem.SubItems(3).Text = Format(Now(), "dd/MM/yyyy")
            lstCuotas.FocusedItem.SubItems(4).Text = "Pagado"
            Consulta("SELECT NRecibo FROM Recibos WHERE  Motivo = 'Pago de Cuota Numero " & lstCuotas.FocusedItem.Text & "' AND CodCompra = " & CodCompra)
            rd.Read()
            NumRecibo = rd(0)
            InvoiceGenerate("ReciboGen")
            MsgBox("El pago ha sido Registrado Satisfactoriamente.", MsgBoxStyle.OkOnly, "Aviso")
        End If
    End Sub

    Private Sub btnReciboCuota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReciboCuota.Click
        Consulta("SELECT NRecibo FROM Recibos WHERE Motivo = 'Pago de Cuota Numero " & lstCuotas.FocusedItem.Text & "' AND CodCompra =" & CodCompra)
        rd.Read()
        NumRecibo = rd(0)
        InvoiceGenerate("ReciboGen")

    End Sub
End Class
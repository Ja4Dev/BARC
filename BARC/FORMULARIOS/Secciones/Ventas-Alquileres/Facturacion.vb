Public Class Facturacion

    Dim i As Integer
    Dim ans As Integer
    Dim FechaTope As Date

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        CatalogoLibros.Show()
        lstCompra.Items.Clear()
        total = 0
        numCantSemanas.Value = 1
    End Sub

    Private Sub btnConfirmarOperacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmarOperacion.Click
        ans = MsgBox("Desea Confirmar la Operación?", MsgBoxStyle.YesNo, "Atencion")
        If ans = 6 Then
            If nuevo = True Then 'si el socio es nuevo
                i = 0
                If operacion = False Then ' si es una compra
                    Consulta("CALL AltaCompraNuevo(" & codsoc & ", '" & tipopago & "', " & cantcuota & ", " & codigoCorredor & ", " & preciocuota & ")")
                    For Each item In lstCompra.Items
                        Consulta("CALL AltaCompras(" & Val(lstCompra.Items(i).Text) & ", " & codsoc & ", " & Val(lstCompra.Items(i).SubItems(4).Text) & ", " & Val(lstCompra.Items(i).SubItems(5).Text) & ")")
                        i = i + 1
                    Next item
                    Consulta("SELECT MAX(CodCompra) FROM Compras")
                    rd.Read()
                    CodCompra = rd(0)
                    If rdbEnvioSI.Checked = True Then
                        Consulta("INSERT INTO Envios VALUES ('', NULL, NULL, " & rd(0) & ", 'Pendiente')")
                    End If
                    If tipopago = "Contado" Then
                        InvoiceGenerate("Factura")
                    Else
                        InvoiceGenerate("FacturaCuota")
                    End If
                    Consulta("INSERT INTO Facturas VALUES ('', curdate(), " & codsoc & ", " & total & ", " & CodCompra & ")")
                Else
                    'si es alquiler
                    CantsemanasAlq = numCantSemanas.Value
                    Consulta("SELECT DATE_ADD( curdate(), INTERVAL " & numCantSemanas.Value & " WEEK )")
                    rd.Read()
                    FechaTope = rd(0)
                    FechaTopeAlqAux = rd(0)
                    Consulta("CALL AltaAlquilerNuevo(" & codsoc & ", '" & Format(FechaTope, "yyyy/MM/dd") & "', " & codigoCorredor & ")")
                    For Each item In lstCompra.Items
                        Consulta("CALL AltaAlquilerD(" & Val(item.Text) & ", " & codsoc & ", " & Val(item.Subitems(4).Text) & ", " & Val(item.Subitems(5).Text) & ")")
                    Next item
                    Consulta("SELECT MAX(CodAlquiler) FROM Alquileres")
                    rd.Read()
                    CodCompra = rd(0)
                    If rdbEnvioSI.Checked = True Then
                        Consulta("INSERT INTO Envios VALUES ('', NULL, " & CodCompra & ", NULL, 'Pendiente')")
                    End If
                    InvoiceGenerate("ReciboAlq")
                    Consulta("INSERT INTO Recibos VALUES ('', CURDATE(), " & codsoc & ", " & total & ", NULL, " & CodCompra & ", " & codigoCorredor & ", 0, 'Recibo de Alquiler')")
                End If
            Else ' si el socio no es nuevo
                i = 0
                If operacion = False Then ' si es una compra

                    Consulta("CALL AltaCompra(" & codsoc & ", '" & tipopago & "', " & cantcuota & ", " & codigoCorredor & ", " & preciocuota & ")")
                    For Each item In lstCompra.Items
                        Consulta("CALL AltaCompras(" & Val(lstCompra.Items(i).Text) & ", " & codsoc & ", " & Val(lstCompra.Items(i).SubItems(4).Text) & ", " & Val(lstCompra.Items(i).SubItems(5).Text) & ")")
                        i = i + 1
                    Next item
                    Consulta("SELECT MAX(CodCompra) FROM Compras")
                    rd.Read()
                    CodCompra = rd(0)
                    If rdbEnvioSI.Checked = True Then
                        Consulta("INSERT INTO Envios VALUES ('', NULL, NULL, " & rd(0) & ", 'Pendiente')")
                    End If

                    If tipopago = "Contado" Then
                        InvoiceGenerate("Factura")
                    Else
                        InvoiceGenerate("FacturaCuota")
                    End If
                    Consulta("INSERT INTO Facturas VALUES ('', curdate(), " & codsoc & ", " & total & ", " & CodCompra & ")")
                Else ' si es un alquiler
                    CantsemanasAlq = numCantSemanas.Value
                    Consulta("SELECT DATE_ADD( curdate(), INTERVAL " & numCantSemanas.Value & " WEEK )")
                    rd.Read()
                    FechaTope = rd(0)
                    FechaTopeAlqAux = rd(0)
                    Consulta("CALL AltaAlquiler(" & codsoc & ", '" & Format(FechaTope, "yyyy/MM/dd") & "', " & codigoCorredor & ")")
                    For Each item In lstCompra.Items
                        Consulta("CALL AltaAlquilerD(" & Val(item.Text) & ", " & codsoc & ", " & Val(item.Subitems(4).Text) & ", " & Val(item.Subitems(5).Text) & ")")
                    Next item
                    Consulta("SELECT MAX(CodAlquiler) FROM Alquileres")
                    rd.Read()
                    CodCompra = rd(0)
                    If rdbEnvioSI.Checked = True Then
                        Consulta("INSERT INTO Envios VALUES ('', NULL, " & CodCompra & ", NULL, 'Pendiente')")
                    End If
                    InvoiceGenerate("ReciboAlq")
                    Consulta("INSERT INTO Recibos VALUES ('', CURDATE(), " & codsoc & ", " & total & ", NULL, " & CodCompra & ", " & codigoCorredor & ", 0, 'Recibo de Alquiler')")
                End If
            End If
        End If
    End Sub

    'Private Sub numCantSemanas_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If (numCantSemanas.Value = 0) Then
    '        MsgBox("Seleccione un valor Mayor a 0")
    '        numCantSemanas.Value = 1
    '    Else
    '        btnConfirmarOperacion.Enabled = True
    '        total = 0
    '        For Each item In lstCompra.Items
    '            total = total + (Val(item.SubItems(4).Text) * Val(item.SubItems(5).Text)) * numCantSemanas.Value
    '        Next item
    '        lblTotal.Text = "Importe Total: " & total
    '    End If
    'End Sub

    Private Sub lstCompra_ColumnWidthChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangingEventArgs) Handles lstCompra.ColumnWidthChanging

        e.Cancel = True
        e.NewWidth = lstCompra.Columns(e.ColumnIndex).Width

    End Sub

    Private Sub rdbFinanciado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCuotas.CheckedChanged

        i = 0

        tipopago = "Financiado"

        cantcuota = 2

        total = 0
        For Each item In lstCompra.Items

            Consulta("SELECT PrecioVenta FROM Libros WHERE CodLibro = " & Val(item.Text))
            rd.Read()
            item.SubItems(5).Text = rd(0)
            total = total + (Val(lstCompra.Items(i).SubItems(5).Text) * Val(lstCompra.Items(i).SubItems(4).Text))
            i += 1

        Next item

        preciocuota = total / 2

        lblCompraTotal.Location = New Point(100, 14)
        lblCompraTotal.Text = "Precio total : $" & total & " en " & cantcuota & " cuotas de $" & preciocuota

        numCuotas.Visible = True
        lblCuotas.Visible = True

        btnCorredor.Enabled = True

    End Sub

    Private Sub rdbContado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbContado.CheckedChanged

        i = 0

        tipopago = "Contado"

        cantcuota = 0

        total = 0

        For Each item In lstCompra.Items

            item.SubItems(5).Text = (Val(item.Subitems(5).Text) * 0.9)
            total = total + (Val(lstCompra.Items(i).SubItems(5).Text) * Val(lstCompra.Items(i).SubItems(4).Text))
            i += 1
        Next item

        lblCompraTotal.Location = New Point(100, 14)
        lblCompraTotal.Text = "Importe Total : " & total
        numCuotas.Visible = False
        lblCuotas.Visible = False

        btnCorredor.Enabled = True

    End Sub

    Private Sub Facturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formulario = "modulo_compras"

        If nuevo = True Then
            Consulta("select codsocio, DNI, nombre, apellido from nuevos where codsocio =  " & codsoc) ' buscamos datos
            rd.Read()
            lblCod.Text = "Código de Socio : " & rd(0)
            lblDNI.Text = "DNI : " & rd(1)
            lblNombre.Text = "Nombre : " & rd(2)
            lblApellido.Text = "Apellido : " & rd(3)
        Else
            Consulta("select codsocio, DNI, nombre, apellido from socios where codsocio =  " & codsoc) ' buscamos datos
            rd.Read()
            lblCod.Text = "Código de Socio : " & rd(0)
            lblDNI.Text = "DNI : " & rd(1)
            lblNombre.Text = "Nombre : " & rd(2)
            lblApellido.Text = "Apellido : " & rd(3)
        End If
        If operacion = True Then
            pnlAlquiler.Visible = True
            btnCorredor.Enabled = True
            pnlCompra.Visible = False
            gbxPago.Visible = False
            gbxEnvio.Location = New Point(413, 267)
            pnlAlquiler.Size = New Size(375, 45)
            numCantSemanas.Visible = True
            lblcantsemanasalq.Visible = True
        Else
            pnlAlquiler.Visible = False
            pnlCompra.Visible = True
            gbxPago.Visible = True
        End If

        lblCompraTotal.Location = New Point(86, 14)
        lblCompraTotal.Text = "Seleccione financiacion"

    End Sub

    Private Sub numCantSemanas_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numCantSemanas.ValueChanged

        lblTotal.Text = "Importe total : " & totalsem * numCantSemanas.Value
        total = totalsem * numCantSemanas.Value
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numCuotas.ValueChanged

        cantcuota = numCuotas.Value

        preciocuota = total / cantcuota

        lblCompraTotal.Location = New Point(100, 14)

        lblCompraTotal.Text = "Precio total : $" & total & " en " & cantcuota & " cuotas de $" & preciocuota

    End Sub

    Private Sub btnCorredor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorredor.Click

        buscarCorredor.ShowDialog()

    End Sub
End Class
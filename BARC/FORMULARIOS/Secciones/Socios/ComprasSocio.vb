Public Class ComprasSocio
    Dim Indice As Integer
    Dim ind As Integer
    Dim Precio_Semanal As Integer
    Dim Cant_Semanas As Integer
    Dim FechaVencimiento As Date
    Dim resp As Integer

    ' revisar las compras al contado cambia el precio total
    ' lbls facturacion si es nuevo



    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        If formulario = "modulo_cobros" Then
            Main.Show()
        Else
            DataSocios.Show()
        End If
    End Sub

    Private Sub lstOperacion_ColumnWidthChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangingEventArgs) Handles lstOperacion.ColumnWidthChanging

        e.Cancel = True
        e.NewWidth = lstOperacion.Columns(e.ColumnIndex).Width

    End Sub

    Private Sub lstOperacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstOperacion.SelectedIndexChanged
        btnComprasDocumentos.Enabled = True
        If Not lstOperacion.FocusedItem.SubItems(2).Text = "Pagado" Then
            If lstOperacion.FocusedItem.SubItems(3).Text = "Contado" Then
                btnComprasDocumentos.Text = "Ver Factura"
                btnCambEstado.Enabled = True
            Else
                btnComprasDocumentos.Text = "Ver Cuotas"
                btnCambEstado.Enabled = False
            End If
        Else
            btnCambEstado.Enabled = False
        End If
        ' COMPRAS DEL CLIENTE
        lstDetalleCompra.Items.Clear()

        ind = lstOperacion.FocusedItem.Index
        ind = Val(lstOperacion.Items(ind).Text)

        Consulta("select l.Titulo, a.Nombre, a.Apellido, NombreEditorial, count(*), dc.Monto_Individual from libros l, autores a, libroautor la, ejemplares e, detallecompra dc, compras c, editoriales ed where l.Editorial = ed.CodEditorial and l.codlibro = la.codlibro and la.codautor = a.codautor and l.codlibro = e.codlibro and e.idejem = dc.idejem and dc.codcompra = c.codcompra and c.codcompra = " & ind & " group by l.titulo")
        While rd.Read
            lstDetalleCompra.Items.Add(rd(0))
            lstDetalleCompra.Items(Indice).SubItems.Add(rd(1) & " " & rd(2))
            lstDetalleCompra.Items(Indice).SubItems.Add(rd(3))
            lstDetalleCompra.Items(Indice).SubItems.Add(rd(4))
            lstDetalleCompra.Items(Indice).SubItems.Add(rd(5))
            Indice = Indice + 1
        End While
        Indice = 0
        Consulta("select Sum(Monto_Individual), FTopePago, TipoDePago FROM DetalleCompra dc, compras c WHERE dc.codcompra = c.codcompra and c.codCompra = " & ind)
        rd.Read()
        total = rd(0)
        lblTotal.Text = "Importe total de la Compra : $" & total
        lblTope.Visible = True
        lblTope.Text = "Fecha de Vencimiento de Pago : " & Format(rd(1), "dd/MM/yyyy")
        lblCantSemanas.Visible = True
        lblCantSemanas.Text = "Tipo de Pago : " & rd(2)
        FechaVencimiento = Format(rd(1), "yyyy/MM/dd")
        Consulta("SELECT DATEDIFF(CURDATE(), " & Format(rd(1), "yyyyMMdd") & ")")
        rd.Read()
        If rd(0) > 0 And lstOperacion.FocusedItem.SubItems(2).Text = "Impago" Then
            Consulta("CALL InteresesProce(" & rd(0) & ", @Dias)")
            Consulta("SELECT @Dias")
            rd.Read()
            Consulta("SELECT Porcentaje FROM Intereses WHERE DiasAtrasados = " & rd(0))
            rd.Read()
            Interes = rd(0)
            total = total + ((total * Interes) / 100)
            lblTotal.Text = "Importe total de la Compra: $" & total & "  (VENCIDO) "
        ElseIf lstOperacion.FocusedItem.SubItems(2).Text = "Pagado" Then
            If lstOperacion.FocusedItem.SubItems(3).Text = "Contado" Then
                Consulta("SELECT Fecha, Total FROM recibos WHERE CodCompra = " & ind)
                rd.Read()
                total = rd(1)
                Consulta("SELECT DATEDIFF(" & Format(FechaVencimiento, "yyyyMMdd") & ", " & Format(rd(0), "yyyyMMdd") & ")")
                rd.Read()
                If rd(0) < 0 Then
                    lblTotal.Text = "Importe total de la Compra: $" & total & "  (VENCIDO) "
                End If
            Else
                Consulta("SELECT Fecha, Total FROM recibos WHERE CodCompra = " & ind)
                total = 0
                While rd.Read
                    total = total + rd(1)
                End While
                lblTotal.Text = "Importe total de la Compra: $" & total & " (VENCIDO) "
            End If
        Else
            Interes = 0
        End If
        Consulta("SELECT CodCorredor, Nombre, Apellido From Corredores Co, Compras C WHERE C.Corredor = Co.CodCorredor AND C.CodCompra = " & ind)
        rd.Read()
        lblCorredor.Text = "Corredor : " & " (" & rd(0) & ") " & rd(1) & " " & rd(2)

    End Sub

    Private Sub lstAlquileres_ColumnWidthChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangingEventArgs) Handles lstAlquileres.ColumnWidthChanging

        e.Cancel = True
        e.NewWidth = lstAlquileres.Columns(e.ColumnIndex).Width

    End Sub



    Private Sub lstAlquileres_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAlquileres.SelectedIndexChanged
        lstDetalleAlquiler.Items.Clear()
        If Not lstAlquileres.FocusedItem.SubItems(2).Text = "Pagado" Then
            btnCambEstado.Enabled = True
        Else
            btnCambEstado.Enabled = False
        End If
        btnComprasDocumentos.Enabled = True
        ind = lstAlquileres.FocusedItem.Text
        CodCompra = lstAlquileres.FocusedItem.Text
        Consulta("SELECT l.Titulo, a.Nombre, a.Apellido, NombreEditorial, count(*), da.Monto_Individual_Semanal from libros l, autores a, libroautor la, ejemplares e, DetalleAlq DA, Alquileres ALQ, Editoriales ed where l.Editorial = ed.CodEditorial and l.codlibro = la.codlibro And la.codautor = a.codautor And l.codlibro = e.codlibro And e.idejem = DA.idejem And dA.CodAlquiler = ALQ.CodAlquiler And ALQ.CodAlquiler = " & ind & " group by l.titulo")

        While rd.Read
            lstDetalleAlquiler.Items.Add(rd(0))
            lstDetalleAlquiler.Items(Indice).SubItems.Add(rd(1) & " " & rd(2))
            lstDetalleAlquiler.Items(Indice).SubItems.Add(rd(3))
            lstDetalleAlquiler.Items(Indice).SubItems.Add(rd(4))
            lstDetalleAlquiler.Items(Indice).SubItems.Add(rd(5))
            Indice = Indice + 1
        End While
        Indice = 0
        Consulta("select SUM(Monto_Individual_Semanal) FROM Alquileres Al, DetalleAlq da WHERE al.Codalquiler = da.Codalquiler and da.CodAlquiler = " & ind)
        rd.Read()
        Precio_Semanal = rd(0)
        Consulta("select DATEDIFF(Fecha_Tope, Fecha_Inicio) FROM Alquileres Al WHERE al.CodAlquiler = " & ind)
        rd.Read()
        Cant_Semanas = (rd(0) / 7)
        CantsemanasAlq = Cant_Semanas

        lblTotal.Text = "Importe total del Alquiler: $" & (Precio_Semanal * Cant_Semanas)
        total = (Precio_Semanal * Cant_Semanas)
        lblPrecioSemanal.Text = "Precio Semanal del Alquiler: " & Precio_Semanal
        lblCantSemanas.Text = "Cantidad de Semanas de Alquiler: " & Cant_Semanas
        Consulta("SELECT Fecha_Devolucion, Fecha_Tope, Fecha_VencimientoPago FROM Alquileres WHERE CodAlquiler = " & ind)
        rd.Read()
        If IsDBNull(rd(0)) Then
            lblDevolucion.Text = "Fecha de Devolución: No devuelto"
            btnDevolverLibro.Enabled = True
        Else
            lblDevolucion.Text = "Fecha de Devolución: " & Format(rd(0), "dd/MM/yyyy")
            btnDevolverLibro.Enabled = False
        End If
        lblTope.Text = "Fecha Tope del Alquiler: " & Format(rd(1), "dd/MM/yyyy")
        lblVencimientoPagoAlq.Text = "Fecha de Vencimiento de Pago:  " & Format(rd(2), "dd/MM/yyyy")
        FechaVencimiento = Format(rd(2), "yyyy/MM/dd")
        Consulta("SELECT DATEDIFF(CURDATE(), " & Format(rd(2), "yyyyMMdd") & ")")
        rd.Read()
        If rd(0) > 0 And lstAlquileres.FocusedItem.SubItems(2).Text = "Impago" Then
            Consulta("CALL InteresesProce(" & rd(0) & ", @Dias)")
            Consulta("SELECT @Dias")
            rd.Read()
            Consulta("SELECT Porcentaje FROM Intereses WHERE DiasAtrasados = " & rd(0))
            rd.Read()
            Interes = rd(0)
            total = total + ((total * Interes) / 100)
            lblTotal.Text = "Importe total del Alquiler: $" & total & "  (VENCIDO) "
        ElseIf lstAlquileres.FocusedItem.SubItems(2).Text = "Pagado" Then
            Consulta("SELECT Fecha, Total FROM recibos WHERE CodAlquiler = " & ind)
            rd.Read()
            total = rd(1)
            Consulta("SELECT DATEDIFF(" & Format(FechaVencimiento, "yyyyMMdd") & ", " & Format(rd(0), "yyyyMMdd") & ")")
            rd.Read()
            If rd(0) < 0 Then
                lblTotal.Text = "Importe total del Alquiler: $" & total & "  (VENCIDO) "
            End If

        Else
            Interes = 0
        End If
        Consulta("SELECT CodCorredor, Nombre, Apellido From Corredores Co, Alquileres A WHERE A.Corredor = Co.CodCorredor AND A.CodAlquiler = " & ind)
        rd.Read()
        lblCorredor.Text = "Corredor : " & " (" & rd(0) & ") " & rd(1) & " " & rd(2)
    End Sub

    Private Sub ComprasSocio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblSocio.Text = "Socio : (" & codsoc & ") " & nomsocio & ""
        If formulario = "modulo_cobros" Then
            gbxOperacion.Visible = True
            gbxOperacion.Enabled = True
            rdbAlquileres.Checked = True
            operacion = True
            btnCambEstado.Visible = True
            btnDevolverLibro.Visible = True
        End If
        OperacionFuncion()
    End Sub




    Private Function OperacionFuncion()
        If Operacion = False Then
            Me.Text = "Operaciones"
            lblCompAlq.Text = "Compras realizadas"
            CompFecha.Text = "Fecha de Compra"
            lblTotal.Text = "Importe total de la compra: "
            lstDetalleCompra.Visible = True
            lstDetalleAlquiler.Visible = False
            lstDetalleAlquiler.SendToBack()
            lblDevolucion.Visible = False
            lblTope.Visible = True
            lblCantSemanas.Visible = False
            lblTope.Text = "Fecha de Vencimiento de Pago : "
            lblCantSemanas.Visible = True
            lblCantSemanas.Text = "Tipo de Pago : "
            lblPrecioSemanal.Visible = False
            lblVencimientoPagoAlq.Visible = False

            lstOperacion.BringToFront()
            lstDetalleCompra.BringToFront()
            lstAlquileres.SendToBack()
            lstDetalleAlquiler.SendToBack()
            btnCambEstado.Enabled = False
            btnComprasDocumentos.Text = "Ver Factura"
            If btnDevolverLibro.Visible = True Then
                btnDevolverLibro.Visible = False
            End If

            lstOperacion.Items.Clear()
            Consulta("select CodCompra, FechaCompra, estado, tipodepago, cantpagos from Compras where CodSocio = " & codsoc & "")
            While rd.Read
                lstOperacion.Items.Add(rd(0))
                lstOperacion.Items(Indice).SubItems.Add(Format(rd(1), "dd/MM/yyyy"))
                lstOperacion.Items(Indice).SubItems.Add(rd(2))
                lstOperacion.Items(Indice).SubItems.Add(rd(3))
                If IsDBNull(rd(4)) Then
                    lstOperacion.Items(Indice).SubItems.Add("1")
                Else
                    lstOperacion.Items(Indice).SubItems.Add(rd(4))
                End If
                Indice = Indice + 1
            End While
            Indice = 0
        Else
            Me.Text = "Operaciones"
            lblCompAlq.Text = "Alquileres realizados"
            AlqFecha.Text = "Fecha de Alquiler"
            lblTotal.Text = "Importe total del Alquiler: "
            lblPrecioSemanal.Text = "Precio Semanal del Alquiler: "
            lblTope.Text = "Fecha Tope del Alquiler: "
            lblCantSemanas.Text = "Cantidad de Semanas de Alquiler: "
            lblVencimientoPagoAlq.Visible = True
            lblVencimientoPagoAlq.Text = "Fecha de Vencimiento de Pago: "
            lblDevolucion.Text = "Fecha de Devolucion: "
            lstDetalleAlquiler.Visible = True
            lstDetalleCompra.Visible = False
            lstDetalleCompra.SendToBack()
            lblDevolucion.Visible = True
            lblTope.Visible = True
            lblCantSemanas.Visible = True
            lblPrecioSemanal.Visible = True

            btnComprasDocumentos.Text = "Ver Recibo de Alquiler"
            btnCambEstado.Enabled = False
            If btnDevolverLibro.Visible = True Then
                btnDevolverLibro.Enabled = False
            End If

            lstOperacion.SendToBack()
            lstDetalleCompra.SendToBack()
            lstAlquileres.BringToFront()
            lstDetalleAlquiler.BringToFront()

            lstAlquileres.Items.Clear()
            Consulta("select CodAlquiler, Fecha_Inicio, estadopago from Alquileres where Codsocio = " & codsoc & "")
            While rd.Read
                lstAlquileres.Items.Add(rd(0))
                lstAlquileres.Items(Indice).SubItems.Add(Format(rd(1), "dd/MM/yyyy"))
                lstAlquileres.Items(Indice).SubItems.Add(rd(2))
                Indice = Indice + 1
            End While
            Indice = 0
        End If
        Return 0
    End Function



    Private Sub btnComprasDocumentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComprasDocumentos.Click
        If operacion = False Then
            CodCompra = lstOperacion.FocusedItem.Text
            If lstOperacion.FocusedItem.SubItems(3).Text = "Contado" Then
                If lstOperacion.FocusedItem.SubItems(2).Text = "Pagado" Then
                    Consulta("SELECT NRecibo FROM Recibos WHERE CodCompra = " & CodCompra)
                    rd.Read()
                    NumRecibo = rd(0)
                    FacturaOrecibo.ShowDialog()
                Else
                    InvoiceGenerate("Factura_Ver")
                End If
            Else
                VerCuotas.Show()
                Me.Close()
            End If
        Else
            CodCompra = lstAlquileres.FocusedItem.Text
            If lstAlquileres.FocusedItem.SubItems(2).Text = "Pagado" Then
                Consulta("SELECT NRecibo FROM Recibos WHERE Motivo = 'Pago de Alquiler' AND CodAlquiler = " & CodCompra)
                rd.Read()
                NumRecibo = rd(0)
                AlquileroRecibo.ShowDialog()
            Else
                InvoiceGenerate("ReciboAlq_Ver")
            End If
        End If

    End Sub

    Private Sub rdbAlquileres_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbAlquileres.CheckedChanged
        operacion = True
        btnDevolverLibro.Visible = True
        btnCambEstado.Size = New Size(360, 122)

        lblCantSemanas.Location = New Point(12, 371)
        lblTope.Location = New Point(12, 387)

        OperacionFuncion()
    End Sub

    Private Sub rdbCompras_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCompras.CheckedChanged
        operacion = False
        btnComprasDocumentos.Enabled = False
        btnCambEstado.Size = New Size(750, 122)

        lblCantSemanas.Location = New Point(12, 354)
        lblTope.Location = New Point(12, 371)

        btnDevolverLibro.Visible = False
        OperacionFuncion()
    End Sub

    Private Sub btnCambEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambEstado.Click
        If operacion = False Then
            CodCompra = lstOperacion.FocusedItem.Text
            IndiceOperacion = lstOperacion.FocusedItem.Index
        Else
            CodCompra = lstAlquileres.FocusedItem.Text
            IndiceOperacion = lstAlquileres.FocusedItem.Index
        End If
        Me.Hide()
        RegistrarPago.Show()
    End Sub

    Private Sub btnDevolverLibro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDevolverLibro.Click
        resp = MsgBox("Confirma que desea Devolver el Libro?", MsgBoxStyle.YesNo, "Atencion")
        If resp = 6 Then
            Consulta("UPDATE Alquileres SET Fecha_Devolucion = CURDATE() WHERE CodAlquiler = " & Val(lstAlquileres.FocusedItem.Text))
            Consulta("SELECT Fecha_Devolucion FROM Alquileres WHERE CodALquiler = " & Val(lstAlquileres.FocusedItem.Text))
            rd.Read()
            lblDevolucion.Text = "Fecha de Devolución: " & Format(rd(0), "dd/MM/yyyy")
            MsgBox("Devolucion Satisfactoria", MsgBoxStyle.OkOnly, "Atencion")
        End If
    End Sub

    Private Sub lstDetalleAlquiler_ColumnWidthChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangingEventArgs) Handles lstDetalleAlquiler.ColumnWidthChanging

        e.Cancel = True
        e.NewWidth = lstDetalleAlquiler.Columns(e.ColumnIndex).Width

    End Sub

    Private Sub lstDetalleCompra_ColumnWidthChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangingEventArgs) Handles lstDetalleCompra.ColumnWidthChanging

        e.Cancel = True
        e.NewWidth = lstDetalleCompra.Columns(e.ColumnIndex).Width

    End Sub

End Class
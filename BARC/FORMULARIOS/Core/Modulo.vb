Imports System.Data.Odbc

Module Modulo

    Public cmd As New OdbcCommand
    Public conexion As OdbcConnection
    Public rd As OdbcDataReader
    Public rd2 As OdbcDataReader
    Public user As String
    Public failed As Boolean
    Public debug As Boolean 'Mostrar labels que ayudan a la depuracion
    Public operacion As Boolean 'Que operacion vas a realizar compra o alquiler  0 - 1 respec
    Public codsoc As Integer 'Codigo de socio para operar con consultas en compras
    Public answer As Integer
    Public nuevo As Boolean 'Verifica si el socio es nuevo para obligar compra/alquiler de dos libros
    Public total As Integer 'Total a pagar por libros a comprar
    Public totalsem As Integer ' total semanal
    Public dni As Integer
    Public CodCompra As Integer 'Para ver dertalle compra
    Public nomsocio As String ' nombre del socio, usado en ver info de compras
    Public fechatope As Date
    Public fechadevo As Date
    Public SocioBaja As Boolean ' si e lsocio esta dado de baja cambio el boton dar de baja por dar de alta
    Public BanderaRS As Integer
    Public tipoNotif As String ' Sistema-Ventas-Compras-Deudas-etc
    Public notifCont As Integer
    Public formulario As String 'Saber que formulario venis si ingresas al mismo de distintos lugares
    Public IndiceOperacion As Integer ' para cambiar el estado en cobros
    Public Interes As Integer
    Public NotificacionActiva As Boolean
    Public tipopago As String
    Public cantcuota As Integer
    Public codigoCorredor As Integer
    Public nombreCorredor As String
    Public preciocuota As Integer
    Public NOpEnvi As Integer
    Public CodProveedor As Integer ' todo para carga de libros nuevos
    Public NumISBN As String
    Public NFacProv As Integer
    Public PrecioUnit As Decimal
    Public CantEjemplares As Integer
    Public CantEjemA As Integer
    Public CantEjemV As Integer
    Public FechaTopeAlqAux As Date
    Public CantsemanasAlq As Integer
    Public CodigoZona As Integer
    Public codigoProveedor As Integer ' ABM
    Public editorialcodigo As Integer ' ABM
    Public codLibro As Integer ' IBM

    Public numCompEntrada As Integer
    Public numNotaPedido As Integer
    Public numFacProveedor As Integer
    Public NumeroRemito As Integer
    Public FechaEvento_ As String
    Public NomEvento As String
    Public estado_socio As String

    Public NumRecibo As Integer

    Public codcheque As Integer

    Dim i As Integer 'Invoice

    ' crear factura con cuotas pendiente
    ' crear recibos genericos  pendiente
    ' revisar balances diarios recibos tienen  que ser de pago HECHO
    ' terminar balances dirarios, mensuales HECHO
    ' empezar lo de corredores HECHOS
    ' RECORRIDOS DE CORREDORES cada 1 semana se ve los que compraron y se hace el recorrido una lista HECHO
    ' ABM HECHO
    ' IMPRIMIR CONSTANCIA DE BAJA HECHO
    ' meter los documentos que faltan (los hizo/esta haciendo cerdan)
    ' revisar todo con los dfd
    ' revisar todas las lineas buscando errores

    Public Function Conectar(ByVal bdd As String)

        Try
            conexion = New OdbcConnection(bdd)
            conexion.Open()

        Catch ex As Exception
            MsgBox("No se pudo conectar a la base de datos, intente nuevamente.")
            failed = True
        End Try

        Return 0
    End Function

    Public Function Desconectar()

        conexion.Close()

        Return 0
    End Function

    Public Function Consulta(ByVal sql As String)

        cmd = New OdbcCommand(sql, conexion)
        cmd.CommandType = CommandType.Text
        If BanderaRS = 0 Then
            rd = cmd.ExecuteReader
        ElseIf BanderaRS = 1 Then
            rd2 = cmd.ExecuteReader
        End If
        cmd.Dispose()

        Return 0
    End Function

    Public Function Notificacion(ByVal tipo As String, ByVal msg As String)

        tipoNotif = tipo

        notif.lblMensaje.Text = msg

        notif.xTick = 0

        notif.Show()

        Return 0
    End Function


    Public Function InvoiceGenerate(ByVal tipodoc As String)

        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("ES-ES")
        i = 0
        If tipodoc = "notapedido" Then

            Dim invoice As New notaDatos()

            Consulta("select n.nnotapedido, n.fecha, n.nsoli, proveedor from nota_pedidos n, solicitudes_compras s where n.nsoli = s.nsoli and n.nnotapedido = " & numNotaPedido & "")
            rd.Read()

            invoice.compNotaPedido = rd(0)
            invoice.fechaEmision = Format(rd(1), "dd/MM/yyyy")
            invoice.nSoliCompra = rd(2)
            invoice.nomProveedor = rd(3)

            Consulta("select libro, cantidad from solicitudes_compras_det where nsoli = " & rd(2) & "")

            Dim i As Integer = 1
            While rd.Read

                Dim article As New notaDetalles()

                article.idenLibros = Convert.ToInt32(i)
                article.ISBNlibro = rd(0)
                article.cantLibros = Convert.ToInt32(rd(1))

                invoice.Detail.Add(article)
                i += 1

            End While

            Dim frm As New notapedidoPreview()

            frm.notaDatos.Add(invoice)
            frm.notaDetalle = invoice.Detail

            frm.ShowDialog()


        ElseIf tipodoc = "cheque_ver" Then

            Dim invoice As New chequeDatos()

            Consulta("select Monto, p.Proveedor, FechaEmision from cheques c, proveedores p where p.CodProveedor = c.proveedor and NFacturaProveedor = " & NFacProv)
            rd.Read()

            invoice.codCheque = codcheque

            invoice.fondosCheque = rd(0)
            invoice.fondosLetras = Num2Text(invoice.fondosCheque)

            invoice.destProveedor = rd(1)

            invoice.diaCheque = Format(rd(2), "dd")
            invoice.mesCheque = Format(rd(2), "MMMM")
            invoice.añoCheque = Format(rd(2), "yyyy")

            Dim frm As New chequePreview()

            frm.CheqDatos.Add(invoice)

            frm.ShowDialog()

        ElseIf tipodoc = "cheque" Then

            Dim invoice As New chequeDatos()

            Consulta("select Monto, p.Proveedor, FechaEmision from cheques c, proveedores p where NCheque = " & codcheque & " and p.CodProveedor = c.proveedor")
            rd.Read()

            invoice.codCheque = codcheque

            invoice.fondosCheque = rd(0)
            invoice.fondosLetras = Num2Text(invoice.fondosCheque)

            invoice.destProveedor = rd(1)

            Application.CurrentCulture = New System.Globalization.CultureInfo("es-ES")

            invoice.diaCheque = Format(rd(2), "dd")
            invoice.mesCheque = Format(rd(2), "MMMM")
            invoice.añoCheque = Format(rd(2), "yyyy")

            Application.CurrentCulture = New System.Globalization.CultureInfo("EN-US")

            Dim frm As New chequePreview()

            frm.CheqDatos.Add(invoice)

            frm.ShowDialog()

        ElseIf tipodoc = "ReciboGen" Then
            Dim invoice As New ReciboGenDatos()

            invoice.NRecibo = NumRecibo
            invoice.CopiaDocumento = "Original"
            invoice.TipoDocumento = "Recibo"
            invoice.IdenDocumento = "X"

            Consulta("SELECT Total, fecha, motivo, codsocio, corredor FROM Recibos WHERE NRecibo = " & NumRecibo)
            rd.Read()
            total = rd(0)
            invoice.Total = total
            invoice.TotalLetrasR = Num2Text(total) & " PESOS"
            invoice.FechaEmision = rd(1)
            'invoice.FechaHasta = rd(0)
            'Consulta("SELECT DATE_ADD(CURDATE(), INTERVAL 1 WEEK)")
            'rd.Read()
            'invoice.FechaVenceAlq = rd(0)
            'invoice.FechaTopeAlq = FechaTopeAlqAux
            invoice.CantSemanas = "Motivo: " & rd(2)
            codsoc = rd(3)

            Consulta("SELECT codcorredor, Nombre, Apellido FROM Corredores where codcorredor = " & rd(4))
            rd.Read()
            invoice.FechaHasta = "(" & rd(0) & ") " & rd(1) & " " & rd(2)
            Consulta("select dni, apellido, nombre, direccion, localidad from socios where codsocio = " & codsoc)
            rd.Read()

            invoice.DNISocio = rd(0)
            invoice.ApeNombre = rd(1) & " " & rd(2)
            invoice.CondicionIVA = "Consumidor Final"
            invoice.DomicilioSocio = rd(3) & " " & rd(4)
            invoice.condVenta = "Contado"

            Dim frm As New ReciboGenericoPreview()

            frm.Invoice.Add(invoice)

            frm.ShowDialog()

        ElseIf tipodoc = "EventoAsis" Then

            Dim invoice As New asistEventosDatos()

            Consulta("SELECT Nombre, Apellido FROM Socios WHERE Codsocio = " & codsoc)
            rd.Read()
            invoice.codSocio = codsoc
            invoice.nomSocio = rd(0)
            invoice.apeSocio = rd(1)
            invoice.nomEvento = NomEvento
            invoice.fechaEvento = FechaEvento_

            Dim frm As New asistEventos()

            frm.EvenDatos.Add(invoice)

            frm.ShowDialog()

        ElseIf tipodoc = "remito_ver" Then

            Dim codop As Integer

            Dim invoice As New REncabezado()

            invoice.CopiaDocumento = "Original"
            invoice.TipoDocumento = "Remito"
            invoice.IdenDocumento = "R"
            invoice.CodRemito = NumeroRemito

            Dim bandera As Boolean

            Consulta("select codcompra, codalquiler from remitos where NRemito = " & invoice.CodRemito)
            rd.Read()

            If Not IsDBNull(rd(0)) Then
                Consulta("select total from facturas f, compras c where f.codcompra = c.codcompra and c.codcompra = " & rd(0))
                rd.Read()
                total = rd(0)
                invoice.SubTotalSem = total
                bandera = True
            Else
                Consulta("select total from recibos r, alquileres a where r.codalquiler = a.codalquiler and r.Motivo = 'Recibo de Alquiler' and a.codalquiler = " & rd(1) & "")
                rd.Read()
                total = rd(0)
                Consulta("SELECT DATEDIFF((SELECT Fecha_Tope FROM Alquileres WHERE CodAlquiler = " & CodCompra & "), (SELECT Fecha_Inicio FROM Alquileres WHERE CodAlquiler = " & CodCompra & "))")
                rd.Read()
                invoice.CantSemanas = (rd(0) / 7) & " Semanas de Alquiler"
                Consulta("SELECT SUM(Monto_Individual_Semanal) FROM DetalleAlq WHERE CodAlquiler = " & CodCompra)
                rd.Read()
                invoice.SubTotalSem = rd(0)
                bandera = False
            End If

            invoice.SubtotalRemito = total
            invoice.TotalLetras = Num2Text(total) & " PESOS"

            Consulta("select fecha from Hojas_de_ruta hr, Hojas_de_Ruta_Det hrd where hr.NHojaRuta = hrd.NHojaRuta AND NRemito = " & invoice.CodRemito & "")
            rd.Read()
            invoice.FechaRemito = rd(0)

            If bandera = True Then
                Consulta("select codsocio from compras where codcompra = " & CodCompra)
            Else
                Consulta("select codsocio from alquileres where codalquiler = " & CodCompra)
            End If

            rd.Read()

            codop = rd(0)

            Consulta("select dni, apellido, nombre, direccion, localidad from socios where codsocio = " & rd(0))
            rd.Read()

            invoice.DNISocio = rd(0)
            invoice.ApeNombre = rd(1) & " " & rd(2)
            invoice.CondicionIVA = "Consumidor Final"
            invoice.DomicilioSocio = rd(3) & " " & rd(4)

            If bandera = True Then

                Consulta("select l.codlibro, l.Titulo, count(*), dc.Monto_Individual from libros l, ejemplares e, detallecompra dc, compras c where l.codlibro = e.codlibro and e.idejem = dc.idejem and dc.codcompra = c.codcompra and c.codcompra = " & CodCompra & " group by l.titulo")

                While rd.Read

                    Dim article As New FacturaCuotasArt()

                    article.CodLibro = Convert.ToInt32(rd(0))
                    article.TituloLibro = rd(1)
                    article.CantidadLibro = Convert.ToInt32(rd(2))
                    article.PrecioUnitario = Convert.ToDecimal(Val(rd(3)))
                    article.SubtotalArticulo = Convert.ToDecimal(rd(3) * rd(2))

                    invoice.Detail.Add(article)

                End While


            Else

                Consulta("select l.codlibro, l.Titulo, count(*), da.Monto_Individual_Semanal from libros l, ejemplares e, detallealq da, alquileres a where l.codlibro = e.codlibro and e.idejem = da.idejem and da.codalquiler = a.codalquiler and a.codalquiler = " & CodCompra & " group by l.titulo")

                While rd.Read

                    Dim article As New FacturaCuotasArt()
                    article.CodLibro = Convert.ToInt32(rd(0))
                    article.TituloLibro = rd(1)
                    article.CantidadLibro = Convert.ToInt32(rd(2))
                    article.PrecioUnitario = Convert.ToDecimal(Val(rd(3)))
                    article.SubtotalArticulo = Convert.ToDecimal(rd(3) * rd(2))
                    invoice.Detail.Add(article)

                End While

            End If

            Dim frm As New remitoPreview()

            frm.Invoice.Add(invoice)

            frm.Detail = invoice.Detail
            frm.ShowDialog()

        ElseIf tipodoc = "remito" Then

            Dim invoice As New REncabezado()

            invoice.CopiaDocumento = "Original"
            invoice.TipoDocumento = "Remito"
            invoice.IdenDocumento = "R"

            Consulta("select max(NRemito) from remitos")
            rd.Read()

            invoice.CodRemito = rd(0)

            Dim bandera As Boolean

            If EnviosVer.lstEnvios.FocusedItem.SubItems(2).Text = "Compra" Then
                Consulta("select total from facturas f, compras c where f.codcompra = c.codcompra and c.codcompra = " & EnviosVer.lstEnvios.FocusedItem.SubItems(3).Text & "")
                rd.Read()
                total = rd(0)
                bandera = True
            Else
                Consulta("select total from recibos r, alquileres a where r.codalquiler = a.codalquiler and a.codalquiler = " & EnviosVer.lstEnvios.FocusedItem.SubItems(3).Text & "")
                rd.Read()
                total = rd(0)
                bandera = False
            End If

            invoice.SubtotalRemito = total
            invoice.TotalLetras = Num2Text(total) & " PESOS"

            Consulta("select curdate()")
            rd.Read()
            invoice.FechaRemito = rd(0)

            If bandera = True Then
                Consulta("select codsocio from compras where codcompra = " & EnviosVer.lstEnvios.FocusedItem.SubItems(3).Text & "")
            Else
                Consulta("select codsocio from alquileres where codalquiler = " & EnviosVer.lstEnvios.FocusedItem.SubItems(3).Text & "")
            End If

            rd.Read()

            Consulta("select dni, apellido, nombre, direccion, localidad from socios where codsocio = " & rd(0) & "")
            rd.Read()

            invoice.DNISocio = rd(0)
            invoice.ApeNombre = rd(1) & " " & rd(2)
            invoice.CondicionIVA = "Consumidor Final"
            invoice.DomicilioSocio = rd(3) & " " & rd(4)

            If bandera = True Then

                Consulta("select l.codlibro, l.Titulo, count(*), dc.Monto_Individual from libros l, ejemplares e, detallecompra dc, compras c where l.codlibro = e.codlibro and e.idejem = dc.idejem and dc.codcompra = c.codcompra and c.codcompra = " & EnviosVer.lstEnvios.FocusedItem.SubItems(3).Text & " group by l.titulo")

                While rd.Read

                    Dim article As New FacturaCuotasArt()
                    article.CodLibro = Convert.ToInt32(rd(0))
                    article.TituloLibro = rd(1)
                    article.CantidadLibro = Convert.ToInt32(rd(2))
                    article.PrecioUnitario = Convert.ToDecimal(Val(rd(3)))
                    article.SubtotalArticulo = Convert.ToDecimal(rd(3) * rd(2))
                    invoice.Detail.Add(article)

                End While


            Else

                Consulta("select l.codlibro, l.Titulo, count(*), da.Monto_Individual_Semanal from libros l, ejemplares e, detallealq da, alquileres a where and l.codlibro = e.codlibro and e.idejem = da.idejem and da.codalquiler = a.codalquiler and a.codalquiler = " & EnviosVer.lstEnvios.FocusedItem.SubItems(3).Text & " group by l.titulo")

                While rd.Read

                    Dim article As New FacturaCuotasArt()
                    article.CodLibro = Convert.ToInt32(rd(0))
                    article.TituloLibro = rd(1)
                    article.CantidadLibro = Convert.ToInt32(rd(2))
                    article.PrecioUnitario = Convert.ToDecimal(Val(rd(3)))
                    article.SubtotalArticulo = Convert.ToDecimal(rd(3) * rd(2))
                    invoice.Detail.Add(article)

                End While

            End If

            Dim frm As New remitoPreview()

            frm.Invoice.Add(invoice)

            frm.Detail = invoice.Detail
            frm.ShowDialog()

        ElseIf tipodoc = "hdruta_imp" Then

            Dim invoice As New hdruta()

            invoice.nhdruta = HojasRuta.lstHojasR.FocusedItem.Text

            Consulta("select fecha from hojas_de_ruta where NHojaRuta = " & invoice.nhdruta & "")
            rd.Read()

            invoice.fechahdruta = rd(0)

            For Each item In HojasRuta.lstHojasRDet.Items

                Dim article As New hdrutaDetalle()

                article.nremito = Convert.ToInt32(HojasRuta.lstHojasRDet.Items(i).SubItems(1).Text)

                Consulta("select codcompra from remitos where NRemito = " & article.nremito & "")
                rd.Read()

                If Not IsDBNull(rd(0)) Then
                    Consulta("select direccion from socios s, compras c where s.codsocio = c.codsocio and c.codcompra = " & rd(0) & "")
                    rd.Read()
                Else
                    Consulta("select direccion from socios s, alquileres a, remitos r where r.codalquiler = a.codalquiler and a.codsocio = s.codsocio and r.NRemito = " & article.nremito & "")
                    rd.Read()
                End If

                article.dirsocio = Convert.ToString(rd(0))

                article.cantlibroshdruta = Convert.ToInt32(HojasRuta.lstHojasRDet.Items(i).SubItems(2).Text)

                invoice.entregas.Add(article)

                i = i + 1

            Next item

            Dim frm As New hojaRutaPreview()

            frm.Ehojaruta.Add(invoice)

            frm.Dhojaruta = invoice.entregas

            frm.ShowDialog()

        ElseIf tipodoc = "compEntradaLibros_gen" Then

            Dim invoice As New entradaLibros()

            invoice.numComprobante = numCompEntrada
            invoice.numFactura = numFacProveedor
            invoice.numNotaPedido = numNotaPedido

            For Each item In ActualizarLibros.lstRecibidos.Items

                Dim article As New entradaLibrosDet()

                article.entradaISBN = ActualizarLibros.lstRecibidos.Items(i).SubItems(1).Text
                article.entradaCantidad = Convert.ToInt32(Val(ActualizarLibros.lstRecibidos.Items(i).SubItems(3).Text))
                article.entradaPrecioUnitario = Convert.ToDecimal(Val(ActualizarLibros.lstRecibidos.Items(i).SubItems(4).Text))

                invoice.detalleEntrada.Add(article)

                i = i + 1

            Next item

            Dim frm As New entradaPreview()

            frm.Invoice.Add(invoice)

            frm.Detail = invoice.detalleEntrada
            frm.ShowDialog()

        ElseIf tipodoc = "compEntradaLibros" Then

            Dim invoice As New entradaLibros()

            invoice.numComprobante = numCompEntrada
            invoice.numFactura = numFacProveedor
            invoice.numNotaPedido = numNotaPedido

            For Each item In VerCompEntrada.lstDetalle.Items

                Dim article As New entradaLibrosDet()

                article.entradaISBN = VerCompEntrada.lstDetalle.Items(i).SubItems(1).Text
                article.entradaCantidad = Convert.ToInt32(Val(VerCompEntrada.lstDetalle.Items(i).SubItems(2).Text))
                article.entradaPrecioUnitario = Convert.ToDecimal(Val(VerCompEntrada.lstDetalle.Items(i).SubItems(3).Text))

                invoice.detalleEntrada.Add(article)

                i = i + 1

            Next item

            Dim frm As New entradaPreview()

            frm.Invoice.Add(invoice)

            frm.Detail = invoice.detalleEntrada
            frm.ShowDialog()

        ElseIf tipodoc = "CredSocio" Then

            Dim invoice As New SocioDatos()

            Consulta("select codsocio, nombre, apellido, dni, tel, direccion, localidad, sociodesde from socios where codsocio = " & DataSocios.lblDataCodSoc.Text)
            rd.Read()

            invoice.CodSocio = rd(0)
            invoice.NomSocio = rd(1) & " " & rd(2)
            invoice.DNISocio = rd(3)
            invoice.TelSocio = rd(4)
            invoice.DirSocio = rd(5) & " " & rd(6)
            invoice.DesdeSocio = rd(7)

            Dim frm As New credPreview()

            frm.SocDatos.Add(invoice)

            frm.ShowDialog()

        ElseIf tipodoc = "ConstanciaAdmision" Then

            Dim invoice As New ConstanciaAdmisionDatos()

            Consulta("SELECT CodSocio, nombre, apellido, SocioDesde FROM Socios WHERE CodSocio = " & codsoc)
            rd.Read()

            invoice.codigoSocio = rd(0)
            invoice.nombreCompleto = rd(1) & " " & rd(2)
            invoice.FechaAdmision = Format(rd(3), "dd/MM/yyyy")

            Dim frm As New ConstanciaAdmisionPreview()

            frm.SocDatos.Add(invoice)

            frm.ShowDialog()

        ElseIf tipodoc = "Constanciabaja" Then

            Dim invoice As New ConstanciaBajaDatos()

            Consulta("SELECT CodSocio, FechaBaja FROM BajasSocios WHERE CodSocio = " & codsoc & " ORDER BY FechaBaja DESC LIMIT 1")
            rd.Read()

            invoice.codigoSocio = rd(0)
            invoice.FechaBaja = Format(rd(1), "dd/MM/yyyy")

            Dim frm As New ConstanciaBajaPreview()

            frm.SocDatos.Add(invoice)

            frm.ShowDialog()

            ' ______________________________________________________________________________________________________________________________________________________________
        ElseIf tipodoc = "Factura" Then

            Dim invoice As New FEncabezado()

            invoice.CopiaDocumento = "Original"
            invoice.TipoDocumento = "Factura"
            invoice.IdenDocumento = "C"

            Consulta("select max(codcompra) from compras")
            rd.Read()

            invoice.CodFactura = rd(0) + 1
            invoice.SubtotalFactura = total
            invoice.TotalLetras = Num2Text(total) & " PESOS"

            Consulta("select curdate()")
            rd.Read()
            invoice.FechaFacturacion = rd(0)
            invoice.HastaFecha = rd(0)
            Consulta("SELECT DATE_ADD(CURDATE(), INTERVAL 1 WEEK)")
            rd.Read()
            invoice.VenceFecha = rd(0)

            Consulta("select dni, apellido, nombre, direccion, localidad from socios where codsocio = " & codsoc & "")
            rd.Read()

            invoice.DNISocio = rd(0)
            invoice.ApeNombre = rd(1) & " " & rd(2)
            invoice.CondicionIVA = "Consumidor Final"
            invoice.DomicilioSocio = rd(3) & " " & rd(4)
            invoice.condVenta = tipopago

            For Each item In Facturacion.lstCompra.Items
                Dim article As New FArticulo()

                article.CodLibro = Convert.ToInt32(Facturacion.lstCompra.Items(i).Text)
                article.TituloLibro = Facturacion.lstCompra.Items(i).SubItems(1).Text
                article.CantidadLibro = Convert.ToInt32(Facturacion.lstCompra.Items(i).SubItems(4).Text)
                article.PrecioUnitario = Convert.ToDecimal(Val(Facturacion.lstCompra.Items(i).SubItems(5).Text) / Val(Facturacion.lstCompra.Items(i).SubItems(4).Text))
                article.SubtotalArticulo = Convert.ToDecimal(Facturacion.lstCompra.Items(i).SubItems(5).Text)

                invoice.Detail.Add(article)

                i = i + 1
            Next

            Dim frm As New facremPreview()

            frm.Invoice.Add(invoice)

            frm.Detail = invoice.Detail
            frm.ShowDialog()

        ElseIf tipodoc = "Factura_Ver" Then
            Dim invoice As New FEncabezado()
            Dim preciounit As Decimal
            Dim subto As Decimal

            invoice.CopiaDocumento = "Original"
            invoice.TipoDocumento = "Factura"
            invoice.IdenDocumento = "C"

            Consulta("select codFactura, total, fecha from facturas where codcompra = " & CodCompra)
            rd.Read()
            invoice.CodFactura = rd(0)
            invoice.SubtotalFactura = rd(1)
            invoice.TotalLetras = Num2Text(rd(1)) & " PESOS"
            invoice.FechaFacturacion = rd(2)
            invoice.HastaFecha = rd(2)
            Consulta("SELECT DATE_ADD(" & Format(rd(2), "yyyyMMdd") & ", INTERVAL 1 WEEK)")
            rd.Read()
            invoice.VenceFecha = rd(0)

            Consulta("select dni, apellido, nombre, direccion, localidad from socios where codsocio = " & codsoc & "")
            rd.Read()

            invoice.DNISocio = rd(0)
            invoice.ApeNombre = rd(1) & " " & rd(2)
            invoice.CondicionIVA = "Consumidor Final"
            invoice.DomicilioSocio = rd(3) & " " & rd(4)
            Consulta("SELECT TipoDePago FROM Compras WHERE CodCompra = " & CodCompra)
            rd.Read()
            invoice.condVenta = rd(0)
            tipopago = rd(0)

            Consulta("SELECT l.CodLibro, l.titulo, COUNT(*), l.PrecioVenta FROM libros l, ejemplares e, DetalleCompra dc WHERE l.CodLibro = e.CodLibro AND e.idEjem = dc.idEjem AND dc.CodCompra = " & CodCompra & " group by l.CodLibro")
            While rd.Read
                Dim article As New FArticulo()
                article.CodLibro = Convert.ToInt32(rd(0))
                article.TituloLibro = rd(1)
                article.CantidadLibro = Convert.ToInt32(rd(2))
                preciounit = rd(3) * 0.9
                article.PrecioUnitario = Convert.ToDecimal(preciounit)
                subto = preciounit * rd(2)
                article.SubtotalArticulo = Convert.ToDecimal(subto)

                invoice.Detail.Add(article)
            End While

            Dim frm As New facremPreview()

            frm.Invoice.Add(invoice)

            frm.Detail = invoice.Detail
            frm.ShowDialog()

        ElseIf tipodoc = "FacturaCuota" Then

            Dim invoice As New FacturaCuotas()

            invoice.CopiaDocumento = "Original"
            invoice.TipoDocumento = "Factura"
            invoice.IdenDocumento = "C"

            Consulta("select max(codcompra) from compras")
            rd.Read()

            invoice.CodFactura = rd(0) + 1
            invoice.SubtotalFactura = total
            invoice.CantCuotas = cantcuota & " cuotas de $" & preciocuota
            invoice.TotalLetras = Num2Text(total) & " PESOS"

            Consulta("select curdate()")
            rd.Read()
            invoice.FechaFacturacion = rd(0)
            invoice.HastaFecha = rd(0)
            Consulta("SELECT DATE_ADD(CURDATE(), INTERVAL 1 WEEK)")
            rd.Read()
            invoice.VenceFecha = rd(0)

            Consulta("select dni, apellido, nombre, direccion, localidad from socios where codsocio = " & codsoc & "")
            rd.Read()

            invoice.DNISocio = rd(0)
            invoice.ApeNombre = rd(1) & " " & rd(2)
            invoice.CondicionIVA = "Consumidor Final"
            invoice.DomicilioSocio = rd(3) & " " & rd(4)
            invoice.condVenta = tipopago

            For Each item In Facturacion.lstCompra.Items
                Dim article As New FacturaCuotasArt()

                article.CodLibro = Convert.ToInt32(Facturacion.lstCompra.Items(i).Text)
                article.TituloLibro = Facturacion.lstCompra.Items(i).SubItems(1).Text
                article.CantidadLibro = Convert.ToInt32(Facturacion.lstCompra.Items(i).SubItems(4).Text)
                article.PrecioUnitario = Convert.ToDecimal(Val(Facturacion.lstCompra.Items(i).SubItems(5).Text) / Val(Facturacion.lstCompra.Items(i).SubItems(4).Text))
                article.SubtotalArticulo = Convert.ToDecimal(Facturacion.lstCompra.Items(i).SubItems(5).Text)

                invoice.Detail.Add(article)

                i = i + 1
            Next

            Dim frm As New FacCuotasPreview()

            frm.Invoice.Add(invoice)

            frm.Detail = invoice.Detail
            frm.ShowDialog()

        ElseIf tipodoc = "FacturaCuota_Ver" Then
            Dim invoice As New FacturaCuotas()
            Dim preciounit As Decimal
            Dim subto As Decimal

            invoice.CopiaDocumento = "Original"
            invoice.TipoDocumento = "Factura"
            invoice.IdenDocumento = "C"

            Consulta("select codFactura, total, fecha from facturas where codcompra = " & CodCompra)
            rd.Read()
            invoice.CodFactura = rd(0)
            invoice.SubtotalFactura = rd(1)
            invoice.CantCuotas = cantcuota & " cuotas de $" & preciocuota
            invoice.TotalLetras = Num2Text(rd(1)) & " PESOS"


            invoice.FechaFacturacion = rd(2)
            invoice.HastaFecha = rd(2)
            Consulta("SELECT DATE_ADD(" & Format(rd(2), "yyyyMMdd") & ", INTERVAL 1 WEEK)")
            rd.Read()
            invoice.VenceFecha = rd(0)


            Consulta("select dni, apellido, nombre, direccion, localidad from socios where codsocio = " & codsoc & "")
            rd.Read()

            invoice.DNISocio = rd(0)
            invoice.ApeNombre = rd(1) & " " & rd(2)
            invoice.CondicionIVA = "Consumidor Final"
            invoice.DomicilioSocio = rd(3) & " " & rd(4)
            Consulta("SELECT TipoDePago FROM Compras WHERE CodCompra = " & CodCompra)
            rd.Read()
            invoice.condVenta = rd(0)
            tipopago = rd(0)

            Consulta("SELECT l.CodLibro, l.titulo, COUNT(*), l.PrecioVenta FROM libros l, ejemplares e, DetalleCompra dc WHERE l.CodLibro = e.CodLibro AND e.idEjem = dc.idEjem AND dc.CodCompra = " & CodCompra & " group by l.CodLibro")
            While rd.Read
                Dim article As New FacturaCuotasArt()
                article.CodLibro = Convert.ToInt32(rd(0))
                article.TituloLibro = rd(1)
                article.CantidadLibro = Convert.ToInt32(rd(2))
                preciounit = rd(3)
                article.PrecioUnitario = Convert.ToDecimal(preciounit)
                subto = preciounit * rd(2)
                article.SubtotalArticulo = Convert.ToDecimal(subto)

                invoice.Detail.Add(article)
            End While

            Dim frm As New FacCuotasPreview()

            frm.Invoice.Add(invoice)

            frm.Detail = invoice.Detail
            frm.ShowDialog()

            ' ______________________________________________________________________________________________________________________________________________________________

        ElseIf tipodoc = "ReciboAlq" Then

            Dim invoice As New ReciboAlqDatos()

            invoice.CopiaDocumento = "Original"
            invoice.TipoDocumento = "Recibo"
            invoice.IdenDocumento = "X"

            Consulta("select max(nrecibo) from  recibos")
            rd.Read()

            invoice.NRecibo = rd(0) + 1
            invoice.SubTotal = total / CantsemanasAlq
            invoice.Total = total
            invoice.TotalLetrasR = Num2Text(total) & " PESOS"

            Consulta("select curdate()")
            rd.Read()
            invoice.FechaEmision = rd(0)
            invoice.FechaHasta = rd(0)
            Consulta("SELECT DATE_ADD(CURDATE(), INTERVAL 1 WEEK)")
            rd.Read()
            invoice.FechaVenceAlq = rd(0)
            invoice.FechaTopeAlq = FechaTopeAlqAux
            invoice.CantSemanas = "(" & CantsemanasAlq & " Semanas)"

            Consulta("select dni, apellido, nombre, direccion, localidad from socios where codsocio = " & codsoc & "")
            rd.Read()

            invoice.DNISocio = rd(0)
            invoice.ApeNombre = rd(1) & " " & rd(2)
            invoice.CondicionIVA = "Consumidor Final"
            invoice.DomicilioSocio = rd(3) & " " & rd(4)
            invoice.condVenta = "Contado"

            For Each item In Facturacion.lstCompra.Items
                Dim article As New ReciboAlqArt()

                article.CodLibro = Convert.ToInt32(Facturacion.lstCompra.Items(i).Text)
                article.TituloLibro = Facturacion.lstCompra.Items(i).SubItems(1).Text
                article.CantidadLibro = Convert.ToInt32(Facturacion.lstCompra.Items(i).SubItems(4).Text)
                article.PrecioUnitario = Convert.ToDecimal(Facturacion.lstCompra.Items(i).SubItems(5).Text)
                article.SubtotalArticulo = Convert.ToDecimal(Val(Facturacion.lstCompra.Items(i).SubItems(5).Text) * Val(Facturacion.lstCompra.Items(i).SubItems(4).Text))

                invoice.Detail.Add(article)

                i = i + 1
            Next

            Dim frm As New ReciboAlqPreview()

            frm.Invoice.Add(invoice)

            frm.Detail = invoice.Detail
            frm.ShowDialog()

        ElseIf tipodoc = "ReciboAlq_Ver" Then

            Dim invoice As New ReciboAlqDatos()
            Dim preciounit As Decimal
            Dim subto As Decimal

            invoice.CopiaDocumento = "Original"
            invoice.TipoDocumento = "Recibo"
            invoice.IdenDocumento = "X"

            Consulta("select nrecibo, fecha, total from recibos WHERE CodAlquiler = " & CodCompra)
            rd.Read()

            invoice.NRecibo = rd(0)
            invoice.SubTotal = total / CantsemanasAlq
            invoice.Total = total
            invoice.TotalLetrasR = Num2Text(total) & " PESOS"
            invoice.FechaEmision = rd(1)
            invoice.FechaHasta = rd(1)

            Consulta("SELECT DATE_ADD(" & Format(rd(1), "yyyyMMdd") & ", INTERVAL 1 WEEK)")
            rd.Read()
            invoice.FechaVenceAlq = rd(0)

            Consulta("SELECT Fecha_Tope FROM Alquileres WHERE CodAlquiler = " & CodCompra)
            rd.Read()
            invoice.FechaTopeAlq = rd(0)
            invoice.CantSemanas = "(" & CantsemanasAlq & " Semanas)"

            Consulta("select dni, apellido, nombre, direccion, localidad from socios where codsocio = " & codsoc)
            rd.Read()

            invoice.DNISocio = rd(0)
            invoice.ApeNombre = rd(1) & " " & rd(2)
            invoice.CondicionIVA = "Consumidor Final"
            invoice.DomicilioSocio = rd(3) & " " & rd(4)
            invoice.condVenta = "Contado"

            Consulta("SELECT l.CodLibro, l.titulo, COUNT(*), l.PrecioAlquiler FROM libros l, ejemplares e, DetalleAlq da WHERE l.CodLibro = e.CodLibro AND e.idEjem = da.idEjem AND da.CodAlquiler = " & CodCompra & " group by l.CodLibro")
            While rd.Read
                Dim article As New ReciboAlqArt()
                article.CodLibro = Convert.ToInt32(rd(0))
                article.TituloLibro = rd(1)
                article.CantidadLibro = Convert.ToInt32(rd(2))
                preciounit = rd(3)
                article.PrecioUnitario = Convert.ToDecimal(preciounit)
                subto = preciounit * rd(2)
                article.SubtotalArticulo = Convert.ToDecimal(subto)

                invoice.Detail.Add(article)
            End While

            Dim frm As New ReciboAlqPreview()

            frm.Invoice.Add(invoice)

            frm.Detail = invoice.Detail
            frm.ShowDialog()

            ' ______________________________________________________________________________________________________________________________________________________________

        End If

        Return 0
    End Function

    Public Function Num2Text(ByVal value As Double) As String
        Select Case value
            Case 0 : Num2Text = "CERO"
            Case 1 : Num2Text = "UN"
            Case 2 : Num2Text = "DOS"
            Case 3 : Num2Text = "TRES"
            Case 4 : Num2Text = "CUATRO"
            Case 5 : Num2Text = "CINCO"
            Case 6 : Num2Text = "SEIS"
            Case 7 : Num2Text = "SIETE"
            Case 8 : Num2Text = "OCHO"
            Case 9 : Num2Text = "NUEVE"
            Case 10 : Num2Text = "DIEZ"
            Case 11 : Num2Text = "ONCE"
            Case 12 : Num2Text = "DOCE"
            Case 13 : Num2Text = "TRECE"
            Case 14 : Num2Text = "CATORCE"
            Case 15 : Num2Text = "QUINCE"
            Case Is < 20 : Num2Text = "DIECI" & Num2Text(value - 10)
            Case 20 : Num2Text = "VEINTE"
            Case Is < 30 : Num2Text = "VEINTI" & Num2Text(value - 20)
            Case 30 : Num2Text = "TREINTA"
            Case 40 : Num2Text = "CUARENTA"
            Case 50 : Num2Text = "CINCUENTA"
            Case 60 : Num2Text = "SESENTA"
            Case 70 : Num2Text = "SETENTA"
            Case 80 : Num2Text = "OCHENTA"
            Case 90 : Num2Text = "NOVENTA"
            Case Is < 100 : Num2Text = Num2Text(Int(value \ 10) * 10) & " Y " & Num2Text(value Mod 10)
            Case 100 : Num2Text = "CIEN"
            Case Is < 200 : Num2Text = "CIENTO " & Num2Text(value - 100)
            Case 200, 300, 400, 600, 800 : Num2Text = Num2Text(Int(value \ 100)) & "CIENTOS"
            Case 500 : Num2Text = "QUINIENTOS"
            Case 700 : Num2Text = "SETECIENTOS"
            Case 900 : Num2Text = "NOVECIENTOS"
            Case Is < 1000 : Num2Text = Num2Text(Int(value \ 100) * 100) & " " & Num2Text(value Mod 100)
            Case 1000 : Num2Text = "MIL"
            Case Is < 2000 : Num2Text = "MIL " & Num2Text(value Mod 1000)
            Case Is < 1000000 : Num2Text = Num2Text(Int(value \ 1000)) & " MIL"
                If value Mod 1000 Then Num2Text = Num2Text & " " & Num2Text(value Mod 1000)
            Case 1000000 : Num2Text = "UN MILLON"
            Case Is < 2000000 : Num2Text = "UN MILLON " & Num2Text(value Mod 1000000)
            Case Is < 1000000000000.0# : Num2Text = Num2Text(Int(value / 1000000)) & " MILLONES"
                If (value - Int(value / 1000000) * 1000000) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000) * 1000000)
            Case 1000000000000.0# : Num2Text = "UN BILLON"
            Case Is < 2000000000000.0# : Num2Text = "UN BILLON " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
            Case Else : Num2Text = Num2Text(Int(value / 1000000000000.0#)) & " BILLONES"
                If (value - Int(value / 1000000000000.0#) * 1000000000000.0#) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
        End Select

        Return Num2Text
    End Function

    Public Function VerNotificaciones()
        Consulta("SELECT * FROM Notificaciones WHERE Vista = 0")
        While rd.Read
            If user = rd(4) Then
                If NotificacionActiva = False Then
                    Notificacion(rd(2), rd(3))
                    BanderaRS = 1
                    Consulta("UPDATE Notificaciones SET Vista = 1 WHERE IdNotificacion = " & rd(0))
                End If
            End If
        End While
        BanderaRS = 0
        Return 0
    End Function
End Module

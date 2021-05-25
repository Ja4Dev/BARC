Public Class Main

    Dim banderaNotif As Boolean
    Dim answ As Integer
    Dim tresdias As String

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Pantalla Principal - Sesion iniciada como : " & user

        Consulta("Select Fecha FROM Calendario WHERE IdCalendario = 3")
        If rd.Read() Then
            If Not Format(Now(), "dd/MM/yyyy") = Format(rd(0), "dd/MM/yyyy") Then ' Calendario Diario
                Consulta("UPDATE Calendario SET Fecha = NOW() WHERE IdCalendario = 3")
                VerSolicitudesCompra()
                VerPuntosStock()
                CalcularBalanceDiario()
            End If
        End If
        If Format(Now(), "dddd").ToString = "Monday" Then ' Calendario Semanalmente
            Consulta("Select Fecha FROM Calendario WHERE IdCalendario = 2")
            rd.Read()
            If Not Format(rd(0), "dd/MM/yyyy") = Format(Now(), "dd/MM/yyyy") Then
                Consulta("UPDATE Calendario SET Fecha = NOW() WHERE IdCalendario = 2")
                VerMorosos()
                DardeBajaInactividadyLegales()
                VerRecorridos()
            End If
        End If
        If Format(Now(), "dd").ToString = "01" Then ' Si es primero de mes (Calendario Mensualmente)
            Consulta("UPDATE Calendario SET Fecha = NOW() WHERE IdCalendario = 1")
            CalcularBalanceMensual()
            Consulta("INSERT INTO Notificaciones VALUES ('', CURDATE(), 'Corredores', 'Se debe asignar Nuevas Zonas a Corredores', 'logistica', 0)")
        End If
        If Format(Now(), "dddd").ToString = "Monday" Or Format(Now(), "dddd").ToString = "Wednesday" Or Format(Now(), "dddd").ToString = "Friday" Then ' cada 3 dias
            VerEnviosNuevos()
        End If
        Consulta("SELECT Fecha FROM Calendario WHERE IdCalendario = 5") ' CAda 1 Hora
        If rd.Read Then
            If Format(Now(), "dd/MM/yyyy") = Format(rd(0), "dd/MM/yyyy") Then
                If Not Format(Now(), "HH") = Format(rd(0), "HH") Then
                    Consulta("UPDATE Calendario SET Fecha = NOW() WHERE IdCalendario = 5")
                    VerSolicitudesCompra()
                End If
            End If
        End If

        VerNotificaciones() ' Notificaciones

        'Permisos
        If user = "root" Then
            btnCobros.Enabled = True
            btnLibros.Enabled = True
            btnBalances.Enabled = True
            btnSocios.Enabled = True
            btnVenAlq.Enabled = True
            btnEnvios.Enabled = True
            btnEventos.Enabled = True
            btnBalances.Enabled = True
            btnABM.Enabled = True
        End If
        If user = "administracion" Then
            btnCobros.Enabled = True
            btnLibros.Enabled = True
            btnBalances.Enabled = True
            btnSocios.Enabled = True
        End If
        If user = "libros" Then
            btnLibros.Enabled = True
        End If
        If user = "logistica" Then
            btnEnvios.Enabled = True
        End If
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        answ = MsgBox("¿Desea cerrar sesión?", MsgBoxStyle.YesNo)

        If answ = 6 Then
            MsgBox("Se ha cerrado sesion correctamente.")
            If NotificacionActiva = True Then
                notif.Close()
                NotificacionActiva = False
            End If
            Me.Close()
            Login.Show()
        End If
    End Sub

    Private Sub btnSocios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSocios.Click
        formulario = "modulo_socios"
        Me.Close()
        Socios.Show()
    End Sub


    Private Sub btnLibros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLibros.Click
        formulario = "modulo_libros"
        Me.Close()
        Libros.Show()
    End Sub

    Private Sub btnVenAlq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVenAlq.Click
        formulario = "modulo_compras"
        Me.Close()
        VentasAlquileres.Show()
    End Sub

    Private Sub btnCobros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCobros.Click
        formulario = "modulo_cobros_busq"
        Me.Close()
        Buscar.Text = "Buscar operacion por socio"
        Buscar.txtSocio.Clear()
        Buscar.ShowDialog()
    End Sub

    Private Sub btnEntrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnvios.Click
        formulario = "modulo_entrega"
        Me.Close()
        frmEnvios.Show()
    End Sub

    Private Sub btnEventos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEventos.Click
        formulario = "modulo_eventos"
        Me.Close()
        frmEventos.Show()
    End Sub

    Private Sub btnBalances_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBalances.Click
        formulario = "modulo_balances"
        Me.Close()
        Balances.Show()
    End Sub

    Public Function VerMorosos()
        Consulta("SELECT DISTINCT CodSocio FROM Compras WHERE FTopePago < CURDATE() AND NOT Estado = 'Pagado'")
        While rd.Read
            codsoc = rd(0)
            BanderaRS = 1
            Consulta("UPDATE Socios SET Estado = 'Moroso' WHERE CodSocio = " & codsoc)
            banderaNotif = True
        End While
        BanderaRS = 0
        Consulta("SELECT DISTINCT CodSocio FROM Alquileres WHERE Fecha_VencimientoPago < CURDATE() AND NOT EstadoPago = 'Pagado'")
        While rd.Read
            codsoc = rd(0)
            BanderaRS = 1
            Consulta("UPDATE Socios SET Estado = 'Moroso' WHERE CodSocio = " & codsoc)
            banderaNotif = True
        End While
        BanderaRS = 0
        If banderaNotif = True Then
            banderaNotif = False
            Consulta("select count(*) FROM notificaciones WHERE Tipo = 'Administracion' AND Detalle = 'Hay Nuevos Socios Deudores' AND Usuario = 'Administracion' AND Fecha = CURDATE()")
            rd.Read()
            If rd(0) = 0 Then
                Consulta("Insert INTO Notificaciones VALUES ('', curdate(), 'Administracion', 'Hay Nuevos Socios Deudores', 'administracion', 0)")
            End If
        End If
        banderaNotif = False
        Return 0
    End Function

    Public Function DardeBajaInactividadyLegales()
        Dim fecha As Integer
        Consulta("SELECT c.CodSocio, GREATEST(Max(FechaCompra), Max(Fecha_Inicio)) FROM Compras c, alquileres a GROUP BY Codsocio")
        BanderaRS = 1
        While rd.Read
            Consulta("SELECT DATEDIFF(CURDATE(), " & Format(rd(1), "yyyyMMdd") & ")")
            rd2.Read()
            fecha = rd2(0)
            If fecha > 60 Then
                Consulta("SELECT Estado FROM Socios WHERE CodSocio = " & rd(0))
                rd2.Read()
                If rd2(0) = "Al Dia" Then
                    Consulta("UPDATE Socios Set Estado = 'Baja' WHERE CodSocio = " & rd(0))
                    Consulta("INSERT INTO BajasSocios VALUES ('', " & rd(0) & ", CURDATE)")
                    Consulta("INSERT INTO Notificaciones VALUES ('', curdate(), 'Atencion al Cliente', 'Hay Socios que han sido dados de baja por Inactividad', 'atencion', 0)")
                ElseIf rd2(0) = "Moroso" Then
                    If fecha > 67 Then
                        Consulta("UPDATE Socios Set Estado = 'Legales' WHERE CodSocio = " & rd(0))
                        Consulta("INSERT INTO Notificaciones VALUES ('', curdate(), 'Atencion al Cliente', 'Hay Nuevos Socios para enviar a legales', 'atencion', 0)")
                    End If
                End If
            End If
        End While
        BanderaRS = 0
        Return 0
    End Function

    Public Function VerSolicitudesCompra()
        Consulta("select count(*) from Solicitudes_compras where estado = 'pendiente'")
        rd.Read()
        If rd(0) <> 0 Then
            Consulta("select count(*) FROM notificaciones WHERE Tipo = 'Administracion' AND Detalle = 'Hay Solicitudes de Compra Pendientes' AND Usuario = 'Administracion' AND Fecha = CURDATE()")
            rd.Read()
            If rd(0) = 0 Then
                Consulta("Insert INTO Notificaciones VALUES ('', curdate(), 'Administracion', 'Hay Solicitudes de Compra Pendientes', 'administracion', 0)")
            End If
        End If
        Return 0
    End Function

    Public Function VerPuntosStock()
        Consulta("CALL VerPuntosPedido(@FaltaStock)")
        Consulta("SELECT @FaltaStock")
        rd.Read()
        If rd(0) = 1 Then
            Consulta("INSERT INTO Notificaciones VALUES ('', CURDATE(), 'Libros', 'Hay Libros que alcanzaron su Punto de Pedido', 'libros', 0)")
        End If
        Return 0
    End Function

    Public Function VerEnviosNuevos()
        Consulta("SELECT COUNT(*) FROM Envios WHERE Estado_Envio = 'Pendiente'")
        rd.Read()
        If rd(0) > 0 Then
            Consulta("INSERT INTO Notificaciones VALUES ('', CURDATE(), 'Envios', 'Hay nuevos envios pendientes', 'logistica', 0)")
        End If
        Return 0
    End Function

    Public Function CalcularBalanceDiario()
        Dim Balance As Decimal
        Dim favor As Integer
        Consulta("select * from balances_diarios WHERE FechaBalance = (SELECT MAX(FechaBalance) FROM Balances_Diarios)")
        rd.Read()
        Balance = rd(2)
        Consulta("SELECT total FROM recibos WHERE Fecha = CURDATE()-1")
        While rd.Read
            Balance = Balance + rd(0)
        End While
        Consulta("SELECT monto FROM Cheques WHERE FechaEmision = CURDATE()-1")
        While rd.Read
            Balance = Balance - rd(0)
        End While
        If Balance >= 0 Then
            favor = 1
        Else
            favor = 0
        End If
        Consulta("INSERT INTO Balances_Diarios VALUES ('', CURDATE()-1, " & Balance & ", " & favor & ")")
        Consulta("INSERT INTO Notificaciones VALUES ('', CURDATE(), 'Administracion', 'El Balance Diario ha sido Calculado', 'administracion', 0)")
        Return 0
    End Function

    Public Function CalcularBalanceMensual()
        Dim Balance As Decimal
        Dim favor As Integer
        Consulta("select * from balances_diarios WHERE FechaCierre >= (SELECT MAX(FechaCierre) FROM Balances_Mensuales)")
        While rd.Read()
            Balance = rd(2)
        End While
        If Balance >= 0 Then
            favor = 1
        Else
            favor = 0
        End If
        Consulta("INSERT INTO Balances_Mensuales VALUES ('', CURDATE()-1, " & Balance & ", " & favor & ")")
        Consulta("INSERT INTO Notificaciones VALUES ('', CURDATE(), 'Administracion', 'El Balance Mensual ha sido Calculado', 'administracion', 0)")
        Return 0
    End Function

    Public Function VerRecorridos()
        Dim codCorredor As Integer
        Dim CodSocio As Integer
        Dim NRecorrido As Integer
        Consulta("SELECT CodCompra FROM(Compras) WHERE Estado = 'Impago' GROUP BY Codsocio UNION Select CodAlquiler FROM Alquileres WHERE EstadoPago = 'Impago' GROUP BY CodSocio")
        BanderaRS = 1
        While rd.Read
            Consulta("SELECT Corredor, CodSocio FROM Compras WHERE CodCompra = " & rd(0))
            If Not rd2.Read Then
                Consulta("SELECT Corredor, CodSocio FROM Alquileres WHERE CodAlquiler = " & rd(0))
                rd2.Read()
            End If
            codCorredor = rd2(0)
            CodSocio = rd2(1)
            Consulta("SELECT COUNT(*) FROM recorridos WHERE fecha = curdate() AND corredor = " & codCorredor)
            rd2.Read()
            If rd2(0) = 0 Then
                Consulta("INSERT INTO Recorridos VALUES ('', CURDATE(), " & codCorredor & ")")
            End If
            Consulta("SELECT NRecorrido FROM Recorridos WHERE Fecha = CURDATE() AND Corredor = " & codCorredor)
            rd2.Read()
            NRecorrido = rd2(0)
            Consulta("SELECT COUNT(*) FROM Recorridos_Soc WHERE NRecorrido = " & NRecorrido & " AND Socio = " & CodSocio)
            rd2.Read()
            If rd2(0) = 0 Then
                Consulta("INSERT INTO Recorridos_Soc VALUES (" & NRecorrido & ", " & CodSocio & ")")
            End If
        End While
        Consulta("INSERT INTO Notificaciones VALUES ('', CURDATE(), 'Corredores', 'Los Recorridos de los Corredores han sido cargados', 'logistica', 0)")
        BanderaRS = 0
        Return 0
    End Function

    Private Sub btnABM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnABM.Click
        Me.Close()
        frmABM.Show()
    End Sub
End Class
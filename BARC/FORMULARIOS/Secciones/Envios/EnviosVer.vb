Public Class EnviosVer

    Dim indice As Integer
    Dim Monto_Total As Integer
    Dim cantsemanas As Integer
    Dim numRemito As Integer
    Dim ans As Integer
    Dim cantlibros As Integer

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

        Me.Close()
        frmEnvios.Show()

    End Sub

    Private Sub EnviosVer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lstEnvios.Items.Clear()
        indice = 0
        Consulta("SELECT * FROM Envios WHERE Estado_Envio = 'Pendiente'")
        BanderaRS = 1

        While rd.Read

            lstEnvios.Items.Add(rd(0))

            If Not IsDBNull(rd(2)) Then

                Consulta("SELECT Fecha_Inicio FROM alquileres WHERE CodAlquiler = " & rd(2))
                rd2.Read()
                lstEnvios.Items(indice).SubItems.Add(Format(rd2(0), "dd/MM/yyyy"))
                lstEnvios.Items(indice).SubItems.Add("Alquiler")
                lstEnvios.Items(indice).SubItems.Add(rd(2))

            Else

                Consulta("SELECT FechaCompra FROM Compras WHERE CodCompra = " & rd(3))
                rd2.Read()
                lstEnvios.Items(indice).SubItems.Add(Format(rd2(0), "dd/MM/yyyy"))
                lstEnvios.Items(indice).SubItems.Add("Compra")
                lstEnvios.Items(indice).SubItems.Add(rd(3))

            End If

            lstEnvios.Items(indice).SubItems.Add(rd(4))
            indice += 1

        End While

        BanderaRS = 0

    End Sub

    Private Sub lstEnvios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstEnvios.SelectedIndexChanged

        If lstEnvios.FocusedItem.SubItems(4).Text = "Pendiente" Then

            btnAceptar.Enabled = True

        Else

            btnAceptar.Enabled = False

        End If

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        ans = MsgBox("Confirma que quiere Aceptar este envio?", MsgBoxStyle.YesNo, "Atencion")

        If ans = 6 Then

            If lstEnvios.FocusedItem.SubItems(2).Text = "Compra" Then

                Consulta("SELECT SUM(Monto_Individual) FROM DetalleCompra WHERE CodCompra = " & Val(lstEnvios.FocusedItem.SubItems(3).Text))
                rd.Read()
                Monto_Total = rd(0)
                Consulta("INSERT INTO Remitos VALUES ('', " & Monto_Total & ", " & Val(lstEnvios.FocusedItem.SubItems(3).Text) & ", NULL, NULL)")
                Consulta("SELECT MAX(NRemito) FROM Remitos")
                rd.Read()
                numRemito = rd(0)
                Consulta("SELECT IdEjem FROM DetalleCompra WHERE CodCompra = " & Val(lstEnvios.FocusedItem.SubItems(3).Text))
                BanderaRS = 1
                cantlibros = 0

                While rd.Read

                    Consulta("INSERT INTO DetalleRem VALUES(" & numRemito & ", " & rd(0) & ")")
                    cantlibros += 1

                End While

                BanderaRS = 0

            Else

                Consulta("select DATEDIFF(Fecha_Tope, Fecha_Inicio) FROM Alquileres Al WHERE al.CodAlquiler = " & Val(lstEnvios.FocusedItem.SubItems(3).Text))
                rd.Read()
                cantsemanas = (rd(0) / 7)
                Consulta("select SUM(Monto_Individual_Semanal) FROM Alquileres Al, DetalleAlq da WHERE al.Codalquiler = da.Codalquiler and da.CodAlquiler = " & Val(lstEnvios.FocusedItem.SubItems(3).Text))
                rd.Read()
                Monto_Total = rd(0) * cantsemanas
                Consulta("INSERT INTO Remitos VALUES ('', " & Monto_Total & ", NULL, " & Val(lstEnvios.FocusedItem.SubItems(3).Text) & ", NULL)")
                Consulta("SELECT MAX(NRemito) FROM Remitos")
                rd.Read()
                numRemito = rd(0)
                Consulta("SELECT IdEjem FROM DetalleAlq WHERE CodAlquiler = " & Val(lstEnvios.FocusedItem.SubItems(3).Text))
                BanderaRS = 1
                cantlibros = 0

                While rd.Read

                    Consulta("INSERT INTO DetalleRem VALUES(" & numRemito & ", " & rd(0) & ")")
                    cantlibros += 1

                End While

                BanderaRS = 0

            End If

            lstEnvios.FocusedItem.SubItems(4).Text = "Enviado"

            Consulta("UPDATE Envios SET Estado_Envio = 'Enviado', Fecha_Aceptado = CURDATE() WHERE CodEnvio = " & Val(lstEnvios.FocusedItem.Text))
            Consulta("CALL HojaDeRuta(" & numRemito & ", " & cantlibros & ")")

            InvoiceGenerate("remito")

        End If

    End Sub

End Class


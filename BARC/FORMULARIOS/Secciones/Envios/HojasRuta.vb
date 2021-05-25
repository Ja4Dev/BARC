Public Class HojasRuta
    Dim indice As Integer
    Dim ans As Integer

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmEnvios.Show()
    End Sub

    Private Sub LOAD_HojasRuta(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        indice = 0
        Consulta("SELECT * FROM Hojas_de_Ruta")
        While rd.Read()
            lstHojasR.Items.Add(rd(0))
            lstHojasR.Items(indice).SubItems.Add(Format(rd(1), "dd/MM/yyyy"))
            lstHojasR.Items(indice).SubItems.Add(rd(2))
            indice += 1
        End While
    End Sub

    Private Sub lstHojasR_ColumnWidthChanging(sender As Object, e As System.Windows.Forms.ColumnWidthChangingEventArgs) Handles lstHojasR.ColumnWidthChanging

        e.Cancel = True
        e.NewWidth = lstHojasR.Columns(e.ColumnIndex).Width

    End Sub

    Private Sub lstHojasRDet_ColumnWidthChanging(sender As Object, e As System.Windows.Forms.ColumnWidthChangingEventArgs) Handles lstHojasRDet.ColumnWidthChanging

        e.Cancel = True
        e.NewWidth = lstHojasRDet.Columns(e.ColumnIndex).Width

    End Sub

    Private Sub lstHojasR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstHojasR.SelectedIndexChanged

        indice = 0
        lstHojasRDet.Items.Clear()
        btnRemito.Enabled = False
        btnVer.Enabled = True
        btnEnviar.Enabled = True

        If lstHojasR.FocusedItem.SubItems(2).Text = "Enviado" Then
            btnCambiarEstado.Enabled = True
        ElseIf lstHojasR.FocusedItem.SubItems(2).Text = "Entregado" Then
            btnCambiarEstado.Enabled = False
            btnEnviar.Enabled = False
        End If

        Consulta("select * from Hojas_de_Ruta_Det where nhojaruta = " & Val(lstHojasR.FocusedItem.Text))

        While rd.Read

            lstHojasRDet.Items.Add(indice + 1)
            lstHojasRDet.Items(indice).SubItems.Add(rd(1))
            lstHojasRDet.Items(indice).SubItems.Add(rd(2))
            indice += 1

        End While

    End Sub

    Private Sub lstHojasRDet_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstHojasRDet.SelectedIndexChanged

        btnRemito.Enabled = True

    End Sub

    Private Sub btnRemito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemito.Click
        NumeroRemito = Val(lstHojasRDet.FocusedItem.SubItems(1).Text)
        Consulta("SELECT CodCompra, CodAlquiler FROM Remitos WHERE NRemito= " & NumeroRemito)
        rd.Read()
        If IsDBNull(rd(0)) Then
            CodCompra = rd(1)
        Else
            CodCompra = rd(0)
        End If
        InvoiceGenerate("remito_ver")

    End Sub

    Private Sub btnImprimirHoja_Click(sender As System.Object, e As System.EventArgs) Handles btnEnviar.Click

        ans = MsgBox("¿Desea Enviar la Hoja de Ruta?", MsgBoxStyle.YesNo, "Atencion")

        If ans = 6 Then

            lstHojasR.FocusedItem.SubItems(2).Text = "Enviado"

            Consulta("UPDATE Hojas_de_Ruta SET Estado = 'Enviado' WHERE NHojaRuta = " & Val(lstHojasR.FocusedItem.Text))

            InvoiceGenerate("hdruta_imp")

        End If

    End Sub

    Private Sub btnCambiarEstado_Click(sender As System.Object, e As System.EventArgs) Handles btnCambiarEstado.Click
        ans = MsgBox("Desea actualizar el estado de la Hoja de Ruta a Entregado?", MsgBoxStyle.YesNo, "Atencion")
        If ans = 6 Then
            lstHojasR.FocusedItem.SubItems(2).Text = "Entregado"
            Consulta("UPDATE Hojas_de_Ruta SET Estado = 'Entregado' WHERE NHojaRuta = " & Val(lstHojasR.FocusedItem.Text))
            Consulta("SELECT r.CodAlquiler, r.CodCompra, hr.NRemito FROM Remitos r, Hojas_de_Ruta_Det hr WHERE hr.NRemito = r.NRemito AND NHojaRuta = " & Val(lstHojasR.FocusedItem.Text))
            BanderaRS = 1
            While rd.Read
                If IsDBNull(rd(0)) Then
                    Consulta("UPDATE Envios SET Estado_Envio = 'Entregado' WHERE CodCompra = " & rd(1))
                Else
                    Consulta("UPDATE Envios SET Estado_Envio = 'Entregado' WHERE CodAlquiler = " & rd(0))
                End If
                Consulta("UPDATE Remitos SET FechaRecepcion = CURDATE() WHERE NRemito = " & rd(2))
            End While
            BanderaRS = 0
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnVer.Click
        InvoiceGenerate("hdruta_imp")
    End Sub



End Class
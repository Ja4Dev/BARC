Public Class EventosLista
    Dim indice As Integer

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmEventos.Show()
    End Sub

    Private Sub lstDetalle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstDetalle.SelectedIndexChanged
        btnComprobante.Enabled = True
    End Sub

    Private Sub lstEventos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstEventos.SelectedIndexChanged
        lstDetalle.Items.Clear()
        btnComprobante.Enabled = False
        Consulta("SELECT Motivo, Descripcion FROM Eventos WHERE NEvento = " & Val(lstEventos.FocusedItem.Text))
        rd.Read()
        lblMotivo.Text = "Motivo: " & rd(0)
        lblDescripcion.Text = "Descripcion: " & rd(1)
        indice = 0
        Consulta("SELECT e.Codsocio, Nombre, Apellido FROM AsisEvento e, Socios s WHERE s.CodSocio = e.CodSocio AND e.NEvento = " & Val(lstEventos.FocusedItem.Text))
        While rd.Read
            lstDetalle.Items.Add(rd(0))
            lstDetalle.Items(indice).SubItems.Add(rd(1) & " " & rd(2))
            indice += 1
        End While
        FechaEvento_ = lstEventos.FocusedItem.SubItems(1).Text
        NomEvento = lstEventos.FocusedItem.SubItems(2).Text
    End Sub

    Private Sub EventosLista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstEventos.Items.Clear()
        Consulta("SELECT NEvento, Fecha, Nombre FROM Eventos")
        While rd.Read()
            lstEventos.Items.Add(rd(0))
            lstEventos.Items(indice).SubItems.Add(Format(rd(1), "dd/MM/yyyy"))
            lstEventos.Items(indice).SubItems.Add(rd(2))
            indice += 1
        End While
    End Sub

    Private Sub btnComprobante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComprobante.Click
        codsoc = Val(lstDetalle.FocusedItem.Text)
        InvoiceGenerate("EventoAsis")
    End Sub
End Class
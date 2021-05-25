Public Class RecorridosCorredores
    Dim indice As Integer

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmEnvios.Show()
    End Sub

    Private Sub RecorridosCorredores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        indice = 0
        Consulta("SELECT NRecorrido, r.Fecha, r.Corredor, c.Nombre, c.Apellido FROM Recorridos r, Corredores c WHERE r.Corredor = c.CodCorredor ORDER BY r.Fecha DESC")
        While rd.Read
            lstRecorridos.Items.Add(rd(0))
            lstRecorridos.Items(indice).SubItems.Add(Format(rd(1), "dd/MM/yyyy"))
            lstRecorridos.Items(indice).SubItems.Add(rd(2))
            lstRecorridos.Items(indice).SubItems.Add(rd(3))
            lstRecorridos.Items(indice).SubItems.Add(rd(4))
            indice += 1
        End While
    End Sub

    Private Sub lstRecorridos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstRecorridos.SelectedIndexChanged
        lstDetalle.Items.Clear()
        indice = 0
        Consulta("SELECT r.Socio, Nombre, Apellido, Direccion FROM Recorridos_Soc r, Socios s WHERE r.Socio = s.CodSocio AND NRecorrido = " & lstRecorridos.FocusedItem.Text)
        While rd.Read
            lstDetalle.Items.Add(rd(0))
            lstDetalle.Items(indice).SubItems.Add(rd(1))
            lstDetalle.Items(indice).SubItems.Add(rd(2))
            lstDetalle.Items(indice).SubItems.Add(rd(3))
            indice += 1
        End While
    End Sub
End Class
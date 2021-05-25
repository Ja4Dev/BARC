Public Class BalancesDiarios
    Dim indice As Integer
    Dim Fecha As Date

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        Balances.Show()
    End Sub

    Private Sub BalancesDiarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        indice = 0
        Consulta("SELECT * FROM balances_diarios ORDER BY FechaBalance DESC")
        While rd.Read
            lstBalance.Items.Add(rd(0))
            lstBalance.Items(indice).SubItems.Add(Format(rd(1), "dd/MM/yyyy"))
            lstBalance.Items(indice).SubItems.Add(rd(2))
            indice += 1
        End While
    End Sub

    Private Sub lstBalance_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstBalance.SelectedIndexChanged
        Consulta("SELECT FechaBalance FROM Balances_Diarios WHERE IDBalance = " & Val(lstBalance.FocusedItem.Text))
        rd.Read()
        Fecha = rd(0)
        lstEntradas.Items.Clear()
        lstSalidas.Items.Clear()
        Consulta("SELECT NRecibo, CodCompra, CodAlquiler, total, motivo FROM Recibos WHERE Motivo LIKE 'Pago%' AND Fecha = " & Format(Fecha, "yyyyMMdd"))
        indice = 0
        While rd.Read
            lstEntradas.Items.Add(rd(0))
            If IsDBNull(rd(1)) Then
                lstEntradas.Items(indice).SubItems.Add(rd(2))
            Else
                lstEntradas.Items(indice).SubItems.Add(rd(1))
            End If
            lstEntradas.Items(indice).SubItems.Add(rd(4))
            lstEntradas.Items(indice).SubItems.Add(rd(3))
            indice += 1
        End While
        indice = 0
        Consulta("SELECT NCheque, p.Proveedor, NFacturaProveedor, Monto FROM Cheques c, Proveedores p WHERE p.CodProveedor = c.Proveedor AND FechaEmision = " & Format(Fecha, "yyyyMMdd"))
        While rd.Read
            lstSalidas.Items.Add(rd(0))
            lstSalidas.Items(indice).SubItems.Add(rd(1))
            lstSalidas.Items(indice).SubItems.Add(rd(2))
            lstSalidas.Items(indice).SubItems.Add(rd(3))
            indice += 1
        End While
    End Sub
End Class
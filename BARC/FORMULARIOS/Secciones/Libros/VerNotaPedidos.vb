Public Class VerNotaPedidos
    Dim indice As Integer
    Dim NSoli As Integer

    Private Sub lstComp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstComp.SelectedIndexChanged
        btnImprimr.Enabled = True
        NSoli = Val(lstComp.FocusedItem.SubItems(2).Text)
        lstDetalle.Items.Clear()
        indice = 0
        Consulta("SELECT Libro, Cantidad FROM Solicitudes_Compras_Det WHERE NSoli = " & NSoli)
        While rd.Read
            lstDetalle.Items.Add(indice + 1)
            lstDetalle.Items(indice).SubItems.Add(rd(0))
            lstDetalle.Items(indice).SubItems.Add(rd(1))
            indice += 1
        End While
    End Sub

    Private Sub VerNotaPedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        indice = 0
        Consulta("SELECT NNotaPedido, np.Fecha, np.Nsoli, np.Estado, p.Proveedor FROM Proveedores P, Nota_Pedidos np, Solicitudes_Compras sc WHERE p.CodProveedor = sc.Proveedor AND np.NSoli = sc.NSoli AND NNotaPedido > 100000")
        While rd.Read
            lstComp.Items.Add(rd(0))
            lstComp.Items(indice).SubItems.Add(rd(1))
            lstComp.Items(indice).SubItems.Add(rd(2))
            lstComp.Items(indice).SubItems.Add(rd(3))
            lstComp.Items(indice).SubItems.Add(rd(4))
            indice += 1
        End While
    End Sub

    Private Sub btnImprimr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimr.Click
        numNotaPedido = Val(lstComp.FocusedItem.Text)
        InvoiceGenerate("notapedido")
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        Libros.Show()
    End Sub
End Class
Public Class VerCompEntrada
    Dim indice As Integer
    Dim ans As Integer
    Dim montototal As Decimal

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        Libros.Show()
    End Sub

    Private Sub VerCompEntrada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        indice = 0
        Consulta("SELECT * FROM Comprobantes_Entradas WHERE IDCompEntrada > 100000")
        BanderaRS = 1
        While rd.Read
            lstComp.Items.Add(rd(0))
            lstComp.Items(indice).SubItems.Add(rd(1))
            Consulta("SELECT p.Proveedor FROM Proveedores P, Nota_Pedidos np, Solicitudes_Compras sc WHERE p.CodProveedor = sc.Proveedor AND np.NSoli = sc.NSoli AND NNotaPedido = " & rd(1))
            rd2.Read()
            lstComp.Items(indice).SubItems.Add(rd2(0))
            lstComp.Items(indice).SubItems.Add(rd(2))
            If rd(3) = 1 Then
                lstComp.Items(indice).SubItems.Add("Pagado")
            Else
                lstComp.Items(indice).SubItems.Add("No Pagado")
            End If
            indice += 1
        End While
        BanderaRS = 0
    End Sub

    Private Sub lstComp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstComp.SelectedIndexChanged
        If lstComp.FocusedItem.SubItems(4).Text <> "Pagado" Then
            btnPagar.Enabled = True
            btnCheque.Enabled = False
        Else
            btnPagar.Enabled = False
            btnCheque.Enabled = True
        End If
        lstDetalle.Items.Clear()
        indice = 0
        btnImprimirComp.Enabled = True
        Consulta("SELECT * FROM Comprobantes_Entradas_Det WHERE IDCompEntrada = " & Val(lstComp.FocusedItem.Text))
        While rd.Read
            lstDetalle.Items.Add(indice + 1)
            lstDetalle.Items(indice).SubItems.Add(rd(2))
            lstDetalle.Items(indice).SubItems.Add(rd(3))
            lstDetalle.Items(indice).SubItems.Add(rd(4))
            indice += 1
        End While
    End Sub

    Private Sub btnImprimirComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirComp.Click

        numCompEntrada = lstComp.FocusedItem.Text
        numNotaPedido = lstComp.FocusedItem.SubItems(1).Text
        numFacProveedor = lstComp.FocusedItem.SubItems(3).Text

        InvoiceGenerate("compEntradaLibros")
    End Sub

    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click

        ans = MsgBox("Desea marcar como pagada la Factura del Proveedor?", MsgBoxStyle.YesNo, "Atencion")

        If ans = 6 Then

            montototal = 0

            For Each item In lstDetalle.Items

                montototal = montototal + (Val(item.Subitems(3).Text) * Val(item.Subitems(2).Text))

            Next item

            Consulta("UPDATE Comprobantes_Entradas Set Pagado = 1 WHERE IDCompEntrada = " & Val(lstComp.FocusedItem.Text))

            btnPagar.Enabled = False
            btnCheque.Enabled = True

            Consulta("SELECT sc.Proveedor FROM Nota_Pedidos np, Solicitudes_Compras sc WHERE np.NSoli = sc.NSoli AND NNotaPedido = " & Val(lstComp.FocusedItem.SubItems(1).Text))
            rd.Read()

            Consulta("INSERT INTO Cheques VALUES ('', " & montototal & ", " & rd(0) & ", CURDATE(), NULL, " & Val(lstComp.FocusedItem.SubItems(3).Text) & ")")

            Consulta("select max(NCheque) from cheques")
            rd.Read()

            codcheque = rd(0)

            lstComp.FocusedItem.SubItems(4).Text = "Pagado"

            MsgBox("Factura pagada, generando cheque", MsgBoxStyle.Information, "Aviso")

            InvoiceGenerate("cheque")

        End If

    End Sub

    Private Sub btnCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheque.Click

        NFacProv = lstComp.FocusedItem.SubItems(3).Text

        InvoiceGenerate("cheque_ver")

    End Sub
End Class
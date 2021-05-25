Public Class ActualizarLibros
    Dim indice As Integer
    Dim bandera As Boolean
    Dim notapedido As Integer
    Dim estadoNota As String

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        Libros.Show()
    End Sub

    Private Sub btnVerificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerificar.Click
        lstDetalleNP.Items.Clear()
        If Trim(txtNotaPedido.Text) = "" Then
            MsgBox("Ingrese una Nota de Pedido Valida.", MsgBoxStyle.OkOnly, "Atencion")
            txtNotaPedido.Clear()
            txtNotaPedido.Focus()
        Else
            Consulta("SELECT Estado FROM Nota_Pedidos WHERE NNotaPedido = " & Val(txtNotaPedido.Text) & " AND Estado <> 'Recibido'")
            If rd.Read() Then
                indice = 0
                estadoNota = rd(0)
                Consulta("SELECT Libro, Cantidad, sc.Proveedor FROM Solicitudes_Compras sc, Solicitudes_Compras_Det scd, Nota_Pedidos np WHERE NNotaPedido = " & Trim(txtNotaPedido.Text) & " AND np.NSoli = sc.NSoli AND sc.NSoli = scd.NSoli AND NOT np.Estado = 'Recibido'")
                While rd.Read
                    CodProveedor = rd(2)
                    lstDetalleNP.Items.Add(indice + 1)
                    lstDetalleNP.Items(indice).SubItems.Add(rd(0))
                    BanderaRS = 1
                    Consulta("SELECT Titulo FROM Libros WHERE ISBN = '" & rd(0) & "'")
                    If rd2.Read Then
                        lstDetalleNP.Items(indice).SubItems.Add(rd2(0))
                    Else
                        lstDetalleNP.Items(indice).SubItems.Add("Libro no existente en la base de datos")
                    End If
                    lstDetalleNP.Items(indice).SubItems.Add(rd(1))
                    indice += 1
                End While
                btnVerificar.Enabled = False
                notapedido = Val(txtNotaPedido.Text)
                BanderaRS = 0
                If estadoNota = "Parcial" Then
                    Consulta("SELECT DISTINCT ced.Libro, ced.Cantidad FROM Solicitudes_Compras_Det scd, Solicitudes_Compras sc, Nota_Pedidos np,Comprobantes_Entradas ce, Comprobantes_Entradas_Det ced WHERE scd.NSoli = sc.NSoli AND sc.NSoli = np.NSoli AND np.NNotaPedido = ce.IdNotaPedido AND ce.IDCompEntrada = ced.IDCompEntrada AND np.NNotaPEdido = 100001")
                    While rd.Read()
                        For Each item In lstDetalleNP.Items
                            If item.SubItems(1).Text = rd(0) Then
                                item.SubItems(3).Text = Val(item.SubItems(3).Text) - rd(1)
                            End If
                        Next item
                    End While
                End If
            Else
                MsgBox("Ingrese una Nota de Pedido Valida.", MsgBoxStyle.OkOnly, "Atencion")
                txtNotaPedido.Clear()
                txtNotaPedido.Focus()
            End If
            End If
        indice = 0
    End Sub

    Private Sub txtNotaPedido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNotaPedido.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtNotaPedido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNotaPedido.TextChanged
        btnVerificar.Enabled = True
    End Sub

    Private Sub lstDetalleNP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstDetalleNP.SelectedIndexChanged
        btnAgregar.Enabled = True
        btnQuitar.Enabled = False
    End Sub

    Private Sub lstRecibidos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstRecibidos.SelectedIndexChanged
        btnAgregar.Enabled = False
        btnQuitar.Enabled = True
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        btnActualizar.Enabled = True
        If Not Val(lstDetalleNP.FocusedItem.SubItems(3).Text) = 0 Then
            indice = lstRecibidos.Items.Count
            For Each item In lstRecibidos.Items
                If item.SubItems(1).Text = lstDetalleNP.FocusedItem.SubItems(1).Text Then
                    item.SubItems(3).Text = Val(item.SubItems(3).Text) + 1
                    bandera = True
                End If
            Next item
            If bandera = False Then
                lstRecibidos.Items.Add(lstDetalleNP.FocusedItem.Text)
                lstRecibidos.Items(indice).SubItems.Add(lstDetalleNP.FocusedItem.SubItems(1).Text)
                lstRecibidos.Items(indice).SubItems.Add(lstDetalleNP.FocusedItem.SubItems(2).Text)
                lstRecibidos.Items(indice).SubItems.Add(1)
                lstRecibidos.Items(indice).SubItems.Add("")
            End If
            lstDetalleNP.FocusedItem.SubItems(3).Text = Val(lstDetalleNP.FocusedItem.SubItems(3).Text) - 1
            bandera = False
        End If
    End Sub

    Private Sub btnQuitar_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitar.Click
        For Each item In lstDetalleNP.Items
            If item.Text = lstRecibidos.FocusedItem.Text Then
                indice = item.Index
            End If
        Next item
        If Not Val(lstRecibidos.FocusedItem.SubItems(3).Text) = 1 Then
            lstRecibidos.FocusedItem.SubItems(3).Text = Val(lstRecibidos.FocusedItem.SubItems(3).Text) - 1
            lstDetalleNP.Items(indice).SubItems(3).Text = Val(lstDetalleNP.Items(indice).SubItems(3).Text) + 1
        Else
            lstRecibidos.FocusedItem.Remove()
            lstDetalleNP.Items(indice).SubItems(3).Text = Val(lstDetalleNP.Items(indice).SubItems(3).Text) + 1
            btnQuitar.Enabled = False
        End If
        If lstRecibidos.Items.Count() = 0 Then
            btnActualizar.Enabled = False
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        Dim i As Integer
        i = 0
        For Each item In lstDetalleNP.Items
            If Val(item.SubItems(3).Text) = 0 Then
                i = i + 1
            End If
        Next item
        If i = lstDetalleNP.Items.Count() Then ' si el pedido llego completo
            Consulta("UPDATE Nota_Pedidos SET Estado = 'Recibido' WHERE NNotaPedido = " & notapedido)
        Else ' si no llego completo
            Consulta("UPDATE Nota_Pedidos SET Estado = 'Parcial' WHERE NNotaPedido = " & notapedido)
        End If
        numFactura.ShowDialog()
        Consulta("INSERT INTO Comprobantes_Entradas VALUES ('', " & notapedido & ", " & NFacProv & ", 0)")
        For Each item In lstRecibidos.Items
            NumISBN = item.SubItems(1).Text
            CantEjemplares = Val(item.SubItems(3).Text)
            Consulta("SELECT COUNT(*) FROM Libros WHERE ISBN = '" & item.SubItems(1).Text & "'")
            rd.Read()
            precioUnitario.ShowDialog()
            item.SubItems(4).Text = PrecioUnit
            If rd(0) = 0 Then
                AgregarLibro.ShowDialog()
                AgregarEjemplar.ShowDialog()
            Else
                AgregarEjemplar.ShowDialog()
            End If
            Consulta("CALL CompEntradaDetLibros('" & item.SubItems(1).Text & "', " & Val(item.SubItems(3).Text) & ", " & PrecioUnit & ")")
        Next item
        MsgBox("Libros Cargados Correctamente")

        Consulta("select max(idcompentrada) from comprobantes_entradas")
        rd.Read()

        numCompEntrada = rd(0)

        numNotaPedido = txtNotaPedido.Text

        numFacProveedor = NFacProv

        InvoiceGenerate("compEntradaLibros_gen")
        Me.Close()
        Libros.Show()
    End Sub

    Private Sub ActualizarLibros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstDetalleNP.Items.Clear()
        lstRecibidos.Items.Clear()
    End Sub
End Class
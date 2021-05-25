Public Class SolicitudesEspera
    Dim indice As Integer
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        Libros.Show()
    End Sub

    Private Sub lstSolicitudes_ColumnWidthChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangingEventArgs) Handles lstSolicitudes.ColumnWidthChanging

        e.Cancel = True
        e.NewWidth = lstSolicitudes.Columns(e.ColumnIndex).Width

    End Sub

    Private Sub lstDetalle_ColumnWidthChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangingEventArgs) Handles lstDetalle.ColumnWidthChanging

        e.Cancel = True
        e.NewWidth = lstDetalle.Columns(e.ColumnIndex).Width


    End Sub

    Private Sub lstSolicitudes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSolicitudes.SelectedIndexChanged
        If lstSolicitudes.FocusedItem.SubItems(3).Text = "Pendiente" Then
            btnAceptar.Enabled = True
            btnDenegar.Enabled = True
        Else
            btnAceptar.Enabled = False
            btnDenegar.Enabled = False
        End If
        lstDetalle.Items.Clear()
        indice = 0
        Consulta("SELECT Libro, Cantidad From Solicitudes_Compras_Det WHERE NSoli = '" & lstSolicitudes.FocusedItem.Text & "'")
        BanderaRS = 1
        While rd.Read
            lstDetalle.Items.Add(indice + 1)
            lstDetalle.Items(indice).SubItems.Add(rd(0))
            Consulta("SELECT Titulo FROM Libros WHERE ISBN = '" & rd(0) & "'")
            If rd2.Read() Then
                lstDetalle.Items(indice).SubItems.Add(rd2(0))
            Else
                lstDetalle.Items(indice).SubItems.Add("Libro no Existente en la Base de Datos")
            End If
            lstDetalle.Items(indice).SubItems.Add(rd(1))
            indice = indice + 1
        End While
        BanderaRS = 0
    End Sub

    Private Sub SolicitudesEspera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        indice = 0
        Consulta("SELECT * FROM Solicitudes_Compras")
        While rd.Read
            If Not rd(0) = 100000 Then
                BanderaRS = 1
                lstSolicitudes.Items.Add(rd(0))
                lstSolicitudes.Items(indice).SubItems.Add(rd(3))
                Consulta("SELECT Proveedor FROM Proveedores WHERE CodProveedor = " & rd(1))
                rd2.Read()
                lstSolicitudes.Items(indice).SubItems.Add(rd2(0))
                lstSolicitudes.Items(indice).SubItems.Add(rd(2))
                indice += 1
            End If
        End While
        BanderaRS = 0
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Consulta("UPDATE Solicitudes_Compras SET Estado = 'Aceptado' WHERE NSoli = " & Val(lstSolicitudes.FocusedItem.Text))
        MsgBox("Solicitud de Compra Aceptada, Generando Nota de Pedido")
        Consulta("INSERT INTO Nota_Pedidos VALUES ('', CURDATE(), " & Val(lstSolicitudes.FocusedItem.Text) & ", 'Pendiente')")
        lstSolicitudes.FocusedItem.SubItems(3).Text = "Aceptado"

        Consulta("select max(NNotaPedido) FROM Nota_Pedidos")
        rd.Read()
        numNotaPedido = rd(0)

        InvoiceGenerate("notapedido")

        btnAceptar.Enabled = False
        btnDenegar.Enabled = False
    End Sub

    Private Sub btnDenegar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDenegar.Click
        Consulta("UPDATE Solicitudes_Compras SET Estado = 'Denegado' WHERE NSoli = " & Val(lstSolicitudes.FocusedItem.Text))
        MsgBox("Solicitud de Compra Denegada Satisfactoriamente.")
        lstSolicitudes.FocusedItem.SubItems(3).Text = "Denegado"
        btnAceptar.Enabled = False
        btnDenegar.Enabled = False
    End Sub



End Class
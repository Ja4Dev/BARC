Public Class LibrosModificacion
    Dim indice As Integer

    ' titulo, isbn, editorial, fpubli, precioventa, precioalq, ppv, ppa

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmABM.Show()
    End Sub

    Private Sub LibrosModificacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Consulta("SELECT CodLibro, Titulo, ISBN, nombreEditorial, F_Publicacion, PrecioVenta, PrecioAlquiler, PuntoPedido, PuntoPedidoAlquiler FROM Libros l, Editoriales E WHERE CodEditorial = Editorial")
        While rd.Read
            lstLibros.Items.Add(rd(0))
            lstLibros.Items(indice).SubItems.Add(rd(1))
            lstLibros.Items(indice).SubItems.Add(rd(2))
            lstLibros.Items(indice).SubItems.Add(rd(3))
            lstLibros.Items(indice).SubItems.Add(rd(4))
            lstLibros.Items(indice).SubItems.Add(rd(5))
            lstLibros.Items(indice).SubItems.Add(rd(6))
            lstLibros.Items(indice).SubItems.Add(rd(7))
            lstLibros.Items(indice).SubItems.Add(rd(8))
            indice += 1
        End While
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim precioventa As String
        Dim precioalq As String
        Dim ppv As String
        Dim ppav As String

        Me.TopMost = False
        precioventa = InputBox("Ingrese nuevo Precio de Venta", "Modificacion de Libros", lstLibros.FocusedItem.SubItems(5).Text)
        If Not Trim(precioventa) = "" Then
            precioalq = InputBox("Ingrese nuevo Precio de Alquiler", "Modificacion de Libros", lstLibros.FocusedItem.SubItems(6).Text)
            If Not Trim(precioalq) = "" Then
                ppv = InputBox("Ingrese nuevo Punto de Pedido para Venta", "Modificacion de Libros", lstLibros.FocusedItem.SubItems(7).Text)
                If Not Trim(ppv) = "" Then
                    ppav = InputBox("Ingrese nuevo Punto de Pedido para Alquiler", "Modificacion de Libros", lstLibros.FocusedItem.SubItems(8).Text)
                    If Not Trim(ppav) = "" Then
                        Consulta("UPDATE Libros SET PrecioVenta = " & Val(precioventa) & ", PrecioAlquiler = " & Val(precioalq) & ", PuntoPedido = " & Val(ppv) & ", PuntoPedidoAlquiler = " & Val(ppav) & " WHERE CodLibro = " & Val(lstLibros.FocusedItem.Text))
                        lstLibros.FocusedItem.SubItems(5).Text = precioventa
                        lstLibros.FocusedItem.SubItems(6).Text = precioalq
                        lstLibros.FocusedItem.SubItems(7).Text = ppv
                        lstLibros.FocusedItem.SubItems(8).Text = ppav
                        MsgBox("Libro Modificado Correctamente", MsgBoxStyle.OkOnly, "Aviso")
                    End If
                End If
            End If
        End If

        Me.TopMost = True
    End Sub

    Private Sub lstLibros_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstLibros.SelectedIndexChanged
        btnModificar.Enabled = True
        btnEjemplar.Enabled = True
        codLibro = Val(lstLibros.FocusedItem.Text)
    End Sub

    Private Sub btnEjemplar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjemplar.Click
        Me.Close()
        LibrosEjemplaresMod.Show()
    End Sub
End Class
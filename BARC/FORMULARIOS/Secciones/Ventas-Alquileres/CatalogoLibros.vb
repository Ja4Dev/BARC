Public Class CatalogoLibros
    Dim indice As Integer
    Dim index As Integer
    Dim ejemplares As Integer
    Dim bandera As Boolean
    Dim cantidadLibros As Integer
    Dim i As Integer
    Dim cantidadnuevo As Integer

    Private Sub CatalogoLibros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Ventas-Alquileres - Sesion iniciada como : " & user
        If operacion = False Then ' si es una compra
            Consulta("select l.CodLibro, titulo, nombre, apellido, NombreEditorial, count(*), PrecioVenta from Libros l, autores a, libroautor la, ejemplares e, editoriales ed where la.codlibro = l.codlibro and la.codautor = a.codautor and e.codlibro = l.codlibro and e.Vendido = 0 AND e.Alquiler = 0 AND e.Deteriorado = 0 and l.editorial = ed.CodEditorial group by (e.codlibro)")
        Else ' si es un alquiler
            Consulta("select l.CodLibro, titulo, nombre, apellido, NombreEditorial, count(*), PrecioAlquiler from Libros l, autores a, libroautor la, ejemplares e, editoriales ed where la.codlibro = l.codlibro and la.codautor = a.codautor and e.codlibro = l.codlibro and e.Prestado = 0 AND e.Alquiler = 1 AND e.Deteriorado = 0 and l.editorial = ed.CodEditorial group by (e.codlibro)")
        End If

        While rd.Read()

            lstLibros.Items.Add(rd(0))
            lstLibros.Items(indice).SubItems.Add(rd(1))
            lstLibros.Items(indice).SubItems.Add(rd(2) & " " & rd(3))
            lstLibros.Items(indice).SubItems.Add(rd(4))
            lstLibros.Items(indice).SubItems.Add(rd(5))
            lstLibros.Items(indice).SubItems.Add(rd(6))

            indice = indice + 1
            cantidadLibros = cantidadLibros + 1

        End While

        If nuevo = True Then
            MsgBox("Debido a ser un socio nuevo DEBE comprar o alquilar dos libros como minimo.", MsgBoxStyle.Information, "Nuevo Socio")
        End If

        indice = 0
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        VentasAlquileres.Show()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If operacion = False Then ' si es una compra
            Consulta("select l.CodLibro, titulo, nombre, apellido, NombreEditorial, PrecioVenta from Libros l, autores a, libroautor la, ejemplares e, Editoriales ed where la.codlibro = l.codlibro and la.codautor = a.codautor and e.codlibro = l.codlibro and l.codlibro = " & lstLibros.Items(index).Text & " and e.Vendido = 0 AND e.Alquiler = 0 AND e.Deteriorado = 0 and l.editorial = ed.CodEditorial limit 1")
        Else ' si es un alquiler
            Consulta("select l.CodLibro, titulo, nombre, apellido, NombreEditorial, PrecioAlquiler from Libros l, autores a, libroautor la, ejemplares e, Editoriales ed where la.codlibro = l.codlibro and la.codautor = a.codautor and e.codlibro = l.codlibro and l.codlibro = " & lstLibros.Items(index).Text & " and e.Prestado = 0 AND e.Alquiler = 1 AND e.Deteriorado = 0 and l.editorial = ed.CodEditorial limit 1")
        End If
        rd.Read()

        ejemplares = Val(lstLibros.Items(index).SubItems(4).Text) - 1
        If ejemplares < 0 Then
            MsgBox("No quedan mas ejemplares para vender", MsgBoxStyle.Information, "Catalogo de Libros")
            ejemplares = ejemplares + 1
        Else
            For Each item In lstCompra.Items
                If item.Text = lstLibros.Items(index).Text Then
                    item.Subitems(4).Text = Val(item.Subitems(4).Text) + 1
                    bandera = True
                End If
            Next item
            If bandera = False Then
                indice = lstCompra.Items.Count
                lstCompra.Items.Add(rd(0))
                lstCompra.Items(indice).SubItems.Add(rd(1))
                lstCompra.Items(indice).SubItems.Add(rd(2) & " " & rd(3))
                lstCompra.Items(indice).SubItems.Add(rd(4))
                lstCompra.Items(indice).SubItems.Add(1)
                lstCompra.Items(indice).SubItems.Add(rd(5))
            End If
            lstLibros.Items(index).SubItems(4).Text = Val(lstLibros.Items(index).SubItems(4).Text) - 1
            bandera = False
        End If

        btnSiguiente.Enabled = True
    End Sub

    Private Sub lstLibros_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstLibros.SelectedIndexChanged
        index = lstLibros.FocusedItem.Index

        btnAgregar.Enabled = True
        btnQuitar.Enabled = False
    End Sub

    Private Sub lstCompra_ColumnWidthChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangingEventArgs) Handles lstCompra.ColumnWidthChanging

        e.Cancel = True
        e.NewWidth = lstCompra.Columns(e.ColumnIndex).Width

    End Sub

    Private Sub lstLibros_ColumnWidthChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangingEventArgs) Handles lstLibros.ColumnWidthChanging

        e.Cancel = True
        e.NewWidth = lstLibros.Columns(e.ColumnIndex).Width

    End Sub

    Private Sub lstCompra_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCompra.SelectedIndexChanged
        index = lstCompra.FocusedItem.Index

        btnAgregar.Enabled = False
        btnQuitar.Enabled = True
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Dim cantlibros As Integer

        cantlibros = Val(lstCompra.FocusedItem.SubItems(4).Text)
        For Each item In lstLibros.Items
            If item.Text = lstCompra.FocusedItem.Text Then
                item.Subitems(4).Text = Val(item.Subitems(4).Text) + cantlibros
            End If
        Next item
        lstCompra.FocusedItem.Remove()
    End Sub

    Private Sub btnSiguiente_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        If nuevo = True Then
            cantidadnuevo = 0
            For Each item In lstCompra.Items
                cantidadnuevo = cantidadnuevo + Val(item.subitems(4).text)
            Next item
            If cantidadnuevo >= 2 Then
                i = 0
                For Each item In lstCompra.Items
                    Facturacion.lstCompra.Items.Add(Val(item.Text))
                    Facturacion.lstCompra.Items(i).SubItems.Add(item.SubItems(1).Text)
                    Facturacion.lstCompra.Items(i).SubItems.Add(item.SubItems(2).Text)
                    Facturacion.lstCompra.Items(i).SubItems.Add(item.SubItems(3).Text)
                    Facturacion.lstCompra.Items(i).SubItems.Add(Val(item.SubItems(4).Text))
                    Facturacion.lstCompra.Items(i).SubItems.Add(Val(item.SubItems(5).Text))
                    i = i + 1
                Next item
                i = 0
                total = 0
                For Each item In Facturacion.lstCompra.Items
                    total = total + (Val(item.SubItems(4).Text) * Val(item.SubItems(5).Text))
                Next item
                Facturacion.lblTotal.Text = "Importe Total: " & total
                Facturacion.lblTotalSem.Text = "Importe Semanal :" & total
                totalsem = total
                Me.Hide()
                Facturacion.Show()
            Else
                MsgBox("Debe Comprar/Alquilar 2 Libros como Mínimo.")
            End If
        Else
            i = 0
            For Each item In lstCompra.Items
                Facturacion.lstCompra.Items.Add(Val(item.Text))
                Facturacion.lstCompra.Items(i).SubItems.Add(item.SubItems(1).Text)
                Facturacion.lstCompra.Items(i).SubItems.Add(item.SubItems(2).Text)
                Facturacion.lstCompra.Items(i).SubItems.Add(item.SubItems(3).Text)
                Facturacion.lstCompra.Items(i).SubItems.Add(Val(item.SubItems(4).Text))
                Facturacion.lstCompra.Items(i).SubItems.Add(Val(item.SubItems(5).Text))
                i = i + 1
            Next item
            i = 0
            total = 0
            For Each item In Facturacion.lstCompra.Items
                total = total + (Val(item.SubItems(4).Text) * Val(item.SubItems(5).Text))
            Next item
            Facturacion.lblTotal.Text = "Importe Total: " & total
            Facturacion.lblTotalSem.Text = "Importe Semanal :" & total
            totalsem = total

            Me.Hide()
            Facturacion.Show()
        End If

    End Sub
End Class
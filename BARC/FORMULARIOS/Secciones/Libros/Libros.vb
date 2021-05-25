Public Class Libros

    Dim indice As Integer
    Dim codigolibro As Integer
    Dim first As Boolean

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub CatalogoLibros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = "Libros - Sesion iniciada como : " & user

        Consulta("select l.CodLibro, titulo, nombre, apellido, isbn, NombreEditorial, f_publicacion, PrecioVenta, PrecioAlquiler from Libros l, autores a, libroautor la, ejemplares e, editoriales ed where la.codlibro = l.codlibro and la.codautor = a.codautor and e.codlibro = l.codlibro and l.Editorial = ed.CodEditorial group by (e.codlibro)")

        While rd.Read()

            lstLibros.Items.Add(rd(0))
            lstLibros.Items(indice).SubItems.Add(rd(1))
            lstLibros.Items(indice).SubItems.Add(rd(2) & " " & rd(3))

            indice = indice + 1

        End While

        If user = "administracion" Then
            btnSolitudes.Visible = True
            btnVerComprobantes.Visible = True
            btnNotaPedido.Visible = True
        ElseIf user = "root" Then
            btnSolitudes.Visible = True
            btnSolicitar.Visible = True
            btnActualizar.Visible = True
            btnEjemplares.Visible = True
            btnVerComprobantes.Visible = True
            btnNotaPedido.Visible = True
        ElseIf user = "libros" Then
            btnSolicitar.Visible = True
            btnActualizar.Visible = True
            btnEjemplares.Visible = True
            btnVerComprobantes.Visible = True
        End If

    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Me.Close()
        ActualizarLibros.Show()
    End Sub

    Private Sub btnSolicitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSolicitar.Click
        Me.Close()
        SolicitarCompra.Show()
    End Sub

    Private Sub btnSolitudes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSolitudes.Click
        Me.Close()
        SolicitudesEspera.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjemplares.Click
        ' que muestre lista con isbn, nombre, pp venta, pp alquiler, estado(alcanzado, en existencia), boton para generar el pedido automaticamente (acceso Libros)
        Me.Close()
        VerEjemplares.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerComprobantes.Click
        ' ver e imprimir comprobantes de entrada ()
        Me.Close()
        VerCompEntrada.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotaPedido.Click
        Me.Close()
        VerNotaPedidos.Show()
    End Sub

    Private Sub lstLibros_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstLibros.SelectedIndexChanged

        If first = False Then
            first = True
            lblSelect.Visible = False

            lblISBN.Visible = True
            lblEditorial.Visible = True
            lblFechaPublicacion.Visible = True
            lblPrecioVenta.Visible = True
            lblPrecioAlquiler.Visible = True

        End If

        Consulta("select isbn, NombreEditorial, f_publicacion, PrecioVenta, PrecioAlquiler from Libros l, autores a, libroautor la, ejemplares e, editoriales ed where la.codlibro = l.codlibro and la.codautor = a.codautor and e.codlibro = l.codlibro and l.Editorial = ed.CodEditorial and l.codlibro = " & lstLibros.FocusedItem.Text & "")
        rd.Read()

        lblISBN.Text = "ISBN : " & rd(0)
        lblEditorial.Text = "Editorial : " & rd(1)
        lblFechaPublicacion.Text = "Año de publicacion : " & rd(2)
        lblPrecioVenta.Text = "Precio de Venta : " & rd(3)
        lblPrecioAlquiler.Text = "Precio de Alquiler :" & rd(4)

    End Sub

    Private Sub Libros_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        first = False
        lblSelect.Visible = True

        lblISBN.Visible = False
        lblEditorial.Visible = False
        lblFechaPublicacion.Visible = False
        lblPrecioVenta.Visible = False
        lblPrecioAlquiler.Visible = False

    End Sub

End Class
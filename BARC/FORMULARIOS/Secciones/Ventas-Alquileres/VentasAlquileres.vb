Public Class VentasAlquileres

    Private Sub btnSocioBusc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSocioBusc.Click
        formulario = "modulo_compras"
        Buscar.Show()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

        If nuevo = True Then

            answer = MsgBox("¿Desea cancelar el alta del nuevo socio?", MsgBoxStyle.YesNo)

            If answer = 6 Then
                Consulta("delete from nuevos where dni = " & dni & "")
                nuevo = False
                Me.Close()
                Main.Show()
            End If

        Else
            Me.Close()
            Main.Show()
        End If
            
    End Sub

    Private Sub btnComprar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComprar.Click
        CatalogoLibros.lblCatalogo.Text = "Catalogo de Libros | Compra"
        Facturacion.lblFacturacion.Text = "Compra de Libros"
        operacion = False
        CatalogoLibros.Show()
        Me.Hide()
    End Sub

    Private Sub btnAlquilar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlquilar.Click
        CatalogoLibros.lblCatalogo.Text = "Catalogo de Libros | Alquiler"
        Facturacion.lblFacturacion.Text = "Alquiler de Libros"
        operacion = True
        Facturacion.lblcantsemanasalq.Visible = True
        Facturacion.numCantSemanas.Visible = True
        CatalogoLibros.Precio.Text = "Precio por Semana"
        CatalogoLibros.libroPrecio.Text = "Precio por Semana"
        CatalogoLibros.Show()
        Me.Hide()
    End Sub

    Private Sub btnNuevoSocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoSocio.Click
        formulario = "modulo_compras"
        Me.Hide()
        altaSocios.Show()
    End Sub

    Private Sub VentasAlquileres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Ventas-Alquileres - Sesion iniciada como : " & user
    End Sub
End Class
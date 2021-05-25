Public Class Socios

    Dim indice As Integer

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDatos.Click

        Consulta("select * from socios where codsocio = " & lstSocios.Items(indice).Text & "")
        codsoc = lstSocios.Items(indice).Text
        rd.Read()

        DataSocios.lblDataCodSoc.Text = rd(0)
        DataSocios.lblDataDNI.Text = rd(1)
        DataSocios.lblDataNombre.Text = rd(2)
        DataSocios.lblDataApellido.Text = rd(3)
        DataSocios.lblDataDomicilio.Text = rd(4)
        DataSocios.lblDataLocalidad.Text = rd(5)
        DataSocios.lblDataTelefono.Text = rd(6)
        estado_socio = rd(7)
        DataSocios.lblDataEstado.Text = rd(7)

        nomsocio = rd(2) & " " & rd(3)

        If rd(7) = "Al dia" Then
            SocioBaja = False
        ElseIf rd(7) = "Baja" Then
            SocioBaja = True
        End If
        Me.Close()
        DataSocios.Show()

    End Sub

    Private Sub Socios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Socios - Sesion iniciada como : " & user

        If user = "administracion" Then
            btnAlta.Enabled = False
        End If

        Consulta("select CodSocio, Nombre, Apellido, Estado, DNI from socios")

        While rd.Read()

            lstSocios.Items.Add(rd(0))
            lstSocios.Items(indice).SubItems.Add(rd(1))
            lstSocios.Items(indice).SubItems.Add(rd(2))
            lstSocios.Items(indice).SubItems.Add(rd(3))

            If IsDBNull(rd(4)) Then
                lstSocios.Items(indice).SubItems.Add(" ")
            Else
                lstSocios.Items(indice).SubItems.Add(rd(4))
            End If

            indice = indice + 1

        End While

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        formulario = "modulo_socios"
        Buscar.Show()

    End Sub

    Private Sub lstSocios_ColumnWidthChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangingEventArgs) Handles lstSocios.ColumnWidthChanging

        e.Cancel = True
        e.NewWidth = lstSocios.Columns(e.ColumnIndex).Width

    End Sub

    Private Sub lstSocios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSocios.SelectedIndexChanged

        btnDatos.Enabled = True

        indice = lstSocios.FocusedItem.Index

    End Sub

    Private Sub btnAlta_Click(sender As System.Object, e As System.EventArgs) Handles btnAlta.Click
        Me.Close()
        altaSocios.Show()
    End Sub
End Class
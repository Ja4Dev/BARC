Public Class altaSocios

    Dim actualizar As Boolean
    Dim idclientenuevo As Integer

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        If formulario = "modulo_compras" Then
            formulario = ""
            Me.Close()
            VentasAlquileres.Show()
        Else
            Me.Close()
            Socios.Show()
        End If
    End Sub

    Private Sub btnAlta_Click(sender As System.Object, e As System.EventArgs) Handles btnAlta.Click
        answer = MsgBox("¿Confirma que los datos ingresados son correctos?", MsgBoxStyle.YesNo)

        If answer = 6 Then

            If actualizar = True Then

                Consulta("select codsocio from socios where DNI = '" & txtDNI.Text & "'")
                rd.Read()

                codsoc = rd(0)

                Consulta("update socios set dni = '" & txtDNI.Text & "', nombre = '" & txtNombre.Text & "', apellido = '" & txtApellido.Text & "', direccion = '" & txtDireccion.Text & "', localidad = '" & txtLocalidad.Text & "', tel = '" & txtTelefono.Text & "', estado = 'Al dia' where codsocio = " & rd(0) & "")
                MsgBox("Datos del Socio Actualizados Correctamente", MsgBoxStyle.OkOnly)
                Me.Close()
                Socios.Show()
            Else
                Consulta("SELECT MAX(CodSocio)+1 From Socios")
                rd.Read()
                idclientenuevo = rd(0)
                Consulta("insert into nuevos values(" & idclientenuevo & ",'" & txtDNI.Text & "','" & txtNombre.Text & "','" & txtApellido.Text & "','" & txtDireccion.Text & "','" & txtLocalidad.Text & "','" & txtTelefono.Text & "')")
                nuevo = True
                'se abre formulario ventas


                Consulta("select codsocio, DNI, nombre, apellido from nuevos where DNI = " & txtDNI.Text & "") ' buscamos datos
                rd.Read()
                codsoc = rd(0) ' guardamos el codigo del socio para operar y cargamos los datos en pantalla
                VentasAlquileres.lblCodsoc.Text = "CodSoc : " & rd(0)
                VentasAlquileres.lblDNI.Text = "DNI : " & rd(1)
                dni = rd(1)
                VentasAlquileres.lblNombre.Text = "Nombre : " & rd(2)
                VentasAlquileres.lblApellido.Text = "Apellido : " & rd(3)
                VentasAlquileres.btnAlquilar.Enabled = True
                VentasAlquileres.btnComprar.Enabled = True
                VentasAlquileres.btnNuevoSocio.Enabled = False
                nuevo = True

                Me.Close()
                VentasAlquileres.Show()
            End If

        End If

    End Sub

    Private Sub btnValidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValidar.Click

        If Trim(txtDNI.Text) = "" Then

            MsgBox("Debe ingresar un dato en el campo DNI", MsgBoxStyle.Information, "Alta de Socio")

        Else

            Consulta("select count(*) from socios where DNI = '" & txtDNI.Text & "'")
            rd.Read()

            If rd(0) = 1 Then
                MsgBox("El socio ya existe en la base de datos", MsgBoxStyle.Information, "Alta de Socio")

                answer = MsgBox("¿Desea modificar los datos del socio?", MsgBoxStyle.YesNo, "Alta de Socio")

                If answer = 6 Then

                    txtDNI.Enabled = False
                    actualizar = True

                    btnAlta.Visible = True
                    btnValidar.Visible = False
                    btnVolver.Visible = False

                    txtNombre.Enabled = True
                    txtApellido.Enabled = True
                    txtDireccion.Enabled = True
                    txtLocalidad.Enabled = True
                    txtTelefono.Enabled = True

                    lblNombre.Enabled = True
                    lblApellido.Enabled = True
                    lblDireccion.Enabled = True
                    lblLocalidad.Enabled = True
                    lblTelefono.Enabled = True

                    Consulta("select Nombre, Apellido, Direccion, Localidad, Tel, codsocio from socios where DNI = '" & txtDNI.Text & "'")
                    rd.Read()

                    txtNombre.Text = rd(0)
                    txtApellido.Text = rd(1)
                    txtDireccion.Text = rd(2)
                    txtLocalidad.Text = rd(3)
                    txtTelefono.Text = rd(4)

                Else

                    Consulta("update socios set estado='Al dia' where DNI = '" & txtDNI.Text & "'")

                    Consulta("select Nombre, Apellido, Direccion, Localidad, Tel from socios where DNI = '" & txtDNI.Text & "'")
                    rd.Read()

                    lblDNI.Enabled = False
                    txtDNI.Enabled = False

                    txtNombre.Text = rd(0)
                    txtApellido.Text = rd(1)
                    txtDireccion.Text = rd(2)
                    txtLocalidad.Text = rd(3)
                    txtTelefono.Text = rd(4)

                    btnAlta.Visible = False
                    btnValidar.Visible = False
                    btnVolver.Visible = True


                End If

            Else

                MsgBox("El socio no existe, proceda a ingresar sus datos.", MsgBoxStyle.Information, "Alta de Socio")

                btnAlta.Visible = True
                btnValidar.Visible = False
                btnVolver.Visible = False

                txtNombre.Enabled = True
                txtApellido.Enabled = True
                txtDireccion.Enabled = True
                txtLocalidad.Enabled = True
                txtTelefono.Enabled = True

                lblNombre.Enabled = True
                lblApellido.Enabled = True
                lblDireccion.Enabled = True
                lblLocalidad.Enabled = True
                lblTelefono.Enabled = True
            End If

        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        Socios.Show()
    End Sub

    Private Sub txtDNI_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDNI.TextChanged
        btnAlta.Visible = False
        btnValidar.Visible = True
        btnVolver.Visible = False
    End Sub
End Class
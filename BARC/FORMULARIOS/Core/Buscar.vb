Public Class Buscar

    Dim mensaje As Integer

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        If Trim(txtSocio.Text) = "" Then ' no ingresa algo en blanco
            MsgBox("Debe ingresar un dato en el campo de texto.")
            txtSocio.Focus()
        Else
            If formulario = "modulo_socios" Then 'dependiendo del formulario del que venga va a hacer una u otra cosa
                If rdbDNI.Checked = True Then ' si es la busqueda desde socios es para mostrar la informacion

                    Consulta("select * from socios where dni = '" & txtSocio.Text & "'") ' si ingresa por dni buscamos que exista
                    If rd.Read() Then
                        codsoc = rd(0)
                        DataSocios.lblDataCodSoc.Text = rd(0) ' imprimir datos del socio en panbtalla
                        DataSocios.lblDataDNI.Text = rd(1)
                        DataSocios.lblDataNombre.Text = rd(2)
                        DataSocios.lblDataApellido.Text = rd(3)
                        DataSocios.lblDataDomicilio.Text = rd(4)
                        DataSocios.lblDataLocalidad.Text = rd(5)
                        DataSocios.lblDataTelefono.Text = rd(6)
                        DataSocios.lblDataEstado.Text = rd(7)

                        Me.Close()
                        Socios.Close()
                        DataSocios.Show()
                    Else
                        MsgBox("El socio buscado no existe", MsgBoxStyle.Information, "Buscar Socio")
                        txtSocio.Clear()
                        txtSocio.Focus()
                    End If

                Else
                    ' si buscamos por codigo de socio
                    Consulta("select * from socios where CodSocio = " & Val(txtSocio.Text))
                    If rd.Read() Then
                        codsoc = rd(0)
                        DataSocios.lblDataCodSoc.Text = rd(0) ' imprimir datos del socio en panbtalla
                        DataSocios.lblDataDNI.Text = rd(1)
                        DataSocios.lblDataNombre.Text = rd(2)
                        DataSocios.lblDataApellido.Text = rd(3)
                        DataSocios.lblDataDomicilio.Text = rd(4)
                        DataSocios.lblDataLocalidad.Text = rd(5)
                        DataSocios.lblDataTelefono.Text = rd(6)
                        DataSocios.lblDataEstado.Text = rd(7)

                        Me.Close()
                        Socios.Close()
                        DataSocios.Show()

                    Else
                        MsgBox("El socio buscado no existe", MsgBoxStyle.Information, "Buscar Socio")
                        txtSocio.Clear()
                        txtSocio.Focus()
                    End If

                End If





            ElseIf formulario = "modulo_compras" Then ' buscar socio para realizar una compra

                If rdbDNI.Checked = True Then ' buscarlo por dni
                    Consulta("select * from socios where DNI = '" & txtSocio.Text & "'")
                    If rd.Read() Then
                        If rd(7) = "Al dia" Then ' si el socio esta al dia
                            codsoc = rd(0) ' guardamos el codigo del socio para operar y cargamos los datos en pantalla
                            VentasAlquileres.lblCodsoc.Text = "CodSoc : " & rd(0)
                            VentasAlquileres.lblDNI.Text = "DNI : " & rd(1)
                            VentasAlquileres.lblNombre.Text = "Nombre : " & rd(2)
                            VentasAlquileres.lblApellido.Text = "Apellido : " & rd(3)
                            VentasAlquileres.btnAlquilar.Enabled = True
                            VentasAlquileres.btnComprar.Enabled = True
                            Me.Close()
                        ElseIf rd(7) = "Nuevo" Then
                            MsgBox("A continuacion se realizara la compra/alquiler obligatoria debido a ser nuevo el socio.", MsgBoxStyle.Information)
                        Else
                            ' no esta al dia no puede hacer nada
                            MsgBox("El socio no se encuentra al día y no puede realizar esta operación. Su estado es: " & rd(7), MsgBoxStyle.Information, "Buscar Socio")
                            Me.Close()
                        End If

                    Else ' no existe
                        mensaje = MsgBox("El socio buscado no existe, desea cargarlo?", MsgBoxStyle.YesNo, "Buscar Socio")
                        txtSocio.Clear()
                        txtSocio.Focus()
                        If mensaje = 6 Then
                            Me.Close()
                            VentasAlquileres.Close()
                            altaSocios.Show()
                        Else
                            Me.Close()
                        End If
                    End If

                Else ' buscarlo por codigo

                    Consulta("select * from socios where CodSocio = " & Val(txtSocio.Text))
                    If rd.Read Then ' si existe
                        If rd(7) = "Al dia" Then ' si el socio esta al dia
                            codsoc = txtSocio.Text ' guardamos el codigo del socio para operar
                            VentasAlquileres.lblCodsoc.Text = "CodSoc : " & rd(0) ' cargamos datos
                            VentasAlquileres.lblDNI.Text = "DNI : " & rd(1)
                            VentasAlquileres.lblNombre.Text = "Nombre : " & rd(2)
                            VentasAlquileres.lblApellido.Text = "Apellido : " & rd(3)
                            VentasAlquileres.btnAlquilar.Enabled = True
                            VentasAlquileres.btnComprar.Enabled = True
                            Me.Close()
                        Else ' no esta al dia
                            MsgBox("El socio no se encuentra al día y no puede realizar esta operación. Su estado es: " & rd(7), MsgBoxStyle.Information, "Buscar Socio")
                            Me.Close()
                        End If

                    Else ' el socio no existe
                        mensaje = MsgBox("El socio buscado no existe, desea cargarlo?", MsgBoxStyle.YesNo, "Buscar Socio")
                        txtSocio.Clear()
                        txtSocio.Focus()
                        If mensaje = 6 Then
                            altaSocios.Show()
                            Me.Close()
                            VentasAlquileres.Close()
                        Else
                            Me.Close()
                        End If
                    End If
                End If

            ElseIf formulario = "modulo_cobros_busq" Then
                formulario = "modulo_cobros"
                If rdbDNI.Checked = True Then ' si es la busqueda desde socios es para mostrar la informacion

                    Consulta("select * from socios where DNI = '" & txtSocio.Text & "'") ' si ingresa por dni buscamos que exista
                    If rd.Read() Then 'si existe
                        codsoc = rd(0)
                        nomsocio = rd(2) & " " & rd(3)
                        ComprasSocio.Show()
                        Me.Close()
                    Else
                        formulario = "modulo_cobros_busq"
                        mensaje = MsgBox("El socio buscado no existe.", MsgBoxStyle.OkOnly, "Buscar Socio")
                        txtSocio.Clear()
                        txtSocio.Focus()
                    End If
                Else
                    Consulta("select * from socios where CodSocio = " & Val(txtSocio.Text))
                    If rd.Read() Then ' si existe
                        codsoc = Val(txtSocio.Text)
                        nomsocio = rd(2) & " " & rd(3)
                        ComprasSocio.Show()
                        txtSocio.Clear()
                        Me.Close()
                    Else
                        formulario = "modulo_cobros_busq"
                        mensaje = MsgBox("El socio buscado no existe.", MsgBoxStyle.OkOnly, "Buscar Socio")
                        txtSocio.Clear()
                        txtSocio.Focus()
                    End If
                End If
            End If
        End If

        txtSocio.Clear()

    End Sub

    Private Sub rdbDNI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbDNI.CheckedChanged

        If rdbDNI.Checked = True Then
            rdbCodSoc.Checked = False
            rdbDNI.Checked = True

            txtSocio.MaxLength = 8
            txtSocio.Clear()
        End If

    End Sub

    Private Sub rdbCodSoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCodSoc.CheckedChanged

        If rdbCodSoc.Checked = True Then
            rdbDNI.Checked = False
            rdbCodSoc.Checked = True

            txtSocio.MaxLength = 5
            txtSocio.Clear()
        End If

    End Sub

    Private Sub Buscar_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Text = "Buscar socio"
    End Sub

    Private Sub Buscar_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If formulario = "modulo_cobros_busq" Then
            Main.Show()
        End If
    End Sub

    Private Sub Buscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSocio.Focus()
    End Sub

    Private Sub txtSocio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSocio.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
Public Class Login

    Dim i As Integer
    Dim answ As Integer

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Consulta("select count(*) from Usuarios where Usuario = '" & txtUser.Text & "'")
        rd.Read()

        If rd(0) = 1 Then

            user = txtUser.Text.ToLower

            Consulta("select count(*) from Usuarios where Password = '" & txtPassword.Text & "' and Usuario = '" & user & "'")
            rd.Read()

            If rd(0) = 1 Then

                MsgBox("Se ha conectado correctamente como " & user & ".")

                txtUser.Clear()
                txtPassword.Clear()
                Me.Close()
                Main.Show()

            Else

                If Trim(txtPassword.Text) = "" Then

                    MsgBox("Escriba una contraseña.")
                    txtPassword.Clear()
                    txtPassword.Focus()

                Else

                    MsgBox("Contraseña incorrecta, Ingresela nuevamente.")
                    txtPassword.Clear()
                    txtPassword.Focus()

                End If

            End If

        Else

            If Trim(txtUser.Text) = "" Then

                MsgBox("Escriba un nombre de usuario.")
                txtUser.Clear()
                txtUser.Focus()

            Else

                MsgBox("Usuario incorrecto, Ingreselo nuevamente.")
                txtUser.Clear()
                txtPassword.Clear()
                txtUser.Focus()

            End If

        End If

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        answ = MsgBox("¿Esta seguro de que desea salir del sistema?", MsgBoxStyle.YesNo)

        If answ = 6 Then

            Me.Close()
            splash.Close()

        End If

    End Sub

End Class

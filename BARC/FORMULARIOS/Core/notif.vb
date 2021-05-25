Public Class notif

    Public xTick As Integer = 0
    Dim i As Integer
    Dim Aux As Integer

    Private Sub notif_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        NotificacionActiva = True
        Me.Width = lblMensaje.Width + 150

        Aux = Math.Round((Me.Width / 10), 2)
        Aux = Aux * 10
        Me.Width = Aux

        Me.Location = New Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - (Me.Height + 40))

        i = splash.lstNotif.Items.Count
        splash.lstNotif.Items.Add(tipoNotif)
        splash.lstNotif.Items(i).SubItems.Add(lblMensaje.Text)

        notifCont += 1

    End Sub

    Private Sub slideIn_Tick(sender As System.Object, e As System.EventArgs) Handles slideIn.Tick

        If Me.Opacity = 0 Then
            Me.Close()
            NotificacionActiva = False
            VerNotificaciones()
        End If

        If Not Me.Location.X = Screen.PrimaryScreen.WorkingArea.Width - (Me.Width + 40) Then
            Me.Location = New Point(Me.Location.X - 10, Me.Location.Y)
        End If

        If xTick = 3000 Then
            Me.Opacity -= 0.02
        End If
        If Not xTick = 3000 Then xTick += 1


    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        While Me.Opacity <> 0

            Me.Opacity -= 0.1

            Me.Refresh()

            Threading.Thread.Sleep(2)

        End While

        Me.Close()

        NotificacionActiva = False
        notifCont -= 1
        VerNotificaciones()
    End Sub

End Class
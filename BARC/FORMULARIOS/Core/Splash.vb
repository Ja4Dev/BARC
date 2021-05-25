Public Class splash

    Dim notifVisible As Boolean
    Dim calenVisible As Boolean

    Private Sub splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Conectar("DSN=BARC")

        If failed = True Then
            MsgBox("Se cerrará el sistema a continuacion.")
            Me.Close()
        Else
            Consulta("delete from nuevos") ' Vaciar la tabla de nuevos clientes en caso de no haber sido cargados anteriormen

            Application.CurrentCulture = New System.Globalization.CultureInfo("EN-US")

            user = "root"
            Main.Show()
        End If

    End Sub

    Private Sub btnNotifClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotifClear.Click
        lstNotif.Clear()
    End Sub

    Private Sub btnNotif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotif.Click

        If notifVisible = False Then
            gbxNotif.Visible = True
            notifVisible = True
        Else
            gbxNotif.Visible = False
            notifVisible = False
        End If

    End Sub

    Private Sub lblClock_Click_(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClock.Click

        If calenVisible = False Then
            gbxCalendar.Visible = True
            calenVisible = True
        Else
            gbxCalendar.Visible = False
            calenVisible = False
        End If

    End Sub

    Private Sub tmrClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrClock.Tick

        lblClock.Text = "Fecha : " & Format(Now, "dddd dd ") & "de" & Format(Now, " MMMM, yyyy") & " / Hora : " & Format(Now, "HH:mm:ss")

    End Sub

    Private Sub pbxBARC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxBARC.Click
        gbxCalendar.Visible = False
        gbxNotif.Visible = False
        calenVisible = False
        notifVisible = False
    End Sub

End Class

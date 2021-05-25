Public Class Notif_SolicitudesCompras
    Dim x As Integer = 0

    Private Sub Notif_SolicitudesCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(Screen.PrimaryScreen.Bounds.Width - 380, Screen.PrimaryScreen.Bounds.Height)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Opacity = 0 Then
            Me.Close()
        End If
        If x = 200 Then
            Me.Opacity -= 0.02
        End If

        If Not Me.Location.Y = Screen.PrimaryScreen.WorkingArea.Height - 50 Then
            Me.Location = New Point(Me.Location.X, Me.Location.Y - 2)
        End If

        If Not x = 200 Then
            x = x + 1
        End If
    End Sub
End Class
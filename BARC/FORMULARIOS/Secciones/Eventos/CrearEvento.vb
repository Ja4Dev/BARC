Public Class CrearEvento
    Dim ans As Integer
    Dim i As Integer

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmEventos.Show()
    End Sub

    Private Sub btnCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrear.Click
        ans = MsgBox("¿Confirma que desea crear este evento?", MsgBoxStyle.YesNo, "Atencion")
        If ans = 6 Then
            If Trim(txtNombre.Text) = "" Or Trim(txtMotivo.Text) = "" Or Trim(txtDescripcion.Text) = "" Then
                MsgBox("Ingrese Valores Validos.", MsgBoxStyle.OkOnly, "Atencion")
            Else
                Consulta("INSERT INTO Eventos VALUES ('', '" & txtNombre.Text & "', '" & txtDescripcion.Text & "', '" & Format(dtpFecha.Value, "yyyyMMdd") & "', '" & txtMotivo.Text & "')")
                MsgBox("Evento Creado Exitosamente.", MsgBoxStyle.OkCancel, "Aviso")
                Me.Close()
                EventosLista.Show()
            End If
        End If
    End Sub

    Private Sub txtNombre_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        i += 1
        If i = 3 Then
            btnCrear.Enabled = True
        End If
    End Sub

    Private Sub txtMotivo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMotivo.TextChanged
        i += 1
        If i = 3 Then
            btnCrear.Enabled = True
        End If
    End Sub

    Private Sub txtDescripcion_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        i += 1
        If i = 3 Then
            btnCrear.Enabled = True
        End If
    End Sub
End Class
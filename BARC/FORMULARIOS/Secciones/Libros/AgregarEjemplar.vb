Public Class AgregarEjemplar
    Dim ans As Integer

    Private Sub AgregarEjemplar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtAlquiler.Clear()
        txtVenta.Clear()
        lblTexto.Text = "Hay " & CantEjemplares & " ejemplares del Libro " & NumISBN
    End Sub


    Private Sub txtVenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVenta.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtAlquiler_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAlquiler.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtVenta_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVenta.Leave
        If Val(txtVenta.Text) > CantEjemplares Then
            txtVenta.Text = CantEjemplares
        End If
        txtAlquiler.Text = CantEjemplares - Val(txtVenta.Text)
    End Sub

    Private Sub txtAlquiler_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlquiler.Leave
        If Val(txtAlquiler.Text) > CantEjemplares Then
            txtAlquiler.Text = CantEjemplares
        End If
        txtVenta.Text = CantEjemplares - Val(txtAlquiler.Text)
    End Sub

    Private Sub btnContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click
        ans = MsgBox("¿Confirma que los datos son correctos?", MsgBoxStyle.YesNo, "Atencion")
        If ans = 6 Then
            CantEjemA = Val(txtAlquiler.Text)
            CantEjemV = Val(txtVenta.Text)
            Consulta("CALL AgreEje(" & NumISBN & ", " & CantEjemV & ", " & CantEjemA & ")")
            Me.Close()
        End If
    End Sub
End Class
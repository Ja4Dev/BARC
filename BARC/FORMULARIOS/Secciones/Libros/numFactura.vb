Public Class numFactura
    Dim ans As Integer

    Private Sub btnContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click
        ans = MsgBox("Confirma que el numero de factura es correcto?", MsgBoxStyle.YesNo, "Atencion")
        If ans = 6 Then
            NFacProv = Val(txtNum.Text)
            Me.Close()
        Else
            txtNum.Clear()
            txtNum.Focus()
        End If
    End Sub

    Private Sub txtNum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNum.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
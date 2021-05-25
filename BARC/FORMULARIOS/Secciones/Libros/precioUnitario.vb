Public Class precioUnitario
    Dim ans As Integer

    Private Sub btnContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click
        ans = MsgBox("Confirma que el precio es correcto?", MsgBoxStyle.YesNo, "Atencion")
        If ans = 6 Then
            PrecioUnit = Val(txtprecio.Text)
            Me.Close()
        Else
            txtprecio.Clear()
            txtprecio.Focus()
        End If
    End Sub

    Private Sub precioUnitario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblISBN.Text = NumISBN
        txtprecio.Clear()
    End Sub

    Private Sub txtprecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprecio.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = 46 Then
                e.Handled = False
            End If
        End If
    End Sub

End Class
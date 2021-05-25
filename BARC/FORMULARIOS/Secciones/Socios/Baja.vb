Public Class Baja
    Dim puede_baja As Integer

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        DataSocios.Show()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        formulario = "darbajasocio"
        If estado_socio = "Moroso" Or estado_socio = "Legales" Then
            MsgBox("El socio no puede ser dado de baja debido a que su estado es: " & estado_socio, MsgBoxStyle.OkOnly, "Atencion")
        ElseIf estado_socio = "Al dia" Then
            Consulta("SELECT COUNT(*) FROM COMPRAS WHERE CodSocio = " & codsoc & " AND Estado = 'Impago'")
            rd.Read()
            If rd(0) > 0 Then
                puede_baja = 0
            Else
                puede_baja += 1
            End If
            Consulta("SELECT COUNT(*) FROM Alquileres WHERE EstadoPago = 'Impago' AND CodSocio = " & codsoc)
            rd.Read()
            If rd(0) > 0 Then
                puede_baja = 0
            Else
                puede_baja += 1
            End If

            If puede_baja = 2 Then
                Consulta("update socios set estado = 'Baja' where codsocio = " & codsoc & "")
                Consulta("INSERT INTO BajasSocios VALUES ('', " & codsoc & ", CURDATE())")
                InvoiceGenerate("Constanciabaja")
            Else
                MsgBox("El Socio no Puede ser dado de baja porque tiene compras/alquileres Impagos.", MsgBoxStyle.OkOnly, "Atencion")
            End If
        End If
    End Sub

    Private Sub Baja_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        puede_baja = 0
    End Sub
End Class
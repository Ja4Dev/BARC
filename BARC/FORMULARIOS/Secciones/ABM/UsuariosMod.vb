Public Class UsuariosMod
    Dim ans As Integer
    Dim indice As Integer

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmABM.Show()
    End Sub

    Private Sub UsuariosMod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        indice = 0
        Consulta("SELECT * FROM Usuarios WHERE CodUsuario > 1")
        While rd.Read
            lstUsuario.Items.Add(rd(0))
            lstUsuario.Items(indice).SubItems.Add(rd(1))
            indice += 1
        End While
    End Sub

    Private Sub lstUsuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstUsuario.SelectedIndexChanged
        btnModificar.Enabled = True
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim contraseña As String
        Me.TopMost = False
        contraseña = InputBox("Ingrese Contraseña Actual", "Modificacion de Contraseña")
        If Not Trim(contraseña) = "" Then
            Consulta("SELECT COUNT(*) FROM Usuarios WHERE CodUsuario = " & Val(lstUsuario.FocusedItem.Text) & " AND Password = '" & Trim(contraseña) & "'")
            rd.Read()
            If rd(0) = 1 Then
                contraseña = InputBox("Ingrese nueva Contraseña.", "Modificacion de Contraseña")
                If Not Trim(contraseña) = "" Then
                    Consulta("UPDATE Usuarios SET Password = '" & Trim(contraseña) & "' WHERE CodUsuario = " & Val(lstUsuario.FocusedItem.Text))
                    MsgBox("Contraseña Actualizada Correctamente", MsgBoxStyle.OkOnly, "Aviso")
                End If
            Else
                MsgBox("Contraseña Incorrecta", MsgBoxStyle.OkOnly, "Aviso")
            End If
        End If
        Me.TopMost = True
    End Sub
End Class
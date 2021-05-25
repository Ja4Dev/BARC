Public Class CorredoresMod
    Dim indice As Integer
    Dim ans As Integer

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmABM.Show()
    End Sub

    Private Sub CorredoresMod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        indice = 0
        Consulta("SELECT * FROM Corredores WHERE Baja = 0")
        While rd.Read
            lstCorredores.Items.Add(rd(0))
            lstCorredores.Items(indice).SubItems.Add(rd(1))
            lstCorredores.Items(indice).SubItems.Add(rd(2))
            lstCorredores.Items(indice).SubItems.Add(rd(3))
            lstCorredores.Items(indice).SubItems.Add(rd(4))
            indice += 1
        End While
    End Sub

    Private Sub lstCorredores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCorredores.SelectedIndexChanged
        btnEliminar.Enabled = True
        btnModificar.Enabled = True
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        ans = MsgBox("Desea Eliminar este Corredor?", MsgBoxStyle.YesNo, "Atencion")
        If ans = 6 Then
            Consulta("DELETE FROM Corredores_Zonas WHERE CodCorredor = " & Val(lstCorredores.FocusedItem.Text))
            Consulta("UPDATE Corredores SET baja = 1 WHERE CodCorredor = " & Val(lstCorredores.FocusedItem.Text))
            lstCorredores.FocusedItem.Remove()
            MsgBox("Corredor Eliminado Correctamente", MsgBoxStyle.OkOnly, "Aviso")
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim nombre As String
        Dim apellido As String
        Dim telefono As String

        Me.TopMost = False
        nombre = InputBox("Ingrese Nuevo Nombre del Corredor", "Modificacion de Corredor", lstCorredores.FocusedItem.SubItems(2).Text)
        If Not Trim(nombre) = "" Then
            apellido = InputBox("Ingrese Nuevo Apellido del Corredor", "Modificacion de Corredor", lstCorredores.FocusedItem.SubItems(3).Text)
            If Not Trim(apellido) = "" Then
                telefono = InputBox("Ingrese Nuevo Telefono del Corredor", "Modificacion de Corredor", lstCorredores.FocusedItem.SubItems(4).Text)
                If Not Trim(telefono) = "" Then
                    Consulta("UPDATE Corredores SET nombre = '" & Trim(nombre) & "', apellido = '" & Trim(apellido) & "', tel = '" & Trim(telefono) & "' WHERE CodCorredor = " & Val(lstCorredores.FocusedItem.Text))
                    lstCorredores.FocusedItem.SubItems(2).Text = nombre
                    lstCorredores.FocusedItem.SubItems(3).Text = apellido
                    lstCorredores.FocusedItem.SubItems(4).Text = telefono
                    MsgBox("Datos del Corredor Modificados Correctamente.", MsgBoxStyle.OkOnly, "Aviso")
                End If
            End If
        End If
        Me.TopMost = True
    End Sub
End Class
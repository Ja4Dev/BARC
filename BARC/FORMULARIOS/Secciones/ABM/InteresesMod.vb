Public Class InteresesMod
    Dim ans As Integer
    Dim indice As Integer

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmABM.Show()
    End Sub

    Private Sub InteresesMod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        indice = 0
        Consulta("SELECT * FROM Intereses")
        While rd.Read
            lstInteres.Items.Add(rd(0))
            lstInteres.Items(indice).SubItems.Add(rd(1))
            lstInteres.Items(indice).SubItems.Add(rd(2))
            indice += 1
        End While
    End Sub

    Private Sub lstInteres_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstInteres.SelectedIndexChanged
        btnModificar.Enabled = True
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim porcentaje As String
        Me.TopMost = False
        porcentaje = InputBox("Ingrese el Porcentaje Nuevo (Ingrese Solo Numeros)", "Modificacion de Porcentaje", lstInteres.FocusedItem.SubItems(2).Text)
        If Not Trim(porcentaje) = "" Then
            Consulta("UPDATE Intereses SET Porcentaje = " & Val(porcentaje) & " WHERE Codinteres = " & Val(lstInteres.FocusedItem.Text))
            lstInteres.FocusedItem.SubItems(2).Text = porcentaje
            MsgBox("Porcentaje de Interes Modificado Correctamente.", MsgBoxStyle.OkOnly, "Aviso")
        End If
        Me.TopMost = True
    End Sub
End Class
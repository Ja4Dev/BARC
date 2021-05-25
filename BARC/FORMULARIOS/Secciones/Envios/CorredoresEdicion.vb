Public Class CorredoresEdicion
    Dim indice As Integer
    Dim ans As Integer

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmEnvios.Show()
    End Sub

    Private Sub CorredoresEdicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        indice = 0
        btnEliminar.Enabled = False
        Consulta("SELECT * FROM Corredores where baja = 0")
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
        codigoCorredor = Val(lstCorredores.FocusedItem.Text)
        btnEliminar.Enabled = False
        btnAgregar.Enabled = True
        lstZonas.Items.Clear()
        indice = 0
        Consulta("SELECT z.CodZona, LimS, LimN, LimE, LimO FROM Zonas z, Corredores_Zonas cz WHERE cz.Codzona = z.Codzona AND CodCorredor = " & Val(lstCorredores.FocusedItem.Text))
        While rd.Read
            lstZonas.Items.Add(rd(0))
            lstZonas.Items(indice).SubItems.Add(rd(1))
            lstZonas.Items(indice).SubItems.Add(rd(2))
            lstZonas.Items(indice).SubItems.Add(rd(3))
            lstZonas.Items(indice).SubItems.Add(rd(4))
            indice += 1
        End While
    End Sub

    Private Sub lstZonas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstZonas.SelectedIndexChanged
        btnEliminar.Enabled = True
        CodigoZona = Val(lstZonas.FocusedItem.Text)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        ans = MsgBox("Seguro que desea Eliminar esta Zona?", MsgBoxStyle.YesNo, "Atencion")
        If ans = 6 Then
            Consulta("DELETE FROM Corredores_Zonas WHERE CodZona = " & CodigoZona & " AND CodCorredor = " & codigoCorredor)
            lstZonas.FocusedItem.Remove()
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Zonas.ShowDialog()
    End Sub
End Class
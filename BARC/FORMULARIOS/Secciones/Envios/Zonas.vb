Public Class Zonas
    Dim indice As Integer
    Dim ans As Integer

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub Zonas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstZonas.Items.Clear()
        indice = 0
        Consulta("SELECT * FROM Zonas WHERE CodZona NOT IN (SELECT CodZona FROM Corredores_Zonas WHERE CodCorredor = " & codigoCorredor & ")")
        While rd.Read
            lstZonas.Items.Add(rd(0))
            lstZonas.Items(indice).SubItems.Add(rd(1))
            lstZonas.Items(indice).SubItems.Add(rd(2))
            lstZonas.Items(indice).SubItems.Add(rd(3))
            lstZonas.Items(indice).SubItems.Add(rd(4))
            indice += 1
        End While
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        ans = MsgBox("Desea agregar estas Zonas?", MsgBoxStyle.YesNo, "Atencion")
        If ans = 6 Then
            indice = CorredoresEdicion.lstZonas.Items.Count
            For Each item In lstZonas.SelectedItems
                Consulta("INSERT INTO Corredores_Zonas VALUES(" & codigoCorredor & ", " & Val(item.Text) & ")")
                CorredoresEdicion.lstZonas.Items.Add(item.Text)
                CorredoresEdicion.lstZonas.Items(indice).SubItems.Add(item.SubItems(1).Text)
                CorredoresEdicion.lstZonas.Items(indice).SubItems.Add(item.SubItems(2).Text)
                CorredoresEdicion.lstZonas.Items(indice).SubItems.Add(item.SubItems(3).Text)
                CorredoresEdicion.lstZonas.Items(indice).SubItems.Add(item.SubItems(4).Text)
                indice += 1
            Next item
            MsgBox("Zonas Cargadas Correctamente", MsgBoxStyle.OkOnly, "Atencion")
            Me.Close()
        End If
    End Sub

    Private Sub lstZonas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstZonas.SelectedIndexChanged
        btnAgregar.Enabled = True
    End Sub
End Class
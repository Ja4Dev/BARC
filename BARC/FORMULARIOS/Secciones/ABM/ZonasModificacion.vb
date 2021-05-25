Public Class ZonasModificacion
    Dim indice As Integer
    Dim ans As Integer

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmABM.Show()
    End Sub

    Private Sub ZonasModificacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        indice = 0
        lstZonas.Items.Clear()
        Consulta("SELECT * FROM Zonas")
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
        btnModificar.Enabled = True
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        ans = MsgBox("Desea Eliminar esta Zona?", MsgBoxStyle.YesNo, "Atencion")
        If ans = 6 Then
            Consulta("DELETE FROM Corredores_Zonas WHERE CodZona = " & Val(lstZonas.FocusedItem.Text))
            Consulta("DELETE FROM Zonas WHERE CodZona = " & Val(lstZonas.FocusedItem.Text))
            lstZonas.FocusedItem.Remove()
            MsgBox("Zona Eliminada Correctamente.", MsgBoxStyle.OkOnly, "Aviso")
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim limS As String
        Dim limN As String
        Dim limE As String
        Dim limO As String

        Me.TopMost = False
        limS = InputBox("Ingrese limite Calle Sur", "Modificacion de Zonas", lstZonas.FocusedItem.SubItems(1).Text)
        If Not Trim(limS) = "" Then
            limN = InputBox("Ingrese limite Calle Norte", "Modificacion de Zonas", lstZonas.FocusedItem.SubItems(2).Text)
            If Not Trim(limN) = "" Then
                limE = InputBox("Ingrese limite Calle Este", "Modificacion de Zonas", lstZonas.FocusedItem.SubItems(3).Text)
                If Not Trim(limE) = "" Then
                    limO = InputBox("Ingrese limite Calle Oeste", "Modificacion de Zonas", lstZonas.FocusedItem.SubItems(4).Text)
                    If Not Trim(limO) = "" Then
                        Consulta("UPDATE Zonas SET LimS = '" & Trim(limS) & "', LimN = '" & Trim(limN) & "', limE = '" & Trim(limE) & "', limO = '" & Trim(limO) & "' WHERE CodZona = " & Val(lstZonas.FocusedItem.Text))
                        lstZonas.FocusedItem.SubItems(1).Text = limS
                        lstZonas.FocusedItem.SubItems(2).Text = limN
                        lstZonas.FocusedItem.SubItems(3).Text = limE
                        lstZonas.FocusedItem.SubItems(4).Text = limO
                        MsgBox("Zona Modificada Correctamente.", MsgBoxStyle.OkOnly, "Aviso")
                    End If
                End If
            End If
        End If
        Me.TopMost = True
    End Sub
End Class
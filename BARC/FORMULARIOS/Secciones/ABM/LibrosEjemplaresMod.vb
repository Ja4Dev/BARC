Public Class LibrosEjemplaresMod
    Dim indice As Integer
    Dim ans As Integer

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        LibrosModificacion.Show()
    End Sub

    Private Sub LibrosEjemplaresMod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Consulta("SELECT * FROM Ejemplares WHERE CodLibro = " & codLibro & " ORDER BY Alquiler DESC, idEjem ASC")
        While rd.Read
            lstEjemplares.Items.Add(rd(0))
            If rd(2) = 0 Then
                lstEjemplares.Items(indice).SubItems.Add("No")
            Else
                lstEjemplares.Items(indice).SubItems.Add("Si")
            End If
            If rd(3) = 0 Then
                lstEjemplares.Items(indice).SubItems.Add("No")
            Else
                lstEjemplares.Items(indice).SubItems.Add("Si")
            End If
            If rd(4) = 0 Then
                lstEjemplares.Items(indice).SubItems.Add("No")
            Else
                lstEjemplares.Items(indice).SubItems.Add("Si")
            End If
            If rd(5) = 0 Then
                lstEjemplares.Items(indice).SubItems.Add("Compra")
            Else
                lstEjemplares.Items(indice).SubItems.Add("Alquiler")
            End If
            indice += 1
        End While
    End Sub

    Private Sub lstEjemplares_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstEjemplares.SelectedIndexChanged
        If lstEjemplares.FocusedItem.SubItems(2).Text = "No" And lstEjemplares.FocusedItem.SubItems(3).Text = "No" Then
            btnEstado.Enabled = True
        Else
            btnEstado.Enabled = False
        End If

        If lstEjemplares.FocusedItem.SubItems(1).Text = "No" And lstEjemplares.FocusedItem.SubItems(2).Text = "No" And lstEjemplares.FocusedItem.SubItems(3).Text = "No" Then
            btnTipo.Enabled = True
        Else
            btnTipo.Enabled = False
        End If
    End Sub

    Private Sub btnEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstado.Click
        ans = MsgBox("Desea Modificar el estado del libro?", MsgBoxStyle.YesNo, "Atencion")
        If ans = 6 Then
            If lstEjemplares.FocusedItem.SubItems(1).Text = "No" Then
                Consulta("UPDATE Ejemplares SET Deteriorado = 1 WHERE idEjem = " & Val(lstEjemplares.FocusedItem.Text))
                lstEjemplares.FocusedItem.SubItems(1).Text = "Si"
            Else
                Consulta("UPDATE Ejemplares SET Deteriorado = 0 WHERE idEjem = " & Val(lstEjemplares.FocusedItem.Text))
                lstEjemplares.FocusedItem.SubItems(1).Text = "No"
            End If
            MsgBox("Estado Modificado Correctamente.", MsgBoxStyle.OkOnly, "Aviso")
        End If
    End Sub

    Private Sub btnTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTipo.Click
        ans = MsgBox("Desea Modificar el Tipo de operacion del Libro?", MsgBoxStyle.YesNo, "Atencion")
        If ans = 6 Then
            If lstEjemplares.FocusedItem.SubItems(4).Text = "Alquiler" Then
                Consulta("UPDATE Ejemplares SET Alquiler = 0 WHERE idEjem = " & Val(lstEjemplares.FocusedItem.Text))
                lstEjemplares.FocusedItem.SubItems(4).Text = "Compra"
            Else
                Consulta("UPDATE Ejemplares SET Alquiler = 1 WHERE idEjem = " & Val(lstEjemplares.FocusedItem.Text))
                lstEjemplares.FocusedItem.SubItems(4).Text = "Alquiler"
            End If
            MsgBox("Tipo de operacion modificado Correctamente.", MsgBoxStyle.OkOnly, "Aviso")
        End If
    End Sub
End Class
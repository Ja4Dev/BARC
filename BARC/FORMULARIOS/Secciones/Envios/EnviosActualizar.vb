Public Class EnviosActualizar
    Dim indice As Integer

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmEnvios.Show()
    End Sub

    Private Sub EnviosActualizar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lstEnvios.Items.Clear()
        indice = 0
        Consulta("SELECT * FROM Envios WHERE Estado_Envio <> 'Pendiente'")
        While rd.Read
            lstEnvios.Items.Add(rd(0))
            If Not IsDBNull(rd(2)) Then
                lstEnvios.Items(indice).SubItems.Add(Format(rd(1), "dd/MM/yyyy"))
                lstEnvios.Items(indice).SubItems.Add("Alquiler")
                lstEnvios.Items(indice).SubItems.Add(rd(2))
            Else
                lstEnvios.Items(indice).SubItems.Add(Format(rd(1), "dd/MM/yyyy"))
                lstEnvios.Items(indice).SubItems.Add("Compra")
                lstEnvios.Items(indice).SubItems.Add(rd(3))
            End If
            lstEnvios.Items(indice).SubItems.Add(rd(4))
            indice += 1
        End While
    End Sub

    Private Sub lstEnvios_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstEnvios.SelectedIndexChanged
        btnRemito.Enabled = True
    End Sub

    Private Sub btnRemito_Click(sender As System.Object, e As System.EventArgs) Handles btnRemito.Click
        CodCompra = Val(lstEnvios.FocusedItem.SubItems(3).Text)
        If lstEnvios.FocusedItem.SubItems(2).Text = "Compra" Then
            Consulta("SELECT NRemito FROM Remitos WHERE CodCompra = " & CodCompra)
        Else
            Consulta("SELECT NRemito FROM Remitos WHERE CodAlquiler = " & CodCompra)
        End If
        rd.Read()
        NumeroRemito = rd(0)
        InvoiceGenerate("remito_ver")
    End Sub
End Class
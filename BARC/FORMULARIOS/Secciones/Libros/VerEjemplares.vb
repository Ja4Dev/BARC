Public Class VerEjemplares
    Dim indice As Integer

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        Libros.Show()
    End Sub

    Private Sub VerEjemplares_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formulario = "pedir_ejemplares"
        lstEjemplares.Items.Clear()
        Consulta("SELECT Codlibro, titulo, isbn, puntopedido, puntopedidoalquiler from libros")
        BanderaRS = 1
        indice = 0
        While rd.Read
            lstEjemplares.Items.Add(rd(0))
            lstEjemplares.Items(indice).SubItems.Add(rd(1))
            lstEjemplares.Items(indice).SubItems.Add(rd(2))
            lstEjemplares.Items(indice).SubItems.Add(rd(3))
            lstEjemplares.Items(indice).SubItems.Add(rd(4))
            Consulta("SELECT COUNT(*) FROM Ejemplares WHERE alquiler = 0 and prestado = 0 and vendido = 0 and deteriorado = 0 AND CodLibro = " & rd(0))
            rd2.Read()
            lstEjemplares.Items(indice).SubItems.Add(rd2(0))
            Consulta("SELECT COUNT(*) FROM Ejemplares WHERE alquiler = 1 and prestado = 0 and vendido = 0 and deteriorado = 0 AND CodLibro = " & rd(0))
            rd2.Read()
            lstEjemplares.Items(indice).SubItems.Add(rd2(0))
            If (Val(lstEjemplares.Items(indice).SubItems(3).Text) - Val(lstEjemplares.Items(indice).SubItems(5).Text)) < 0 Or (Val(lstEjemplares.Items(indice).SubItems(4).Text) - Val(lstEjemplares.Items(indice).SubItems(6).Text)) < 0 Then
                lstEjemplares.Items(indice).SubItems.Add("En Existencias")
            ElseIf (Val(lstEjemplares.Items(indice).SubItems(3).Text) - Val(lstEjemplares.Items(indice).SubItems(5).Text)) = 0 Or (Val(lstEjemplares.Items(indice).SubItems(4).Text) - Val(lstEjemplares.Items(indice).SubItems(6).Text)) = 0 Then
                lstEjemplares.Items(indice).SubItems.Add("Punto Pedido Alcanzado")
            Else
                lstEjemplares.Items(indice).SubItems.Add("Punto Pedido Alcanzado")
            End If
            indice += 1
        End While
        BanderaRS = 0
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        Me.Hide()
        SolicitarCompra.Show()
    End Sub
End Class
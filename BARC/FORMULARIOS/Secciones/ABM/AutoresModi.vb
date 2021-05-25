Public Class AutoresModi
    Dim indice As Integer

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmABM.Show()
    End Sub

    Private Sub AutoresModi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        indice = 0
        Consulta("SELECT * FROM autores")
        While rd.Read
            lstAutores.Items.Add(rd(0))
            lstAutores.Items(indice).SubItems.Add(rd(1))
            lstAutores.Items(indice).SubItems.Add(rd(2))
            indice += 1
        End While
    End Sub

    Private Sub lstAutores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAutores.SelectedIndexChanged
        btnModificar.Enabled = True
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim nombre As String
        Dim apellido As String

        Me.TopMost = False
        nombre = InputBox("Ingrese Nuevo Nombre del Autor", "Modificacion de Autor", lstAutores.FocusedItem.SubItems(1).Text)
        If Not Trim(nombre) = "" Then
            apellido = InputBox("Ingrese Nuevo Apellido del Autor", "Modificacion de Autor", lstAutores.FocusedItem.SubItems(2).Text)
            If Not Trim(apellido) = "" Then
                Consulta("UPDATE Autores SET Nombre = '" & nombre & "', Apellido = '" & apellido & "' WHERE CodAutor = " & Val(lstAutores.FocusedItem.Text))
                lstAutores.FocusedItem.SubItems(1).Text = nombre
                lstAutores.FocusedItem.SubItems(2).Text = apellido
                MsgBox("Autor Modificado Correctamente", MsgBoxStyle.OkOnly, "Aviso")
            End If
        End If
        Me.TopMost = True
    End Sub
End Class
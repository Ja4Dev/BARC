Public Class EditorialSelect
    Dim indice As Integer
    Dim ans As Integer

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub EditorialSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstEditoriales.Items.Clear()
        indice = 0
        Consulta("SELECT * FROM Editoriales WHERE CodEditorial NOT IN (SELECT Editorial FROM Proveedores_Editoriales WHERE CodProveedor = " & codigoProveedor & ")")
        While rd.Read
            lstEditoriales.Items.Add(rd(0))
            lstEditoriales.Items(indice).SubItems.Add(rd(1))
            indice += 1
        End While
    End Sub

    Private Sub lstEditoriales_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstEditoriales.SelectedIndexChanged
        btnAgregar.Enabled = True
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        ans = MsgBox("Desea agregar estas Editoriales?", MsgBoxStyle.YesNo, "Atencion")
        If ans = 6 Then
            indice = ProveedoresEditoriales.lstEditoriales.Items.Count
            For Each item In lstEditoriales.SelectedItems
                Consulta("INSERT INTO Proveedores_Editoriales VALUES(" & codigoProveedor & ", " & Val(item.Text) & ")")
                ProveedoresEditoriales.lstEditoriales.Items.Add(item.Text)
                ProveedoresEditoriales.lstEditoriales.Items(indice).SubItems.Add(item.SubItems(1).Text)
                indice += 1
            Next item
            MsgBox("Editoriales Cargadas Correctamente", MsgBoxStyle.OkOnly, "Atencion")
            Me.Close()
        End If
    End Sub
End Class
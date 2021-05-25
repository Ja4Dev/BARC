Public Class ProveedoresEditoriales
    Dim indice As Integer
    Dim ans As Integer

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmABM.Show()
    End Sub

    Private Sub ProveedoresEditoriales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        indice = 0
        Consulta("SELECT * FROM Proveedores")
        While rd.Read
            lstProveedores.Items.Add(rd(0))
            lstProveedores.Items(indice).SubItems.Add(rd(1))
            lstProveedores.Items(indice).SubItems.Add(rd(2))
            lstProveedores.Items(indice).SubItems.Add(rd(3))
            indice += 1
        End While
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        ans = MsgBox("Seguro que desea Eliminar esta Editorial?", MsgBoxStyle.YesNo, "Atencion")
        If ans = 6 Then
            Consulta("DELETE FROM Proveedores_Editoriales WHERE codProveedor = " & codigoProveedor & " AND Editorial = " & editorialcodigo)
            lstEditoriales.FocusedItem.Remove()
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub lstProveedores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstProveedores.SelectedIndexChanged
        indice = 0
        codigoProveedor = Val(lstProveedores.FocusedItem.Text)
        lstEditoriales.Items.Clear()
        btnEliminar.Enabled = False
        btnAgregar.Enabled = True
        Consulta("SELECT e.CodEditorial, nombreEditorial FROM Editoriales e, Proveedores_Editoriales p WHERE e.CodEditorial = p.Editorial AND CodProveedor = " & codigoProveedor)
        While rd.Read
            lstEditoriales.Items.Add(rd(0))
            lstEditoriales.Items(indice).SubItems.Add(rd(1))
            indice += 1
        End While
    End Sub

    Private Sub lstEditoriales_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstEditoriales.SelectedIndexChanged
        btnEliminar.Enabled = True
        editorialcodigo = Val(lstEditoriales.FocusedItem.Text)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        EditorialSelect.ShowDialog()
    End Sub
End Class
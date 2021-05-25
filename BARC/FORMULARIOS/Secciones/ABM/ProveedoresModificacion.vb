Public Class ProveedoresModificacion
    Dim indice As Integer
    Dim ans As Integer

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmABM.Show()
    End Sub

    Private Sub ProveedoresModificacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub lstProveedores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstProveedores.SelectedIndexChanged
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        ans = MsgBox("Desea Eliminar el Proveedor Seleccionado?", MsgBoxStyle.YesNo, "Atencion")
        If ans = 6 Then
            Consulta("DELETE FROM Proveedores_Editoriales WHERE CodProveedor = " & Val(lstProveedores.FocusedItem.Text))
            Consulta("DELETE FROM Proveedores WHERE CodProveedor = " & Val(lstProveedores.FocusedItem.Text))
            MsgBox("Proveedor Eliminado Correctamente.")
            lstProveedores.FocusedItem.Remove()
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim proveedor As String
        Dim direccion As String
        Dim telefono As String
        Me.TopMost = False
        proveedor = InputBox("Ingrese Nombre del Proveedor", "Modificacion de Proveedores", lstProveedores.FocusedItem.SubItems(1).Text)
        If Not Trim(proveedor) = "" Then
            direccion = InputBox("Ingrese Direccion del Proveedor", "Modificacion de Proveedores", lstProveedores.FocusedItem.SubItems(2).Text)
            If Not Trim(direccion) = "" Then
                telefono = InputBox("Ingrese Telefono del Proveedor", "Modificacion de Proveedores", lstProveedores.FocusedItem.SubItems(3).Text)
                If Not Trim(telefono) = "" Then
                    Consulta("UPDATE Proveedores SET Proveedor = '" & Trim(proveedor) & "', Direccion = '" & Trim(direccion) & "', telefono = '" & Trim(telefono) & "' WHERE CodProveedor = " & Val(lstProveedores.FocusedItem.Text))
                    lstProveedores.FocusedItem.SubItems(1).Text = Trim(proveedor)
                    lstProveedores.FocusedItem.SubItems(2).Text = Trim(direccion)
                    lstProveedores.FocusedItem.SubItems(3).Text = Trim(telefono)
                    MsgBox("Proveedor Modificado Correctamente.", MsgBoxStyle.OkOnly, "Aviso")
                End If
            End If
        End If
        Me.TopMost = True
    End Sub
End Class
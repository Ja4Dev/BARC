Public Class EditorialesMod
    Dim indice As Integer

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmABM.Show()
    End Sub

    Private Sub EditorialesMod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstEditoriales.Items.Clear()
        indice = 0
        Consulta("SELECT * FROM Editoriales")
        While rd.Read
            lstEditoriales.Items.Add(rd(0))
            lstEditoriales.Items(indice).SubItems.Add(rd(1))
            indice += 1
        End While
    End Sub

    Private Sub lstEditoriales_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstEditoriales.SelectedIndexChanged
        btnModificar.Enabled = True
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim editorial As String

        Me.TopMost = False
        editorial = InputBox("Ingrese Nuevo Nombre de Editorial", "Modificacion de Editorial", lstEditoriales.FocusedItem.SubItems(1).Text)
        If Not Trim(editorial) = "" Then
            Consulta("UPDATE Editoriales SET nombreEditorial = '" & editorial & "' WHERE codEditorial = " & Val(lstEditoriales.FocusedItem.Text))
            lstEditoriales.FocusedItem.SubItems(1).Text = editorial
            MsgBox("Editorial modificada Correctamente.", MsgBoxStyle.OkOnly, "Aviso")
        End If
        Me.TopMost = True
    End Sub
End Class
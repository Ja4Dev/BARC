Public Class AgregarLibro
    Dim ans As Integer
    Dim codautor As Integer
    Dim codeditorial As Integer

    Private Sub numCantCompra_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If numCantCompra.Value < 0 Then
            numCantCompra.Value = 0
        End If
    End Sub

    Private Sub numCantAlq_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If numCantAlq.Value < 0 Then
            numCantAlq.Value = 0
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        ans = MsgBox("Confirma que los datos ingresados son Correctos?", MsgBoxStyle.YesNo, "Atencion")
        If ans = 6 Then
            Consulta("SELECT COUNT(*) FROM Autores WHERE Nombre = '" & Trim(txtNombreAu.Text) & "' AND Apellido = '" & Trim(txtApellidoAu.Text) & "'") ' si el autor existe
            rd.Read()
            If rd(0) = 1 Then ' si existe conseguimos su cod autor
                Consulta("SELECT CodAutor FROM Autores WHERE Nombre = '" & Trim(txtNombreAu.Text) & "' AND Apellido = '" & Trim(txtApellidoAu.Text) & "'")
                rd.Read()
                codautor = rd(0)
            Else ' si no existe lo insertamos
                Consulta("insert into autores values ('', '" & Trim(txtNombreAu.Text) & "', '" & Trim(txtApellidoAu.Text) & "')")
                Consulta("SELECT CodAutor FROM Autores WHERE Nombre = '" & Trim(txtNombreAu.Text) & "' AND Apellido = '" & Trim(txtApellidoAu.Text) & "'")
                rd.Read()
                codautor = rd(0)
            End If
            Consulta("SELECT CodEditorial FROM Editoriales WHERE NombreEditorial = '" & Trim(txtEditorial.Text) & "'")
            If rd.Read Then
                codeditorial = rd(0)
            Else
                Consulta("INSERT INTO Editoriales VALUES ('', '" & Trim(txtEditorial.Text) & "')")
                Consulta("SELECT Max(CodEditorial) FROM Editoriales")
                rd.Read()
                codeditorial = rd(0)
                Consulta("INSERT INTO Proveedores_Editoriales VALUES (" & CodProveedor & ", " & rd(0) & ")")
            End If
            Consulta("CALL AgreLibroNuevo('" & Trim(txtTitulo.Text) & "', '" & NumISBN & "', " & codeditorial & ", " & Val(txtPrecioVenta.Text) & ", " & Val(txtPrecioAlquiler.Text) & ", '" & txtFPubli.Text & "', " & codautor & ", " & numCantAlq.Value & ", " & numCantCompra.Value & ")")
            Me.Close()
        End If
    End Sub


    Private Sub txtPrecioAlquiler_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioAlquiler.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = 46 Then
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub txtPrecioVenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioVenta.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = 46 Then
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub txtFPubli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFPubli.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub AgregarLibro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtApellidoAu.Clear()
        txtEditorial.Clear()
        txtFPubli.Clear()
        txtNombreAu.Clear()
        txtPrecioAlquiler.Clear()
        txtPrecioVenta.Clear()
        txtTitulo.Clear()
        numCantAlq.Value = 0
        numCantCompra.Value = 0
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class
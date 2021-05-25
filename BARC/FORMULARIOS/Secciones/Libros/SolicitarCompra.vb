Public Class SolicitarCompra
    Dim Cantidad As Boolean
    Dim Iterador As Integer
    Dim CodSolicitud As Integer
    Dim indice As Integer



    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        If formulario = "pedir_libros" Then
            VerEjemplares.Close()
        End If
        Me.Close()
        Libros.Show()
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        Cantidad = False
        For Each item In lstLibros.Items
            Cantidad = True
        Next item
        If Cantidad Then
            Consulta("SELECT CodProveedor FROM Proveedores WHERE Proveedor = '" & cmbProveedores.SelectedItem.ToString & "'")
            rd.Read()
            Consulta("INSERT INTO Solicitudes_Compras VALUES ('', '" & rd(0) & "', 'Pendiente', CURDATE())")
            Consulta("SELECT MAX(NSoli) From Solicitudes_Compras")
            rd.Read()
            CodSolicitud = rd(0)
            For Each item In lstLibros.Items
                Consulta("INSERT INTO Solicitudes_Compras_Det VALUES ('', " & CodSolicitud & ", '" & item.Subitems(1).Text & "', " & Val(item.Subitems(3).Text) & " )")
            Next item
            MsgBox("Solicitud de Compra Generada")
            If formulario = "pedir_libros" Then
                VerEjemplares.Close()
            End If
            Me.Close()
            Libros.Show()
        Else
            MsgBox("Ingrese minimo 1 Libro para Generar la Solicitud de Compra")
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Iterador = lstLibros.Items.Count
        If Trim(txtISBN.Text) = "" Then
            MsgBox("Ingrese un ISBN", MsgBoxStyle.OkOnly)
        Else
            Consulta("SELECT ISBN, Titulo From Libros WHERE ISBN = '" & txtISBN.Text & "'")
            If rd.Read() Then
                lstLibros.Items.Add(Iterador + 1)
                lstLibros.Items(Iterador).SubItems.Add(rd(0))
                lstLibros.Items(Iterador).SubItems.Add(rd(1))
                lstLibros.Items(Iterador).SubItems.Add(numCantEjemplares.Value)
            Else
                lstLibros.Items.Add(Iterador + 1)
                lstLibros.Items(Iterador).SubItems.Add(txtISBN.Text)
                lstLibros.Items(Iterador).SubItems.Add("Libro no Existente en la Base de Datos")
                lstLibros.Items(Iterador).SubItems.Add(numCantEjemplares.Value)
            End If
            txtISBN.Text = ""
            numCantEjemplares.Value = 1
            Iterador = Iterador + 1
        End If
    End Sub

    Private Sub numCantEjemplares_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numCantEjemplares.ValueChanged
        If numCantEjemplares.Value = 0 Then
            numCantEjemplares.Value = 1
        End If
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        lstLibros.FocusedItem.Remove()
        Iterador -= 1
        btnQuitar.Enabled = False
    End Sub

    Private Sub lstLibros_ColumnWidthChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangingEventArgs) Handles lstLibros.ColumnWidthChanging

        e.Cancel = True
        e.NewWidth = lstLibros.Columns(e.ColumnIndex).Width

    End Sub

    Private Sub lstLibros_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstLibros.SelectedIndexChanged
        btnQuitar.Enabled = True
    End Sub

    Private Sub cmbProveedores_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbProveedores.SelectedIndexChanged
        btnGenerar.Enabled = True
    End Sub

    Private Sub SolicitarCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lstLibros.Items.Clear()

        Consulta("SELECT * FROM Proveedores")

        cmbProveedores.Items.Clear()

        While rd.Read

            cmbProveedores.Items.Add(rd(1))

        End While

        If formulario = "pedir_ejemplares" Then

            Dim selectedItems = VerEjemplares.lstEjemplares.SelectedItems
            Dim cantPedir As Integer

            indice = 0

            For Each item As ListViewItem In selectedItems

                cantPedir = (Val(item.SubItems(3).Text) - Val(item.SubItems(5).Text)) + (Val(item.SubItems(4).Text) - Val(item.SubItems(6).Text))

                If cantPedir <= 0 Then

                    cantPedir = 1
                End If

                lstLibros.Items.Add(indice + 1)
                lstLibros.Items(indice).SubItems.Add(item.SubItems(2).Text)
                lstLibros.Items(indice).SubItems.Add(item.SubItems(1).Text)
                lstLibros.Items(indice).SubItems.Add(cantPedir + 4)

                indice += 1

            Next item

            VerEjemplares.Close()

        End If

    End Sub

End Class
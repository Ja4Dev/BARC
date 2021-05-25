Public Class RegistrarAsis
    Dim indice As Integer
    Dim ans As Integer

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmEventos.Show()
    End Sub

    Private Sub RegistrarAsis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstEventos.Items.Clear()
        Consulta("SELECT NEvento, Fecha, Nombre FROM Eventos ORDER BY(Fecha) DESC")
        While rd.Read()
            lstEventos.Items.Add(rd(0))
            lstEventos.Items(indice).SubItems.Add(Format(rd(1), "dd/MM/yyyy"))
            lstEventos.Items(indice).SubItems.Add(rd(2))
            indice += 1
        End While
    End Sub

    Private Sub lstEventos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstEventos.SelectedIndexChanged
        lblEvento.Text = "Evento Seleccionado: (" & lstEventos.FocusedItem.Text & ") " & lstEventos.FocusedItem.SubItems(2).Text
        txtCodSoc.Clear()
        txtCodSoc.Focus()
        btnRegistrar.Enabled = False
    End Sub

    Private Sub btnVerificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerificar.Click
        If Trim(txtCodSoc.Text) = "" Then
            MsgBox("Ingrese un Codigo de Socio Valido", MsgBoxStyle.OkOnly, "Atencion")
        Else
            Consulta("SELECT CodSocio, Nombre, Apellido, DNI FROM Socios WHERE CodSocio = " & Val(txtCodSoc.Text))
            rd.Read()
            codsoc = rd(0)
            lblnombreSoc.Text = "Nombre y Apellido: " & rd(1) & " " & rd(2)
            lblDNI.Text = "DNI: " & rd(3)
            txtCodSoc.Clear()
            btnRegistrar.Enabled = True
        End If
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        ans = MsgBox("¿Desea Registrar la asistencia del Socio: (" & codsoc & ") " & rd(1) & " " & rd(2) & "?", MsgBoxStyle.YesNo, "Atencion")
        If ans = 6 Then
            Consulta("SELECT NEvento FROM AsisEvento WHERE NEvento = " & Val(lstEventos.FocusedItem.Text) & " AND CodSocio = " & codsoc)
            If Not rd.Read Then
                Consulta("INSERT INTO AsisEvento VALUES (" & Val(lstEventos.FocusedItem.Text) & ", " & codsoc & ")")
                MsgBox("La Asistencia del socio fue cargada Correctamente", MsgBoxStyle.OkOnly, "Atencion")
                FechaEvento_ = lstEventos.FocusedItem.SubItems(1).Text
                NomEvento = lstEventos.FocusedItem.SubItems(2).Text
                InvoiceGenerate("EventoAsis")
            Else
                MsgBox("El socio ya se encontraba registrado en este evento.", MsgBoxStyle.OkOnly, "Atencion")
            End If
        End If
    End Sub
End Class
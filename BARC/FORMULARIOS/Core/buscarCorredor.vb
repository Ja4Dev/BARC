Public Class buscarCorredor

    Dim exec As Integer

    Private Sub buscarCorredor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lstZonas.Items.Clear()
        lstCorredores.Items.Clear()

        Consulta("select CodCorredor, Nombre, Apellido from corredores WHERE baja = 0")

        While rd.Read

            Dim i As Integer

            lstCorredores.Items.Add(rd(0))
            lstCorredores.Items(i).SubItems.Add(rd(1))
            lstCorredores.Items(i).SubItems.Add(rd(2))

            i += 1

        End While

    End Sub

    Private Sub lstCorredores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCorredores.SelectedIndexChanged

        lstZonas.Items.Clear()

        Consulta("select limN, limS, limE, limO from corredores_zonas cz, zonas z where cz.codcorredor = " & Val(lstCorredores.FocusedItem.Text) & " and cz.codzona = z.codzona")

        While rd.Read

            Dim i As Integer

            lstZonas.Items.Add(rd(0))
            lstZonas.Items(i).SubItems.Add(rd(1))
            lstZonas.Items(i).SubItems.Add(rd(2))
            lstZonas.Items(i).SubItems.Add(rd(3))

            i += 1

        End While

        btnSeleccionar.Enabled = True

        exec += 1

        If exec = 2 Then
            exec = 0
        End If

    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click

        If formulario = "RegistrarPago" Then

            RegistrarPago.lblCorredorCod.Text = "Codigo de corredor : " & Val(lstCorredores.FocusedItem.Text)
            RegistrarPago.lblCorredorNom.Text = "Nombre de corredor : " & (lstCorredores.FocusedItem.SubItems(1).Text & " " & lstCorredores.FocusedItem.SubItems(2).Text)

            RegistrarPago.btnRegistrar.Enabled = True
            RegistrarPago.lblCorredorCod.Visible = True
            RegistrarPago.lblCorredorNom.Visible = True
            RegistrarPago.lblSeleccionar.Visible = False

            codigoCorredor = Val(lstCorredores.FocusedItem.Text)

            formulario = "modulo_cobros"

        ElseIf formulario = "modulo_compras" Then

            codigoCorredor = Val(lstCorredores.FocusedItem.Text)

            Facturacion.btnCorredor.Text = "Cambiar corredor" & vbCrLf & "Actual : " & codigoCorredor

            Facturacion.btnConfirmarOperacion.Enabled = True
        Else
            codigoCorredor = Val(lstCorredores.FocusedItem.Text)

        End If

        btnSeleccionar.Enabled = False
        Me.Close()


    End Sub

End Class
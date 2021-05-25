Public Class frmABM


    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Me.Close()
        ProveedoresEditoriales.Show()
    End Sub

    Private Sub btnProvAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProvAlta.Click
        Dim proveedor As String
        Dim direccion As String
        Dim telefono As String
        Me.TopMost = False
        proveedor = InputBox("Ingrese Nombre del Proveedor", "Alta de Proveedores")
        If Not Trim(proveedor) = "" Then
            direccion = InputBox("Ingrese Direccion del Proveedor", "Alta de Proveedores")
            If Not Trim(direccion) = "" Then
                telefono = InputBox("Ingrese Telefono del Proveedor", "Alta de Proveedores")
                If Not Trim(telefono) = "" Then
                    Consulta("INSERT INTO Proveedores VALUES ('', '" & Trim(proveedor) & "', '" & Trim(direccion) & "', '" & Trim(telefono) & "')")
                    MsgBox("Proveedor Cargado Correctamente.", MsgBoxStyle.OkOnly, "Aviso")
                End If
            End If
        End If
        Me.TopMost = True
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Me.Close()
        ProveedoresModificacion.Show()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Me.Close()
        InteresesMod.Show()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Me.Close()
        UsuariosMod.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.Close()
        CorredoresMod.Show()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim dni As String
        Dim nombre As String
        Dim apellido As String
        Dim telefono As String

        Me.TopMost = False
        dni = InputBox("Ingrese DNI del Nuevo Corredor", "Ingreso de Nuevos Corredores")
        If Not Trim(dni) = "" Then
            nombre = InputBox("Ingrese Nombre del Nuevo Corredor", "Ingreso de Nuevos Corredores")
            If Not Trim(nombre) = "" Then
                apellido = InputBox("Ingrese Apellido del Nuevo Corredor", "Ingreso de Nuevos Corredores")
                If Not Trim(apellido) = "" Then
                    telefono = InputBox("Ingrese Telefono del Nuevo Corredor", "Ingreso de Nuevos Corredores")
                    If Not Trim(telefono) = "" Then
                        Consulta("INSERT INTO Corredores VALUES ('', '" & Trim(dni) & "', '" & Trim(nombre) & "', '" & Trim(apellido) & "', '" & Trim(telefono) & "')")
                        MsgBox("Corredor Ingresado Correctamente.", MsgBoxStyle.OkOnly, "Aviso")
                    End If
                End If
            End If
        End If
        Me.TopMost = True
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim limS As String
        Dim limN As String
        Dim limE As String
        Dim limO As String

        Me.TopMost = False
        limS = InputBox("Ingrese limite Calle Sur", "Ingreso de Zonas")
        If Not Trim(limS) = "" Then
            limN = InputBox("Ingrese limite Calle Norte", "Ingreso de Zonas")
            If Not Trim(limN) = "" Then
                limE = InputBox("Ingrese limite Calle Este", "Ingreso de Zonas")
                If Not Trim(limE) = "" Then
                    limO = InputBox("Ingrese limite Calle Oeste", "Ingreso de Zonas")
                    If Not Trim(limO) = "" Then
                        Consulta("INSERT INTO Zonas VALUES ('', '" & Trim(limS) & "', '" & Trim(limN) & "', '" & Trim(limE) & "', '" & Trim(limO) & "')")
                        MsgBox("Zona Agregada Correctamente.", MsgBoxStyle.OkOnly, "Aviso")
                    End If
                End If
            End If
        End If
        Me.TopMost = True
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
        ZonasModificacion.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
        LibrosModificacion.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        AutoresModi.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        EditorialesMod.Show()
    End Sub

    Private Sub btnAltas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAltas.Click
        Dim editorial As String

        Me.TopMost = False
        editorial = InputBox("Ingrese el Nombre de la Nueva Editorial", "Ingreso de Editorial")
        If Not Trim(editorial) = "" Then
            Consulta("INSERT INTO Editoriales VALUES ('', '" & Trim(editorial) & "')")
            MsgBox("Editorial agregada Correctamente.", MsgBoxStyle.OkOnly, "Aviso")
        End If
        Me.TopMost = True
    End Sub

    Private Sub frmABM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Pantalla Principal - Sesion iniciada como : " & user
    End Sub
End Class
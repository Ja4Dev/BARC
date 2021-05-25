<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarAsis
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstEventos = New System.Windows.Forms.ListView()
        Me.IdEvento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaEvento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NombreEvento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodSoc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblnombreSoc = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblEvento = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstEventos
        '
        Me.lstEventos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IdEvento, Me.FechaEvento, Me.NombreEvento})
        Me.lstEventos.FullRowSelect = True
        Me.lstEventos.Location = New System.Drawing.Point(12, 145)
        Me.lstEventos.Name = "lstEventos"
        Me.lstEventos.Size = New System.Drawing.Size(322, 351)
        Me.lstEventos.TabIndex = 1
        Me.lstEventos.UseCompatibleStateImageBehavior = False
        Me.lstEventos.View = System.Windows.Forms.View.Details
        '
        'IdEvento
        '
        Me.IdEvento.Text = "#"
        Me.IdEvento.Width = 63
        '
        'FechaEvento
        '
        Me.FechaEvento.Text = "Fecha"
        Me.FechaEvento.Width = 114
        '
        'NombreEvento
        '
        Me.NombreEvento.Text = "Nombre"
        Me.NombreEvento.Width = 141
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(428, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Registrar Asistencia de Socio"
        '
        'txtCodSoc
        '
        Me.txtCodSoc.Location = New System.Drawing.Point(424, 170)
        Me.txtCodSoc.Name = "txtCodSoc"
        Me.txtCodSoc.Size = New System.Drawing.Size(79, 22)
        Me.txtCodSoc.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Seleccione Evento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(358, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cod Socio: "
        '
        'lblnombreSoc
        '
        Me.lblnombreSoc.AutoSize = True
        Me.lblnombreSoc.Location = New System.Drawing.Point(358, 251)
        Me.lblnombreSoc.Name = "lblnombreSoc"
        Me.lblnombreSoc.Size = New System.Drawing.Size(108, 13)
        Me.lblnombreSoc.TabIndex = 6
        Me.lblnombreSoc.Text = "Nombre y Apellido: "
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(358, 282)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(32, 13)
        Me.lblDNI.TabIndex = 7
        Me.lblDNI.Text = "DNI: "
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Enabled = False
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegistrar.Location = New System.Drawing.Point(393, 359)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(151, 34)
        Me.btnRegistrar.TabIndex = 8
        Me.btnRegistrar.Text = "Registrar Asistencia"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnVerificar
        '
        Me.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVerificar.Location = New System.Drawing.Point(514, 170)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(75, 23)
        Me.btnVerificar.TabIndex = 9
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnBack.Location = New System.Drawing.Point(560, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(29, 25)
        Me.btnBack.TabIndex = 49
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblEvento
        '
        Me.lblEvento.AutoSize = True
        Me.lblEvento.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblEvento.Location = New System.Drawing.Point(358, 119)
        Me.lblEvento.Name = "lblEvento"
        Me.lblEvento.Size = New System.Drawing.Size(119, 13)
        Me.lblEvento.TabIndex = 50
        Me.lblEvento.Text = "Evento Seleccionado: "
        '
        'RegistrarAsis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(601, 508)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblEvento)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnVerificar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.lblnombreSoc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodSoc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstEventos)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "RegistrarAsis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Asistencia"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstEventos As System.Windows.Forms.ListView
    Friend WithEvents IdEvento As System.Windows.Forms.ColumnHeader
    Friend WithEvents FechaEvento As System.Windows.Forms.ColumnHeader
    Friend WithEvents NombreEvento As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodSoc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblnombreSoc As System.Windows.Forms.Label
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents btnVerificar As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblEvento As System.Windows.Forms.Label
End Class

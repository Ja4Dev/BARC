<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentasAlquileres
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
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.btnSocioBusc = New System.Windows.Forms.Button()
        Me.lblVentasAlquileres = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnNuevoSocio = New System.Windows.Forms.Button()
        Me.lblCodsoc = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.btnAlquilar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnComprar
        '
        Me.btnComprar.Enabled = False
        Me.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnComprar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprar.Location = New System.Drawing.Point(153, 123)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(173, 40)
        Me.btnComprar.TabIndex = 11
        Me.btnComprar.Text = "Realizar Compra"
        Me.btnComprar.UseVisualStyleBackColor = True
        '
        'btnSocioBusc
        '
        Me.btnSocioBusc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSocioBusc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSocioBusc.Location = New System.Drawing.Point(12, 67)
        Me.btnSocioBusc.Name = "btnSocioBusc"
        Me.btnSocioBusc.Size = New System.Drawing.Size(114, 40)
        Me.btnSocioBusc.TabIndex = 12
        Me.btnSocioBusc.Text = "Buscar Socio"
        Me.btnSocioBusc.UseVisualStyleBackColor = True
        '
        'lblVentasAlquileres
        '
        Me.lblVentasAlquileres.AutoSize = True
        Me.lblVentasAlquileres.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.lblVentasAlquileres.Location = New System.Drawing.Point(12, 9)
        Me.lblVentasAlquileres.Name = "lblVentasAlquileres"
        Me.lblVentasAlquileres.Size = New System.Drawing.Size(297, 46)
        Me.lblVentasAlquileres.TabIndex = 13
        Me.lblVentasAlquileres.Text = "Ventas / Alquileres"
        Me.lblVentasAlquileres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Location = New System.Drawing.Point(508, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 14
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(340, 94)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(50, 13)
        Me.lblApellido.TabIndex = 16
        Me.lblApellido.Text = "Apellido"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(150, 94)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(48, 13)
        Me.lblNombre.TabIndex = 15
        Me.lblNombre.Text = "Nombre"
        '
        'btnNuevoSocio
        '
        Me.btnNuevoSocio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNuevoSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoSocio.Location = New System.Drawing.Point(12, 123)
        Me.btnNuevoSocio.Name = "btnNuevoSocio"
        Me.btnNuevoSocio.Size = New System.Drawing.Size(114, 40)
        Me.btnNuevoSocio.TabIndex = 17
        Me.btnNuevoSocio.Text = "Nuevo Socio"
        Me.btnNuevoSocio.UseVisualStyleBackColor = True
        '
        'lblCodsoc
        '
        Me.lblCodsoc.AutoSize = True
        Me.lblCodsoc.Location = New System.Drawing.Point(150, 67)
        Me.lblCodsoc.Name = "lblCodsoc"
        Me.lblCodsoc.Size = New System.Drawing.Size(56, 13)
        Me.lblCodsoc.TabIndex = 18
        Me.lblCodsoc.Text = "CodSocio"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(340, 67)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(26, 13)
        Me.lblDNI.TabIndex = 19
        Me.lblDNI.Text = "DNI"
        '
        'btnAlquilar
        '
        Me.btnAlquilar.Enabled = False
        Me.btnAlquilar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlquilar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlquilar.Location = New System.Drawing.Point(348, 123)
        Me.btnAlquilar.Name = "btnAlquilar"
        Me.btnAlquilar.Size = New System.Drawing.Size(173, 40)
        Me.btnAlquilar.TabIndex = 20
        Me.btnAlquilar.Text = "Realizar Alquiler"
        Me.btnAlquilar.UseVisualStyleBackColor = True
        '
        'VentasAlquileres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(545, 175)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAlquilar)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.lblCodsoc)
        Me.Controls.Add(Me.btnNuevoSocio)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblVentasAlquileres)
        Me.Controls.Add(Me.btnSocioBusc)
        Me.Controls.Add(Me.btnComprar)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VentasAlquileres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnComprar As System.Windows.Forms.Button
    Friend WithEvents btnSocioBusc As System.Windows.Forms.Button
    Friend WithEvents lblVentasAlquileres As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnNuevoSocio As System.Windows.Forms.Button
    Friend WithEvents lblCodsoc As System.Windows.Forms.Label
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents btnAlquilar As System.Windows.Forms.Button
End Class




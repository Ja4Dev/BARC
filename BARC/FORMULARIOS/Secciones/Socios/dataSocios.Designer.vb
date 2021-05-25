<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataSocios
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblInformacion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblCod = New System.Windows.Forms.Label()
        Me.lblDomicilio = New System.Windows.Forms.Label()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.btnCompras = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.btnConstanciaBaja = New System.Windows.Forms.Button()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.btnAlquileres = New System.Windows.Forms.Button()
        Me.btnCredencial = New System.Windows.Forms.Button()
        Me.lblDataCodSoc = New System.Windows.Forms.Label()
        Me.lblDataNombre = New System.Windows.Forms.Label()
        Me.lblDataDomicilio = New System.Windows.Forms.Label()
        Me.lblDataTelefono = New System.Windows.Forms.Label()
        Me.lblDataDNI = New System.Windows.Forms.Label()
        Me.lblDataApellido = New System.Windows.Forms.Label()
        Me.lblDataLocalidad = New System.Windows.Forms.Label()
        Me.lblDataEstado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Location = New System.Drawing.Point(340, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 2
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblInformacion
        '
        Me.lblInformacion.AutoSize = True
        Me.lblInformacion.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformacion.Location = New System.Drawing.Point(12, 9)
        Me.lblInformacion.Name = "lblInformacion"
        Me.lblInformacion.Size = New System.Drawing.Size(189, 42)
        Me.lblInformacion.TabIndex = 3
        Me.lblInformacion.Text = "Información"
        Me.lblInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(16, 89)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(50, 13)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Nombre :"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(221, 89)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(50, 13)
        Me.lblApellido.TabIndex = 5
        Me.lblApellido.Text = "Apellido :"
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Location = New System.Drawing.Point(16, 61)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(91, 13)
        Me.lblCod.TabIndex = 6
        Me.lblCod.Text = "Código de Socio :"
        '
        'lblDomicilio
        '
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.Location = New System.Drawing.Point(16, 115)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(55, 13)
        Me.lblDomicilio.TabIndex = 7
        Me.lblDomicilio.Text = "Domicilio :"
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Location = New System.Drawing.Point(221, 115)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(59, 13)
        Me.lblLocalidad.TabIndex = 8
        Me.lblLocalidad.Text = "Localidad :"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(16, 141)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(55, 13)
        Me.lblTelefono.TabIndex = 9
        Me.lblTelefono.Text = "Telefono :"
        '
        'btnCompras
        '
        Me.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompras.Location = New System.Drawing.Point(11, 171)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(171, 40)
        Me.btnCompras.TabIndex = 10
        Me.btnCompras.Text = "Compras Realizadas"
        Me.btnCompras.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaja.Location = New System.Drawing.Point(12, 217)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(355, 40)
        Me.btnBaja.TabIndex = 11
        Me.btnBaja.Text = "Dar de Baja"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'btnConstanciaBaja
        '
        Me.btnConstanciaBaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConstanciaBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConstanciaBaja.Location = New System.Drawing.Point(11, 309)
        Me.btnConstanciaBaja.Name = "btnConstanciaBaja"
        Me.btnConstanciaBaja.Size = New System.Drawing.Size(355, 40)
        Me.btnConstanciaBaja.TabIndex = 12
        Me.btnConstanciaBaja.Text = "Constancia de Baja"
        Me.btnConstanciaBaja.UseVisualStyleBackColor = True
        Me.btnConstanciaBaja.Visible = False
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(221, 61)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(32, 13)
        Me.lblDNI.TabIndex = 13
        Me.lblDNI.Text = "DNI :"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(221, 141)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(46, 13)
        Me.lblEstado.TabIndex = 14
        Me.lblEstado.Text = "Estado :"
        '
        'btnAlquileres
        '
        Me.btnAlquileres.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlquileres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlquileres.Location = New System.Drawing.Point(195, 171)
        Me.btnAlquileres.Name = "btnAlquileres"
        Me.btnAlquileres.Size = New System.Drawing.Size(171, 40)
        Me.btnAlquileres.TabIndex = 15
        Me.btnAlquileres.Text = "Alquileres Realizados"
        Me.btnAlquileres.UseVisualStyleBackColor = True
        '
        'btnCredencial
        '
        Me.btnCredencial.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCredencial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredencial.Location = New System.Drawing.Point(12, 263)
        Me.btnCredencial.Name = "btnCredencial"
        Me.btnCredencial.Size = New System.Drawing.Size(355, 40)
        Me.btnCredencial.TabIndex = 16
        Me.btnCredencial.Text = "Ver Credencial"
        Me.btnCredencial.UseVisualStyleBackColor = True
        '
        'lblDataCodSoc
        '
        Me.lblDataCodSoc.AutoSize = True
        Me.lblDataCodSoc.Location = New System.Drawing.Point(107, 61)
        Me.lblDataCodSoc.Name = "lblDataCodSoc"
        Me.lblDataCodSoc.Size = New System.Drawing.Size(28, 13)
        Me.lblDataCodSoc.TabIndex = 17
        Me.lblDataCodSoc.Text = "data"
        '
        'lblDataNombre
        '
        Me.lblDataNombre.AutoSize = True
        Me.lblDataNombre.Location = New System.Drawing.Point(66, 89)
        Me.lblDataNombre.Name = "lblDataNombre"
        Me.lblDataNombre.Size = New System.Drawing.Size(28, 13)
        Me.lblDataNombre.TabIndex = 18
        Me.lblDataNombre.Text = "data"
        '
        'lblDataDomicilio
        '
        Me.lblDataDomicilio.AutoSize = True
        Me.lblDataDomicilio.Location = New System.Drawing.Point(71, 115)
        Me.lblDataDomicilio.Name = "lblDataDomicilio"
        Me.lblDataDomicilio.Size = New System.Drawing.Size(28, 13)
        Me.lblDataDomicilio.TabIndex = 19
        Me.lblDataDomicilio.Text = "data"
        '
        'lblDataTelefono
        '
        Me.lblDataTelefono.AutoSize = True
        Me.lblDataTelefono.Location = New System.Drawing.Point(71, 141)
        Me.lblDataTelefono.Name = "lblDataTelefono"
        Me.lblDataTelefono.Size = New System.Drawing.Size(28, 13)
        Me.lblDataTelefono.TabIndex = 20
        Me.lblDataTelefono.Text = "data"
        '
        'lblDataDNI
        '
        Me.lblDataDNI.AutoSize = True
        Me.lblDataDNI.Location = New System.Drawing.Point(253, 61)
        Me.lblDataDNI.Name = "lblDataDNI"
        Me.lblDataDNI.Size = New System.Drawing.Size(28, 13)
        Me.lblDataDNI.TabIndex = 21
        Me.lblDataDNI.Text = "data"
        '
        'lblDataApellido
        '
        Me.lblDataApellido.AutoSize = True
        Me.lblDataApellido.Location = New System.Drawing.Point(271, 89)
        Me.lblDataApellido.Name = "lblDataApellido"
        Me.lblDataApellido.Size = New System.Drawing.Size(28, 13)
        Me.lblDataApellido.TabIndex = 22
        Me.lblDataApellido.Text = "data"
        '
        'lblDataLocalidad
        '
        Me.lblDataLocalidad.AutoSize = True
        Me.lblDataLocalidad.Location = New System.Drawing.Point(280, 115)
        Me.lblDataLocalidad.Name = "lblDataLocalidad"
        Me.lblDataLocalidad.Size = New System.Drawing.Size(28, 13)
        Me.lblDataLocalidad.TabIndex = 23
        Me.lblDataLocalidad.Text = "data"
        '
        'lblDataEstado
        '
        Me.lblDataEstado.AutoSize = True
        Me.lblDataEstado.Location = New System.Drawing.Point(267, 141)
        Me.lblDataEstado.Name = "lblDataEstado"
        Me.lblDataEstado.Size = New System.Drawing.Size(28, 13)
        Me.lblDataEstado.TabIndex = 24
        Me.lblDataEstado.Text = "data"
        '
        'DataSocios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(373, 309)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblDataEstado)
        Me.Controls.Add(Me.lblDataLocalidad)
        Me.Controls.Add(Me.lblDataApellido)
        Me.Controls.Add(Me.lblDataDNI)
        Me.Controls.Add(Me.lblDataTelefono)
        Me.Controls.Add(Me.lblDataDomicilio)
        Me.Controls.Add(Me.lblDataNombre)
        Me.Controls.Add(Me.lblDataCodSoc)
        Me.Controls.Add(Me.btnCredencial)
        Me.Controls.Add(Me.btnAlquileres)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.btnConstanciaBaja)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.btnCompras)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblLocalidad)
        Me.Controls.Add(Me.lblDomicilio)
        Me.Controls.Add(Me.lblCod)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblInformacion)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DataSocios"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informacion del Socio"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblInformacion As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblCod As System.Windows.Forms.Label
    Friend WithEvents lblDomicilio As System.Windows.Forms.Label
    Friend WithEvents lblLocalidad As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents btnCompras As System.Windows.Forms.Button
    Friend WithEvents btnBaja As System.Windows.Forms.Button
    Friend WithEvents btnConstanciaBaja As System.Windows.Forms.Button
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents btnAlquileres As System.Windows.Forms.Button
    Friend WithEvents btnCredencial As System.Windows.Forms.Button
    Friend WithEvents lblDataCodSoc As System.Windows.Forms.Label
    Friend WithEvents lblDataNombre As System.Windows.Forms.Label
    Friend WithEvents lblDataDomicilio As System.Windows.Forms.Label
    Friend WithEvents lblDataTelefono As System.Windows.Forms.Label
    Friend WithEvents lblDataDNI As System.Windows.Forms.Label
    Friend WithEvents lblDataApellido As System.Windows.Forms.Label
    Friend WithEvents lblDataLocalidad As System.Windows.Forms.Label
    Friend WithEvents lblDataEstado As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturacion
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
        Me.lblFacturacion = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblCod = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lstCompra = New System.Windows.Forms.ListView()
        Me.CodLibro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClibroTitulo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClibroAutor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClibroEditorial = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CantLibros = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstPrecio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnConfirmarOperacion = New System.Windows.Forms.Button()
        Me.gbxPago = New System.Windows.Forms.GroupBox()
        Me.rdbContado = New System.Windows.Forms.RadioButton()
        Me.rdbCuotas = New System.Windows.Forms.RadioButton()
        Me.lblCompraTotal = New System.Windows.Forms.Label()
        Me.lblcantsemanasalq = New System.Windows.Forms.Label()
        Me.lblTotalSem = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.numCantSemanas = New System.Windows.Forms.NumericUpDown()
        Me.pnlAlquiler = New System.Windows.Forms.Panel()
        Me.pnlCompra = New System.Windows.Forms.Panel()
        Me.lblCuotas = New System.Windows.Forms.Label()
        Me.numCuotas = New System.Windows.Forms.NumericUpDown()
        Me.btnCorredor = New System.Windows.Forms.Button()
        Me.gbxEnvio = New System.Windows.Forms.GroupBox()
        Me.rdbEnvioNo = New System.Windows.Forms.RadioButton()
        Me.rdbEnvioSI = New System.Windows.Forms.RadioButton()
        Me.gbxPago.SuspendLayout()
        CType(Me.numCantSemanas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAlquiler.SuspendLayout()
        Me.pnlCompra.SuspendLayout()
        CType(Me.numCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxEnvio.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFacturacion
        '
        Me.lblFacturacion.AutoSize = True
        Me.lblFacturacion.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.lblFacturacion.Location = New System.Drawing.Point(12, 9)
        Me.lblFacturacion.Name = "lblFacturacion"
        Me.lblFacturacion.Size = New System.Drawing.Size(264, 46)
        Me.lblFacturacion.TabIndex = 21
        Me.lblFacturacion.Text = "Facturacion de x"
        Me.lblFacturacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Location = New System.Drawing.Point(736, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 22
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(524, 22)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(26, 13)
        Me.lblDNI.TabIndex = 26
        Me.lblDNI.Text = "DNI"
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Location = New System.Drawing.Point(319, 22)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(92, 13)
        Me.lblCod.TabIndex = 25
        Me.lblCod.Text = "Código de Socio"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(524, 50)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(50, 13)
        Me.lblApellido.TabIndex = 24
        Me.lblApellido.Text = "Apellido"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(319, 50)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(48, 13)
        Me.lblNombre.TabIndex = 23
        Me.lblNombre.Text = "Nombre"
        '
        'lstCompra
        '
        Me.lstCompra.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CodLibro, Me.ClibroTitulo, Me.ClibroAutor, Me.ClibroEditorial, Me.CantLibros, Me.lstPrecio})
        Me.lstCompra.FullRowSelect = True
        Me.lstCompra.GridLines = True
        Me.lstCompra.HideSelection = False
        Me.lstCompra.Location = New System.Drawing.Point(12, 76)
        Me.lstCompra.MultiSelect = False
        Me.lstCompra.Name = "lstCompra"
        Me.lstCompra.Size = New System.Drawing.Size(749, 185)
        Me.lstCompra.TabIndex = 27
        Me.lstCompra.UseCompatibleStateImageBehavior = False
        Me.lstCompra.View = System.Windows.Forms.View.Details
        '
        'CodLibro
        '
        Me.CodLibro.Text = "#"
        Me.CodLibro.Width = 45
        '
        'ClibroTitulo
        '
        Me.ClibroTitulo.Text = "Titulo"
        Me.ClibroTitulo.Width = 212
        '
        'ClibroAutor
        '
        Me.ClibroAutor.Text = "Autor"
        Me.ClibroAutor.Width = 130
        '
        'ClibroEditorial
        '
        Me.ClibroEditorial.Text = "Editorial"
        Me.ClibroEditorial.Width = 158
        '
        'CantLibros
        '
        Me.CantLibros.Text = "Cantidad"
        Me.CantLibros.Width = 63
        '
        'lstPrecio
        '
        Me.lstPrecio.Text = "Precio"
        Me.lstPrecio.Width = 133
        '
        'btnConfirmarOperacion
        '
        Me.btnConfirmarOperacion.Enabled = False
        Me.btnConfirmarOperacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConfirmarOperacion.Location = New System.Drawing.Point(646, 274)
        Me.btnConfirmarOperacion.Name = "btnConfirmarOperacion"
        Me.btnConfirmarOperacion.Size = New System.Drawing.Size(115, 45)
        Me.btnConfirmarOperacion.TabIndex = 29
        Me.btnConfirmarOperacion.Text = "Siguiente"
        Me.btnConfirmarOperacion.UseVisualStyleBackColor = True
        '
        'gbxPago
        '
        Me.gbxPago.Controls.Add(Me.rdbContado)
        Me.gbxPago.Controls.Add(Me.rdbCuotas)
        Me.gbxPago.Location = New System.Drawing.Point(413, 267)
        Me.gbxPago.Name = "gbxPago"
        Me.gbxPago.Size = New System.Drawing.Size(93, 56)
        Me.gbxPago.TabIndex = 34
        Me.gbxPago.TabStop = False
        Me.gbxPago.Text = "Financiacion"
        '
        'rdbContado
        '
        Me.rdbContado.AutoSize = True
        Me.rdbContado.Location = New System.Drawing.Point(10, 33)
        Me.rdbContado.Name = "rdbContado"
        Me.rdbContado.Size = New System.Drawing.Size(70, 17)
        Me.rdbContado.TabIndex = 1
        Me.rdbContado.TabStop = True
        Me.rdbContado.Text = "Contado"
        Me.rdbContado.UseVisualStyleBackColor = True
        '
        'rdbCuotas
        '
        Me.rdbCuotas.AutoSize = True
        Me.rdbCuotas.Location = New System.Drawing.Point(10, 15)
        Me.rdbCuotas.Name = "rdbCuotas"
        Me.rdbCuotas.Size = New System.Drawing.Size(61, 17)
        Me.rdbCuotas.TabIndex = 0
        Me.rdbCuotas.TabStop = True
        Me.rdbCuotas.Text = "Cuotas"
        Me.rdbCuotas.UseVisualStyleBackColor = True
        '
        'lblCompraTotal
        '
        Me.lblCompraTotal.AutoSize = True
        Me.lblCompraTotal.Location = New System.Drawing.Point(86, 14)
        Me.lblCompraTotal.Name = "lblCompraTotal"
        Me.lblCompraTotal.Size = New System.Drawing.Size(127, 13)
        Me.lblCompraTotal.TabIndex = 35
        Me.lblCompraTotal.Text = "Seleccione financiacion"
        Me.lblCompraTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcantsemanasalq
        '
        Me.lblcantsemanasalq.AutoSize = True
        Me.lblcantsemanasalq.Location = New System.Drawing.Point(5, 15)
        Me.lblcantsemanasalq.Name = "lblcantsemanasalq"
        Me.lblcantsemanasalq.Size = New System.Drawing.Size(177, 13)
        Me.lblcantsemanasalq.TabIndex = 38
        Me.lblcantsemanasalq.Text = "Cantidad de Semanas de Alquiler"
        Me.lblcantsemanasalq.Visible = False
        '
        'lblTotalSem
        '
        Me.lblTotalSem.AutoSize = True
        Me.lblTotalSem.Location = New System.Drawing.Point(249, 6)
        Me.lblTotalSem.Name = "lblTotalSem"
        Me.lblTotalSem.Size = New System.Drawing.Size(96, 13)
        Me.lblTotalSem.TabIndex = 39
        Me.lblTotalSem.Text = "Importe Semanal:"
        Me.lblTotalSem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(263, 24)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(83, 13)
        Me.lblTotal.TabIndex = 36
        Me.lblTotal.Text = "Importe Total : "
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numCantSemanas
        '
        Me.numCantSemanas.Location = New System.Drawing.Point(190, 13)
        Me.numCantSemanas.Name = "numCantSemanas"
        Me.numCantSemanas.Size = New System.Drawing.Size(48, 22)
        Me.numCantSemanas.TabIndex = 37
        Me.numCantSemanas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numCantSemanas.Visible = False
        '
        'pnlAlquiler
        '
        Me.pnlAlquiler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAlquiler.Controls.Add(Me.lblcantsemanasalq)
        Me.pnlAlquiler.Controls.Add(Me.numCantSemanas)
        Me.pnlAlquiler.Controls.Add(Me.lblTotalSem)
        Me.pnlAlquiler.Controls.Add(Me.lblTotal)
        Me.pnlAlquiler.Location = New System.Drawing.Point(12, 274)
        Me.pnlAlquiler.Name = "pnlAlquiler"
        Me.pnlAlquiler.Size = New System.Drawing.Size(321, 45)
        Me.pnlAlquiler.TabIndex = 40
        Me.pnlAlquiler.Visible = False
        '
        'pnlCompra
        '
        Me.pnlCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCompra.Controls.Add(Me.lblCuotas)
        Me.pnlCompra.Controls.Add(Me.numCuotas)
        Me.pnlCompra.Controls.Add(Me.lblCompraTotal)
        Me.pnlCompra.Location = New System.Drawing.Point(12, 274)
        Me.pnlCompra.Name = "pnlCompra"
        Me.pnlCompra.Size = New System.Drawing.Size(321, 45)
        Me.pnlCompra.TabIndex = 41
        Me.pnlCompra.Visible = False
        '
        'lblCuotas
        '
        Me.lblCuotas.AutoSize = True
        Me.lblCuotas.Location = New System.Drawing.Point(4, 15)
        Me.lblCuotas.Name = "lblCuotas"
        Me.lblCuotas.Size = New System.Drawing.Size(43, 13)
        Me.lblCuotas.TabIndex = 37
        Me.lblCuotas.Text = "Cuotas"
        Me.lblCuotas.Visible = False
        '
        'numCuotas
        '
        Me.numCuotas.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.numCuotas.Location = New System.Drawing.Point(49, 11)
        Me.numCuotas.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.numCuotas.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.numCuotas.Name = "numCuotas"
        Me.numCuotas.Size = New System.Drawing.Size(31, 22)
        Me.numCuotas.TabIndex = 36
        Me.numCuotas.Value = New Decimal(New Integer() {2, 0, 0, 0})
        Me.numCuotas.Visible = False
        '
        'btnCorredor
        '
        Me.btnCorredor.Enabled = False
        Me.btnCorredor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCorredor.Location = New System.Drawing.Point(516, 274)
        Me.btnCorredor.Name = "btnCorredor"
        Me.btnCorredor.Size = New System.Drawing.Size(115, 45)
        Me.btnCorredor.TabIndex = 42
        Me.btnCorredor.Text = "Seleccionar corredor"
        Me.btnCorredor.UseVisualStyleBackColor = True
        '
        'gbxEnvio
        '
        Me.gbxEnvio.Controls.Add(Me.rdbEnvioNo)
        Me.gbxEnvio.Controls.Add(Me.rdbEnvioSI)
        Me.gbxEnvio.Location = New System.Drawing.Point(339, 267)
        Me.gbxEnvio.Name = "gbxEnvio"
        Me.gbxEnvio.Size = New System.Drawing.Size(70, 56)
        Me.gbxEnvio.TabIndex = 35
        Me.gbxEnvio.TabStop = False
        Me.gbxEnvio.Text = "Envio"
        '
        'rdbEnvioNo
        '
        Me.rdbEnvioNo.AutoSize = True
        Me.rdbEnvioNo.Location = New System.Drawing.Point(10, 33)
        Me.rdbEnvioNo.Name = "rdbEnvioNo"
        Me.rdbEnvioNo.Size = New System.Drawing.Size(40, 17)
        Me.rdbEnvioNo.TabIndex = 1
        Me.rdbEnvioNo.Text = "No"
        Me.rdbEnvioNo.UseVisualStyleBackColor = True
        '
        'rdbEnvioSI
        '
        Me.rdbEnvioSI.AutoSize = True
        Me.rdbEnvioSI.Checked = True
        Me.rdbEnvioSI.Location = New System.Drawing.Point(10, 15)
        Me.rdbEnvioSI.Name = "rdbEnvioSI"
        Me.rdbEnvioSI.Size = New System.Drawing.Size(34, 17)
        Me.rdbEnvioSI.TabIndex = 0
        Me.rdbEnvioSI.TabStop = True
        Me.rdbEnvioSI.Text = "Si"
        Me.rdbEnvioSI.UseVisualStyleBackColor = True
        '
        'Facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(773, 329)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbxEnvio)
        Me.Controls.Add(Me.btnCorredor)
        Me.Controls.Add(Me.gbxPago)
        Me.Controls.Add(Me.btnConfirmarOperacion)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.lblCod)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblFacturacion)
        Me.Controls.Add(Me.lstCompra)
        Me.Controls.Add(Me.pnlCompra)
        Me.Controls.Add(Me.pnlAlquiler)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Facturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturacion"
        Me.TopMost = True
        Me.gbxPago.ResumeLayout(False)
        Me.gbxPago.PerformLayout()
        CType(Me.numCantSemanas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAlquiler.ResumeLayout(False)
        Me.pnlAlquiler.PerformLayout()
        Me.pnlCompra.ResumeLayout(False)
        Me.pnlCompra.PerformLayout()
        CType(Me.numCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxEnvio.ResumeLayout(False)
        Me.gbxEnvio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFacturacion As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents lblCod As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lstCompra As System.Windows.Forms.ListView
    Friend WithEvents ClibroTitulo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClibroAutor As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClibroEditorial As System.Windows.Forms.ColumnHeader
    Friend WithEvents CantLibros As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstPrecio As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnConfirmarOperacion As System.Windows.Forms.Button
    Friend WithEvents CodLibro As System.Windows.Forms.ColumnHeader
    Friend WithEvents gbxPago As System.Windows.Forms.GroupBox
    Friend WithEvents rdbContado As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCuotas As System.Windows.Forms.RadioButton
    Friend WithEvents lblCompraTotal As System.Windows.Forms.Label
    Friend WithEvents lblcantsemanasalq As System.Windows.Forms.Label
    Friend WithEvents lblTotalSem As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents numCantSemanas As System.Windows.Forms.NumericUpDown
    Friend WithEvents pnlAlquiler As System.Windows.Forms.Panel
    Friend WithEvents pnlCompra As System.Windows.Forms.Panel
    Friend WithEvents lblCuotas As System.Windows.Forms.Label
    Friend WithEvents numCuotas As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnCorredor As System.Windows.Forms.Button
    Friend WithEvents gbxEnvio As System.Windows.Forms.GroupBox
    Friend WithEvents rdbEnvioNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdbEnvioSI As System.Windows.Forms.RadioButton
End Class

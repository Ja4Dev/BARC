<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComprasSocio
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
        Me.lstOperacion = New System.Windows.Forms.ListView()
        Me.CompAlqCod = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CompFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CompEstado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CompTipoPago = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CompCantPagos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblCompAlq = New System.Windows.Forms.Label()
        Me.lstDetalleCompra = New System.Windows.Forms.ListView()
        Me.CompLibro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CompAutor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CompEditorial = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CompCantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CompPrecioUnitario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblFlechas = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblSocio = New System.Windows.Forms.Label()
        Me.lstDetalleAlquiler = New System.Windows.Forms.ListView()
        Me.AlqLibro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AlqAutor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AlqEditorial = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AlqCantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AlqPrecSem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblDevolucion = New System.Windows.Forms.Label()
        Me.lblTope = New System.Windows.Forms.Label()
        Me.lblPrecioSemanal = New System.Windows.Forms.Label()
        Me.lblCantSemanas = New System.Windows.Forms.Label()
        Me.lblCorredor = New System.Windows.Forms.Label()
        Me.gbxOperacion = New System.Windows.Forms.GroupBox()
        Me.rdbCompras = New System.Windows.Forms.RadioButton()
        Me.rdbAlquileres = New System.Windows.Forms.RadioButton()
        Me.btnComprasDocumentos = New System.Windows.Forms.Button()
        Me.lstAlquileres = New System.Windows.Forms.ListView()
        Me.AlqID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AlqFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AlqEstado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnCambEstado = New System.Windows.Forms.Button()
        Me.lblVencimientoPagoAlq = New System.Windows.Forms.Label()
        Me.btnDevolverLibro = New System.Windows.Forms.Button()
        Me.gbxOperacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Location = New System.Drawing.Point(1201, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 3
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lstOperacion
        '
        Me.lstOperacion.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CompAlqCod, Me.CompFecha, Me.CompEstado, Me.CompTipoPago, Me.CompCantPagos})
        Me.lstOperacion.FullRowSelect = True
        Me.lstOperacion.Location = New System.Drawing.Point(12, 63)
        Me.lstOperacion.Name = "lstOperacion"
        Me.lstOperacion.Size = New System.Drawing.Size(433, 264)
        Me.lstOperacion.TabIndex = 4
        Me.lstOperacion.UseCompatibleStateImageBehavior = False
        Me.lstOperacion.View = System.Windows.Forms.View.Details
        '
        'CompAlqCod
        '
        Me.CompAlqCod.Text = "#"
        Me.CompAlqCod.Width = 56
        '
        'CompFecha
        '
        Me.CompFecha.Text = "Fecha Compra"
        Me.CompFecha.Width = 112
        '
        'CompEstado
        '
        Me.CompEstado.Text = "Estado"
        '
        'CompTipoPago
        '
        Me.CompTipoPago.Text = "Tipo de Pago"
        Me.CompTipoPago.Width = 92
        '
        'CompCantPagos
        '
        Me.CompCantPagos.Text = "Cant Pagos"
        Me.CompCantPagos.Width = 91
        '
        'lblCompAlq
        '
        Me.lblCompAlq.AutoSize = True
        Me.lblCompAlq.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.lblCompAlq.Location = New System.Drawing.Point(12, 9)
        Me.lblCompAlq.Name = "lblCompAlq"
        Me.lblCompAlq.Size = New System.Drawing.Size(331, 46)
        Me.lblCompAlq.TabIndex = 9
        Me.lblCompAlq.Text = "Compras / Alquileres"
        Me.lblCompAlq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstDetalleCompra
        '
        Me.lstDetalleCompra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstDetalleCompra.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CompLibro, Me.CompAutor, Me.CompEditorial, Me.CompCantidad, Me.CompPrecioUnitario})
        Me.lstDetalleCompra.FullRowSelect = True
        Me.lstDetalleCompra.Location = New System.Drawing.Point(476, 63)
        Me.lstDetalleCompra.Name = "lstDetalleCompra"
        Me.lstDetalleCompra.Size = New System.Drawing.Size(750, 264)
        Me.lstDetalleCompra.TabIndex = 10
        Me.lstDetalleCompra.UseCompatibleStateImageBehavior = False
        Me.lstDetalleCompra.View = System.Windows.Forms.View.Details
        '
        'CompLibro
        '
        Me.CompLibro.Text = "Libro"
        Me.CompLibro.Width = 241
        '
        'CompAutor
        '
        Me.CompAutor.Text = "Autor"
        Me.CompAutor.Width = 179
        '
        'CompEditorial
        '
        Me.CompEditorial.Text = "Editorial"
        Me.CompEditorial.Width = 177
        '
        'CompCantidad
        '
        Me.CompCantidad.Text = "Cantidad"
        Me.CompCantidad.Width = 58
        '
        'CompPrecioUnitario
        '
        Me.CompPrecioUnitario.Text = "Precio Unitario"
        Me.CompPrecioUnitario.Width = 90
        '
        'lblFlechas
        '
        Me.lblFlechas.AutoSize = True
        Me.lblFlechas.Location = New System.Drawing.Point(451, 149)
        Me.lblFlechas.Name = "lblFlechas"
        Me.lblFlechas.Size = New System.Drawing.Size(16, 65)
        Me.lblFlechas.TabIndex = 11
        Me.lblFlechas.Text = "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(12, 338)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(142, 13)
        Me.lblTotal.TabIndex = 12
        Me.lblTotal.Text = "Importe total del Alquiler: "
        '
        'lblSocio
        '
        Me.lblSocio.AutoSize = True
        Me.lblSocio.Location = New System.Drawing.Point(249, 338)
        Me.lblSocio.Name = "lblSocio"
        Me.lblSocio.Size = New System.Drawing.Size(44, 13)
        Me.lblSocio.TabIndex = 13
        Me.lblSocio.Text = "Socio : "
        '
        'lstDetalleAlquiler
        '
        Me.lstDetalleAlquiler.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstDetalleAlquiler.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.AlqLibro, Me.AlqAutor, Me.AlqEditorial, Me.AlqCantidad, Me.AlqPrecSem})
        Me.lstDetalleAlquiler.FullRowSelect = True
        Me.lstDetalleAlquiler.Location = New System.Drawing.Point(476, 63)
        Me.lstDetalleAlquiler.Name = "lstDetalleAlquiler"
        Me.lstDetalleAlquiler.Size = New System.Drawing.Size(750, 264)
        Me.lstDetalleAlquiler.TabIndex = 14
        Me.lstDetalleAlquiler.UseCompatibleStateImageBehavior = False
        Me.lstDetalleAlquiler.View = System.Windows.Forms.View.Details
        Me.lstDetalleAlquiler.Visible = False
        '
        'AlqLibro
        '
        Me.AlqLibro.Text = "Libro"
        Me.AlqLibro.Width = 215
        '
        'AlqAutor
        '
        Me.AlqAutor.Text = "Autor"
        Me.AlqAutor.Width = 178
        '
        'AlqEditorial
        '
        Me.AlqEditorial.Text = "Editorial"
        Me.AlqEditorial.Width = 147
        '
        'AlqCantidad
        '
        Me.AlqCantidad.Text = "Cantidad"
        Me.AlqCantidad.Width = 68
        '
        'AlqPrecSem
        '
        Me.AlqPrecSem.Text = "Precio Unitario Semanal"
        Me.AlqPrecSem.Width = 134
        '
        'lblDevolucion
        '
        Me.lblDevolucion.AutoSize = True
        Me.lblDevolucion.Location = New System.Drawing.Point(249, 371)
        Me.lblDevolucion.Name = "lblDevolucion"
        Me.lblDevolucion.Size = New System.Drawing.Size(120, 13)
        Me.lblDevolucion.TabIndex = 15
        Me.lblDevolucion.Text = "Fecha de Devolución: "
        Me.lblDevolucion.Visible = False
        '
        'lblTope
        '
        Me.lblTope.AutoSize = True
        Me.lblTope.Location = New System.Drawing.Point(12, 387)
        Me.lblTope.Name = "lblTope"
        Me.lblTope.Size = New System.Drawing.Size(133, 13)
        Me.lblTope.TabIndex = 16
        Me.lblTope.Text = "Fecha Tope del Alquiler: "
        Me.lblTope.Visible = False
        '
        'lblPrecioSemanal
        '
        Me.lblPrecioSemanal.AutoSize = True
        Me.lblPrecioSemanal.Location = New System.Drawing.Point(12, 354)
        Me.lblPrecioSemanal.Name = "lblPrecioSemanal"
        Me.lblPrecioSemanal.Size = New System.Drawing.Size(152, 13)
        Me.lblPrecioSemanal.TabIndex = 17
        Me.lblPrecioSemanal.Text = "Precio Semanal del Alquiler: "
        '
        'lblCantSemanas
        '
        Me.lblCantSemanas.AutoSize = True
        Me.lblCantSemanas.Location = New System.Drawing.Point(12, 371)
        Me.lblCantSemanas.Name = "lblCantSemanas"
        Me.lblCantSemanas.Size = New System.Drawing.Size(183, 13)
        Me.lblCantSemanas.TabIndex = 18
        Me.lblCantSemanas.Text = "Cantidad de Semanas de Alquiler: "
        '
        'lblCorredor
        '
        Me.lblCorredor.AutoSize = True
        Me.lblCorredor.Location = New System.Drawing.Point(249, 354)
        Me.lblCorredor.Name = "lblCorredor"
        Me.lblCorredor.Size = New System.Drawing.Size(59, 13)
        Me.lblCorredor.TabIndex = 19
        Me.lblCorredor.Text = "Corredor :"
        '
        'gbxOperacion
        '
        Me.gbxOperacion.Controls.Add(Me.rdbCompras)
        Me.gbxOperacion.Controls.Add(Me.rdbAlquileres)
        Me.gbxOperacion.Enabled = False
        Me.gbxOperacion.Location = New System.Drawing.Point(12, 407)
        Me.gbxOperacion.Name = "gbxOperacion"
        Me.gbxOperacion.Size = New System.Drawing.Size(193, 46)
        Me.gbxOperacion.TabIndex = 21
        Me.gbxOperacion.TabStop = False
        Me.gbxOperacion.Text = "Operacion"
        Me.gbxOperacion.Visible = False
        '
        'rdbCompras
        '
        Me.rdbCompras.AutoSize = True
        Me.rdbCompras.Location = New System.Drawing.Point(102, 17)
        Me.rdbCompras.Name = "rdbCompras"
        Me.rdbCompras.Size = New System.Drawing.Size(70, 17)
        Me.rdbCompras.TabIndex = 1
        Me.rdbCompras.Text = "Compras"
        Me.rdbCompras.UseVisualStyleBackColor = True
        '
        'rdbAlquileres
        '
        Me.rdbAlquileres.AutoSize = True
        Me.rdbAlquileres.Location = New System.Drawing.Point(20, 17)
        Me.rdbAlquileres.Name = "rdbAlquileres"
        Me.rdbAlquileres.Size = New System.Drawing.Size(76, 17)
        Me.rdbAlquileres.TabIndex = 0
        Me.rdbAlquileres.Text = "Alquileres"
        Me.rdbAlquileres.UseVisualStyleBackColor = True
        '
        'btnComprasDocumentos
        '
        Me.btnComprasDocumentos.Enabled = False
        Me.btnComprasDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnComprasDocumentos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprasDocumentos.Location = New System.Drawing.Point(252, 409)
        Me.btnComprasDocumentos.Name = "btnComprasDocumentos"
        Me.btnComprasDocumentos.Size = New System.Drawing.Size(193, 46)
        Me.btnComprasDocumentos.TabIndex = 22
        Me.btnComprasDocumentos.Text = "Ver Factura"
        Me.btnComprasDocumentos.UseVisualStyleBackColor = True
        '
        'lstAlquileres
        '
        Me.lstAlquileres.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.AlqID, Me.AlqFecha, Me.AlqEstado})
        Me.lstAlquileres.FullRowSelect = True
        Me.lstAlquileres.Location = New System.Drawing.Point(12, 63)
        Me.lstAlquileres.Name = "lstAlquileres"
        Me.lstAlquileres.Size = New System.Drawing.Size(433, 264)
        Me.lstAlquileres.TabIndex = 25
        Me.lstAlquileres.UseCompatibleStateImageBehavior = False
        Me.lstAlquileres.View = System.Windows.Forms.View.Details
        '
        'AlqID
        '
        Me.AlqID.Text = "#"
        Me.AlqID.Width = 56
        '
        'AlqFecha
        '
        Me.AlqFecha.Text = "Fecha Compra"
        Me.AlqFecha.Width = 112
        '
        'AlqEstado
        '
        Me.AlqEstado.Text = "Estado"
        Me.AlqEstado.Width = 243
        '
        'btnCambEstado
        '
        Me.btnCambEstado.Enabled = False
        Me.btnCambEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCambEstado.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambEstado.Location = New System.Drawing.Point(476, 333)
        Me.btnCambEstado.Name = "btnCambEstado"
        Me.btnCambEstado.Size = New System.Drawing.Size(360, 122)
        Me.btnCambEstado.TabIndex = 26
        Me.btnCambEstado.Text = "Registrar Pago"
        Me.btnCambEstado.UseVisualStyleBackColor = True
        Me.btnCambEstado.Visible = False
        '
        'lblVencimientoPagoAlq
        '
        Me.lblVencimientoPagoAlq.AutoSize = True
        Me.lblVencimientoPagoAlq.Location = New System.Drawing.Point(249, 387)
        Me.lblVencimientoPagoAlq.Name = "lblVencimientoPagoAlq"
        Me.lblVencimientoPagoAlq.Size = New System.Drawing.Size(125, 13)
        Me.lblVencimientoPagoAlq.TabIndex = 27
        Me.lblVencimientoPagoAlq.Text = "Fecha de Vencimiento: "
        Me.lblVencimientoPagoAlq.Visible = False
        '
        'btnDevolverLibro
        '
        Me.btnDevolverLibro.Enabled = False
        Me.btnDevolverLibro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDevolverLibro.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDevolverLibro.Location = New System.Drawing.Point(866, 333)
        Me.btnDevolverLibro.Name = "btnDevolverLibro"
        Me.btnDevolverLibro.Size = New System.Drawing.Size(360, 122)
        Me.btnDevolverLibro.TabIndex = 28
        Me.btnDevolverLibro.Text = "Registrar Devolucion"
        Me.btnDevolverLibro.UseVisualStyleBackColor = True
        Me.btnDevolverLibro.Visible = False
        '
        'ComprasSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1238, 465)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnDevolverLibro)
        Me.Controls.Add(Me.lblVencimientoPagoAlq)
        Me.Controls.Add(Me.btnCambEstado)
        Me.Controls.Add(Me.btnComprasDocumentos)
        Me.Controls.Add(Me.gbxOperacion)
        Me.Controls.Add(Me.lblCorredor)
        Me.Controls.Add(Me.lblCantSemanas)
        Me.Controls.Add(Me.lblPrecioSemanal)
        Me.Controls.Add(Me.lblTope)
        Me.Controls.Add(Me.lblDevolucion)
        Me.Controls.Add(Me.lblSocio)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblFlechas)
        Me.Controls.Add(Me.lblCompAlq)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lstDetalleCompra)
        Me.Controls.Add(Me.lstDetalleAlquiler)
        Me.Controls.Add(Me.lstOperacion)
        Me.Controls.Add(Me.lstAlquileres)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ComprasSocio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras - Alquileres"
        Me.TopMost = True
        Me.gbxOperacion.ResumeLayout(False)
        Me.gbxOperacion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lstOperacion As System.Windows.Forms.ListView
    Friend WithEvents CompAlqCod As System.Windows.Forms.ColumnHeader
    Friend WithEvents CompFecha As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblCompAlq As System.Windows.Forms.Label
    Friend WithEvents lstDetalleCompra As System.Windows.Forms.ListView
    Friend WithEvents CompLibro As System.Windows.Forms.ColumnHeader
    Friend WithEvents CompCantidad As System.Windows.Forms.ColumnHeader
    Friend WithEvents CompPrecioUnitario As System.Windows.Forms.ColumnHeader
    Friend WithEvents CompAutor As System.Windows.Forms.ColumnHeader
    Friend WithEvents CompEditorial As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblFlechas As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblSocio As System.Windows.Forms.Label
    Friend WithEvents lstDetalleAlquiler As System.Windows.Forms.ListView
    Friend WithEvents AlqLibro As System.Windows.Forms.ColumnHeader
    Friend WithEvents AlqAutor As System.Windows.Forms.ColumnHeader
    Friend WithEvents AlqEditorial As System.Windows.Forms.ColumnHeader
    Friend WithEvents AlqCantidad As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblDevolucion As System.Windows.Forms.Label
    Friend WithEvents lblTope As System.Windows.Forms.Label
    Friend WithEvents CompEstado As System.Windows.Forms.ColumnHeader
    Friend WithEvents AlqPrecSem As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblPrecioSemanal As System.Windows.Forms.Label
    Friend WithEvents lblCantSemanas As System.Windows.Forms.Label
    Friend WithEvents lblCorredor As System.Windows.Forms.Label
    Friend WithEvents gbxOperacion As System.Windows.Forms.GroupBox
    Friend WithEvents rdbCompras As System.Windows.Forms.RadioButton
    Friend WithEvents rdbAlquileres As System.Windows.Forms.RadioButton
    Friend WithEvents btnComprasDocumentos As System.Windows.Forms.Button
    Friend WithEvents CompTipoPago As System.Windows.Forms.ColumnHeader
    Friend WithEvents CompCantPagos As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstAlquileres As System.Windows.Forms.ListView
    Friend WithEvents AlqID As System.Windows.Forms.ColumnHeader
    Friend WithEvents AlqFecha As System.Windows.Forms.ColumnHeader
    Friend WithEvents AlqEstado As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCambEstado As System.Windows.Forms.Button
    Friend WithEvents lblVencimientoPagoAlq As System.Windows.Forms.Label
    Friend WithEvents btnDevolverLibro As System.Windows.Forms.Button
End Class

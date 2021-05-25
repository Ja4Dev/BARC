<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Libros
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
        Me.lstLibros = New System.Windows.Forms.ListView()
        Me.codLibro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.libroTitulo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.libroAutor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.btnSolitudes = New System.Windows.Forms.Button()
        Me.btnVerComprobantes = New System.Windows.Forms.Button()
        Me.btnEjemplares = New System.Windows.Forms.Button()
        Me.btnNotaPedido = New System.Windows.Forms.Button()
        Me.lblFechaPublicacion = New System.Windows.Forms.Label()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.lblPrecioVenta = New System.Windows.Forms.Label()
        Me.lblEditorial = New System.Windows.Forms.Label()
        Me.lblPrecioAlquiler = New System.Windows.Forms.Label()
        Me.lblSocios = New System.Windows.Forms.Label()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnBack.Location = New System.Drawing.Point(525, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 3
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lstLibros
        '
        Me.lstLibros.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codLibro, Me.libroTitulo, Me.libroAutor})
        Me.lstLibros.FullRowSelect = True
        Me.lstLibros.Location = New System.Drawing.Point(12, 177)
        Me.lstLibros.Name = "lstLibros"
        Me.lstLibros.Size = New System.Drawing.Size(538, 225)
        Me.lstLibros.TabIndex = 4
        Me.lstLibros.UseCompatibleStateImageBehavior = False
        Me.lstLibros.View = System.Windows.Forms.View.Details
        '
        'codLibro
        '
        Me.codLibro.Text = "#"
        Me.codLibro.Width = 46
        '
        'libroTitulo
        '
        Me.libroTitulo.Text = "Titulo"
        Me.libroTitulo.Width = 288
        '
        'libroAutor
        '
        Me.libroAutor.Text = "Autor"
        Me.libroAutor.Width = 200
        '
        'btnActualizar
        '
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnActualizar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnActualizar.Location = New System.Drawing.Point(12, 65)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(175, 50)
        Me.btnActualizar.TabIndex = 8
        Me.btnActualizar.Text = "Actualizar Stock"
        Me.btnActualizar.UseVisualStyleBackColor = True
        Me.btnActualizar.Visible = False
        '
        'btnSolicitar
        '
        Me.btnSolicitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSolicitar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSolicitar.Location = New System.Drawing.Point(194, 65)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(175, 50)
        Me.btnSolicitar.TabIndex = 9
        Me.btnSolicitar.Text = "Solicitar Compra"
        Me.btnSolicitar.UseVisualStyleBackColor = True
        Me.btnSolicitar.Visible = False
        '
        'btnSolitudes
        '
        Me.btnSolitudes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSolitudes.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSolitudes.Location = New System.Drawing.Point(375, 65)
        Me.btnSolitudes.Name = "btnSolitudes"
        Me.btnSolitudes.Size = New System.Drawing.Size(175, 50)
        Me.btnSolitudes.TabIndex = 10
        Me.btnSolitudes.Text = "Solicitudes Realizadas"
        Me.btnSolitudes.UseVisualStyleBackColor = True
        Me.btnSolitudes.Visible = False
        '
        'btnVerComprobantes
        '
        Me.btnVerComprobantes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVerComprobantes.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnVerComprobantes.Location = New System.Drawing.Point(194, 121)
        Me.btnVerComprobantes.Name = "btnVerComprobantes"
        Me.btnVerComprobantes.Size = New System.Drawing.Size(175, 50)
        Me.btnVerComprobantes.TabIndex = 11
        Me.btnVerComprobantes.Text = "Comprobantes de Entrada"
        Me.btnVerComprobantes.UseVisualStyleBackColor = True
        Me.btnVerComprobantes.Visible = False
        '
        'btnEjemplares
        '
        Me.btnEjemplares.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEjemplares.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnEjemplares.Location = New System.Drawing.Point(375, 121)
        Me.btnEjemplares.Name = "btnEjemplares"
        Me.btnEjemplares.Size = New System.Drawing.Size(175, 50)
        Me.btnEjemplares.TabIndex = 12
        Me.btnEjemplares.Text = "Lista de Ejemplares"
        Me.btnEjemplares.UseVisualStyleBackColor = True
        Me.btnEjemplares.Visible = False
        '
        'btnNotaPedido
        '
        Me.btnNotaPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNotaPedido.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnNotaPedido.Location = New System.Drawing.Point(12, 121)
        Me.btnNotaPedido.Name = "btnNotaPedido"
        Me.btnNotaPedido.Size = New System.Drawing.Size(175, 50)
        Me.btnNotaPedido.TabIndex = 13
        Me.btnNotaPedido.Text = "Notas de Pedido"
        Me.btnNotaPedido.UseVisualStyleBackColor = True
        Me.btnNotaPedido.Visible = False
        '
        'lblFechaPublicacion
        '
        Me.lblFechaPublicacion.AutoSize = True
        Me.lblFechaPublicacion.Location = New System.Drawing.Point(12, 419)
        Me.lblFechaPublicacion.Name = "lblFechaPublicacion"
        Me.lblFechaPublicacion.Size = New System.Drawing.Size(113, 13)
        Me.lblFechaPublicacion.TabIndex = 14
        Me.lblFechaPublicacion.Text = "Año de publicacion :"
        Me.lblFechaPublicacion.Visible = False
        '
        'lblISBN
        '
        Me.lblISBN.AutoSize = True
        Me.lblISBN.Location = New System.Drawing.Point(12, 446)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(36, 13)
        Me.lblISBN.TabIndex = 15
        Me.lblISBN.Text = "ISBN :"
        Me.lblISBN.Visible = False
        '
        'lblPrecioVenta
        '
        Me.lblPrecioVenta.AutoSize = True
        Me.lblPrecioVenta.Location = New System.Drawing.Point(216, 419)
        Me.lblPrecioVenta.Name = "lblPrecioVenta"
        Me.lblPrecioVenta.Size = New System.Drawing.Size(92, 13)
        Me.lblPrecioVenta.TabIndex = 16
        Me.lblPrecioVenta.Text = "Precio de Venta :"
        Me.lblPrecioVenta.Visible = False
        '
        'lblEditorial
        '
        Me.lblEditorial.AutoSize = True
        Me.lblEditorial.Location = New System.Drawing.Point(216, 446)
        Me.lblEditorial.Name = "lblEditorial"
        Me.lblEditorial.Size = New System.Drawing.Size(56, 13)
        Me.lblEditorial.TabIndex = 17
        Me.lblEditorial.Text = "Editorial :"
        Me.lblEditorial.Visible = False
        '
        'lblPrecioAlquiler
        '
        Me.lblPrecioAlquiler.AutoSize = True
        Me.lblPrecioAlquiler.Location = New System.Drawing.Point(387, 419)
        Me.lblPrecioAlquiler.Name = "lblPrecioAlquiler"
        Me.lblPrecioAlquiler.Size = New System.Drawing.Size(103, 13)
        Me.lblPrecioAlquiler.TabIndex = 18
        Me.lblPrecioAlquiler.Text = "Precio de Alquiler :"
        Me.lblPrecioAlquiler.Visible = False
        '
        'lblSocios
        '
        Me.lblSocios.AutoSize = True
        Me.lblSocios.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.lblSocios.Location = New System.Drawing.Point(12, 9)
        Me.lblSocios.Name = "lblSocios"
        Me.lblSocios.Size = New System.Drawing.Size(110, 46)
        Me.lblSocios.TabIndex = 19
        Me.lblSocios.Text = "Libros"
        Me.lblSocios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Location = New System.Drawing.Point(229, 432)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(105, 13)
        Me.lblSelect.TabIndex = 20
        Me.lblSelect.Text = "Seleccione un libro"
        '
        'Libros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(562, 478)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.lblSocios)
        Me.Controls.Add(Me.lblPrecioAlquiler)
        Me.Controls.Add(Me.lblEditorial)
        Me.Controls.Add(Me.lblPrecioVenta)
        Me.Controls.Add(Me.lblISBN)
        Me.Controls.Add(Me.lblFechaPublicacion)
        Me.Controls.Add(Me.btnNotaPedido)
        Me.Controls.Add(Me.btnEjemplares)
        Me.Controls.Add(Me.btnSolitudes)
        Me.Controls.Add(Me.btnSolicitar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.lstLibros)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnVerComprobantes)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Libros"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Libros"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lstLibros As System.Windows.Forms.ListView
    Friend WithEvents codLibro As System.Windows.Forms.ColumnHeader
    Friend WithEvents libroTitulo As System.Windows.Forms.ColumnHeader
    Friend WithEvents libroAutor As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnSolicitar As System.Windows.Forms.Button
    Friend WithEvents btnSolitudes As System.Windows.Forms.Button
    Friend WithEvents btnVerComprobantes As System.Windows.Forms.Button
    Friend WithEvents btnEjemplares As System.Windows.Forms.Button
    Friend WithEvents btnNotaPedido As System.Windows.Forms.Button
    Friend WithEvents lblFechaPublicacion As System.Windows.Forms.Label
    Friend WithEvents lblISBN As System.Windows.Forms.Label
    Friend WithEvents lblPrecioVenta As System.Windows.Forms.Label
    Friend WithEvents lblEditorial As System.Windows.Forms.Label
    Friend WithEvents lblPrecioAlquiler As System.Windows.Forms.Label
    Friend WithEvents lblSocios As System.Windows.Forms.Label
    Friend WithEvents lblSelect As System.Windows.Forms.Label
End Class

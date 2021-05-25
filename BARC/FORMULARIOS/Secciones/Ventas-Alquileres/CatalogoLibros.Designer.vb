<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatalogoLibros
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
        Me.lstLibros = New System.Windows.Forms.ListView()
        Me.codLibro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.libroTitulo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.libroAutor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.libroEditorial = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.libroNeJemplares = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.libroPrecio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.lblCatalogo = New System.Windows.Forms.Label()
        Me.lblCod = New System.Windows.Forms.Label()
        Me.lstCompra = New System.Windows.Forms.ListView()
        Me.CcodLibro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClibroTitulo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClibroAutor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClibroEditorial = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CantLibros = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Precio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstLibros
        '
        Me.lstLibros.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstLibros.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codLibro, Me.libroTitulo, Me.libroAutor, Me.libroEditorial, Me.libroNeJemplares, Me.libroPrecio})
        Me.lstLibros.FullRowSelect = True
        Me.lstLibros.Location = New System.Drawing.Point(12, 62)
        Me.lstLibros.Name = "lstLibros"
        Me.lstLibros.Size = New System.Drawing.Size(759, 176)
        Me.lstLibros.TabIndex = 5
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
        Me.libroTitulo.Width = 179
        '
        'libroAutor
        '
        Me.libroAutor.Text = "Autor"
        Me.libroAutor.Width = 178
        '
        'libroEditorial
        '
        Me.libroEditorial.Text = "Editorial"
        Me.libroEditorial.Width = 145
        '
        'libroNeJemplares
        '
        Me.libroNeJemplares.Text = "Cantidad Ejemplares"
        Me.libroNeJemplares.Width = 115
        '
        'libroPrecio
        '
        Me.libroPrecio.Text = "Precio"
        Me.libroPrecio.Width = 92
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Location = New System.Drawing.Point(745, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 15
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregar.Location = New System.Drawing.Point(300, 244)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(25, 25)
        Me.btnAgregar.TabIndex = 17
        Me.btnAgregar.TabStop = False
        Me.btnAgregar.Text = "↓"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnQuitar
        '
        Me.btnQuitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuitar.Enabled = False
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnQuitar.Location = New System.Drawing.Point(452, 244)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(25, 25)
        Me.btnQuitar.TabIndex = 18
        Me.btnQuitar.TabStop = False
        Me.btnQuitar.Text = "↑"
        Me.btnQuitar.UseVisualStyleBackColor = False
        '
        'lblCatalogo
        '
        Me.lblCatalogo.AutoSize = True
        Me.lblCatalogo.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.lblCatalogo.Location = New System.Drawing.Point(12, 9)
        Me.lblCatalogo.Name = "lblCatalogo"
        Me.lblCatalogo.Size = New System.Drawing.Size(301, 46)
        Me.lblCatalogo.TabIndex = 20
        Me.lblCatalogo.Text = "Catalogo de Libros"
        Me.lblCatalogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Location = New System.Drawing.Point(328, 250)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(122, 13)
        Me.lblCod.TabIndex = 21
        Me.lblCod.Text = "Agregar / Quitar libros"
        '
        'lstCompra
        '
        Me.lstCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstCompra.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CcodLibro, Me.ClibroTitulo, Me.ClibroAutor, Me.ClibroEditorial, Me.CantLibros, Me.Precio})
        Me.lstCompra.FullRowSelect = True
        Me.lstCompra.Location = New System.Drawing.Point(12, 275)
        Me.lstCompra.Name = "lstCompra"
        Me.lstCompra.Size = New System.Drawing.Size(759, 176)
        Me.lstCompra.TabIndex = 22
        Me.lstCompra.UseCompatibleStateImageBehavior = False
        Me.lstCompra.View = System.Windows.Forms.View.Details
        '
        'CcodLibro
        '
        Me.CcodLibro.Text = "#"
        Me.CcodLibro.Width = 46
        '
        'ClibroTitulo
        '
        Me.ClibroTitulo.Text = "Titulo"
        Me.ClibroTitulo.Width = 223
        '
        'ClibroAutor
        '
        Me.ClibroAutor.Text = "Autor"
        Me.ClibroAutor.Width = 154
        '
        'ClibroEditorial
        '
        Me.ClibroEditorial.Text = "Editorial"
        Me.ClibroEditorial.Width = 179
        '
        'CantLibros
        '
        Me.CantLibros.Text = "Cantidad"
        Me.CantLibros.Width = 61
        '
        'Precio
        '
        Me.Precio.Text = "Precio"
        Me.Precio.Width = 92
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSiguiente.Enabled = False
        Me.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSiguiente.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSiguiente.Location = New System.Drawing.Point(12, 465)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(758, 40)
        Me.btnSiguiente.TabIndex = 24
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'CatalogoLibros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(782, 517)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.lstCompra)
        Me.Controls.Add(Me.lblCod)
        Me.Controls.Add(Me.lblCatalogo)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lstLibros)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CatalogoLibros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de Libros"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstLibros As System.Windows.Forms.ListView
    Friend WithEvents codLibro As System.Windows.Forms.ColumnHeader
    Friend WithEvents libroTitulo As System.Windows.Forms.ColumnHeader
    Friend WithEvents libroAutor As System.Windows.Forms.ColumnHeader
    Friend WithEvents libroEditorial As System.Windows.Forms.ColumnHeader
    Friend WithEvents libroNeJemplares As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents lblCatalogo As System.Windows.Forms.Label
    Friend WithEvents lblCod As System.Windows.Forms.Label
    Friend WithEvents lstCompra As System.Windows.Forms.ListView
    Friend WithEvents CcodLibro As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClibroTitulo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClibroAutor As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClibroEditorial As System.Windows.Forms.ColumnHeader
    Friend WithEvents CantLibros As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents libroPrecio As System.Windows.Forms.ColumnHeader
    Friend WithEvents Precio As System.Windows.Forms.ColumnHeader
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SolicitarCompra
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
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numCantEjemplares = New System.Windows.Forms.NumericUpDown()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.lstLibros = New System.Windows.Forms.ListView()
        Me.LibroId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LibroISBN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LibroNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LibroCant = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblSolicitar = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbProveedores = New System.Windows.Forms.ComboBox()
        CType(Me.numCantEjemplares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnBack.Location = New System.Drawing.Point(841, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 4
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnGenerar.Enabled = False
        Me.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGenerar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnGenerar.Location = New System.Drawing.Point(12, 245)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(267, 36)
        Me.btnGenerar.TabIndex = 31
        Me.btnGenerar.Text = "Generar Solicitud"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 15)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Cantidad de Ejemplares"
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnAgregar.Location = New System.Drawing.Point(12, 168)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(125, 70)
        Me.btnAgregar.TabIndex = 29
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lblISBN
        '
        Me.lblISBN.AutoSize = True
        Me.lblISBN.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblISBN.Location = New System.Drawing.Point(12, 102)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(32, 15)
        Me.lblISBN.TabIndex = 28
        Me.lblISBN.Text = "ISBN"
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(118, 99)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(161, 22)
        Me.txtISBN.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Proveedor"
        '
        'numCantEjemplares
        '
        Me.numCantEjemplares.Location = New System.Drawing.Point(217, 125)
        Me.numCantEjemplares.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numCantEjemplares.Name = "numCantEjemplares"
        Me.numCantEjemplares.Size = New System.Drawing.Size(62, 22)
        Me.numCantEjemplares.TabIndex = 35
        Me.numCantEjemplares.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnQuitar
        '
        Me.btnQuitar.Enabled = False
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnQuitar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnQuitar.Location = New System.Drawing.Point(154, 168)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(125, 70)
        Me.btnQuitar.TabIndex = 36
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'lstLibros
        '
        Me.lstLibros.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lstLibros.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.LibroId, Me.LibroISBN, Me.LibroNombre, Me.LibroCant})
        Me.lstLibros.FullRowSelect = True
        Me.lstLibros.Location = New System.Drawing.Point(297, 44)
        Me.lstLibros.Name = "lstLibros"
        Me.lstLibros.Size = New System.Drawing.Size(569, 237)
        Me.lstLibros.TabIndex = 37
        Me.lstLibros.UseCompatibleStateImageBehavior = False
        Me.lstLibros.View = System.Windows.Forms.View.Details
        '
        'LibroId
        '
        Me.LibroId.Text = "#"
        Me.LibroId.Width = 44
        '
        'LibroISBN
        '
        Me.LibroISBN.Text = "ISBN"
        Me.LibroISBN.Width = 151
        '
        'LibroNombre
        '
        Me.LibroNombre.Text = "Nombre"
        Me.LibroNombre.Width = 298
        '
        'LibroCant
        '
        Me.LibroCant.Text = "Cantidad"
        Me.LibroCant.Width = 70
        '
        'lblSolicitar
        '
        Me.lblSolicitar.AutoSize = True
        Me.lblSolicitar.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.lblSolicitar.Location = New System.Drawing.Point(12, 9)
        Me.lblSolicitar.Name = "lblSolicitar"
        Me.lblSolicitar.Size = New System.Drawing.Size(267, 46)
        Me.lblSolicitar.TabIndex = 38
        Me.lblSolicitar.Text = "Solicitar Compra"
        Me.lblSolicitar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "----------------"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(140, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "----------------"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "------------------"
        '
        'cmbProveedores
        '
        Me.cmbProveedores.FormattingEnabled = True
        Me.cmbProveedores.Location = New System.Drawing.Point(158, 69)
        Me.cmbProveedores.Name = "cmbProveedores"
        Me.cmbProveedores.Size = New System.Drawing.Size(121, 21)
        Me.cmbProveedores.TabIndex = 43
        '
        'SolicitarCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(878, 293)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbProveedores)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSolicitar)
        Me.Controls.Add(Me.lstLibros)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.numCantEjemplares)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblISBN)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "SolicitarCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitar Compra de Libros"
        Me.TopMost = True
        CType(Me.numCantEjemplares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents lblISBN As System.Windows.Forms.Label
    Friend WithEvents txtISBN As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents numCantEjemplares As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents lstLibros As System.Windows.Forms.ListView
    Friend WithEvents LibroId As System.Windows.Forms.ColumnHeader
    Friend WithEvents LibroISBN As System.Windows.Forms.ColumnHeader
    Friend WithEvents LibroNombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents LibroCant As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblSolicitar As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbProveedores As System.Windows.Forms.ComboBox
End Class

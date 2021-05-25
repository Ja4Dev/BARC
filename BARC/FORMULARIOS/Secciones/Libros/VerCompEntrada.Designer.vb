<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerCompEntrada
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstComp = New System.Windows.Forms.ListView()
        Me.CodCompEntrada = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CodNotaPedido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NomProveedorCompE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CodFacturaProv = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CompPagado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblFlechas = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstDetalle = New System.Windows.Forms.ListView()
        Me.IndiceLibro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CompLibro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CompCantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CompPreciounit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnImprimirComp = New System.Windows.Forms.Button()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.btnCheque = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(319, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Comprobantes de Entrada"
        '
        'lstComp
        '
        Me.lstComp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CodCompEntrada, Me.CodNotaPedido, Me.NomProveedorCompE, Me.CodFacturaProv, Me.CompPagado})
        Me.lstComp.FullRowSelect = True
        Me.lstComp.Location = New System.Drawing.Point(12, 104)
        Me.lstComp.Name = "lstComp"
        Me.lstComp.Size = New System.Drawing.Size(533, 326)
        Me.lstComp.TabIndex = 1
        Me.lstComp.UseCompatibleStateImageBehavior = False
        Me.lstComp.View = System.Windows.Forms.View.Details
        '
        'CodCompEntrada
        '
        Me.CodCompEntrada.Text = "#"
        Me.CodCompEntrada.Width = 47
        '
        'CodNotaPedido
        '
        Me.CodNotaPedido.Text = "Num Nota Pedido"
        Me.CodNotaPedido.Width = 111
        '
        'NomProveedorCompE
        '
        Me.NomProveedorCompE.Text = "Proveedor"
        Me.NomProveedorCompE.Width = 159
        '
        'CodFacturaProv
        '
        Me.CodFacturaProv.Text = "Num Factura Proveedor"
        Me.CodFacturaProv.Width = 139
        '
        'CompPagado
        '
        Me.CompPagado.Text = "Pagado"
        Me.CompPagado.Width = 70
        '
        'lblFlechas
        '
        Me.lblFlechas.AutoSize = True
        Me.lblFlechas.Location = New System.Drawing.Point(551, 224)
        Me.lblFlechas.Name = "lblFlechas"
        Me.lblFlechas.Size = New System.Drawing.Size(16, 65)
        Me.lblFlechas.TabIndex = 45
        Me.lblFlechas.Text = "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(172, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 20)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Comprobantes de Entrada"
        '
        'lstDetalle
        '
        Me.lstDetalle.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IndiceLibro, Me.CompLibro, Me.CompCantidad, Me.CompPreciounit})
        Me.lstDetalle.Location = New System.Drawing.Point(575, 104)
        Me.lstDetalle.Name = "lstDetalle"
        Me.lstDetalle.Size = New System.Drawing.Size(402, 326)
        Me.lstDetalle.TabIndex = 47
        Me.lstDetalle.UseCompatibleStateImageBehavior = False
        Me.lstDetalle.View = System.Windows.Forms.View.Details
        '
        'IndiceLibro
        '
        Me.IndiceLibro.Text = "#"
        Me.IndiceLibro.Width = 50
        '
        'CompLibro
        '
        Me.CompLibro.Text = "ISBN Libro"
        Me.CompLibro.Width = 153
        '
        'CompCantidad
        '
        Me.CompCantidad.Text = "Cantidad"
        Me.CompCantidad.Width = 86
        '
        'CompPreciounit
        '
        Me.CompPreciounit.Text = "Precio Unitario"
        Me.CompPreciounit.Width = 97
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(751, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Detalle"
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnBack.Location = New System.Drawing.Point(953, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 49
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnImprimirComp
        '
        Me.btnImprimirComp.Enabled = False
        Me.btnImprimirComp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImprimirComp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimirComp.Location = New System.Drawing.Point(22, 444)
        Me.btnImprimirComp.Name = "btnImprimirComp"
        Me.btnImprimirComp.Size = New System.Drawing.Size(107, 47)
        Me.btnImprimirComp.TabIndex = 50
        Me.btnImprimirComp.Text = "Imprimir Comprobante"
        Me.btnImprimirComp.UseVisualStyleBackColor = True
        '
        'btnPagar
        '
        Me.btnPagar.Enabled = False
        Me.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPagar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.Location = New System.Drawing.Point(146, 444)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(121, 47)
        Me.btnPagar.TabIndex = 51
        Me.btnPagar.Text = "Pagar Factura"
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'btnCheque
        '
        Me.btnCheque.Enabled = False
        Me.btnCheque.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCheque.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheque.Location = New System.Drawing.Point(284, 444)
        Me.btnCheque.Name = "btnCheque"
        Me.btnCheque.Size = New System.Drawing.Size(121, 47)
        Me.btnCheque.TabIndex = 52
        Me.btnCheque.Text = "Ver Cheque"
        Me.btnCheque.UseVisualStyleBackColor = True
        '
        'VerCompEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(990, 503)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCheque)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.btnImprimirComp)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstDetalle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblFlechas)
        Me.Controls.Add(Me.lstComp)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "VerCompEntrada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comprobantes de Entrada"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstComp As System.Windows.Forms.ListView
    Friend WithEvents lblFlechas As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CodCompEntrada As System.Windows.Forms.ColumnHeader
    Friend WithEvents CodNotaPedido As System.Windows.Forms.ColumnHeader
    Friend WithEvents CodFacturaProv As System.Windows.Forms.ColumnHeader
    Friend WithEvents CompPagado As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstDetalle As System.Windows.Forms.ListView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnImprimirComp As System.Windows.Forms.Button
    Friend WithEvents IndiceLibro As System.Windows.Forms.ColumnHeader
    Friend WithEvents CompLibro As System.Windows.Forms.ColumnHeader
    Friend WithEvents CompCantidad As System.Windows.Forms.ColumnHeader
    Friend WithEvents CompPreciounit As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPagar As System.Windows.Forms.Button
    Friend WithEvents NomProveedorCompE As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCheque As System.Windows.Forms.Button
End Class

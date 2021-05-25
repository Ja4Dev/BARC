<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerNotaPedidos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstDetalle = New System.Windows.Forms.ListView()
        Me.IndiceLibro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CompLibro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CompCantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblFlechas = New System.Windows.Forms.Label()
        Me.lstComp = New System.Windows.Forms.ListView()
        Me.CodNotasPedido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NPFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.numSoliciCompraNP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NPEstado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NomProveedorNP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnImprimr = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnBack.Location = New System.Drawing.Point(838, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 50
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 47)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Notas de Pedido"
        '
        'lstDetalle
        '
        Me.lstDetalle.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IndiceLibro, Me.CompLibro, Me.CompCantidad})
        Me.lstDetalle.Location = New System.Drawing.Point(558, 86)
        Me.lstDetalle.Name = "lstDetalle"
        Me.lstDetalle.Size = New System.Drawing.Size(305, 326)
        Me.lstDetalle.TabIndex = 54
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
        Me.CompLibro.Width = 164
        '
        'CompCantidad
        '
        Me.CompCantidad.Text = "Cantidad"
        Me.CompCantidad.Width = 86
        '
        'lblFlechas
        '
        Me.lblFlechas.AutoSize = True
        Me.lblFlechas.Location = New System.Drawing.Point(536, 204)
        Me.lblFlechas.Name = "lblFlechas"
        Me.lblFlechas.Size = New System.Drawing.Size(16, 65)
        Me.lblFlechas.TabIndex = 53
        Me.lblFlechas.Text = "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→"
        '
        'lstComp
        '
        Me.lstComp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CodNotasPedido, Me.NPFecha, Me.numSoliciCompraNP, Me.NPEstado, Me.NomProveedorNP})
        Me.lstComp.FullRowSelect = True
        Me.lstComp.Location = New System.Drawing.Point(12, 86)
        Me.lstComp.Name = "lstComp"
        Me.lstComp.Size = New System.Drawing.Size(518, 326)
        Me.lstComp.TabIndex = 52
        Me.lstComp.UseCompatibleStateImageBehavior = False
        Me.lstComp.View = System.Windows.Forms.View.Details
        '
        'CodNotasPedido
        '
        Me.CodNotasPedido.Text = "#"
        '
        'NPFecha
        '
        Me.NPFecha.Text = "Fecha"
        Me.NPFecha.Width = 115
        '
        'numSoliciCompraNP
        '
        Me.numSoliciCompraNP.Text = "Num Solicitud Compra"
        Me.numSoliciCompraNP.Width = 136
        '
        'NPEstado
        '
        Me.NPEstado.Text = "Estado"
        Me.NPEstado.Width = 78
        '
        'NomProveedorNP
        '
        Me.NomProveedorNP.Text = "Proveedor"
        Me.NomProveedorNP.Width = 123
        '
        'btnImprimr
        '
        Me.btnImprimr.Enabled = False
        Me.btnImprimr.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImprimr.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimr.Location = New System.Drawing.Point(27, 429)
        Me.btnImprimr.Name = "btnImprimr"
        Me.btnImprimr.Size = New System.Drawing.Size(114, 49)
        Me.btnImprimr.TabIndex = 55
        Me.btnImprimr.Text = "Imprimir Nota de Pedido"
        Me.btnImprimr.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(685, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Detalle"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(203, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Notas de Pedido"
        '
        'VerNotaPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(875, 489)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnImprimr)
        Me.Controls.Add(Me.lstDetalle)
        Me.Controls.Add(Me.lblFlechas)
        Me.Controls.Add(Me.lstComp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "VerNotaPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notas de Pedido"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstDetalle As System.Windows.Forms.ListView
    Friend WithEvents IndiceLibro As System.Windows.Forms.ColumnHeader
    Friend WithEvents CompLibro As System.Windows.Forms.ColumnHeader
    Friend WithEvents CompCantidad As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblFlechas As System.Windows.Forms.Label
    Friend WithEvents lstComp As System.Windows.Forms.ListView
    Friend WithEvents CodNotasPedido As System.Windows.Forms.ColumnHeader
    Friend WithEvents NPFecha As System.Windows.Forms.ColumnHeader
    Friend WithEvents numSoliciCompraNP As System.Windows.Forms.ColumnHeader
    Friend WithEvents NPEstado As System.Windows.Forms.ColumnHeader
    Friend WithEvents NomProveedorNP As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnImprimr As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

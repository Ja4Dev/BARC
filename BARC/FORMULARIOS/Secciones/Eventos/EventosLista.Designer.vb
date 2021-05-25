<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventosLista
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
        Me.lstDetalle = New System.Windows.Forms.ListView()
        Me.codsocioEvento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nombresocioevento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblFlechas = New System.Windows.Forms.Label()
        Me.lblMotivo = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.btnComprobante = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblEventos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstEventos
        '
        Me.lstEventos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IdEvento, Me.FechaEvento, Me.NombreEvento})
        Me.lstEventos.FullRowSelect = True
        Me.lstEventos.Location = New System.Drawing.Point(12, 98)
        Me.lstEventos.Name = "lstEventos"
        Me.lstEventos.Size = New System.Drawing.Size(322, 351)
        Me.lstEventos.TabIndex = 0
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
        'lstDetalle
        '
        Me.lstDetalle.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codsocioEvento, Me.nombresocioevento})
        Me.lstDetalle.FullRowSelect = True
        Me.lstDetalle.Location = New System.Drawing.Point(364, 98)
        Me.lstDetalle.Name = "lstDetalle"
        Me.lstDetalle.Size = New System.Drawing.Size(274, 351)
        Me.lstDetalle.TabIndex = 1
        Me.lstDetalle.UseCompatibleStateImageBehavior = False
        Me.lstDetalle.View = System.Windows.Forms.View.Details
        '
        'codsocioEvento
        '
        Me.codsocioEvento.Text = "CodSocio"
        Me.codsocioEvento.Width = 72
        '
        'nombresocioevento
        '
        Me.nombresocioevento.Text = "Nombre y Apellido"
        Me.nombresocioevento.Width = 193
        '
        'lblFlechas
        '
        Me.lblFlechas.AutoSize = True
        Me.lblFlechas.Location = New System.Drawing.Point(340, 206)
        Me.lblFlechas.Name = "lblFlechas"
        Me.lblFlechas.Size = New System.Drawing.Size(16, 65)
        Me.lblFlechas.TabIndex = 44
        Me.lblFlechas.Text = "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→"
        '
        'lblMotivo
        '
        Me.lblMotivo.AutoSize = True
        Me.lblMotivo.Location = New System.Drawing.Point(12, 463)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(49, 13)
        Me.lblMotivo.TabIndex = 45
        Me.lblMotivo.Text = "Motivo: "
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(12, 499)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(73, 13)
        Me.lblDescripcion.TabIndex = 46
        Me.lblDescripcion.Text = "Descripcion: "
        '
        'btnComprobante
        '
        Me.btnComprobante.Enabled = False
        Me.btnComprobante.Location = New System.Drawing.Point(502, 620)
        Me.btnComprobante.Name = "btnComprobante"
        Me.btnComprobante.Size = New System.Drawing.Size(116, 48)
        Me.btnComprobante.TabIndex = 47
        Me.btnComprobante.Text = "Ver Comprobante de Asistencia"
        Me.btnComprobante.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnBack.Location = New System.Drawing.Point(609, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(29, 25)
        Me.btnBack.TabIndex = 48
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblEventos
        '
        Me.lblEventos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEventos.AutoSize = True
        Me.lblEventos.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventos.Location = New System.Drawing.Point(255, 12)
        Me.lblEventos.Name = "lblEventos"
        Me.lblEventos.Size = New System.Drawing.Size(141, 47)
        Me.lblEventos.TabIndex = 49
        Me.lblEventos.Text = "Eventos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 21)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Evento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(426, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 21)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Socios que Asistieron"
        '
        'EventosLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(651, 680)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEventos)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnComprobante)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblMotivo)
        Me.Controls.Add(Me.lblFlechas)
        Me.Controls.Add(Me.lstDetalle)
        Me.Controls.Add(Me.lstEventos)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "EventosLista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EventosLista"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstEventos As System.Windows.Forms.ListView
    Friend WithEvents IdEvento As System.Windows.Forms.ColumnHeader
    Friend WithEvents FechaEvento As System.Windows.Forms.ColumnHeader
    Friend WithEvents NombreEvento As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstDetalle As System.Windows.Forms.ListView
    Friend WithEvents codsocioEvento As System.Windows.Forms.ColumnHeader
    Friend WithEvents nombresocioevento As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblFlechas As System.Windows.Forms.Label
    Friend WithEvents lblMotivo As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents btnComprobante As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblEventos As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

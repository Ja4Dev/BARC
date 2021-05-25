<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SolicitudesEspera
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
        Me.lstSolicitudes = New System.Windows.Forms.ListView()
        Me.SolCompraID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SolCompraFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SolCompraProve = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SolCompraEstado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstDetalle = New System.Windows.Forms.ListView()
        Me.SolDetalleID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SolDetISBN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SolDetLibro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SolDetCantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnDenegar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSolicitar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnBack.Location = New System.Drawing.Point(856, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 5
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lstSolicitudes
        '
        Me.lstSolicitudes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SolCompraID, Me.SolCompraFecha, Me.SolCompraProve, Me.SolCompraEstado})
        Me.lstSolicitudes.FullRowSelect = True
        Me.lstSolicitudes.Location = New System.Drawing.Point(12, 58)
        Me.lstSolicitudes.Name = "lstSolicitudes"
        Me.lstSolicitudes.Size = New System.Drawing.Size(366, 332)
        Me.lstSolicitudes.TabIndex = 6
        Me.lstSolicitudes.UseCompatibleStateImageBehavior = False
        Me.lstSolicitudes.View = System.Windows.Forms.View.Details
        '
        'SolCompraID
        '
        Me.SolCompraID.Text = "#"
        Me.SolCompraID.Width = 45
        '
        'SolCompraFecha
        '
        Me.SolCompraFecha.Text = "Fecha"
        Me.SolCompraFecha.Width = 81
        '
        'SolCompraProve
        '
        Me.SolCompraProve.Text = "Proveedor"
        Me.SolCompraProve.Width = 166
        '
        'SolCompraEstado
        '
        Me.SolCompraEstado.Text = "Estado"
        Me.SolCompraEstado.Width = 70
        '
        'lstDetalle
        '
        Me.lstDetalle.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SolDetalleID, Me.SolDetISBN, Me.SolDetLibro, Me.SolDetCantidad})
        Me.lstDetalle.FullRowSelect = True
        Me.lstDetalle.Location = New System.Drawing.Point(403, 58)
        Me.lstDetalle.Name = "lstDetalle"
        Me.lstDetalle.Size = New System.Drawing.Size(478, 332)
        Me.lstDetalle.TabIndex = 7
        Me.lstDetalle.UseCompatibleStateImageBehavior = False
        Me.lstDetalle.View = System.Windows.Forms.View.Details
        '
        'SolDetalleID
        '
        Me.SolDetalleID.Text = "#"
        Me.SolDetalleID.Width = 45
        '
        'SolDetISBN
        '
        Me.SolDetISBN.Text = "ISBN"
        Me.SolDetISBN.Width = 124
        '
        'SolDetLibro
        '
        Me.SolDetLibro.Text = "Libro"
        Me.SolDetLibro.Width = 249
        '
        'SolDetCantidad
        '
        Me.SolDetCantidad.Text = "Cantidad"
        Me.SolDetCantidad.Width = 56
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAceptar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnAceptar.Location = New System.Drawing.Point(12, 410)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(106, 35)
        Me.btnAceptar.TabIndex = 8
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnDenegar
        '
        Me.btnDenegar.Enabled = False
        Me.btnDenegar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDenegar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnDenegar.Location = New System.Drawing.Point(775, 410)
        Me.btnDenegar.Name = "btnDenegar"
        Me.btnDenegar.Size = New System.Drawing.Size(106, 35)
        Me.btnDenegar.TabIndex = 9
        Me.btnDenegar.Text = "Denegar"
        Me.btnDenegar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(384, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 65)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = ">" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ">" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ">" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ">" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ">"
        '
        'lblSolicitar
        '
        Me.lblSolicitar.AutoSize = True
        Me.lblSolicitar.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.lblSolicitar.Location = New System.Drawing.Point(12, 9)
        Me.lblSolicitar.Name = "lblSolicitar"
        Me.lblSolicitar.Size = New System.Drawing.Size(510, 46)
        Me.lblSolicitar.TabIndex = 39
        Me.lblSolicitar.Text = "Solicitudes de Compra en espera"
        Me.lblSolicitar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SolicitudesEspera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(893, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblSolicitar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDenegar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lstDetalle)
        Me.Controls.Add(Me.lstSolicitudes)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "SolicitudesEspera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitudes de Compra"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lstSolicitudes As System.Windows.Forms.ListView
    Friend WithEvents SolCompraID As System.Windows.Forms.ColumnHeader
    Friend WithEvents SolCompraFecha As System.Windows.Forms.ColumnHeader
    Friend WithEvents SolCompraProve As System.Windows.Forms.ColumnHeader
    Friend WithEvents SolCompraEstado As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstDetalle As System.Windows.Forms.ListView
    Friend WithEvents SolDetalleID As System.Windows.Forms.ColumnHeader
    Friend WithEvents SolDetISBN As System.Windows.Forms.ColumnHeader
    Friend WithEvents SolDetLibro As System.Windows.Forms.ColumnHeader
    Friend WithEvents SolDetCantidad As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnDenegar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSolicitar As System.Windows.Forms.Label
End Class

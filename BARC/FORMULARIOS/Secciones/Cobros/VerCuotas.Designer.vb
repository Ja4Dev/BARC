<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerCuotas
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
        Me.lstCuotas = New System.Windows.Forms.ListView()
        Me.NumCuota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FVencimientoCuota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MontoCuota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FpagoCuota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EstadoCuota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnReciboCuota = New System.Windows.Forms.Button()
        Me.btnVerFactura = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstCuotas
        '
        Me.lstCuotas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NumCuota, Me.FVencimientoCuota, Me.MontoCuota, Me.FpagoCuota, Me.EstadoCuota})
        Me.lstCuotas.FullRowSelect = True
        Me.lstCuotas.Location = New System.Drawing.Point(12, 65)
        Me.lstCuotas.Name = "lstCuotas"
        Me.lstCuotas.Size = New System.Drawing.Size(611, 335)
        Me.lstCuotas.TabIndex = 0
        Me.lstCuotas.UseCompatibleStateImageBehavior = False
        Me.lstCuotas.View = System.Windows.Forms.View.Details
        '
        'NumCuota
        '
        Me.NumCuota.Text = "Numero de Cuota"
        Me.NumCuota.Width = 118
        '
        'FVencimientoCuota
        '
        Me.FVencimientoCuota.Text = "Fecha de Vencimiento"
        Me.FVencimientoCuota.Width = 142
        '
        'MontoCuota
        '
        Me.MontoCuota.Text = "Monto de Cuota"
        Me.MontoCuota.Width = 122
        '
        'FpagoCuota
        '
        Me.FpagoCuota.Text = "Fecha de Pago"
        Me.FpagoCuota.Width = 129
        '
        'EstadoCuota
        '
        Me.EstadoCuota.Text = "Estado"
        Me.EstadoCuota.Width = 89
        '
        'btnPagar
        '
        Me.btnPagar.Enabled = False
        Me.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPagar.Location = New System.Drawing.Point(25, 416)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(116, 35)
        Me.btnPagar.TabIndex = 1
        Me.btnPagar.Text = "Registrar Pago"
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Location = New System.Drawing.Point(597, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 5
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnReciboCuota
        '
        Me.btnReciboCuota.Enabled = False
        Me.btnReciboCuota.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReciboCuota.Location = New System.Drawing.Point(256, 416)
        Me.btnReciboCuota.Name = "btnReciboCuota"
        Me.btnReciboCuota.Size = New System.Drawing.Size(116, 35)
        Me.btnReciboCuota.TabIndex = 6
        Me.btnReciboCuota.Text = "Ver Recibo de Pago"
        Me.btnReciboCuota.UseVisualStyleBackColor = True
        '
        'btnVerFactura
        '
        Me.btnVerFactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVerFactura.Location = New System.Drawing.Point(496, 416)
        Me.btnVerFactura.Name = "btnVerFactura"
        Me.btnVerFactura.Size = New System.Drawing.Size(116, 35)
        Me.btnVerFactura.TabIndex = 7
        Me.btnVerFactura.Text = "Ver Factura"
        Me.btnVerFactura.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(268, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 37)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Cuotas"
        '
        'VerCuotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(634, 464)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVerFactura)
        Me.Controls.Add(Me.btnReciboCuota)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.lstCuotas)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "VerCuotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuotas"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstCuotas As System.Windows.Forms.ListView
    Friend WithEvents NumCuota As System.Windows.Forms.ColumnHeader
    Friend WithEvents FVencimientoCuota As System.Windows.Forms.ColumnHeader
    Friend WithEvents MontoCuota As System.Windows.Forms.ColumnHeader
    Friend WithEvents FpagoCuota As System.Windows.Forms.ColumnHeader
    Friend WithEvents EstadoCuota As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPagar As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnReciboCuota As System.Windows.Forms.Button
    Friend WithEvents btnVerFactura As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnviosVer
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lstEnvios = New System.Windows.Forms.ListView()
        Me.CodEnvio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaOperacion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TipoOperacion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CodOperacion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EstadoEnv = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnBack.Location = New System.Drawing.Point(491, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 5
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAceptar.Location = New System.Drawing.Point(153, 287)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(222, 48)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Autorizar envio y generar remito"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lstEnvios
        '
        Me.lstEnvios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CodEnvio, Me.FechaOperacion, Me.TipoOperacion, Me.CodOperacion, Me.EstadoEnv})
        Me.lstEnvios.FullRowSelect = True
        Me.lstEnvios.GridLines = True
        Me.lstEnvios.Location = New System.Drawing.Point(12, 73)
        Me.lstEnvios.Name = "lstEnvios"
        Me.lstEnvios.Size = New System.Drawing.Size(504, 200)
        Me.lstEnvios.TabIndex = 8
        Me.lstEnvios.UseCompatibleStateImageBehavior = False
        Me.lstEnvios.View = System.Windows.Forms.View.Details
        '
        'CodEnvio
        '
        Me.CodEnvio.Text = "#"
        Me.CodEnvio.Width = 62
        '
        'FechaOperacion
        '
        Me.FechaOperacion.Text = "Fecha de operacion"
        Me.FechaOperacion.Width = 115
        '
        'TipoOperacion
        '
        Me.TipoOperacion.Text = "Compra/Alquiler"
        Me.TipoOperacion.Width = 105
        '
        'CodOperacion
        '
        Me.CodOperacion.Text = "Codigo de operacion"
        Me.CodOperacion.Width = 123
        '
        'EstadoEnv
        '
        Me.EstadoEnv.Text = "Estado de envio"
        Me.EstadoEnv.Width = 94
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 40)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Envios Pendientes"
        '
        'EnviosVer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(528, 347)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstEnvios)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "EnviosVer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Envios Pendientes"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lstEnvios As System.Windows.Forms.ListView
    Friend WithEvents CodEnvio As System.Windows.Forms.ColumnHeader
    Friend WithEvents CodOperacion As System.Windows.Forms.ColumnHeader
    Friend WithEvents EstadoEnv As System.Windows.Forms.ColumnHeader
    Friend WithEvents TipoOperacion As System.Windows.Forms.ColumnHeader
    Friend WithEvents FechaOperacion As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

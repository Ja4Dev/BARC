<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Socios
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
        Me.lblSocios = New System.Windows.Forms.Label()
        Me.lstSocios = New System.Windows.Forms.ListView()
        Me.codSocio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.socioNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.socioApellido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.socioEstado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.socioDNI = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnDatos = New System.Windows.Forms.Button()
        Me.lblFlecha2 = New System.Windows.Forms.Label()
        Me.lblFlecha1 = New System.Windows.Forms.Label()
        Me.lblFlecha3 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Location = New System.Drawing.Point(527, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 1
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblSocios
        '
        Me.lblSocios.AutoSize = True
        Me.lblSocios.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.lblSocios.Location = New System.Drawing.Point(5, 2)
        Me.lblSocios.Name = "lblSocios"
        Me.lblSocios.Size = New System.Drawing.Size(116, 46)
        Me.lblSocios.TabIndex = 2
        Me.lblSocios.Text = "Socios"
        Me.lblSocios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstSocios
        '
        Me.lstSocios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codSocio, Me.socioNombre, Me.socioApellido, Me.socioEstado, Me.socioDNI})
        Me.lstSocios.FullRowSelect = True
        Me.lstSocios.Location = New System.Drawing.Point(12, 54)
        Me.lstSocios.Name = "lstSocios"
        Me.lstSocios.Size = New System.Drawing.Size(540, 307)
        Me.lstSocios.TabIndex = 3
        Me.lstSocios.UseCompatibleStateImageBehavior = False
        Me.lstSocios.View = System.Windows.Forms.View.Details
        '
        'codSocio
        '
        Me.codSocio.Text = "#"
        Me.codSocio.Width = 38
        '
        'socioNombre
        '
        Me.socioNombre.Text = "Nombre"
        Me.socioNombre.Width = 113
        '
        'socioApellido
        '
        Me.socioApellido.Text = "Apellido"
        Me.socioApellido.Width = 123
        '
        'socioEstado
        '
        Me.socioEstado.Text = "Estado"
        Me.socioEstado.Width = 195
        '
        'socioDNI
        '
        Me.socioDNI.Text = "DNI"
        Me.socioDNI.Width = 67
        '
        'btnAlta
        '
        Me.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlta.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnAlta.Location = New System.Drawing.Point(12, 380)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(143, 40)
        Me.btnAlta.TabIndex = 4
        Me.btnAlta.Text = "Alta de Socio"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'btnDatos
        '
        Me.btnDatos.Enabled = False
        Me.btnDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDatos.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnDatos.Location = New System.Drawing.Point(409, 380)
        Me.btnDatos.Name = "btnDatos"
        Me.btnDatos.Size = New System.Drawing.Size(143, 40)
        Me.btnDatos.TabIndex = 6
        Me.btnDatos.Text = "Ver Informacion"
        Me.btnDatos.UseVisualStyleBackColor = True
        '
        'lblFlecha2
        '
        Me.lblFlecha2.AutoSize = True
        Me.lblFlecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlecha2.Location = New System.Drawing.Point(474, 364)
        Me.lblFlecha2.Name = "lblFlecha2"
        Me.lblFlecha2.Size = New System.Drawing.Size(13, 15)
        Me.lblFlecha2.TabIndex = 7
        Me.lblFlecha2.Text = "^"
        '
        'lblFlecha1
        '
        Me.lblFlecha1.AutoSize = True
        Me.lblFlecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlecha1.Location = New System.Drawing.Point(455, 364)
        Me.lblFlecha1.Name = "lblFlecha1"
        Me.lblFlecha1.Size = New System.Drawing.Size(13, 15)
        Me.lblFlecha1.TabIndex = 8
        Me.lblFlecha1.Text = "^"
        '
        'lblFlecha3
        '
        Me.lblFlecha3.AutoSize = True
        Me.lblFlecha3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlecha3.Location = New System.Drawing.Point(493, 364)
        Me.lblFlecha3.Name = "lblFlecha3"
        Me.lblFlecha3.Size = New System.Drawing.Size(13, 15)
        Me.lblFlecha3.TabIndex = 9
        Me.lblFlecha3.Text = "^"
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnBuscar.Location = New System.Drawing.Point(244, 380)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(76, 40)
        Me.btnBuscar.TabIndex = 10
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Socios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(564, 431)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblFlecha3)
        Me.Controls.Add(Me.lblFlecha1)
        Me.Controls.Add(Me.lblFlecha2)
        Me.Controls.Add(Me.btnDatos)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.lstSocios)
        Me.Controls.Add(Me.lblSocios)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Socios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Socios"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblSocios As System.Windows.Forms.Label
    Friend WithEvents lstSocios As System.Windows.Forms.ListView
    Friend WithEvents codSocio As System.Windows.Forms.ColumnHeader
    Friend WithEvents socioApellido As System.Windows.Forms.ColumnHeader
    Friend WithEvents socioNombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents socioEstado As System.Windows.Forms.ColumnHeader
    Friend WithEvents socioDNI As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAlta As System.Windows.Forms.Button
    Friend WithEvents btnDatos As System.Windows.Forms.Button
    Friend WithEvents lblFlecha2 As System.Windows.Forms.Label
    Friend WithEvents lblFlecha1 As System.Windows.Forms.Label
    Friend WithEvents lblFlecha3 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class

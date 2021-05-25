<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CorredoresEdicion
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Me.lstZonas = New System.Windows.Forms.ListView()
        Me.codzona = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.calle1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.calle2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.calle3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.calle4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstCorredores = New System.Windows.Forms.ListView()
        Me.codCorredor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dniCorredor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nomCorredor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.apeCorredor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.telCorredor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFlechas = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstZonas
        '
        Me.lstZonas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codzona, Me.calle1, Me.calle2, Me.calle3, Me.calle4})
        Me.lstZonas.FullRowSelect = True
        Me.lstZonas.GridLines = True
        Me.lstZonas.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lstZonas.Location = New System.Drawing.Point(525, 131)
        Me.lstZonas.Name = "lstZonas"
        Me.lstZonas.Size = New System.Drawing.Size(690, 298)
        Me.lstZonas.TabIndex = 7
        Me.lstZonas.UseCompatibleStateImageBehavior = False
        Me.lstZonas.View = System.Windows.Forms.View.Details
        '
        'codzona
        '
        Me.codzona.Text = "#"
        '
        'calle1
        '
        Me.calle1.Text = "Calle1"
        Me.calle1.Width = 164
        '
        'calle2
        '
        Me.calle2.Text = "Calle 2"
        Me.calle2.Width = 164
        '
        'calle3
        '
        Me.calle3.Text = "Calle 3"
        Me.calle3.Width = 149
        '
        'calle4
        '
        Me.calle4.Text = "Calle 4"
        Me.calle4.Width = 145
        '
        'lstCorredores
        '
        Me.lstCorredores.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codCorredor, Me.dniCorredor, Me.nomCorredor, Me.apeCorredor, Me.telCorredor})
        Me.lstCorredores.FullRowSelect = True
        Me.lstCorredores.GridLines = True
        Me.lstCorredores.Location = New System.Drawing.Point(12, 131)
        Me.lstCorredores.Name = "lstCorredores"
        Me.lstCorredores.Size = New System.Drawing.Size(485, 438)
        Me.lstCorredores.TabIndex = 6
        Me.lstCorredores.UseCompatibleStateImageBehavior = False
        Me.lstCorredores.View = System.Windows.Forms.View.Details
        '
        'codCorredor
        '
        Me.codCorredor.Text = "#"
        Me.codCorredor.Width = 50
        '
        'dniCorredor
        '
        Me.dniCorredor.Text = "DNI"
        Me.dniCorredor.Width = 81
        '
        'nomCorredor
        '
        Me.nomCorredor.Text = "Nombre"
        Me.nomCorredor.Width = 133
        '
        'apeCorredor
        '
        Me.apeCorredor.Text = "Apellido"
        Me.apeCorredor.Width = 125
        '
        'telCorredor
        '
        Me.telCorredor.Text = "Telefono"
        Me.telCorredor.Width = 89
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnBack.Location = New System.Drawing.Point(1190, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 8
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Corredores"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(793, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Zonas Asignadas"
        '
        'lblFlechas
        '
        Me.lblFlechas.AutoSize = True
        Me.lblFlechas.Location = New System.Drawing.Point(503, 239)
        Me.lblFlechas.Name = "lblFlechas"
        Me.lblFlechas.Size = New System.Drawing.Size(16, 65)
        Me.lblFlechas.TabIndex = 54
        Me.lblFlechas.Text = "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→"
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(975, 483)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(109, 48)
        Me.btnEliminar.TabIndex = 55
        Me.btnEliminar.Text = "Eliminar Zona"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(598, 483)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(116, 48)
        Me.btnAgregar.TabIndex = 56
        Me.btnAgregar.Text = "Agregar Zonas"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(394, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(388, 45)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Asignacion de Corredores"
        '
        'CorredoresEdicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1227, 579)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lblFlechas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lstZonas)
        Me.Controls.Add(Me.lstCorredores)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CorredoresEdicion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignacion de Corredores"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstZonas As System.Windows.Forms.ListView
    Friend WithEvents calle1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents calle2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents calle3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents calle4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstCorredores As System.Windows.Forms.ListView
    Friend WithEvents codCorredor As System.Windows.Forms.ColumnHeader
    Friend WithEvents nomCorredor As System.Windows.Forms.ColumnHeader
    Friend WithEvents apeCorredor As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFlechas As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dniCorredor As System.Windows.Forms.ColumnHeader
    Friend WithEvents telCorredor As System.Windows.Forms.ColumnHeader
    Friend WithEvents codzona As System.Windows.Forms.ColumnHeader
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CorredoresMod
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
        Me.lstCorredores = New System.Windows.Forms.ListView()
        Me.codCorredor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dniCorredor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nomCorredor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.apeCorredor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.telCorredor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(450, 47)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Modificacion de Corredores"
        '
        'lstCorredores
        '
        Me.lstCorredores.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codCorredor, Me.dniCorredor, Me.nomCorredor, Me.apeCorredor, Me.telCorredor})
        Me.lstCorredores.FullRowSelect = True
        Me.lstCorredores.GridLines = True
        Me.lstCorredores.Location = New System.Drawing.Point(12, 134)
        Me.lstCorredores.Name = "lstCorredores"
        Me.lstCorredores.Size = New System.Drawing.Size(485, 438)
        Me.lstCorredores.TabIndex = 10
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
        Me.btnBack.Location = New System.Drawing.Point(474, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 12
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(107, 583)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(134, 48)
        Me.btnModificar.TabIndex = 68
        Me.btnModificar.Text = "Modificar Corredor"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(271, 583)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(133, 48)
        Me.btnEliminar.TabIndex = 67
        Me.btnEliminar.Text = "Eliminar Corredor"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'CorredoresMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(511, 650)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstCorredores)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CorredoresMod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificacion de Corredores"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstCorredores As System.Windows.Forms.ListView
    Friend WithEvents codCorredor As System.Windows.Forms.ColumnHeader
    Friend WithEvents dniCorredor As System.Windows.Forms.ColumnHeader
    Friend WithEvents nomCorredor As System.Windows.Forms.ColumnHeader
    Friend WithEvents apeCorredor As System.Windows.Forms.ColumnHeader
    Friend WithEvents telCorredor As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class buscarCorredor
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
        Me.lstCorredores = New System.Windows.Forms.ListView()
        Me.codCorredor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nomCorredor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.apeCorredor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstZonas = New System.Windows.Forms.ListView()
        Me.calle1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.calle2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.calle3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.calle4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstCorredores
        '
        Me.lstCorredores.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codCorredor, Me.nomCorredor, Me.apeCorredor})
        Me.lstCorredores.FullRowSelect = True
        Me.lstCorredores.GridLines = True
        Me.lstCorredores.Location = New System.Drawing.Point(12, 12)
        Me.lstCorredores.Name = "lstCorredores"
        Me.lstCorredores.Size = New System.Drawing.Size(520, 199)
        Me.lstCorredores.TabIndex = 4
        Me.lstCorredores.UseCompatibleStateImageBehavior = False
        Me.lstCorredores.View = System.Windows.Forms.View.Details
        '
        'codCorredor
        '
        Me.codCorredor.Text = "#"
        Me.codCorredor.Width = 54
        '
        'nomCorredor
        '
        Me.nomCorredor.Text = "Nombre"
        Me.nomCorredor.Width = 232
        '
        'apeCorredor
        '
        Me.apeCorredor.Text = "Apellido"
        Me.apeCorredor.Width = 230
        '
        'lstZonas
        '
        Me.lstZonas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.calle1, Me.calle2, Me.calle3, Me.calle4})
        Me.lstZonas.GridLines = True
        Me.lstZonas.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lstZonas.Location = New System.Drawing.Point(12, 251)
        Me.lstZonas.Name = "lstZonas"
        Me.lstZonas.Size = New System.Drawing.Size(520, 96)
        Me.lstZonas.TabIndex = 5
        Me.lstZonas.UseCompatibleStateImageBehavior = False
        Me.lstZonas.View = System.Windows.Forms.View.Details
        '
        'calle1
        '
        Me.calle1.Text = "Calle1"
        Me.calle1.Width = 130
        '
        'calle2
        '
        Me.calle2.Text = "Calle 2"
        Me.calle2.Width = 130
        '
        'calle3
        '
        Me.calle3.Text = "Calle 3"
        Me.calle3.Width = 130
        '
        'calle4
        '
        Me.calle4.Text = "Calle 4"
        Me.calle4.Width = 126
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSeleccionar.Enabled = False
        Me.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSeleccionar.Location = New System.Drawing.Point(52, 356)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(440, 34)
        Me.btnSeleccionar.TabIndex = 43
        Me.btnSeleccionar.Text = "Seleccionar corredor"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(190, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Perimetro en el que trabaja"
        '
        'buscarCorredor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(544, 399)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.lstZonas)
        Me.Controls.Add(Me.lstCorredores)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "buscarCorredor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccion de Corredor"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstCorredores As System.Windows.Forms.ListView
    Friend WithEvents codCorredor As System.Windows.Forms.ColumnHeader
    Friend WithEvents nomCorredor As System.Windows.Forms.ColumnHeader
    Friend WithEvents apeCorredor As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstZonas As System.Windows.Forms.ListView
    Friend WithEvents calle1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents calle2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents calle3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents calle4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

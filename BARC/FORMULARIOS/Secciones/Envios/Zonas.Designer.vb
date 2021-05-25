<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Zonas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstZonas
        '
        Me.lstZonas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codzona, Me.calle1, Me.calle2, Me.calle3, Me.calle4})
        Me.lstZonas.FullRowSelect = True
        Me.lstZonas.GridLines = True
        Me.lstZonas.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lstZonas.Location = New System.Drawing.Point(12, 88)
        Me.lstZonas.Name = "lstZonas"
        Me.lstZonas.Size = New System.Drawing.Size(690, 298)
        Me.lstZonas.TabIndex = 8
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(209, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 47)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Seleccionar Zonas"
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnBack.Location = New System.Drawing.Point(679, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 10
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(298, 418)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(121, 59)
        Me.btnAgregar.TabIndex = 57
        Me.btnAgregar.Text = "Agregar "
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Zonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(716, 505)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstZonas)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Zonas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Zonas"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstZonas As System.Windows.Forms.ListView
    Friend WithEvents codzona As System.Windows.Forms.ColumnHeader
    Friend WithEvents calle1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents calle2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents calle3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents calle4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
End Class

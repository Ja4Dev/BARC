<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ZonasModificacion
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lstZonas = New System.Windows.Forms.ListView()
        Me.codzona = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.calle1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.calle2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.calle3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.calle4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Location = New System.Drawing.Point(676, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 7
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lstZonas
        '
        Me.lstZonas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codzona, Me.calle1, Me.calle2, Me.calle3, Me.calle4})
        Me.lstZonas.FullRowSelect = True
        Me.lstZonas.GridLines = True
        Me.lstZonas.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lstZonas.Location = New System.Drawing.Point(11, 69)
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
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 45)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Modificaciones Zonas"
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(208, 396)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(134, 48)
        Me.btnModificar.TabIndex = 68
        Me.btnModificar.Text = "Modificar Zonas"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(372, 396)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(133, 48)
        Me.btnEliminar.TabIndex = 67
        Me.btnEliminar.Text = "Eliminar Zonas"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'ZonasModificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(713, 470)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstZonas)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ZonasModificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificacion de Zonas"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lstZonas As System.Windows.Forms.ListView
    Friend WithEvents codzona As System.Windows.Forms.ColumnHeader
    Friend WithEvents calle1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents calle2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents calle3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents calle4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
End Class

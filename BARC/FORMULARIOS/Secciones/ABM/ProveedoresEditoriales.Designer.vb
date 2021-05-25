<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProveedoresEditoriales
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstEditoriales = New System.Windows.Forms.ListView()
        Me.codEditorial = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nomEditorial = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstProveedores = New System.Windows.Forms.ListView()
        Me.codProveedor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nombreProv = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.direccionProv = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.telCorredor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblFlechas = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(185, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(585, 45)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Asignacion de Proveedores - Editoriales"
        '
        'btnAgregar
        '
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(656, 498)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(134, 48)
        Me.btnAgregar.TabIndex = 63
        Me.btnAgregar.Text = "Agregar Editorial"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(808, 498)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(133, 48)
        Me.btnEliminar.TabIndex = 62
        Me.btnEliminar.Text = "Eliminar Editorial"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(731, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 20)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Editoriales Asignadas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(250, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Proveedores"
        '
        'lstEditoriales
        '
        Me.lstEditoriales.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codEditorial, Me.nomEditorial})
        Me.lstEditoriales.FullRowSelect = True
        Me.lstEditoriales.GridLines = True
        Me.lstEditoriales.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lstEditoriales.Location = New System.Drawing.Point(652, 146)
        Me.lstEditoriales.Name = "lstEditoriales"
        Me.lstEditoriales.Size = New System.Drawing.Size(295, 298)
        Me.lstEditoriales.TabIndex = 59
        Me.lstEditoriales.UseCompatibleStateImageBehavior = False
        Me.lstEditoriales.View = System.Windows.Forms.View.Details
        '
        'codEditorial
        '
        Me.codEditorial.Text = "#"
        Me.codEditorial.Width = 52
        '
        'nomEditorial
        '
        Me.nomEditorial.Text = "Editorial"
        Me.nomEditorial.Width = 228
        '
        'lstProveedores
        '
        Me.lstProveedores.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codProveedor, Me.nombreProv, Me.direccionProv, Me.telCorredor})
        Me.lstProveedores.FullRowSelect = True
        Me.lstProveedores.GridLines = True
        Me.lstProveedores.Location = New System.Drawing.Point(12, 146)
        Me.lstProveedores.Name = "lstProveedores"
        Me.lstProveedores.Size = New System.Drawing.Size(612, 438)
        Me.lstProveedores.TabIndex = 58
        Me.lstProveedores.UseCompatibleStateImageBehavior = False
        Me.lstProveedores.View = System.Windows.Forms.View.Details
        '
        'codProveedor
        '
        Me.codProveedor.Text = "#"
        Me.codProveedor.Width = 50
        '
        'nombreProv
        '
        Me.nombreProv.Text = "Proveedor"
        Me.nombreProv.Width = 223
        '
        'direccionProv
        '
        Me.direccionProv.Text = "Direccion"
        Me.direccionProv.Width = 203
        '
        'telCorredor
        '
        Me.telCorredor.Text = "Telefono"
        Me.telCorredor.Width = 131
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Location = New System.Drawing.Point(922, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 65
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblFlechas
        '
        Me.lblFlechas.AutoSize = True
        Me.lblFlechas.Location = New System.Drawing.Point(630, 259)
        Me.lblFlechas.Name = "lblFlechas"
        Me.lblFlechas.Size = New System.Drawing.Size(16, 65)
        Me.lblFlechas.TabIndex = 66
        Me.lblFlechas.Text = "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→"
        '
        'ProveedoresEditoriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(959, 621)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblFlechas)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstEditoriales)
        Me.Controls.Add(Me.lstProveedores)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ProveedoresEditoriales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignacion de Proveedores -Editoriales"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstEditoriales As System.Windows.Forms.ListView
    Friend WithEvents codEditorial As System.Windows.Forms.ColumnHeader
    Friend WithEvents nomEditorial As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstProveedores As System.Windows.Forms.ListView
    Friend WithEvents codProveedor As System.Windows.Forms.ColumnHeader
    Friend WithEvents nombreProv As System.Windows.Forms.ColumnHeader
    Friend WithEvents direccionProv As System.Windows.Forms.ColumnHeader
    Friend WithEvents telCorredor As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblFlechas As System.Windows.Forms.Label
End Class

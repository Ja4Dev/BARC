<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibrosEjemplaresMod
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
        Me.lstEjemplares = New System.Windows.Forms.ListView()
        Me.CodLibroEjemplares = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EjemplaresDet = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EjemplaresPrestado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EjemplaresVedido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EjemplaresTipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnEstado = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnTipo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstEjemplares
        '
        Me.lstEjemplares.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.lstEjemplares.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lstEjemplares.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CodLibroEjemplares, Me.EjemplaresDet, Me.EjemplaresPrestado, Me.EjemplaresVedido, Me.EjemplaresTipo})
        Me.lstEjemplares.FullRowSelect = True
        Me.lstEjemplares.GridLines = True
        Me.lstEjemplares.Location = New System.Drawing.Point(12, 77)
        Me.lstEjemplares.Name = "lstEjemplares"
        Me.lstEjemplares.Size = New System.Drawing.Size(503, 440)
        Me.lstEjemplares.TabIndex = 6
        Me.lstEjemplares.UseCompatibleStateImageBehavior = False
        Me.lstEjemplares.View = System.Windows.Forms.View.Details
        '
        'CodLibroEjemplares
        '
        Me.CodLibroEjemplares.Text = "#"
        Me.CodLibroEjemplares.Width = 52
        '
        'EjemplaresDet
        '
        Me.EjemplaresDet.Text = "Deteriorado"
        Me.EjemplaresDet.Width = 110
        '
        'EjemplaresPrestado
        '
        Me.EjemplaresPrestado.Text = "Alquilado"
        Me.EjemplaresPrestado.Width = 101
        '
        'EjemplaresVedido
        '
        Me.EjemplaresVedido.Text = "Vendido"
        Me.EjemplaresVedido.Width = 100
        '
        'EjemplaresTipo
        '
        Me.EjemplaresTipo.Text = "Tipo de Ejemplar"
        Me.EjemplaresTipo.Width = 135
        '
        'btnEstado
        '
        Me.btnEstado.Enabled = False
        Me.btnEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEstado.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEstado.Location = New System.Drawing.Point(45, 539)
        Me.btnEstado.Name = "btnEstado"
        Me.btnEstado.Size = New System.Drawing.Size(133, 48)
        Me.btnEstado.TabIndex = 68
        Me.btnEstado.Text = "Modificar Estado"
        Me.btnEstado.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Location = New System.Drawing.Point(493, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 69
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnTipo
        '
        Me.btnTipo.Enabled = False
        Me.btnTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTipo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTipo.Location = New System.Drawing.Point(349, 539)
        Me.btnTipo.Name = "btnTipo"
        Me.btnTipo.Size = New System.Drawing.Size(133, 48)
        Me.btnTipo.TabIndex = 70
        Me.btnTipo.Text = "Modificar Tipo"
        Me.btnTipo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 45)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Modificar Ejemplares"
        '
        'LibrosEjemplaresMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(530, 599)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTipo)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnEstado)
        Me.Controls.Add(Me.lstEjemplares)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "LibrosEjemplaresMod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Ejemplares"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstEjemplares As System.Windows.Forms.ListView
    Friend WithEvents CodLibroEjemplares As System.Windows.Forms.ColumnHeader
    Friend WithEvents EjemplaresDet As System.Windows.Forms.ColumnHeader
    Friend WithEvents EjemplaresPrestado As System.Windows.Forms.ColumnHeader
    Friend WithEvents EjemplaresVedido As System.Windows.Forms.ColumnHeader
    Friend WithEvents EjemplaresTipo As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnEstado As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnTipo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

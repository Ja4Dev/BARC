<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InteresesMod
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
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.lstInteres = New System.Windows.Forms.ListView()
        Me.codInteres = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DiasAtrasad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.porcentajeInte = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Location = New System.Drawing.Point(259, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 7
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(81, 403)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(134, 48)
        Me.btnModificar.TabIndex = 67
        Me.btnModificar.Text = "Modificar Interes"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'lstInteres
        '
        Me.lstInteres.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codInteres, Me.DiasAtrasad, Me.porcentajeInte})
        Me.lstInteres.FullRowSelect = True
        Me.lstInteres.Location = New System.Drawing.Point(43, 76)
        Me.lstInteres.MultiSelect = False
        Me.lstInteres.Name = "lstInteres"
        Me.lstInteres.Size = New System.Drawing.Size(210, 310)
        Me.lstInteres.TabIndex = 68
        Me.lstInteres.UseCompatibleStateImageBehavior = False
        Me.lstInteres.View = System.Windows.Forms.View.Details
        '
        'codInteres
        '
        Me.codInteres.Text = "#"
        Me.codInteres.Width = 49
        '
        'DiasAtrasad
        '
        Me.DiasAtrasad.Text = "Dias Atrasados"
        Me.DiasAtrasad.Width = 94
        '
        'porcentajeInte
        '
        Me.porcentajeInte.Text = "% Interes"
        Me.porcentajeInte.Width = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 25)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Modificacion Intereses"
        '
        'InteresesMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(296, 463)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstInteres)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "InteresesMod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificacion de Intereses"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents lstInteres As System.Windows.Forms.ListView
    Friend WithEvents codInteres As System.Windows.Forms.ColumnHeader
    Friend WithEvents DiasAtrasad As System.Windows.Forms.ColumnHeader
    Friend WithEvents porcentajeInte As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

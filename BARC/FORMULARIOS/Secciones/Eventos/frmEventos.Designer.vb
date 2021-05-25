<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEventos
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
        Me.lblEventos = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCrearEv = New System.Windows.Forms.Button()
        Me.btnRegistrarAsis = New System.Windows.Forms.Button()
        Me.btnEventos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEventos
        '
        Me.lblEventos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEventos.AutoSize = True
        Me.lblEventos.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventos.Location = New System.Drawing.Point(78, 9)
        Me.lblEventos.Name = "lblEventos"
        Me.lblEventos.Size = New System.Drawing.Size(141, 47)
        Me.lblEventos.TabIndex = 0
        Me.lblEventos.Text = "Eventos"
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnBack.Location = New System.Drawing.Point(258, 9)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(29, 25)
        Me.btnBack.TabIndex = 4
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnCrearEv
        '
        Me.btnCrearEv.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCrearEv.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearEv.Location = New System.Drawing.Point(86, 89)
        Me.btnCrearEv.Name = "btnCrearEv"
        Me.btnCrearEv.Size = New System.Drawing.Size(128, 58)
        Me.btnCrearEv.TabIndex = 5
        Me.btnCrearEv.Text = "Crear Evento"
        Me.btnCrearEv.UseVisualStyleBackColor = True
        '
        'btnRegistrarAsis
        '
        Me.btnRegistrarAsis.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegistrarAsis.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarAsis.Location = New System.Drawing.Point(86, 236)
        Me.btnRegistrarAsis.Name = "btnRegistrarAsis"
        Me.btnRegistrarAsis.Size = New System.Drawing.Size(128, 58)
        Me.btnRegistrarAsis.TabIndex = 6
        Me.btnRegistrarAsis.Text = "Registrar Asistencia"
        Me.btnRegistrarAsis.UseVisualStyleBackColor = True
        '
        'btnEventos
        '
        Me.btnEventos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEventos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEventos.Location = New System.Drawing.Point(86, 162)
        Me.btnEventos.Name = "btnEventos"
        Me.btnEventos.Size = New System.Drawing.Size(128, 58)
        Me.btnEventos.TabIndex = 7
        Me.btnEventos.Text = "Eventos"
        Me.btnEventos.UseVisualStyleBackColor = True
        '
        'frmEventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(301, 325)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnEventos)
        Me.Controls.Add(Me.btnRegistrarAsis)
        Me.Controls.Add(Me.btnCrearEv)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblEventos)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmEventos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eventos"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEventos As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnCrearEv As System.Windows.Forms.Button
    Friend WithEvents btnRegistrarAsis As System.Windows.Forms.Button
    Friend WithEvents btnEventos As System.Windows.Forms.Button
End Class

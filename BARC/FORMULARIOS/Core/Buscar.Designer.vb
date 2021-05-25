<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buscar
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
        Me.rdbDNI = New System.Windows.Forms.RadioButton()
        Me.rdbCodSoc = New System.Windows.Forms.RadioButton()
        Me.txtSocio = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rdbDNI
        '
        Me.rdbDNI.AutoSize = True
        Me.rdbDNI.Checked = True
        Me.rdbDNI.Location = New System.Drawing.Point(12, 45)
        Me.rdbDNI.Name = "rdbDNI"
        Me.rdbDNI.Size = New System.Drawing.Size(44, 17)
        Me.rdbDNI.TabIndex = 0
        Me.rdbDNI.TabStop = True
        Me.rdbDNI.Text = "DNI"
        Me.rdbDNI.UseVisualStyleBackColor = True
        '
        'rdbCodSoc
        '
        Me.rdbCodSoc.AutoSize = True
        Me.rdbCodSoc.Location = New System.Drawing.Point(62, 45)
        Me.rdbCodSoc.Name = "rdbCodSoc"
        Me.rdbCodSoc.Size = New System.Drawing.Size(103, 17)
        Me.rdbCodSoc.TabIndex = 1
        Me.rdbCodSoc.Text = "Codigo de Socio"
        Me.rdbCodSoc.UseVisualStyleBackColor = True
        '
        'txtSocio
        '
        Me.txtSocio.Location = New System.Drawing.Point(12, 12)
        Me.txtSocio.MaxLength = 8
        Me.txtSocio.Name = "txtSocio"
        Me.txtSocio.Size = New System.Drawing.Size(153, 20)
        Me.txtSocio.TabIndex = 2
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(180, 17)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(97, 40)
        Me.btnBuscar.TabIndex = 11
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Buscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(289, 74)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtSocio)
        Me.Controls.Add(Me.rdbCodSoc)
        Me.Controls.Add(Me.rdbDNI)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Buscar"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Socio"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdbDNI As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCodSoc As System.Windows.Forms.RadioButton
    Friend WithEvents txtSocio As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class

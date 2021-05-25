<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarPago
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
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnBuscarCorredor = New System.Windows.Forms.Button()
        Me.lblCorredorNom = New System.Windows.Forms.Label()
        Me.lblCorredorCod = New System.Windows.Forms.Label()
        Me.lblSeleccionar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegistrar.Location = New System.Drawing.Point(12, 72)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(200, 50)
        Me.btnRegistrar.TabIndex = 1
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelar.Location = New System.Drawing.Point(223, 72)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(200, 50)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnBuscarCorredor
        '
        Me.btnBuscarCorredor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscarCorredor.Location = New System.Drawing.Point(12, 21)
        Me.btnBuscarCorredor.Name = "btnBuscarCorredor"
        Me.btnBuscarCorredor.Size = New System.Drawing.Size(112, 40)
        Me.btnBuscarCorredor.TabIndex = 3
        Me.btnBuscarCorredor.Text = "Buscar corredor"
        Me.btnBuscarCorredor.UseVisualStyleBackColor = True
        '
        'lblCorredorNom
        '
        Me.lblCorredorNom.AutoSize = True
        Me.lblCorredorNom.Location = New System.Drawing.Point(157, 44)
        Me.lblCorredorNom.Name = "lblCorredorNom"
        Me.lblCorredorNom.Size = New System.Drawing.Size(40, 13)
        Me.lblCorredorNom.TabIndex = 4
        Me.lblCorredorNom.Text = "Label1"
        Me.lblCorredorNom.Visible = False
        '
        'lblCorredorCod
        '
        Me.lblCorredorCod.AutoSize = True
        Me.lblCorredorCod.Location = New System.Drawing.Point(157, 26)
        Me.lblCorredorCod.Name = "lblCorredorCod"
        Me.lblCorredorCod.Size = New System.Drawing.Size(40, 13)
        Me.lblCorredorCod.TabIndex = 5
        Me.lblCorredorCod.Text = "Label2"
        Me.lblCorredorCod.Visible = False
        '
        'lblSeleccionar
        '
        Me.lblSeleccionar.AutoSize = True
        Me.lblSeleccionar.Location = New System.Drawing.Point(210, 35)
        Me.lblSeleccionar.Name = "lblSeleccionar"
        Me.lblSeleccionar.Size = New System.Drawing.Size(158, 13)
        Me.lblSeleccionar.TabIndex = 6
        Me.lblSeleccionar.Text = "Debe seleccionar un corredor"
        '
        'RegistrarPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(435, 134)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblSeleccionar)
        Me.Controls.Add(Me.lblCorredorNom)
        Me.Controls.Add(Me.btnBuscarCorredor)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.lblCorredorCod)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "RegistrarPago"
        Me.Text = "Registrar Pago"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnBuscarCorredor As System.Windows.Forms.Button
    Friend WithEvents lblCorredorNom As System.Windows.Forms.Label
    Friend WithEvents lblCorredorCod As System.Windows.Forms.Label
    Friend WithEvents lblSeleccionar As System.Windows.Forms.Label
End Class

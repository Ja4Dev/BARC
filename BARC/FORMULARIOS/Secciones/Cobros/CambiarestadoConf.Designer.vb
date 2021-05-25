<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambiarestadoConf
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
        Me.btnSi = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.lblCorredor = New System.Windows.Forms.Label()
        Me.txtCorredor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCorredorData = New System.Windows.Forms.Label()
        Me.btnValidar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Esta seguro que quiere registrar el pago?"
        '
        'btnSi
        '
        Me.btnSi.Location = New System.Drawing.Point(66, 165)
        Me.btnSi.Name = "btnSi"
        Me.btnSi.Size = New System.Drawing.Size(75, 23)
        Me.btnSi.TabIndex = 1
        Me.btnSi.Text = "Registrar"
        Me.btnSi.UseVisualStyleBackColor = True
        '
        'btnNo
        '
        Me.btnNo.Location = New System.Drawing.Point(288, 165)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(75, 23)
        Me.btnNo.TabIndex = 2
        Me.btnNo.Text = "Cancelar"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'lblCorredor
        '
        Me.lblCorredor.AutoSize = True
        Me.lblCorredor.Location = New System.Drawing.Point(45, 99)
        Me.lblCorredor.Name = "lblCorredor"
        Me.lblCorredor.Size = New System.Drawing.Size(86, 13)
        Me.lblCorredor.TabIndex = 3
        Me.lblCorredor.Text = "Codigo Corredor:"
        '
        'txtCorredor
        '
        Me.txtCorredor.Location = New System.Drawing.Point(137, 96)
        Me.txtCorredor.Name = "txtCorredor"
        Me.txtCorredor.Size = New System.Drawing.Size(100, 20)
        Me.txtCorredor.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre Corredor:"
        '
        'lblCorredorData
        '
        Me.lblCorredorData.AutoSize = True
        Me.lblCorredorData.Location = New System.Drawing.Point(137, 128)
        Me.lblCorredorData.Name = "lblCorredorData"
        Me.lblCorredorData.Size = New System.Drawing.Size(0, 13)
        Me.lblCorredorData.TabIndex = 6
        '
        'btnValidar
        '
        Me.btnValidar.Location = New System.Drawing.Point(288, 96)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(75, 23)
        Me.btnValidar.TabIndex = 7
        Me.btnValidar.Text = "Validar"
        Me.btnValidar.UseVisualStyleBackColor = True
        '
        'CambiarestadoConf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 234)
        Me.Controls.Add(Me.btnValidar)
        Me.Controls.Add(Me.lblCorredorData)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCorredor)
        Me.Controls.Add(Me.lblCorredor)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnSi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CambiarestadoConf"
        Me.Text = "CambiarestadoConf"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSi As System.Windows.Forms.Button
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents lblCorredor As System.Windows.Forms.Label
    Friend WithEvents txtCorredor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCorredorData As System.Windows.Forms.Label
    Friend WithEvents btnValidar As System.Windows.Forms.Button
End Class

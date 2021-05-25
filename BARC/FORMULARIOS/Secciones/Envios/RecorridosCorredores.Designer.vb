<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecorridosCorredores
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
        Me.lblFlechas = New System.Windows.Forms.Label()
        Me.lstRecorridos = New System.Windows.Forms.ListView()
        Me.NRecorridoLista = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaRecorrido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CodCorredorRecorrido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NombreCReco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ApellidoCReco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstDetalle = New System.Windows.Forms.ListView()
        Me.SocioReco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NombreSReco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ApellidoSReco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DireccionReco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnBack.Location = New System.Drawing.Point(863, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 5
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblFlechas
        '
        Me.lblFlechas.AutoSize = True
        Me.lblFlechas.Location = New System.Drawing.Point(440, 264)
        Me.lblFlechas.Name = "lblFlechas"
        Me.lblFlechas.Size = New System.Drawing.Size(16, 65)
        Me.lblFlechas.TabIndex = 44
        Me.lblFlechas.Text = "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→"
        '
        'lstRecorridos
        '
        Me.lstRecorridos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NRecorridoLista, Me.FechaRecorrido, Me.CodCorredorRecorrido, Me.NombreCReco, Me.ApellidoCReco})
        Me.lstRecorridos.FullRowSelect = True
        Me.lstRecorridos.Location = New System.Drawing.Point(12, 97)
        Me.lstRecorridos.Name = "lstRecorridos"
        Me.lstRecorridos.Size = New System.Drawing.Size(420, 440)
        Me.lstRecorridos.TabIndex = 45
        Me.lstRecorridos.UseCompatibleStateImageBehavior = False
        Me.lstRecorridos.View = System.Windows.Forms.View.Details
        '
        'NRecorridoLista
        '
        Me.NRecorridoLista.Text = "#"
        Me.NRecorridoLista.Width = 51
        '
        'FechaRecorrido
        '
        Me.FechaRecorrido.Text = "Fecha"
        Me.FechaRecorrido.Width = 69
        '
        'CodCorredorRecorrido
        '
        Me.CodCorredorRecorrido.Text = "Cod Corredor"
        Me.CodCorredorRecorrido.Width = 86
        '
        'NombreCReco
        '
        Me.NombreCReco.Text = "Nombre"
        Me.NombreCReco.Width = 99
        '
        'ApellidoCReco
        '
        Me.ApellidoCReco.Text = "Apellido"
        Me.ApellidoCReco.Width = 108
        '
        'lstDetalle
        '
        Me.lstDetalle.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SocioReco, Me.NombreSReco, Me.ApellidoSReco, Me.DireccionReco})
        Me.lstDetalle.Location = New System.Drawing.Point(464, 97)
        Me.lstDetalle.Name = "lstDetalle"
        Me.lstDetalle.Size = New System.Drawing.Size(425, 440)
        Me.lstDetalle.TabIndex = 46
        Me.lstDetalle.UseCompatibleStateImageBehavior = False
        Me.lstDetalle.View = System.Windows.Forms.View.Details
        '
        'SocioReco
        '
        Me.SocioReco.Text = "Cod Socio"
        Me.SocioReco.Width = 65
        '
        'NombreSReco
        '
        Me.NombreSReco.Text = "Nombre"
        Me.NombreSReco.Width = 85
        '
        'ApellidoSReco
        '
        Me.ApellidoSReco.Text = "Apellido"
        Me.ApellidoSReco.Width = 85
        '
        'DireccionReco
        '
        Me.DireccionReco.Text = "Direccion"
        Me.DireccionReco.Width = 175
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(267, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 47)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Recorridos Corredores"
        '
        'RecorridosCorredores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 594)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstDetalle)
        Me.Controls.Add(Me.lstRecorridos)
        Me.Controls.Add(Me.lblFlechas)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "RecorridosCorredores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recorridos Corredores"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblFlechas As System.Windows.Forms.Label
    Friend WithEvents lstRecorridos As System.Windows.Forms.ListView
    Friend WithEvents NRecorridoLista As System.Windows.Forms.ColumnHeader
    Friend WithEvents FechaRecorrido As System.Windows.Forms.ColumnHeader
    Friend WithEvents CodCorredorRecorrido As System.Windows.Forms.ColumnHeader
    Friend WithEvents NombreCReco As System.Windows.Forms.ColumnHeader
    Friend WithEvents ApellidoCReco As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstDetalle As System.Windows.Forms.ListView
    Friend WithEvents SocioReco As System.Windows.Forms.ColumnHeader
    Friend WithEvents NombreSReco As System.Windows.Forms.ColumnHeader
    Friend WithEvents ApellidoSReco As System.Windows.Forms.ColumnHeader
    Friend WithEvents DireccionReco As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

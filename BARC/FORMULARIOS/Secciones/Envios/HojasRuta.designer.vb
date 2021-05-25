<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HojasRuta
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
        Me.lblSolicitar = New System.Windows.Forms.Label()
        Me.lstHojasR = New System.Windows.Forms.ListView()
        Me.CodHojaRuta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaHojaRuta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EstadoHojaRuta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lstHojasRDet = New System.Windows.Forms.ListView()
        Me.CodigHojaRuta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NumRemitoHR = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CantLibrosHR = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblFlechas = New System.Windows.Forms.Label()
        Me.btnRemito = New System.Windows.Forms.Button()
        Me.btnCambiarEstado = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.gbxHojasruta = New System.Windows.Forms.GroupBox()
        Me.gbxHojasRutaDetalle = New System.Windows.Forms.GroupBox()
        Me.gbxHojasruta.SuspendLayout()
        Me.gbxHojasRutaDetalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSolicitar
        '
        Me.lblSolicitar.AutoSize = True
        Me.lblSolicitar.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.lblSolicitar.Location = New System.Drawing.Point(12, 9)
        Me.lblSolicitar.Name = "lblSolicitar"
        Me.lblSolicitar.Size = New System.Drawing.Size(227, 46)
        Me.lblSolicitar.TabIndex = 39
        Me.lblSolicitar.Text = "Hojas de Ruta"
        Me.lblSolicitar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstHojasR
        '
        Me.lstHojasR.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CodHojaRuta, Me.FechaHojaRuta, Me.EstadoHojaRuta})
        Me.lstHojasR.FullRowSelect = True
        Me.lstHojasR.GridLines = True
        Me.lstHojasR.Location = New System.Drawing.Point(12, 20)
        Me.lstHojasR.Name = "lstHojasR"
        Me.lstHojasR.Size = New System.Drawing.Size(311, 286)
        Me.lstHojasR.TabIndex = 40
        Me.lstHojasR.UseCompatibleStateImageBehavior = False
        Me.lstHojasR.View = System.Windows.Forms.View.Details
        '
        'CodHojaRuta
        '
        Me.CodHojaRuta.Text = "#"
        Me.CodHojaRuta.Width = 69
        '
        'FechaHojaRuta
        '
        Me.FechaHojaRuta.Text = "Fecha"
        Me.FechaHojaRuta.Width = 111
        '
        'EstadoHojaRuta
        '
        Me.EstadoHojaRuta.Text = "Estado"
        Me.EstadoHojaRuta.Width = 127
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnBack.Location = New System.Drawing.Point(691, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 41
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lstHojasRDet
        '
        Me.lstHojasRDet.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CodigHojaRuta, Me.NumRemitoHR, Me.CantLibrosHR})
        Me.lstHojasRDet.FullRowSelect = True
        Me.lstHojasRDet.GridLines = True
        Me.lstHojasRDet.Location = New System.Drawing.Point(13, 20)
        Me.lstHojasRDet.Name = "lstHojasRDet"
        Me.lstHojasRDet.Size = New System.Drawing.Size(309, 286)
        Me.lstHojasRDet.TabIndex = 42
        Me.lstHojasRDet.UseCompatibleStateImageBehavior = False
        Me.lstHojasRDet.View = System.Windows.Forms.View.Details
        '
        'CodigHojaRuta
        '
        Me.CodigHojaRuta.Text = "#"
        Me.CodigHojaRuta.Width = 35
        '
        'NumRemitoHR
        '
        Me.NumRemitoHR.Text = "Remito"
        Me.NumRemitoHR.Width = 160
        '
        'CantLibrosHR
        '
        Me.CantLibrosHR.Text = "Cantidad de Libros"
        Me.CantLibrosHR.Width = 110
        '
        'lblFlechas
        '
        Me.lblFlechas.AutoSize = True
        Me.lblFlechas.Location = New System.Drawing.Point(356, 193)
        Me.lblFlechas.Name = "lblFlechas"
        Me.lblFlechas.Size = New System.Drawing.Size(16, 65)
        Me.lblFlechas.TabIndex = 43
        Me.lblFlechas.Text = "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→"
        '
        'btnRemito
        '
        Me.btnRemito.Enabled = False
        Me.btnRemito.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRemito.Location = New System.Drawing.Point(546, 392)
        Me.btnRemito.Name = "btnRemito"
        Me.btnRemito.Size = New System.Drawing.Size(170, 49)
        Me.btnRemito.TabIndex = 44
        Me.btnRemito.Text = "Ver Remito"
        Me.btnRemito.UseVisualStyleBackColor = True
        '
        'btnCambiarEstado
        '
        Me.btnCambiarEstado.Enabled = False
        Me.btnCambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCambiarEstado.Location = New System.Drawing.Point(12, 392)
        Me.btnCambiarEstado.Name = "btnCambiarEstado"
        Me.btnCambiarEstado.Size = New System.Drawing.Size(170, 49)
        Me.btnCambiarEstado.TabIndex = 45
        Me.btnCambiarEstado.Text = "Cambiar Estado"
        Me.btnCambiarEstado.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.Enabled = False
        Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnviar.Location = New System.Drawing.Point(190, 392)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(170, 49)
        Me.btnEnviar.TabIndex = 46
        Me.btnEnviar.Text = "Enviar Hoja de Ruta"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'btnVer
        '
        Me.btnVer.Enabled = False
        Me.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVer.Location = New System.Drawing.Point(368, 392)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(170, 49)
        Me.btnVer.TabIndex = 47
        Me.btnVer.Text = "Ver/Imprimir Hoja de Ruta"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'gbxHojasruta
        '
        Me.gbxHojasruta.Controls.Add(Me.lstHojasR)
        Me.gbxHojasruta.Location = New System.Drawing.Point(16, 66)
        Me.gbxHojasruta.Name = "gbxHojasruta"
        Me.gbxHojasruta.Size = New System.Drawing.Size(334, 320)
        Me.gbxHojasruta.TabIndex = 50
        Me.gbxHojasruta.TabStop = False
        Me.gbxHojasruta.Text = "Hojas de ruta"
        '
        'gbxHojasRutaDetalle
        '
        Me.gbxHojasRutaDetalle.Controls.Add(Me.lstHojasRDet)
        Me.gbxHojasRutaDetalle.Location = New System.Drawing.Point(378, 66)
        Me.gbxHojasRutaDetalle.Name = "gbxHojasRutaDetalle"
        Me.gbxHojasRutaDetalle.Size = New System.Drawing.Size(334, 320)
        Me.gbxHojasRutaDetalle.TabIndex = 51
        Me.gbxHojasRutaDetalle.TabStop = False
        Me.gbxHojasRutaDetalle.Text = "Detalle"
        '
        'HojasRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(728, 455)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbxHojasRutaDetalle)
        Me.Controls.Add(Me.gbxHojasruta)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.btnCambiarEstado)
        Me.Controls.Add(Me.btnRemito)
        Me.Controls.Add(Me.lblFlechas)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblSolicitar)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "HojasRuta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hoja de Ruta"
        Me.TopMost = True
        Me.gbxHojasruta.ResumeLayout(False)
        Me.gbxHojasRutaDetalle.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSolicitar As System.Windows.Forms.Label
    Friend WithEvents lstHojasR As System.Windows.Forms.ListView
    Friend WithEvents CodHojaRuta As System.Windows.Forms.ColumnHeader
    Friend WithEvents FechaHojaRuta As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents EstadoHojaRuta As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstHojasRDet As System.Windows.Forms.ListView
    Friend WithEvents CodigHojaRuta As System.Windows.Forms.ColumnHeader
    Friend WithEvents CantLibrosHR As System.Windows.Forms.ColumnHeader
    Friend WithEvents NumRemitoHR As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblFlechas As System.Windows.Forms.Label
    Friend WithEvents btnRemito As System.Windows.Forms.Button
    Friend WithEvents btnCambiarEstado As System.Windows.Forms.Button
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents gbxHojasruta As System.Windows.Forms.GroupBox
    Friend WithEvents gbxHojasRutaDetalle As System.Windows.Forms.GroupBox
End Class

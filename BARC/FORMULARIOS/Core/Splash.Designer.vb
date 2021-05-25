<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splash
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
        Me.components = New System.ComponentModel.Container()
        Me.pbxBARC = New System.Windows.Forms.PictureBox()
        Me.gbxBARC = New System.Windows.Forms.Panel()
        Me.gbxCalendar = New System.Windows.Forms.Panel()
        Me.gbxCalendarContainer = New System.Windows.Forms.Panel()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.lblCalendario = New System.Windows.Forms.Label()
        Me.gbxNotif = New System.Windows.Forms.Panel()
        Me.gbxNotifContainer = New System.Windows.Forms.Panel()
        Me.lstNotif = New System.Windows.Forms.ListView()
        Me.notifTipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.notifContenido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnNotifClear = New System.Windows.Forms.Button()
        Me.lblNotifTitulo = New System.Windows.Forms.Label()
        Me.gbxStatus = New System.Windows.Forms.Panel()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.btnNotif = New System.Windows.Forms.Button()
        Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbxBARC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxBARC.SuspendLayout()
        Me.gbxCalendar.SuspendLayout()
        Me.gbxCalendarContainer.SuspendLayout()
        Me.gbxNotif.SuspendLayout()
        Me.gbxNotifContainer.SuspendLayout()
        Me.gbxStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbxBARC
        '
        Me.pbxBARC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxBARC.Image = Global.BARC.My.Resources.Resources.barc50
        Me.pbxBARC.Location = New System.Drawing.Point(0, 0)
        Me.pbxBARC.Name = "pbxBARC"
        Me.pbxBARC.Size = New System.Drawing.Size(1036, 560)
        Me.pbxBARC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxBARC.TabIndex = 0
        Me.pbxBARC.TabStop = False
        '
        'gbxBARC
        '
        Me.gbxBARC.Controls.Add(Me.gbxCalendar)
        Me.gbxBARC.Controls.Add(Me.gbxNotif)
        Me.gbxBARC.Controls.Add(Me.pbxBARC)
        Me.gbxBARC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxBARC.Location = New System.Drawing.Point(0, 0)
        Me.gbxBARC.Name = "gbxBARC"
        Me.gbxBARC.Size = New System.Drawing.Size(1036, 560)
        Me.gbxBARC.TabIndex = 2
        '
        'gbxCalendar
        '
        Me.gbxCalendar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbxCalendar.BackColor = System.Drawing.SystemColors.ControlDark
        Me.gbxCalendar.Controls.Add(Me.gbxCalendarContainer)
        Me.gbxCalendar.Location = New System.Drawing.Point(8, 308)
        Me.gbxCalendar.Name = "gbxCalendar"
        Me.gbxCalendar.Size = New System.Drawing.Size(252, 215)
        Me.gbxCalendar.TabIndex = 2
        Me.gbxCalendar.Visible = False
        '
        'gbxCalendarContainer
        '
        Me.gbxCalendarContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxCalendarContainer.BackColor = System.Drawing.SystemColors.Control
        Me.gbxCalendarContainer.Controls.Add(Me.MonthCalendar1)
        Me.gbxCalendarContainer.Controls.Add(Me.lblCalendario)
        Me.gbxCalendarContainer.Location = New System.Drawing.Point(3, 3)
        Me.gbxCalendarContainer.Name = "gbxCalendarContainer"
        Me.gbxCalendarContainer.Size = New System.Drawing.Size(246, 209)
        Me.gbxCalendarContainer.TabIndex = 0
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(9, 38)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 1
        '
        'lblCalendario
        '
        Me.lblCalendario.AutoSize = True
        Me.lblCalendario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCalendario.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblCalendario.Location = New System.Drawing.Point(9, 8)
        Me.lblCalendario.Name = "lblCalendario"
        Me.lblCalendario.Size = New System.Drawing.Size(76, 21)
        Me.lblCalendario.TabIndex = 0
        Me.lblCalendario.Text = "Calendario"
        '
        'gbxNotif
        '
        Me.gbxNotif.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxNotif.BackColor = System.Drawing.SystemColors.ControlDark
        Me.gbxNotif.Controls.Add(Me.gbxNotifContainer)
        Me.gbxNotif.Location = New System.Drawing.Point(664, 82)
        Me.gbxNotif.Name = "gbxNotif"
        Me.gbxNotif.Size = New System.Drawing.Size(360, 441)
        Me.gbxNotif.TabIndex = 1
        Me.gbxNotif.Visible = False
        '
        'gbxNotifContainer
        '
        Me.gbxNotifContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxNotifContainer.BackColor = System.Drawing.SystemColors.Control
        Me.gbxNotifContainer.Controls.Add(Me.lstNotif)
        Me.gbxNotifContainer.Controls.Add(Me.btnNotifClear)
        Me.gbxNotifContainer.Controls.Add(Me.lblNotifTitulo)
        Me.gbxNotifContainer.Location = New System.Drawing.Point(3, 3)
        Me.gbxNotifContainer.Name = "gbxNotifContainer"
        Me.gbxNotifContainer.Size = New System.Drawing.Size(354, 435)
        Me.gbxNotifContainer.TabIndex = 0
        '
        'lstNotif
        '
        Me.lstNotif.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.notifTipo, Me.notifContenido})
        Me.lstNotif.FullRowSelect = True
        Me.lstNotif.GridLines = True
        Me.lstNotif.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstNotif.Location = New System.Drawing.Point(9, 38)
        Me.lstNotif.MultiSelect = False
        Me.lstNotif.Name = "lstNotif"
        Me.lstNotif.Size = New System.Drawing.Size(337, 389)
        Me.lstNotif.TabIndex = 2
        Me.lstNotif.UseCompatibleStateImageBehavior = False
        Me.lstNotif.View = System.Windows.Forms.View.Details
        '
        'notifTipo
        '
        Me.notifTipo.Text = "Tipo"
        Me.notifTipo.Width = 76
        '
        'notifContenido
        '
        Me.notifContenido.Text = "Notificacion"
        Me.notifContenido.Width = 257
        '
        'btnNotifClear
        '
        Me.btnNotifClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNotifClear.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnNotifClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNotifClear.Location = New System.Drawing.Point(246, 8)
        Me.btnNotifClear.Name = "btnNotifClear"
        Me.btnNotifClear.Size = New System.Drawing.Size(100, 24)
        Me.btnNotifClear.TabIndex = 1
        Me.btnNotifClear.Text = "Limpiar"
        Me.btnNotifClear.UseVisualStyleBackColor = False
        '
        'lblNotifTitulo
        '
        Me.lblNotifTitulo.AutoSize = True
        Me.lblNotifTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNotifTitulo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblNotifTitulo.Location = New System.Drawing.Point(9, 8)
        Me.lblNotifTitulo.Name = "lblNotifTitulo"
        Me.lblNotifTitulo.Size = New System.Drawing.Size(168, 21)
        Me.lblNotifTitulo.TabIndex = 0
        Me.lblNotifTitulo.Text = "Notificaciones del Sistema"
        '
        'gbxStatus
        '
        Me.gbxStatus.BackColor = System.Drawing.SystemColors.Control
        Me.gbxStatus.Controls.Add(Me.lblClock)
        Me.gbxStatus.Controls.Add(Me.btnNotif)
        Me.gbxStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbxStatus.Location = New System.Drawing.Point(0, 529)
        Me.gbxStatus.Name = "gbxStatus"
        Me.gbxStatus.Size = New System.Drawing.Size(1036, 31)
        Me.gbxStatus.TabIndex = 1
        '
        'lblClock
        '
        Me.lblClock.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblClock.AutoSize = True
        Me.lblClock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClock.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblClock.Location = New System.Drawing.Point(7, 7)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(45, 17)
        Me.lblClock.TabIndex = 1
        Me.lblClock.Text = "Label1"
        Me.lblClock.Visible = False
        '
        'btnNotif
        '
        Me.btnNotif.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNotif.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnNotif.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNotif.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnNotif.Location = New System.Drawing.Point(921, 5)
        Me.btnNotif.Name = "btnNotif"
        Me.btnNotif.Size = New System.Drawing.Size(109, 20)
        Me.btnNotif.TabIndex = 0
        Me.btnNotif.Text = "Ver notificaciones"
        Me.btnNotif.UseVisualStyleBackColor = False
        '
        'tmrClock
        '
        '
        'splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1036, 560)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbxStatus)
        Me.Controls.Add(Me.gbxBARC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "splash"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pbxBARC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxBARC.ResumeLayout(False)
        Me.gbxCalendar.ResumeLayout(False)
        Me.gbxCalendarContainer.ResumeLayout(False)
        Me.gbxCalendarContainer.PerformLayout()
        Me.gbxNotif.ResumeLayout(False)
        Me.gbxNotifContainer.ResumeLayout(False)
        Me.gbxNotifContainer.PerformLayout()
        Me.gbxStatus.ResumeLayout(False)
        Me.gbxStatus.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbxBARC As System.Windows.Forms.PictureBox
    Friend WithEvents gbxBARC As System.Windows.Forms.Panel
    Friend WithEvents gbxStatus As System.Windows.Forms.Panel
    Friend WithEvents btnNotif As System.Windows.Forms.Button
    Friend WithEvents gbxNotif As System.Windows.Forms.Panel
    Friend WithEvents tmrClock As System.Windows.Forms.Timer
    Friend WithEvents gbxCalendar As System.Windows.Forms.Panel
    Friend WithEvents gbxCalendarContainer As System.Windows.Forms.Panel
    Friend WithEvents lblCalendario As System.Windows.Forms.Label
    Friend WithEvents gbxNotifContainer As System.Windows.Forms.Panel
    Friend WithEvents lstNotif As System.Windows.Forms.ListView
    Friend WithEvents notifTipo As System.Windows.Forms.ColumnHeader
    Friend WithEvents notifContenido As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnNotifClear As System.Windows.Forms.Button
    Friend WithEvents lblNotifTitulo As System.Windows.Forms.Label
    Friend WithEvents lblClock As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar

End Class

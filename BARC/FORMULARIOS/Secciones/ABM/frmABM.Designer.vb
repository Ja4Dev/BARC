<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABM
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
        Me.gbxEditorial = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnAltas = New System.Windows.Forms.Button()
        Me.gbxAutores = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbxLibros = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.gbxZonas = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.gbxCorredores = New System.Windows.Forms.GroupBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.gbxProvEd = New System.Windows.Forms.GroupBox()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.gbxProveedores = New System.Windows.Forms.GroupBox()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.btnProvAlta = New System.Windows.Forms.Button()
        Me.gbxIntereses = New System.Windows.Forms.GroupBox()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.gbxUsuarios = New System.Windows.Forms.GroupBox()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbxEditorial.SuspendLayout()
        Me.gbxAutores.SuspendLayout()
        Me.gbxLibros.SuspendLayout()
        Me.gbxZonas.SuspendLayout()
        Me.gbxCorredores.SuspendLayout()
        Me.gbxProvEd.SuspendLayout()
        Me.gbxProveedores.SuspendLayout()
        Me.gbxIntereses.SuspendLayout()
        Me.gbxUsuarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Location = New System.Drawing.Point(815, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 6
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'gbxEditorial
        '
        Me.gbxEditorial.Controls.Add(Me.Button3)
        Me.gbxEditorial.Controls.Add(Me.btnAltas)
        Me.gbxEditorial.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxEditorial.Location = New System.Drawing.Point(31, 139)
        Me.gbxEditorial.Name = "gbxEditorial"
        Me.gbxEditorial.Size = New System.Drawing.Size(351, 63)
        Me.gbxEditorial.TabIndex = 7
        Me.gbxEditorial.TabStop = False
        Me.gbxEditorial.Text = "Editoriales"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(179, 26)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(166, 30)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Modificacion"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnAltas
        '
        Me.btnAltas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAltas.Location = New System.Drawing.Point(6, 26)
        Me.btnAltas.Name = "btnAltas"
        Me.btnAltas.Size = New System.Drawing.Size(167, 30)
        Me.btnAltas.TabIndex = 0
        Me.btnAltas.Text = "Altas"
        Me.btnAltas.UseVisualStyleBackColor = True
        '
        'gbxAutores
        '
        Me.gbxAutores.Controls.Add(Me.Button1)
        Me.gbxAutores.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxAutores.Location = New System.Drawing.Point(31, 218)
        Me.gbxAutores.Name = "gbxAutores"
        Me.gbxAutores.Size = New System.Drawing.Size(351, 63)
        Me.gbxAutores.TabIndex = 8
        Me.gbxAutores.TabStop = False
        Me.gbxAutores.Text = "Autores"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(6, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(339, 30)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Modificacion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gbxLibros
        '
        Me.gbxLibros.Controls.Add(Me.Button5)
        Me.gbxLibros.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxLibros.Location = New System.Drawing.Point(31, 300)
        Me.gbxLibros.Name = "gbxLibros"
        Me.gbxLibros.Size = New System.Drawing.Size(351, 63)
        Me.gbxLibros.TabIndex = 9
        Me.gbxLibros.TabStop = False
        Me.gbxLibros.Text = "Libros"
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(6, 26)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(339, 30)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Modificacion"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'gbxZonas
        '
        Me.gbxZonas.Controls.Add(Me.Button8)
        Me.gbxZonas.Controls.Add(Me.Button10)
        Me.gbxZonas.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxZonas.Location = New System.Drawing.Point(31, 382)
        Me.gbxZonas.Name = "gbxZonas"
        Me.gbxZonas.Size = New System.Drawing.Size(351, 63)
        Me.gbxZonas.TabIndex = 9
        Me.gbxZonas.TabStop = False
        Me.gbxZonas.Text = "Zonas"
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Location = New System.Drawing.Point(179, 26)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(166, 30)
        Me.Button8.TabIndex = 11
        Me.Button8.Text = "Modificacion"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button10.Location = New System.Drawing.Point(6, 26)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(167, 30)
        Me.Button10.TabIndex = 9
        Me.Button10.Text = "Altas"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'gbxCorredores
        '
        Me.gbxCorredores.Controls.Add(Me.Button11)
        Me.gbxCorredores.Controls.Add(Me.Button13)
        Me.gbxCorredores.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxCorredores.Location = New System.Drawing.Point(31, 464)
        Me.gbxCorredores.Name = "gbxCorredores"
        Me.gbxCorredores.Size = New System.Drawing.Size(351, 63)
        Me.gbxCorredores.TabIndex = 9
        Me.gbxCorredores.TabStop = False
        Me.gbxCorredores.Text = "Corredores"
        '
        'Button11
        '
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button11.Location = New System.Drawing.Point(179, 26)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(167, 30)
        Me.Button11.TabIndex = 14
        Me.Button11.Text = "Modificacion"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button13.Location = New System.Drawing.Point(6, 26)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(167, 30)
        Me.Button13.TabIndex = 12
        Me.Button13.Text = "Altas"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(31, 528)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(351, 63)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "GroupBox6"
        Me.GroupBox6.Visible = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(466, 528)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(351, 63)
        Me.GroupBox7.TabIndex = 16
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "GroupBox7"
        Me.GroupBox7.Visible = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(466, 448)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(351, 63)
        Me.GroupBox8.TabIndex = 14
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "GroupBox8"
        Me.GroupBox8.Visible = False
        '
        'gbxProvEd
        '
        Me.gbxProvEd.Controls.Add(Me.Button23)
        Me.gbxProvEd.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxProvEd.Location = New System.Drawing.Point(466, 382)
        Me.gbxProvEd.Name = "gbxProvEd"
        Me.gbxProvEd.Size = New System.Drawing.Size(351, 63)
        Me.gbxProvEd.TabIndex = 15
        Me.gbxProvEd.TabStop = False
        Me.gbxProvEd.Text = "Proveedores-Editoriales"
        '
        'Button23
        '
        Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button23.Location = New System.Drawing.Point(7, 26)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(339, 30)
        Me.Button23.TabIndex = 26
        Me.Button23.Text = "Modificacion"
        Me.Button23.UseVisualStyleBackColor = True
        '
        'gbxProveedores
        '
        Me.gbxProveedores.Controls.Add(Me.Button20)
        Me.gbxProveedores.Controls.Add(Me.btnProvAlta)
        Me.gbxProveedores.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxProveedores.Location = New System.Drawing.Point(466, 300)
        Me.gbxProveedores.Name = "gbxProveedores"
        Me.gbxProveedores.Size = New System.Drawing.Size(351, 63)
        Me.gbxProveedores.TabIndex = 13
        Me.gbxProveedores.TabStop = False
        Me.gbxProveedores.Text = "Proveedores"
        '
        'Button20
        '
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button20.Location = New System.Drawing.Point(180, 26)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(167, 30)
        Me.Button20.TabIndex = 23
        Me.Button20.Text = "Modificacion"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'btnProvAlta
        '
        Me.btnProvAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProvAlta.Location = New System.Drawing.Point(7, 26)
        Me.btnProvAlta.Name = "btnProvAlta"
        Me.btnProvAlta.Size = New System.Drawing.Size(167, 30)
        Me.btnProvAlta.TabIndex = 21
        Me.btnProvAlta.Text = "Altas"
        Me.btnProvAlta.UseVisualStyleBackColor = True
        '
        'gbxIntereses
        '
        Me.gbxIntereses.Controls.Add(Me.Button17)
        Me.gbxIntereses.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxIntereses.Location = New System.Drawing.Point(466, 218)
        Me.gbxIntereses.Name = "gbxIntereses"
        Me.gbxIntereses.Size = New System.Drawing.Size(351, 63)
        Me.gbxIntereses.TabIndex = 12
        Me.gbxIntereses.TabStop = False
        Me.gbxIntereses.Text = "Intereses"
        '
        'Button17
        '
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button17.Location = New System.Drawing.Point(7, 26)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(339, 30)
        Me.Button17.TabIndex = 20
        Me.Button17.Text = "Modificacion"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'gbxUsuarios
        '
        Me.gbxUsuarios.Controls.Add(Me.Button14)
        Me.gbxUsuarios.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxUsuarios.Location = New System.Drawing.Point(466, 139)
        Me.gbxUsuarios.Name = "gbxUsuarios"
        Me.gbxUsuarios.Size = New System.Drawing.Size(351, 63)
        Me.gbxUsuarios.TabIndex = 11
        Me.gbxUsuarios.TabStop = False
        Me.gbxUsuarios.Text = "Usuarios"
        '
        'Button14
        '
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button14.Location = New System.Drawing.Point(6, 26)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(340, 30)
        Me.Button14.TabIndex = 17
        Me.Button14.Text = "Modificacion"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(379, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 47)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "ABM"
        '
        'frmABM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(852, 577)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.gbxCorredores)
        Me.Controls.Add(Me.gbxProvEd)
        Me.Controls.Add(Me.gbxZonas)
        Me.Controls.Add(Me.gbxProveedores)
        Me.Controls.Add(Me.gbxLibros)
        Me.Controls.Add(Me.gbxIntereses)
        Me.Controls.Add(Me.gbxAutores)
        Me.Controls.Add(Me.gbxUsuarios)
        Me.Controls.Add(Me.gbxEditorial)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmABM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM"
        Me.TopMost = True
        Me.gbxEditorial.ResumeLayout(False)
        Me.gbxAutores.ResumeLayout(False)
        Me.gbxLibros.ResumeLayout(False)
        Me.gbxZonas.ResumeLayout(False)
        Me.gbxCorredores.ResumeLayout(False)
        Me.gbxProvEd.ResumeLayout(False)
        Me.gbxProveedores.ResumeLayout(False)
        Me.gbxIntereses.ResumeLayout(False)
        Me.gbxUsuarios.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents gbxEditorial As System.Windows.Forms.GroupBox
    Friend WithEvents gbxAutores As System.Windows.Forms.GroupBox
    Friend WithEvents gbxLibros As System.Windows.Forms.GroupBox
    Friend WithEvents gbxZonas As System.Windows.Forms.GroupBox
    Friend WithEvents gbxCorredores As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents gbxProvEd As System.Windows.Forms.GroupBox
    Friend WithEvents gbxProveedores As System.Windows.Forms.GroupBox
    Friend WithEvents gbxIntereses As System.Windows.Forms.GroupBox
    Friend WithEvents gbxUsuarios As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnAltas As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents btnProvAlta As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

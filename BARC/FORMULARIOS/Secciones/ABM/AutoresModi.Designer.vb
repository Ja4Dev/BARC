﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutoresModi
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
        Me.lstAutores = New System.Windows.Forms.ListView()
        Me.codAutor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.autorNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.autorApellido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Location = New System.Drawing.Point(342, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 7
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lstAutores
        '
        Me.lstAutores.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codAutor, Me.autorNombre, Me.autorApellido})
        Me.lstAutores.FullRowSelect = True
        Me.lstAutores.Location = New System.Drawing.Point(12, 75)
        Me.lstAutores.Name = "lstAutores"
        Me.lstAutores.Size = New System.Drawing.Size(355, 293)
        Me.lstAutores.TabIndex = 8
        Me.lstAutores.UseCompatibleStateImageBehavior = False
        Me.lstAutores.View = System.Windows.Forms.View.Details
        '
        'codAutor
        '
        Me.codAutor.Text = "#"
        '
        'autorNombre
        '
        Me.autorNombre.Text = "Nombre"
        Me.autorNombre.Width = 145
        '
        'autorApellido
        '
        Me.autorApellido.Text = "Apellido"
        Me.autorApellido.Width = 143
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 37)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Modificacion Autores"
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(123, 377)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(133, 48)
        Me.btnModificar.TabIndex = 69
        Me.btnModificar.Text = "Modificar Autor"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'AutoresModi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(379, 433)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstAutores)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AutoresModi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificacion Autores"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lstAutores As System.Windows.Forms.ListView
    Friend WithEvents codAutor As System.Windows.Forms.ColumnHeader
    Friend WithEvents autorNombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents autorApellido As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
End Class

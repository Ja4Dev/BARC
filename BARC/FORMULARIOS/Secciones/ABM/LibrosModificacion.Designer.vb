﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibrosModificacion
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
        Me.lstLibros = New System.Windows.Forms.ListView()
        Me.codLibroM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.libroTituloM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.libroISBNM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.libroEditorialM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.libroFechaPM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.libroPrecioM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.libroPrecioAlqM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PPVM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PPAM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEjemplar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Location = New System.Drawing.Point(1047, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 7
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lstLibros
        '
        Me.lstLibros.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lstLibros.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codLibroM, Me.libroTituloM, Me.libroISBNM, Me.libroEditorialM, Me.libroFechaPM, Me.libroPrecioM, Me.libroPrecioAlqM, Me.PPVM, Me.PPAM})
        Me.lstLibros.FullRowSelect = True
        Me.lstLibros.Location = New System.Drawing.Point(12, 115)
        Me.lstLibros.Name = "lstLibros"
        Me.lstLibros.Size = New System.Drawing.Size(1060, 302)
        Me.lstLibros.TabIndex = 8
        Me.lstLibros.UseCompatibleStateImageBehavior = False
        Me.lstLibros.View = System.Windows.Forms.View.Details
        '
        'codLibroM
        '
        Me.codLibroM.Text = "#"
        Me.codLibroM.Width = 46
        '
        'libroTituloM
        '
        Me.libroTituloM.Text = "Titulo"
        Me.libroTituloM.Width = 253
        '
        'libroISBNM
        '
        Me.libroISBNM.Text = "ISBN"
        Me.libroISBNM.Width = 118
        '
        'libroEditorialM
        '
        Me.libroEditorialM.Text = "Editorial"
        Me.libroEditorialM.Width = 189
        '
        'libroFechaPM
        '
        Me.libroFechaPM.Text = "Fecha de Publicacion"
        Me.libroFechaPM.Width = 125
        '
        'libroPrecioM
        '
        Me.libroPrecioM.Text = "Precio Venta"
        Me.libroPrecioM.Width = 87
        '
        'libroPrecioAlqM
        '
        Me.libroPrecioAlqM.Text = "Precio Alquiler"
        Me.libroPrecioAlqM.Width = 91
        '
        'PPVM
        '
        Me.PPVM.Text = "P.P Venta"
        Me.PPVM.Width = 68
        '
        'PPAM
        '
        Me.PPAM.Text = "P.P Alquiler"
        Me.PPAM.Width = 77
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(357, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 47)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Modificacion de Libros"
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(394, 438)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(134, 48)
        Me.btnModificar.TabIndex = 68
        Me.btnModificar.Text = "Modificar Libro"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEjemplar
        '
        Me.btnEjemplar.Enabled = False
        Me.btnEjemplar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEjemplar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEjemplar.Location = New System.Drawing.Point(558, 438)
        Me.btnEjemplar.Name = "btnEjemplar"
        Me.btnEjemplar.Size = New System.Drawing.Size(133, 48)
        Me.btnEjemplar.TabIndex = 67
        Me.btnEjemplar.Text = "Modificar Ejemplares"
        Me.btnEjemplar.UseVisualStyleBackColor = True
        '
        'LibrosModificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1084, 504)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEjemplar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstLibros)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "LibrosModificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificacion de Libros"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lstLibros As System.Windows.Forms.ListView
    Friend WithEvents codLibroM As System.Windows.Forms.ColumnHeader
    Friend WithEvents libroTituloM As System.Windows.Forms.ColumnHeader
    Friend WithEvents libroISBNM As System.Windows.Forms.ColumnHeader
    Friend WithEvents libroEditorialM As System.Windows.Forms.ColumnHeader
    Friend WithEvents libroFechaPM As System.Windows.Forms.ColumnHeader
    Friend WithEvents libroPrecioM As System.Windows.Forms.ColumnHeader
    Friend WithEvents libroPrecioAlqM As System.Windows.Forms.ColumnHeader
    Friend WithEvents PPVM As System.Windows.Forms.ColumnHeader
    Friend WithEvents PPAM As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEjemplar As System.Windows.Forms.Button
End Class

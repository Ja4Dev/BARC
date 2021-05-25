<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerEjemplares
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
        Me.lstEjemplares = New System.Windows.Forms.ListView()
        Me.CodLibroEjemplares = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EjemplaresTitulo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EjemplaresISBN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EjemplaresPPV = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EjemplaresPPA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EjemplaresCantV = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EjemplaresCantA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EstadoEjemp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnGenerar = New System.Windows.Forms.Button()
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
        Me.btnBack.Location = New System.Drawing.Point(952, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 4
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lstEjemplares
        '
        Me.lstEjemplares.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstEjemplares.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CodLibroEjemplares, Me.EjemplaresTitulo, Me.EjemplaresISBN, Me.EjemplaresPPV, Me.EjemplaresPPA, Me.EjemplaresCantV, Me.EjemplaresCantA, Me.EstadoEjemp})
        Me.lstEjemplares.FullRowSelect = True
        Me.lstEjemplares.Location = New System.Drawing.Point(12, 81)
        Me.lstEjemplares.Name = "lstEjemplares"
        Me.lstEjemplares.Size = New System.Drawing.Size(965, 440)
        Me.lstEjemplares.TabIndex = 5
        Me.lstEjemplares.UseCompatibleStateImageBehavior = False
        Me.lstEjemplares.View = System.Windows.Forms.View.Details
        '
        'CodLibroEjemplares
        '
        Me.CodLibroEjemplares.Text = "#"
        Me.CodLibroEjemplares.Width = 47
        '
        'EjemplaresTitulo
        '
        Me.EjemplaresTitulo.Text = "Titulo"
        Me.EjemplaresTitulo.Width = 223
        '
        'EjemplaresISBN
        '
        Me.EjemplaresISBN.Text = "ISBN"
        Me.EjemplaresISBN.Width = 133
        '
        'EjemplaresPPV
        '
        Me.EjemplaresPPV.Text = "P.P Venta"
        Me.EjemplaresPPV.Width = 110
        '
        'EjemplaresPPA
        '
        Me.EjemplaresPPA.Text = "P.P Alquiler"
        Me.EjemplaresPPA.Width = 110
        '
        'EjemplaresCantV
        '
        Me.EjemplaresCantV.Text = "Ej. Venta"
        Me.EjemplaresCantV.Width = 100
        '
        'EjemplaresCantA
        '
        Me.EjemplaresCantA.Text = "Ej. Alquiler"
        Me.EjemplaresCantA.Width = 100
        '
        'EstadoEjemp
        '
        Me.EstadoEjemp.Text = "Estado"
        Me.EstadoEjemp.Width = 135
        '
        'btnGenerar
        '
        Me.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGenerar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Location = New System.Drawing.Point(22, 527)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(120, 55)
        Me.btnGenerar.TabIndex = 6
        Me.btnGenerar.Text = "Generar Solicitud de Compra"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(356, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 37)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Listado de Ejemplares"
        '
        'VerEjemplares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(989, 605)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.lstEjemplares)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "VerEjemplares"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Ejemplares"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lstEjemplares As System.Windows.Forms.ListView
    Friend WithEvents CodLibroEjemplares As System.Windows.Forms.ColumnHeader
    Friend WithEvents EjemplaresTitulo As System.Windows.Forms.ColumnHeader
    Friend WithEvents EjemplaresISBN As System.Windows.Forms.ColumnHeader
    Friend WithEvents EjemplaresCantV As System.Windows.Forms.ColumnHeader
    Friend WithEvents EjemplaresCantA As System.Windows.Forms.ColumnHeader
    Friend WithEvents EjemplaresPPV As System.Windows.Forms.ColumnHeader
    Friend WithEvents EjemplaresPPA As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents EstadoEjemp As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

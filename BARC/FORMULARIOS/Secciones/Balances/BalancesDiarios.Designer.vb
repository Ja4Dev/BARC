<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BalancesDiarios
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
        Me.lstBalance = New System.Windows.Forms.ListView()
        Me.idBalance = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaBalance = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BalanceDiario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFlechas = New System.Windows.Forms.Label()
        Me.lstEntradas = New System.Windows.Forms.ListView()
        Me.NumReciboBD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CodoperacionBD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MotivoBD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TotalBD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstSalidas = New System.Windows.Forms.ListView()
        Me.NChequeBD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProveBD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FacProvBD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MontoFacBD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Location = New System.Drawing.Point(1128, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.TabIndex = 6
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lstBalance
        '
        Me.lstBalance.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idBalance, Me.FechaBalance, Me.BalanceDiario})
        Me.lstBalance.FullRowSelect = True
        Me.lstBalance.Location = New System.Drawing.Point(12, 99)
        Me.lstBalance.Name = "lstBalance"
        Me.lstBalance.Size = New System.Drawing.Size(227, 514)
        Me.lstBalance.TabIndex = 7
        Me.lstBalance.UseCompatibleStateImageBehavior = False
        Me.lstBalance.View = System.Windows.Forms.View.Details
        '
        'idBalance
        '
        Me.idBalance.Text = "#"
        Me.idBalance.Width = 56
        '
        'FechaBalance
        '
        Me.FechaBalance.Text = "Fecha"
        Me.FechaBalance.Width = 98
        '
        'BalanceDiario
        '
        Me.BalanceDiario.Text = "Balance"
        Me.BalanceDiario.Width = 87
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(447, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 47)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Balances Diarios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(84, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Balances"
        '
        'lblFlechas
        '
        Me.lblFlechas.AutoSize = True
        Me.lblFlechas.Location = New System.Drawing.Point(245, 302)
        Me.lblFlechas.Name = "lblFlechas"
        Me.lblFlechas.Size = New System.Drawing.Size(16, 65)
        Me.lblFlechas.TabIndex = 44
        Me.lblFlechas.Text = "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→"
        '
        'lstEntradas
        '
        Me.lstEntradas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NumReciboBD, Me.CodoperacionBD, Me.MotivoBD, Me.TotalBD})
        Me.lstEntradas.FullRowSelect = True
        Me.lstEntradas.Location = New System.Drawing.Point(267, 99)
        Me.lstEntradas.Name = "lstEntradas"
        Me.lstEntradas.Size = New System.Drawing.Size(387, 514)
        Me.lstEntradas.TabIndex = 45
        Me.lstEntradas.UseCompatibleStateImageBehavior = False
        Me.lstEntradas.View = System.Windows.Forms.View.Details
        '
        'NumReciboBD
        '
        Me.NumReciboBD.Text = "Num Recibo"
        Me.NumReciboBD.Width = 83
        '
        'CodoperacionBD
        '
        Me.CodoperacionBD.Text = "Cod Operacion"
        Me.CodoperacionBD.Width = 98
        '
        'MotivoBD
        '
        Me.MotivoBD.Text = "Motivo"
        Me.MotivoBD.Width = 127
        '
        'TotalBD
        '
        Me.TotalBD.Text = "Monto"
        Me.TotalBD.Width = 73
        '
        'lstSalidas
        '
        Me.lstSalidas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NChequeBD, Me.ProveBD, Me.FacProvBD, Me.MontoFacBD})
        Me.lstSalidas.FullRowSelect = True
        Me.lstSalidas.Location = New System.Drawing.Point(682, 99)
        Me.lstSalidas.Name = "lstSalidas"
        Me.lstSalidas.Size = New System.Drawing.Size(470, 514)
        Me.lstSalidas.TabIndex = 46
        Me.lstSalidas.UseCompatibleStateImageBehavior = False
        Me.lstSalidas.View = System.Windows.Forms.View.Details
        '
        'NChequeBD
        '
        Me.NChequeBD.Text = "Num Cheque"
        Me.NChequeBD.Width = 98
        '
        'ProveBD
        '
        Me.ProveBD.Text = "Proveedor"
        Me.ProveBD.Width = 176
        '
        'FacProvBD
        '
        Me.FacProvBD.Text = "Num Factura"
        Me.FacProvBD.Width = 121
        '
        'MontoFacBD
        '
        Me.MontoFacBD.Text = "Monto"
        Me.MontoFacBD.Width = 66
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(660, 302)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 65)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(421, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 17)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Entradas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(891, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Salidas"
        '
        'BalancesDiarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1165, 625)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstSalidas)
        Me.Controls.Add(Me.lstEntradas)
        Me.Controls.Add(Me.lblFlechas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstBalance)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "BalancesDiarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balances Diarios"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lstBalance As System.Windows.Forms.ListView
    Friend WithEvents FechaBalance As System.Windows.Forms.ColumnHeader
    Friend WithEvents BalanceDiario As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFlechas As System.Windows.Forms.Label
    Friend WithEvents lstEntradas As System.Windows.Forms.ListView
    Friend WithEvents NumReciboBD As System.Windows.Forms.ColumnHeader
    Friend WithEvents CodoperacionBD As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstSalidas As System.Windows.Forms.ListView
    Friend WithEvents NChequeBD As System.Windows.Forms.ColumnHeader
    Friend WithEvents ProveBD As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MotivoBD As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TotalBD As System.Windows.Forms.ColumnHeader
    Friend WithEvents FacProvBD As System.Windows.Forms.ColumnHeader
    Friend WithEvents MontoFacBD As System.Windows.Forms.ColumnHeader
    Friend WithEvents idBalance As System.Windows.Forms.ColumnHeader
End Class

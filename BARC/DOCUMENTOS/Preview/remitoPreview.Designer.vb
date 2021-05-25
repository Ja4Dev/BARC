<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class remitoPreview
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
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.REncabezadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaCuotasArtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.REncabezadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaCuotasArtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource5.Name = "remitoEncabezado"
        ReportDataSource5.Value = Me.REncabezadoBindingSource
        ReportDataSource6.Name = "remitoDetalle"
        ReportDataSource6.Value = Me.FacturaCuotasArtBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BARC.Remito.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(647, 741)
        Me.ReportViewer1.TabIndex = 0
        '
        'REncabezadoBindingSource
        '
        Me.REncabezadoBindingSource.DataSource = GetType(BARC.REncabezado)
        '
        'FacturaCuotasArtBindingSource
        '
        Me.FacturaCuotasArtBindingSource.DataSource = GetType(BARC.FacturaCuotasArt)
        '
        'remitoPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 741)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "remitoPreview"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "remitoPreview"
        Me.TopMost = True
        CType(Me.REncabezadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaCuotasArtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents REncabezadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FacturaCuotasArtBindingSource As System.Windows.Forms.BindingSource
End Class

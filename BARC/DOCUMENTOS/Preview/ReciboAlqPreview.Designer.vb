<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReciboAlqPreview
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReciboAlqDatosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReciboAlqArtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.ReciboAlqDatosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReciboAlqArtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReciboAlqDatosBindingSource
        '
        Me.ReciboAlqDatosBindingSource.DataSource = GetType(BARC.ReciboAlqDatos)
        '
        'ReciboAlqArtBindingSource
        '
        Me.ReciboAlqArtBindingSource.DataSource = GetType(BARC.ReciboAlqArt)
        '
        'ReportViewer3
        '
        ReportDataSource1.Name = "Encabezado"
        ReportDataSource1.Value = Me.ReciboAlqDatosBindingSource
        ReportDataSource2.Name = "Detalle"
        ReportDataSource2.Value = Me.ReciboAlqArtBindingSource
        Me.ReportViewer3.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer3.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "BARC.ReciboAlq.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.Size = New System.Drawing.Size(657, 751)
        Me.ReportViewer3.TabIndex = 0
        '
        'ReciboAlqPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 751)
        Me.Controls.Add(Me.ReportViewer3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ReciboAlqPreview"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir recibo de alquiler"
        Me.TopMost = True
        CType(Me.ReciboAlqDatosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReciboAlqArtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReciboAlqDatosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReciboAlqArtBindingSource As System.Windows.Forms.BindingSource
End Class

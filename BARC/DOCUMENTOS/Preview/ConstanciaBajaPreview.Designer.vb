<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConstanciaBajaPreview
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
        Me.ReportViewerCB = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'ReportViewerCB
        '
        Me.ReportViewerCB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewerCB.LocalReport.ReportEmbeddedResource = "BARC.ConstanciaBajaDoc.rdlc"
        Me.ReportViewerCB.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewerCB.Name = "ReportViewerCB"
        Me.ReportViewerCB.Size = New System.Drawing.Size(650, 464)
        Me.ReportViewerCB.TabIndex = 0
        '
        'ConstanciaBajaPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 464)
        Me.Controls.Add(Me.ReportViewerCB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ConstanciaBajaPreview"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir constancia de baja"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewerCB As Microsoft.Reporting.WinForms.ReportViewer
End Class

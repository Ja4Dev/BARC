﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacCuotaPreview
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewerCuotasFac = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'ReportViewerCuotasFac
        '
        Me.ReportViewerCuotasFac.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "Encabezado"
        ReportDataSource3.Value = Nothing
        ReportDataSource4.Name = "Detalle"
        ReportDataSource4.Value = Nothing
        Me.ReportViewerCuotasFac.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewerCuotasFac.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewerCuotasFac.LocalReport.ReportEmbeddedResource = "BARC.FacRem.rdlc"
        Me.ReportViewerCuotasFac.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewerCuotasFac.Name = "ReportViewerCuotasFac"
        Me.ReportViewerCuotasFac.Size = New System.Drawing.Size(657, 751)
        Me.ReportViewerCuotasFac.TabIndex = 1
        '
        'FacCuotaPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 751)
        Me.Controls.Add(Me.ReportViewerCuotasFac)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FacCuotaPreview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documento"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewerCuotasFac As Microsoft.Reporting.WinForms.ReportViewer
End Class

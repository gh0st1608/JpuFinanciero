﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(530, 500)
        Me.ReportViewer1.TabIndex = 0
        '
        'FormReportes
        '
        Me.ClientSize = New System.Drawing.Size(554, 524)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormReportes"
        Me.Text = "Reporte"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class

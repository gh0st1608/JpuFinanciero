﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReport
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
        Me.DtReporteIngresoFiltroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsBDFinanciero = New ERP_EEA.DsBDFinanciero()
        Me.DtReporteIngresoDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LeerReporteIngresosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.DtReporteIngresoFiltroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsBDFinanciero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtReporteIngresoDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeerReporteIngresosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtReporteIngresoFiltroBindingSource
        '
        Me.DtReporteIngresoFiltroBindingSource.DataMember = "DtReporteIngresoFiltro"
        Me.DtReporteIngresoFiltroBindingSource.DataSource = Me.DsBDFinanciero
        '
        'DsBDFinanciero
        '
        Me.DsBDFinanciero.DataSetName = "DsBDFinanciero"
        Me.DsBDFinanciero.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DtReporteIngresoDataBindingSource
        '
        Me.DtReporteIngresoDataBindingSource.DataMember = "DtReporteIngresoData"
        Me.DtReporteIngresoDataBindingSource.DataSource = Me.DsBDFinanciero
        '
        'LeerReporteIngresosBindingSource
        '
        Me.LeerReporteIngresosBindingSource.DataMember = "LeerReporteIngresos"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'ReportViewer
        '
        Me.ReportViewer.Location = New System.Drawing.Point(-7, 0)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.ServerReport.BearerToken = Nothing
        Me.ReportViewer.Size = New System.Drawing.Size(809, 458)
        Me.ReportViewer.TabIndex = 0
        '
        'FormReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer)
        Me.Name = "FormReport"
        Me.Text = "FormReport"
        CType(Me.DtReporteIngresoFiltroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsBDFinanciero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtReporteIngresoDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeerReporteIngresosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents LeerReporteIngresosBindingSource As BindingSource
    Friend WithEvents DtReporteIngresoFiltroBindingSource As BindingSource
    Friend WithEvents DsBDFinanciero As DsBDFinanciero
    Friend WithEvents DtReporteIngresoDataBindingSource As BindingSource
    Friend WithEvents ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
End Class
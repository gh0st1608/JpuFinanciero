﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteFCProyectado
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
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.cboPeriodoInicialFiltro = New System.Windows.Forms.ComboBox()
        Me.lblPeriodoInicio = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(62, 42)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerar.TabIndex = 10
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'cboPeriodoInicialFiltro
        '
        Me.cboPeriodoInicialFiltro.FormattingEnabled = True
        Me.cboPeriodoInicialFiltro.Location = New System.Drawing.Point(62, 12)
        Me.cboPeriodoInicialFiltro.Name = "cboPeriodoInicialFiltro"
        Me.cboPeriodoInicialFiltro.Size = New System.Drawing.Size(89, 21)
        Me.cboPeriodoInicialFiltro.TabIndex = 1
        '
        'lblPeriodoInicio
        '
        Me.lblPeriodoInicio.AutoSize = True
        Me.lblPeriodoInicio.Location = New System.Drawing.Point(13, 15)
        Me.lblPeriodoInicio.Name = "lblPeriodoInicio"
        Me.lblPeriodoInicio.Size = New System.Drawing.Size(43, 13)
        Me.lblPeriodoInicio.TabIndex = 527
        Me.lblPeriodoInicio.Text = "Periodo"
        '
        'FormReporteFCProyectado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(160, 78)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.cboPeriodoInicialFiltro)
        Me.Controls.Add(Me.lblPeriodoInicio)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(176, 117)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(176, 117)
        Me.Name = "FormReporteFCProyectado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flujo de caja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGenerar As Button
    Friend WithEvents cboPeriodoInicialFiltro As ComboBox
    Friend WithEvents lblPeriodoInicio As Label
End Class
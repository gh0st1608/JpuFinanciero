<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteRatios
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
        Me.cboPeriodoFinalFiltro = New System.Windows.Forms.ComboBox()
        Me.cboPeriodoInicialFiltro = New System.Windows.Forms.ComboBox()
        Me.lblPeriodoFinal = New System.Windows.Forms.Label()
        Me.lblPeriodoInicio = New System.Windows.Forms.Label()
        Me.cboTipoRatioFiltro = New System.Windows.Forms.ComboBox()
        Me.lblRatio = New System.Windows.Forms.Label()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboPeriodoFinalFiltro
        '
        Me.cboPeriodoFinalFiltro.FormattingEnabled = True
        Me.cboPeriodoFinalFiltro.Location = New System.Drawing.Point(81, 67)
        Me.cboPeriodoFinalFiltro.Name = "cboPeriodoFinalFiltro"
        Me.cboPeriodoFinalFiltro.Size = New System.Drawing.Size(89, 21)
        Me.cboPeriodoFinalFiltro.TabIndex = 522
        '
        'cboPeriodoInicialFiltro
        '
        Me.cboPeriodoInicialFiltro.FormattingEnabled = True
        Me.cboPeriodoInicialFiltro.Location = New System.Drawing.Point(81, 42)
        Me.cboPeriodoInicialFiltro.Name = "cboPeriodoInicialFiltro"
        Me.cboPeriodoInicialFiltro.Size = New System.Drawing.Size(89, 21)
        Me.cboPeriodoInicialFiltro.TabIndex = 521
        '
        'lblPeriodoFinal
        '
        Me.lblPeriodoFinal.AutoSize = True
        Me.lblPeriodoFinal.Location = New System.Drawing.Point(10, 67)
        Me.lblPeriodoFinal.Name = "lblPeriodoFinal"
        Me.lblPeriodoFinal.Size = New System.Drawing.Size(68, 13)
        Me.lblPeriodoFinal.TabIndex = 520
        Me.lblPeriodoFinal.Text = "Periodo Final"
        '
        'lblPeriodoInicio
        '
        Me.lblPeriodoInicio.AutoSize = True
        Me.lblPeriodoInicio.Location = New System.Drawing.Point(10, 45)
        Me.lblPeriodoInicio.Name = "lblPeriodoInicio"
        Me.lblPeriodoInicio.Size = New System.Drawing.Size(71, 13)
        Me.lblPeriodoInicio.TabIndex = 519
        Me.lblPeriodoInicio.Text = "Periodo Inicio"
        '
        'cboTipoRatioFiltro
        '
        Me.cboTipoRatioFiltro.FormattingEnabled = True
        Me.cboTipoRatioFiltro.Location = New System.Drawing.Point(80, 17)
        Me.cboTipoRatioFiltro.Name = "cboTipoRatioFiltro"
        Me.cboTipoRatioFiltro.Size = New System.Drawing.Size(152, 21)
        Me.cboTipoRatioFiltro.TabIndex = 523
        '
        'lblRatio
        '
        Me.lblRatio.AutoSize = True
        Me.lblRatio.Location = New System.Drawing.Point(40, 22)
        Me.lblRatio.Name = "lblRatio"
        Me.lblRatio.Size = New System.Drawing.Size(32, 13)
        Me.lblRatio.TabIndex = 524
        Me.lblRatio.Text = "Ratio"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(219, 110)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerar.TabIndex = 526
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(138, 110)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 525
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        Me.btnCancelar.Visible = False
        '
        'FormReporteRatios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 139)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblRatio)
        Me.Controls.Add(Me.cboTipoRatioFiltro)
        Me.Controls.Add(Me.cboPeriodoFinalFiltro)
        Me.Controls.Add(Me.cboPeriodoInicialFiltro)
        Me.Controls.Add(Me.lblPeriodoFinal)
        Me.Controls.Add(Me.lblPeriodoInicio)
        Me.Name = "FormReporteRatios"
        Me.Text = "Ratios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboPeriodoFinalFiltro As ComboBox
    Friend WithEvents cboPeriodoInicialFiltro As ComboBox
    Friend WithEvents lblPeriodoFinal As Label
    Friend WithEvents lblPeriodoInicio As Label
    Friend WithEvents cboTipoRatioFiltro As ComboBox
    Friend WithEvents lblRatio As Label
    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnCancelar As Button
End Class

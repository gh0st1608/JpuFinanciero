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
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboPeriodoFinalFiltro
        '
        Me.cboPeriodoFinalFiltro.FormattingEnabled = True
        Me.cboPeriodoFinalFiltro.Location = New System.Drawing.Point(90, 37)
        Me.cboPeriodoFinalFiltro.Name = "cboPeriodoFinalFiltro"
        Me.cboPeriodoFinalFiltro.Size = New System.Drawing.Size(89, 21)
        Me.cboPeriodoFinalFiltro.TabIndex = 2
        '
        'cboPeriodoInicialFiltro
        '
        Me.cboPeriodoInicialFiltro.FormattingEnabled = True
        Me.cboPeriodoInicialFiltro.Location = New System.Drawing.Point(90, 12)
        Me.cboPeriodoInicialFiltro.Name = "cboPeriodoInicialFiltro"
        Me.cboPeriodoInicialFiltro.Size = New System.Drawing.Size(89, 21)
        Me.cboPeriodoInicialFiltro.TabIndex = 1
        '
        'lblPeriodoFinal
        '
        Me.lblPeriodoFinal.AutoSize = True
        Me.lblPeriodoFinal.Location = New System.Drawing.Point(13, 37)
        Me.lblPeriodoFinal.Name = "lblPeriodoFinal"
        Me.lblPeriodoFinal.Size = New System.Drawing.Size(68, 13)
        Me.lblPeriodoFinal.TabIndex = 520
        Me.lblPeriodoFinal.Text = "Periodo Final"
        '
        'lblPeriodoInicio
        '
        Me.lblPeriodoInicio.AutoSize = True
        Me.lblPeriodoInicio.Location = New System.Drawing.Point(13, 15)
        Me.lblPeriodoInicio.Name = "lblPeriodoInicio"
        Me.lblPeriodoInicio.Size = New System.Drawing.Size(71, 13)
        Me.lblPeriodoInicio.TabIndex = 519
        Me.lblPeriodoInicio.Text = "Periodo Inicio"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(55, 66)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerar.TabIndex = 10
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'FormReporteRatios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(190, 100)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.cboPeriodoFinalFiltro)
        Me.Controls.Add(Me.cboPeriodoInicialFiltro)
        Me.Controls.Add(Me.lblPeriodoFinal)
        Me.Controls.Add(Me.lblPeriodoInicio)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(206, 139)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(206, 139)
        Me.Name = "FormReporteRatios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ratios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboPeriodoFinalFiltro As ComboBox
    Friend WithEvents cboPeriodoInicialFiltro As ComboBox
    Friend WithEvents lblPeriodoFinal As Label
    Friend WithEvents lblPeriodoInicio As Label
    Friend WithEvents btnGenerar As Button
End Class

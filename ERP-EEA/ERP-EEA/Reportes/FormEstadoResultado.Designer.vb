<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEstadoResultado
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
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbPeriodoInicio = New System.Windows.Forms.ComboBox()
        Me.cbPeriodoFin = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(101, 70)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerar.TabIndex = 10
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 515
        Me.Label1.Text = "Periodo Final"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 15)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 13)
        Me.Label17.TabIndex = 514
        Me.Label17.Text = "Periodo Inicio"
        '
        'cbPeriodoInicio
        '
        Me.cbPeriodoInicio.FormattingEnabled = True
        Me.cbPeriodoInicio.Location = New System.Drawing.Point(101, 12)
        Me.cbPeriodoInicio.Name = "cbPeriodoInicio"
        Me.cbPeriodoInicio.Size = New System.Drawing.Size(125, 21)
        Me.cbPeriodoInicio.TabIndex = 1
        '
        'cbPeriodoFin
        '
        Me.cbPeriodoFin.FormattingEnabled = True
        Me.cbPeriodoFin.Location = New System.Drawing.Point(101, 39)
        Me.cbPeriodoFin.Name = "cbPeriodoFin"
        Me.cbPeriodoFin.Size = New System.Drawing.Size(125, 21)
        Me.cbPeriodoFin.TabIndex = 2
        '
        'FormEstadoResultado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 105)
        Me.Controls.Add(Me.cbPeriodoFin)
        Me.Controls.Add(Me.cbPeriodoInicio)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(259, 144)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(259, 144)
        Me.Name = "FormEstadoResultado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado de Resultados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGenerar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cbPeriodoInicio As ComboBox
    Friend WithEvents cbPeriodoFin As ComboBox
End Class

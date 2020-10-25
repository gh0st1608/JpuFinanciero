Imports ERP_Negocio
Imports ERP_Entidad

Public Class FormParametro
#Region "Variables"
    Dim negParametro As New NegParametro
    Dim entParametro As New EntParametro
    Dim operacion As Boolean = False
    Dim dataTable As DataTable
#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        Me.Height = 316
        txtIdParametro.Text = "0"
        txtDescripcion.Text = ""
        txtValorParametro.Text = ""
        btnNuevo.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        cboTipoParametro.SelectedIndex = 0
        cboEstado.Visible = False
        lblEstado.Visible = False
        dgvParametro.Enabled = True
        CargarTabla()
    End Sub

    Private Sub ModoRegistro()
        Me.Height = 428
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        dgvParametro.Enabled = False
    End Sub
#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarTabla()
        dataTable = negParametro.ObtenerTabla()
        dgvParametro.DataSource = dataTable
        If dataTable.Rows.Count > 0 Then
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            dgvParametro.Enabled = True
        End If
    End Sub
#End Region

#Region "Funciones Principales (CRUD)"
    Private Sub CrearParametro()
        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entParametro.Descripcion = txtDescripcion.Text
        End If
        If cboTipoParametro.SelectedIndex = 0 Then
            MsgBox("Escoger el tipo de parámetro", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entParametro.TipoParametro = cboTipoParametro.Text
        End If
        entParametro.ValorParametro = txtValorParametro.Text
        entParametro.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        operacion = negParametro.Guardar(entParametro)
        If operacion Then
            MsgBox("Creó con exito", MsgBoxStyle.Information, "Crear Parametro")
        Else
            MsgBox("No creó", MsgBoxStyle.Critical, "Crear Parametro")
        End If
    End Sub

    Private Sub LeerParametro() 'Item
        entParametro = negParametro.ObtenerData(dgvParametro.CurrentRow.Cells("IdParametro").Value)

        txtIdParametro.Text = entParametro.IdParametro
        txtDescripcion.Text = entParametro.Descripcion
        cboTipoParametro.Text = entParametro.TipoParametro
        txtValorParametro.Text = entParametro.ValorParametro

        If (entParametro.IdEstadoActivo = 0) Then
            cboEstado.Visible = True
            lblEstado.Visible = True
            cboTipoParametro.Enabled = False
            cboEstado.Text = "INACTIVO"
        End If
    End Sub

    Private Sub ActualizarParametro()
        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entParametro.Descripcion = txtDescripcion.Text
        End If
        If cboTipoParametro.SelectedIndex = 0 Then
            MsgBox("Escoger el tipo de parámetro", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entParametro.TipoParametro = cboTipoParametro.Text
        End If
        entParametro.ValorParametro = txtValorParametro.Text
        entParametro.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        If (cboEstado.SelectedItem = "INACTIVO") Then
            entParametro.IdEstadoActivo = 0
        Else
            entParametro.IdEstadoActivo = 1
        End If

        operacion = negParametro.Actualizar(entParametro)
        If operacion Then
            MsgBox("Actualizó con exito", MsgBoxStyle.Information, "Actualizar Parametro")
        Else
            MsgBox("No actualizó", MsgBoxStyle.Critical, "Actualizar Parametro")
        End If
    End Sub
    Private Sub EliminarParametro()
        entParametro.IdParametro = Int(dgvParametro.CurrentRow.Cells("IdParametro").Value)
        entParametro.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        operacion = negParametro.Eliminar(entParametro)

        If operacion Then
            MsgBox("Eliminó con exito", MsgBoxStyle.Information, "Eliminar Parametro")
        Else
            MsgBox("No eliminó", MsgBoxStyle.Critical, "Eliminar Parametro")
        End If
    End Sub
#End Region

#Region "Funciones del formulario"
    Private Sub FormGrupoIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModoInicial()
    End Sub

    Private Sub FormGrupoIngreso_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 Then
            LeerParametro()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete Then
            EliminarParametro()
            ModoInicial()
        End If
    End Sub
#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdParametro.Text = "0" Then
            CrearParametro()
        Else
            ActualizarParametro()
        End If
        If operacion Then
            ModoInicial()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LeerParametro()
        ModoRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarParametro()
        ModoInicial()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub
#End Region

End Class
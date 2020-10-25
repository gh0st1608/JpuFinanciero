Imports ERP_Negocio
Imports ERP_Entidad

Public Class formGrupoPasivo
#Region "Variables"
    Dim negGrupoPasivo As New NegGrupoPasivo
    Dim entGrupoPasivo As New EntGrupoPasivo
    Dim operacion As Boolean = False
    Dim dataTable As DataTable
#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        Me.Height = 305
        txtIdGrupoPasivo.Text = "0"
        txtDescripcion.Text = ""
        btnNuevo.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        cboEstado.Visible = False
        lbEstado.Visible = False
        dgvGrupoPasivo.Enabled = False
        CargarTabla()
    End Sub

    Private Sub ModoRegistro()
        Me.Height = 416
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        dgvGrupoPasivo.Enabled = False
    End Sub
#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarTabla()
        dataTable = negGrupoPasivo.ObtenerTabla()
        dgvGrupoPasivo.DataSource = dataTable
        If dgvGrupoPasivo.Rows.Count > 0 Then
            dgvGrupoPasivo.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        End If
    End Sub
#End Region

#Region "Funciones Principales (CRUD)"
    Private Sub CrearGrupoPasivo()
        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entGrupoPasivo.Descripcion = txtDescripcion.Text
        End If
        If cbTipo.SelectedIndex = 0 Then
            MsgBox("Escoger tipo", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entGrupoPasivo.IdTipo = cbTipo.SelectedIndex
        End If
        entGrupoPasivo.Cuenta = 0
        entGrupoPasivo.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        operacion = negGrupoPasivo.Guardar(entGrupoPasivo)
        If operacion Then
            MsgBox("Creó con exito", MsgBoxStyle.Information, "Crear Grupo Pasivo")
        Else
            MsgBox("No creó", MsgBoxStyle.Critical, "Crear Grupo Pasivo")
        End If
    End Sub

    Private Sub LeerGrupoPasivo()
        entGrupoPasivo = negGrupoPasivo.ObtenerData(dgvGrupoPasivo.CurrentRow.Cells("IdGrupoPasivo").Value)
        txtIdGrupoPasivo.Text = entGrupoPasivo.IdGrupoPasivo
        txtDescripcion.Text = entGrupoPasivo.Descripcion
        cbTipo.SelectedIndex = entGrupoPasivo.IdTipo

        If (entGrupoPasivo.IdEstadoActivo = 0) Then
            cboEstado.Visible = True
            cboEstado.Text = "INACTIVO"
        End If
    End Sub

    Private Sub ActualizarGrupoPasivo()
        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion")
            Exit Sub
        Else
            entGrupoPasivo.Descripcion = txtDescripcion.Text
        End If
        If cbTipo.SelectedIndex = 0 Then
            MsgBox("Escoger tipo", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entGrupoPasivo.IdTipo = cbTipo.SelectedIndex
        End If
        entGrupoPasivo.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        If (cboEstado.SelectedItem = "INACTIVO") Then
            entGrupoPasivo.IdEstadoActivo = 0
        Else
            entGrupoPasivo.IdEstadoActivo = 1
        End If

        operacion = negGrupoPasivo.Actualizar(entGrupoPasivo)
        If operacion Then
            MsgBox("Actualizó con exito", MsgBoxStyle.Information, "Actualizar Grupo Pasivo")
        Else
            MsgBox("No actualizó", MsgBoxStyle.Critical, "Actualizar Grupo Pasivo")
        End If
    End Sub
    Private Sub EliminarGrupoPasivo()
        entGrupoPasivo.IdGrupoPasivo = Int(dgvGrupoPasivo.CurrentRow.Cells("IDGrupoPasivo").Value)
        entGrupoPasivo.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        operacion = negGrupoPasivo.Eliminar(entGrupoPasivo)
        If operacion Then
            MsgBox("Eliminó con exito", MsgBoxStyle.Information, "Eliminar Grupo Pasivo")
        Else
            MsgBox("No eliminó", MsgBoxStyle.Critical, "Eliminar Grupo Pasivo")
        End If
    End Sub
#End Region

#Region "Funciones del formulario"
    Private Sub FormGrupoPasivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModoInicial()
    End Sub

    Private Sub FormGrupoPasivo_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 Then
            LeerGrupoPasivo()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete Then
            EliminarGrupoPasivo()
            ModoInicial()
        End If
    End Sub
#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdGrupoPasivo.Text = "0" Then
            CrearGrupoPasivo()
        Else
            ActualizarGrupoPasivo()
        End If
        If operacion Then
            ModoInicial()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LeerGrupoPasivo()
        ModoRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarGrupoPasivo()
        ModoInicial()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub
#End Region
End Class
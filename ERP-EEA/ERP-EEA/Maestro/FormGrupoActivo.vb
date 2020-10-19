Imports ERP_Negocio
Imports ERP_Entidad

Public Class FormGrupoActivo
#Region "Variables"

    Dim negGrupoActivo As New NegGrupoActivo
    Dim entGrupoActivo As New EntGrupoActivo
    Dim operacion As Boolean = False
    Dim dataTable As DataTable

#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        Me.Height = 307
        txtIdGrupoActivo.Text = "0"
        txtDescripcion.Text = ""
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        cboEstado.Visible = False
        CargarTabla()
    End Sub

    Private Sub ModoRegistro()
        Me.Height = 392
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub


#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarTabla()
        dataTable = negGrupoActivo.ObtenerTabla() 'Puedo enviarte filtros si no fueran maestros
        dgvGrupoActivo.DataSource = dataTable
    End Sub


#End Region

#Region "Funciones Principales (CRUD)"
    Private Sub CrearGrupoActivo()
        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion")
            Exit Sub
        Else
            entGrupoActivo.Descripcion = txtDescripcion.Text
        End If

        entGrupoActivo.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        operacion = negGrupoActivo.Guardar(entGrupoActivo)

        If operacion Then
            MsgBox("Guardo con exito")
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
    Private Sub LeerGrupoActivo() 'Item
        entGrupoActivo = negGrupoActivo.ObtenerData(dgvGrupoActivo.CurrentRow.Cells("IdGrupoActivo").Value)

        txtIdGrupoActivo.Text = entGrupoActivo.IdGrupoActivo
        txtDescripcion.Text = entGrupoActivo.Descripcion

        If (entGrupoActivo.IdEstadoActivo = 0) Then
            cboEstado.Visible = True
            cboEstado.Text = "INACTIVO"
        End If
    End Sub
    Private Sub ActualizarGrupoActivo()
        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion")
            Exit Sub
        Else
            entGrupoActivo.Descripcion = txtDescripcion.Text
        End If

        entGrupoActivo.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        If (cboEstado.SelectedItem = "ACTIVO") Then
            entGrupoActivo.IdEstadoActivo = 1
        Else
            entGrupoActivo.IdEstadoActivo = 0
        End If

        operacion = negGrupoActivo.Actualizar(entGrupoActivo)

        If operacion Then
            MsgBox("Guardo con exito")
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
    Private Sub EliminarGrupoActivo()
        entGrupoActivo.IdGrupoActivo = Int(dgvGrupoActivo.CurrentRow.Cells("IDGrupoActivo").Value)
        entGrupoActivo.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        operacion = negGrupoActivo.Eliminar(entGrupoActivo)

        If operacion Then
            MsgBox("Guardo con exito")
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
#End Region

#Region "Funciones del formulario"
    Private Sub FormGrupoActivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModoInicial()
    End Sub

    Private Sub FormGrupoActivo_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 Then
            LeerGrupoActivo()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete Then
            EliminarGrupoActivo()
        End If
    End Sub
#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdGrupoActivo.Text = "0" Then
            CrearGrupoActivo()
        Else
            ActualizarGrupoActivo()
        End If
        ModoInicial()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LeerGrupoActivo()
        ModoRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarGrupoActivo()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub
#End Region

End Class
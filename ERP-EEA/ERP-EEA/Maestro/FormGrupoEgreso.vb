Imports ERP_Negocio
Imports ERP_Entidad

Public Class FormGrupoEgreso

#Region "Variables"

    Dim negGrupoEgreso As New NegGrupoEgreso
    Dim entGrupoEgreso As New EntGrupoEgreso
    Dim operacion As Boolean = False
    Dim dataTable As DataTable

#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        Me.Height = 307
        txtIdGrupoEgreso.Text = "0"
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
        dataTable = negGrupoEgreso.ObtenerTabla() 'Puedo enviarte filtros si no fueran maestros
        dgvGrupoEgreso.DataSource = dataTable
    End Sub


#End Region

#Region "Funciones Principales (CRUD)"
    Private Sub CrearGrupoEgreso()
        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion")
            Exit Sub
        Else
            entGrupoEgreso.Descripcion = txtDescripcion.Text
        End If

        entGrupoEgreso.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        operacion = negGrupoEgreso.Guardar(entGrupoEgreso)

        If operacion Then
            MsgBox("Guardo con exito")
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
    Private Sub LeerGrupoEgreso() 'Item
        entGrupoEgreso = negGrupoEgreso.ObtenerData(dgvGrupoEgreso.CurrentRow.Cells("IdGrupoEgreso").Value)

        txtIdGrupoEgreso.Text = entGrupoEgreso.IdGrupoEgreso
        txtDescripcion.Text = entGrupoEgreso.Descripcion

        If (entGrupoEgreso.IdEstadoActivo = 0) Then
            cboEstado.Visible = True
            cboEstado.Text = "INACTIVO"
        End If
    End Sub
    Private Sub ActualizarGrupoEgreso()
        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion")
            Exit Sub
        Else
            entGrupoEgreso.Descripcion = txtDescripcion.Text
        End If

        entGrupoEgreso.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        If (cboEstado.SelectedItem = "ACTIVO") Then
            entGrupoEgreso.IdEstadoActivo = 1
        Else
            entGrupoEgreso.IdEstadoActivo = 0
        End If

        operacion = negGrupoEgreso.Actualizar(entGrupoEgreso)

        If operacion Then
            MsgBox("Guardo con exito")
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
    Private Sub EliminarGrupoEgreso()
        entGrupoEgreso.IdGrupoEgreso = Int(dgvGrupoEgreso.CurrentRow.Cells("IDGrupoEgreso").Value)
        entGrupoEgreso.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        operacion = negGrupoEgreso.Eliminar(entGrupoEgreso)

        If operacion Then
            MsgBox("Guardo con exito")
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
#End Region

#Region "Funciones del formulario"
    Private Sub FormGrupoEgreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModoInicial()
    End Sub

    Private Sub FormGrupoEgreso_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 Then
            LeerGrupoEgreso()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete Then
            EliminarGrupoEgreso()
        End If
    End Sub
#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdGrupoEgreso.Text = "0" Then
            CrearGrupoEgreso()
        Else
            ActualizarGrupoEgreso()
        End If
        ModoInicial()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LeerGrupoEgreso()
        ModoRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarGrupoEgreso()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub

#End Region

End Class
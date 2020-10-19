Imports ERP_Negocio
Imports ERP_Entidad

Public Class FormSubGrupoEgreso

#Region "Variables"

    Dim negSubGrupoEgreso As New NegSubGrupoEgreso
    Dim negGrupoEgreso As New NegGrupoEgreso
    Dim entSubGrupoEgreso As New EntSubGrupoEgreso
    Dim operacion As Boolean = False
    Dim dataTable As DataTable

#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        Me.Height = 304
        txtIdSubGrupoEgreso.Text = "0"
        cboGrupoEgreso.SelectedValue = 0
        txtDescripcion.Text = ""
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        lbEstado.Visible = False
        cboEstado.Visible = False
        CargarTabla()
    End Sub

    Private Sub ModoRegistro()
        Me.Height = 409
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub


#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarTabla()
        dataTable = negSubGrupoEgreso.ObtenerTabla() 'Puedo enviarte filtros si no fueran maestros
        dgvSubGrupoEgreso.DataSource = dataTable
    End Sub

    Private Sub CargarCombo()
        cboGrupoEgreso.ValueMember = "IdGrupoEgreso"
        cboGrupoEgreso.DisplayMember = "Descripcion"
        cboGrupoEgreso.DataSource = negGrupoEgreso.ObtenerLista(False, True)
    End Sub
#End Region

#Region "Funciones Principales (CRUD)"
    Private Sub CrearSubGrupoEgreso()
        If cboGrupoEgreso.SelectedValue = 0 Then
            MsgBox("Escoger grupo egreso")
            Exit Sub
        Else
            entSubGrupoEgreso.GrupoEgresoId = cboGrupoEgreso.SelectedValue
        End If

        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion")
            Exit Sub
        Else
            entSubGrupoEgreso.ItemSubGrupoEgreso = txtDescripcion.Text
        End If

        entSubGrupoEgreso.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        operacion = negSubGrupoEgreso.Guardar(entSubGrupoEgreso)

        If operacion Then
            MsgBox("Guardo con exito")
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
    Private Sub LeerSubGrupoEgreso() 'Item
        entSubGrupoEgreso = negSubGrupoEgreso.ObtenerData(dgvSubGrupoEgreso.CurrentRow.Cells("IdSubGrupoEgreso").Value)

        txtIdSubGrupoEgreso.Text = entSubGrupoEgreso.IdSubGrupoEgreso
        cboGrupoEgreso.SelectedValue = entSubGrupoEgreso.GrupoEgresoId
        txtDescripcion.Text = entSubGrupoEgreso.ItemSubGrupoEgreso

        If (entSubGrupoEgreso.IdEstadoActivo = 0) Then
            cboEstado.Visible = True
            lbEstado.Visible = True
            cboEstado.Text = "INACTIVO"
        End If
    End Sub
    Private Sub ActualizarSubGrupoEgreso()
        If cboGrupoEgreso.SelectedValue = 0 Then
            MsgBox("Escoger grupo egreso")
            Exit Sub
        Else
            entSubGrupoEgreso.GrupoEgresoId = cboGrupoEgreso.SelectedValue
        End If

        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion")
            Exit Sub
        Else
            entSubGrupoEgreso.ItemSubGrupoEgreso = txtDescripcion.Text
        End If

        entSubGrupoEgreso.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        If (cboEstado.SelectedItem = "ACTIVO") Then
            entSubGrupoEgreso.IdEstadoActivo = 1
        End If

        operacion = negSubGrupoEgreso.Actualizar(entSubGrupoEgreso)

        If operacion Then
            MsgBox("Guardo con exito")
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
    Private Sub EliminarSubGrupoEgreso()
        entSubGrupoEgreso.IdSubGrupoEgreso = Int(dgvSubGrupoEgreso.CurrentRow.Cells("IDSubGrupoEgreso").Value)
        entSubGrupoEgreso.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        operacion = negSubGrupoEgreso.Eliminar(entSubGrupoEgreso)

        If operacion Then
            MsgBox("Guardo con exito")
            CargarTabla()
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
#End Region

#Region "Funciones del formulario"
    Private Sub FormSubGrupoEgreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo()
        ModoInicial()
    End Sub

    Private Sub FormSubGrupoEgreso_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 Then
            LeerSubGrupoEgreso()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete Then
            EliminarSubGrupoEgreso()
        End If
    End Sub
#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdSubGrupoEgreso.Text = "0" Then
            CrearSubGrupoEgreso()
        Else
            ActualizarSubGrupoEgreso()
        End If
        ModoInicial()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LeerSubGrupoEgreso()
        ModoRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarSubGrupoEgreso()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub

#End Region

End Class
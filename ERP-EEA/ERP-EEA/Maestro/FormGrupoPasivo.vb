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
        Me.Height = 307
        txtIdGrupoPasivo.Text = "0"
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
        dataTable = negGrupoPasivo.ObtenerTabla() 'Puedo enviarte filtros si no fueran maestros
        dgvGrupoPasivo.DataSource = dataTable
    End Sub


#End Region

#Region "Funciones Principales (CRUD)"
    Private Sub CrearGrupoPasivo()
        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion")
            Exit Sub
        Else
            entGrupoPasivo.Descripcion = txtDescripcion.Text
        End If

        entGrupoPasivo.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        operacion = negGrupoPasivo.Guardar(entGrupoPasivo)

        If operacion Then
            MsgBox("Guardo con exito")
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
    Private Sub LeerGrupoPasivo() 'Item
        entGrupoPasivo = negGrupoPasivo.ObtenerData(dgvGrupoPasivo.CurrentRow.Cells("IdGrupoPasivo").Value)

        txtIdGrupoPasivo.Text = entGrupoPasivo.IdGrupoPasivo
        txtDescripcion.Text = entGrupoPasivo.Descripcion

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

        entGrupoPasivo.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        If (cboEstado.SelectedItem = "ACTIVO") Then
            entGrupoPasivo.IdEstadoActivo = 1
        Else
            entGrupoPasivo.IdEstadoActivo = 0
        End If

        operacion = negGrupoPasivo.Actualizar(entGrupoPasivo)

        If operacion Then
            MsgBox("Guardo con exito")
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
    Private Sub EliminarGrupoPasivo()
        entGrupoPasivo.IdGrupoPasivo = Int(dgvGrupoPasivo.CurrentRow.Cells("IDGrupoPasivo").Value)
        entGrupoPasivo.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        operacion = negGrupoPasivo.Eliminar(entGrupoPasivo)

        If operacion Then
            MsgBox("Guardo con exito")
        Else
            MsgBox("No guardo bien")
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
        ModoInicial()
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
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub
#End Region

End Class

Imports ERP_Negocio
Imports ERP_Entidad

Public Class FormGrupoIngreso

#Region "Variables"

    Dim negGrupoIngreso As New NegGrupoIngreso
    Dim entGrupoIngreso As New EntGrupoIngreso
    Dim operacion As Boolean = False
    Dim dataTable As DataTable

#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        Me.Height = 307
        txtIdGrupoIngreso.Text = "0"
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
        dataTable = negGrupoIngreso.ObtenerTabla() 'Puedo enviarte filtros si no fueran maestros
        dgvGrupoIngreso.DataSource = dataTable
    End Sub


#End Region

#Region "Funciones Principales (CRUD)"
    Private Sub CrearGrupoIngreso()
        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion")
            Exit Sub
        Else
            entGrupoIngreso.Descripcion = txtDescripcion.Text
        End If

        entGrupoIngreso.UsuarioCreacionId = 1

        operacion = negGrupoIngreso.Guardar(entGrupoIngreso)

        If operacion Then
            MsgBox("Guardo con exito")
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
    Private Sub LeerGrupoIngreso() 'Item
        entGrupoIngreso = negGrupoIngreso.ObtenerData(dgvGrupoIngreso.CurrentRow.Cells("IdGrupoIngreso").Value)

        txtIdGrupoIngreso.Text = entGrupoIngreso.IdGrupoIngreso
        txtDescripcion.Text = entGrupoIngreso.Descripcion

        If (entGrupoIngreso.IdEstadoActivo = 0) Then
            cboEstado.Visible = True
            cboEstado.Text = "INACTIVO"
        End If
    End Sub
    Private Sub ActualizarGrupoIngreso()
        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion")
            Exit Sub
        Else
            entGrupoIngreso.Descripcion = txtDescripcion.Text
        End If

        entGrupoIngreso.UsuarioModificacionId = 1

        If (cboEstado.SelectedItem = "ACTIVO") Then
            entGrupoIngreso.IdEstadoActivo = 1
        Else
            entGrupoIngreso.IdEstadoActivo = 0
        End If

        operacion = negGrupoIngreso.Actualizar(entGrupoIngreso)

        If operacion Then
            MsgBox("Guardo con exito")
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
    Private Sub EliminarGrupoIngreso()
        entGrupoIngreso.IdGrupoIngreso = Int(dgvGrupoIngreso.CurrentRow.Cells("IDGrupoIngreso").Value)
        entGrupoIngreso.UsuarioModificacionId = 1

        operacion = negGrupoIngreso.Eliminar(entGrupoIngreso)

        If operacion Then
            MsgBox("Guardo con exito")
        Else
            MsgBox("No guardo bien")
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
            LeerGrupoIngreso()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete Then
            EliminarGrupoIngreso()
        End If
    End Sub
#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdGrupoIngreso.Text = "0" Then
            CrearGrupoIngreso()
        Else
            ActualizarGrupoIngreso()
        End If
        ModoInicial()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LeerGrupoIngreso()
        ModoRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarGrupoIngreso()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub
#End Region

End Class
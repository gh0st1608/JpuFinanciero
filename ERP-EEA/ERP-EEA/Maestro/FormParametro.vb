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
        Me.Height = 307
        txtIdParametro.Text = "0"
        txtDescripcion.Text = ""
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        cboEstado.Visible = False
        lblEstado.Visible = False
        cboTipoParametro.Visible = True

        CargarTabla()
    End Sub

    Private Sub ModoRegistro()
        'Me.Height = 392
        Me.Height = 490
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False

    End Sub


#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarTabla()
        dataTable = negParametro.ObtenerTabla() 'Puedo enviarte filtros si no fueran maestros
        dgvParametro.DataSource = dataTable
    End Sub

#End Region

#Region "Funciones Principales (CRUD)"
    Private Sub CrearParametro()
        If txtDescripcion.Text = "" Then
            MsgBox("Ingresar descripcion")
            Exit Sub
        Else
            entParametro.Descripcion = txtDescripcion.Text
        End If

        entParametro.TipoParametro = cboTipoParametro.Text
        entParametro.UsuarioCreacionId = 1

        operacion = negParametro.Guardar(entParametro)

        If operacion Then
            MsgBox("Guardo con exito")
        Else
            MsgBox("No guardo bien")
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
            MsgBox("Ingresar descripcion")
            Exit Sub
        Else
            entParametro.Descripcion = txtDescripcion.Text
        End If

        entParametro.UsuarioModificacionId = 1

        If (cboEstado.SelectedItem = "ACTIVO") Then
            entParametro.IdEstadoActivo = 1
        Else
            entParametro.IdEstadoActivo = 0
        End If

        If (cboTipoParametro.SelectedItem = "AUXILIAR") Then
            entParametro.TipoParametro = "AUXILIAR"
        Else
            entParametro.TipoParametro = "MEDICION"
        End If

        operacion = negParametro.Actualizar(entParametro)

        If operacion Then
            MsgBox("Guardo con exito")
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
    Private Sub EliminarParametro()
        entParametro.IdParametro = Int(dgvParametro.CurrentRow.Cells("IdParametro").Value)
        entParametro.UsuarioModificacionId = 1

        operacion = negParametro.Eliminar(entParametro)

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
            LeerParametro()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete Then
            EliminarParametro()
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
        ModoInicial()
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
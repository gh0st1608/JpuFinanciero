Imports System.IO
Imports System.Globalization
Imports ERP_Entidad
Imports ERP_Negocio

Public Class FormActivo
#Region "Variables"

    Dim negActivo As New NegActivo
    Dim entActivo As New EntActivo
    Dim entGrupoActivo As New EntGrupoActivo
    Dim negGrupoActivo As New NegGrupoActivo
    Dim operacion As Boolean = False
    Dim negPeriodo As New NegPeriodo
    Dim negMetodoPago As New NegMetodoPago
    Dim dataTable As New DataTable
    Dim list As New List(Of String)
    Dim respaldo As Decimal
    Dim cantActivos As Integer
    Dim blnActualizar As Boolean = False

#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        CargarTablaActivo()
        dgvActivo.Enabled = True
        Me.Height = 273
        txtIdActivo.Text = "0"
        cboPeriodo.SelectedValue = 0
        btnNuevo.Enabled = True
        If cantActivos = 0 Then
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
        Else
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        End If
        dgvActivo.Enabled = True
        PanelActivo.Visible = True

    End Sub

    Private Sub ModoRegistro()
        Me.Height = 460
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        dgvActivo.Enabled = False
        PanelActivo.Visible = True
    End Sub


#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarTablaActivo()
        dataTable = negActivo.ObtenerTabla(0, cbPeriodoFiltro.SelectedValue)
        dgvActivo.DataSource = dataTable
        cantActivos = dgvActivo.Rows.Count
    End Sub


    Private Sub CargarCombo()

        cboTipoActivo.ValueMember = "IdGrupoActivo"
        cboTipoActivo.DisplayMember = "Descripcion"
        cboTipoActivo.DataSource = negGrupoActivo.ObtenerLista(False, True)

        cboPeriodo.ValueMember = "IdPeriodo"
        cboPeriodo.DisplayMember = "DescripcionPeriodo"
        cboPeriodo.DataSource = negPeriodo.ObtenerLista(False, True)

        cbPeriodoFiltro.ValueMember = "IdPeriodo"
        cbPeriodoFiltro.DisplayMember = "DescripcionPeriodo"
        cbPeriodoFiltro.DataSource = negPeriodo.ObtenerLista(True, False)

    End Sub



#End Region

#Region "Funciones Principales (CRUD)"
    'Activo
    Private Sub CrearActivo()
        If cboTipoActivo.SelectedValue = 0 Then
            MsgBox("Escoger Origen de Activos")
            Exit Sub
        Else
            entActivo.GrupoActivoId = cboTipoActivo.SelectedValue
        End If


        If cboPeriodo.SelectedValue = 0 Then
            MsgBox("Escoger un cliente")
            Exit Sub
        Else
            entActivo.PeriodoId = cboPeriodo.SelectedValue
        End If

        If txtSubTotal.Text = "" Then
            MsgBox("Ingresar el importe")
            Exit Sub
        Else
            entActivo.Monto = Convert.ToDecimal(txtSubTotal.Text, New CultureInfo("en-US"))
        End If
        entActivo.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        operacion = negActivo.Guardar(entActivo)

        If operacion Then
            MsgBox("Guardo con exito")
            ModoInicial()
        Else
            MsgBox("No guardo bien")
        End If
    End Sub
    Private Sub LeerActivo()

        entActivo = negActivo.ObtenerData(dgvActivo.CurrentRow.Cells("IdActivo").Value)
        txtIdActivo.Text = entActivo.IdActivo
        cboTipoActivo.SelectedValue = entActivo.GrupoActivoId
        cboPeriodo.SelectedValue = entActivo.PeriodoId
        txtSubTotal.Text = entActivo.Monto.ToString(“##,##0.00”)

    End Sub
    Private Sub ActualizarActivo()

        If cboTipoActivo.SelectedValue = 0 Then
            MsgBox("Escoger un Activo")
            Exit Sub
        Else
            entActivo.GrupoActivoId = cboTipoActivo.SelectedValue
        End If
        If cboPeriodo.SelectedValue = 0 Then
            MsgBox("Escoger un periodo")
            Exit Sub
        Else
            entActivo.PeriodoId = cboPeriodo.SelectedValue
        End If

        If txtSubTotal.Text = "" Then
            MsgBox("Ingresar el importe")
            Exit Sub
        Else
            entActivo.Monto = Convert.ToDecimal(txtSubTotal.Text, New CultureInfo("en-US"))
        End If

        entActivo.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        operacion = negActivo.Actualizar(entActivo)

        If operacion Then
            MsgBox("Se guardo bien")
            ModoInicial()
        Else
            MsgBox("No se guardo bien")
        End If
    End Sub
    Private Sub EliminarActivo()
        entActivo.IdActivo = dgvActivo.CurrentRow.Cells("IdActivo").Value
        entActivo.UsuarioModificacionId = VariableGlobal.VGIDUsuario
        operacion = negActivo.Eliminar(entActivo)

        If operacion Then
            MsgBox("Elimino con exito")
            ModoInicial()
        Else
            MsgBox("No elimino bien")
        End If
    End Sub

    'PAGO

#End Region

#Region "Funciones del formulario"
    Private Sub FormActivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo()
        ModoInicial()
    End Sub

    Private Sub FormActivo_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 Then
            LeerActivo()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete Then
            EliminarActivo()
        End If
    End Sub

#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdActivo.Text = "0" Then
            CrearActivo()
        Else
            ActualizarActivo()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LeerActivo()
        ModoRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarActivo()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub

    Private Sub cbPeriodoFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPeriodoFiltro.SelectedIndexChanged
        CargarTablaActivo()
    End Sub


#End Region
End Class
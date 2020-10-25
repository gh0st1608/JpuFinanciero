Imports System.IO
Imports System.Globalization
Imports ERP_Entidad
Imports ERP_Negocio

Public Class FormPatrimonio
#Region "Variables"
    Dim negPatrimonio As New NegPatrimonio
    Dim entPatrimonio As New EntPatrimonio
    Dim entGrupoPatrimonio As New EntGrupoPatrimonio
    Dim negGrupoPatrimonio As New NegGrupoPatrimonio
    Dim operacion As Boolean = False
    Dim negPeriodo As New NegPeriodo
    Dim dataTable As New DataTable
    Dim list As New List(Of String)
    Dim respaldo As Decimal
#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        Me.Height = 296
        txtIdPatrimonio.Text = "0"
        cboPeriodo.SelectedValue = 0
        btnNuevo.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        dgvPatrimonio.Enabled = False
        PanelPatrimonio.Visible = True
        CargarTablaPatrimonio()
    End Sub

    Private Sub ModoRegistro()
        Me.Height = 408
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        dgvPatrimonio.Enabled = False
        PanelPatrimonio.Visible = True
    End Sub
#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarTablaPatrimonio()
        dataTable = negPatrimonio.ObtenerTabla(0, cbPeriodoFiltro.SelectedValue)
        dgvPatrimonio.DataSource = dataTable
        If dgvPatrimonio.Rows.Count > 0 Then
            dgvPatrimonio.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        End If
    End Sub

    Private Sub CargarCombo()
        cboTipoPatrimonio.ValueMember = "IdGrupoPatrimonio"
        cboTipoPatrimonio.DisplayMember = "Descripcion"
        cboTipoPatrimonio.DataSource = negGrupoPatrimonio.ObtenerLista(False, True)
        cboPeriodo.ValueMember = "IdPeriodo"
        cboPeriodo.DisplayMember = "DescripcionPeriodo"
        cboPeriodo.DataSource = negPeriodo.ObtenerLista(False, True)
        cbPeriodoFiltro.ValueMember = "IdPeriodo"
        cbPeriodoFiltro.DisplayMember = "DescripcionPeriodo"
        cbPeriodoFiltro.DataSource = negPeriodo.ObtenerLista(True, False)
    End Sub
#End Region

#Region "Funciones Principales (CRUD)"
    Private Sub CrearPatrimonio()
        If cboTipoPatrimonio.SelectedValue = 0 Then
            MsgBox("Escoger Tipo de Patrimonios", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entPatrimonio.GrupoPatrimonioId = cboTipoPatrimonio.SelectedValue
        End If
        If cboPeriodo.SelectedValue = 0 Then
            MsgBox("Escoger un periodo", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entPatrimonio.PeriodoId = cboPeriodo.SelectedValue
        End If
        If txtSubTotal.Text = "" Then
            MsgBox("Ingresar el subtotal", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entPatrimonio.Monto = Convert.ToDecimal(txtSubTotal.Text)
        End If
        entPatrimonio.UsuarioCreacionId = VariableGlobal.VGIDUsuario

        operacion = negPatrimonio.Guardar(entPatrimonio)
        If operacion Then
            MsgBox("Creó con exito", MsgBoxStyle.Information, "Crear Patrimonio")
        Else
            MsgBox("No creó", MsgBoxStyle.Critical, "Crear Patrimonio")
        End If
    End Sub

    Private Sub LeerPatrimonio()
        entPatrimonio = negPatrimonio.ObtenerData(dgvPatrimonio.CurrentRow.Cells("IdPatrimonio").Value)
        txtIdPatrimonio.Text = entPatrimonio.IdPatrimonio
        cboTipoPatrimonio.SelectedValue = entPatrimonio.GrupoPatrimonioId
        cboPeriodo.SelectedValue = entPatrimonio.PeriodoId
        txtSubTotal.Text = entPatrimonio.Monto.ToString(“##,##0.00”)
    End Sub

    Private Sub ActualizarPatrimonio()
        If cboTipoPatrimonio.SelectedValue = 0 Then
            MsgBox("Escoger Tipo de Patrimonios", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entPatrimonio.GrupoPatrimonioId = cboTipoPatrimonio.SelectedValue
        End If
        If cboPeriodo.SelectedValue = 0 Then
            MsgBox("Escoger un periodo", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entPatrimonio.PeriodoId = cboPeriodo.SelectedValue
        End If
        If txtSubTotal.Text = "" Then
            MsgBox("Ingresar el subtotal", MsgBoxStyle.Critical, "Validar campo")
            Exit Sub
        Else
            entPatrimonio.Monto = Convert.ToDecimal(txtSubTotal.Text)
        End If
        entPatrimonio.UsuarioModificacionId = VariableGlobal.VGIDUsuario

        operacion = negPatrimonio.Actualizar(entPatrimonio)
        If operacion Then
            MsgBox("Actualizó con exito", MsgBoxStyle.Information, "Actualizar Patrimonio")
        Else
            MsgBox("No actualizó", MsgBoxStyle.Critical, "Actualizar Patrimonio")
        End If
    End Sub

    Private Sub EliminarPatrimonio()
        entPatrimonio.IdPatrimonio = dgvPatrimonio.CurrentRow.Cells("IdPatrimonio").Value
        entPatrimonio.UsuarioModificacionId = VariableGlobal.VGIDUsuario
        operacion = negPatrimonio.Eliminar(entPatrimonio)
        If operacion Then
            MsgBox("Eliminó con exito", MsgBoxStyle.Information, "Eliminar Patrimonio")
        Else
            MsgBox("No eliminó", MsgBoxStyle.Critical, "Eliminar Patrimonio")
        End If
    End Sub
#End Region

#Region "Funciones del formulario"
    Private Sub FormPatrimonio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo()
        ModoInicial()
    End Sub

    Private Sub FormPatrimonio_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            ModoRegistro()
        End If
        If e.KeyCode = Keys.F5 Then
            LeerPatrimonio()
            ModoRegistro()
        End If
        If e.KeyCode = Keys.Delete Then
            EliminarPatrimonio()
            ModoInicial()
        End If
    End Sub
#End Region

#Region "Funciones de elementos del formulario"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdPatrimonio.Text = "0" Then
            CrearPatrimonio()
        Else
            ActualizarPatrimonio()
        End If
        If operacion Then
            ModoInicial()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LeerPatrimonio()
        ModoRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarPatrimonio()
        ModoInicial()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoInicial()
    End Sub

    Private Sub cbPeriodoFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPeriodoFiltro.SelectedIndexChanged
        CargarTablaPatrimonio()
    End Sub
#End Region
End Class
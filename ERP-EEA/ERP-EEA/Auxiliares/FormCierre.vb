Imports ERP_Negocio
Imports ERP_Entidad
Imports System.Math

Public Class FormCierre
#Region "Variables"
    Dim negPeriodo As New NegPeriodo
    Dim entPeriodo As New EntPeriodo
    Dim negActivo As New NegActivo
    Dim negPasivo As New NegPasivo
    Dim negPatrimonio As New NegPatrimonio
    Dim negEstadoResultado As New NegEstadoResultado
    Dim entEstadoResultado As New EntEstadoResultado
    Dim negRatio As New NegRatio
    Dim entRatio As New EntRatio
    Dim operacion As Boolean = False
    Dim CuentasPorPagar As Decimal
    Dim CuentasPorPagarTerceros As Decimal
    Dim IgvVenta As Decimal
    Dim CuentaBCP As Decimal
    Dim CuentaBN As Decimal
    Dim CuentaPorCobrar As Decimal
    Dim AdelantoAccionistas As Decimal
    Dim IgvCompra As Decimal
    Dim Equipos As Decimal
    Dim HaberesOperacionales As Decimal
    Dim Ventas As Decimal
    Dim Capital As Decimal
    Dim CapitalAdicional As Decimal
    Dim AporteCapital As Decimal
    Dim UtilidadNetaPatrimonio As Decimal
    Dim CostoVentas1 As Decimal
    Dim CostoVentas2 As Decimal
    Dim CostoVentas3 As Decimal
    Dim Costos As Decimal
    Dim UtilidadBruta As Decimal
    Dim GastosAdministrativos As Decimal
    Dim UtilidadOperativa As Decimal
    Dim GastoMenor As Decimal
    Dim GastoFinanciero As Decimal
    Dim GastoInversion As Decimal
    Dim UtilidadNeta As Decimal
    Dim ActivosTotalCorriente As Decimal
    Dim ActivosTotal As Decimal
    Dim PasivosTotal As Decimal
    Dim PatrimonioTotal As Decimal
    Dim dataTable As DataTable
#End Region

#Region "Modos de ventana"
    Private Sub ModoInicial()
        Me.Width = 279
        Me.Height = 286
        btnCerrar.Enabled = True
        CargarTabla()
    End Sub
#End Region

#Region "Funciones Auxiliares"
    Private Sub CargarTabla()
        dataTable = negPeriodo.ObtenerTabla()
        dgvPeriodo.DataSource = dataTable
        If dgvPeriodo.Rows.Count > 0 Then
            dgvPeriodo.Enabled = True
            btnCerrar.Enabled = True
        Else
            btnCerrar.Enabled = False
        End If
    End Sub

    Private Sub CrearRatios()
        entRatio.UsuarioCreacionId = 1
        'Periodo Ratio
        entRatio.PeriodoId = Int(dgvPeriodo.CurrentRow.Cells("IdPeriodo").Value)

        'Pasivos Corriente
        CuentasPorPagar = negPasivo.ObtenerData(0, entPeriodo.IdPeriodo, 1).Monto
        CuentasPorPagarTerceros = negPasivo.ObtenerData(0, entPeriodo.IdPeriodo, 2).Monto
        IgvVenta = negPasivo.ObtenerData(0, entPeriodo.IdPeriodo, 3).Monto
        PasivosTotal = CuentasPorPagar + CuentasPorPagarTerceros + IgvVenta

        'Activos Corriente
        CuentaBCP = negActivo.ObtenerData(0, entPeriodo.IdPeriodo, 1).Monto
        CuentaBN = negActivo.ObtenerData(0, entPeriodo.IdPeriodo, 2).Monto
        CuentaPorCobrar = negActivo.ObtenerData(0, entPeriodo.IdPeriodo, 3).Monto
        AdelantoAccionistas = negActivo.ObtenerData(0, entPeriodo.IdPeriodo, 4).Monto
        IgvCompra = negActivo.ObtenerData(0, entPeriodo.IdPeriodo, 5).Monto
        ActivosTotalCorriente = CuentaBCP + CuentaBN + CuentaPorCobrar + AdelantoAccionistas + IgvCompra

        'Activos No Corriente
        Equipos = negActivo.ObtenerData(0, entPeriodo.IdPeriodo, 6).Monto
        ActivosTotal = ActivosTotalCorriente + Equipos

        'Patrimonio
        Capital = negPatrimonio.ObtenerData(0, entPeriodo.IdPeriodo, 1).Monto
        CapitalAdicional = negPatrimonio.ObtenerData(0, entPeriodo.IdPeriodo, 2).Monto
        AporteCapital = negPatrimonio.ObtenerData(0, entPeriodo.IdPeriodo, 3).Monto
        UtilidadNetaPatrimonio = negPatrimonio.ObtenerData(0, entPeriodo.IdPeriodo, 4).Monto
        PatrimonioTotal = Capital + CapitalAdicional + AporteCapital + UtilidadNetaPatrimonio

        'HaberesOperacionales = negEgreso.ObtenerData(0, 2, entPeriodo.IdPeriodo).ImporteProvision - negEgreso.ObtenerData(0, 2, entPeriodo.IdPeriodo).Deuda

        '---Valores de Estado de Resultado----

        'Ventas
        Ventas = negEstadoResultado.ObtenerData(0, entPeriodo.IdPeriodo, 1).Valor

        'Costo de Venta 1
        CostoVentas1 = negEstadoResultado.ObtenerData(0, entPeriodo.IdPeriodo, 2).Valor

        'Costo de Venta 2
        CostoVentas2 = negEstadoResultado.ObtenerData(0, entPeriodo.IdPeriodo, 3).Valor

        'Costo de Venta 3
        CostoVentas3 = negEstadoResultado.ObtenerData(0, entPeriodo.IdPeriodo, 4).Valor

        'Utilidad Bruta
        UtilidadBruta = negEstadoResultado.ObtenerData(0, entPeriodo.IdPeriodo, 5).Valor

        'Gastos Administrativos
        GastosAdministrativos = negEstadoResultado.ObtenerData(0, entPeriodo.IdPeriodo, 6).Valor

        'Utilidad Operativa
        UtilidadOperativa = negEstadoResultado.ObtenerData(0, entPeriodo.IdPeriodo, 7).Valor

        'Gasto Menor
        GastoMenor = negEstadoResultado.ObtenerData(0, entPeriodo.IdPeriodo, 8).Valor

        'GastoFinanciero
        GastoFinanciero = negEstadoResultado.ObtenerData(0, entPeriodo.IdPeriodo, 9).Valor

        'GastoInversion
        GastoInversion = negEstadoResultado.ObtenerData(0, entPeriodo.IdPeriodo, 10).Valor

        'Utilidad Neta
        UtilidadNeta = negEstadoResultado.ObtenerData(0, entPeriodo.IdPeriodo, 11).Valor

        'Costos
        Costos = CostoVentas1 + CostoVentas2 + CostoVentas3

        '1 Razon Corriente [activo coriente/pasivo corriente] (veces)
        entRatio.TipoRatioId = 1
        entRatio.Valor = Round((ActivosTotalCorriente / PasivosTotal), 1)
        operacion = negRatio.Guardar(entRatio)

        '2 Razon Endeudamiento [pasivo total /activo total] x100 (%)
        entRatio.TipoRatioId = 2
        entRatio.Valor = Round((PasivosTotal / ActivosTotal) * 100)
        operacion = negRatio.Guardar(entRatio)

        '3 Razon de Endeudamiento Patrimonial [pasivo total / patrimonio] (veces)
        entRatio.TipoRatioId = 3
        entRatio.Valor = Round((PasivosTotal / PatrimonioTotal), 1)
        operacion = negRatio.Guardar(entRatio)

        '4 Promedio de Pagos (dias)
        entRatio.TipoRatioId = 4
        entRatio.Valor = Round(((CuentasPorPagar / Costos) * 365))
        operacion = negRatio.Guardar(entRatio)

        '5 Rotacion de Activos (veces)
        entRatio.TipoRatioId = 5
        entRatio.Valor = Round((Ventas / ActivosTotal), 1)
        operacion = negRatio.Guardar(entRatio)

        '6 Margen de utilidad Bruta(%)
        entRatio.TipoRatioId = 6
        entRatio.Valor = Round((UtilidadBruta / Ventas) * 100)
        operacion = negRatio.Guardar(entRatio)

        '7 Margen de Utilidad Operativa(%)
        entRatio.TipoRatioId = 7
        entRatio.Valor = Round((UtilidadOperativa / Ventas) * 100)
        operacion = negRatio.Guardar(entRatio)

        '8 Margen de utilidad Neta(%)
        entRatio.TipoRatioId = 8
        entRatio.Valor = Round((UtilidadNeta / Ventas) * 100)
        operacion = negRatio.Guardar(entRatio)

        '9 Rendimiento Sobre Activos(%)
        entRatio.TipoRatioId = 9
        entRatio.Valor = Round((UtilidadNeta / ActivosTotal) * 100)
        operacion = negRatio.Guardar(entRatio)

        '10 Rendimiento Sobre Patrimonio(%)
        entRatio.TipoRatioId = 10
        entRatio.Valor = Round((UtilidadNeta / PatrimonioTotal) * 100)
        operacion = negRatio.Guardar(entRatio)

        '11 Margen de Gasto Personal(%)
        entRatio.TipoRatioId = 11
        entRatio.Valor = Round((CostoVentas1 / (Costos + GastosAdministrativos + GastoMenor + GastoFinanciero))) * 100
        'entRatio.Valor = Round((CostoVentas1 / (Costos + GastosAdministrativos + GastoMenor + GastoFinanciero + GastoInversion))) * 100
        operacion = negRatio.Guardar(entRatio)
    End Sub

    Private Sub CrearEstadoResultados()
        entEstadoResultado.UsuarioCreacionId = VariableGlobal.VGIDUsuario
        'Periodo 
        entEstadoResultado.PeriodoId = Int(dgvPeriodo.CurrentRow.Cells("IdPeriodo").Value)
        Dim Tabla As New DataTable
        Tabla = negEstadoResultado.ObtenerTabla(entEstadoResultado.PeriodoId)

        If (Tabla.Rows.Count() > 0) Then
            'Ventas
            Ventas = IIf(IsDBNull(Convert.ToDecimal(Tabla.Rows(0).Item("Venta"))), 0, Convert.ToDecimal(Tabla.Rows(0).Item("Venta")))
            entEstadoResultado.Valor = Ventas
            entEstadoResultado.Concepto = "Ventas"
            entEstadoResultado.Orden = 1
            operacion = negEstadoResultado.Guardar(entEstadoResultado)
            'Costo de Venta 1
            CostoVentas1 = IIf(IsDBNull(Convert.ToDecimal(Tabla.Rows(0).Item("Costo1"))), 0, Convert.ToDecimal(Tabla.Rows(0).Item("Costo1")))
            entEstadoResultado.Valor = CostoVentas1
            entEstadoResultado.Concepto = "Costo de Venta 1"
            entEstadoResultado.Orden = 2
            operacion = negEstadoResultado.Guardar(entEstadoResultado)
            'Costo de Venta 2
            CostoVentas2 = IIf(IsDBNull(Convert.ToDecimal(Tabla.Rows(0).Item("Costo2"))), 0, Convert.ToDecimal(Tabla.Rows(0).Item("Costo2")))
            entEstadoResultado.Valor = CostoVentas2
            entEstadoResultado.Concepto = "Costo de Venta 2"
            entEstadoResultado.Orden = 3
            operacion = negEstadoResultado.Guardar(entEstadoResultado)
            'Costo de Venta 3
            CostoVentas3 = IIf(IsDBNull(Convert.ToDecimal(Tabla.Rows(0).Item("Costo2"))), 0, Convert.ToDecimal(Tabla.Rows(0).Item("Costo3")))
            entEstadoResultado.Valor = CostoVentas3
            entEstadoResultado.Concepto = "Costo de Venta 3"
            entEstadoResultado.Orden = 4
            operacion = negEstadoResultado.Guardar(entEstadoResultado)
            'Costos
            entEstadoResultado.Valor = CostoVentas1 + CostoVentas2 + CostoVentas3
            entEstadoResultado.Concepto = "Costos"
            entEstadoResultado.Orden = 0
            operacion = negEstadoResultado.Guardar(entEstadoResultado)
            'Utilidad Bruta
            UtilidadBruta = Ventas - (CostoVentas1 + CostoVentas2 + CostoVentas3)
            entEstadoResultado.Valor = UtilidadBruta
            entEstadoResultado.Concepto = "Utilidad Bruta"
            entEstadoResultado.Orden = 5
            operacion = negEstadoResultado.Guardar(entEstadoResultado)
            'Gastos Administrativos
            GastosAdministrativos = IIf(IsDBNull(Convert.ToDecimal(Tabla.Rows(0).Item("GastoAdministrativo"))), 0, Convert.ToDecimal(Tabla.Rows(0).Item("GastoAdministrativo")))
            entEstadoResultado.Valor = GastosAdministrativos
            entEstadoResultado.Concepto = "Gasto Administrativo"
            entEstadoResultado.Orden = 6
            operacion = negEstadoResultado.Guardar(entEstadoResultado)
            'Utilidad Operativa
            entEstadoResultado.Valor = UtilidadBruta - GastosAdministrativos
            entEstadoResultado.Concepto = "Utilidad Operativa"
            entEstadoResultado.Orden = 7
            operacion = negEstadoResultado.Guardar(entEstadoResultado)
            'Gasto Menor
            GastoMenor = IIf(IsDBNull(Convert.ToDecimal(Tabla.Rows(0).Item("GastoMenor"))), 0, Convert.ToDecimal(Tabla.Rows(0).Item("GastoMenor")))
            entEstadoResultado.Valor = GastoMenor
            entEstadoResultado.Concepto = "Gasto Menor"
            entEstadoResultado.Orden = 8
            operacion = negEstadoResultado.Guardar(entEstadoResultado)
            'GastoFinanciero
            GastoFinanciero = IIf(IsDBNull(Convert.ToDecimal(Tabla.Rows(0).Item("GastoFinanciero"))), 0, Convert.ToDecimal(Tabla.Rows(0).Item("GastoFinanciero")))
            entEstadoResultado.Valor = GastoFinanciero
            entEstadoResultado.Concepto = "Gasto Financiero"
            entEstadoResultado.Orden = 9
            operacion = negEstadoResultado.Guardar(entEstadoResultado)
            'GastoInversion
            'GastoInversion = IIf(IsDBNull(Convert.ToDecimal(Tabla.Rows(0).Item("GastoInversion"))), 0, Convert.ToDecimal(Tabla.Rows(0).Item("GastoInversion")))
            'entEstadoResultado.Valor = GastoInversion
            'entEstadoResultado.Concepto = "Gasto Inversión"
            'entEstadoResultado.Orden = 10
            'operacion = negEstadoResultado.Guardar(entEstadoResultado)
            'Utilidad Neta
            entEstadoResultado.Valor = UtilidadBruta - (GastoFinanciero + GastoMenor + GastosAdministrativos + GastoInversion)
            entEstadoResultado.Concepto = "Utilidad Neta"
            entEstadoResultado.Orden = 11
            operacion = negEstadoResultado.Guardar(entEstadoResultado)
        End If
    End Sub
#End Region

#Region "Funciones Principales (CRUD)"



    Private Sub ActualizaPeriodo()
        entPeriodo.IdPeriodo = Int(dgvPeriodo.CurrentRow.Cells("IdPeriodo").Value)
        entPeriodo.Cierre = 1
        operacion = negPeriodo.Actualizar(entPeriodo)
        If operacion Then
            MsgBox("Actualizó con exito", MsgBoxStyle.Information, "Actualizar Periodo")
        Else
            MsgBox("No actualizó", MsgBoxStyle.Critical, "Actualizar Periodo")
        End If
    End Sub

#End Region

#Region "Funciones del formulario"
    Private Sub FormPeriodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModoInicial()
    End Sub

#End Region

#Region "Funciones de elementos del formulario"

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        ActualizaPeriodo()
        CrearEstadoResultados()
        CrearRatios()
        ModoInicial()
    End Sub
#End Region
End Class
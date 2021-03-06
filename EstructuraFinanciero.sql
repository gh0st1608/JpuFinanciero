USE [BDFinanciero]
GO
/****** Object:  StoredProcedure [dbo].[LeerUsuario]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerUsuario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerUsuario]
GO
/****** Object:  StoredProcedure [dbo].[LeerTipoRatio]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerTipoRatio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerTipoRatio]
GO
/****** Object:  StoredProcedure [dbo].[LeerTipoCliente]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerTipoCliente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerTipoCliente]
GO
/****** Object:  StoredProcedure [dbo].[LeerSubGrupoEgreso]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerSubGrupoEgreso]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerSubGrupoEgreso]
GO
/****** Object:  StoredProcedure [dbo].[LeerReporteRatios]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerReporteRatios]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerReporteRatios]
GO
/****** Object:  StoredProcedure [dbo].[LeerReporteIngresos]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerReporteIngresos]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerReporteIngresos]
GO
/****** Object:  StoredProcedure [dbo].[LeerReporteFCProyectado]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerReporteFCProyectado]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerReporteFCProyectado]
GO
/****** Object:  StoredProcedure [dbo].[LeerReporteEstadoResultados]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerReporteEstadoResultados]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerReporteEstadoResultados]
GO
/****** Object:  StoredProcedure [dbo].[LeerReporteEgresos]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerReporteEgresos]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerReporteEgresos]
GO
/****** Object:  StoredProcedure [dbo].[LeerReporteBalanceGeneral]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerReporteBalanceGeneral]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerReporteBalanceGeneral]
GO
/****** Object:  StoredProcedure [dbo].[LeerRelacionDebeHaber]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerRelacionDebeHaber]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerRelacionDebeHaber]
GO
/****** Object:  StoredProcedure [dbo].[LeerProyectado]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerProyectado]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerProyectado]
GO
/****** Object:  StoredProcedure [dbo].[LeerProveedor]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerProveedor]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerProveedor]
GO
/****** Object:  StoredProcedure [dbo].[LeerPeriodo]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerPeriodo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerPeriodo]
GO
/****** Object:  StoredProcedure [dbo].[LeerPatrimonio]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerPatrimonio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerPatrimonio]
GO
/****** Object:  StoredProcedure [dbo].[LeerPasivo]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerPasivo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerPasivo]
GO
/****** Object:  StoredProcedure [dbo].[LeerParametro]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerParametro]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerParametro]
GO
/****** Object:  StoredProcedure [dbo].[LeerPago]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerPago]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerPago]
GO
/****** Object:  StoredProcedure [dbo].[LeerMetodoPago]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerMetodoPago]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerMetodoPago]
GO
/****** Object:  StoredProcedure [dbo].[LeerIngreso]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerIngreso]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerIngreso]
GO
/****** Object:  StoredProcedure [dbo].[LeerGrupoPatrimonio]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerGrupoPatrimonio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerGrupoPatrimonio]
GO
/****** Object:  StoredProcedure [dbo].[LeerGrupoPasivo]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerGrupoPasivo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerGrupoPasivo]
GO
/****** Object:  StoredProcedure [dbo].[LeerGrupoIngreso]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerGrupoIngreso]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerGrupoIngreso]
GO
/****** Object:  StoredProcedure [dbo].[LeerGrupoEgreso]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerGrupoEgreso]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerGrupoEgreso]
GO
/****** Object:  StoredProcedure [dbo].[LeerGrupoActivo]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerGrupoActivo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerGrupoActivo]
GO
/****** Object:  StoredProcedure [dbo].[LeerEstadoResultadoCalculado]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerEstadoResultadoCalculado]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerEstadoResultadoCalculado]
GO
/****** Object:  StoredProcedure [dbo].[LeerEstadoResultado]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerEstadoResultado]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerEstadoResultado]
GO
/****** Object:  StoredProcedure [dbo].[LeerEgreso]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerEgreso]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerEgreso]
GO
/****** Object:  StoredProcedure [dbo].[LeerContacto]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerContacto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerContacto]
GO
/****** Object:  StoredProcedure [dbo].[LeerCliente]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerCliente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerCliente]
GO
/****** Object:  StoredProcedure [dbo].[LeerActivo]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerActivo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[LeerActivo]
GO
/****** Object:  StoredProcedure [dbo].[EliminarUsuario]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarUsuario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EliminarUsuario]
GO
/****** Object:  StoredProcedure [dbo].[EliminarTipoCliente]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarTipoCliente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EliminarTipoCliente]
GO
/****** Object:  StoredProcedure [dbo].[EliminarSubGrupoEgreso]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarSubGrupoEgreso]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EliminarSubGrupoEgreso]
GO
/****** Object:  StoredProcedure [dbo].[EliminarRelacionDebeHaber]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarRelacionDebeHaber]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EliminarRelacionDebeHaber]
GO
/****** Object:  StoredProcedure [dbo].[EliminarProyectado]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarProyectado]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EliminarProyectado]
GO
/****** Object:  StoredProcedure [dbo].[EliminarProveedor]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarProveedor]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EliminarProveedor]
GO
/****** Object:  StoredProcedure [dbo].[EliminarPatrimonio]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarPatrimonio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EliminarPatrimonio]
GO
/****** Object:  StoredProcedure [dbo].[EliminarPasivo]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarPasivo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EliminarPasivo]
GO
/****** Object:  StoredProcedure [dbo].[EliminarParametro]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarParametro]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EliminarParametro]
GO
/****** Object:  StoredProcedure [dbo].[EliminarPago]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarPago]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EliminarPago]
GO
/****** Object:  StoredProcedure [dbo].[EliminarIngreso]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarIngreso]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EliminarIngreso]
GO
/****** Object:  StoredProcedure [dbo].[EliminarGrupoPatrimonio]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarGrupoPatrimonio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EliminarGrupoPatrimonio]
GO
/****** Object:  StoredProcedure [dbo].[EliminarGrupoPasivo]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarGrupoPasivo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EliminarGrupoPasivo]
GO
/****** Object:  StoredProcedure [dbo].[EliminarGrupoIngreso]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarGrupoIngreso]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EliminarGrupoIngreso]
GO
/****** Object:  StoredProcedure [dbo].[EliminarGrupoEgreso]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarGrupoEgreso]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EliminarGrupoEgreso]
GO
/****** Object:  StoredProcedure [dbo].[EliminarGrupoActivo]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarGrupoActivo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EliminarGrupoActivo]
GO
/****** Object:  StoredProcedure [dbo].[EliminarEgreso]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarEgreso]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EliminarEgreso]
GO
/****** Object:  StoredProcedure [dbo].[EliminarContacto]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarContacto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EliminarContacto]
GO
/****** Object:  StoredProcedure [dbo].[EliminarCliente]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarCliente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EliminarCliente]
GO
/****** Object:  StoredProcedure [dbo].[EliminarActivo]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarActivo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EliminarActivo]
GO
/****** Object:  StoredProcedure [dbo].[CrearUsuario]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearUsuario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CrearUsuario]
GO
/****** Object:  StoredProcedure [dbo].[CrearTipoCliente]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearTipoCliente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CrearTipoCliente]
GO
/****** Object:  StoredProcedure [dbo].[CrearSubGrupoEgreso]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearSubGrupoEgreso]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CrearSubGrupoEgreso]
GO
/****** Object:  StoredProcedure [dbo].[CrearRelacionDebeHaber]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearRelacionDebeHaber]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CrearRelacionDebeHaber]
GO
/****** Object:  StoredProcedure [dbo].[CrearRatio]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearRatio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CrearRatio]
GO
/****** Object:  StoredProcedure [dbo].[CrearProyectado]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearProyectado]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CrearProyectado]
GO
/****** Object:  StoredProcedure [dbo].[CrearProveedor]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearProveedor]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CrearProveedor]
GO
/****** Object:  StoredProcedure [dbo].[CrearPatrimonio]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearPatrimonio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CrearPatrimonio]
GO
/****** Object:  StoredProcedure [dbo].[CrearPasivo]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearPasivo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CrearPasivo]
GO
/****** Object:  StoredProcedure [dbo].[CrearParametro]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearParametro]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CrearParametro]
GO
/****** Object:  StoredProcedure [dbo].[CrearPago]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearPago]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CrearPago]
GO
/****** Object:  StoredProcedure [dbo].[CrearIngreso]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearIngreso]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CrearIngreso]
GO
/****** Object:  StoredProcedure [dbo].[CrearGrupoPatrimonio]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearGrupoPatrimonio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CrearGrupoPatrimonio]
GO
/****** Object:  StoredProcedure [dbo].[CrearGrupoPasivo]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearGrupoPasivo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CrearGrupoPasivo]
GO
/****** Object:  StoredProcedure [dbo].[CrearGrupoIngreso]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearGrupoIngreso]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CrearGrupoIngreso]
GO
/****** Object:  StoredProcedure [dbo].[CrearGrupoEgreso]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearGrupoEgreso]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CrearGrupoEgreso]
GO
/****** Object:  StoredProcedure [dbo].[CrearGrupoActivo]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearGrupoActivo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CrearGrupoActivo]
GO
/****** Object:  StoredProcedure [dbo].[CrearEstadoResultado]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearEstadoResultado]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CrearEstadoResultado]
GO
/****** Object:  StoredProcedure [dbo].[CrearEgreso]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearEgreso]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CrearEgreso]
GO
/****** Object:  StoredProcedure [dbo].[CrearContacto]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearContacto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CrearContacto]
GO
/****** Object:  StoredProcedure [dbo].[CrearCliente]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearCliente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CrearCliente]
GO
/****** Object:  StoredProcedure [dbo].[CrearActivo]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearActivo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CrearActivo]
GO
/****** Object:  StoredProcedure [dbo].[AutenticarUsuario]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AutenticarUsuario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AutenticarUsuario]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarUsuario]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarUsuario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ActualizarUsuario]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarTipoCliente]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarTipoCliente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ActualizarTipoCliente]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarSubGrupoEgreso]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarSubGrupoEgreso]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ActualizarSubGrupoEgreso]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarRelacionDebeHaber]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarRelacionDebeHaber]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ActualizarRelacionDebeHaber]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarProyectado]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarProyectado]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ActualizarProyectado]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarProveedor]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarProveedor]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ActualizarProveedor]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarPeriodo]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarPeriodo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ActualizarPeriodo]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarPatrimonio]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarPatrimonio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ActualizarPatrimonio]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarPasivo]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarPasivo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ActualizarPasivo]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarParametro]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarParametro]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ActualizarParametro]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarPago]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarPago]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ActualizarPago]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarIngreso]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarIngreso]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ActualizarIngreso]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarGrupoPatrimonio]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarGrupoPatrimonio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ActualizarGrupoPatrimonio]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarGrupoPasivo]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarGrupoPasivo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ActualizarGrupoPasivo]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarGrupoIngreso]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarGrupoIngreso]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ActualizarGrupoIngreso]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarGrupoEgreso]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarGrupoEgreso]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ActualizarGrupoEgreso]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarGrupoActivo]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarGrupoActivo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ActualizarGrupoActivo]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarEgreso]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarEgreso]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ActualizarEgreso]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarContacto]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarContacto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ActualizarContacto]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarCliente]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarCliente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ActualizarCliente]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarActivo]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarActivo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ActualizarActivo]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuario]') AND type in (N'U'))
DROP TABLE [dbo].[Usuario]
GO
/****** Object:  Table [dbo].[TipoRatio]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoRatio]') AND type in (N'U'))
DROP TABLE [dbo].[TipoRatio]
GO
/****** Object:  Table [dbo].[TipoCliente]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoCliente]') AND type in (N'U'))
DROP TABLE [dbo].[TipoCliente]
GO
/****** Object:  Table [dbo].[SubGrupoEgreso]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SubGrupoEgreso]') AND type in (N'U'))
DROP TABLE [dbo].[SubGrupoEgreso]
GO
/****** Object:  Table [dbo].[RelacionDebeHaber]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RelacionDebeHaber]') AND type in (N'U'))
DROP TABLE [dbo].[RelacionDebeHaber]
GO
/****** Object:  Table [dbo].[Ratio]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Ratio]') AND type in (N'U'))
DROP TABLE [dbo].[Ratio]
GO
/****** Object:  Table [dbo].[Proyectado]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proyectado]') AND type in (N'U'))
DROP TABLE [dbo].[Proyectado]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proveedor]') AND type in (N'U'))
DROP TABLE [dbo].[Proveedor]
GO
/****** Object:  Table [dbo].[Periodo]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Periodo]') AND type in (N'U'))
DROP TABLE [dbo].[Periodo]
GO
/****** Object:  Table [dbo].[Patrimonio]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Patrimonio]') AND type in (N'U'))
DROP TABLE [dbo].[Patrimonio]
GO
/****** Object:  Table [dbo].[Pasivo]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pasivo]') AND type in (N'U'))
DROP TABLE [dbo].[Pasivo]
GO
/****** Object:  Table [dbo].[Parametro]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Parametro]') AND type in (N'U'))
DROP TABLE [dbo].[Parametro]
GO
/****** Object:  Table [dbo].[Pago]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pago]') AND type in (N'U'))
DROP TABLE [dbo].[Pago]
GO
/****** Object:  Table [dbo].[MetodoPago]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MetodoPago]') AND type in (N'U'))
DROP TABLE [dbo].[MetodoPago]
GO
/****** Object:  Table [dbo].[Ingreso]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Ingreso]') AND type in (N'U'))
DROP TABLE [dbo].[Ingreso]
GO
/****** Object:  Table [dbo].[GrupoPatrimonio]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GrupoPatrimonio]') AND type in (N'U'))
DROP TABLE [dbo].[GrupoPatrimonio]
GO
/****** Object:  Table [dbo].[GrupoPasivo]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GrupoPasivo]') AND type in (N'U'))
DROP TABLE [dbo].[GrupoPasivo]
GO
/****** Object:  Table [dbo].[GrupoIngreso]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GrupoIngreso]') AND type in (N'U'))
DROP TABLE [dbo].[GrupoIngreso]
GO
/****** Object:  Table [dbo].[GrupoEgreso]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GrupoEgreso]') AND type in (N'U'))
DROP TABLE [dbo].[GrupoEgreso]
GO
/****** Object:  Table [dbo].[GrupoActivo]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GrupoActivo]') AND type in (N'U'))
DROP TABLE [dbo].[GrupoActivo]
GO
/****** Object:  Table [dbo].[EstadoResultado]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EstadoResultado]') AND type in (N'U'))
DROP TABLE [dbo].[EstadoResultado]
GO
/****** Object:  Table [dbo].[Egreso]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Egreso]') AND type in (N'U'))
DROP TABLE [dbo].[Egreso]
GO
/****** Object:  Table [dbo].[Contacto]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Contacto]') AND type in (N'U'))
DROP TABLE [dbo].[Contacto]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Cliente]') AND type in (N'U'))
DROP TABLE [dbo].[Cliente]
GO
/****** Object:  Table [dbo].[Activo]    Script Date: 10/01/2021 16:40:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Activo]') AND type in (N'U'))
DROP TABLE [dbo].[Activo]
GO
/****** Object:  Table [dbo].[Activo]    Script Date: 10/01/2021 16:40:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Activo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Activo](
	[IdActivo] [int] IDENTITY(1,1) NOT NULL,
	[GrupoActivoId] [int] NULL,
	[PeriodoId] [int] NULL,
	[Monto] [money] NULL,
	[UsuarioCreacionId] [int] NULL,
	[UsuarioModificacionId] [int] NULL,
	[FechaCreacion] [date] NULL,
	[FechaModificacion] [date] NULL,
	[EstadoActivo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdActivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Cliente]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Cliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[TipoClienteId] [int] NULL,
	[RazonSocial] [varchar](255) NULL,
	[Documento] [varchar](13) NULL,
	[Descripcion] [varchar](50) NULL,
	[MetaEntidad] [money] NULL,
	[MetaEmpresa] [money] NULL,
	[Correo] [varchar](50) NULL,
	[NumeroContacto] [varchar](12) NULL,
	[UsuarioCreacionId] [int] NULL,
	[UsuarioModificacionId] [int] NULL,
	[FechaCreacion] [date] NULL,
	[FechaModificacion] [date] NULL,
	[EstadoActivo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Contacto]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Contacto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Contacto](
	[IdContacto] [int] IDENTITY(1,1) NOT NULL,
	[TipoContactoId] [int] NULL,
	[Cargo] [varchar](100) NULL,
	[NombreCompleto] [varchar](200) NULL,
	[OrigenId] [int] NULL,
	[Correo] [varchar](100) NULL,
	[Celular] [varchar](50) NULL,
	[UsuarioCreacionId] [int] NULL,
	[UsuarioModificacionId] [int] NULL,
	[FechaCreacion] [date] NULL,
	[FechaModificacion] [date] NULL,
	[EstadoActivo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdContacto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Egreso]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Egreso]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Egreso](
	[IdEgreso] [int] IDENTITY(1,1) NOT NULL,
	[SubGrupoEgresoId] [int] NULL,
	[ProveedorId] [int] NULL,
	[ImporteProvision] [money] NULL,
	[IgvProvision] [money] NULL,
	[TotalProvision] [money] NULL,
	[PeriodoId] [int] NULL,
	[Comentario] [varchar](100) NULL,
	[FechaEgresoProvision] [date] NULL,
	[UsuarioCreacionId] [int] NULL,
	[UsuarioModificacionId] [int] NULL,
	[FechaCreacion] [date] NULL,
	[FechaModificacion] [date] NULL,
	[EstadoActivo] [int] NULL,
	[Deuda] [money] NULL,
	[GrupoEgresoId] [int] NULL,
	[ComprobanteUbicacion] [varchar](200) NULL,
	[NumeroComprobanteEgreso] [varchar](20) NULL,
	[IGV] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEgreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EstadoResultado]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EstadoResultado]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EstadoResultado](
	[IdEstadoResultado] [int] IDENTITY(1,1) NOT NULL,
	[Orden] [int] NULL,
	[Concepto] [varchar](50) NULL,
	[Periodo] [int] NULL,
	[Valor] [money] NULL,
	[FechaCreacion] [date] NULL,
	[FechaModificacion] [date] NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GrupoActivo]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GrupoActivo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[GrupoActivo](
	[IdGrupoActivo] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [int] NULL,
	[Descripcion] [nvarchar](50) NULL,
	[Cuenta] [int] NULL,
	[UsuarioCreacionId] [int] NULL,
	[UsuarioModificacionId] [int] NULL,
	[FechaCreacion] [date] NULL,
	[FechaModificacion] [date] NULL,
	[EstadoActivo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdGrupoActivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[GrupoEgreso]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GrupoEgreso]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[GrupoEgreso](
	[IdGrupoEgreso] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
	[UsuarioCreacionId] [int] NULL,
	[UsuarioModificacionId] [int] NULL,
	[FechaCreacion] [date] NULL,
	[FechaModificacion] [date] NULL,
	[EstadoActivo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdGrupoEgreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[GrupoIngreso]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GrupoIngreso]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[GrupoIngreso](
	[IdGrupoIngreso] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
	[UsuarioCreacionId] [int] NULL,
	[UsuarioModificacionId] [int] NULL,
	[FechaCreacion] [date] NULL,
	[FechaModificacion] [date] NULL,
	[EstadoActivo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdGrupoIngreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[GrupoPasivo]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GrupoPasivo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[GrupoPasivo](
	[IdGrupoPasivo] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [int] NULL,
	[Descripcion] [nvarchar](50) NULL,
	[Cuenta] [int] NULL,
	[UsuarioCreacionId] [int] NULL,
	[UsuarioModificacionId] [int] NULL,
	[FechaCreacion] [date] NULL,
	[FechaModificacion] [date] NULL,
	[EstadoActivo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdGrupoPasivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[GrupoPatrimonio]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GrupoPatrimonio]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[GrupoPatrimonio](
	[IdGrupoPatrimonio] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
	[Cuenta] [int] NULL,
	[UsuarioCreacionId] [int] NULL,
	[UsuarioModificacionId] [int] NULL,
	[FechaCreacion] [date] NULL,
	[FechaModificacion] [date] NULL,
	[EstadoActivo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdGrupoPatrimonio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Ingreso]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Ingreso]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Ingreso](
	[IdIngreso] [int] IDENTITY(1,1) NOT NULL,
	[GrupoIngresoId] [int] NULL,
	[ClienteId] [int] NULL,
	[ImporteProvision] [money] NULL,
	[IgvProvision] [money] NULL,
	[TotalProvision] [money] NULL,
	[DetraccionProvision] [money] NULL,
	[IngresoCuenta] [money] NULL,
	[PeriodoId] [int] NULL,
	[Comentario] [varchar](200) NULL,
	[FechaIngresoProvision] [date] NULL,
	[UsuarioCreacionId] [int] NULL,
	[UsuarioModificacionId] [int] NULL,
	[FechaCreacion] [date] NULL,
	[FechaModificacion] [date] NULL,
	[EstadoActivo] [int] NULL,
	[Deuda] [money] NULL,
	[IGV] [bit] NULL,
	[Detraccion] [bit] NULL,
	[ComprobanteUbicacion] [varchar](200) NULL,
	[NumeroComprobanteIngreso] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdIngreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MetodoPago]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MetodoPago]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MetodoPago](
	[IdMetodoPago] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[UsuarioCreacionId] [int] NULL,
	[UsuarioModificacionId] [int] NULL,
	[FechaCreacion] [date] NULL,
	[FechaModificacion] [date] NULL,
	[EstadoActivo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdMetodoPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pago]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pago]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Pago](
	[IdPago] [int] IDENTITY(1,1) NOT NULL,
	[TipoOrigenId] [int] NULL,
	[OrigenId] [int] NULL,
	[ImporteCancelado] [money] NULL,
	[MetodoPagoId] [int] NULL,
	[FechaPago] [date] NULL,
	[UsuarioCreacionId] [int] NULL,
	[UsuarioModificacionId] [int] NULL,
	[FechaCreacion] [date] NULL,
	[FechaModificacion] [date] NULL,
	[EstadoActivo] [int] NULL,
	[ComprobanteUbicacion] [varchar](200) NULL,
	[NumeroComprobante] [varchar](20) NULL,
	[ImporteTotal] [money] NULL,
	[ImporteIGV] [money] NULL,
	[ImporteDetraccion] [money] NULL,
	[NroOperacion] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Parametro]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Parametro]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Parametro](
	[idParametro] [int] IDENTITY(1,1) NOT NULL,
	[TipoParametro] [varchar](20) NULL,
	[Descripcion] [varchar](50) NULL,
	[ValorParametro] [float] NULL,
	[UsuarioCreacionId] [int] NULL,
	[UsuarioModificacionId] [int] NULL,
	[FechaCreacion] [date] NULL,
	[FechaModificacion] [date] NULL,
	[EstadoActivo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idParametro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pasivo]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pasivo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Pasivo](
	[IdPasivo] [int] IDENTITY(1,1) NOT NULL,
	[GrupoPasivoId] [int] NULL,
	[PeriodoId] [int] NULL,
	[Monto] [money] NULL,
	[UsuarioCreacionId] [int] NULL,
	[UsuarioModificacionId] [int] NULL,
	[FechaCreacion] [date] NULL,
	[FechaModificacion] [date] NULL,
	[EstadoActivo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPasivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Patrimonio]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Patrimonio]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Patrimonio](
	[IdPatrimonio] [int] IDENTITY(1,1) NOT NULL,
	[GrupoPatrimonioId] [int] NULL,
	[PeriodoId] [int] NULL,
	[Monto] [money] NULL,
	[UsuarioCreacionId] [int] NULL,
	[UsuarioModificacionId] [int] NULL,
	[FechaCreacion] [date] NULL,
	[FechaModificacion] [date] NULL,
	[EstadoActivo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPatrimonio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Periodo]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Periodo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Periodo](
	[idPeriodo] [int] IDENTITY(1,1) NOT NULL,
	[FechaInicio] [date] NULL,
	[DescripcionPeriodo] [varchar](50) NULL,
	[FechaFin] [date] NULL,
	[Cierre] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPeriodo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proveedor]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Proveedor](
	[IdProveedor] [int] IDENTITY(1,1) NOT NULL,
	[NombreComercial] [varchar](50) NULL,
	[RazonSocial] [varchar](25) NULL,
	[NumeroContacto] [varchar](15) NULL,
	[MedicionId] [int] NULL,
	[Tarifa] [float] NULL,
	[UsuarioCreacionId] [int] NULL,
	[UsuarioModificacionId] [int] NULL,
	[FechaCreacion] [date] NULL,
	[FechaModificacion] [date] NULL,
	[EstadoActivo] [int] NULL,
	[Documento] [varchar](13) NULL,
	[Correo] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Proyectado]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proyectado]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Proyectado](
	[IdProyectado] [int] IDENTITY(1,1) NOT NULL,
	[GrupoEgresoId] [int] NULL,
	[SubGrupoEgresoId] [int] NULL,
	[PeriodoId] [int] NULL,
	[ImporteProvision] [money] NULL,
	[UsuarioCreacionId] [int] NULL,
	[UsuarioModificacionId] [int] NULL,
	[FechaCreacion] [date] NULL,
	[FechaModificacion] [date] NULL,
	[EstadoActivo] [int] NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Ratio]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Ratio]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Ratio](
	[IdRatio] [int] IDENTITY(1,1) NOT NULL,
	[TipoRatioId] [int] NULL,
	[Valor] [float] NULL,
	[PeriodoId] [int] NULL,
	[UsuarioCreacionId] [int] NULL,
	[UsuarioModificacionId] [int] NULL,
	[FechaCreacion] [date] NULL,
	[FechaModificacion] [date] NULL,
	[EstadoActivo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdRatio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[RelacionDebeHaber]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RelacionDebeHaber]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[RelacionDebeHaber](
	[IdRelacionDebeHaber] [int] IDENTITY(1,1) NOT NULL,
	[TipoOperacionId] [int] NULL,
	[EtapaOperacionId] [int] NULL,
	[GrupoId] [int] NULL,
	[GrupoDebeId] [int] NULL,
	[GrupoHaberId] [int] NULL,
	[DebeId] [int] NULL,
	[HaberId] [int] NULL,
	[SignoDebe] [int] NULL,
	[SignoHaber] [int] NULL,
	[EstadoActivo] [int] NULL,
	[UsuarioCreacionId] [int] NULL,
	[UsuarioModificacionId] [int] NULL,
	[FechaCreacion] [date] NULL,
	[FechaModificacion] [date] NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[SubGrupoEgreso]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SubGrupoEgreso]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[SubGrupoEgreso](
	[IdSubGrupoEgreso] [int] IDENTITY(1,1) NOT NULL,
	[GrupoEgresoId] [int] NULL,
	[ItemSubGrupoEgreso] [nvarchar](50) NULL,
	[UsuarioCreacionId] [int] NULL,
	[UsuarioModificacionId] [int] NULL,
	[FechaCreacion] [date] NULL,
	[FechaModificacion] [date] NULL,
	[EstadoActivo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdSubGrupoEgreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[TipoCliente]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoCliente]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TipoCliente](
	[IdTipoCliente] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[UsuarioCreacionId] [int] NULL,
	[UsuarioModificacionId] [int] NULL,
	[FechaCreacion] [date] NULL,
	[FechaModificacion] [date] NULL,
	[EstadoActivo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTipoCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoRatio]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoRatio]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TipoRatio](
	[IdTipoRatio] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[UsuarioCreacionId] [int] NULL,
	[UsuarioModificacionId] [int] NULL,
	[FechaCreacion] [date] NULL,
	[FechaModificacion] [date] NULL,
	[EstadoActivo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTipoRatio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuario]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [varchar](40) NULL,
	[Contraseña] [varchar](40) NULL,
	[FechaCreacion] [date] NULL,
	[FechaModificacion] [date] NULL,
	[EstadoActivo] [int] NULL,
	[NombreCompleto] [varchar](200) NULL,
	[EmpleadoId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[ActualizarActivo]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarActivo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ActualizarActivo] AS' 
END
GO
ALTER PROCEDURE [dbo].[ActualizarActivo](
	@IdActivo					int,
	@GrupoActivoId				int,
	@PeriodoId					int,
	@Monto						money,
	@UsuarioModificacionId		int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			update Activo
			set 
				GrupoActivoId = @GrupoActivoId,
				PeriodoId = @PeriodoId,
				Monto = @Monto,
				UsuarioModificacionId = @UsuarioModificacionId,
				FechaModificacion = GETDATE(),
				EstadoActivo = 1
			where IdActivo = @IdActivo

			select @ErrorCode = @@ERROR 
			if @ErrorCode <> 0 goto onError
			 
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[ActualizarCliente]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarCliente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ActualizarCliente] AS' 
END
GO

ALTER PROCEDURE [dbo].[ActualizarCliente](
	@IdCliente				int,
	@TipoClienteId			int,
	@RazonSocial			varchar(255),
	@Documento				varchar(13),
	@Descripcion			varchar(50),
	@MetaEntidad			money,
	@MetaEmpresa			money,
	@Correo					varchar(50),
	@NumeroContacto			varchar(12),
	@UsuarioModificacionId	int,
	@EstadoActivo			int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
					update Cliente
					set 
						TipoClienteId = @TipoClienteId,
						RazonSocial = @RazonSocial,
						Documento = @Documento,
						Descripcion = @Descripcion,
						MetaEntidad = @MetaEntidad,
						MetaEmpresa = @MetaEmpresa,
						Correo = @Correo,
						NumeroContacto = @NumeroContacto,
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = @EstadoActivo
					where IdCliente = @IdCliente

					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
			 end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[ActualizarContacto]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarContacto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ActualizarContacto] AS' 
END
GO

ALTER PROCEDURE [dbo].[ActualizarContacto](
	@IdContacto					INT,
	@TipoContactoId				int,
	@Cargo						varchar(100),
	@NombreCompleto				varchar(200),
	@OrigenId					int,
	@Correo						varchar(100),
	@Celular					varchar(50),
	@UsuarioModificacionId		int,
	@EstadoActivo				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
					update Contacto
					set 
						TipoContactoId = @TipoContactoId,
						Cargo = @Cargo,
						NombreCompleto = @NombreCompleto,
						OrigenId = @OrigenId,
						Correo = @Correo,
						Celular = @Celular,
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = @EstadoActivo
					where IdContacto = @IdContacto

					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
			 end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[ActualizarEgreso]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarEgreso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ActualizarEgreso] AS' 
END
GO

ALTER PROCEDURE [dbo].[ActualizarEgreso](
	@IdEgreso					int,
	@GrupoEgresoId				int,
	@SubGrupoEgresoId			int,
	@ProveedorId				int,
	@ImporteProvision			money,
	@IgvProvision				money,
	@TotalProvision				money,
	@IGV						bit,
	@PeriodoId					int,
	@Comentario					varchar(200),
	@FechaEgresoProvision		date,
	@ComprobanteUbicacion		varchar(200),
	@NumeroComprobanteEgreso	varchar(20),
	@Deuda						money,
	@UsuarioModificacionId		int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	DECLARE @Cierre INT
	SET @Cierre = (SELECT Cierre FROM Periodo P WHERE idPeriodo=@PeriodoId)

IF @Cierre=0
	BEGIN
		begin
			begin tran
				update Egreso
				set 
					GrupoEgresoId = @GrupoEgresoId,
					SubGrupoEgresoId = @SubGrupoEgresoId,
					ProveedorId = @ProveedorId,
					ImporteProvision = @ImporteProvision,
					IgvProvision = @IgvProvision,
					TotalProvision = @TotalProvision,
					IGV = @IGV,
					PeriodoId = @PeriodoId,
					Comentario = @Comentario,
					FechaEgresoProvision = @FechaEgresoProvision,
					ComprobanteUbicacion = @ComprobanteUbicacion,
					NumeroComprobanteEgreso = @NumeroComprobanteEgreso,
					Deuda = @Deuda,
					UsuarioModificacionId = @UsuarioModificacionId,
					FechaModificacion = GETDATE(),
					EstadoActivo = 1
				where IdEgreso = @IdEgreso

				select @ErrorCode = @@ERROR 
				if @ErrorCode <> 0 goto onError
			 
			commit tran
		end
	END

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END
GO
/****** Object:  StoredProcedure [dbo].[ActualizarGrupoActivo]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarGrupoActivo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ActualizarGrupoActivo] AS' 
END
GO
ALTER PROCEDURE [dbo].[ActualizarGrupoActivo](
	@IdGrupoActivo				int,
	@Tipo						int,
	@Descripcion				varchar(50),
	@Cuenta						int = 0,
	@EstadoActivo				int,
	@UsuarioModificacionId		int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
					
					update GrupoActivo
					set 
						Tipo = @Tipo,
						Descripcion = @Descripcion,
						Cuenta = @Cuenta,
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = @EstadoActivo
					where IdGrupoActivo = @IdGrupoActivo

					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
			 end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[ActualizarGrupoEgreso]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarGrupoEgreso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ActualizarGrupoEgreso] AS' 
END
GO

ALTER PROCEDURE [dbo].[ActualizarGrupoEgreso]
	(
	@IdGrupoEgreso				int,
	@Descripcion				varchar(50),
	@EstadoActivo				int,
	@UsuarioModificacionId					int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			if exists(select IdGrupoEgreso from GrupoEgreso where Descripcion=@Descripcion and IdGrupoEgreso != @IdGrupoEgreso)
			  begin
				   RAISERROR ('Ya se encuentra un area registrada con éste Nombre', 11, 1)
			  end
			else
			  begin
				update GrupoEgreso
				set 
					Descripcion = @Descripcion,
					UsuarioModificacionId = @UsuarioModificacionId,
					FechaModificacion = GETDATE(),
					EstadoActivo = @EstadoActivo
				where IdGrupoEgreso = @IdGrupoEgreso

				select @ErrorCode = @@ERROR 
				if @ErrorCode <> 0 goto onError
			 end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END

GO
/****** Object:  StoredProcedure [dbo].[ActualizarGrupoIngreso]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarGrupoIngreso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ActualizarGrupoIngreso] AS' 
END
GO


ALTER PROCEDURE [dbo].[ActualizarGrupoIngreso](
	@IdGrupoIngreso				int,
	@Descripcion				varchar(50),
	@EstadoActivo				int,
	@UsuarioModificacionId					int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			if exists(select IdGrupoIngreso from GrupoIngreso where Descripcion=@Descripcion and IdGrupoIngreso != @IdGrupoIngreso)
			  begin
				   RAISERROR ('Ya se encuentra un area registrada con éste Nombre', 11, 1)
			  end
			else
			  begin
					
					update GrupoIngreso
					set 
						Descripcion = @Descripcion,
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = @EstadoActivo
					where IdGrupoIngreso = @IdGrupoIngreso

					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
			 end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END

GO
/****** Object:  StoredProcedure [dbo].[ActualizarGrupoPasivo]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarGrupoPasivo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ActualizarGrupoPasivo] AS' 
END
GO

ALTER PROCEDURE [dbo].[ActualizarGrupoPasivo](
	@IdGrupoPasivo				int,
	@Tipo						int,
	@Descripcion				varchar(50),
	@Cuenta						int =  0,
	@EstadoActivo				int,
	@UsuarioModificacionId		int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
					
					update GrupoPasivo
					set 
						Tipo = @Tipo,
						Descripcion = @Descripcion,
						Cuenta = @Cuenta,
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = @EstadoActivo
					where IdGrupoPasivo = @IdGrupoPasivo

					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
			 end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[ActualizarGrupoPatrimonio]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarGrupoPatrimonio]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ActualizarGrupoPatrimonio] AS' 
END
GO

ALTER PROCEDURE [dbo].[ActualizarGrupoPatrimonio](
	@IdGrupoPatrimonio			int,
	@Descripcion				varchar(50),
	@Cuenta						int,
	@EstadoActivo				int,
	@UsuarioModificacionId		int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
					
					update GrupoPatrimonio
					set 
						Descripcion = @Descripcion,
						Cuenta = @Cuenta,
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = @EstadoActivo
					where IdGrupoPatrimonio = @IdGrupoPatrimonio

					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
			 end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[ActualizarIngreso]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarIngreso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ActualizarIngreso] AS' 
END
GO

ALTER PROCEDURE [dbo].[ActualizarIngreso](
	@IdIngreso					int,
	@GrupoIngresoId				int,
	@ClienteId					int,
	@Detraccion					bit,
	@IGV						bit,
	@ImporteProvision			money,
	@PeriodoId					int,
	@Comentario					varchar(200),
	@FechaIngresoProvision		date,
	@ComprobanteUbicacion		varchar(200),
	@NumeroComprobanteIngreso	varchar(20),
	@Deuda						money,
	@IgvProvision				money,
	@DetraccionProvision		money,
	@TotalProvision				money,
	@IngresoCuenta				money,
	--@EstadoActivo				int,
	@UsuarioModificacionId		int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			update Ingreso
			set 
				GrupoIngresoId = @GrupoIngresoId,
				ClienteId = @ClienteId,
				Detraccion = @Detraccion,
				IGV = @IGV,
				ImporteProvision = @ImporteProvision,
				PeriodoId = @PeriodoId,
				Comentario = @Comentario,
				FechaIngresoProvision = @FechaIngresoProvision,
				ComprobanteUbicacion = @ComprobanteUbicacion,
				NumeroComprobanteIngreso = @NumeroComprobanteIngreso,
				Deuda = @Deuda,
				IgvProvision = @IgvProvision,
				DetraccionProvision = @DetraccionProvision,
				TotalProvision = @TotalProvision,
				IngresoCuenta = @IngresoCuenta,
				UsuarioModificacionId = @UsuarioModificacionId,
				FechaModificacion = GETDATE(),
				EstadoActivo = 1
			where IdIngreso = @IdIngreso

			select @ErrorCode = @@ERROR 
			if @ErrorCode <> 0 goto onError
			 
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END

GO
/****** Object:  StoredProcedure [dbo].[ActualizarPago]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarPago]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ActualizarPago] AS' 
END
GO
ALTER PROCEDURE [dbo].[ActualizarPago](
	@IdPago					int,
	@TipoOrigenId			int,
	@OrigenId				int,
	@ImporteCancelado		money,
	@ImporteIGV				money,
	@ImporteDetraccion		money,
	@ImporteTotal			money,
	@MetodoPagoId			int,
	@NroOperacion			varchar(20),
	@FechaPago				date,
	-- @ComprobanteUbicacion	varchar(200),
	@NumeroComprobante		varchar(20),
	@UsuarioModificacionId	int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			update Pago
			set 
				TipoOrigenId = @TipoOrigenId,
				OrigenId = @OrigenId,
				ImporteCancelado = @ImporteCancelado,
				ImporteIGV = @ImporteIGV,
				ImporteDetraccion = @ImporteDetraccion,
				ImporteTotal = @ImporteTotal,
				MetodoPagoId = @MetodoPagoId,
				NroOperacion = @NroOperacion,
				FechaPago = @FechaPago,
				-- ComprobanteUbicacion = @ComprobanteUbicacion,
				NumeroComprobante = @NumeroComprobante,
				UsuarioModificacionId = @UsuarioModificacionId,
				FechaModificacion = GETDATE()
			where IdPago = @IdPago

			select @ErrorCode = @@ERROR 
			if @ErrorCode <> 0 goto onError
			 
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END

GO
/****** Object:  StoredProcedure [dbo].[ActualizarParametro]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarParametro]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ActualizarParametro] AS' 
END
GO

ALTER PROCEDURE [dbo].[ActualizarParametro](
	@IdParametro				int,
	-- @TipoParametro				varchar(20),
	@Descripcion				varchar(50),
	@ValorParametro				float,
	@UsuarioModificacionId		int,
	@EstadoActivo				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			if exists(select TipoParametro from Parametro where Descripcion=@Descripcion and idParametro != @IdParametro)
			  begin
				   RAISERROR ('Ya se encuentra un area registrada con éste Nombre', 11, 1)
			  end
			else
			  begin
					
					update Parametro
					set 
						-- TipoParametro = @TipoParametro,
						Descripcion = @Descripcion,
						ValorParametro = @ValorParametro,
						UsuarioModificacionId = @UsuarioModificacionId,
						EstadoActivo = @EstadoActivo
					where idParametro = @IdParametro

					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
			 end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[ActualizarPasivo]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarPasivo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ActualizarPasivo] AS' 
END
GO
ALTER PROCEDURE [dbo].[ActualizarPasivo](
	@IdPasivo					int,
	@GrupoPasivoId				int,
	@PeriodoId					int,
	@Monto						money,
	@UsuarioModificacionId		int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			update Pasivo
			set 
				GrupoPasivoId = @GrupoPasivoId,
				PeriodoId = @PeriodoId,
				Monto = @Monto,
				UsuarioModificacionId = @UsuarioModificacionId,
				FechaModificacion = GETDATE(),
				EstadoActivo = 1
			where IdPasivo = @IdPasivo

			select @ErrorCode = @@ERROR 
			if @ErrorCode <> 0 goto onError
			 
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[ActualizarPatrimonio]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarPatrimonio]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ActualizarPatrimonio] AS' 
END
GO
ALTER PROCEDURE [dbo].[ActualizarPatrimonio](
	@IdPatrimonio					int,
	@GrupoPatrimonioId				int,
	@PeriodoId					int,
	@Monto						money,
	@UsuarioModificacionId		int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			update Patrimonio
			set 
				GrupoPatrimonioId = @GrupoPatrimonioId,
				PeriodoId = @PeriodoId,
				Monto = @Monto,
				UsuarioModificacionId = @UsuarioModificacionId,
				FechaModificacion = GETDATE(),
				EstadoActivo = 1
			where IdPatrimonio = @IdPatrimonio

			select @ErrorCode = @@ERROR 
			if @ErrorCode <> 0 goto onError
			 
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[ActualizarPeriodo]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarPeriodo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ActualizarPeriodo] AS' 
END
GO
ALTER PROCEDURE [dbo].[ActualizarPeriodo](
	@IdPeriodo				int,
	@Cierre					int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
					
					update Periodo
					set 
						Cierre = @Cierre
					where IdPeriodo = @IdPeriodo

					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
			 end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END
GO
/****** Object:  StoredProcedure [dbo].[ActualizarProveedor]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarProveedor]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ActualizarProveedor] AS' 
END
GO
ALTER PROCEDURE [dbo].[ActualizarProveedor](
	@IdProveedor				int,
	@Documento					varchar(25),
	@NombreComercial			varchar(50),
	@RazonSocial				varchar(25),
	@Correo						varchar(25),
	@NumeroContacto			    varchar(15),
	@MedicionId					int,
	@Tarifa						float,
	@UsuarioModificacionId		int,
	@EstadoActivo				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
					update Proveedor
					set 
						Documento = @Documento,
						NombreComercial = @NombreComercial,
						RazonSocial = @RazonSocial,
						Correo = @Correo,
						NumeroContacto = @NumeroContacto,
						MedicionId = @MedicionId,
						Tarifa = @Tarifa,
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = @EstadoActivo
					where IdProveedor = @IdProveedor

					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
			 end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[ActualizarProyectado]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarProyectado]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ActualizarProyectado] AS' 
END
GO
ALTER PROCEDURE [dbo].[ActualizarProyectado](
	@IdProyectado					int,
	@GrupoEgresoId				int,
	@SubGrupoEgresoId			int,
	@ImporteProvision			money,
	@PeriodoId					int,
	@UsuarioModificacionId		int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;


	BEGIN
		begin
			begin tran
				update Proyectado
				set 
					GrupoEgresoId = @GrupoEgresoId,
					SubGrupoEgresoId = @SubGrupoEgresoId,
					ImporteProvision = @ImporteProvision,
					PeriodoId = @PeriodoId,
					UsuarioModificacionId = @UsuarioModificacionId,
					FechaModificacion = GETDATE(),
					EstadoActivo = 1
				where IdProyectado = @IdProyectado

				select @ErrorCode = @@ERROR 
				if @ErrorCode <> 0 goto onError
			 
			commit tran
		end
	END

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[ActualizarRelacionDebeHaber]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarRelacionDebeHaber]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ActualizarRelacionDebeHaber] AS' 
END
GO
ALTER PROCEDURE [dbo].[ActualizarRelacionDebeHaber](
	@IdRelacionDebeHaber		int,
	@TipoOperacionId			int,
	@EtapaOperacionId			int,
	@GrupoId					int,
	@GrupoDebeId				int,
	@GrupoHaberId				int,
	@DebeId						int,
	@HaberId					int,
	@SignoDebe					int,
	@SignoHaber					int,
	@UsuarioModificacionId		int,
	@EstadoActivo				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
					update RelacionDebeHaber
					set 
						TipoOperacionId = @TipoOperacionId,
						EtapaOperacionId = @EtapaOperacionId,
						GrupoId = @GrupoId,
						GrupoDebeId = @GrupoDebeId,
						GrupoHaberId = @GrupoHaberId,
						DebeId = @DebeId,
						HaberId = @HaberId,
						SignoDebe = @SignoDebe,
						SignoHaber = @SignoHaber,
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = @EstadoActivo
					where IdRelacionDebeHaber = @IdRelacionDebeHaber

					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
			 end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[ActualizarSubGrupoEgreso]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarSubGrupoEgreso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ActualizarSubGrupoEgreso] AS' 
END
GO
ALTER PROCEDURE [dbo].[ActualizarSubGrupoEgreso]
	(
	@IdSubGrupoEgreso				int,
	@GrupoEgresoId					int,
	@ItemSubGrupoEgreso				varchar(50),
	@EstadoActivo					int,
	@UsuarioModificacionId			int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			if exists(select IdSubGrupoEgreso from SubGrupoEgreso where ItemSubGrupoEgreso=@ItemSubGrupoEgreso and IdSubGrupoEgreso != @IdSubGrupoEgreso)
			  begin
				   RAISERROR ('Ya se encuentra un area registrada con éste Nombre', 11, 1)
			  end
			else
			  begin
				update SubGrupoEgreso
				set 
					ItemSubGrupoEgreso = @ItemSubGrupoEgreso,
					GrupoEgresoId = @GrupoEgresoId,
					UsuarioModificacionId = @UsuarioModificacionId,
					FechaModificacion = GETDATE(),
					EstadoActivo = @EstadoActivo
				where IdSubGrupoEgreso = @IdSubGrupoEgreso

				select @ErrorCode = @@ERROR 
				if @ErrorCode <> 0 goto onError
			 end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END

GO
/****** Object:  StoredProcedure [dbo].[ActualizarTipoCliente]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarTipoCliente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ActualizarTipoCliente] AS' 
END
GO

ALTER PROCEDURE [dbo].[ActualizarTipoCliente](
	@IdTipoCliente				int,
	@Descripcion				varchar(50),
	@UsuarioModificacionId		int,
	@EstadoActivo				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
					
					update TipoCliente
					set 
						Descripcion = @Descripcion,
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = @EstadoActivo
					where IdTipoCliente = @IdTipoCliente

					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
			 end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[ActualizarUsuario]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActualizarUsuario]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ActualizarUsuario] AS' 
END
GO
ALTER PROCEDURE [dbo].[ActualizarUsuario](
	@IdUsuario				int,
	@NombreCompleto				varchar(200),
	@NombreUsuario				varchar(50),
	@Contraseña					varchar(50),
	@EstadoActivo				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
					
					update Usuario
					set 
						NombreCompleto = @NombreCompleto,
						NombreUsuario = @NombreUsuario,
						Contraseña = @Contraseña,
						FechaModificacion = GETDATE(),
						EstadoActivo = @EstadoActivo
					where IdUsuario = @IdUsuario

					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
			 end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[AutenticarUsuario]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AutenticarUsuario]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[AutenticarUsuario] AS' 
END
GO

ALTER PROCEDURE [dbo].[AutenticarUsuario]
(@Usuario VARCHAR(400),@Clave VARCHAR(400)
)
AS
begin
	select
		count(*) as Resultado
	from
		Usuario U
	where
		(U.NombreUsuario = @Usuario)
	and	(U.Contraseña = @Clave)	
end


GO
/****** Object:  StoredProcedure [dbo].[CrearActivo]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearActivo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CrearActivo] AS' 
END
GO
ALTER PROCEDURE [dbo].[CrearActivo](
	@GrupoActivoId			int,
	@PeriodoId				int,
	@Monto					money,
	@UsuarioCreacionId		int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran

			if exists(select IdActivo from Activo where PeriodoId=@PeriodoId and GrupoActivoId=@GrupoActivoId and EstadoActivo = 1)
			  begin
				  RAISERROR ('Ya se encuentra registrado el activo en este periodo', 11, 1)
			  end
			else
			  begin
				  
				  insert into Activo
				  (
				  GrupoActivoId,
				  PeriodoId,
				  Monto,
				  UsuarioCreacionId,
				  FechaCreacion,
				  EstadoActivo
				  )
				  values (
				  @GrupoActivoId,
				  @PeriodoId,
				  @Monto,
				  @UsuarioCreacionId,
				  GETDATE(),
				  1
				  )
			
				  select @ErrorCode = @@ERROR 
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	
	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[CrearCliente]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearCliente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CrearCliente] AS' 
END
GO
ALTER PROCEDURE [dbo].[CrearCliente](
	@TipoClienteId				int,
	@RazonSocial				varchar(255),
	@Documento					varchar(13),
	@Descripcion				varchar(50),
	@MetaEntidad				money,
	@MetaEmpresa				money,
	@Correo						varchar(50),
	@NumeroContacto				varchar(12),
	@UsuarioCreacionId			int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
				  
				  insert into Cliente(TipoClienteId,RazonSocial,Documento,Descripcion,MetaEntidad,MetaEmpresa,Correo,NumeroContacto,UsuarioCreacionId,FechaCreacion,EstadoActivo)
				  values (@TipoClienteId,@RazonSocial,@Documento,@Descripcion,@MetaEntidad,@MetaEmpresa,@Correo,@NumeroContacto,@UsuarioCreacionId,GETDATE(),1)
			
				  select @ErrorCode = @@ERROR 
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end

	Select top 1 IdCliente from Cliente where UsuarioCreacionId = @UsuarioCreacionId order by IdCliente desc
	
	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[CrearContacto]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearContacto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CrearContacto] AS' 
END
GO
ALTER PROCEDURE [dbo].[CrearContacto](
	@TipoContactoId				int,
	@Cargo						varchar(100),
	@NombreCompleto				varchar(200),
	@OrigenId					int,
	@Correo						varchar(100),
	@Celular					varchar(50),
	@UsuarioCreacionId			int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
				  
				  insert into Contacto(TipoContactoId,Cargo,NombreCompleto,OrigenId,Correo,Celular,UsuarioCreacionId,FechaCreacion,EstadoActivo)
				  values (@TipoContactoId,@Cargo,@NombreCompleto,@OrigenId,@Correo,@Celular,@UsuarioCreacionId,GETDATE(),1)
			
				  select @ErrorCode = @@ERROR 
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	
	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END

GO
/****** Object:  StoredProcedure [dbo].[CrearEgreso]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearEgreso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CrearEgreso] AS' 
END
GO

ALTER PROCEDURE [dbo].[CrearEgreso](
	@GrupoEgresoId					int,
	@SubGrupoEgresoId				int,
	@ProveedorId					int,
	@ImporteProvision				money,
	@IgvProvision					money,
	@TotalProvision					money,
	@Deuda							float,
	@IGV							bit,
	@PeriodoId						int,
	@Comentario						varchar(200),
	@FechaEgresoProvision			date,
	@ComprobanteUbicacion			varchar(200),
	@NumeroComprobanteEgreso		varchar(20),
	@UsuarioCreacionId				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	DECLARE @Cierre INT
	SET @Cierre = (SELECT Cierre FROM Periodo P WHERE idPeriodo=@PeriodoId)

IF @Cierre=0
	BEGIN
		insert into Egreso
		(
		GrupoEgresoId,
		SubGrupoEgresoId,
		ProveedorId,
		ImporteProvision,
		IgvProvision,
		TotalProvision,
		Deuda,
		IGV,
		PeriodoId,
		Comentario,
		FechaEgresoProvision,
		ComprobanteUbicacion,
		NumeroComprobanteEgreso,
		UsuarioCreacionId,
		FechaCreacion,
		EstadoActivo
		)
		values (
		@GrupoEgresoId,
		@SubGrupoEgresoId,
		@ProveedorId,
		@ImporteProvision,
		@IgvProvision,
		@TotalProvision,
		@Deuda,
		@IGV,
		@PeriodoId,
		@Comentario,
		@FechaEgresoProvision,
		@ComprobanteUbicacion,
		@NumeroComprobanteEgreso,
		@UsuarioCreacionId,
		GETDATE(),
		1
		)			
		select @ErrorCode = @@ERROR 
		if @ErrorCode <> 0 goto onError
	END
	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END
GO
/****** Object:  StoredProcedure [dbo].[CrearEstadoResultado]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearEstadoResultado]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CrearEstadoResultado] AS' 
END
GO

ALTER PROCEDURE [dbo].[CrearEstadoResultado](
	@Orden					int,
	@Concepto				varchar(50),
	@Valor					money,
	@PeriodoId				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
				  
				  insert into EstadoResultado(Orden, Concepto,Valor,Periodo,FechaCreacion)
				  values (@Orden,@Concepto,@Valor,@PeriodoId,GETDATE())
			
				  select @ErrorCode = @@ERROR 
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	
	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END
GO
/****** Object:  StoredProcedure [dbo].[CrearGrupoActivo]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearGrupoActivo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CrearGrupoActivo] AS' 
END
GO
ALTER PROCEDURE [dbo].[CrearGrupoActivo](
	@Tipo						int,
	@Descripcion				varchar(50),
	@Cuenta						int = 0,
	@UsuarioCreacionId			int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin			  
				  insert into GrupoActivo
				  (
				  Tipo,
				  Descripcion,
				  Cuenta,
				  UsuarioCreacionId,
				  FechaCreacion,
				  EstadoActivo
				  )
				  values (
				  @Tipo,
				  @Descripcion,
				  @Cuenta,
				  @UsuarioCreacionId,
				  GETDATE(),
				  1
				  )	
				  select @ErrorCode = @@ERROR 
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	
	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[CrearGrupoEgreso]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearGrupoEgreso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CrearGrupoEgreso] AS' 
END
GO
ALTER PROCEDURE [dbo].[CrearGrupoEgreso](
	@Descripcion				varchar(50),
	@UsuarioCreacionId					int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran

			-- if exists(select idGrupoEgreso from GrupoEgreso where Descripcion=@Descripcion)
			 --  begin
			--	  RAISERROR ('Ya se encuentra un GrupoEgreso registrado con éste Nombre', 11, 1)
			 --  end
			--else
			  begin
				  
				  insert into GrupoEgreso(Descripcion,UsuarioCreacionId,FechaCreacion,EstadoActivo)
				  values (@Descripcion,@UsuarioCreacionId,GETDATE(),1)
			
				  select @ErrorCode = @@ERROR 
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	
	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END

GO
/****** Object:  StoredProcedure [dbo].[CrearGrupoIngreso]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearGrupoIngreso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CrearGrupoIngreso] AS' 
END
GO
ALTER PROCEDURE [dbo].[CrearGrupoIngreso](
	@Descripcion				varchar(50),
	@UsuarioCreacionId					int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran

			-- if exists(select idGrupoIngreso from GrupoIngreso where Descripcion=@Descripcion)
			 --  begin
			--	  RAISERROR ('Ya se encuentra un GrupoIngreso registrado con éste Nombre', 11, 1)
			 --  end
			--else
			  begin
				  
				  insert into GrupoIngreso(Descripcion,UsuarioCreacionId,FechaCreacion,EstadoActivo)
				  values (@Descripcion,@UsuarioCreacionId,GETDATE(),1)
			
				  select @ErrorCode = @@ERROR 
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	
	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END

GO
/****** Object:  StoredProcedure [dbo].[CrearGrupoPasivo]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearGrupoPasivo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CrearGrupoPasivo] AS' 
END
GO
ALTER PROCEDURE [dbo].[CrearGrupoPasivo](
	@Tipo						int,
	@Descripcion				varchar(50),
	@Cuenta						int = 0,
	@UsuarioCreacionId			int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin			  
				  insert into GrupoPasivo
				  (
				  Tipo,
				  Descripcion,
				  Cuenta,
				  UsuarioCreacionId,
				  FechaCreacion,
				  EstadoActivo
				  )
				  values (
				  @Tipo,
				  @Descripcion,
				  @Cuenta,
				  @UsuarioCreacionId,
				  GETDATE(),
				  1
				  )	
				  select @ErrorCode = @@ERROR 
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	
	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[CrearGrupoPatrimonio]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearGrupoPatrimonio]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CrearGrupoPatrimonio] AS' 
END
GO
ALTER PROCEDURE [dbo].[CrearGrupoPatrimonio](
	@Descripcion				varchar(50),
	@Cuenta						int,
	@UsuarioCreacionId			int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin			  
				  insert into GrupoPatrimonio
				  (
				  Descripcion,
				  Cuenta,
				  UsuarioCreacionId,
				  FechaCreacion,
				  EstadoActivo
				  )
				  values (
				  @Descripcion,
				  @Cuenta,
				  @UsuarioCreacionId,
				  GETDATE(),
				  1
				  )	
				  select @ErrorCode = @@ERROR 
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	
	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[CrearIngreso]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearIngreso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CrearIngreso] AS' 
END
GO

ALTER PROCEDURE [dbo].[CrearIngreso](
	@GrupoIngresoId				int,
	@ClienteId					int,
	@Detraccion					bit,
	@IGV						bit,
	@ImporteProvision			money,
	@IgvProvision				money,
	@DetraccionProvision		money,
	@TotalProvision				money,
	@IngresoCuenta				money,
	@PeriodoId					int,
	@Comentario					varchar(200),
	@FechaIngresoProvision		date,
	@ComprobanteUbicacion		varchar(200),
	@NumeroComprobanteIngreso	varchar(20),
	@UsuarioCreacionId			int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	DECLARE @Cierre INT
	SET @Cierre = (SELECT Cierre FROM Periodo WHERE idPeriodo=@PeriodoId)

IF @Cierre=0
	begin
		insert into Ingreso
		(
		GrupoIngresoId,
		ClienteId,
		Detraccion,
		IGV,
		ImporteProvision,
		IgvProvision,
		DetraccionProvision,
		TotalProvision,
		IngresoCuenta,
		PeriodoId,
		Comentario,
		FechaIngresoProvision,
		ComprobanteUbicacion,
		NumeroComprobanteIngreso,
		Deuda,
		UsuarioCreacionId,
		FechaCreacion,
		EstadoActivo
		)
		values (
		@GrupoIngresoId,
		@ClienteId,
		@Detraccion,
		@IGV,
		@ImporteProvision,
		@IgvProvision,	
		@DetraccionProvision,
		@TotalProvision,				
		@IngresoCuenta,				
		@PeriodoId,
		@Comentario,
		@FechaIngresoProvision,
		@ComprobanteUbicacion,
		@NumeroComprobanteIngreso,
		@ImporteProvision,
		@UsuarioCreacionId,
		GETDATE(),
		1
		)
			
		select @ErrorCode = @@ERROR 
		if @ErrorCode <> 0 goto onError
	end
	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END
GO
/****** Object:  StoredProcedure [dbo].[CrearPago]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearPago]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CrearPago] AS' 
END
GO
ALTER PROCEDURE [dbo].[CrearPago](
	@TipoOrigenId			int,
	@OrigenId				int,
	@ImporteCancelado		money,
	@ImporteIGV				money,
	@ImporteDetraccion		money,
	@ImporteTotal			money,
	@MetodoPagoId			int,
	@NroOperacion			varchar(20),
	@FechaPago				date,
	--@ComprobanteUbicacion	varchar(200),
	@NumeroComprobante		varchar(20),
	@UsuarioCreacionId		int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			begin
				insert into Pago
				(
				TipoOrigenId,
				OrigenId,
				ImporteCancelado,
				ImporteIGV,
				ImporteDetraccion,
				ImporteTotal,
				MetodoPagoId,
				NroOperacion,
				FechaPago,
				--ComprobanteUbicacion,
				NumeroComprobante,
				UsuarioCreacionId,
				FechaCreacion,
				EstadoActivo
				)
				values (
				@TipoOrigenId,
				@OrigenId,
				@ImporteCancelado,
				@ImporteIGV,
				@ImporteDetraccion,
				@ImporteTotal,
				@MetodoPagoId,
				@NroOperacion,
				@FechaPago,
				--@ComprobanteUbicacion,
				@NumeroComprobante,
				@UsuarioCreacionId,
				GETDATE(),
				1
				)
			
				select @ErrorCode = @@ERROR 
				if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	
	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END

GO
/****** Object:  StoredProcedure [dbo].[CrearParametro]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearParametro]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CrearParametro] AS' 
END
GO

ALTER PROCEDURE [dbo].[CrearParametro](
	@TipoParametro				varchar(20),
	@Descripcion				varchar(50),
	@ValorParametro				float,
	@UsuarioCreacionId			int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
				  
				  insert into Parametro(TipoParametro,Descripcion,ValorParametro,UsuarioCreacionId,FechaCreacion,EstadoActivo)
				  values (@TipoParametro,@Descripcion,@ValorParametro,@UsuarioCreacionId,GETDATE(),1)
			
				  select @ErrorCode = @@ERROR 
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	
	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[CrearPasivo]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearPasivo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CrearPasivo] AS' 
END
GO
ALTER PROCEDURE [dbo].[CrearPasivo](
	@GrupoPasivoId			int,
	@PeriodoId				int,
	@Monto					money,
	@UsuarioCreacionId		int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			if exists(select IdPasivo from Pasivo where PeriodoId=@PeriodoId and GrupoPasivoId=@GrupoPasivoId and EstadoActivo = 1)
			  begin
				  RAISERROR ('Ya se encuentra registrado el pasivo en este periodo', 11, 1)
			  end
			else
			  begin
				  
				  insert into Pasivo
				  (
				  GrupoPasivoId,
				  PeriodoId,
				  Monto,
				  UsuarioCreacionId,
				  FechaCreacion,
				  EstadoActivo
				  )
				  values (
				  @GrupoPasivoId,
				  @PeriodoId,
				  @Monto,
				  @UsuarioCreacionId,
				  GETDATE(),
				  1
				  )
			
				  select @ErrorCode = @@ERROR 
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	
	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[CrearPatrimonio]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearPatrimonio]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CrearPatrimonio] AS' 
END
GO
ALTER PROCEDURE [dbo].[CrearPatrimonio](
	@GrupoPatrimonioId			int,
	@PeriodoId				int,
	@Monto					money,
	@UsuarioCreacionId		int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			if exists(select IdPatrimonio from Patrimonio where PeriodoId=@PeriodoId and GrupoPatrimonioId=@GrupoPatrimonioId and EstadoActivo = 1)
			  begin
				  RAISERROR ('Ya se encuentra registrado el patrimonio en este periodo', 11, 1)
			  end
			else
			  begin
				  
				  insert into Patrimonio
				  (
				  GrupoPatrimonioId,
				  PeriodoId,
				  Monto,
				  UsuarioCreacionId,
				  FechaCreacion,
				  EstadoActivo
				  )
				  values (
				  @GrupoPatrimonioId,
				  @PeriodoId,
				  @Monto,
				  @UsuarioCreacionId,
				  GETDATE(),
				  1
				  )
			
				  select @ErrorCode = @@ERROR 
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	
	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[CrearProveedor]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearProveedor]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CrearProveedor] AS' 
END
GO
ALTER PROCEDURE [dbo].[CrearProveedor](
	@Documento					varchar(25),
	@NombreComercial			varchar(50),
	@RazonSocial				varchar(25),
	@Correo						varchar(25),
	@NumeroContacto			    varchar(15),
	@MedicionId					int,
	@Tarifa						float,
	@UsuarioCreacionId			int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			-- if exists(select idGrupoIngreso from GrupoIngreso where Descripcion=@Descripcion)
			 --  begin
			--	  RAISERROR ('Ya se encuentra un GrupoIngreso registrado con éste Nombre', 11, 1)
			 --  end
			--else
			  begin
				  
				  insert into Proveedor(Documento, NombreComercial,RazonSocial,Correo,NumeroContacto,MedicionId,Tarifa,UsuarioCreacionId,FechaCreacion,EstadoActivo)
				  values (@Documento, @NombreComercial,@RazonSocial,@Correo,@NumeroContacto,@MedicionId,@Tarifa,@UsuarioCreacionId,GETDATE(),1)
			
				  select @ErrorCode = @@ERROR 
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	
	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[CrearProyectado]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearProyectado]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CrearProyectado] AS' 
END
GO
ALTER PROCEDURE [dbo].[CrearProyectado](
	@GrupoEgresoId					int,
	@SubGrupoEgresoId				int,
	@ImporteProvision				money,
	@PeriodoId						int,
	@UsuarioCreacionId				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	BEGIN
		begin
			begin tran
				  begin
				  
					  insert into Proyectado
					  (
					  GrupoEgresoId,
					  SubGrupoEgresoId,
					  ImporteProvision,
					  PeriodoId,
					  UsuarioCreacionId,
					  FechaCreacion,
					  EstadoActivo
					  )
					  values (
					  @GrupoEgresoId,
					  @SubGrupoEgresoId,
					  @ImporteProvision,
					  @PeriodoId,
					  @UsuarioCreacionId,
					  GETDATE(),
					  1
					  )
			
					  select @ErrorCode = @@ERROR 
					  if @ErrorCode <> 0 goto onError
				  end
			commit tran
		end
	END
	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[CrearRatio]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearRatio]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CrearRatio] AS' 
END
GO
ALTER PROCEDURE [dbo].[CrearRatio](
	@TipoRatioId					int,
	@Valor							money,
	@PeriodoId						int,
	@UsuarioCreacionId				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
				  
				  insert into Ratio(TipoRatioId,Valor,PeriodoId,UsuarioCreacionId,FechaCreacion,EstadoActivo)
				  values (@TipoRatioId,@Valor,@PeriodoId,@UsuarioCreacionId,GETDATE(),1)
			
				  select @ErrorCode = @@ERROR 
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	
	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END
GO
/****** Object:  StoredProcedure [dbo].[CrearRelacionDebeHaber]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearRelacionDebeHaber]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CrearRelacionDebeHaber] AS' 
END
GO
ALTER PROCEDURE [dbo].[CrearRelacionDebeHaber](
	@TipoOperacionId			int,
	@EtapaOperacionId			int,
	@GrupoId					int,
	@GrupoDebeId				int,
	@GrupoHaberId				int,
	@DebeId						int,
	@HaberId					int,
	@SignoDebe					int,
	@SignoHaber					int,
	@UsuarioCreacionId			int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
				  
				  insert into RelacionDebeHaber(				  
				  TipoOperacionId,
				  EtapaOperacionId,
				  GrupoId,
				  GrupoDebeId,
				  GrupoHaberId,
				  DebeId,
				  HaberId,
				  SignoDebe,
				  SignoHaber,
				  UsuarioCreacionId,
				  FechaCreacion,
				  EstadoActivo)
				  values (
				  @TipoOperacionId,
				  @EtapaOperacionId,
				  @GrupoId,
				  @GrupoDebeId,
				  @GrupoHaberId,
				  @DebeId,
				  @HaberId,
				  @SignoDebe,
				  @SignoHaber,
				  @UsuarioCreacionId,
				  GETDATE(),
				  1)
			
				  select @ErrorCode = @@ERROR 
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	
	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[CrearSubGrupoEgreso]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearSubGrupoEgreso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CrearSubGrupoEgreso] AS' 
END
GO
ALTER PROCEDURE [dbo].[CrearSubGrupoEgreso](
	@ItemSubGrupoEgreso				varchar(50),
	@GrupoEgresoId					int,
	@UsuarioCreacionId				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran

			-- if exists(select idSubGrupoEgreso from SubGrupoEgreso where Descripcion=@Descripcion)
			 --  begin
			--	  RAISERROR ('Ya se encuentra un SubGrupoEgreso registrado con éste Nombre', 11, 1)
			 --  end
			--else
			  begin
				  
				  insert into SubGrupoEgreso(ItemSubGrupoEgreso,GrupoEgresoId, UsuarioCreacionId,FechaCreacion,EstadoActivo)
				  values (@ItemSubGrupoEgreso,@GrupoEgresoId,@UsuarioCreacionId,GETDATE(),1)
			
				  select @ErrorCode = @@ERROR 
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	
	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END

GO
/****** Object:  StoredProcedure [dbo].[CrearTipoCliente]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearTipoCliente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CrearTipoCliente] AS' 
END
GO

ALTER PROCEDURE [dbo].[CrearTipoCliente](
	@Descripcion				varchar(50),
	@UsuarioCreacionId			int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran

			-- if exists(select idGrupoIngreso from GrupoIngreso where Descripcion=@Descripcion)
			 --  begin
			--	  RAISERROR ('Ya se encuentra un GrupoIngreso registrado con éste Nombre', 11, 1)
			 --  end
			--else
			  begin
				  
				  insert into TipoCliente(Descripcion,UsuarioCreacionId,FechaCreacion,EstadoActivo)
				  values (@Descripcion,@UsuarioCreacionId,GETDATE(),1)
			
				  select @ErrorCode = @@ERROR 
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	
	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[CrearUsuario]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CrearUsuario]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CrearUsuario] AS' 
END
GO
ALTER PROCEDURE [dbo].[CrearUsuario](
	@NombreCompleto				varchar(200),
	@NombreUsuario				varchar(50),
	@Contraseña					varchar(50)
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			if exists(select IdUsuario from Usuario where NombreUsuario=@NombreUsuario)
			  begin
				  RAISERROR ('Ya se encuentra registrado un usuario con es ID', 11, 1)
			  end
			else
			  begin
				  
				  insert into Usuario(NombreCompleto,NombreUsuario,Contraseña,FechaCreacion,EstadoActivo)
				  values (@NombreCompleto,@NombreUsuario,@Contraseña,GETDATE(),1)
			
				  select @ErrorCode = @@ERROR 
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	
	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[EliminarActivo]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarActivo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[EliminarActivo] AS' 
END
GO
ALTER PROCEDURE [dbo].[EliminarActivo](
	@IdActivo						int,
	@UsuarioModificacionId			int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;
	begin
		begin tran
			begin
				  
				  update Activo 
					set					
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = 0
					where IdActivo = @IdActivo
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[EliminarCliente]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarCliente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[EliminarCliente] AS' 
END
GO

ALTER PROCEDURE [dbo].[EliminarCliente](
	@IdCliente							int,
	@UsuarioModificacionId				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;
	begin
		begin tran
			begin
				  
				  update Cliente 
					set					
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = 0
					where IdCliente = @IdCliente
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[EliminarContacto]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarContacto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[EliminarContacto] AS' 
END
GO
ALTER PROCEDURE [dbo].[EliminarContacto](
	@IdContacto						int,
	@UsuarioModificacionId				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;
	begin
		begin tran
			begin
				  
				  update Contacto 
					set					
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = 0
					where IdContacto = @IdContacto
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END

GO
/****** Object:  StoredProcedure [dbo].[EliminarEgreso]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarEgreso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[EliminarEgreso] AS' 
END
GO
ALTER PROCEDURE [dbo].[EliminarEgreso](
	@IdEgreso						int,
	@UsuarioModificacionId			int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;
	begin
		begin tran
			begin
				  
				  update Egreso 
					set					
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = 0
					where IdEgreso = @IdEgreso
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END

GO
/****** Object:  StoredProcedure [dbo].[EliminarGrupoActivo]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarGrupoActivo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[EliminarGrupoActivo] AS' 
END
GO

ALTER PROCEDURE [dbo].[EliminarGrupoActivo](
	@IdGrupoActivo						int,
	@UsuarioModificacionId				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;
	begin
		begin tran
			begin
				  
				  update GrupoActivo 
					set					
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = 0
					where IdGrupoActivo = @IdGrupoActivo
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[EliminarGrupoEgreso]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarGrupoEgreso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[EliminarGrupoEgreso] AS' 
END
GO

ALTER PROCEDURE [dbo].[EliminarGrupoEgreso](
	@IdGrupoEgreso						int,
	@UsuarioModificacionId				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;
	begin
		begin tran
			begin
				  
				  update GrupoEgreso 
					set					
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = 0
					Where IdGrupoEgreso = @IdGrupoEgreso
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END

GO
/****** Object:  StoredProcedure [dbo].[EliminarGrupoIngreso]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarGrupoIngreso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[EliminarGrupoIngreso] AS' 
END
GO
ALTER PROCEDURE [dbo].[EliminarGrupoIngreso](
	@IdGrupoIngreso						int,
	@UsuarioModificacionId				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;
	begin
		begin tran
			begin
				  
				  update GrupoIngreso 
					set					
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = 0
					where IdGrupoIngreso = @IdGrupoIngreso
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[EliminarGrupoPasivo]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarGrupoPasivo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[EliminarGrupoPasivo] AS' 
END
GO

ALTER PROCEDURE [dbo].[EliminarGrupoPasivo](
	@IdGrupoPasivo						int,
	@UsuarioModificacionId				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;
	begin
		begin tran
			begin
				  
				  update GrupoPasivo
					set					
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = 0
					where IdGrupoPasivo = @IdGrupoPasivo
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END



GO
/****** Object:  StoredProcedure [dbo].[EliminarGrupoPatrimonio]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarGrupoPatrimonio]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[EliminarGrupoPatrimonio] AS' 
END
GO
ALTER PROCEDURE [dbo].[EliminarGrupoPatrimonio](
	@IdGrupoPatrimonio					int,
	@UsuarioModificacionId				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;
	begin
		begin tran
			begin
				  
				  update GrupoPatrimonio
					set					
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = 0
					where IdGrupoPatrimonio = @IdGrupoPatrimonio
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END



GO
/****** Object:  StoredProcedure [dbo].[EliminarIngreso]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarIngreso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[EliminarIngreso] AS' 
END
GO
ALTER PROCEDURE [dbo].[EliminarIngreso](
	@IdIngreso						int,
	@UsuarioModificacionId			int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;
	begin
		begin tran
			begin
				  
				  update Ingreso 
					set					
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = 0
					where IdIngreso = @IdIngreso
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[EliminarPago]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarPago]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[EliminarPago] AS' 
END
GO
ALTER PROCEDURE [dbo].[EliminarPago](
	@IdPago						int,
	@UsuarioModificacionId		int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;
	begin
		begin tran
			begin 
				update Pago 
				set
					UsuarioModificacionId = @UsuarioModificacionId,
					FechaModificacion = GETDATE(),
					EstadoActivo = 0
				where IdPago = @IdPago
				if @ErrorCode <> 0 goto onError
			end
		commit tran
	end
	

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[EliminarParametro]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarParametro]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[EliminarParametro] AS' 
END
GO
ALTER PROCEDURE [dbo].[EliminarParametro](
	@IdParametro						int,
	@UsuarioModificacionId				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;
	begin
		begin tran
			begin
				  
				  update Parametro
					set					
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = 0
					where idParametro = @IdParametro
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END




GO
/****** Object:  StoredProcedure [dbo].[EliminarPasivo]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarPasivo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[EliminarPasivo] AS' 
END
GO
ALTER PROCEDURE [dbo].[EliminarPasivo](
	@IdPasivo						int,
	@UsuarioModificacionId			int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;
	begin
		begin tran
			begin
				  
				  update Pasivo 
					set					
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = 0
					where IdPasivo = @IdPasivo
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[EliminarPatrimonio]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarPatrimonio]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[EliminarPatrimonio] AS' 
END
GO
ALTER PROCEDURE [dbo].[EliminarPatrimonio](
	@IdPatrimonio						int,
	@UsuarioModificacionId			int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;
	begin
		begin tran
			begin
				  
				  update Patrimonio 
					set					
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = 0
					where IdPatrimonio = @IdPatrimonio
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END



GO
/****** Object:  StoredProcedure [dbo].[EliminarProveedor]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarProveedor]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[EliminarProveedor] AS' 
END
GO
ALTER PROCEDURE [dbo].[EliminarProveedor](
	@IdProveedor						int,
	@UsuarioModificacionId				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;
	begin
		begin tran
			begin
				  
				  update Proveedor 
					set					
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = 0
					where IdProveedor = @IdProveedor
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END

GO
/****** Object:  StoredProcedure [dbo].[EliminarProyectado]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarProyectado]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[EliminarProyectado] AS' 
END
GO
ALTER PROCEDURE [dbo].[EliminarProyectado](
	@IdProyectado					int,
	@UsuarioModificacionId			int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	
	BEGIN
		begin
			begin tran
				begin
				  
					  update Proyectado 
						set					
							UsuarioModificacionId = @UsuarioModificacionId,
							FechaModificacion = GETDATE(),
							EstadoActivo = 0
						where IdProyectado = @IdProyectado
					  if @ErrorCode <> 0 goto onError
				  end
			commit tran
		end
	END

		onError:
		if @ErrorCode <> 0
		begin
			print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
			rollback tran 
		end
	
END

GO
/****** Object:  StoredProcedure [dbo].[EliminarRelacionDebeHaber]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarRelacionDebeHaber]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[EliminarRelacionDebeHaber] AS' 
END
GO
ALTER PROCEDURE [dbo].[EliminarRelacionDebeHaber](
	@IdRelacionDebeHaber				int,
	@UsuarioModificacionId				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;
	begin
		begin tran
			begin
				  
				  update RelacionDebeHaber 
					set					
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = 0
					where IdRelacionDebeHaber = @IdRelacionDebeHaber
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END

GO
/****** Object:  StoredProcedure [dbo].[EliminarSubGrupoEgreso]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarSubGrupoEgreso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[EliminarSubGrupoEgreso] AS' 
END
GO

ALTER PROCEDURE [dbo].[EliminarSubGrupoEgreso](
	@IdSubGrupoEgreso						int,
	@UsuarioModificacionId					int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;
	begin
		begin tran
			begin
				  
				  update SubGrupoEgreso 
					set					
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = 0
					where IdSubGrupoEgreso = @IdSubGrupoEgreso
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[EliminarTipoCliente]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarTipoCliente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[EliminarTipoCliente] AS' 
END
GO

ALTER PROCEDURE [dbo].[EliminarTipoCliente](
	@IdTipoCliente						int,
	@UsuarioModificacionId				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;
	begin
		begin tran
			begin
				  
				  update TipoCliente 
					set					
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = 0
						where idTipoCliente = @IdTipoCliente
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[EliminarUsuario]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarUsuario]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[EliminarUsuario] AS' 
END
GO
ALTER PROCEDURE [dbo].[EliminarUsuario](
	@IdUsuario						int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;
	begin
		begin tran
			begin
				  
				  update Usuario
					set					
						FechaModificacion = GETDATE(),
						EstadoActivo = 0
					where idUsuario = @IdUsuario
				  if @ErrorCode <> 0 goto onError
			  end
		commit tran
	end
	

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END




GO
/****** Object:  StoredProcedure [dbo].[LeerActivo]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerActivo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerActivo] AS' 
END
GO
ALTER PROCEDURE [dbo].[LeerActivo](
	@IdActivo				int,
	@PeriodoId				int,
	@GrupoId				int,
	@TablaMaestra			bit = 0
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			begin
			select 
				ROW_NUMBER() OVER(ORDER BY PeriodoId desc, GrupoActivoId desc) as item,
				A.IdActivo, 
				A.GrupoActivoId,
				GA.Descripcion,
				A.Monto,
				A.PeriodoId,
				P.DescripcionPeriodo as Periodo
			from Activo A
			inner join GrupoActivo GA on GA.IdGrupoActivo = A.GrupoActivoId 
			inner join Periodo P on P.idPeriodo = A.PeriodoId
			Where A.EstadoActivo = 1
			And ((@IdActivo = 0) OR (IdActivo = @IdActivo))
			and ((@PeriodoId = 0) OR (PeriodoId = @PeriodoId))
			and ((@GrupoId = 0) OR (GrupoActivoId = @GrupoId))
			AND ((@TablaMaestra = 1) OR (@TablaMaestra = 0 and A.EstadoActivo = 1))
			order by PeriodoId desc, GrupoActivoId desc

			select @ErrorCode = @@ERROR 
			if @ErrorCode <> 0 goto onError
			end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end	
END


GO
/****** Object:  StoredProcedure [dbo].[LeerCliente]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerCliente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerCliente] AS' 
END
GO

ALTER PROCEDURE [dbo].[LeerCliente](
	@IdCliente				int,
	@TablaMaestra			bit = 0 
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
					
					select ROW_NUMBER() OVER(ORDER BY IdCliente) AS Item,
					C.IdCliente,
					C.TipoClienteId,
					-- TC.Descripcion as TipoCliente,
					C.RazonSocial,
					C.Documento,
					C.Descripcion as Descripcion,
					C.MetaEntidad,
					C.MetaEmpresa,
					C.Correo,
					C.NumeroContacto,
					C.EstadoActivo AS IdEstadoActivo,
					IIF(C.EstadoActivo = 1, 'Activo', 'Inactivo') AS EstadoActivo
					from Cliente C
					-- inner join TipoCliente TC on TC.IdTipoCliente = C.TipoClienteId
					Where ((@IdCliente = 0) OR (C.IdCliente = @IdCliente))
					AND ((@TablaMaestra = 1) OR (@TablaMaestra = 0 and EstadoActivo = 1))
					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
				end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[LeerContacto]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerContacto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerContacto] AS' 
END
GO


ALTER PROCEDURE [dbo].[LeerContacto]
	(
		@IdContacto				int,
		@OrigenId				int,
		@TipoContactoId			int,
		@TablaMaestra			bit = 0 
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			if @TipoContactoId = 1
				begin
					select 
						ROW_NUMBER() OVER(ORDER BY IdContacto asc) as item,
						IdContacto,
						OrigenId,
						NombreCompleto,
						Cargo,
						C.Correo,
						Celular,
						IIF(C.EstadoActivo = 1, 'Activo', 'Inactivo') AS EstadoActivo,
						C.EstadoActivo as IdEstadoActivo
					from Contacto C
					inner join Cliente Cl ON C.OrigenId = Cl.IdCliente
					Where ((@IdContacto = 0) OR (IdContacto = @IdContacto))
					and ((@OrigenId = 0) OR (OrigenId = @OrigenId))
					AND ((@TablaMaestra = 1) OR (@TablaMaestra = 0 and C.EstadoActivo = 1))
					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
				end
			if @TipoContactoId = 2
				begin
					select 
						ROW_NUMBER() OVER(ORDER BY IdContacto asc) as item,
						IdContacto,
						OrigenId,
						NombreCompleto,
						Cargo,
						C.Correo,
						Celular,
						IIF(C.EstadoActivo = 1, 'Activo', 'Inactivo') AS EstadoActivo,
						C.EstadoActivo as IdEstadoActivo
					from Contacto C
					inner join Proveedor P ON C.OrigenId = P.IdProveedor
					Where ((@IdContacto = 0) OR (IdContacto = @IdContacto))
					and ((@OrigenId = 0) OR (OrigenId = @OrigenId))
					AND ((@TablaMaestra = 1) OR (@TablaMaestra = 0 and C.EstadoActivo = 1))
					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
				end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END

GO
/****** Object:  StoredProcedure [dbo].[LeerEgreso]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerEgreso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerEgreso] AS' 
END
GO


ALTER PROCEDURE [dbo].[LeerEgreso](
	@IdEgreso					int,
	@PeriodoId					int,
	@ProveedorId				int,
	@alerta						bit
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	DECLARE @Cierre INT
	SET @Cierre = (SELECT Cierre FROM Periodo WHERE idPeriodo=@PeriodoId)
	Declare @dias as int
	Set @dias = (Select ValorParametro from Parametro where idParametro = 4)

IF @Cierre=0 OR @PeriodoId=0
	BEGIN
	if @alerta = 0
		begin
			begin tran
				begin
				select 
					ROW_NUMBER() OVER(ORDER BY PeriodoId desc, E.GrupoEgresoId desc, E.SubGrupoEgresoId desc) as item,
					E.IdEgreso, 
					E.GrupoEgresoId,
					GE.Descripcion as GrupoEgresoDescripcion,
					E.SubGrupoEgresoId,
					SGE.ItemSubGrupoEgreso as SubGrupoEgresoDescripcion,
					E.ProveedorId,
					P.NombreComercial,
					E.NumeroComprobanteEgreso,
					E.IGV,
					E.PeriodoId,
					E.Comentario,
					E.FechaEgresoProvision,
					E.ImporteProvision,
					E.ComprobanteUbicacion,
					E.Deuda
				from Egreso E
				inner join Proveedor P on P.IdProveedor = E.ProveedorId
				inner join GrupoEgreso GE on GE.IdGrupoEgreso = E.GrupoEgresoId
				inner join SubGrupoEgreso SGE on SGE.IdSubGrupoEgreso = E.SubGrupoEgresoId
				Where ((@IdEgreso = 0) OR (IdEgreso = @IdEgreso))
				and ((@PeriodoId = 0) OR (PeriodoId = @PeriodoId))
				and ((@ProveedorId = 0) OR (ProveedorId = @ProveedorId))
				and (E.EstadoActivo = 1)
				order by PeriodoId desc, E.GrupoEgresoId desc, E.SubGrupoEgresoId desc

				select @ErrorCode = @@ERROR 
				if @ErrorCode <> 0 goto onError
				end
			commit tran
		end
	Else
		Begin
			begin tran
				begin
				select 
					ROW_NUMBER() OVER(ORDER BY PeriodoId desc, E.GrupoEgresoId desc, E.SubGrupoEgresoId desc) as item,
					E.IdEgreso, 
					E.GrupoEgresoId,
					GE.Descripcion as GrupoEgresoDescripcion,
					E.SubGrupoEgresoId,
					SGE.ItemSubGrupoEgreso as SubGrupoEgresoDescripcion,
					E.ProveedorId,
					P.NombreComercial,
					E.NumeroComprobanteEgreso,
					E.IGV,
					E.PeriodoId,
					E.Comentario,
					E.FechaEgresoProvision,
					E.ImporteProvision,
					E.ComprobanteUbicacion,
					E.Deuda
				from Egreso E
				inner join Proveedor P on P.IdProveedor = E.ProveedorId
				inner join GrupoEgreso GE on GE.IdGrupoEgreso = E.GrupoEgresoId
				inner join SubGrupoEgreso SGE on SGE.IdSubGrupoEgreso = E.SubGrupoEgresoId
				Where ((@IdEgreso = 0) OR (IdEgreso = @IdEgreso))
				and ((@PeriodoId = 0) OR (PeriodoId = @PeriodoId))
				and ((@ProveedorId = 0) OR (ProveedorId = @ProveedorId))
				and (E.EstadoActivo = 1)
				and E.Deuda > 0
				and DATEDIFF(day,E.FechaEgresoProvision,getdate()) > @dias
				order by PeriodoId desc, E.GrupoEgresoId desc, E.SubGrupoEgresoId desc

				select @ErrorCode = @@ERROR 
				if @ErrorCode <> 0 goto onError
				end
			commit tran
		End
	END
	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END
GO
/****** Object:  StoredProcedure [dbo].[LeerEstadoResultado]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerEstadoResultado]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerEstadoResultado] AS' 
END
GO
ALTER PROCEDURE [dbo].[LeerEstadoResultado](
	@IdEstadoResultado				int,
	@PeriodoId						int,
	@Orden							int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			begin		
				Select			
					IdEstadoResultado,
					Concepto,
					Periodo,
					Valor,
					Orden
				from EstadoResultado
				Where ((@IdEstadoResultado = 0) OR (IdEstadoResultado = @IdEstadoResultado))
						AND ((@PeriodoId = 0) OR (Periodo = @PeriodoId))
						AND ((@Orden = 0) OR (Orden = @Orden))
				select @ErrorCode = @@ERROR 
				if @ErrorCode <> 0 goto onError
			end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END



GO
/****** Object:  StoredProcedure [dbo].[LeerEstadoResultadoCalculado]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerEstadoResultadoCalculado]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerEstadoResultadoCalculado] AS' 
END
GO
ALTER PROCEDURE [dbo].[LeerEstadoResultadoCalculado](
@IdPeriodo int
)
AS
BEGIN
	SELECT 
		P.DescripcionPeriodo as Periodo,
		Sum(I.ImporteProvision) as Venta,
		Sum(EC1.ImporteProvision) as Costo1,
		Sum(EC2.ImporteProvision) as Costo2,
		Sum(EC3.ImporteProvision) as Costo3,
		Sum(EGA.ImporteProvision) as GastoAdministrativo,
		Sum(EGV.ImporteProvision) as GastoVenta,
		Sum(EGF.ImporteProvision) as GastoFinanciero,
		Sum(EGM.ImporteProvision) as GastoMenor,
		Sum(EGI.ImporteProvision) as GastoInversion
	FROM Periodo P
		Full outer JOIN Ingreso I ON P.idPeriodo = I.PeriodoId
		Full outer JOIN Egreso EC1 ON (P.idPeriodo = EC1.PeriodoId and EC1.GrupoEgresoId = 1)
		Full outer JOIN Egreso EC2 ON (P.idPeriodo = EC2.PeriodoId and EC2.GrupoEgresoId = 2)
		Full outer JOIN Egreso EC3 ON (P.idPeriodo = EC3.PeriodoId and EC3.GrupoEgresoId = 3)
		Full outer JOIN Egreso EGA ON (P.idPeriodo = EGA.PeriodoId and EGA.GrupoEgresoId = 4)
		Full outer JOIN Egreso EGV ON (P.idPeriodo = EGV.PeriodoId and EGV.GrupoEgresoId = 5)
		Full outer JOIN Egreso EGF ON (P.idPeriodo = EGF.PeriodoId and EGF.GrupoEgresoId = 6)
		Full outer JOIN Egreso EGM ON (P.idPeriodo = EGM.PeriodoId and EGM.GrupoEgresoId = 7)
		Full outer JOIN Egreso EGI ON (P.idPeriodo = EGI.PeriodoId and EGI.GrupoEgresoId = 8)
	WHERE I.EstadoActivo = 1	
	and P.idPeriodo = @IdPeriodo
	Group by P.DescripcionPeriodo
END
GO
/****** Object:  StoredProcedure [dbo].[LeerGrupoActivo]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerGrupoActivo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerGrupoActivo] AS' 
END
GO

ALTER PROCEDURE [dbo].[LeerGrupoActivo](
	@IdGrupoActivo				int,
	@Descripcion				varchar(50),
	@TablaMaestra				bit = 0
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
					
					select ROW_NUMBER() OVER(ORDER BY IdGrupoActivo asc) as item,
					IdGrupoActivo,
					Tipo as IdTipo,
					IIF(Tipo = 1, 'Corriente', 'No Corriente') AS Tipo,  
					Descripcion,
					Cuenta,
					EstadoActivo AS IdEstadoActivo,
					IIF(EstadoActivo = 1, 'Activo', 'Inactivo') AS EstadoActivo  
					from GrupoActivo
					Where ((@IdGrupoActivo = 0) OR (IdGrupoActivo = @IdGrupoActivo))
					AND ((@TablaMaestra = 1) OR (@TablaMaestra = 0 and EstadoActivo = 1))
					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
				end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[LeerGrupoEgreso]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerGrupoEgreso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerGrupoEgreso] AS' 
END
GO


ALTER PROCEDURE [dbo].[LeerGrupoEgreso](
	@IdGrupoEgreso				int,
	@TablaMaestra				bit = 0
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
					
					select ROW_NUMBER() OVER(ORDER BY IdGrupoEgreso asc) as item,
					IdGrupoEgreso, Descripcion, 
					EstadoActivo AS IdEstadoActivo,
					IIF(EstadoActivo = 1, 'Activo', 'Inactivo') AS EstadoActivo 
					from GrupoEgreso
					Where ((@IdGrupoEgreso = 0) OR (IdGrupoEgreso = @IdGrupoEgreso))
					AND ((@TablaMaestra = 1) OR (@TablaMaestra = 0 and EstadoActivo = 1))
					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
				end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END

GO
/****** Object:  StoredProcedure [dbo].[LeerGrupoIngreso]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerGrupoIngreso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerGrupoIngreso] AS' 
END
GO

ALTER PROCEDURE [dbo].[LeerGrupoIngreso](
	@IdGrupoIngreso				int,
	@Descripcion				varchar(50),
	@TablaMaestra				bit = 0
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
					
					select ROW_NUMBER() OVER(ORDER BY IdGrupoIngreso asc) as item,
					IdGrupoIngreso, Descripcion, EstadoActivo AS IdEstadoActivo,
					IIF(EstadoActivo = 1, 'Activo', 'Inactivo') AS EstadoActivo  
					from GrupoIngreso
					Where ((@IdGrupoIngreso = 0) OR (IdGrupoIngreso = @IdGrupoIngreso))
					AND ((@TablaMaestra = 1) OR (@TablaMaestra = 0 and EstadoActivo = 1))
					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
				end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END

GO
/****** Object:  StoredProcedure [dbo].[LeerGrupoPasivo]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerGrupoPasivo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerGrupoPasivo] AS' 
END
GO


ALTER PROCEDURE [dbo].[LeerGrupoPasivo](
	@IdGrupoPasivo				int,
	@Descripcion				varchar(50),
	@TablaMaestra				bit = 0
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
					
					select ROW_NUMBER() OVER(ORDER BY IdGrupoPasivo asc) as item,
					IdGrupoPasivo,
					Tipo as TipoId,
					IIF(Tipo = 1, 'Corriente', 'No Corriente') AS TipoDescripcion,  
					Descripcion,
					Cuenta,
					EstadoActivo AS IdEstadoActivo,
					IIF(EstadoActivo = 1, 'Activo', 'Inactivo') AS EstadoActivo  
					from GrupoPasivo
					Where ((@IdGrupoPasivo = 0) OR (IdGrupoPasivo = @IdGrupoPasivo))
					AND ((@TablaMaestra = 1) OR (@TablaMaestra = 0 and EstadoActivo = 1))
					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
				end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[LeerGrupoPatrimonio]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerGrupoPatrimonio]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerGrupoPatrimonio] AS' 
END
GO

ALTER PROCEDURE [dbo].[LeerGrupoPatrimonio](
	@IdGrupoPatrimonio			int,
	@Descripcion				varchar(50),
	@TablaMaestra				bit = 0
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
					
					select ROW_NUMBER() OVER(ORDER BY IdGrupoPatrimonio asc) as item,
					IdGrupoPatrimonio,
					Descripcion,
					Cuenta,
					EstadoActivo AS IdEstadoActivo,
					IIF(EstadoActivo = 1, 'Activo', 'Inactivo') AS EstadoActivo  
					from GrupoPatrimonio
					Where ((@IdGrupoPatrimonio = 0) OR (IdGrupoPatrimonio = @IdGrupoPatrimonio))
					AND ((@TablaMaestra = 1) OR (@TablaMaestra = 0 and EstadoActivo = 1))
					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
				end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[LeerIngreso]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerIngreso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerIngreso] AS' 
END
GO

ALTER PROCEDURE [dbo].[LeerIngreso](
	@IdIngreso				int,
	@PeriodoId				int,
	@ClienteId				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;
	
	DECLARE @Cierre INT
	SET @Cierre = (SELECT top 1 Cierre FROM Periodo WHERE idPeriodo=@PeriodoId)

IF @Cierre=0 OR @PeriodoId=0
	BEGIN
		begin
			begin tran
				begin
				select 
					ROW_NUMBER() OVER(ORDER BY PeriodoId desc, GrupoIngresoId desc) as item,
					IdIngreso, 
					GrupoIngresoId,
					ClienteId,
					C.Descripcion,
					NumeroComprobanteIngreso,
					Detraccion,
					IGV,
					PeriodoId,
					Comentario,
					FechaIngresoProvision,
					ImporteProvision,
					ComprobanteUbicacion,
					Deuda
				from Ingreso I
				inner join Cliente C on I.ClienteId = C.IdCliente 
				Where ((@IdIngreso = 0) OR (IdIngreso = @IdIngreso))
				and ((@PeriodoId = 0) OR (PeriodoId = @PeriodoId))
				and ((@ClienteId = 0) OR (ClienteId = @ClienteId))
				and (I.EstadoActivo = 1)
				order by PeriodoId desc, GrupoIngresoId desc

				select @ErrorCode = @@ERROR 
				if @ErrorCode <> 0 goto onError
				end
			commit tran
		end

		onError:
		if @ErrorCode <> 0
		begin
			print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
			rollback tran 
		end
	END
END
GO
/****** Object:  StoredProcedure [dbo].[LeerMetodoPago]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerMetodoPago]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerMetodoPago] AS' 
END
GO
ALTER PROCEDURE [dbo].[LeerMetodoPago](
	@IdMetodoPago				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			select
				IdMetodoPago,
				Descripcion
			from MetodoPago 			
			Where ((@IdMetodoPago = 0) OR (IdMetodoPago = @IdMetodoPago))
			and EstadoActivo = 1
			select @ErrorCode = @@ERROR 
			if @ErrorCode <> 0 goto onError
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END

GO
/****** Object:  StoredProcedure [dbo].[LeerPago]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerPago]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerPago] AS' 
END
GO
ALTER PROCEDURE [dbo].[LeerPago]
	(
		@IdPago				int,
		@OrigenId			int,
		@TipoOrigen			int,
		@PeriodoId			int,
		@ClienteId			int = 0,
		@ProveedorId		int = 0
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			if @TipoOrigen = 1
				begin
					select 
						ROW_NUMBER() OVER(ORDER BY IdPago asc) as item,
						P.IdPago,
						P.OrigenId,
						--ComprobanteUbicacion,
						P.NumeroComprobante,
						MP.Descripcion as MedioDePago,
						P.MetodoPagoId,
						P.NroOperacion,
						P.FechaPago,
						P.ImporteTotal,
						P.ImporteCancelado,
						P.ImporteDetraccion,
						P.ImporteIGV
					from Pago P
					inner join Ingreso I ON P.OrigenId = I.IdIngreso
					inner join MetodoPago MP ON MP.IdMetodoPago = P.MetodoPagoId
					Where ((@IdPago = 0) OR (IdPago = @IdPago))
					and ((@OrigenId = 0) OR (IdIngreso = @OrigenId))
					and ((@PeriodoId = 0) OR (I.PeriodoId = @PeriodoId))
					and ((@ClienteId = 0) OR (I.ClienteId = @ClienteId))
					and (P.EstadoActivo = 1)

					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
				end
			if @TipoOrigen = 2
				begin
					select 
						ROW_NUMBER() OVER(ORDER BY IdPago asc) as item,
						P.IdPago,
						P.OrigenId,
						--ComprobanteUbicacion,
						P.NumeroComprobante,
						MP.Descripcion as MedioDePago,
						P.MetodoPagoId,
						P.NroOperacion,
						P.FechaPago,
						P.ImporteTotal,
						P.ImporteCancelado,
						P.ImporteDetraccion,
						P.ImporteIGV
					from Pago P
					inner join Egreso E ON P.OrigenId = E.IdEgreso
					inner join MetodoPago MP ON MP.IdMetodoPago = P.MetodoPagoId
					Where ((@IdPago = 0) OR (IdPago = @IdPago))
					and ((@OrigenId = 0) OR (IdEgreso = @OrigenId))
					and ((@PeriodoId = 0) OR (E.PeriodoId = @PeriodoId))
					and ((@ClienteId = 0) OR (E.ProveedorId = @ClienteId))
					and (P.EstadoActivo = 1)

					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
				end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[LeerParametro]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerParametro]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerParametro] AS' 
END
GO
ALTER PROCEDURE [dbo].[LeerParametro](
	@IdParametro				int,
	@Descripcion				varchar(50),
	@TipoParametro				varchar(50),
	@TablaMaestra				bit = 0
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
					
					select ROW_NUMBER() OVER(ORDER BY IdParametro) AS Item,
					IdParametro,
					TipoParametro,
					Descripcion,
					ValorParametro,
					EstadoActivo AS IdEstadoActivo,
					IIF(EstadoActivo = 1, 'Activo', 'Inactivo') AS EstadoActivo
					from Parametro
					Where ((@IdParametro = 0) OR (idParametro = @IdParametro))
					AND ((@Descripcion= '') OR (Descripcion LIKE '%'+ @Descripcion+'%'))
					AND ((@TipoParametro= '') OR (TipoParametro LIKE '%'+ @TipoParametro+'%'))
					AND ((@TablaMaestra = 1) OR (@TablaMaestra = 0 and EstadoActivo = 1))
					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
				end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END




GO
/****** Object:  StoredProcedure [dbo].[LeerPasivo]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerPasivo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerPasivo] AS' 
END
GO
ALTER PROCEDURE [dbo].[LeerPasivo](
	@IdPasivo				int,
	@PeriodoId				int,
	@GrupoId				int,
	@TablaMaestra			bit = 0
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			begin
			select 
				ROW_NUMBER() OVER(ORDER BY PeriodoId desc, GrupoPasivoId desc) as item,
				P.IdPasivo, 
				P.GrupoPasivoId,
				GP.Descripcion,
				P.Monto,
				P.PeriodoId,
				PE.DescripcionPeriodo as Periodo
			from Pasivo P
			inner join GrupoPasivo GP on GP.IdGrupoPasivo = P.GrupoPasivoId 
			inner join Periodo Pe on Pe.idPeriodo = P.PeriodoId
			Where P.EstadoActivo = 1
			and ((@IdPasivo = 0) OR (IdPasivo = @IdPasivo))
			and ((@PeriodoId = 0) OR (PeriodoId = @PeriodoId))
			and ((@GrupoId = 0) OR (GrupoPasivoId = @GrupoId))
			AND ((@TablaMaestra = 1) OR (@TablaMaestra = 0 and P.EstadoActivo = 1))
			order by PeriodoId desc, GrupoPasivoId desc

			select @ErrorCode = @@ERROR 
			if @ErrorCode <> 0 goto onError
			end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[LeerPatrimonio]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerPatrimonio]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerPatrimonio] AS' 
END
GO
ALTER PROCEDURE [dbo].[LeerPatrimonio](
	@IdPatrimonio			int,
	@PeriodoId				int,
	@GrupoId				int,
	@TablaMaestra			bit = 0
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			begin
			select 
				ROW_NUMBER() OVER(ORDER BY PeriodoId desc, GrupoPatrimonioId desc) as item,
				P.IdPatrimonio, 
				P.GrupoPatrimonioId,
				GP.Descripcion,
				P.Monto,
				P.PeriodoId,
				Pe.DescripcionPeriodo as Periodo
			from Patrimonio P
			inner join GrupoPatrimonio GP on GP.IdGrupoPatrimonio = P.GrupoPatrimonioId			
			inner join Periodo Pe on Pe.idPeriodo = P.PeriodoId
			Where P.EstadoActivo = 1
			and ((@IdPatrimonio = 0) OR (IdPatrimonio = @IdPatrimonio))
			and ((@PeriodoId = 0) OR (PeriodoId = @PeriodoId))
			and ((@GrupoId = 0) OR (GrupoPatrimonioId = @GrupoId))
			and ((@TablaMaestra = 1) OR (@TablaMaestra = 0 and P.EstadoActivo = 1))
			order by PeriodoId desc, GrupoPatrimonioId desc

			select @ErrorCode = @@ERROR 
			if @ErrorCode <> 0 goto onError
			end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[LeerPeriodo]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerPeriodo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerPeriodo] AS' 
END
GO


ALTER PROCEDURE [dbo].[LeerPeriodo](
	@IdPeriodo				int,
	@DescripcionPeriodo		varchar(10) = '',
	@Modo					int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			if @DescripcionPeriodo = ''
				begin
					if @Modo = 0
					Begin
						select
							ROW_NUMBER() OVER(ORDER BY IdPeriodo desc) as item,
							IdPeriodo as IdPeriodo,
							DescripcionPeriodo as DescripcionPeriodo,
							FechaInicio as FechaInicio,
							FechaFin as FechaFin,
							IIF(Cierre = 1, 'CERRADO', 'NO CERRADO') AS Cierre
						from Periodo 			
						Where ((@IdPeriodo = 0) OR (IdPeriodo = @IdPeriodo))
						order by idPeriodo desc
						select @ErrorCode = @@ERROR 
						if @ErrorCode <> 0 goto onError
					End
					if @Modo = 1
					Begin
						select
							ROW_NUMBER() OVER(ORDER BY IdPeriodo desc) as item,
							IdPeriodo as IdPeriodo,
							DescripcionPeriodo as DescripcionPeriodo,
							FechaInicio as FechaInicio,
							FechaFin as FechaFin,
							IIF(Cierre = 1, 'CERRADO', 'NO CERRADO') AS Cierre
						from Periodo 			
						Where ((@IdPeriodo = 0) OR (IdPeriodo = @IdPeriodo))
						and DATEDIFF(MONTH, GETDATE(), FechaFin) < 1
						order by idPeriodo desc
						select @ErrorCode = @@ERROR 
						if @ErrorCode <> 0 goto onError
					end
					if @Modo = 2
					Begin
						select
							ROW_NUMBER() OVER(ORDER BY IdPeriodo desc) as item,
							IdPeriodo as IdPeriodo,
							DescripcionPeriodo as DescripcionPeriodo,
							FechaInicio as FechaInicio,
							FechaFin as FechaFin,
							IIF(Cierre = 1, 'CERRADO', 'NO CERRADO') AS Cierre
						from Periodo 			
						Where ((@IdPeriodo = 0) OR (IdPeriodo = @IdPeriodo))
						and DATEDIFF(MONTH, GETDATE(), FechaFin) > 0
						order by idPeriodo desc
						select @ErrorCode = @@ERROR 
						if @ErrorCode <> 0 goto onError
					End
				end
			else
				begin
					select
						IdPeriodo,
						DescripcionPeriodo,
						FechaInicio,
						FechaFin,
						Cierre
					from Periodo 			
					Where ((@DescripcionPeriodo = '') OR (DescripcionPeriodo LIKE '%'+@DescripcionPeriodo+'%'))
					order by idPeriodo desc
					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
				end
		commit tran
	end
	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end	
END
GO
/****** Object:  StoredProcedure [dbo].[LeerProveedor]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerProveedor]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerProveedor] AS' 
END
GO

ALTER PROCEDURE [dbo].[LeerProveedor](
	@IdProveedor				int,
	@TablaMaestra				bit = 0
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
					
					select ROW_NUMBER() OVER(ORDER BY IdProveedor) AS Item,
					PR.IdProveedor,
					PR.Documento,
					PR.NombreComercial,
					PR.RazonSocial,
					PR.NumeroContacto,
					PR.Correo,
					PR.MedicionId,
					PA.Descripcion as TipoMedicion,
					PR.Tarifa,
					PR.EstadoActivo AS IdEstadoActivo,
					IIF(PR.EstadoActivo = 1, 'Activo', 'Inactivo') AS EstadoActivo
					from Proveedor PR
					inner join Parametro PA on PA.idParametro = PR.MedicionId
					Where ((@IdProveedor = 0) OR (PR.IdProveedor = @IdProveedor))
					AND ((@TablaMaestra = 1) OR (@TablaMaestra = 0 and PR.EstadoActivo = 1))
					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
				end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[LeerProyectado]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerProyectado]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerProyectado] AS' 
END
GO
ALTER PROCEDURE [dbo].[LeerProyectado](
	@IdProyectado				int,
	@SubGrupoEgresoId			int,
	@PeriodoId					int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	DECLARE @Cierre INT
	SET @Cierre = (SELECT Cierre FROM Periodo WHERE idPeriodo=@PeriodoId)

IF @Cierre=0 OR @PeriodoId=0
	BEGIN
		begin
			begin tran
				begin
				select 
					ROW_NUMBER() OVER(ORDER BY PeriodoId desc, PY.GrupoEgresoId desc, PY.SubGrupoEgresoId desc) as item,
					PY.IdProyectado, 
					PY.GrupoEgresoId,
					GE.Descripcion as GrupoEgresoDescripcion,
					PY.SubGrupoEgresoId,
					SGE.ItemSubGrupoEgreso as SubGrupoEgresoDescripcion,
					PY.PeriodoId,
					P.DescripcionPeriodo as PeriodoDescripcion,
					PY.ImporteProvision
				from Proyectado PY
				inner join GrupoEgreso GE on GE.IdGrupoEgreso = PY.GrupoEgresoId
				inner join SubGrupoEgreso SGE on SGE.IdSubGrupoEgreso = PY.SubGrupoEgresoId
				inner join Periodo P on P.idPeriodo = PY.PeriodoId
				Where ((@IdProyectado = 0) OR (IdProyectado = @IdProyectado))
				and ((@SubGrupoEgresoId = 0) OR (SubGrupoEgresoId = @SubGrupoEgresoId))
				and ((@PeriodoId = 0) OR (PeriodoId = @PeriodoId))
				and (PY.EstadoActivo = 1)
				order by PeriodoId desc, PY.GrupoEgresoId desc, PY.SubGrupoEgresoId desc
				select @ErrorCode = @@ERROR 
				if @ErrorCode <> 0 goto onError
				end
			commit tran
		end
	END
	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END

GO
/****** Object:  StoredProcedure [dbo].[LeerRelacionDebeHaber]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerRelacionDebeHaber]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerRelacionDebeHaber] AS' 
END
GO

ALTER PROCEDURE [dbo].[LeerRelacionDebeHaber]
	(
		@IdRelacionDebeHaber		int,
		@TipoOperacionId			int,
		@EtapaOperacionId			int,
		@GrupoId					int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			begin
				select 
					ROW_NUMBER() OVER(ORDER BY IdRelacionDebeHaber asc) as item,
					IdRelacionDebeHaber,
					TipoOperacionId,
					EtapaOperacionId,
					IIF(R.EtapaOperacionId = 1, 'Registro', 'Pago/Cobro') AS DescripcionEtapaOperacion,
					GrupoId,
					IIF(R.TipoOperacionId = 1, GI.Descripcion, SGE.ItemSubGrupoEgreso) AS DescripcionGrupo,
					GrupoDebeId,
					GrupoHaberId,
					DebeId,
					IIF(R.GrupoDebeId = 1, DGA.Descripcion, IIF(R.GrupoDebeId = 2,DGPS.Descripcion,DGPT.Descripcion)) AS DescripcionDebe,
					HaberId,
					IIF(R.GrupoHaberId = 1, HGA.Descripcion, IIF(R.GrupoHaberId = 2,HGPS.Descripcion,HGPT.Descripcion)) AS DescripcionHaber,
					SignoDebe,
					IIF(R.SignoDebe = 1, '+', '-') AS DescripcionSignoDebe,
					SignoHaber,
					IIF(R.SignoHaber = 1, '+', '-') AS DescripcionSignoHaber
				from RelacionDebeHaber R
				LEFT JOIN GrupoIngreso GI ON (R.TipoOperacionId = 1 AND R.GrupoId = GI.IdGrupoIngreso)
				LEFT JOIN SubGrupoEgreso SGE ON (R.TipoOperacionId = 2 AND R.GrupoId = SGE.IdSubGrupoEgreso)
				LEFT JOIN GrupoActivo DGA ON (R.GrupoDebeId = 1 AND R.DebeId = DGA.IdGrupoActivo)
				LEFT JOIN GrupoPasivo DGPS ON (R.GrupoDebeId = 2 AND R.DebeId = DGPS.IdGrupoPasivo)
				LEFT JOIN GrupoPatrimonio DGPT ON (R.GrupoDebeId = 3 AND R.DebeId = DGPT.IdGrupoPatrimonio)
				LEFT JOIN GrupoActivo HGA ON (R.GrupoHaberId = 1 AND R.HaberId = HGA.IdGrupoActivo)
				LEFT JOIN GrupoPasivo HGPS ON (R.GrupoHaberId = 2 AND R.HaberId = HGPS.IdGrupoPasivo)
				LEFT JOIN GrupoPatrimonio HGPT ON (R.GrupoHaberId = 3 AND R.HaberId = HGPT.IdGrupoPatrimonio)
				Where ((@IdRelacionDebeHaber = 0) OR (IdRelacionDebeHaber = @IdRelacionDebeHaber))					
				and ((@TipoOperacionId = 0) OR (TipoOperacionId = @TipoOperacionId))				
				and ((@EtapaOperacionId = 0) OR (EtapaOperacionId = @EtapaOperacionId))		
				and ((@GrupoId = 0) OR (GrupoId = @GrupoId))
				and R.EstadoActivo = 1

				select @ErrorCode = @@ERROR 
				if @ErrorCode <> 0 goto onError
			end		
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END
GO
/****** Object:  StoredProcedure [dbo].[LeerReporteBalanceGeneral]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerReporteBalanceGeneral]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerReporteBalanceGeneral] AS' 
END
GO
ALTER PROCEDURE [dbo].[LeerReporteBalanceGeneral](
@Periodo int
)
AS
BEGIN

SELECT 
	IIF(@Periodo = 0,'Todos',(SELECT P.DescripcionPeriodo FROM Periodo P WHERE P.IdPeriodo = @Periodo)) as Periodo

SELECT
	GA.Descripcion as GrupoActivo,
	A.Monto as Monto
FROM Activo A
	JOIN Periodo P ON P.idPeriodo = A.PeriodoId
	JOIN GrupoActivo GA ON GA.IdGrupoActivo = A.GrupoActivoId
WHERE A.PeriodoId = @Periodo

SELECT
	GP.Descripcion as GrupoPasivo,
	PA.Monto as Monto
FROM Pasivo PA
	JOIN Periodo P ON P.idPeriodo = PA.PeriodoId
	JOIN GrupoPasivo GP ON GP.IdGrupoPasivo = PA.GrupoPasivoId
WHERE PA.PeriodoId = @Periodo

SELECT
	GP.Descripcion as GrupoPatrimonio,
	PT.Monto as Monto
FROM Patrimonio PT
	JOIN Periodo P ON P.idPeriodo = PT.PeriodoId
	JOIN GrupoPatrimonio GP ON GP.IdGrupoPatrimonio = PT.GrupoPatrimonioId
WHERE PT.PeriodoId = @Periodo


END

GO
/****** Object:  StoredProcedure [dbo].[LeerReporteEgresos]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerReporteEgresos]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerReporteEgresos] AS' 
END
GO

ALTER PROCEDURE [dbo].[LeerReporteEgresos](
@GrupoEgresoId	INT,
@SubGrupoEgresoId INT,
@ProveedorId INT,
@PeriodoInicio INT,
@PeriodoFin INT
)
AS

BEGIN

SELECT 
	IIF(@GrupoEgresoId = 0,'Todos',(SELECT GE.Descripcion FROM GrupoEgreso GE WHERE GE.IdGrupoEgreso = @GrupoEgresoId)) as GrupoEgreso,
	IIF(@SubGrupoEgresoId = 0,'Todos',(SELECT SG.ItemSubGrupoEgreso FROM SubGrupoEgreso SG WHERE SG.IdSubGrupoEgreso = @SubGrupoEgresoId)) as SubGrupoEgreso,
	IIF(@ProveedorId = 0,'Todos',(SELECT PR.NombreComercial FROM Proveedor PR WHERE PR.IdProveedor = @ProveedorId)) as Proveedor,
	IIF(@PeriodoInicio = 0,'Todos',(SELECT PE.DescripcionPeriodo FROM Periodo PE WHERE PE.IdPeriodo = @PeriodoInicio)) as PeriodoInicio,
	IIF(@PeriodoFin = 0,'Todos',(SELECT PE.DescripcionPeriodo FROM Periodo PE WHERE PE.IdPeriodo = @PeriodoFin)) as PeriodoFin

SELECT 
	GE.IdGrupoEgreso as Orden,
	GE.Descripcion  as GrupoEgreso,
	SG.ItemSubGrupoEgreso as SubGrupoEgreso,
	E.ProveedorId as Proveedor,
	P.DescripcionPeriodo as Periodo,
	CONVERT(VARCHAR, SUM(E.ImporteProvision), 1) as Importe
FROM Egreso E
	INNER JOIN SubGrupoEgreso SG ON SG.IdSubGrupoEgreso = E.SubGrupoEgresoId
	INNER JOIN GrupoEgreso GE ON GE.IdGrupoEgreso = SG.GrupoEgresoId
	INNER JOIN Proveedor PR ON PR.IdProveedor = E.ProveedorId
	INNER JOIN Periodo P ON P.IdPeriodo = E.PeriodoId
WHERE E.EstadoActivo = 1 AND E.ImporteProvision > 0 
	AND ((@GrupoEgresoId = 0) OR (GE.IdGrupoEgreso = @GrupoEgresoId))
	AND ((@SubGrupoEgresoId = 0) OR (SG.IdSubGrupoEgreso = @SubGrupoEgresoId))
	AND ((@ProveedorId = 0) OR (PR.IdProveedor = @ProveedorId))
	AND E.PeriodoId >= @PeriodoInicio
	AND E.PeriodoId <= @PeriodoFin
Group by GE.IdGrupoEgreso,GE.Descripcion,SG.ItemSubGrupoEgreso,E.ProveedorId,P.DescripcionPeriodo
UNION
--SubTotal
SELECT
	1000 as Orden,
	'' as GrupoEgreso,
	'SubTotal' as SubGrupoEgreso,
	'' as Proveedor,
	P.DescripcionPeriodo as Periodo, 
	CONVERT(VARCHAR, SUM(E.ImporteProvision), 1) as Importe
FROM Egreso E
	INNER JOIN SubGrupoEgreso SG ON SG.IdSubGrupoEgreso = E.SubGrupoEgresoId
	INNER JOIN GrupoEgreso GE ON GE.IdGrupoEgreso = SG.GrupoEgresoId
	INNER JOIN Proveedor PR ON PR.IdProveedor = E.ProveedorId
	INNER JOIN Periodo P ON P.IdPeriodo = E.PeriodoId
WHERE E.EstadoActivo = 1 AND E.ImporteProvision > 0 
	AND ((@GrupoEgresoId = 0) OR (GE.IdGrupoEgreso = @GrupoEgresoId))
	AND ((@SubGrupoEgresoId = 0) OR (SG.IdSubGrupoEgreso = @SubGrupoEgresoId))
	AND ((@ProveedorId = 0) OR (PR.IdProveedor = @ProveedorId))
	AND E.PeriodoId >= @PeriodoInicio
	AND E.PeriodoId <= @PeriodoFin
Group by P.DescripcionPeriodo
UNION
--IGV
SELECT
	1001 as Orden,
	'' as GrupoEgreso,
	'IGV' as SubGrupoEgreso,
	'' as Proveedor,
	P.DescripcionPeriodo as Periodo, 
	CONVERT(VARCHAR, SUM(E.IgvProvision), 1) as Importe
FROM Egreso E
	INNER JOIN SubGrupoEgreso SG ON SG.IdSubGrupoEgreso = E.SubGrupoEgresoId
	INNER JOIN GrupoEgreso GE ON GE.IdGrupoEgreso = SG.GrupoEgresoId
	INNER JOIN Proveedor PR ON PR.IdProveedor = E.ProveedorId
	INNER JOIN Periodo P ON P.IdPeriodo = E.PeriodoId
WHERE E.EstadoActivo = 1 AND E.ImporteProvision > 0 
	AND ((@GrupoEgresoId = 0) OR (GE.IdGrupoEgreso = @GrupoEgresoId))
	AND ((@SubGrupoEgresoId = 0) OR (SG.IdSubGrupoEgreso = @SubGrupoEgresoId))
	AND ((@ProveedorId = 0) OR (PR.IdProveedor = @ProveedorId))
	AND E.PeriodoId >= @PeriodoInicio
	AND E.PeriodoId <= @PeriodoFin
Group by P.DescripcionPeriodo
UNION
--Total
SELECT
	1004 as Orden,
	'' as GrupoEgreso,
	'Total' as SubGrupoEgreso,
	'' as Proveedor,
	P.DescripcionPeriodo as Periodo,
	CONVERT(VARCHAR, CAST(SUM(E.ImporteProvision+E.IgvProvision) AS MONEY), 1) as Importe
FROM Egreso E
	INNER JOIN SubGrupoEgreso SG ON SG.IdSubGrupoEgreso = E.SubGrupoEgresoId
	INNER JOIN GrupoEgreso GE ON GE.IdGrupoEgreso = SG.GrupoEgresoId
	INNER JOIN Proveedor PR ON PR.IdProveedor = E.ProveedorId
	INNER JOIN Periodo P ON P.IdPeriodo = E.PeriodoId
WHERE E.EstadoActivo = 1 AND E.ImporteProvision > 0 
	AND ((@GrupoEgresoId = 0) OR (GE.IdGrupoEgreso = @GrupoEgresoId))
	AND ((@SubGrupoEgresoId = 0) OR (SG.IdSubGrupoEgreso = @SubGrupoEgresoId))
	AND ((@ProveedorId = 0) OR (PR.IdProveedor = @ProveedorId))
	AND E.PeriodoId >= @PeriodoInicio
	AND E.PeriodoId <= @PeriodoFin
Group by P.DescripcionPeriodo
END

GO
/****** Object:  StoredProcedure [dbo].[LeerReporteEstadoResultados]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerReporteEstadoResultados]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerReporteEstadoResultados] AS' 
END
GO
ALTER PROCEDURE [dbo].[LeerReporteEstadoResultados](
@PeriodoInicio int,
@PeriodoFin int
)
AS


BEGIN
	SELECT 
		(SELECT DescripcionPeriodo FROM Periodo WHERE idPeriodo = @PeriodoInicio) as PeriodoInicio,
		(SELECT DescripcionPeriodo FROM Periodo WHERE idPeriodo = @PeriodoFin) as PeriodoFin

	SELECT 
		ER.Orden,
		ER.Concepto,
		P.DescripcionPeriodo as Periodo,
		ER.Valor	
	FROM EstadoResultado ER
		JOIN Periodo P ON P.idPeriodo = ER.Periodo
	WHERE ER.Periodo >= @PeriodoInicio
		AND ER.Periodo <= @PeriodoFin
END

GO
/****** Object:  StoredProcedure [dbo].[LeerReporteFCProyectado]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerReporteFCProyectado]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerReporteFCProyectado] AS' 
END
GO


ALTER PROCEDURE [dbo].[LeerReporteFCProyectado](
@Periodo INT
)
AS
Declare @Parametro as float
Set @Parametro = (Select ValorParametro from Parametro where idParametro = 3)
BEGIN

SELECT 
	IIF(@Periodo = 0,'Todos',(SELECT PE.DescripcionPeriodo FROM Periodo PE WHERE PE.IdPeriodo = @Periodo)) as Periodo

SELECT 
	GE.IdGrupoEgreso as Orden,
	GE.Descripcion as GrupoEgreso,
	SG.ItemSubGrupoEgreso as SubGrupoEgreso,
	PY.ImporteProvision as Monto
FROM Proyectado PY
	INNER JOIN GrupoEgreso GE ON GE.IdGrupoEgreso = PY.GrupoEgresoId
	INNER JOIN SubGrupoEgreso SG ON SG.IdSubGrupoEgreso = PY.SubGrupoEgresoId
WHERE PY.EstadoActivo = 1
	AND PY.PeriodoId = @Periodo

SELECT
	GA.IdGrupoActivo as Orden,
	GA.Descripcion as GrupoActivo,
	SUM(A.Monto) as Monto
FROM Activo A
	JOIN GrupoActivo GA ON (GA.IdGrupoActivo = A.GrupoActivoId and GA.IdGrupoActivo < 4)
	JOIN Periodo P ON P.idPeriodo = A.PeriodoId
WHERE A.PeriodoId <= @Periodo 
and P.Cierre = 0
Group by GA.IdGrupoActivo, GA.Descripcion

SELECT
	GP.IdGrupoPasivo as Orden,
	GP.Descripcion as GrupoPasivo,
	SUM(PS.Monto) as Monto
FROM Pasivo PS
	JOIN GrupoPasivo GP ON (GP.IdGrupoPasivo = PS.GrupoPasivoId and GP.IdGrupoPasivo = 1)
	JOIN Periodo P ON P.idPeriodo = PS.PeriodoId
WHERE PS.PeriodoId <= @Periodo
and P.Cierre = 0
Group by GP.IdGrupoPasivo, GP.Descripcion

SELECT 
	SUM(PY.ImporteProvision/@Parametro) as VentaProyectada
FROM Proyectado PY
WHERE PY.EstadoActivo = 1
	AND PY.PeriodoId = @Periodo
END

GO
/****** Object:  StoredProcedure [dbo].[LeerReporteIngresos]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerReporteIngresos]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerReporteIngresos] AS' 
END
GO

ALTER PROCEDURE [dbo].[LeerReporteIngresos](
@GrupoIngresoId	INT,
@ClienteId INT,
@PeriodoInicio INT,
@PeriodoFin INT
)
AS
BEGIN

SELECT 
	IIF(@GrupoIngresoId = 0,'Todos',(SELECT GI.Descripcion FROM GrupoIngreso GI WHERE GI.IdGrupoIngreso = @GrupoIngresoId)) as GrupoIngreso,
	IIF(@ClienteId = 0,'Todos',(SELECT C.Descripcion FROM Cliente C WHERE C.IdCliente = @ClienteId)) as Cliente,
	IIF(@PeriodoInicio = 0,'Todos',(SELECT PE.DescripcionPeriodo FROM Periodo PE WHERE PE.IdPeriodo = @PeriodoInicio)) as PeriodoInicio,
	IIF(@PeriodoFin = 0,'Todos',(SELECT PE.DescripcionPeriodo FROM Periodo PE WHERE PE.IdPeriodo = @PeriodoFin)) as PeriodoFin

SELECT 
	CI.IdCliente as Orden,
	CI.Descripcion as Cliente,
	P.DescripcionPeriodo as Periodo, 
	CONVERT(VARCHAR, SUM(I.ImporteProvision), 1) as Importe
FROM Ingreso I
	INNER JOIN GrupoIngreso GI ON GI.IdGrupoIngreso = I.GrupoIngresoId
	INNER JOIN Cliente CI ON CI.IdCliente = I.ClienteId
	INNER JOIN Periodo P ON P.IdPeriodo = I.PeriodoId
WHERE I.EstadoActivo = 1
	AND ((@GrupoIngresoId = 0) OR (GI.IdGrupoIngreso = @GrupoIngresoId))
	AND ((@ClienteId = 0) OR (CI.IdCliente = @ClienteId))
	AND I.PeriodoId >= @PeriodoInicio
	AND I.PeriodoId <= @PeriodoFin
Group by CI.IdCliente,CI.Descripcion,P.DescripcionPeriodo
UNION
--SubTotal
SELECT
	1000 as Orden,
	'SubTotal' as Cliente,
	P.DescripcionPeriodo as Periodo, 
	CONVERT(VARCHAR, SUM(I.ImporteProvision), 1) as Importe
FROM Ingreso I
	INNER JOIN GrupoIngreso GI ON GI.IdGrupoIngreso = I.GrupoIngresoId
	INNER JOIN Cliente CI ON CI.IdCliente = I.ClienteId
	INNER JOIN Periodo P ON P.IdPeriodo = I.PeriodoId
WHERE I.EstadoActivo = 1
	AND ((@GrupoIngresoId = 0) OR (GI.IdGrupoIngreso = @GrupoIngresoId))
	AND ((@ClienteId = 0) OR (CI.IdCliente = @ClienteId))
	AND I.PeriodoId >= @PeriodoInicio
	AND I.PeriodoId <= @PeriodoFin
Group by P.DescripcionPeriodo
UNION
--IGV
SELECT
	1001 as Orden,
	'IGV' as Cliente,
	P.DescripcionPeriodo as Periodo, 
	CONVERT(VARCHAR, SUM(I.IgvProvision), 1) as Importe
FROM Ingreso I
	INNER JOIN GrupoIngreso GI ON GI.IdGrupoIngreso = I.GrupoIngresoId
	INNER JOIN Cliente CI ON CI.IdCliente = I.ClienteId
	INNER JOIN Periodo P ON P.IdPeriodo = I.PeriodoId
WHERE I.EstadoActivo = 1
	AND ((@GrupoIngresoId = 0) OR (GI.IdGrupoIngreso = @GrupoIngresoId))
	AND ((@ClienteId = 0) OR (CI.IdCliente = @ClienteId))
	AND I.PeriodoId >= @PeriodoInicio
	AND I.PeriodoId <= @PeriodoFin
Group by P.DescripcionPeriodo
UNION
--Detraccion
SELECT
	1002 as Orden,
	'Detraccion (Cta BN)' as Cliente,
	P.DescripcionPeriodo as Periodo, 
	CONVERT(VARCHAR, SUM(I.DetraccionProvision), 1) as Importe
FROM Ingreso I
	INNER JOIN GrupoIngreso GI ON GI.IdGrupoIngreso = I.GrupoIngresoId
	INNER JOIN Cliente CI ON CI.IdCliente = I.ClienteId
	INNER JOIN Periodo P ON P.IdPeriodo = I.PeriodoId
WHERE I.EstadoActivo = 1
	AND ((@GrupoIngresoId = 0) OR (GI.IdGrupoIngreso = @GrupoIngresoId))
	AND ((@ClienteId = 0) OR (CI.IdCliente = @ClienteId))
	AND I.PeriodoId >= @PeriodoInicio
	AND I.PeriodoId <= @PeriodoFin
Group by P.DescripcionPeriodo
UNION
--Ingreso a cuenta
SELECT
	1003 as Orden,
	'Ingreso a cuenta' as Cliente,
	P.DescripcionPeriodo as Periodo, 
	CONVERT(VARCHAR, CAST(SUM(I.ImporteProvision+I.IgvProvision-I.DetraccionProvision) AS MONEY), 1) as Importe
FROM Ingreso I
	INNER JOIN GrupoIngreso GI ON GI.IdGrupoIngreso = I.GrupoIngresoId
	INNER JOIN Cliente CI ON CI.IdCliente = I.ClienteId
	INNER JOIN Periodo P ON P.IdPeriodo = I.PeriodoId
WHERE I.EstadoActivo = 1
	AND ((@GrupoIngresoId = 0) OR (GI.IdGrupoIngreso = @GrupoIngresoId))
	AND ((@ClienteId = 0) OR (CI.IdCliente = @ClienteId))
	AND I.PeriodoId >= @PeriodoInicio
	AND I.PeriodoId <= @PeriodoFin
Group by P.DescripcionPeriodo
UNION
--Total
SELECT
	1004 as Orden,
	'Total' as Cliente,
	P.DescripcionPeriodo as Periodo,
	CONVERT(VARCHAR, CAST(SUM(I.ImporteProvision+I.IgvProvision) AS MONEY), 1) as Importe
FROM Ingreso I
	INNER JOIN GrupoIngreso GI ON GI.IdGrupoIngreso = I.GrupoIngresoId
	INNER JOIN Cliente CI ON CI.IdCliente = I.ClienteId
	INNER JOIN Periodo P ON P.IdPeriodo = I.PeriodoId
WHERE I.EstadoActivo = 1
	AND ((@GrupoIngresoId = 0) OR (GI.IdGrupoIngreso = @GrupoIngresoId))
	AND ((@ClienteId = 0) OR (CI.IdCliente = @ClienteId))
	AND I.PeriodoId >= @PeriodoInicio
	AND I.PeriodoId <= @PeriodoFin
Group by P.DescripcionPeriodo
END
GO
/****** Object:  StoredProcedure [dbo].[LeerReporteRatios]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerReporteRatios]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerReporteRatios] AS' 
END
GO
ALTER PROCEDURE [dbo].[LeerReporteRatios](
@PeriodoInicio INT,
@PeriodoFin INT
)
AS
BEGIN

SELECT 
	IIF(@PeriodoInicio = 0,'Todos',(SELECT PE.DescripcionPeriodo FROM Periodo PE WHERE PE.IdPeriodo = @PeriodoInicio)) as PeriodoInicio,
	IIF(@PeriodoFin = 0,'Todos',(SELECT PE.DescripcionPeriodo FROM Periodo PE WHERE PE.IdPeriodo = @PeriodoFin)) as PeriodoFin

SELECT
	TR.IdTipoRatio as IdTipoRatio, 
	TR.Descripcion as TipoRatio,
	R.Valor as Valor,
	P.DescripcionPeriodo as Periodo
FROM Ratio R
	INNER JOIN TipoRatio TR ON TR.IdTipoRatio = R.TipoRatioId
	INNER JOIN Periodo P ON P.IdPeriodo = R.PeriodoId
WHERE R.EstadoActivo = 1
	AND R.PeriodoId >= @PeriodoInicio
	AND R.PeriodoId <= @PeriodoFin
ORDER BY TipoRatioId DESC

END

GO
/****** Object:  StoredProcedure [dbo].[LeerSubGrupoEgreso]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerSubGrupoEgreso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerSubGrupoEgreso] AS' 
END
GO

ALTER PROCEDURE [dbo].[LeerSubGrupoEgreso](
	@IdSubGrupoEgreso				int,
	@FiltroCombo					int,
	@TablaMaestra					bit = 0
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin					
					select ROW_NUMBER() OVER(ORDER BY IdSubGrupoEgreso asc) as item,
					IdSubGrupoEgreso, GrupoEgresoId, ItemSubGrupoEgreso, 
					EstadoActivo AS IdEstadoActivo,
					IIF(EstadoActivo = 1, 'Activo', 'Inactivo') AS EstadoActivo 
					from SubGrupoEgreso
					Where ((@IdSubGrupoEgreso = 0) OR (IdSubGrupoEgreso = @IdSubGrupoEgreso))
					AND ((@FiltroCombo = 0) OR (GrupoEgresoId = @FiltroCombo))
					AND ((@TablaMaestra = 1) OR (@TablaMaestra = 0 and EstadoActivo = 1))
					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
				end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END

GO
/****** Object:  StoredProcedure [dbo].[LeerTipoCliente]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerTipoCliente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerTipoCliente] AS' 
END
GO
ALTER PROCEDURE [dbo].[LeerTipoCliente](
	@IdTipoCliente				int,
	@TablaMaestra				bit = 0 
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
					
					select ROW_NUMBER() OVER(ORDER BY IdTipoCliente) AS Item,
					IdTipoCliente, 
					Descripcion, 
					EstadoActivo as IdEstadoActivo,
					IIF(EstadoActivo = 1, 'Activo', 'Inactivo') AS EstadoActivo
					from TipoCliente
					Where ((@IdTipoCliente = 0) OR (IdTipoCliente = @IdTipoCliente))
					AND ((@TablaMaestra = 1) OR (@TablaMaestra = 0 and EstadoActivo = 1))
					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
				end
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END


GO
/****** Object:  StoredProcedure [dbo].[LeerTipoRatio]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerTipoRatio]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerTipoRatio] AS' 
END
GO
ALTER PROCEDURE [dbo].[LeerTipoRatio](
	@IdTipoRatio				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			select
				IdTipoRatio,
				Descripcion
			from TipoRatio 			
			Where ((@IdTipoRatio = 0) OR (IdTipoRatio = @IdTipoRatio))
			and EstadoActivo = 1
			select @ErrorCode = @@ERROR 
			if @ErrorCode <> 0 goto onError
		commit tran
	end

	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end
	
END
GO
/****** Object:  StoredProcedure [dbo].[LeerUsuario]    Script Date: 10/01/2021 16:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LeerUsuario]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[LeerUsuario] AS' 
END
GO

ALTER PROCEDURE [dbo].[LeerUsuario]
	(
		@IdUsuario					int,
		@NombreUsuario				varchar(200),
		@TablaMaestra				bit = 0
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;
	begin
		begin tran
			begin
				select 
					ROW_NUMBER() OVER(ORDER BY IdUsuario asc) as item,
					IdUsuario,
					NombreCompleto,
					NombreUsuario,
					Contraseña,
					EstadoActivo as EstadoId,
					IIF(EstadoActivo = 1, 'Activo', 'Inactivo') AS EstadoActivo
				from Usuario 
				Where ((@IdUsuario = 0) OR (IdUsuario = @IdUsuario))
				and ((@NombreUsuario = '') OR (NombreUsuario = @NombreUsuario))
				AND ((@TablaMaestra = 1) OR (@TablaMaestra = 0 and EstadoActivo = 1))
				select @ErrorCode = @@ERROR 
				if @ErrorCode <> 0 goto onError
			end			
		commit tran
	end
	onError:
	if @ErrorCode <> 0
	begin
		print 'Error ' + @ErrorCode + '. No se pudo completar la operación'
		rollback tran 
	end	
END

GO
USE [master]
GO
ALTER DATABASE [BDFinanciero] SET  READ_WRITE 
GO

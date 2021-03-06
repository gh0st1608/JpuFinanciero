﻿Imports ERP_Entidad
Imports ERP_Datos

Public Class NegPatrimonio
    Dim ObjPatrimonioEnt As New EntPatrimonio
    Dim ObjPatrimonioDat As New DatPatrimonio

    Public Function ObtenerTabla(ByVal IdPatrimonio As Integer, ByVal PeriodoId As Integer, ByVal GrupoId As Integer, TablaMaestra As Boolean) As DataTable
        Return ObjPatrimonioDat.LeerPatrimonio(IdPatrimonio, PeriodoId, GrupoId, TablaMaestra)
    End Function

    Public Function ObtenerData(ByVal Id As Integer, ByVal PeriodoId As Integer, ByVal GrupoId As Integer) As EntPatrimonio
        Dim Dt As DataTable
        Dt = ObjPatrimonioDat.LeerPatrimonio(Id, PeriodoId, GrupoId, True)
        If (Dt.Rows.Count() > 0) Then
            ObjPatrimonioEnt.IdPatrimonio = Convert.ToInt32(Dt.Rows(0).Item("IdPatrimonio"))
            ObjPatrimonioEnt.GrupoPatrimonioId = Convert.ToInt32(Dt.Rows(0).Item("GrupoPatrimonioId"))
            ObjPatrimonioEnt.PeriodoId = Convert.ToInt32(Dt.Rows(0).Item("PeriodoId"))
            ObjPatrimonioEnt.Monto = Convert.ToInt32(Dt.Rows(0).Item("Monto"))
        End If
        Return ObjPatrimonioEnt
    End Function

    Public Function Eliminar(ByVal varPatrimonioEnt As EntPatrimonio) As Boolean
        Return ObjPatrimonioDat.EliminarPatrimonio(varPatrimonioEnt)
    End Function

    Public Function Guardar(ByVal varPatrimonioEnt As EntPatrimonio) As Boolean
        Return ObjPatrimonioDat.CrearPatrimonio(varPatrimonioEnt)
    End Function

    Public Function Actualizar(ByVal varPatrimonioEnt As EntPatrimonio) As Boolean
        Return ObjPatrimonioDat.ActualizarPatrimonio(varPatrimonioEnt)
    End Function
End Class

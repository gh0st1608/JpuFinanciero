CREATE PROCEDURE LeerReporteEstadoResultados(
@PeriodoInicio DATE,
@PeriodoFin DATE
)
AS


BEGIN
	Declare @FechaInicio Date
	Declare @FechaFin Date
	
	Set @FechaInicio = (Select FechaInicio from Periodo where idPeriodo = @PeriodoInicio)
	Set @FechaFin = (Select FechaFin from Periodo where idPeriodo = @PeriodoFin)
SELECT 
	(SELECT DescripcionPeriodo FROM Periodo WHERE idPeriodo = @PeriodoInicio) as PeriodoInicio,
	(SELECT DescripcionPeriodo FROM Periodo WHERE idPeriodo = @PeriodoFin) as PeriodoFin

SELECT 
	P.DescripcionPeriodo as Periodo,
	Sum(I.ImporteProvision) as Venta,
	Sum(EGA.ImporteProvision) as GastoAdministrativo,
	Sum(EGV.ImporteProvision) as GastoVenta,
	Sum(EGF.ImporteProvision) as GastoFinanciero,
	Sum(EGM.ImporteProvision) as GastoMenor,
	Sum(EC1.ImporteProvision) as Costo1,
	Sum(EC2.ImporteProvision) as Costo2,
	Sum(EC3.ImporteProvision) as Costo3,
	Sum(EC1.ImporteProvision) + Sum(EC2.ImporteProvision) as Suma
	 
	
FROM Periodo P
	Full outer JOIN Ingreso I ON P.idPeriodo = I.PeriodoId
	Full outer JOIN Egreso EGA ON (P.idPeriodo = EGA.PeriodoId and EGA.GrupoEgresoId = 1)
	Full outer JOIN Egreso EGV ON (P.idPeriodo = EGV.PeriodoId and EGV.GrupoEgresoId = 2)
	Full outer JOIN Egreso EGF ON (P.idPeriodo = EGF.PeriodoId and EGF.GrupoEgresoId = 3)
	Full outer JOIN Egreso EGM ON (P.idPeriodo = EGM.PeriodoId and EGM.GrupoEgresoId = 4)
	Full outer JOIN Egreso EC1 ON (P.idPeriodo = EC1.PeriodoId and EC1.GrupoEgresoId = 5)
	Full outer JOIN Egreso EC2 ON (P.idPeriodo = EC2.PeriodoId and EC2.GrupoEgresoId = 6)
	Full outer JOIN Egreso EC3 ON (P.idPeriodo = EC3.PeriodoId and EC3.GrupoEgresoId = 7)

WHERE I.EstadoActivo = 1	
	--AND I.FechaCreacion >= @FechaInicio
	--AND I.FechaCreacion <= @FechaFin
Group by P.DescripcionPeriodo
END
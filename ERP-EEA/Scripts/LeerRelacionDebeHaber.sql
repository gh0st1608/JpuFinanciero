CREATE PROCEDURE [dbo].[LeerRelacionDebeHaber]
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
					IIF(R.TipoOperacionId = 1, GI.Descripcion, GE.Descripcion) AS DescripcionGrupo,
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
				LEFT JOIN GrupoEgreso GE ON (R.TipoOperacionId = 2 AND R.GrupoId = GE.IdGrupoEgreso)
				LEFT JOIN GrupoActivo DGA ON (R.GrupoDebeId = 1 AND R.DebeId = DGA.IdGrupoActivo)
				LEFT JOIN GrupoPasivo DGPS ON (R.GrupoDebeId = 2 AND R.DebeId = DGPS.IdGrupoPasivo)
				LEFT JOIN GrupoPatrimonio DGPT ON (R.GrupoDebeId = 3 AND R.DebeId = DGPT.IdGrupoPatrimonio)
				LEFT JOIN GrupoActivo HGA ON (R.GrupoHaberId = 1 AND R.HaberId = HGA.IdGrupoActivo)
				LEFT JOIN GrupoPasivo HGPS ON (R.GrupoHaberId = 2 AND R.HaberId = HGPS.IdGrupoPasivo)
				LEFT JOIN GrupoPatrimonio HGPT ON (R.GrupoHaberId = 3 AND R.HaberId = HGPT.IdGrupoPatrimonio)
				Where ((@IdRelacionDebeHaber = 0) OR (IdRelacionDebeHaber = @IdRelacionDebeHaber))					
				and ((@EtapaOperacionId = 0) OR (EtapaOperacionId = @EtapaOperacionId))

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
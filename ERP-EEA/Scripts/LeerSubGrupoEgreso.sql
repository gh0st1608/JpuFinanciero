USE [BDFinanciero]
GO
/****** Object:  StoredProcedure [dbo].[LeerSubGrupoEgreso]    Script Date: 02/10/2020 5:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[LeerSubGrupoEgreso](
	@IdSubGrupoEgreso				int
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
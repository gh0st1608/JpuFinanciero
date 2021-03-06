USE [BDFinanciero]
GO
/****** Object:  StoredProcedure [dbo].[LeerGrupoEgreso]    Script Date: 02/10/2020 9:35:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[LeerGrupoEgreso](
	@IdGrupoEgreso				int
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
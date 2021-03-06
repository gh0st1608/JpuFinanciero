USE [BDFinanciero]
GO
/****** Object:  StoredProcedure [dbo].[LeerGrupoIngreso]    Script Date: 02/10/2020 9:42:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[LeerGrupoIngreso](
	@IdGrupoIngreso				int,
	@Descripcion				varchar(50)
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
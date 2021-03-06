USE [BDFinanciero]
GO
/****** Object:  StoredProcedure [dbo].[LeerParametro]    Script Date: 02/10/2020 14:14:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[LeerParametro](
	@IdParametro				int,
	@Descripcion				varchar(50),
	@TipoParametro				varchar(50)
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



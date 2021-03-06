CREATE PROCEDURE [dbo].[LeerIngreso](
	@IdIngreso				int,
	@PeriodoId				int,
	@ClienteId				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			begin
			select 
				ROW_NUMBER() OVER(ORDER BY IdIngreso asc) as item,
				IdIngreso, 
				GrupoIngresoId,
				ClienteId,
				C.Descripcion,
				Detraccion,
				ImporteProvision,
				PeriodoId,
				Comentario,
				FechaIngresoProvision,
				Deuda
			from Ingreso I
			inner join Cliente C on I.ClienteId = C.IdCliente 
			Where ((@IdIngreso = 0) OR (IdIngreso = @IdIngreso))
			and ((@PeriodoId = 0) OR (PeriodoId = @PeriodoId))
			and ((@ClienteId = 0) OR (ClienteId = @ClienteId))

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
CREATE PROCEDURE [dbo].[LeerMetodoPago](
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
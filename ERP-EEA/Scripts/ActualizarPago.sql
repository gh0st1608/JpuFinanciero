CREATE PROCEDURE [dbo].[ActualizarPago](
	@IdPago					int,
	@TipoOrigenId			int,
	@OrigenId				int,
	@ImporteCancelado		money,
	@ImporteTotal			money,
	@MetodoPagoId			int,
	@FechaPago				date,
	@ComprobanteUbicacion	varchar(200),
	@NumeroComprobante		varchar(20),
	@EstadoActivo			int,
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
				ImporteTotal = @ImporteTotal,
				MetodoPagoId = @MetodoPagoId,
				FechaPago = @FechaPago,
				ComprobanteUbicacion = @ComprobanteUbicacion,
				NumeroComprobante = @NumeroComprobante,
				UsuarioModificacionId = @UsuarioModificacionId,
				FechaModificacion = GETDATE(),
				EstadoActivo = @EstadoActivo
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

CREATE PROCEDURE [dbo].[CrearPago](
	@TipoOrigenId			int,
	@OrigenId				int,
	@ImporteCancelado		money,
	@ImporteTotal			money,
	@MetodoPagoId			int,
	@ComprobanteUbicacion	varchar(200),
	@NumeroComprobante		varchar(20),
	@FechaPago				date,
	@UsuarioCreacionId		int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			begin
				insert into Pago
				(
				TipoOrigenId,
				OrigenId,
				ImporteCancelado,
				ImporteTotal,
				MetodoPagoId,
				FechaPago,
				ComprobanteUbicacion,
				NumeroComprobante,
				UsuarioCreacionId,
				FechaCreacion,
				EstadoActivo
				)
				values (
				@TipoOrigenId,
				@OrigenId,
				@ImporteCancelado,
				@ImporteTotal,
				@MetodoPagoId,
				@FechaPago,
				@ComprobanteUbicacion,
				@NumeroComprobante,
				@UsuarioCreacionId,
				GETDATE(),
				1
				)
			
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
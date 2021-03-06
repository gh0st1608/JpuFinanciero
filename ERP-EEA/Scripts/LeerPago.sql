CREATE PROCEDURE [dbo].[LeerPago]
	(
		@IdPago				int,
		@OrigenId			int,
		@TipoOrigen			int,
		@PeriodoId			int,
		@ClienteId			int = 0,
		@ProveedorId		int = 0
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			if @TipoOrigen = 1
				begin
					select 
						ROW_NUMBER() OVER(ORDER BY IdPago asc) as item,
						IdPago,
						OrigenId,
						ImporteCancelado,
						MetodoPagoId,
						FechaPago,
						ComprobanteUbicacion,
						NumeroComprobante,
						ImporteTotal
					from Pago P
					inner join Ingreso I ON P.OrigenId = I.IdIngreso
					Where ((@IdPago = 0) OR (IdPago = @IdPago))
					and ((@OrigenId = 0) OR (IdIngreso = @OrigenId))
					and ((@PeriodoId = 0) OR (I.PeriodoId = @PeriodoId))
					and ((@ClienteId = 0) OR (I.ClienteId = @ClienteId))

					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
				end
			if @TipoOrigen = 2
				begin
					select 
						ROW_NUMBER() OVER(ORDER BY IdPago asc) as item,
						IdPago,
						OrigenId,
						ImporteCancelado,
						MetodoPagoId,
						FechaPago,
						ComprobanteUbicacion,
						NumeroComprobante,
						ImporteTotal
					from Pago P
					inner join Egreso E ON P.OrigenId = E.IdEgreso
					Where ((@IdPago = 0) OR (IdPago = @IdPago))
					and ((@OrigenId = 0) OR (IdEgreso = @OrigenId))
					and ((@PeriodoId = 0) OR (E.PeriodoId = @PeriodoId))
					and ((@ClienteId = 0) OR (E.ProveedorId = @ClienteId))

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
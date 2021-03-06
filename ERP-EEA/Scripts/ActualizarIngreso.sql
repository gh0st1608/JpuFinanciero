CREATE PROCEDURE [dbo].[ActualizarIngreso](
	@IdIngreso				int,
	@GrupoIngresoId			int,
	@ClienteId				int,
	@Detraccion				bit,
	@ImporteProvision		money,
	@PeriodoId				int,
	@Comentario				varchar(200),
	@FechaIngresoProvision	date,
	@Deuda					money,
	@EstadoActivo			int,
	@UsuarioModificacionId	int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			update Ingreso
			set 
				GrupoIngresoId = @GrupoIngresoId,
				ClienteId = @ClienteId,
				Detraccion = @Detraccion,
				ImporteProvision = @ImporteProvision,
				PeriodoId = @PeriodoId,
				Comentario = @Comentario,
				FechaIngresoProvision = @FechaIngresoProvision,
				Deuda = @Deuda,
				UsuarioModificacionId = @UsuarioModificacionId,
				FechaModificacion = GETDATE(),
				EstadoActivo = @EstadoActivo
			where IdIngreso = @IdIngreso

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
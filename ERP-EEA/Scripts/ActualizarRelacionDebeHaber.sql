CREATE PROCEDURE [dbo].[ActualizarRelacionDebeHaber](
	@IdRelacionDebeHaber		int,
	@TipoOperacionId			int,
	@EtapaOperacionId			int,
	@GrupoId					int,
	@GrupoDebeId				int,
	@GrupoHaberId				int,
	@DebeId						int,
	@HaberId					int,
	@SignoDebe					int,
	@SignoHaber					int,
	@UsuarioModificacionId		int,
	@IdEstadoActivo				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
					update RelacionDebeHaber
					set 
						TipoOperacionId = @TipoOperacionId,
						EtapaOperacionId = @EtapaOperacionId,
						GrupoId = @GrupoId,
						GrupoDebeId = @GrupoDebeId,
						GrupoHaberId = @GrupoHaberId,
						DebeId = @DebeId,
						HaberId = @HaberId,
						SignoDebe = @SignoDebe,
						SignoHaber = @SignoHaber,
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = @IdEstadoActivo
					where IdRelacionDebeHaber = @IdRelacionDebeHaber

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

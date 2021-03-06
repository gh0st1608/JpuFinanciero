ALTER PROCEDURE [dbo].[ActualizarSubGrupoEgreso]
	(
	@IdSubGrupoEgreso				int,
	@GrupoEgresoId					int,
	@ItemSubGrupoEgreso				varchar(50),
	@EstadoActivo					int,
	@UsuarioModificacionId			int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			if exists(select IdSubGrupoEgreso from SubGrupoEgreso where ItemSubGrupoEgreso=@ItemSubGrupoEgreso and IdSubGrupoEgreso != @IdSubGrupoEgreso)
			  begin
				   RAISERROR ('Ya se encuentra un area registrada con éste Nombre', 11, 1)
			  end
			else
			  begin
				update SubGrupoEgreso
				set 
					ItemSubGrupoEgreso = @ItemSubGrupoEgreso,
					GrupoEgresoId = @GrupoEgresoId,
					UsuarioModificacionId = @UsuarioModificacionId,
					FechaModificacion = GETDATE(),
					EstadoActivo = @EstadoActivo
				where IdSubGrupoEgreso = @IdSubGrupoEgreso

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
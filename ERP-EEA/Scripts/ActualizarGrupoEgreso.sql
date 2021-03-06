CREATE PROCEDURE [dbo].[ActualizarGrupoEgreso]
	(
	@IdGrupoEgreso				int,
	@Descripcion				varchar(50),
	@Estado						int,
	@UsuarioId					int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			if exists(select IdGrupoEgreso from GrupoEgreso where Descripcion=@Descripcion and IdGrupoEgreso != @IdGrupoEgreso)
			  begin
				   RAISERROR ('Ya se encuentra un area registrada con éste Nombre', 11, 1)
			  end
			else
			  begin
				update GrupoEgreso
				set 
					Descripcion = @Descripcion,
					UsuarioModificacionId = @UsuarioId,
					FechaModificacion = GETDATE(),
					EstadoActivo = @Estado
				where IdGrupoEgreso = @IdGrupoEgreso

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
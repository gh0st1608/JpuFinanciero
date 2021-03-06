CREATE PROCEDURE [dbo].[ActualizarContacto](
	@IdContacto					INT,
	@TipoContactoId				int,
	@Cargo						varchar(100),
	@NombreCompleto				varchar(200),
	@OrigenId					int,
	@Correo						varchar(100),
	@Celular					varchar(50),
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
					update Contacto
					set 
						TipoContactoId = @TipoContactoId,
						Cargo = @Cargo,
						NombreCompleto = @NombreCompleto,
						OrigenId = @OrigenId,
						Correo = @Correo,
						Celular = @Celular,
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = @IdEstadoActivo
					where IdContacto = @IdContacto

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

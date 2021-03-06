CREATE PROCEDURE [dbo].[ActualizarUsuario](
	@IdUsuario					int,
	@NombreCompleto				varchar(200),
	@NombreUsuario				varchar(50),
	@Contraseña					varchar(50),
	@EstadoActivo				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
					
					update Usuario
					set 
						NombreCompleto = @NombreCompleto,
						NombreUsuario = @NombreUsuario,
						Contraseña = @Contraseña,
						FechaModificacion = GETDATE(),
						EstadoActivo = @EstadoActivo
					where IdUsuario = @IdUsuario

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

CREATE PROCEDURE [dbo].[EliminarContacto](
	@IdContacto						int,
	@UsuarioModificacionId				int
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
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = 0
					where IdContacto = @IdContacto
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
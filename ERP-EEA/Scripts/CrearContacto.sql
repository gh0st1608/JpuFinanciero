CREATE PROCEDURE [dbo].[CrearContacto](
	@TipoContactoId				int,
	@Cargo						varchar(100),
	@NombreCompleto				varchar(200),
	@OrigenId					int,
	@Correo						varchar(100),
	@Celular					varchar(50),
	@UsuarioCreacionId			int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
				  
				  insert into Contacto(TipoContactoId,Cargo,NombreCompleto,OrigenId,Correo,Celular,UsuarioCreacionId,FechaCreacion,EstadoActivo)
				  values (@TipoContactoId,@Cargo,@NombreCompleto,@OrigenId,@Correo,@Celular,@UsuarioCreacionId,GETDATE(),1)
			
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

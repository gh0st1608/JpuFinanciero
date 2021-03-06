CREATE PROCEDURE [dbo].[CrearUsuario](
	@NombreCompleto				varchar(200),
	@NombreUsuario				varchar(50),
	@Contraseña					varchar(50)
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			if exists(select IdUsuario from Usuario where NombreUsuario=@NombreUsuario)
			  begin
				  RAISERROR ('Ya se encuentra registrado un usuario con es ID', 11, 1)
			  end
			else
			  begin
				  
				  insert into Usuario(NombreCompleto,NombreUsuario,Contraseña,FechaCreacion,EstadoActivo)
				  values (@NombreCompleto,@NombreUsuario,@Contraseña,GETDATE(),1)
			
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

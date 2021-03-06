CREATE PROCEDURE [dbo].[CrearGrupoEgreso](
	@Descripcion				varchar(50),
	@UsuarioCreacionId					int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran

			-- if exists(select idGrupoEgreso from GrupoEgreso where Descripcion=@Descripcion)
			 --  begin
			--	  RAISERROR ('Ya se encuentra un GrupoEgreso registrado con éste Nombre', 11, 1)
			 --  end
			--else
			  begin
				  
				  insert into GrupoEgreso(Descripcion,UsuarioCreacionId,FechaCreacion,EstadoActivo)
				  values (@Descripcion,@UsuarioCreacionId,GETDATE(),1)
			
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
CREATE PROCEDURE [dbo].[CrearSubGrupoEgreso](
	@ItemSubGrupoEgreso				varchar(50),
	@GrupoEgresoId					int,
	@UsuarioCreacionId				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran

			-- if exists(select idSubGrupoEgreso from SubGrupoEgreso where Descripcion=@Descripcion)
			 --  begin
			--	  RAISERROR ('Ya se encuentra un SubGrupoEgreso registrado con éste Nombre', 11, 1)
			 --  end
			--else
			  begin
				  
				  insert into SubGrupoEgreso(ItemSubGrupoEgreso,GrupoEgresoId, UsuarioCreacionId,FechaCreacion,EstadoActivo)
				  values (@ItemSubGrupoEgreso,@GrupoEgresoId,@UsuarioCreacionId,GETDATE(),1)
			
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
CREATE PROCEDURE [dbo].[CrearRelacionDebeHaber](
	@TipoOperacionId			int,
	@EtapaOperacionId			int,
	@GrupoId					int,
	@GrupoDebeId				int,
	@GrupoHaberId				int,
	@DebeId						int,
	@HaberId					int,
	@SignoDebe					int,
	@SignoHaber					int,
	@UsuarioCreacionId			int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
				  
				  insert into RelacionDebeHaber(				  
				  TipoOperacionId,
				  EtapaOperacionId,
				  GrupoId,
				  GrupoDebeId,
				  GrupoHaberId,
				  DebeId,
				  HaberId,
				  SignoDebe,
				  SignoHaber,
				  UsuarioCreacionId,
				  FechaCreacion,
				  EstadoActivo)
				  values (
				  @TipoOperacionId,
				  @EtapaOperacionId,
				  @GrupoId,
				  @GrupoDebeId,
				  @GrupoHaberId,
				  @DebeId,
				  @HaberId,
				  @SignoDebe,
				  @SignoHaber,
				  @UsuarioCreacionId,
				  GETDATE(),
				  1)
			
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

CREATE PROCEDURE [dbo].[CrearIngreso](
	@GrupoIngresoId			int,
	@ClienteId				int,
	@Detraccion				bit,
	@ImporteProvision		money,
	@PeriodoId				int,
	@Comentario				varchar(200),
	@FechaIngresoProvision	date,
	@UsuarioCreacionId		int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran

			if exists(select idIngreso from Ingreso where ClienteId=@ClienteId and PeriodoId=@PeriodoId and GrupoIngresoId=@GrupoIngresoId)
			  begin
				  RAISERROR ('Ya se encuentra registrado el ingreso para ese cliente, en ese periodo y en el mismo grupo ingreso', 11, 1)
			  end
			else
			  begin
				  
				  insert into Ingreso
				  (
				  GrupoIngresoId,
				  ClienteId,
				  Detraccion,
				  ImporteProvision,
				  PeriodoId,
				  Comentario,
				  FechaIngresoProvision,
				  Deuda,
				  UsuarioCreacionId,
				  FechaCreacion,
				  EstadoActivo
				  )
				  values (
				  @GrupoIngresoId,
				  @ClienteId,
				  @Detraccion,
				  @ImporteProvision,
				  @PeriodoId,
				  @Comentario,
				  @FechaIngresoProvision,
				  @ImporteProvision,
				  @UsuarioCreacionId,
				  GETDATE(),
				  1
				  )
			
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
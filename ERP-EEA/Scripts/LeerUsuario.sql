CREATE PROCEDURE [dbo].[LeerUsuario]
	(
		@IdUsuario					int,
		@NombreUsuario				varchar(200)
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			begin
				select 
					ROW_NUMBER() OVER(ORDER BY IdUsuario asc) as item,
					IdUsuario,
					NombreCompleto,
					NombreUsuario,
					Contraseña,
					EstadoActivo as EstadoId,
					IIF(EstadoActivo = 1, 'Activo', 'Inactivo') AS EstadoActivo
				from Usuario 
				Where ((@IdUsuario = 0) OR (IdUsuario = @IdUsuario))
				and ((@NombreUsuario = '') OR (NombreUsuario = @NombreUsuario))

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
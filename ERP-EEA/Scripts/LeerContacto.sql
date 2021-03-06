CREATE PROCEDURE [dbo].[LeerContacto]
	(
		@IdContacto				int,
		@OrigenId				int,
		@TipoContactoId			int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			if @TipoContactoId = 1
				begin
					select 
						ROW_NUMBER() OVER(ORDER BY IdContacto asc) as item,
						IdContacto,
						OrigenId,
						NombreCompleto,
						Cargo,
						C.Correo,
						Celular,
						IIF(C.EstadoActivo = 1, 'Activo', 'Inactivo') AS EstadoActivo
					from Contacto C
					inner join Cliente Cl ON C.OrigenId = Cl.IdCliente
					Where ((@IdContacto = 0) OR (IdContacto = @IdContacto))
					and ((@OrigenId = 0) OR (OrigenId = @OrigenId))

					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
				end
			if @TipoContactoId = 2
				begin
					select 
						ROW_NUMBER() OVER(ORDER BY IdContacto asc) as item,
						IdContacto,
						OrigenId,
						NombreCompleto,
						Cargo,
						C.Correo,
						Celular,
						IIF(C.EstadoActivo = 1, 'Activo', 'Inactivo') AS EstadoActivo
					from Contacto C
					inner join Proveedor P ON C.OrigenId = P.IdProveedor
					Where ((@IdContacto = 0) OR (IdContacto = @IdContacto))
					and ((@OrigenId = 0) OR (OrigenId = @OrigenId))

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
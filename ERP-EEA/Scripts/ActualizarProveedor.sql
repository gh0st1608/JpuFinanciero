USE [BDFinanciero]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarProveedor]    Script Date: 02/10/2020 14:25:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ActualizarProveedor](
	@IdProveedor				int,
	@Documento					varchar(25),
	@NombreComercial			varchar(50),
	@RazonSocial				varchar(25),
	@Correo						varchar(25),
	@NumeroContacto			    varchar(15),
	@MedicionId					int,
	@Tarifa						float,
	@UsuarioModificacionId		int,
	@EstadoActivo				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
					update Proveedor
					set 
						Documento = @Documento,
						NombreComercial = @NombreComercial,
						RazonSocial = @RazonSocial,
						Correo = @Correo,
						NumeroContacto = @NumeroContacto,
						MedicionId = @MedicionId,
						Tarifa = @Tarifa,
						UsuarioModificacionId = @UsuarioModificacionId,
						FechaModificacion = GETDATE(),
						EstadoActivo = @EstadoActivo
					where IdProveedor = @IdProveedor

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

USE [BDFinanciero]
GO
/****** Object:  StoredProcedure [dbo].[LeerProveedor]    Script Date: 02/10/2020 14:26:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[LeerProveedor](
	@IdProveedor				int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			  begin
					
					select ROW_NUMBER() OVER(ORDER BY IdProveedor) AS Item,
					PR.IdProveedor,
					PR.Documento,
					PR.NombreComercial,
					PR.RazonSocial,
					PR.NumeroContacto,
					PR.Correo,
					PR.MedicionId,
					PA.Descripcion as TipoMedicion,
					PR.Tarifa,
					PR.EstadoActivo AS IdEstadoActivo,
					IIF(PR.EstadoActivo = 1, 'Activo', 'Inactivo') AS EstadoActivo
					from Proveedor PR
					inner join Parametro PA on PA.idParametro = PR.MedicionId
					Where ((@IdProveedor = 0) OR (PR.IdProveedor = @IdProveedor))

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

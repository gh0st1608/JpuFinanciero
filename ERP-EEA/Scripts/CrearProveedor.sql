USE [BDFinanciero]
GO
/****** Object:  StoredProcedure [dbo].[CrearProveedor]    Script Date: 02/10/2020 14:25:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[CrearProveedor](
	@Documento					varchar(25),
	@NombreComercial			varchar(50),
	@RazonSocial				varchar(25),
	@Correo						varchar(25),
	@NumeroContacto			    varchar(15),
	@MedicionId					int,
	@Tarifa						float,
	@UsuarioCreacionId			int
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			-- if exists(select idGrupoIngreso from GrupoIngreso where Descripcion=@Descripcion)
			 --  begin
			--	  RAISERROR ('Ya se encuentra un GrupoIngreso registrado con éste Nombre', 11, 1)
			 --  end
			--else
			  begin
				  
				  insert into Proveedor(Documento, NombreComercial,RazonSocial,Correo,NumeroContacto,MedicionId,Tarifa,UsuarioCreacionId,FechaCreacion,EstadoActivo)
				  values (@Documento, @NombreComercial,@RazonSocial,@Correo,@NumeroContacto,@MedicionId,@Tarifa,@UsuarioCreacionId,GETDATE(),1)
			
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

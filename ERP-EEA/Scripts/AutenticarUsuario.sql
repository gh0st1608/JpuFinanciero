CREATE PROCEDURE [dbo].[AutenticarUsuario]
(@Usuario VARCHAR(400),@Clave VARCHAR(400)
)
AS
begin
	select
		count(*)
	from
		Usuario U
	where
		(U.NombreUsuario = @Usuario)
	and	(U.Contraseña = @Clave)	
end






CREATE PROCEDURE [dbo].[LeerPeriodo](
	@IdPeriodo				int,
	@DescripcionPeriodo		varchar(10) = ''
	)
AS
BEGIN
	DECLARE @ErrorCode as int
	SET NOCOUNT ON;

	begin
		begin tran
			if @DescripcionPeriodo = ''
				begin
					select
						IdPeriodo,
						DescripcionPeriodo,
						FechaInicio,
						FechaFin
					from Periodo 			
					Where ((@IdPeriodo = 0) OR (IdPeriodo = @IdPeriodo))
					and DATEDIFF(MONTH, GETDATE(), FechaFin) < 2
					and DATEDIFF(MONTH, FechaInicio, GETDATE()) > 5
					order by idPeriodo desc
					select @ErrorCode = @@ERROR 
					if @ErrorCode <> 0 goto onError
				end
			else
				begin
					select
						IdPeriodo,
						DescripcionPeriodo,
						FechaInicio,
						FechaFin
					from Periodo 			
					Where ((@DescripcionPeriodo = 0) OR (DescripcionPeriodo LIKE '%'+@DescripcionPeriodo+'%'))
					order by idPeriodo desc
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
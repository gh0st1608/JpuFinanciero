USE [BDFinanciero]
GO

/****** Object:  Table [dbo].[RelacionDebeHaber]    Script Date: 17/10/2020 13:45:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RelacionDebeHaber](
	[IdRelacionDebeHaber] [int] IDENTITY(1,1) NOT NULL,
	[TipoOperacionId] [int] NULL,
	[EtapaOperacionId] [int] NULL,
	[GrupoId] [int] NULL,
	[GrupoDebeId] [int] NULL,
	[GrupoHaberId] [int] NULL,
	[DebeId] [int] NULL,
	[HaberId] [int] NULL,
	[SignoDebe] [int] NULL,
	[SignoHaber] [int] NULL,
	[EstadoActivo] [int] NULL,
	[UsuarioCreacionId] [int] NULL,
	[UsuarioModificacionId] [int] NULL,
	[FechaCreacion] [date] NULL,
	[FechaModificacion] [date] NULL
) ON [PRIMARY]

GO



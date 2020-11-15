USE [BDFinanciero]
GO

/****** Object:  Table [dbo].[Contacto]    Script Date: 30/09/2020 15:16:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Contacto](
	[IdContacto] [int] IDENTITY(1,1) NOT NULL,
	[TipoContactoId] [int] NULL,
	[OrigenId] [int] NULL,
	[Cargo] [varchar](100) NULL,
	[NombreCompleto] [varchar](200) NULL,
	[Correo] [varchar](100) NULL,
	[Celular] [varchar](50) NULL,
	[UsuarioCreacionId] [int] NULL,
	[UsuarioModificacionId] [int] NULL,
	[FechaCreacion] [date] NULL,
	[FechaModificacion] [date] NULL,
	[EstadoActivo] [int] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO



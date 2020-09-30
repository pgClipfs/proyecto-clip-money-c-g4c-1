USE [Wallet_Virtual]
GO
/****** Object:  Table [dbo].[CajaMonedaExtranjera]    Script Date: 30/09/2020 07:42:18 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CajaMonedaExtranjera](
	[ID] [varchar](22) NOT NULL,
	[Monto] [int] NULL,
	[Movimiento] [int] NULL,
	[Detalle] [varchar](50) NULL,
 CONSTRAINT [PK_CajaMonedaExtranjera] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CajaMonedaLocal]    Script Date: 30/09/2020 07:42:18 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CajaMonedaLocal](
	[ID] [varchar](22) NOT NULL,
	[Monto] [int] NULL,
	[Movimiento] [int] NULL,
	[Detalle] [varchar](50) NULL,
 CONSTRAINT [PK_CajaMonedaLocal] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CVU]    Script Date: 30/09/2020 07:42:18 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CVU](
	[Usuario] [varchar](16) NULL,
	[CajaMonedaLocal] [varchar](22) NULL,
	[CajaMonedaExtranjera] [varchar](20) NULL,
	[Inversiones] [varchar](22) NULL,
	[IDCVU] [varchar](20) NOT NULL,
 CONSTRAINT [PK_CVU] PRIMARY KEY CLUSTERED 
(
	[IDCVU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 30/09/2020 07:42:18 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[IDFactura] [varchar](20) NOT NULL,
	[Detalles] [varchar](50) NULL,
	[Vencimiento] [date] NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[IDFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlazoFijo]    Script Date: 30/09/2020 07:42:18 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlazoFijo](
	[IDPlazoFijo] [varchar](22) NOT NULL,
	[Monto] [int] NOT NULL,
	[FechaInicio] [date] NOT NULL,
	[FechaFin] [date] NOT NULL,
 CONSTRAINT [PK_PlazoFijo] PRIMARY KEY CLUSTERED 
(
	[IDPlazoFijo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicios]    Script Date: 30/09/2020 07:42:18 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicios](
	[Tipo_Servicio] [varchar](20) NULL,
	[Monto_Deuda] [float] NULL,
	[Historial] [varchar](20) NULL,
	[IDServicio] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Servicios] PRIMARY KEY CLUSTERED 
(
	[IDServicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 30/09/2020 07:42:18 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[DNI] [int] NULL,
	[IDUsuario] [varchar](16) NOT NULL,
	[Nombre] [varchar](20) NULL,
	[Apellido] [varchar](20) NULL,
	[Contraseña] [varchar](8) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IDUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CVU]  WITH CHECK ADD  CONSTRAINT [FK_CVU_CajaMonedaExtranjera] FOREIGN KEY([CajaMonedaLocal])
REFERENCES [dbo].[CajaMonedaExtranjera] ([ID])
GO
ALTER TABLE [dbo].[CVU] CHECK CONSTRAINT [FK_CVU_CajaMonedaExtranjera]
GO
ALTER TABLE [dbo].[CVU]  WITH CHECK ADD  CONSTRAINT [FK_CVU_CajaMonedaLocal] FOREIGN KEY([CajaMonedaLocal])
REFERENCES [dbo].[CajaMonedaLocal] ([ID])
GO
ALTER TABLE [dbo].[CVU] CHECK CONSTRAINT [FK_CVU_CajaMonedaLocal]
GO
ALTER TABLE [dbo].[CVU]  WITH CHECK ADD  CONSTRAINT [FK_CVU_PlazoFijo] FOREIGN KEY([Inversiones])
REFERENCES [dbo].[PlazoFijo] ([IDPlazoFijo])
GO
ALTER TABLE [dbo].[CVU] CHECK CONSTRAINT [FK_CVU_PlazoFijo]
GO
ALTER TABLE [dbo].[CVU]  WITH CHECK ADD  CONSTRAINT [FK_CVU_Servicios] FOREIGN KEY([CajaMonedaExtranjera])
REFERENCES [dbo].[Servicios] ([IDServicio])
GO
ALTER TABLE [dbo].[CVU] CHECK CONSTRAINT [FK_CVU_Servicios]
GO
ALTER TABLE [dbo].[CVU]  WITH CHECK ADD  CONSTRAINT [FK_CVU_Usuario] FOREIGN KEY([Usuario])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[CVU] CHECK CONSTRAINT [FK_CVU_Usuario]
GO
ALTER TABLE [dbo].[Servicios]  WITH CHECK ADD  CONSTRAINT [FK_Servicios_Factura] FOREIGN KEY([Historial])
REFERENCES [dbo].[Factura] ([IDFactura])
GO
ALTER TABLE [dbo].[Servicios] CHECK CONSTRAINT [FK_Servicios_Factura]
GO

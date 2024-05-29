
CREATE DATABASE [ProyectoProgramacion]
DROP DATABASE proyectoProgramacion
USE [ProyectoProgramacion]

GO

/****** Object:  Table [dbo].[Reservacion]    Script Date: 11/05/2024 22:21:41 ******/

SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO
select*from Reservacion
drop table Reservacion
CREATE TABLE [dbo].[Reservacion](

	[idReservacion] [int] NOT NULL,

	[TipoCancha] [varchar](50) NULL,

	[fecha] [date] NULL,

	[hora] [time](4) NULL,

	[Nombre] [varchar](50) NULL,

	[Carnet] [varchar](50) NULL

) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[usuario]    Script Date: 11/05/2024 22:21:41 ******/

SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

CREATE TABLE [dbo].[usuario](

	[idUsuario] [int] NOT NULL,

	[Nombre] [varchar](50) NULL,

	[Carnet] [varchar](50) NULL,

	[Contra] [varchar](50) NULL,

CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 

(

	[idUsuario] ASC

)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Reservacion]  WITH CHECK ADD  CONSTRAINT [FK_Reservacion_usuario] FOREIGN KEY([idReservacion])

REFERENCES [dbo].[usuario] ([idUsuario])

GO

ALTER TABLE [dbo].[Reservacion] CHECK CONSTRAINT [FK_Reservacion_usuario]

GO

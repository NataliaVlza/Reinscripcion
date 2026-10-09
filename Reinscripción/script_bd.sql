USE [master]
GO
/****** Object:  Database [DS3_Materias]    Script Date: 29/09/2025 14:22:49 ******/
CREATE DATABASE [DS3_Materias]
GO
USE [DS3_Materias]
GO
/****** Object:  Table [dbo].[Materia]    Script Date: 29/09/2025 14:22:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materia](
	[IDMateria] [int] IDENTITY(1,1) NOT NULL,
	[NombreMateria] [varchar](30) NULL,
	[Tipo] [varchar](30) NULL,
	[Horario] [varchar](5) NULL,
	[Calificacion] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Materia] PRIMARY KEY CLUSTERED 
(
	[IDMateria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [DS3_Materias] SET  READ_WRITE 
GO

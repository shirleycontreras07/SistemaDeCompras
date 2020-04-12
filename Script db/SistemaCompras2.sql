USE [master]
GO
/****** Object:  Database [SistemaCompras2]    Script Date: 5/4/2020 1:58:57 p. m. ******/
CREATE DATABASE [SistemaCompras2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SistemaCompras2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER01\MSSQL\DATA\SistemaCompras2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SistemaCompras2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER01\MSSQL\DATA\SistemaCompras2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SistemaCompras2] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SistemaCompras2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SistemaCompras2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SistemaCompras2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SistemaCompras2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SistemaCompras2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SistemaCompras2] SET ARITHABORT OFF 
GO
ALTER DATABASE [SistemaCompras2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SistemaCompras2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SistemaCompras2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SistemaCompras2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SistemaCompras2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SistemaCompras2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SistemaCompras2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SistemaCompras2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SistemaCompras2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SistemaCompras2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SistemaCompras2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SistemaCompras2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SistemaCompras2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SistemaCompras2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SistemaCompras2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SistemaCompras2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SistemaCompras2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SistemaCompras2] SET RECOVERY FULL 
GO
ALTER DATABASE [SistemaCompras2] SET  MULTI_USER 
GO
ALTER DATABASE [SistemaCompras2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SistemaCompras2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SistemaCompras2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SistemaCompras2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SistemaCompras2] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SistemaCompras2', N'ON'
GO
ALTER DATABASE [SistemaCompras2] SET QUERY_STORE = OFF
GO
USE [SistemaCompras2]
GO
/****** Object:  Table [dbo].[Articulos]    Script Date: 5/4/2020 1:58:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulos](
	[CodArticulo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Marca] [int] NOT NULL,
	[Medida] [int] NOT NULL,
	[Existencia] [varchar](50) NOT NULL,
	[Estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodArticulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departamentos]    Script Date: 5/4/2020 1:58:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamentos](
	[CodDept] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodDept] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 5/4/2020 1:58:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[CodEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [varchar](50) NOT NULL,
	[Departamento] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 5/4/2020 1:58:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas](
	[CodMarca] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medida]    Script Date: 5/4/2020 1:58:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medida](
	[CodMedida] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodMedida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orden]    Script Date: 5/4/2020 1:58:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orden](
	[CodOrden] [int] IDENTITY(1,1) NOT NULL,
	[Solicitud] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Estado] [bit] NULL,
	[Articulo] [int] NOT NULL,
	[Cantidad] [varchar](50) NOT NULL,
	[Medida] [int] NOT NULL,
	[Marca] [int] NOT NULL,
	[Costo] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CodOrden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 5/4/2020 1:58:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[CodProveedor] [int] IDENTITY(1,1) NOT NULL,
	[TipoIdentificacion] [int] NOT NULL,
	[Identificacion] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Solicitud]    Script Date: 5/4/2020 1:58:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Solicitud](
	[CodSolicitud] [int] IDENTITY(1,1) NOT NULL,
	[Empleado] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Articulo] [int] NOT NULL,
	[Cantidad] [varchar](50) NOT NULL,
	[Medida] [int] NOT NULL,
	[Estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodSolicitud] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoIdentificacion]    Script Date: 5/4/2020 1:58:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoIdentificacion](
	[CodIdentificacion] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CodIdentificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Articulos]  WITH CHECK ADD FOREIGN KEY([Marca])
REFERENCES [dbo].[Marcas] ([CodMarca])
GO
ALTER TABLE [dbo].[Articulos]  WITH CHECK ADD FOREIGN KEY([Medida])
REFERENCES [dbo].[Medida] ([CodMedida])
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD FOREIGN KEY([Departamento])
REFERENCES [dbo].[Departamentos] ([CodDept])
GO
ALTER TABLE [dbo].[Orden]  WITH CHECK ADD FOREIGN KEY([Articulo])
REFERENCES [dbo].[Articulos] ([CodArticulo])
GO
ALTER TABLE [dbo].[Orden]  WITH CHECK ADD FOREIGN KEY([Marca])
REFERENCES [dbo].[Marcas] ([CodMarca])
GO
ALTER TABLE [dbo].[Orden]  WITH CHECK ADD FOREIGN KEY([Medida])
REFERENCES [dbo].[Medida] ([CodMedida])
GO
ALTER TABLE [dbo].[Orden]  WITH CHECK ADD FOREIGN KEY([Solicitud])
REFERENCES [dbo].[Solicitud] ([CodSolicitud])
GO
ALTER TABLE [dbo].[Proveedores]  WITH CHECK ADD FOREIGN KEY([TipoIdentificacion])
REFERENCES [dbo].[TipoIdentificacion] ([CodIdentificacion])
GO
ALTER TABLE [dbo].[Solicitud]  WITH CHECK ADD FOREIGN KEY([Articulo])
REFERENCES [dbo].[Articulos] ([CodArticulo])
GO
ALTER TABLE [dbo].[Solicitud]  WITH CHECK ADD FOREIGN KEY([Empleado])
REFERENCES [dbo].[Empleados] ([CodEmpleado])
GO
ALTER TABLE [dbo].[Solicitud]  WITH CHECK ADD FOREIGN KEY([Medida])
REFERENCES [dbo].[Medida] ([CodMedida])
GO
USE [master]
GO
ALTER DATABASE [SistemaCompras2] SET  READ_WRITE 
GO

USE [master]
GO
/****** Object:  Database [Truco_Simulador]    Script Date: 21/06/2023 9:54:07 ******/
CREATE DATABASE [Truco_Simulador]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Truco_Simulador', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Truco_Simulador.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Truco_Simulador_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Truco_Simulador_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Truco_Simulador] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Truco_Simulador].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Truco_Simulador] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Truco_Simulador] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Truco_Simulador] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Truco_Simulador] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Truco_Simulador] SET ARITHABORT OFF 
GO
ALTER DATABASE [Truco_Simulador] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Truco_Simulador] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Truco_Simulador] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Truco_Simulador] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Truco_Simulador] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Truco_Simulador] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Truco_Simulador] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Truco_Simulador] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Truco_Simulador] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Truco_Simulador] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Truco_Simulador] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Truco_Simulador] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Truco_Simulador] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Truco_Simulador] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Truco_Simulador] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Truco_Simulador] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Truco_Simulador] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Truco_Simulador] SET RECOVERY FULL 
GO
ALTER DATABASE [Truco_Simulador] SET  MULTI_USER 
GO
ALTER DATABASE [Truco_Simulador] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Truco_Simulador] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Truco_Simulador] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Truco_Simulador] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Truco_Simulador] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Truco_Simulador] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Truco_Simulador', N'ON'
GO
ALTER DATABASE [Truco_Simulador] SET QUERY_STORE = OFF
GO
USE [Truco_Simulador]
GO
/****** Object:  Table [dbo].[Partidas]    Script Date: 21/06/2023 9:54:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Partidas](
	[IdPartida] [int] IDENTITY(1,1) NOT NULL,
	[Jugador1] [varchar](50) NULL,
	[PuntajeJugador1] [int] NULL,
	[Jugador2] [varchar](50) NULL,
	[PuntajeJugador2] [int] NULL,
	[Ganador] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPartida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Partidas] ON 

INSERT [dbo].[Partidas] ([IdPartida], [Jugador1], [PuntajeJugador1], [Jugador2], [PuntajeJugador2], [Ganador]) VALUES (1, N'Francis', 4, N'Yober', 3, N'Francis')
INSERT [dbo].[Partidas] ([IdPartida], [Jugador1], [PuntajeJugador1], [Jugador2], [PuntajeJugador2], [Ganador]) VALUES (2, N'Maxi', 3, N'Facu', 16, N'Facu')
INSERT [dbo].[Partidas] ([IdPartida], [Jugador1], [PuntajeJugador1], [Jugador2], [PuntajeJugador2], [Ganador]) VALUES (3, N'Julian', 16, N'Fernando', 3, N'Julian')
INSERT [dbo].[Partidas] ([IdPartida], [Jugador1], [PuntajeJugador1], [Jugador2], [PuntajeJugador2], [Ganador]) VALUES (4, N'Tomas', 4, N'Nicolas', 0, N'Tomas')
INSERT [dbo].[Partidas] ([IdPartida], [Jugador1], [PuntajeJugador1], [Jugador2], [PuntajeJugador2], [Ganador]) VALUES (5, N'Agustin', 8, N'Francis', 16, N'Francis')
SET IDENTITY_INSERT [dbo].[Partidas] OFF
GO
USE [master]
GO
ALTER DATABASE [Truco_Simulador] SET  READ_WRITE 
GO

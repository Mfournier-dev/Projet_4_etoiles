USE [4Estrellas]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[T_Utilisation]') AND type in (N'U'))
ALTER TABLE [dbo].[T_Utilisation] DROP CONSTRAINT IF EXISTS [FK_T_Utilisation_T_Tables]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[T_CommandesArticles]') AND type in (N'U'))
ALTER TABLE [dbo].[T_CommandesArticles] DROP CONSTRAINT IF EXISTS [FK_T_CommandesArticles_T_Commandes]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[T_CommandesArticles]') AND type in (N'U'))
ALTER TABLE [dbo].[T_CommandesArticles] DROP CONSTRAINT IF EXISTS [FK_T_CommandesArticles_T_Articles]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[T_Commandes]') AND type in (N'U'))
ALTER TABLE [dbo].[T_Commandes] DROP CONSTRAINT IF EXISTS [FK_T_Commandes_T_Tables]
GO
/****** Object:  Table [dbo].[T_Utilisation]    Script Date: 2022-12-18 11:51:36 PM ******/
DROP TABLE IF EXISTS [dbo].[T_Utilisation]
GO
/****** Object:  Table [dbo].[T_Tables]    Script Date: 2022-12-18 11:51:36 PM ******/
DROP TABLE IF EXISTS [dbo].[T_Tables]
GO
/****** Object:  Table [dbo].[T_CommandesArticles]    Script Date: 2022-12-18 11:51:36 PM ******/
DROP TABLE IF EXISTS [dbo].[T_CommandesArticles]
GO
/****** Object:  Table [dbo].[T_Commandes]    Script Date: 2022-12-18 11:51:36 PM ******/
DROP TABLE IF EXISTS [dbo].[T_Commandes]
GO
/****** Object:  Table [dbo].[T_Articles]    Script Date: 2022-12-18 11:51:36 PM ******/
DROP TABLE IF EXISTS [dbo].[T_Articles]
GO
USE [master]
GO
/****** Object:  Database [4Estrellas]    Script Date: 2022-12-18 11:51:36 PM ******/
DROP DATABASE IF EXISTS [4Estrellas]
GO
/****** Object:  Database [4Estrellas]    Script Date: 2022-12-18 11:51:36 PM ******/
CREATE DATABASE [4Estrellas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'4Estrellas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL2019EXPRESS\MSSQL\DATA\4Estrellas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'4Estrellas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL2019EXPRESS\MSSQL\DATA\4Estrellas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [4Estrellas] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [4Estrellas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [4Estrellas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [4Estrellas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [4Estrellas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [4Estrellas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [4Estrellas] SET ARITHABORT OFF 
GO
ALTER DATABASE [4Estrellas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [4Estrellas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [4Estrellas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [4Estrellas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [4Estrellas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [4Estrellas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [4Estrellas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [4Estrellas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [4Estrellas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [4Estrellas] SET  DISABLE_BROKER 
GO
ALTER DATABASE [4Estrellas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [4Estrellas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [4Estrellas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [4Estrellas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [4Estrellas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [4Estrellas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [4Estrellas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [4Estrellas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [4Estrellas] SET  MULTI_USER 
GO
ALTER DATABASE [4Estrellas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [4Estrellas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [4Estrellas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [4Estrellas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [4Estrellas] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [4Estrellas] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [4Estrellas] SET QUERY_STORE = OFF
GO
USE [4Estrellas]
GO
/****** Object:  Table [dbo].[T_Articles]    Script Date: 2022-12-18 11:51:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Articles](
	[IdArticle] [int] IDENTITY(1,1) NOT NULL,
	[NomArticle] [nvarchar](35) NOT NULL,
	[Categorie] [nchar](25) NOT NULL,
	[Prix] [decimal](5, 2) NOT NULL,
 CONSTRAINT [PK_TableArticles] PRIMARY KEY CLUSTERED 
(
	[IdArticle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Commandes]    Script Date: 2022-12-18 11:51:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Commandes](
	[IdCommande] [int] IDENTITY(1,1) NOT NULL,
	[IdTable] [int] NOT NULL,
	[NombreClients] [int] NOT NULL,
 CONSTRAINT [PK_TableCommandes] PRIMARY KEY CLUSTERED 
(
	[IdCommande] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_CommandesArticles]    Script Date: 2022-12-18 11:51:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_CommandesArticles](
	[IdCA] [int] IDENTITY(1,1) NOT NULL,
	[IdArticle] [int] NOT NULL,
	[IdCommande] [int] NOT NULL,
	[Quantite] [int] NOT NULL,
 CONSTRAINT [PK_T_CommandesArticles_1] PRIMARY KEY CLUSTERED 
(
	[IdCA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Tables]    Script Date: 2022-12-18 11:51:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Tables](
	[IdTable] [int] IDENTITY(1,1) NOT NULL,
	[MaximumClients] [int] NOT NULL,
	[MinimumClients] [int] NOT NULL,
	[Statut] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_T_Tables] PRIMARY KEY CLUSTERED 
(
	[IdTable] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Utilisation]    Script Date: 2022-12-18 11:51:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Utilisation](
	[IdUtilisation] [int] IDENTITY(1,1) NOT NULL,
	[NombreClients] [int] NOT NULL,
	[IdTable] [int] NOT NULL,
	[NomReservation] [nvarchar](64) NULL,
	[NumeroTelephone] [nvarchar](16) NULL,
	[DateReservation] [datetime] NOT NULL,
	[HeureReservation] [datetime] NOT NULL,
 CONSTRAINT [PK_UtilisationTables] PRIMARY KEY CLUSTERED 
(
	[IdUtilisation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[T_Articles] ON 

INSERT [dbo].[T_Articles] ([IdArticle], [NomArticle], [Categorie], [Prix]) VALUES (1, N'Tres Leches', N'Dessert                  ', CAST(10.00 AS Decimal(5, 2)))
INSERT [dbo].[T_Articles] ([IdArticle], [NomArticle], [Categorie], [Prix]) VALUES (2, N'Filet Mignon', N'Plat Principal           ', CAST(49.99 AS Decimal(5, 2)))
INSERT [dbo].[T_Articles] ([IdArticle], [NomArticle], [Categorie], [Prix]) VALUES (3, N'Cotes-Levees', N'Plat Principal           ', CAST(45.00 AS Decimal(5, 2)))
INSERT [dbo].[T_Articles] ([IdArticle], [NomArticle], [Categorie], [Prix]) VALUES (4, N'Creme Brulee', N'Dessert                  ', CAST(12.00 AS Decimal(5, 2)))
INSERT [dbo].[T_Articles] ([IdArticle], [NomArticle], [Categorie], [Prix]) VALUES (5, N'Pinot Noir, bouteille', N'Boisson                  ', CAST(89.99 AS Decimal(5, 2)))
INSERT [dbo].[T_Articles] ([IdArticle], [NomArticle], [Categorie], [Prix]) VALUES (6, N'Pinot Noir, verre', N'Boisson                  ', CAST(12.00 AS Decimal(5, 2)))
INSERT [dbo].[T_Articles] ([IdArticle], [NomArticle], [Categorie], [Prix]) VALUES (7, N'Soupe aux oignons', N'Entree                   ', CAST(15.00 AS Decimal(5, 2)))
INSERT [dbo].[T_Articles] ([IdArticle], [NomArticle], [Categorie], [Prix]) VALUES (8, N'Nachos chili', N'Entree                   ', CAST(18.00 AS Decimal(5, 2)))
SET IDENTITY_INSERT [dbo].[T_Articles] OFF
GO
SET IDENTITY_INSERT [dbo].[T_Commandes] ON 

INSERT [dbo].[T_Commandes] ([IdCommande], [IdTable], [NombreClients]) VALUES (1, 1, 4)
INSERT [dbo].[T_Commandes] ([IdCommande], [IdTable], [NombreClients]) VALUES (2, 2, 4)
SET IDENTITY_INSERT [dbo].[T_Commandes] OFF
GO
SET IDENTITY_INSERT [dbo].[T_CommandesArticles] ON 

INSERT [dbo].[T_CommandesArticles] ([IdCA], [IdArticle], [IdCommande], [Quantite]) VALUES (1, 1, 1, 2)
INSERT [dbo].[T_CommandesArticles] ([IdCA], [IdArticle], [IdCommande], [Quantite]) VALUES (2, 2, 1, 2)
INSERT [dbo].[T_CommandesArticles] ([IdCA], [IdArticle], [IdCommande], [Quantite]) VALUES (3, 2, 2, 4)
INSERT [dbo].[T_CommandesArticles] ([IdCA], [IdArticle], [IdCommande], [Quantite]) VALUES (4, 3, 1, 2)
INSERT [dbo].[T_CommandesArticles] ([IdCA], [IdArticle], [IdCommande], [Quantite]) VALUES (5, 4, 2, 3)
INSERT [dbo].[T_CommandesArticles] ([IdCA], [IdArticle], [IdCommande], [Quantite]) VALUES (6, 5, 1, 1)
INSERT [dbo].[T_CommandesArticles] ([IdCA], [IdArticle], [IdCommande], [Quantite]) VALUES (7, 6, 2, 3)
INSERT [dbo].[T_CommandesArticles] ([IdCA], [IdArticle], [IdCommande], [Quantite]) VALUES (8, 7, 1, 5)
INSERT [dbo].[T_CommandesArticles] ([IdCA], [IdArticle], [IdCommande], [Quantite]) VALUES (9, 8, 2, 2)
SET IDENTITY_INSERT [dbo].[T_CommandesArticles] OFF
GO
SET IDENTITY_INSERT [dbo].[T_Tables] ON 

INSERT [dbo].[T_Tables] ([IdTable], [MaximumClients], [MinimumClients], [Statut]) VALUES (1, 12, 8, N'Occupé')
INSERT [dbo].[T_Tables] ([IdTable], [MaximumClients], [MinimumClients], [Statut]) VALUES (2, 4, 1, N'Occupé')
INSERT [dbo].[T_Tables] ([IdTable], [MaximumClients], [MinimumClients], [Statut]) VALUES (3, 8, 4, N'Libre')
INSERT [dbo].[T_Tables] ([IdTable], [MaximumClients], [MinimumClients], [Statut]) VALUES (4, 12, 12, N'Libre')
INSERT [dbo].[T_Tables] ([IdTable], [MaximumClients], [MinimumClients], [Statut]) VALUES (5, 6, 3, N'Libre')
INSERT [dbo].[T_Tables] ([IdTable], [MaximumClients], [MinimumClients], [Statut]) VALUES (6, 2, 1, N'Libre')
INSERT [dbo].[T_Tables] ([IdTable], [MaximumClients], [MinimumClients], [Statut]) VALUES (7, 8, 4, N'Libre')
INSERT [dbo].[T_Tables] ([IdTable], [MaximumClients], [MinimumClients], [Statut]) VALUES (12, 4, 2, N'Libre')
INSERT [dbo].[T_Tables] ([IdTable], [MaximumClients], [MinimumClients], [Statut]) VALUES (13, 6, 4, N'Libre')
INSERT [dbo].[T_Tables] ([IdTable], [MaximumClients], [MinimumClients], [Statut]) VALUES (14, 2, 1, N'Libre')
SET IDENTITY_INSERT [dbo].[T_Tables] OFF
GO
SET IDENTITY_INSERT [dbo].[T_Utilisation] ON 

INSERT [dbo].[T_Utilisation] ([IdUtilisation], [NombreClients], [IdTable], [NomReservation], [NumeroTelephone], [DateReservation], [HeureReservation]) VALUES (1, 4, 1, N'Paul', N'438-555-3456', CAST(N'2022-12-25T00:00:00.000' AS DateTime), CAST(N'1900-01-01T16:00:00.000' AS DateTime))
INSERT [dbo].[T_Utilisation] ([IdUtilisation], [NombreClients], [IdTable], [NomReservation], [NumeroTelephone], [DateReservation], [HeureReservation]) VALUES (2, 12, 4, N'Paola', N'418-265-1951', CAST(N'2022-12-24T00:00:00.000' AS DateTime), CAST(N'2022-12-18T17:00:00.000' AS DateTime))
INSERT [dbo].[T_Utilisation] ([IdUtilisation], [NombreClients], [IdTable], [NomReservation], [NumeroTelephone], [DateReservation], [HeureReservation]) VALUES (10, 4, 6, N'Trudy', N'540-322-4444', CAST(N'2022-12-21T10:06:56.000' AS DateTime), CAST(N'2022-12-18T16:00:00.000' AS DateTime))
INSERT [dbo].[T_Utilisation] ([IdUtilisation], [NombreClients], [IdTable], [NomReservation], [NumeroTelephone], [DateReservation], [HeureReservation]) VALUES (11, 6, 7, N'Pepe', N'424-333-2222', CAST(N'2022-12-18T10:21:19.073' AS DateTime), CAST(N'2022-12-18T17:30:00.000' AS DateTime))
INSERT [dbo].[T_Utilisation] ([IdUtilisation], [NombreClients], [IdTable], [NomReservation], [NumeroTelephone], [DateReservation], [HeureReservation]) VALUES (12, 2, 13, N'Jobaba', N'432-554-2222', CAST(N'2022-12-21T10:34:35.000' AS DateTime), CAST(N'2022-12-18T17:30:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[T_Utilisation] OFF
GO
ALTER TABLE [dbo].[T_Commandes]  WITH CHECK ADD  CONSTRAINT [FK_T_Commandes_T_Tables] FOREIGN KEY([IdTable])
REFERENCES [dbo].[T_Tables] ([IdTable])
GO
ALTER TABLE [dbo].[T_Commandes] CHECK CONSTRAINT [FK_T_Commandes_T_Tables]
GO
ALTER TABLE [dbo].[T_CommandesArticles]  WITH CHECK ADD  CONSTRAINT [FK_T_CommandesArticles_T_Articles] FOREIGN KEY([IdArticle])
REFERENCES [dbo].[T_Articles] ([IdArticle])
GO
ALTER TABLE [dbo].[T_CommandesArticles] CHECK CONSTRAINT [FK_T_CommandesArticles_T_Articles]
GO
ALTER TABLE [dbo].[T_CommandesArticles]  WITH CHECK ADD  CONSTRAINT [FK_T_CommandesArticles_T_Commandes] FOREIGN KEY([IdCommande])
REFERENCES [dbo].[T_Commandes] ([IdCommande])
GO
ALTER TABLE [dbo].[T_CommandesArticles] CHECK CONSTRAINT [FK_T_CommandesArticles_T_Commandes]
GO
ALTER TABLE [dbo].[T_Utilisation]  WITH CHECK ADD  CONSTRAINT [FK_T_Utilisation_T_Tables] FOREIGN KEY([IdTable])
REFERENCES [dbo].[T_Tables] ([IdTable])
GO
ALTER TABLE [dbo].[T_Utilisation] CHECK CONSTRAINT [FK_T_Utilisation_T_Tables]
GO
USE [master]
GO
ALTER DATABASE [4Estrellas] SET  READ_WRITE 
GO

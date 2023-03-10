USE [master]
GO
/****** Object:  Database [passionsDB]    Script Date: 16/01/2023 19:36:25 ******/
CREATE DATABASE [passionsDB]
GO
ALTER DATABASE [passionsDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [passionsDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [passionsDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [passionsDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [passionsDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [passionsDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [passionsDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [passionsDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [passionsDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [passionsDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [passionsDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [passionsDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [passionsDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [passionsDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [passionsDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [passionsDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [passionsDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [passionsDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [passionsDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [passionsDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [passionsDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [passionsDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [passionsDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [passionsDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [passionsDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [passionsDB] SET  MULTI_USER 
GO
ALTER DATABASE [passionsDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [passionsDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [passionsDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [passionsDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [passionsDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [passionsDB] SET QUERY_STORE = OFF
GO
USE [passionsDB]
GO
/****** Object:  Table [dbo].[Passions]    Script Date: 16/01/2023 19:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Passions](
	[IndexPass] [int] IDENTITY(1,1) NOT NULL,
	[Passion] [varchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[IndexPass] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personnes]    Script Date: 16/01/2023 19:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personnes](
	[IndexNom] [int] IDENTITY(1,1) NOT NULL,
	[Prenom] [varchar](60) NULL,
	[Nom] [varchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[IndexNom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersPass]    Script Date: 16/01/2023 19:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersPass](
	[IndexNom] [int] NOT NULL,
	[IndexPass] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IndexNom] ASC,
	[IndexPass] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Passions] ON 

INSERT [dbo].[Passions] ([IndexPass], [Passion]) VALUES (1, N'ski')
INSERT [dbo].[Passions] ([IndexPass], [Passion]) VALUES (2, N'marche')
INSERT [dbo].[Passions] ([IndexPass], [Passion]) VALUES (3, N'lecture')
INSERT [dbo].[Passions] ([IndexPass], [Passion]) VALUES (4, N'philatelie')
INSERT [dbo].[Passions] ([IndexPass], [Passion]) VALUES (5, N'informatique')
SET IDENTITY_INSERT [dbo].[Passions] OFF
GO
SET IDENTITY_INSERT [dbo].[Personnes] ON 

INSERT [dbo].[Personnes] ([IndexNom], [Prenom], [Nom]) VALUES (1, N'Jean', N'Bon')
INSERT [dbo].[Personnes] ([IndexNom], [Prenom], [Nom]) VALUES (2, N'Pierre', N'Ade')
INSERT [dbo].[Personnes] ([IndexNom], [Prenom], [Nom]) VALUES (3, N'Jacques', N'Adis')
INSERT [dbo].[Personnes] ([IndexNom], [Prenom], [Nom]) VALUES (4, N'Leon', N'Nard')
INSERT [dbo].[Personnes] ([IndexNom], [Prenom], [Nom]) VALUES (5, N'Jean', N'Tand')
SET IDENTITY_INSERT [dbo].[Personnes] OFF
GO
INSERT [dbo].[PersPass] ([IndexNom], [IndexPass]) VALUES (1, 2)
INSERT [dbo].[PersPass] ([IndexNom], [IndexPass]) VALUES (1, 3)
INSERT [dbo].[PersPass] ([IndexNom], [IndexPass]) VALUES (2, 5)
INSERT [dbo].[PersPass] ([IndexNom], [IndexPass]) VALUES (3, 1)
INSERT [dbo].[PersPass] ([IndexNom], [IndexPass]) VALUES (3, 2)
INSERT [dbo].[PersPass] ([IndexNom], [IndexPass]) VALUES (3, 4)
INSERT [dbo].[PersPass] ([IndexNom], [IndexPass]) VALUES (4, 2)
INSERT [dbo].[PersPass] ([IndexNom], [IndexPass]) VALUES (5, 2)
INSERT [dbo].[PersPass] ([IndexNom], [IndexPass]) VALUES (5, 3)
GO
ALTER TABLE [dbo].[PersPass]  WITH CHECK ADD FOREIGN KEY([IndexNom])
REFERENCES [dbo].[Personnes] ([IndexNom])
GO
ALTER TABLE [dbo].[PersPass]  WITH CHECK ADD FOREIGN KEY([IndexPass])
REFERENCES [dbo].[Passions] ([IndexPass])
GO
USE [master]
GO
ALTER DATABASE [passionsDB] SET  READ_WRITE 
GO

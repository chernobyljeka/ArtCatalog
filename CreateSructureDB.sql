USE [master]
GO
/****** Object:  Database [artcatalog]    Script Date: 02.12.2016 2:41:06 ******/
CREATE DATABASE [artcatalog] ON  PRIMARY 
( NAME = N'artcatalog', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\artcatalog.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'artcatalog_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\artcatalog_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [artcatalog].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [artcatalog] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [artcatalog] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [artcatalog] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [artcatalog] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [artcatalog] SET ARITHABORT OFF 
GO
ALTER DATABASE [artcatalog] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [artcatalog] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [artcatalog] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [artcatalog] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [artcatalog] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [artcatalog] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [artcatalog] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [artcatalog] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [artcatalog] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [artcatalog] SET  DISABLE_BROKER 
GO
ALTER DATABASE [artcatalog] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [artcatalog] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [artcatalog] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [artcatalog] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [artcatalog] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [artcatalog] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [artcatalog] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [artcatalog] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [artcatalog] SET  MULTI_USER 
GO
ALTER DATABASE [artcatalog] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [artcatalog] SET DB_CHAINING OFF 
GO
USE [artcatalog]
GO
/****** Object:  Table [dbo].[Persons]    Script Date: 02.12.2016 2:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[ID_Person] [int] IDENTITY(1,1) NOT NULL,
	[login] [varchar](16) NOT NULL,
	[Password_hash] [varchar](255) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Surname] [varchar](100) NOT NULL,
	[Date_birthday] [datetime] NOT NULL,
	[Position] [varchar](100) NOT NULL,
	[Admin] [bit] NOT NULL,
 CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED 
(
	[ID_Person] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 02.12.2016 2:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ID_product] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Discription] [varchar](100) NULL,
	[Count] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[ImagePath] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ID_product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sells]    Script Date: 02.12.2016 2:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sells](
	[ID_sell] [int] IDENTITY(1,1) NOT NULL,
	[ID_product] [int] NOT NULL,
	[ID_person] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[Sum] [int] NOT NULL,
 CONSTRAINT [PK_Sells] PRIMARY KEY CLUSTERED 
(
	[ID_sell] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Persons] ON 

GO
INSERT [dbo].[Persons] ([ID_Person], [login], [Password_hash], [Name], [Surname], [Date_birthday], [Position], [Admin]) VALUES (3, N'log', N'1', N'Тест имя', N'Тест фам', CAST(N'2012-12-12T00:00:00.000' AS DateTime), N'Админ', 1)
GO
SET IDENTITY_INSERT [dbo].[Persons] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

GO
INSERT [dbo].[Products] ([ID_product], [Name], [Discription], [Count], [Price], [ImagePath]) VALUES (1, N'Тестовый продукт', N'Описание', 100, 100, N'SomePath')
GO
INSERT [dbo].[Products] ([ID_product], [Name], [Discription], [Count], [Price], [ImagePath]) VALUES (2, N'Тестовый продукт 2', N'Описание 2', 56, 25, N'SomePath')
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Sells] ON 

GO
INSERT [dbo].[Sells] ([ID_sell], [ID_product], [ID_person], [Date], [Sum]) VALUES (2, 1, 3, CAST(N'2012-12-12T00:00:00.000' AS DateTime), 3)
GO
SET IDENTITY_INSERT [dbo].[Sells] OFF
GO
ALTER TABLE [dbo].[Sells]  WITH CHECK ADD  CONSTRAINT [FK_Sells_Persons] FOREIGN KEY([ID_person])
REFERENCES [dbo].[Persons] ([ID_Person])
GO
ALTER TABLE [dbo].[Sells] CHECK CONSTRAINT [FK_Sells_Persons]
GO
ALTER TABLE [dbo].[Sells]  WITH CHECK ADD  CONSTRAINT [FK_Sells_Products] FOREIGN KEY([ID_product])
REFERENCES [dbo].[Products] ([ID_product])
GO
ALTER TABLE [dbo].[Sells] CHECK CONSTRAINT [FK_Sells_Products]
GO
USE [master]
GO
ALTER DATABASE [artcatalog] SET  READ_WRITE 
GO

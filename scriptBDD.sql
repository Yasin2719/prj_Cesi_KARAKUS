USE [master]
GO
/****** Object:  Database [BDD_Cesi]    Script Date: 07/06/2021 14:42:10 ******/
CREATE DATABASE [BDD_Cesi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDD_Cesi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BDD_Cesi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BDD_Cesi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BDD_Cesi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BDD_Cesi] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDD_Cesi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDD_Cesi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDD_Cesi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDD_Cesi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDD_Cesi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDD_Cesi] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDD_Cesi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BDD_Cesi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDD_Cesi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDD_Cesi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDD_Cesi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDD_Cesi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDD_Cesi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDD_Cesi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDD_Cesi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDD_Cesi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BDD_Cesi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDD_Cesi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDD_Cesi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDD_Cesi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDD_Cesi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDD_Cesi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDD_Cesi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDD_Cesi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BDD_Cesi] SET  MULTI_USER 
GO
ALTER DATABASE [BDD_Cesi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDD_Cesi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDD_Cesi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDD_Cesi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BDD_Cesi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BDD_Cesi] SET QUERY_STORE = OFF
GO
USE [BDD_Cesi]
GO
/****** Object:  Table [dbo].[Personne]    Script Date: 07/06/2021 14:42:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personne](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [nchar](50) NULL,
	[Prenom] [nchar](50) NULL,
	[Telephone] [nchar](50) NULL,
	[Service] [nchar](30) NULL,
	[DateEntree] [date] NULL,
 CONSTRAINT [PK_Personne] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Personne] ON 

INSERT [dbo].[Personne] ([id], [Nom], [Prenom], [Telephone], [Service], [DateEntree]) VALUES (2, N'KARAKUS                                           ', N'Yasin                                             ', N'0651614980                                        ', N'Bouygue Telecom               ', CAST(N'2011-10-31' AS Date))
INSERT [dbo].[Personne] ([id], [Nom], [Prenom], [Telephone], [Service], [DateEntree]) VALUES (3, N'karakus                                           ', N'selim                                             ', N'0101010101                                        ', N'Free                          ', CAST(N'2021-06-04' AS Date))
INSERT [dbo].[Personne] ([id], [Nom], [Prenom], [Telephone], [Service], [DateEntree]) VALUES (12, N'Kallio                                            ', N'Ronja                                             ', N'044-327-59-93                                     ', N'SFR                           ', CAST(N'2021-06-05' AS Date))
INSERT [dbo].[Personne] ([id], [Nom], [Prenom], [Telephone], [Service], [DateEntree]) VALUES (13, N'Roy                                               ', N'Lily                                              ', N'478-784-9853                                      ', N'Orange                        ', CAST(N'2021-06-05' AS Date))
INSERT [dbo].[Personne] ([id], [Nom], [Prenom], [Telephone], [Service], [DateEntree]) VALUES (14, N'????                                              ', N'????                                              ', N'0951-748-0454                                     ', N'SFR                           ', CAST(N'2021-03-04' AS Date))
INSERT [dbo].[Personne] ([id], [Nom], [Prenom], [Telephone], [Service], [DateEntree]) VALUES (15, N'Hansen                                            ', N'Jack                                              ', N'0766-943-823                                      ', N'SFR                           ', CAST(N'2021-03-04' AS Date))
INSERT [dbo].[Personne] ([id], [Nom], [Prenom], [Telephone], [Service], [DateEntree]) VALUES (16, N'Esteban                                           ', N'Marta                                             ', N'626-803-573                                       ', N'Orange                        ', CAST(N'2021-04-14' AS Date))
SET IDENTITY_INSERT [dbo].[Personne] OFF
GO
/****** Object:  StoredProcedure [dbo].[prc_PersonneListe]    Script Date: 07/06/2021 14:42:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_PersonneListe] 
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Personne
END
GO
/****** Object:  StoredProcedure [dbo].[prcAddUser]    Script Date: 07/06/2021 14:42:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prcAddUser] 
	-- Add the parameters for the stored procedure here
@nom as varchar (50),
@prenom as varchar(50),
@tel as varchar(20),
@service as varchar(50),
@dateE as date

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into Personne values (@nom,@prenom,@tel,@service,@dateE)
END
GO
USE [master]
GO
ALTER DATABASE [BDD_Cesi] SET  READ_WRITE 
GO

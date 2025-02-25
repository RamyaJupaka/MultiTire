USE [master]
GO
/****** Object:  Database [HI-TechProject]    Script Date: 12/3/2019 10:26:53 PM ******/
CREATE DATABASE [HI-TechProject]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HI-TechProject', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER2017\MSSQL\DATA\HI-TechProject.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HI-TechProject_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER2017\MSSQL\DATA\HI-TechProject_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [HI-TechProject] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HI-TechProject].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HI-TechProject] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HI-TechProject] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HI-TechProject] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HI-TechProject] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HI-TechProject] SET ARITHABORT OFF 
GO
ALTER DATABASE [HI-TechProject] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HI-TechProject] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HI-TechProject] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HI-TechProject] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HI-TechProject] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HI-TechProject] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HI-TechProject] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HI-TechProject] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HI-TechProject] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HI-TechProject] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HI-TechProject] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HI-TechProject] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HI-TechProject] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HI-TechProject] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HI-TechProject] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HI-TechProject] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HI-TechProject] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HI-TechProject] SET RECOVERY FULL 
GO
ALTER DATABASE [HI-TechProject] SET  MULTI_USER 
GO
ALTER DATABASE [HI-TechProject] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HI-TechProject] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HI-TechProject] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HI-TechProject] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HI-TechProject] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'HI-TechProject', N'ON'
GO
ALTER DATABASE [HI-TechProject] SET QUERY_STORE = OFF
GO
USE [HI-TechProject]
GO
/****** Object:  Table [dbo].[AuthorBooks]    Script Date: 12/3/2019 10:26:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuthorBooks](
	[AutherID] [int] NOT NULL,
	[ISBN] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_AuthorBooks] PRIMARY KEY CLUSTERED 
(
	[AutherID] ASC,
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 12/3/2019 10:26:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[AutherID] [int] NOT NULL,
	[AutherFistName] [nvarchar](50) NOT NULL,
	[AuterLastName] [nvarchar](50) NOT NULL,
	[AuterEmail] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[AutherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 12/3/2019 10:26:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[ISBN] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Price] [float] NOT NULL,
	[QOH] [int] NOT NULL,
	[CatID] [int] NOT NULL,
	[PubID] [int] NOT NULL,
	[YearsPublished] [int] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BooksCatagory]    Script Date: 12/3/2019 10:26:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BooksCatagory](
	[CatID] [int] NOT NULL,
	[CatagoryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_BooksCatagory] PRIMARY KEY CLUSTERED 
(
	[CatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 12/3/2019 10:26:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[PostalCode] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
	[FaxNumber] [nvarchar](50) NOT NULL,
	[CreditLimit] [int] NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 12/3/2019 10:26:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[JobTitle] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderLines]    Script Date: 12/3/2019 10:26:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderLines](
	[OrderID] [int] NOT NULL,
	[ISBN] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_OrderLines] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 12/3/2019 10:26:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[EmployeeID] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publishers]    Script Date: 12/3/2019 10:26:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publishers](
	[PubID] [int] NOT NULL,
	[PublisherName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Publishers] PRIMARY KEY CLUSTERED 
(
	[PubID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 12/3/2019 10:26:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Books] ([ISBN], [Title], [Price], [QOH], [CatID], [PubID], [YearsPublished]) VALUES (N'1111', N'fhdjk', 543, 33, 222, 23, 111)
INSERT [dbo].[Books] ([ISBN], [Title], [Price], [QOH], [CatID], [PubID], [YearsPublished]) VALUES (N'2222', N'ddd', 333, 333, 333, 33, 333)
INSERT [dbo].[BooksCatagory] ([CatID], [CatagoryName]) VALUES (1, N'JAVA')
INSERT [dbo].[BooksCatagory] ([CatID], [CatagoryName]) VALUES (2, N'Python')
INSERT [dbo].[BooksCatagory] ([CatID], [CatagoryName]) VALUES (3, N'PHP')
INSERT [dbo].[BooksCatagory] ([CatID], [CatagoryName]) VALUES (4, N'C')
INSERT [dbo].[BooksCatagory] ([CatID], [CatagoryName]) VALUES (5, N'Database')
INSERT [dbo].[BooksCatagory] ([CatID], [CatagoryName]) VALUES (6, N'IOS')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [JobTitle]) VALUES (1111, N'Henry', N'Brown', N'Manager')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [JobTitle]) VALUES (2222, N'Thomas', N'Moore', N'SalesManager')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [JobTitle]) VALUES (3333, N'Peter', N'Wang', N'InvertoryController')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [JobTitle]) VALUES (4444, N'Mary', N'Brown', N'OrderClerks')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [JobTitle]) VALUES (5555, N'Jennifer', N'Bouchard', N'OrderClerks')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [JobTitle]) VALUES (6666, N'Kim Hoa', N'Nguyen', N'Accountant')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [JobTitle]) VALUES (7777, N'Rose', N'Tauriac', N'Employee')
INSERT [dbo].[Users] ([UserID], [Password]) VALUES (1111, N'123')
INSERT [dbo].[Users] ([UserID], [Password]) VALUES (2222, N'222')
INSERT [dbo].[Users] ([UserID], [Password]) VALUES (3333, N'123')
INSERT [dbo].[Users] ([UserID], [Password]) VALUES (4444, N'123')
INSERT [dbo].[Users] ([UserID], [Password]) VALUES (5555, N'123')
INSERT [dbo].[Users] ([UserID], [Password]) VALUES (6666, N'123')
USE [master]
GO
ALTER DATABASE [HI-TechProject] SET  READ_WRITE 
GO

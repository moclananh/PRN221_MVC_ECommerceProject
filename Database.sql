USE [master]
GO
/****** Object:  Database [PRN221_ASM02]    Script Date: 17/6/2023 7:22:36 pm ******/
CREATE DATABASE [PRN221_ASM02]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PRN221_ASM02', FILENAME = N'D:\SQL_SERVER\MSSQL15.MSSQLSERVER\MSSQL\DATA\PRN221_ASM02.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PRN221_ASM02_log', FILENAME = N'D:\SQL_SERVER\MSSQL15.MSSQLSERVER\MSSQL\DATA\PRN221_ASM02_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PRN221_ASM02] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PRN221_ASM02].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PRN221_ASM02] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PRN221_ASM02] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PRN221_ASM02] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PRN221_ASM02] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PRN221_ASM02] SET ARITHABORT OFF 
GO
ALTER DATABASE [PRN221_ASM02] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PRN221_ASM02] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PRN221_ASM02] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PRN221_ASM02] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PRN221_ASM02] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PRN221_ASM02] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PRN221_ASM02] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PRN221_ASM02] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PRN221_ASM02] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PRN221_ASM02] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PRN221_ASM02] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PRN221_ASM02] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PRN221_ASM02] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PRN221_ASM02] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PRN221_ASM02] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PRN221_ASM02] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PRN221_ASM02] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PRN221_ASM02] SET RECOVERY FULL 
GO
ALTER DATABASE [PRN221_ASM02] SET  MULTI_USER 
GO
ALTER DATABASE [PRN221_ASM02] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PRN221_ASM02] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PRN221_ASM02] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PRN221_ASM02] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PRN221_ASM02] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PRN221_ASM02] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'PRN221_ASM02', N'ON'
GO
ALTER DATABASE [PRN221_ASM02] SET QUERY_STORE = OFF
GO
USE [PRN221_ASM02]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 17/6/2023 7:22:36 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[AccountId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[Type] [bit] NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 17/6/2023 7:22:36 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
	[Desciption] [nvarchar](max) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 17/6/2023 7:22:36 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[ContactName] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](max) NULL,
	[Phone] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 17/6/2023 7:22:36 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[UnitPrice] [float] NOT NULL,
	[Quantity] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 17/6/2023 7:22:36 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[OrderDate] [date] NOT NULL,
	[RequiredDate] [date] NOT NULL,
	[ShippedDate] [date] NOT NULL,
	[Freight] [int] NOT NULL,
	[ShipAddress] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 17/6/2023 7:22:36 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
	[SuppilerId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[QuantityPerUnit] [int] NOT NULL,
	[UnitPrice] [float] NOT NULL,
	[ProductImage] [nvarchar](max) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 17/6/2023 7:22:36 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierId] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[SupplierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([AccountId], [UserName], [Password], [FullName], [Type]) VALUES (3, N'admin', N'admin', N'admin', 0)
INSERT [dbo].[Account] ([AccountId], [UserName], [Password], [FullName], [Type]) VALUES (6, N'thanh', N'123123', N'thanh', 1)
INSERT [dbo].[Account] ([AccountId], [UserName], [Password], [FullName], [Type]) VALUES (7, N'hien', N'123123', N'User Name', 1)
INSERT [dbo].[Account] ([AccountId], [UserName], [Password], [FullName], [Type]) VALUES (8, N'tien', N'123123', N'User Name', 1)
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [Desciption]) VALUES (1, N'Pizza hai san', N'pizza hai san co tom ngon lam')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [Desciption]) VALUES (2, N'Pizza pho mai', N'pizza pho mai co pho mai ngon lam')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [Desciption]) VALUES (3, N'pizza giam gia', N'giam gia re lam')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerId], [Password], [ContactName], [Address], [Phone]) VALUES (1, N'123123', N'thanh', N'tra vinh', N'0339078133')
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
INSERT [dbo].[OrderDetails] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (3, 1, 100, 1)
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderId], [CustomerId], [OrderDate], [RequiredDate], [ShippedDate], [Freight], [ShipAddress]) VALUES (3, 1, CAST(N'2023-06-17' AS Date), CAST(N'2023-06-17' AS Date), CAST(N'2023-06-18' AS Date), 100, N'tra vinh')
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductId], [ProductName], [SuppilerId], [CategoryId], [QuantityPerUnit], [UnitPrice], [ProductImage]) VALUES (1, N'Pizza hai san', 1, 1, 10, 100, N'https://img.dominos.vn/cach-lam-pizza-chay-0.jpg')
INSERT [dbo].[Products] ([ProductId], [ProductName], [SuppilerId], [CategoryId], [QuantityPerUnit], [UnitPrice], [ProductImage]) VALUES (2, N'pizza ngon qua', 1, 2, 5, 150, N'https://cdn.tgdd.vn/Files/2021/08/24/1377468/cach-lam-pizza-pho-mai-bap-ngot-beo-ngay-don-gian-tai-nha-202108241444001705.jpg')
INSERT [dbo].[Products] ([ProductId], [ProductName], [SuppilerId], [CategoryId], [QuantityPerUnit], [UnitPrice], [ProductImage]) VALUES (3, N'pizza plaza', 1, 1, 4, 110, N'https://hips.hearstapps.com/hmg-prod/images/classic-cheese-pizza-recipe-2-64429a0cb408b.jpg?crop=0.6666666666666667xw:1xh;center,top&resize=1200:*')
INSERT [dbo].[Products] ([ProductId], [ProductName], [SuppilerId], [CategoryId], [QuantityPerUnit], [UnitPrice], [ProductImage]) VALUES (4, N'pizza rau cu da edit', 1, 1, 12, 122, N'https://cdn.sgtiepthi.vn/wp-content/uploads/2021/10/T3_pizzaraucungusac_pinterest.jpg')
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Suppliers] ON 

INSERT [dbo].[Suppliers] ([SupplierId], [CompanyName], [Address], [Phone]) VALUES (1, N'ThanhTHCO', N'Tra Vinh', N'0339078133')
SET IDENTITY_INSERT [dbo].[Suppliers] OFF
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([OrderId])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Suppliers] FOREIGN KEY([SuppilerId])
REFERENCES [dbo].[Suppliers] ([SupplierId])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Suppliers]
GO
USE [master]
GO
ALTER DATABASE [PRN221_ASM02] SET  READ_WRITE 
GO

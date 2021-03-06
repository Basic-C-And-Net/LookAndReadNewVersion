USE [master]
GO
/****** Object:  Database [BookStoreDatabase]    Script Date: 8.01.2021 21:34:24 ******/
CREATE DATABASE [BookStoreDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BookStoreDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BookStoreDatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BookStoreDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BookStoreDatabase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BookStoreDatabase] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BookStoreDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BookStoreDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BookStoreDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BookStoreDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BookStoreDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BookStoreDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [BookStoreDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BookStoreDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BookStoreDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BookStoreDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BookStoreDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BookStoreDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BookStoreDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BookStoreDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BookStoreDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BookStoreDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BookStoreDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BookStoreDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BookStoreDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BookStoreDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BookStoreDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BookStoreDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BookStoreDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BookStoreDatabase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BookStoreDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [BookStoreDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BookStoreDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BookStoreDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BookStoreDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BookStoreDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BookStoreDatabase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BookStoreDatabase] SET QUERY_STORE = OFF
GO
USE [BookStoreDatabase]
GO
/****** Object:  Table [dbo].[Tbl_admin]    Script Date: 8.01.2021 21:34:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_admin](
	[AdminID] [smallint] IDENTITY(1,1) NOT NULL,
	[AdminUsername] [varchar](10) NULL,
	[AdminPassword] [varchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_book]    Script Date: 8.01.2021 21:34:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_book](
	[BookID] [smallint] IDENTITY(1,1) NOT NULL,
	[BookName] [varchar](50) NOT NULL,
	[BookAuthor] [varchar](30) NOT NULL,
	[BookType] [varchar](30) NOT NULL,
	[BookPrice] [float] NOT NULL,
	[BookDescription] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_customer]    Script Date: 8.01.2021 21:34:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_customer](
	[CustomerID] [smallint] IDENTITY(1,1) NOT NULL,
	[CustomerName] [varchar](15) NOT NULL,
	[CustomerSurname] [varchar](15) NOT NULL,
	[CustomerUsername] [varchar](15) NOT NULL,
	[CustomerPassword] [varchar](15) NOT NULL,
	[CustomerPhone] [varchar](15) NOT NULL,
 CONSTRAINT [PK_Tbl_customer] PRIMARY KEY CLUSTERED 
(
	[CustomerUsername] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_magazine]    Script Date: 8.01.2021 21:34:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_magazine](
	[MagazineID] [smallint] NOT NULL,
	[MagazineName] [varchar](20) NULL,
	[MagazinePrice] [money] NULL,
	[MagazineType] [varchar](15) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_order]    Script Date: 8.01.2021 21:34:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_order](
	[OrderID] [smallint] IDENTITY(1,1) NOT NULL,
	[CustomerUsername] [varchar](15) NULL,
	[OrderName] [varchar](20) NULL,
	[OrderPrice] [money] NULL,
	[OrderState] [bit] NULL,
	[OrderQuantity] [smallint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_type]    Script Date: 8.01.2021 21:34:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_type](
	[TypeID] [tinyint] IDENTITY(1,1) NOT NULL,
	[TypeName] [varchar](30) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Tbl_admin] ON 

INSERT [dbo].[Tbl_admin] ([AdminID], [AdminUsername], [AdminPassword]) VALUES (1, N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[Tbl_admin] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_book] ON 

INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (1, N'Beyaz Geceler', N'Dostoyevski', N'Rus Edebiyatı', 18, N'sadjkasndlkansldknasldaskd')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (5, N'Yüzüklerin Efendisi', N'J.R.R. Tolkien', N'Fantastik', 150, N'dkjbnsş kjdsılkj çvş')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (4, N'Beyaz Diş', N'Jack London', N'Dünya Klasikleri', 14, N'sghtdhgdjyujyughjhg')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (9, N'Cesur Yeni Dünya', N'Aldous Huxley', N'Bilim Kurgu', 22, N'chasbcuoasc')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (10, N'Yerdeniz Büyücüsü', N'Ursula K Leguin', N'Fantastik', 25, N'xdddd')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (11, N'Rüzgarın Adı', N'Patrick Rothfuss', N'Fantastik', 30, N'xxdasdasfasd')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (12, N'Açlık Oyunları', N'Suzanne Collins', N'Fantastik', 30, N'1asdasdasdassa')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (16, N'Bitmeyen Savaş', N'Joe Haldeman', N'Bilim Kurgu', 20, N'dasdasd2134')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (17, N'Cesur Yeni Dünya', N'Aldous Huxley', N'Bilim Kurgu', 36, N'dasdasd2134')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (20, N'Ölü Canlar', N'Nikolay Gogol', N'Rus Edebiyatı', 18, N'xzcczxc')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (21, N'Diriliş', N'Lev Tolstoy', N'Rus Edebiyatı', 22, N'xzcczxc')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (23, N'Tutunamayanlar', N'Oğuz Atay', N'Türk Edebiyatı', 55, N'dsadasdxzadxzc')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (24, N'Yaban', N'Yakup Kadri Karaosmanoğlu', N'Türk Edebiyatı', 52, N'sad214124dfasd')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (26, N'Görünmez Kentler', N'Italo Calvino', N'İtalyan Edebiyatı', 22, N'sdaasdasfasfsaf')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (28, N'Leopar', N'Giuseppe Tomasi di Lampedusa', N'İtalyan Edebiyatı', 28, N'sdaasdasfasfsaf')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (32, N'Altı Yıl', N'Harlan Coben', N'Polisiye', 32, N'asdasdzxczxc')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (33, N'Sefiller', N'Victor Hugo', N'Dünya Klasikleri', 44, N'sdfasdsad')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (35, N'İhtiyar Balıkçı', N'Ernest Hemingway', N'Dünya Klasikleri', 46, N'sdfasdsad')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (13, N'Tehanu', N'Ursula Le Guin', N'Fantastik', 35, N'2asadasasdd')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (18, N'Dune', N'Frank Herbert', N'Bilim Kurgu', 32, N'dasdasd2134')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (30, N'Oğul', N'Jo Nesbo', N'Polisiye', 24, N'sdaw43qasd')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (14, N'Kılıçların Fırtınası', N'George R R Martin', N'Fantastik', 35, N'3asadasasdd')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (15, N'Ben Robot', N'Isaac Asimov', N'Bilim Kurgu', 25, N'adasdasd')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (19, N'Yeraltından Notlar', N'Fyodor Dostoyevski', N'Rus Edebiyatı', 10, N'asdasdasdzxc')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (22, N'Mai ve Siyah', N'Halit Ziya Uşaklıgil', N'Türk Edebiyatı', 60, N'dsadasdxzadxzc')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (25, N'Sinekli Bakkal', N'Halide Edib Adıvar', N'Türk Edebiyatı', 45, N'sadasdasdasd')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (27, N'Tatar Çölü', N'Dino Buzzati', N'İtalyan Edebiyatı', 26, N'sdaasdasfasfsaf')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (29, N'On Küçük Zenci', N'Agatha Christie', N'Polisiye', 36, N'sdaw43qasd')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (31, N'Doğu Ekspresi''nde Cinayet', N'Agatha Christie', N'Polisiye', 28, N'asdasdzxczxc')
INSERT [dbo].[Tbl_book] ([BookID], [BookName], [BookAuthor], [BookType], [BookPrice], [BookDescription]) VALUES (34, N'Babalar ve Oğullar', N'İvan Turgenyev', N'Dünya Klasikleri', 37, N'sdfasdsad')
SET IDENTITY_INSERT [dbo].[Tbl_book] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_customer] ON 

INSERT [dbo].[Tbl_customer] ([CustomerID], [CustomerName], [CustomerSurname], [CustomerUsername], [CustomerPassword], [CustomerPhone]) VALUES (1, N'Çağlar', N'Akman', N'cags', N'1111', N'(535) 2002800')
INSERT [dbo].[Tbl_customer] ([CustomerID], [CustomerName], [CustomerSurname], [CustomerUsername], [CustomerPassword], [CustomerPhone]) VALUES (8, N'Efsun', N'Akman', N'efsun', N'5555', N'(537) 6542681')
INSERT [dbo].[Tbl_customer] ([CustomerID], [CustomerName], [CustomerSurname], [CustomerUsername], [CustomerPassword], [CustomerPhone]) VALUES (3, N'Ahmet ', N'Yeşilyurt', N'tienam', N'2222', N'(555) 5555555')
INSERT [dbo].[Tbl_customer] ([CustomerID], [CustomerName], [CustomerSurname], [CustomerUsername], [CustomerPassword], [CustomerPhone]) VALUES (7, N'dfgdfg', N'fgfdg', N'tryry', N'ryry', N'(444) 4444444')
SET IDENTITY_INSERT [dbo].[Tbl_customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_order] ON 

INSERT [dbo].[Tbl_order] ([OrderID], [CustomerUsername], [OrderName], [OrderPrice], [OrderState], [OrderQuantity]) VALUES (16, N'cags', N'Yüzüklerin Efendisi', 150.0000, 1, 2)
INSERT [dbo].[Tbl_order] ([OrderID], [CustomerUsername], [OrderName], [OrderPrice], [OrderState], [OrderQuantity]) VALUES (2, N'tienam', N'Beyaz Geceler', 15.0000, 1, 1)
INSERT [dbo].[Tbl_order] ([OrderID], [CustomerUsername], [OrderName], [OrderPrice], [OrderState], [OrderQuantity]) VALUES (5, N'tienam', N'Beyaz Diş', 14.0000, 1, 3)
INSERT [dbo].[Tbl_order] ([OrderID], [CustomerUsername], [OrderName], [OrderPrice], [OrderState], [OrderQuantity]) VALUES (9, N'cags', N'Yüzüklerin Efendisi', 150.0000, 1, 1)
INSERT [dbo].[Tbl_order] ([OrderID], [CustomerUsername], [OrderName], [OrderPrice], [OrderState], [OrderQuantity]) VALUES (14, N'cags', N'Beyaz Diş', 14.0000, 1, 3)
INSERT [dbo].[Tbl_order] ([OrderID], [CustomerUsername], [OrderName], [OrderPrice], [OrderState], [OrderQuantity]) VALUES (18, N'cags', N'Beyaz Diş', 14.0000, 1, 2)
INSERT [dbo].[Tbl_order] ([OrderID], [CustomerUsername], [OrderName], [OrderPrice], [OrderState], [OrderQuantity]) VALUES (10, N'cags', N'Beyaz Diş', 14.0000, 1, 3)
INSERT [dbo].[Tbl_order] ([OrderID], [CustomerUsername], [OrderName], [OrderPrice], [OrderState], [OrderQuantity]) VALUES (11, N'cags', N'Yüzüklerin Efendisi', 150.0000, 1, 3)
INSERT [dbo].[Tbl_order] ([OrderID], [CustomerUsername], [OrderName], [OrderPrice], [OrderState], [OrderQuantity]) VALUES (12, N'cags', N'Beyaz Diş', 14.0000, 1, 2)
INSERT [dbo].[Tbl_order] ([OrderID], [CustomerUsername], [OrderName], [OrderPrice], [OrderState], [OrderQuantity]) VALUES (13, N'cags', N'Beyaz Diş', 14.0000, 1, 4)
SET IDENTITY_INSERT [dbo].[Tbl_order] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_type] ON 

INSERT [dbo].[Tbl_type] ([TypeID], [TypeName]) VALUES (1, N'Fantastik')
INSERT [dbo].[Tbl_type] ([TypeID], [TypeName]) VALUES (2, N'Bilim Kurgu')
INSERT [dbo].[Tbl_type] ([TypeID], [TypeName]) VALUES (3, N'Rus Edebiyatı')
INSERT [dbo].[Tbl_type] ([TypeID], [TypeName]) VALUES (4, N'Polisiye')
INSERT [dbo].[Tbl_type] ([TypeID], [TypeName]) VALUES (5, N'İtalyan Edebiyatı')
INSERT [dbo].[Tbl_type] ([TypeID], [TypeName]) VALUES (6, N'Türk Edebiyatı')
INSERT [dbo].[Tbl_type] ([TypeID], [TypeName]) VALUES (7, N'Dünya Klasikleri')
SET IDENTITY_INSERT [dbo].[Tbl_type] OFF
GO
USE [master]
GO
ALTER DATABASE [BookStoreDatabase] SET  READ_WRITE 
GO

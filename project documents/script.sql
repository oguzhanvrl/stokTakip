USE [master]
GO
/****** Object:  Database [StokDB]    Script Date: 12/27/2018 11:23:24 PM ******/
CREATE DATABASE [StokDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StokDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\StokDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'StokDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\StokDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [StokDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StokDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StokDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StokDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StokDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StokDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StokDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [StokDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StokDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StokDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StokDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StokDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StokDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StokDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StokDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StokDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StokDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StokDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StokDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StokDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StokDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StokDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StokDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StokDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StokDB] SET RECOVERY FULL 
GO
ALTER DATABASE [StokDB] SET  MULTI_USER 
GO
ALTER DATABASE [StokDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StokDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StokDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StokDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [StokDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'StokDB', N'ON'
GO
USE [StokDB]
GO
/****** Object:  Table [dbo].[AtikKontrol]    Script Date: 12/27/2018 11:23:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AtikKontrol](
	[atikID] [int] NOT NULL,
	[atikAktif] [bit] NULL,
	[zimmetID] [int] NULL,
	[atikNot] [nvarchar](max) NULL,
	[atikAdet] [int] NULL,
 CONSTRAINT [PK_AtikKontrol] PRIMARY KEY CLUSTERED 
(
	[atikID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bolumler]    Script Date: 12/27/2018 11:23:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bolumler](
	[bolumID] [int] NOT NULL,
	[bolumAdi] [nvarchar](50) NULL,
	[bolumSefID] [int] NULL,
 CONSTRAINT [PK_Bolumler] PRIMARY KEY CLUSTERED 
(
	[bolumID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Islemler]    Script Date: 12/27/2018 11:23:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Islemler](
	[islemID] [int] NOT NULL,
	[islemTurID] [int] NULL,
	[perID] [int] NULL,
	[islemRefID] [int] NULL,
	[islemTarih] [date] NULL,
 CONSTRAINT [PK_Islemler] PRIMARY KEY CLUSTERED 
(
	[islemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[IslemTur]    Script Date: 12/27/2018 11:23:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IslemTur](
	[islemTurID] [int] NOT NULL,
	[islemTuru] [nvarchar](50) NULL,
	[islemTurBilgi] [nvarchar](max) NULL,
 CONSTRAINT [PK_IslemTur] PRIMARY KEY CLUSTERED 
(
	[islemTurID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 12/27/2018 11:23:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[perID] [int] NOT NULL,
	[kullaniciAdi] [nvarchar](50) NULL,
	[kullaniciSifre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[perID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Personel]    Script Date: 12/27/2018 11:23:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[perID] [int] NOT NULL,
	[perIsim] [nvarchar](100) NULL,
	[perTCNo] [nvarchar](11) NULL,
	[perTipID] [int] NULL,
	[bolumID] [int] NULL,
	[perAktif] [bit] NULL,
	[perIseGiris] [date] NULL,
	[perIsCikis] [date] NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[perID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PersonelTip]    Script Date: 12/27/2018 11:23:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonelTip](
	[perTipID] [int] NOT NULL,
	[perTipAdi] [nvarchar](50) NULL,
 CONSTRAINT [PK_PersonelTip] PRIMARY KEY CLUSTERED 
(
	[perTipID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SatinAlma]    Script Date: 12/27/2018 11:23:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SatinAlma](
	[saID] [int] NOT NULL,
	[urunID] [int] NULL,
	[saTarih] [date] NULL,
	[perID] [int] NULL,
	[saBirimFiyat] [money] NULL,
	[saAdet] [int] NULL,
	[saTedarikciFirma] [nvarchar](max) NULL,
 CONSTRAINT [PK_SatinAlma] PRIMARY KEY CLUSTERED 
(
	[saID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Stok]    Script Date: 12/27/2018 11:23:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stok](
	[stokID] [int] NOT NULL,
	[stokAktif] [bit] NULL,
	[urunID] [int] NULL,
	[stokAdet] [int] NULL,
 CONSTRAINT [PK_Stok] PRIMARY KEY CLUSTERED 
(
	[stokID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Urunler]    Script Date: 12/27/2018 11:23:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urunler](
	[urunID] [int] NOT NULL,
	[urunBilgi] [nvarchar](50) NULL,
	[urunOzellik] [nvarchar](max) NULL,
	[urunTurID] [int] NULL,
 CONSTRAINT [PK_Urunler] PRIMARY KEY CLUSTERED 
(
	[urunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UrunTur]    Script Date: 12/27/2018 11:23:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UrunTur](
	[urunTurID] [int] NOT NULL,
	[urunTurAdi] [nvarchar](100) NULL,
 CONSTRAINT [PK_UrunTur] PRIMARY KEY CLUSTERED 
(
	[urunTurID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Zimmet]    Script Date: 12/27/2018 11:23:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zimmet](
	[zimmetID] [int] NOT NULL,
	[zimmetAktif] [bit] NULL,
	[urunID] [int] NULL,
	[perID] [int] NULL,
	[zimmetTarih] [date] NULL,
	[zimmetAdet] [int] NULL,
 CONSTRAINT [PK_Zimmet] PRIMARY KEY CLUSTERED 
(
	[zimmetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[AtikKontrol] ([atikID], [atikAktif], [zimmetID], [atikNot], [atikAdet]) VALUES (120, 1, 111, N'hatalı', 50)
INSERT [dbo].[AtikKontrol] ([atikID], [atikAktif], [zimmetID], [atikNot], [atikAdet]) VALUES (220, 1, 411, N'bozuk', 20)
INSERT [dbo].[AtikKontrol] ([atikID], [atikAktif], [zimmetID], [atikNot], [atikAdet]) VALUES (320, 1, 611, N'kötü', 250)
INSERT [dbo].[AtikKontrol] ([atikID], [atikAktif], [zimmetID], [atikNot], [atikAdet]) VALUES (420, 1, 511, N'hatalı', 10)
INSERT [dbo].[Bolumler] ([bolumID], [bolumAdi], [bolumSefID]) VALUES (10, N'Yazılım', 300)
INSERT [dbo].[Bolumler] ([bolumID], [bolumAdi], [bolumSefID]) VALUES (20, N'Muhasebe', 500)
INSERT [dbo].[Bolumler] ([bolumID], [bolumAdi], [bolumSefID]) VALUES (30, N'Ambar', 600)
INSERT [dbo].[Bolumler] ([bolumID], [bolumAdi], [bolumSefID]) VALUES (40, N'İnsan Kaynakları', 700)
INSERT [dbo].[Bolumler] ([bolumID], [bolumAdi], [bolumSefID]) VALUES (50, N'Pazarlama', 800)
INSERT [dbo].[Kullanici] ([perID], [kullaniciAdi], [kullaniciSifre]) VALUES (100, N'admin', N'123456789')
INSERT [dbo].[Kullanici] ([perID], [kullaniciAdi], [kullaniciSifre]) VALUES (200, N'user', N'987654321')
INSERT [dbo].[Kullanici] ([perID], [kullaniciAdi], [kullaniciSifre]) VALUES (300, N'sef', N'123123123')
INSERT [dbo].[Kullanici] ([perID], [kullaniciAdi], [kullaniciSifre]) VALUES (500, N'sef1', N'123123123')
INSERT [dbo].[Kullanici] ([perID], [kullaniciAdi], [kullaniciSifre]) VALUES (600, N'sef2', N'123123123')
INSERT [dbo].[Kullanici] ([perID], [kullaniciAdi], [kullaniciSifre]) VALUES (700, N'sef3', N'123123123')
INSERT [dbo].[Kullanici] ([perID], [kullaniciAdi], [kullaniciSifre]) VALUES (800, N'sef4', N'123123123')
INSERT [dbo].[Kullanici] ([perID], [kullaniciAdi], [kullaniciSifre]) VALUES (1500, N'mur', N'12345678')
INSERT [dbo].[Personel] ([perID], [perIsim], [perTCNo], [perTipID], [bolumID], [perAktif], [perIseGiris], [perIsCikis]) VALUES (100, N'Ahmet', N'11111111111', 1, 10, 1, CAST(N'2018-12-24' AS Date), NULL)
INSERT [dbo].[Personel] ([perID], [perIsim], [perTCNo], [perTipID], [bolumID], [perAktif], [perIseGiris], [perIsCikis]) VALUES (200, N'Mehmet', N'22222222222', 2, 10, 1, CAST(N'2018-12-24' AS Date), NULL)
INSERT [dbo].[Personel] ([perID], [perIsim], [perTCNo], [perTipID], [bolumID], [perAktif], [perIseGiris], [perIsCikis]) VALUES (300, N'Hasan', N'33333333333', 3, 10, 1, CAST(N'2018-12-24' AS Date), NULL)
INSERT [dbo].[Personel] ([perID], [perIsim], [perTCNo], [perTipID], [bolumID], [perAktif], [perIseGiris], [perIsCikis]) VALUES (400, N'Hüseyin', N'44444444444', 4, 20, 1, CAST(N'2018-12-24' AS Date), NULL)
INSERT [dbo].[Personel] ([perID], [perIsim], [perTCNo], [perTipID], [bolumID], [perAktif], [perIseGiris], [perIsCikis]) VALUES (500, N'Cem', N'55555555555', 3, 20, 1, CAST(N'2018-12-24' AS Date), NULL)
INSERT [dbo].[Personel] ([perID], [perIsim], [perTCNo], [perTipID], [bolumID], [perAktif], [perIseGiris], [perIsCikis]) VALUES (600, N'Can', N'66666666666', 3, 30, 1, CAST(N'2018-12-24' AS Date), NULL)
INSERT [dbo].[Personel] ([perID], [perIsim], [perTCNo], [perTipID], [bolumID], [perAktif], [perIseGiris], [perIsCikis]) VALUES (700, N'Mahmut', N'77777777777', 3, 40, 1, CAST(N'2018-12-24' AS Date), NULL)
INSERT [dbo].[Personel] ([perID], [perIsim], [perTCNo], [perTipID], [bolumID], [perAktif], [perIseGiris], [perIsCikis]) VALUES (800, N'Gamze', N'88888888888', 3, 50, 1, CAST(N'2018-12-24' AS Date), NULL)
INSERT [dbo].[Personel] ([perID], [perIsim], [perTCNo], [perTipID], [bolumID], [perAktif], [perIseGiris], [perIsCikis]) VALUES (900, N'Gülçin', N'99999999999', 4, 20, 1, CAST(N'2018-12-24' AS Date), NULL)
INSERT [dbo].[Personel] ([perID], [perIsim], [perTCNo], [perTipID], [bolumID], [perAktif], [perIseGiris], [perIsCikis]) VALUES (1000, N'Fatma', N'11111111110', 4, 30, 1, CAST(N'2018-12-24' AS Date), NULL)
INSERT [dbo].[Personel] ([perID], [perIsim], [perTCNo], [perTipID], [bolumID], [perAktif], [perIseGiris], [perIsCikis]) VALUES (1100, N'Nurdan', N'22222222220', 4, 40, 1, CAST(N'2018-12-24' AS Date), NULL)
INSERT [dbo].[Personel] ([perID], [perIsim], [perTCNo], [perTipID], [bolumID], [perAktif], [perIseGiris], [perIsCikis]) VALUES (1200, N'Hatice', N'33333333330', 4, 50, 1, CAST(N'2018-12-24' AS Date), NULL)
INSERT [dbo].[Personel] ([perID], [perIsim], [perTCNo], [perTipID], [bolumID], [perAktif], [perIseGiris], [perIsCikis]) VALUES (1300, N'oguzhan', N'44444444440', 1, 10, 0, CAST(N'2018-12-24' AS Date), CAST(N'2018-12-26' AS Date))
INSERT [dbo].[Personel] ([perID], [perIsim], [perTCNo], [perTipID], [bolumID], [perAktif], [perIseGiris], [perIsCikis]) VALUES (1400, N'tarık', N'44444444488', 4, 40, 1, CAST(N'2018-12-25' AS Date), NULL)
INSERT [dbo].[Personel] ([perID], [perIsim], [perTCNo], [perTipID], [bolumID], [perAktif], [perIseGiris], [perIsCikis]) VALUES (1500, N'murat', N'12345678912', 2, 30, 1, CAST(N'2018-12-27' AS Date), NULL)
INSERT [dbo].[PersonelTip] ([perTipID], [perTipAdi]) VALUES (1, N'Yönetici')
INSERT [dbo].[PersonelTip] ([perTipID], [perTipAdi]) VALUES (2, N'Satın Alma Görevlisi')
INSERT [dbo].[PersonelTip] ([perTipID], [perTipAdi]) VALUES (3, N'Bölüm Şefi')
INSERT [dbo].[PersonelTip] ([perTipID], [perTipAdi]) VALUES (4, N'Personel')
INSERT [dbo].[SatinAlma] ([saID], [urunID], [saTarih], [perID], [saBirimFiyat], [saAdet], [saTedarikciFirma]) VALUES (10, 1000, CAST(N'2018-12-12' AS Date), 500, 4500.0000, 3, N'Anonim Şirket')
INSERT [dbo].[SatinAlma] ([saID], [urunID], [saTarih], [perID], [saBirimFiyat], [saAdet], [saTedarikciFirma]) VALUES (11, 1200, CAST(N'2018-12-15' AS Date), 600, 6500.0000, 5, N'Anonim Şirket')
INSERT [dbo].[SatinAlma] ([saID], [urunID], [saTarih], [perID], [saBirimFiyat], [saAdet], [saTedarikciFirma]) VALUES (12, 1000, CAST(N'2018-12-15' AS Date), 500, 4500.0000, 50, N'Anonim Şirket')
INSERT [dbo].[SatinAlma] ([saID], [urunID], [saTarih], [perID], [saBirimFiyat], [saAdet], [saTedarikciFirma]) VALUES (13, 1000, CAST(N'2018-12-17' AS Date), 700, 4500.0000, 5, N'Anonim Şirket')
INSERT [dbo].[SatinAlma] ([saID], [urunID], [saTarih], [perID], [saBirimFiyat], [saAdet], [saTedarikciFirma]) VALUES (14, 1300, CAST(N'2018-12-18' AS Date), 800, 752.0000, 10, N'Tedarikçi Firma')
INSERT [dbo].[SatinAlma] ([saID], [urunID], [saTarih], [perID], [saBirimFiyat], [saAdet], [saTedarikciFirma]) VALUES (15, 1400, CAST(N'2018-12-19' AS Date), 500, 3555.0000, 30, N'Anonim Şirket')
INSERT [dbo].[SatinAlma] ([saID], [urunID], [saTarih], [perID], [saBirimFiyat], [saAdet], [saTedarikciFirma]) VALUES (16, 1500, CAST(N'2018-12-19' AS Date), 500, 452.0000, 20, N'Anonim Şirket')
INSERT [dbo].[SatinAlma] ([saID], [urunID], [saTarih], [perID], [saBirimFiyat], [saAdet], [saTedarikciFirma]) VALUES (17, 1600, CAST(N'2018-12-19' AS Date), 400, 7523.0000, 40, N'Anonim Şirket')
INSERT [dbo].[SatinAlma] ([saID], [urunID], [saTarih], [perID], [saBirimFiyat], [saAdet], [saTedarikciFirma]) VALUES (18, 1700, CAST(N'2018-12-20' AS Date), 300, 123.0000, 60, N'Anonim Şirket')
INSERT [dbo].[SatinAlma] ([saID], [urunID], [saTarih], [perID], [saBirimFiyat], [saAdet], [saTedarikciFirma]) VALUES (19, 1800, CAST(N'2018-12-22' AS Date), 500, 42.0000, 10, N'Anonim Şirket')
INSERT [dbo].[SatinAlma] ([saID], [urunID], [saTarih], [perID], [saBirimFiyat], [saAdet], [saTedarikciFirma]) VALUES (20, 1300, CAST(N'2018-12-24' AS Date), 700, 760.0000, 2, N'Anonim Şirket')
INSERT [dbo].[SatinAlma] ([saID], [urunID], [saTarih], [perID], [saBirimFiyat], [saAdet], [saTedarikciFirma]) VALUES (21, 1900, CAST(N'2018-12-24' AS Date), 500, 150.0000, 60, N'Anonim Şirket')
INSERT [dbo].[SatinAlma] ([saID], [urunID], [saTarih], [perID], [saBirimFiyat], [saAdet], [saTedarikciFirma]) VALUES (121, 1600, CAST(N'2018-12-19' AS Date), 100, 7800.0000, 11, N'Tedarikçi Firma')
INSERT [dbo].[Stok] ([stokID], [stokAktif], [urunID], [stokAdet]) VALUES (10, 1, 1000, 55613)
INSERT [dbo].[Stok] ([stokID], [stokAktif], [urunID], [stokAdet]) VALUES (20, 1, 1100, 3)
INSERT [dbo].[Stok] ([stokID], [stokAktif], [urunID], [stokAdet]) VALUES (30, 1, 1200, 10)
INSERT [dbo].[Stok] ([stokID], [stokAktif], [urunID], [stokAdet]) VALUES (40, 1, 1300, 12)
INSERT [dbo].[Stok] ([stokID], [stokAktif], [urunID], [stokAdet]) VALUES (50, 1, 1400, 30)
INSERT [dbo].[Stok] ([stokID], [stokAktif], [urunID], [stokAdet]) VALUES (60, 1, 1500, 8)
INSERT [dbo].[Stok] ([stokID], [stokAktif], [urunID], [stokAdet]) VALUES (70, 1, 1600, 91)
INSERT [dbo].[Stok] ([stokID], [stokAktif], [urunID], [stokAdet]) VALUES (80, 1, 1700, 60)
INSERT [dbo].[Stok] ([stokID], [stokAktif], [urunID], [stokAdet]) VALUES (90, 1, 1800, 10)
INSERT [dbo].[Stok] ([stokID], [stokAktif], [urunID], [stokAdet]) VALUES (100, 1, 1900, 60)
INSERT [dbo].[Stok] ([stokID], [stokAktif], [urunID], [stokAdet]) VALUES (200, 0, 2100, 50)
INSERT [dbo].[Stok] ([stokID], [stokAktif], [urunID], [stokAdet]) VALUES (300, 0, 2200, 0)
INSERT [dbo].[Urunler] ([urunID], [urunBilgi], [urunOzellik], [urunTurID]) VALUES (1000, N'asus notebook', N'asdasfafasafasfafasfasf', 100)
INSERT [dbo].[Urunler] ([urunID], [urunBilgi], [urunOzellik], [urunTurID]) VALUES (1100, N'lenovo notebook', N'asdasfafasafasfafasfasf', 100)
INSERT [dbo].[Urunler] ([urunID], [urunBilgi], [urunOzellik], [urunTurID]) VALUES (1200, N'azer mouse', N'asdasfafasafasfafasfasf', 700)
INSERT [dbo].[Urunler] ([urunID], [urunBilgi], [urunOzellik], [urunTurID]) VALUES (1300, N'hp monitör', N'asdasfafasafasfafasfasf', 200)
INSERT [dbo].[Urunler] ([urunID], [urunBilgi], [urunOzellik], [urunTurID]) VALUES (1400, N'asus anakart', N'asdasfafasafasfafasfasf', 400)
INSERT [dbo].[Urunler] ([urunID], [urunBilgi], [urunOzellik], [urunTurID]) VALUES (1500, N'intel i7 işlemci', N'asdasfafasafasfafasfasf', 500)
INSERT [dbo].[Urunler] ([urunID], [urunBilgi], [urunOzellik], [urunTurID]) VALUES (1600, N'microsoft win10', N'asdasfafasafasfafasfasf', 600)
INSERT [dbo].[Urunler] ([urunID], [urunBilgi], [urunOzellik], [urunTurID]) VALUES (1700, N'razor klavye', N'asdasfafasafasfafasfasf', 300)
INSERT [dbo].[Urunler] ([urunID], [urunBilgi], [urunOzellik], [urunTurID]) VALUES (1800, N'msi notebook', N'asdasfafasafasfafasfasf', 100)
INSERT [dbo].[Urunler] ([urunID], [urunBilgi], [urunOzellik], [urunTurID]) VALUES (1900, N'toshiba kasa', N'kasa yeni', 800)
INSERT [dbo].[Urunler] ([urunID], [urunBilgi], [urunOzellik], [urunTurID]) VALUES (2000, N'iphone 6s', N'32 gb space gray2', 600)
INSERT [dbo].[Urunler] ([urunID], [urunBilgi], [urunOzellik], [urunTurID]) VALUES (2100, N'16 gb ram', N'DDR4 1600mhz ram', 802)
INSERT [dbo].[Urunler] ([urunID], [urunBilgi], [urunOzellik], [urunTurID]) VALUES (2200, N'razor klavye', N'asdasfafasafasfafasfasf', 300)
INSERT [dbo].[UrunTur] ([urunTurID], [urunTurAdi]) VALUES (100, N'Notebook')
INSERT [dbo].[UrunTur] ([urunTurID], [urunTurAdi]) VALUES (200, N'Monitör')
INSERT [dbo].[UrunTur] ([urunTurID], [urunTurAdi]) VALUES (300, N'Klavye')
INSERT [dbo].[UrunTur] ([urunTurID], [urunTurAdi]) VALUES (400, N'Anakart')
INSERT [dbo].[UrunTur] ([urunTurID], [urunTurAdi]) VALUES (500, N'İşlemci')
INSERT [dbo].[UrunTur] ([urunTurID], [urunTurAdi]) VALUES (600, N'İşletim Sistemi')
INSERT [dbo].[UrunTur] ([urunTurID], [urunTurAdi]) VALUES (700, N'Mouse')
INSERT [dbo].[UrunTur] ([urunTurID], [urunTurAdi]) VALUES (800, N'Kasa')
INSERT [dbo].[UrunTur] ([urunTurID], [urunTurAdi]) VALUES (801, N'telefon')
INSERT [dbo].[UrunTur] ([urunTurID], [urunTurAdi]) VALUES (802, N'Ram')
INSERT [dbo].[Zimmet] ([zimmetID], [zimmetAktif], [urunID], [perID], [zimmetTarih], [zimmetAdet]) VALUES (111, 1, 1100, 500, CAST(N'2018-12-12' AS Date), 10)
INSERT [dbo].[Zimmet] ([zimmetID], [zimmetAktif], [urunID], [perID], [zimmetTarih], [zimmetAdet]) VALUES (211, 1, 1500, 700, CAST(N'2018-12-15' AS Date), 17)
INSERT [dbo].[Zimmet] ([zimmetID], [zimmetAktif], [urunID], [perID], [zimmetTarih], [zimmetAdet]) VALUES (311, 1, 1400, 600, CAST(N'2018-12-16' AS Date), 5)
INSERT [dbo].[Zimmet] ([zimmetID], [zimmetAktif], [urunID], [perID], [zimmetTarih], [zimmetAdet]) VALUES (411, 1, 1200, 400, CAST(N'2018-12-18' AS Date), 15)
INSERT [dbo].[Zimmet] ([zimmetID], [zimmetAktif], [urunID], [perID], [zimmetTarih], [zimmetAdet]) VALUES (511, 1, 1500, 800, CAST(N'2018-12-24' AS Date), 7)
INSERT [dbo].[Zimmet] ([zimmetID], [zimmetAktif], [urunID], [perID], [zimmetTarih], [zimmetAdet]) VALUES (611, 1, 1500, 900, CAST(N'2018-12-24' AS Date), 8)
USE [master]
GO
ALTER DATABASE [StokDB] SET  READ_WRITE 
GO

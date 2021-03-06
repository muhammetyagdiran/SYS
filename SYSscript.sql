USE [SYS]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 26.11.2021 15:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SporcuBilgiler]    Script Date: 26.11.2021 15:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SporcuBilgiler](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](50) NULL,
	[Soyad] [varchar](50) NULL,
	[DogumYeri] [varchar](50) NULL,
	[DogumTarihi] [varchar](50) NULL,
	[EvTelefon] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[EvAdresi] [varchar](250) NULL,
	[KanGrubu] [varchar](50) NULL,
	[Boy] [int] NULL,
	[Kilo] [int] NULL,
	[OkuduguOkul] [varchar](250) NULL,
 CONSTRAINT [PK_SporcuBilgiler] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211114123718_InitialCreate', N'5.0.12')
GO
SET IDENTITY_INSERT [dbo].[SporcuBilgiler] ON 

INSERT [dbo].[SporcuBilgiler] ([id], [Ad], [Soyad], [DogumYeri], [DogumTarihi], [EvTelefon], [email], [EvAdresi], [KanGrubu], [Boy], [Kilo], [OkuduguOkul]) VALUES (1, N'Muhammet', N'Yağdıran', N'Balıkesir', N'1997', NULL, NULL, NULL, NULL, 0, 0, NULL)
INSERT [dbo].[SporcuBilgiler] ([id], [Ad], [Soyad], [DogumYeri], [DogumTarihi], [EvTelefon], [email], [EvAdresi], [KanGrubu], [Boy], [Kilo], [OkuduguOkul]) VALUES (2, N'Erdem ', N'Bozkır', N'İzmir', N'1998', NULL, NULL, NULL, NULL, 0, 0, NULL)
INSERT [dbo].[SporcuBilgiler] ([id], [Ad], [Soyad], [DogumYeri], [DogumTarihi], [EvTelefon], [email], [EvAdresi], [KanGrubu], [Boy], [Kilo], [OkuduguOkul]) VALUES (3, N'Deneme', N'Kayıt', N'Ankara', N'1997', NULL, NULL, NULL, NULL, 0, 0, NULL)
INSERT [dbo].[SporcuBilgiler] ([id], [Ad], [Soyad], [DogumYeri], [DogumTarihi], [EvTelefon], [email], [EvAdresi], [KanGrubu], [Boy], [Kilo], [OkuduguOkul]) VALUES (4, N'aaaa', N'bbbb', N'sbds', N'sdfsdf', NULL, NULL, NULL, NULL, 0, 0, NULL)
INSERT [dbo].[SporcuBilgiler] ([id], [Ad], [Soyad], [DogumYeri], [DogumTarihi], [EvTelefon], [email], [EvAdresi], [KanGrubu], [Boy], [Kilo], [OkuduguOkul]) VALUES (5, N'asdasd', N'dsfasdf', N'asdfasdf', N'adsfasdf', NULL, NULL, NULL, NULL, 0, 0, NULL)
INSERT [dbo].[SporcuBilgiler] ([id], [Ad], [Soyad], [DogumYeri], [DogumTarihi], [EvTelefon], [email], [EvAdresi], [KanGrubu], [Boy], [Kilo], [OkuduguOkul]) VALUES (6, N'SGDSFG', N'SDFGSDFG', N'SDFGSDFG', N'SDFGSDFG', NULL, NULL, NULL, NULL, 346, 346, NULL)
INSERT [dbo].[SporcuBilgiler] ([id], [Ad], [Soyad], [DogumYeri], [DogumTarihi], [EvTelefon], [email], [EvAdresi], [KanGrubu], [Boy], [Kilo], [OkuduguOkul]) VALUES (7, N'Serkan', N'Berker', N'Balıkesir', N'2000', NULL, NULL, NULL, NULL, 60, 160, NULL)
INSERT [dbo].[SporcuBilgiler] ([id], [Ad], [Soyad], [DogumYeri], [DogumTarihi], [EvTelefon], [email], [EvAdresi], [KanGrubu], [Boy], [Kilo], [OkuduguOkul]) VALUES (8, N'asfsg', N'gdfg', N'dfgdfg', N'dfgdfg', NULL, NULL, NULL, NULL, 45, 45, NULL)
SET IDENTITY_INSERT [dbo].[SporcuBilgiler] OFF
GO

USE [ButceTakipDB]
GO
/****** Object:  Table [dbo].[Islem]    Script Date: 30.12.2021 09:18:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Islem](
	[islemID] [int] IDENTITY(1,1) NOT NULL,
	[islemTurID] [int] NULL,
	[aciklama] [nvarchar](500) NULL,
	[tutar] [money] NULL,
	[tarih] [smalldatetime] NULL,
	[kullaniciID] [int] NULL,
 CONSTRAINT [PK_Islem] PRIMARY KEY CLUSTERED 
(
	[islemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IslemTur]    Script Date: 30.12.2021 09:18:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IslemTur](
	[islemTurID] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NULL,
 CONSTRAINT [PK_IslemTur] PRIMARY KEY CLUSTERED 
(
	[islemTurID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 30.12.2021 09:18:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[kullaniciID] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL,
	[eposta] [nvarchar](50) NULL,
	[sifre] [nvarchar](50) NULL,
	[yetkiID] [int] NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[kullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yetki]    Script Date: 30.12.2021 09:18:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yetki](
	[yetkiID] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nchar](10) NULL,
 CONSTRAINT [PK_Yetki] PRIMARY KEY CLUSTERED 
(
	[yetkiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Islem]  WITH CHECK ADD  CONSTRAINT [FK_Islem_IslemTur] FOREIGN KEY([islemTurID])
REFERENCES [dbo].[IslemTur] ([islemTurID])
GO
ALTER TABLE [dbo].[Islem] CHECK CONSTRAINT [FK_Islem_IslemTur]
GO
ALTER TABLE [dbo].[Islem]  WITH CHECK ADD  CONSTRAINT [FK_Islem_Kullanici] FOREIGN KEY([kullaniciID])
REFERENCES [dbo].[Kullanici] ([kullaniciID])
GO
ALTER TABLE [dbo].[Islem] CHECK CONSTRAINT [FK_Islem_Kullanici]
GO
ALTER TABLE [dbo].[Kullanici]  WITH CHECK ADD  CONSTRAINT [FK_Kullanici_Yetki] FOREIGN KEY([yetkiID])
REFERENCES [dbo].[Yetki] ([yetkiID])
GO
ALTER TABLE [dbo].[Kullanici] CHECK CONSTRAINT [FK_Kullanici_Yetki]
GO

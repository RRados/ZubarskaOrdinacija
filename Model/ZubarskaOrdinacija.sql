USE [master]
GO

CREATE DATABASE [ZubarskaOrdinacija]

USE [ZubarskaOrdinacija]
GO

CREATE TABLE [dbo].[Gradovi]
(
	[IDGrad] [int] IDENTITY(1,1) NOT NULL,
	[NazivGrada] [nvarchar](50) NULL,
	CONSTRAINT [PK_Gradovi] PRIMARY KEY CLUSTERED 
	(
			[IDGrad] ASC 
			)
			WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, 
			OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
			) 
			ON [PRIMARY]
) 
ON [PRIMARY]

CREATE TABLE [dbo].[IzvrseniPregledi](
	[IDIzvrseniPregledi] [int] NOT NULL,
	[FK_Pacijent] [int] NOT NULL,
	[FK_Lekar] [int] NOT NULL,
	[FK_Usluga] [int] NULL,
	[Datum] [date] NOT NULL,
	[Anamneza] [nvarchar](max) NOT NULL,
	[Dijagnoza] [nvarchar](max) NOT NULL,
	[CenaPregleda] [decimal](18, 2) NOT NULL,
	CONSTRAINT [PK_IzvrseniPregledi] PRIMARY KEY CLUSTERED 
	(
		[IDIzvrseniPregledi] ASC
		)
		WITH (PAD_INDEX = OFF, 
		STATISTICS_NORECOMPUTE = OFF, 
		IGNORE_DUP_KEY = OFF, 
		ALLOW_ROW_LOCKS = ON, 
		ALLOW_PAGE_LOCKS = ON, 
		OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
		) 
		ON [PRIMARY]
) 
ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

CREATE TABLE [dbo].[Lekari](
	[IDLekar] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [nvarchar](50) NULL,
	[Prezime] [nvarchar](50) NULL,
	[Telefon] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[FK_Grad] [int] NULL,
	CONSTRAINT [PK_Lekari] PRIMARY KEY CLUSTERED 
	(
		[IDLekar] ASC
		)
		WITH (
			PAD_INDEX = OFF, 
			STATISTICS_NORECOMPUTE = OFF, 
			IGNORE_DUP_KEY = OFF, 
			ALLOW_ROW_LOCKS = ON, 
			ALLOW_PAGE_LOCKS = ON, 
			OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
			) 
			ON [PRIMARY]
) 
ON [PRIMARY]

CREATE TABLE [dbo].[Pacijenti](
	[IDPacijent] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [nvarchar](50) NOT NULL,
	[Prezime] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Telefon] [nvarchar](50) NOT NULL,
	[FK_Grad] [int] NOT NULL,
	CONSTRAINT [PK_Pacijent] PRIMARY KEY CLUSTERED 
(
	[IDPacijent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Usluge](
	[ID_Usluga] [int] IDENTITY(1,1) NOT NULL,
	[NazivUsluge] [nvarchar](50) NULL,
 CONSTRAINT [PK_Usluge] PRIMARY KEY CLUSTERED 
(
	[ID_Usluga] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Zakazivanje]
(
	[IDZakazivanje] [int] IDENTITY(1,1) NOT NULL,
	[FK_Pacijent] [int] NOT NULL,
	[FK_Lekar] [int] NOT NULL,
	[DatumIVremeDolaska] [datetime] NOT NULL,
	[ZastoPacijentDolazi] [nvarchar](max) NOT NULL,
	CONSTRAINT [PK_Zakazivanje] PRIMARY KEY CLUSTERED 
(
	[IDZakazivanje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

SET IDENTITY_INSERT [dbo].[Gradovi] ON 
INSERT [dbo].[Gradovi] ([IDGrad], [NazivGrada]) VALUES (1, N'Nis')
INSERT [dbo].[Gradovi] ([IDGrad], [NazivGrada]) VALUES (2, N'Beograd')
INSERT [dbo].[Gradovi] ([IDGrad], [NazivGrada]) VALUES (3, N'Pristina')
INSERT [dbo].[Gradovi] ([IDGrad], [NazivGrada]) VALUES (4, N'Novi Sad')
INSERT [dbo].[Gradovi] ([IDGrad], [NazivGrada]) VALUES (5, N'Pirot')
INSERT [dbo].[Gradovi] ([IDGrad], [NazivGrada]) VALUES (6, N'Loznica')
INSERT [dbo].[Gradovi] ([IDGrad], [NazivGrada]) VALUES (7, N'Sremska Mitrovica')
INSERT [dbo].[Gradovi] ([IDGrad], [NazivGrada]) VALUES (8, N'Kraljevo')
INSERT [dbo].[Gradovi] ([IDGrad], [NazivGrada]) VALUES (9, N'Kragujevac')
INSERT [dbo].[Gradovi] ([IDGrad], [NazivGrada]) VALUES (10, N'Leskovac')
INSERT [dbo].[Gradovi] ([IDGrad], [NazivGrada]) VALUES (11, N'Arandjelovac')
SET IDENTITY_INSERT [dbo].[Gradovi] OFF

SET IDENTITY_INSERT [dbo].[Lekari] ON 
INSERT [dbo].[Lekari] ([IDLekar], [Ime], [Prezime], [Telefon], [Email], [FK_Grad]) VALUES (1, N'Danijela', N'Rajcic', N'234432322', N'drNela@dr.com', 3)
INSERT [dbo].[Lekari] ([IDLekar], [Ime], [Prezime], [Telefon], [Email], [FK_Grad]) VALUES (2, N'Ankica', N'Milenkovic', N'234442343', N'drAnka@dr.com', 4)
INSERT [dbo].[Lekari] ([IDLekar], [Ime], [Prezime], [Telefon], [Email], [FK_Grad]) VALUES (3, N'Aleksandra', N'Miljkovic', N'1828851', N'alexm@dr.com', 1)
INSERT [dbo].[Lekari] ([IDLekar], [Ime], [Prezime], [Telefon], [Email], [FK_Grad]) VALUES (4, N'Branko', N'Mihajlovic', N'11 244 09 01', N'kontakt@ordinacijadentan.rs', 3)
INSERT [dbo].[Lekari] ([IDLekar], [Ime], [Prezime], [Telefon], [Email], [FK_Grad]) VALUES (5, N'Miodrag', N'Scepanovic', N'11 24 52 192', N'ordinacija@a1dentalstudio.rs', 3)
INSERT [dbo].[Lekari] ([IDLekar], [Ime], [Prezime], [Telefon], [Email], [FK_Grad]) VALUES (6, N'Mica', N'Rajcic', N'65 2123 287', N'no-do-dent@mica.rs', 3)
SET IDENTITY_INSERT [dbo].[Lekari] OFF

SET IDENTITY_INSERT [dbo].[Pacijenti] ON 
INSERT [dbo].[Pacijenti] ([IDPacijent], [Ime], [Prezime], [Email], [Telefon], [FK_Grad]) VALUES (1, N'Rados', N'Rajcic', N'rados6320@its.edu.rs', N'621828851', 1)
SET IDENTITY_INSERT [dbo].[Pacijenti] OFF

SET IDENTITY_INSERT [dbo].[Usluge] ON 
INSERT [dbo].[Usluge] ([ID_Usluga], [NazivUsluge]) VALUES (1, N'ORALNA HIRURGIJA')
INSERT [dbo].[Usluge] ([ID_Usluga], [NazivUsluge]) VALUES (2, N'STOMATOLOŠKA PROTETIKA')
INSERT [dbo].[Usluge] ([ID_Usluga], [NazivUsluge]) VALUES (3, N'ESTETSKA STOMATOLOGIJA')
INSERT [dbo].[Usluge] ([ID_Usluga], [NazivUsluge]) VALUES (4, N'KONZERVATIVNA STOMATOLOGIJA')
INSERT [dbo].[Usluge] ([ID_Usluga], [NazivUsluge]) VALUES (5, N'PARADONTOLOGIJA I LASERSKA TERAPIJA')
INSERT [dbo].[Usluge] ([ID_Usluga], [NazivUsluge]) VALUES (6, N'PREVENTIVNA STOMATOLOGIJA')
INSERT [dbo].[Usluge] ([ID_Usluga], [NazivUsluge]) VALUES (7, N'BELJENJE ZUBA')
INSERT [dbo].[Usluge] ([ID_Usluga], [NazivUsluge]) VALUES (8, N'ANTIAGE METODE')
INSERT [dbo].[Usluge] ([ID_Usluga], [NazivUsluge]) VALUES (9, N'ENDODONCIJA')
INSERT [dbo].[Usluge] ([ID_Usluga], [NazivUsluge]) VALUES (10, N'CISTEKOTOMIJA')
INSERT [dbo].[Usluge] ([ID_Usluga], [NazivUsluge]) VALUES (11, N'APIKOTOMIJA')
INSERT [dbo].[Usluge] ([ID_Usluga], [NazivUsluge]) VALUES (12, N'FRENEKTOMIJA')
GO

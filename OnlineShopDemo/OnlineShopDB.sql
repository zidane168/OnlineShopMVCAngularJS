USE [OnlineShop]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 7/1/2018 6:10:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [varchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 7/1/2018 6:10:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Alias] [nvarchar](50) NULL,
	[ParentID] [int] NULL,
	[CreateDate] [datetime] NULL,
	[IsOder] [int] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Category1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 7/1/2018 6:10:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Alias] [varchar](50) NULL,
	[CategoryID] [int] NULL,
	[Images] [nvarchar](250) NULL,
	[CreateDate] [datetime] NULL,
	[Price] [decimal](18, 0) NULL,
	[Detail] [ntext] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Product_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Account] ([UserName], [Password]) VALUES (N'admin', N'123123')
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([ID], [Name], [Alias], [ParentID], [CreateDate], [IsOder], [Status]) VALUES (1, N'Moive Hero', N'phim-viet-hero', 1, CAST(N'2018-06-30T12:39:33.480' AS DateTime), 0, 1)
INSERT [dbo].[Category] ([ID], [Name], [Alias], [ParentID], [CreateDate], [IsOder], [Status]) VALUES (2, N'Movie Hài', N'phim-viet-hay', 1, CAST(N'2018-06-30T12:39:55.320' AS DateTime), 0, 1)
INSERT [dbo].[Category] ([ID], [Name], [Alias], [ParentID], [CreateDate], [IsOder], [Status]) VALUES (3, N'Travelling Canada Guild', N'du-lich-canada', 2, CAST(N'2018-06-30T12:41:09.203' AS DateTime), 0, 1)
INSERT [dbo].[Category] ([ID], [Name], [Alias], [ParentID], [CreateDate], [IsOder], [Status]) VALUES (4, N'Listenning Titanic music', N'nghe-nhac', 3, CAST(N'2018-06-30T12:41:52.820' AS DateTime), 0, 1)
INSERT [dbo].[Category] ([ID], [Name], [Alias], [ParentID], [CreateDate], [IsOder], [Status]) VALUES (5, N'Shopping Lotte', N'mua-sam-hay', 4, CAST(N'2018-06-30T12:42:11.567' AS DateTime), 0, 1)
INSERT [dbo].[Category] ([ID], [Name], [Alias], [ParentID], [CreateDate], [IsOder], [Status]) VALUES (6, N'Travlling Đà Lạt', N'du-lich-data', 3, CAST(N'2018-06-30T12:42:27.170' AS DateTime), 0, 1)
INSERT [dbo].[Category] ([ID], [Name], [Alias], [ParentID], [CreateDate], [IsOder], [Status]) VALUES (7, N'Playing Hero Game', N'choi-game-hro', 5, CAST(N'2018-06-30T12:42:52.020' AS DateTime), 0, 1)
INSERT [dbo].[Category] ([ID], [Name], [Alias], [ParentID], [CreateDate], [IsOder], [Status]) VALUES (8, N'abc', N'1212', NULL, CAST(N'2018-07-12T17:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[Category] ([ID], [Name], [Alias], [ParentID], [CreateDate], [IsOder], [Status]) VALUES (9, N'anhlaai', N'and as', NULL, CAST(N'2018-07-11T17:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[Category] ([ID], [Name], [Alias], [ParentID], [CreateDate], [IsOder], [Status]) VALUES (10, N'thémmmem', N'hello', NULL, CAST(N'1904-03-11T17:17:56.000' AS DateTime), NULL, 1)
INSERT [dbo].[Category] ([ID], [Name], [Alias], [ParentID], [CreateDate], [IsOder], [Status]) VALUES (11, N'them', N'1', NULL, CAST(N'1984-04-11T17:00:00.000' AS DateTime), NULL, 1)
SET IDENTITY_INSERT [dbo].[Category] OFF
ALTER TABLE [dbo].[Category] ADD  CONSTRAINT [DF_Category1_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Category] ADD  CONSTRAINT [DF_Category1_IsOder]  DEFAULT ((0)) FOR [IsOder]
GO
ALTER TABLE [dbo].[Category] ADD  CONSTRAINT [DF_Category1_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  StoredProcedure [dbo].[uspAccountLogin]    Script Date: 7/1/2018 6:10:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[uspAccountLogin]
	@username varchar(50),
	@password varchar(50)
AS
Begin
	DECLARE @count int
	DECLARE @result bit

	SELECT @count = count (*) from ACCOUNT WHERE UserName = @username and Password = @password

	SET @result = 0
	if (@count > 0)
		SET @result = 1	

	SELECT @result

End
GO
/****** Object:  StoredProcedure [dbo].[uspGetAllCategory]    Script Date: 7/1/2018 6:10:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[uspGetAllCategory]
AS

SELECT * FROM Category WHERE STATUS = 1
ORDER BY IsOder ASC
GO

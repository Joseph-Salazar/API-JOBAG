USE [Sigone2]
GO
/****** Object:  Table [dbo].[Audits]    Script Date: 19/09/2022 11:28:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Audits](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TableName] [nvarchar](50) NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[KeyValues] [nvarchar](max) NULL,
	[OldValues] [nvarchar](max) NULL,
	[NewValues] [nvarchar](max) NULL,
	[User] [varchar](50) NULL,
 CONSTRAINT [PK_Audits] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 19/09/2022 11:28:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](300) NOT NULL,
	[LastName] [varchar](300) NOT NULL,
	[State] [int] NOT NULL
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 19/09/2022 11:28:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[State] [int] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](50) NOT NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [nvarchar](50) NULL
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 19/09/2022 11:28:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PersonId] [int] NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](500) NOT NULL,		
	[Email] [nvarchar](300) NOT NULL,
	[RecoveryCode] [char](6) NULL,
	[State] [int] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](50) NOT NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [nvarchar](50) NULL
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRole]    Script Date: 19/09/2022 11:28:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRole](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[RoleId] [int] NOT NULL
 CONSTRAINT [PK_RolUsuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Master]    Script Date: 17/02/2022 04:55:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Master](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Key] [varchar](30) NOT NULL,
	[Description] [varchar](500) NOT NULL,
 CONSTRAINT [PK_Master] PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MasterDetail]    Script Date: 17/02/2022 04:55:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MasterDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MasterId] [int] NOT NULL,
	[Key] [varchar](100) NOT NULL,
	[Value] [varchar](max) NOT NULL,
	[Description] [varchar](500) NOT NULL,
	[State] [int] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](50) NOT NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [nvarchar](50) NULL
 CONSTRAINT [PK_MasterDetail] PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 26/09/2022 05:38:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Url] [nvarchar](200) NULL,
	[Icon] [nvarchar](50) NULL,
	[Order] [int] NOT NULL,
	[MenuParentId] [int] NULL,
	[State] [int] NOT NULL
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MenuAction]    Script Date: 26/09/2022 05:38:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuAction](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MenuId] [int] NOT NULL,	
	[Code] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
	[State] [int] NOT NULL
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permission]    Script Date: 26/09/2022 05:38:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleMenuAction](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NOT NULL,
	[MenuActionId] [int] NOT NULL
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 26/09/2022 05:38:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SubFamilyId] [int] NOT NULL,
	[TypeId] [int] NOT NULL,
	[BrandId] [int] NOT NULL,
	[AdditionalFeatureId] [int] NOT NULL,
	[Code] [nvarchar](20) NOT NULL,
	[ShortName] [nvarchar](250) NOT NULL,
	[Name] [nvarchar](500) NOT NULL,
	[Description] [nvarchar](2000) NOT NULL,
	[AffectedToStock] [bit] NOT NULL,
	[Ean] [nvarchar](50) NOT NULL,
	[FileImageName] [nvarchar](50) NOT NULL,
	[CutTypeId] [int] NULL,
	[UnitMeasureId] [int] NULL,
	[DurationTypeId] [int] NULL,
	[Duration] [int] NULL,
	[Quantity] [int] NULL,
	[Tagged] [bit] NOT NULL,
	[Sticker] [bit] NOT NULL,
	[State] [int] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](50) NOT NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [nvarchar](50) NULL
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Person_Id] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Person_Id]
GO
ALTER TABLE [dbo].[UserRole]  WITH CHECK ADD  CONSTRAINT [FK_UserRole_Role_Id] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([Id])
GO
ALTER TABLE [dbo].[UserRole] CHECK CONSTRAINT [FK_UserRole_Role_Id]
GO
ALTER TABLE [dbo].[UserRole]  WITH CHECK ADD  CONSTRAINT [FK_UserRole_User_Id] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[UserRole] CHECK CONSTRAINT [FK_UserRole_User_Id]
GO
ALTER TABLE [dbo].[MasterDetail]  WITH CHECK ADD  CONSTRAINT [FK_MasterDetail_Master_Id] FOREIGN KEY([MasterId])
REFERENCES [dbo].[Master] ([Id])
GO
ALTER TABLE [dbo].[MasterDetail] CHECK CONSTRAINT [FK_MasterDetail_Master_Id]
GO

ALTER TABLE [dbo].[Menu]  WITH CHECK ADD FOREIGN KEY([MenuParentId])
REFERENCES [dbo].[Menu] ([Id])
GO
ALTER TABLE [dbo].[MenuAction]  WITH CHECK ADD FOREIGN KEY([MenuId])
REFERENCES [dbo].[Menu] ([Id])
GO
ALTER TABLE [dbo].[RoleMenuAction]  WITH CHECK ADD FOREIGN KEY([MenuActionId])
REFERENCES [dbo].[MenuAction] ([Id])
GO
ALTER TABLE [dbo].[RoleMenuAction]  WITH CHECK ADD FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([Id])
GO

ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([SubFamilyId])
REFERENCES [dbo].[Family] ([Id])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([TypeId])
REFERENCES [dbo].[MasterDetail] ([Id])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([BrandId])
REFERENCES [dbo].[MasterDetail] ([Id])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([AdditionalFeatureId])
REFERENCES [dbo].[MasterDetail] ([Id])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([CutTypeId])
REFERENCES [dbo].[MasterDetail] ([Id])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([UnitMeasureId])
REFERENCES [dbo].[MasterDetail] ([Id])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([DurationTypeId])
REFERENCES [dbo].[MasterDetail] ([Id])
GO
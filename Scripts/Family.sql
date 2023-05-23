USE [Sigone2]
GO

/****** Object:  Table [dbo].[Family]    Script Date: 07/10/2022 16:33:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Family](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Code] [nvarchar](10) NOT NULL,
	[Description] [nvarchar](200) NULL,
	[Level] [int] NULL,
	[FamilyParentId] [int] NULL,
	[State] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Family] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Family]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Family_dbo.Family_FamilyParentId] FOREIGN KEY([FamilyParentId])
REFERENCES [dbo].[Family] ([Id])
GO

ALTER TABLE [dbo].[Family] CHECK CONSTRAINT [FK_dbo.Family_dbo.Family_FamilyParentId]
GO



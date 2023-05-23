USE [Sigone2]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Carrier](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[DocumentType] [int] NOT NULL,
	[Email] [nvarchar](100) NULL,
	[PhoneNumber] [nvarchar](100) NULL,
	[Region] [nvarchar](20) NOT NULL,
	[Document] [nvarchar](11) NOT NULL,
	[License] [nvarchar](50) NOT NULL,
	[Province] [nvarchar](11) NOT NULL,
	[District] [nvarchar](20) NOT NULL,
	[UbigeoId] [int] NOT NULL,
	[State] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Carrier] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Carrier]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Carrier_dbo.Ubigeo_UbigeoId] FOREIGN KEY([UbigeoId])
REFERENCES [dbo].[Ubigeo] ([Id])
GO

ALTER TABLE [dbo].[Carrier] CHECK CONSTRAINT [FK_dbo.Carrier_dbo.Ubigeo_UbigeoId]
GO


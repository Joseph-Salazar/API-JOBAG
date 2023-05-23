USE [Sigone2]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CarrierUnit](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LicensePlate] [nvarchar](50) NOT NULL,
	[Model] [nvarchar](50) NOT NULL,
	[Brand] [nvarchar](50) NOT NULL,
	[CarrierId] [int] NULL,
	[State] [int] NOT NULL,
 CONSTRAINT [PK_dbo.CarrierUnit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CarrierUnit]  WITH CHECK ADD  CONSTRAINT [FK_dbo.CarrierUnit_dbo.Carrier_CarrierId] FOREIGN KEY([CarrierId])
REFERENCES [dbo].[Carrier] ([Id])
GO

ALTER TABLE [dbo].[CarrierUnit] CHECK CONSTRAINT [FK_dbo.CarrierUnit_dbo.Carrier_CarrierId]
GO



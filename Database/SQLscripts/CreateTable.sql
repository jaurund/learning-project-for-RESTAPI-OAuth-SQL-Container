USE [csvNetflixDB]
GO

/****** Object:  Table [dbo].[NetflixDataset]    Script Date: 27. aug 2025 13:36:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[NetflixDataset](
	[Show_Id] [nvarchar](50) NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](600) NOT NULL,
	[Director] [nvarchar](600) NULL,
	[Cast] [varchar](max) NULL,
	[Country] [nvarchar](600) NULL,
	[Release_Date] [date] NULL,
	[Rating] [nvarchar](50) NULL,
	[Duration] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](250) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO



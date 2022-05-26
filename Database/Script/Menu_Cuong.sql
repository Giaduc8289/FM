USE [FM]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 05/26/2022 08:51:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[MenuId] [nvarchar](20) NOT NULL,
	[MenuName] [nvarchar](500) NULL,
	[Icon] [nvarchar](500) NULL,
	[Issudung] [int] NULL,
	[Istrangthai] [int] NULL,
	[Menuparent] [nvarchar](50) NULL,
	[Thutu] [int] NULL,
	[FormName] [nvarchar](1000) NULL,
	[LoaiMenu] [int] NULL,
	[Param] [nvarchar](500) NULL,
	[Maphanhe] [nvarchar](50) NULL,
 CONSTRAINT [Menu_PK] PRIMARY KEY CLUSTERED 
(
	[MenuId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

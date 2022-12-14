USE [Potager]
GO
/****** Object:  Table [dbo].[Legumes]    Script Date: 16/01/2016 13:23:55 ******/
DROP TABLE [dbo].[Legumes]
GO
/****** Object:  Table [dbo].[Legumes]    Script Date: 16/01/2016 13:23:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Legumes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](255) NOT NULL,
 CONSTRAINT [PK_Legumes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Legumes] ON 

INSERT [dbo].[Legumes] ([id], [name]) VALUES (1, N'Tomate                                                                                                                                                                                                                                                         ')
INSERT [dbo].[Legumes] ([id], [name]) VALUES (2, N'Poireau                                                                                                                                                                                                                                                        ')
SET IDENTITY_INSERT [dbo].[Legumes] OFF

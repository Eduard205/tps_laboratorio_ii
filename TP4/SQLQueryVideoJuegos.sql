CREATE DATABASE [LISTA_VIDEOJUEGOS]
GO
USE [LISTA_VIDEOJUEGOS]
GO
/****** Object:  Table [dbo].[VideoJuegos]    Script Date: 19/06/2022 1:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VideoJuegos](
	[NombreVideoJuego] [varchar](25) NOT NULL,
	[NombreVideoConsola] [varchar](25) NOT NULL,
	[Precio] [float] NOT NULL,
	[Stock] [int] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[VideoJuegos] ([NombreVideoJuego], [NombreVideoConsola], [Precio], [Stock]) VALUES (N'Mortal Kombat', N'PS4', 10000, 10)
GO
INSERT [dbo].[VideoJuegos] ([NombreVideoJuego], [NombreVideoConsola], [Precio], [Stock]) VALUES (N'Pokemon Lets Go Pikachu', N'NintendoSwitch', 12000, 5)
GO
INSERT [dbo].[VideoJuegos] ([NombreVideoJuego], [NombreVideoConsola], [Precio], [Stock]) VALUES (N'Battlefield 3', N'Xbox', 8000, 10)
GO
INSERT [dbo].[VideoJuegos] ([NombreVideoJuego], [NombreVideoConsola], [Precio], [Stock]) VALUES (N'FIFA 22', N'PS5', 15000, 8)
GO
INSERT [dbo].[VideoJuegos] ([NombreVideoJuego], [NombreVideoConsola], [Precio], [Stock]) VALUES (N'Horizon Forbidden West', N'PS5', 15000, 5)
GO
INSERT [dbo].[VideoJuegos] ([NombreVideoJuego], [NombreVideoConsola], [Precio], [Stock]) VALUES (N'Pokemon Sword', N'NintendoSwitch', 11000, 12)
GO
INSERT [dbo].[VideoJuegos] ([NombreVideoJuego], [NombreVideoConsola], [Precio], [Stock]) VALUES (N'Pokemon Arceus', N'NintendoSwitch', 13000, 4)
GO
INSERT [dbo].[VideoJuegos] ([NombreVideoJuego], [NombreVideoConsola], [Precio], [Stock]) VALUES (N'Mario Odyssey', N'NintendoSwitch', 9000, 7)
GO
INSERT [dbo].[VideoJuegos] ([NombreVideoJuego], [NombreVideoConsola], [Precio], [Stock]) VALUES (N'Minecraft', N'PS4', 7000, 5)
GO
INSERT [dbo].[VideoJuegos] ([NombreVideoJuego], [NombreVideoConsola], [Precio], [Stock]) VALUES (N'Dragonball Fighter Z', N'PS4', 8500, 6)
GO

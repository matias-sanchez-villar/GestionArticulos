USE [Catalogo_DB]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 3/5/2021 02:15:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 3/5/2021 02:15:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 3/5/2021 02:15:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [char](5) NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](150) NOT NULL,
	[IDMarca] [int] NOT NULL,
	[IDCategoria] [int] NOT NULL,
	[URLimagen] [varchar](350) NULL,
	[Precio] [money] NOT NULL,
	[Cantidad] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categorias] ON 

INSERT [dbo].[Categorias] ([ID], [Nombre]) VALUES (1, N'Smartphones')
INSERT [dbo].[Categorias] ([ID], [Nombre]) VALUES (2, N'Notebooks')
INSERT [dbo].[Categorias] ([ID], [Nombre]) VALUES (3, N'Monitors')
INSERT [dbo].[Categorias] ([ID], [Nombre]) VALUES (4, N'Tablets')
INSERT [dbo].[Categorias] ([ID], [Nombre]) VALUES (5, N'Smartwatch')
INSERT [dbo].[Categorias] ([ID], [Nombre]) VALUES (6, N'TV')
INSERT [dbo].[Categorias] ([ID], [Nombre]) VALUES (7, N'Desktop PC')
SET IDENTITY_INSERT [dbo].[Categorias] OFF
GO
SET IDENTITY_INSERT [dbo].[Marcas] ON 

INSERT [dbo].[Marcas] ([ID], [Nombre]) VALUES (1, N'Apple')
INSERT [dbo].[Marcas] ([ID], [Nombre]) VALUES (2, N'OnePlus')
INSERT [dbo].[Marcas] ([ID], [Nombre]) VALUES (3, N'Xiaomi')
INSERT [dbo].[Marcas] ([ID], [Nombre]) VALUES (4, N'Samsung')
INSERT [dbo].[Marcas] ([ID], [Nombre]) VALUES (5, N'Sony')
INSERT [dbo].[Marcas] ([ID], [Nombre]) VALUES (6, N'Huawei')
SET IDENTITY_INSERT [dbo].[Marcas] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([ID], [Codigo], [Nombre], [Descripcion], [IDMarca], [IDCategoria], [URLimagen], [Precio], [Cantidad]) VALUES (1, N'A100 ', N'OnePlus 9 Pro', N'The best OnePlus in the market, never settle', 2, 1, N'https://www.notebookcheck.org/fileadmin/Notebooks/News/_nc3/OnePlus_9_Pro_Pine_Green.png', 999.0000, 50)
INSERT [dbo].[Producto] ([ID], [Codigo], [Nombre], [Descripcion], [IDMarca], [IDCategoria], [URLimagen], [Precio], [Cantidad]) VALUES (2, N'B100 ', N'iPhone 12 Pro Max', N'Apple''s last iPhone to break the market.', 1, 1, N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSPIue8RhdCK3nYTAJIrb56eHqXh-cWQNfHSsO88LwBOz7zZt_rZtFXrMbbKlM8AW7KCYWzPPab&usqp=CAc', 1100.0000, 10)
INSERT [dbo].[Producto] ([ID], [Codigo], [Nombre], [Descripcion], [IDMarca], [IDCategoria], [URLimagen], [Precio], [Cantidad]) VALUES (4, N'B200 ', N'MacBook Pro M1', N'MacBook Pro M1 Mid 2020', 1, 2, N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQY1mARNDMioyZ16N3z9_YKdu6pynCdFBqAKYUj_RVRotFUWrhS7U1D_Z5RKz9sM8ZGlWijG2s&usqp=CAc', 1300.0000, 4)
INSERT [dbo].[Producto] ([ID], [Codigo], [Nombre], [Descripcion], [IDMarca], [IDCategoria], [URLimagen], [Precio], [Cantidad]) VALUES (15, N'S100 ', N'Samsung Galaxy S20 Ultra ', N'The newest Samsung Galaxy in the Galaxy ', 4, 1, N' https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRs19G_0HjuJJ7dVb-eI5S4NSUzp1ptc7AKhgbjgE4GqMz8z5NfaxXq3od7rg&usqp=CAc ', 850.0000, 6)
INSERT [dbo].[Producto] ([ID], [Codigo], [Nombre], [Descripcion], [IDMarca], [IDCategoria], [URLimagen], [Precio], [Cantidad]) VALUES (17, N' A200', N'OnePlus Watch ', N'The best fvcking watch you can buy for x-mas ', 2, 1, N' https://www.virtualizados.net/wp-content/uploads/2021/03/oneplus-watch-01.jpg ', 120.0000, 6)
INSERT [dbo].[Producto] ([ID], [Codigo], [Nombre], [Descripcion], [IDMarca], [IDCategoria], [URLimagen], [Precio], [Cantidad]) VALUES (18, N' S200', N' Galaxy Z Fold 2 ', N' The new foldable phone ', 4, 1, N'https://cdn.computerhoy.com/sites/navi.axelspringer.es/public/styles/main_card_image/https/bdt.computerhoy.com/sites/default/files/fold%25202.png?itok=hhYF5UGa', 2200.0000, 1)
INSERT [dbo].[Producto] ([ID], [Codigo], [Nombre], [Descripcion], [IDMarca], [IDCategoria], [URLimagen], [Precio], [Cantidad]) VALUES (19, N' C420', N'Click here Maxi', N' There are no nudes here', 1, 1, N' https://i.pinimg.com/originals/f0/85/2b/f0852ba7e229b2cb518032719b48e6e5.gif ', 666.0000, 1)
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Producto__06370DAC73D9C1C8]    Script Date: 3/5/2021 02:15:20 ******/
ALTER TABLE [dbo].[Producto] ADD UNIQUE NONCLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD FOREIGN KEY([IDCategoria])
REFERENCES [dbo].[Categorias] ([ID])
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD FOREIGN KEY([IDMarca])
REFERENCES [dbo].[Marcas] ([ID])
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD CHECK  (([Cantidad]>(0)))
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD CHECK  (([Precio]>(0)))
GO

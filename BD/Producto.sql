create database Catalogo_DB
go
use Catalogo_DB
go
create table Categorias(
	ID int not null primary key identity(1,1),
	Nombre varchar(50) not null,
)
go
create table Marcas(
	ID int not null primary key identity(1,1),
	Nombre varchar(50) not null,
)
go
Create table Producto(
	ID int not null primary key identity(1,1),
	Codigo char(5) NULL unique,
	Nombre varchar(50) not null,
	Descripcion varchar(350) not null,
	IDMarca int foreign key references Marcas(ID) not null,
	IDCategoria int foreign key references Categorias(ID) not null,
	URLimagen varchar(1000) null,
	Precio money not null check(Precio > 0),
	Cantidad int null check(Cantidad > 0)
)

--Categorias
INSERT Categorias (Nombre) VALUES ('Smartphones')
INSERT Categorias (Nombre) VALUES ('Notebooks')
INSERT Categorias (Nombre) VALUES ('Monitors')
INSERT Categorias (Nombre) VALUES ('Tablets')
INSERT Categorias (Nombre) VALUES ('Smartwatch')
INSERT Categorias (Nombre) VALUES ('TV')
INSERT Categorias (Nombre) VALUES ('Desktop PC')


--Marcas
INSERT Marcas (Nombre) VALUES ('Apple')
INSERT Marcas (Nombre) VALUES ('OnePlus')
INSERT Marcas (Nombre) VALUES ('Xiaomi')
INSERT Marcas (Nombre) VALUES ('Samsung')
INSERT Marcas (Nombre) VALUES ('Sony')
INSERT Marcas (Nombre) VALUES ('Huawei')

--Productos
INSERT Producto (Codigo, Nombre, Descripcion, IDMarca, IDCategoria, URLimagen, Precio, Cantidad) VALUES ('A100', 'OnePlus 9 Pro', 'The best OnePlus in the market, never settle', 2, 1, 'https://www.notebookcheck.org/fileadmin/Notebooks/News/_nc3/OnePlus_9_Pro_Pine_Green.png', 999.000, 50)

INSERT Producto (Codigo, Nombre, Descripcion, IDMarca, IDCategoria, URLimagen, Precio, Cantidad) VALUES ('B100', 'iPhone 12 Pro Max', 'Apple''s last iPhone to break the market.', 1, 1, 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSPIue8RhdCK3nYTAJIrb56eHqXh-cWQNfHSsO88LwBOz7zZt_rZtFXrMbbKlM8AW7KCYWzPPab&usqp=CAc', 1100.000, 10)

INSERT Producto (Codigo, Nombre, Descripcion, IDMarca, IDCategoria, URLimagen, Precio, Cantidad) VALUES ('B200', 'MacBook Pro M1', 'MacBook Pro M1 Mid 2020', 1, 2, N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQY1mARNDMioyZ16N3z9_YKdu6pynCdFBqAKYUj_RVRotFUWrhS7U1D_Z5RKz9sM8ZGlWijG2s&usqp=CAc', 1300.000, 4)

INSERT Producto (Codigo, Nombre, Descripcion, IDMarca, IDCategoria, URLimagen, Precio, Cantidad) VALUES ('S100', 'Samsung Galaxy S20 Ultra', 'The newest Samsung Galaxy in the Galaxy', 4, 1, ' https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRs19G_0HjuJJ7dVb-eI5S4NSUzp1ptc7AKhgbjgE4GqMz8z5NfaxXq3od7rg&usqp=CAc ', 850.000, 6)

INSERT Producto (Codigo, Nombre, Descripcion, IDMarca, IDCategoria, URLimagen, Precio, Cantidad) VALUES ('A200', 'OnePlus Watch', 'The best fvcking watch you can buy for x-mas', 2, 1, ' https://www.virtualizados.net/wp-content/uploads/2021/03/oneplus-watch-01.jpg ', 120.000, 6)

INSERT Producto (Codigo, Nombre, Descripcion, IDMarca, IDCategoria, URLimagen, Precio, Cantidad) VALUES ('S200', 'Galaxy Z Fold 2', 'The new foldable phone', 4, 1, 'https://cdn.computerhoy.com/sites/navi.axelspringer.es/public/styles/main_card_image/https/bdt.computerhoy.com/sites/default/files/fold%25202.png?itok=hhYF5UGa', 2200.000, 1)

INSERT Producto (Codigo, Nombre, Descripcion, IDMarca, IDCategoria, URLimagen, Precio, Cantidad) VALUES ('C420', 'Samsung Galaxy A01', 1, 1, 'El Samsung A01 Core posee el novedoso sistema operativo Android 10 que incorpora respuestas inteligentes y acciones sugeridas para todas tus aplicaciones. Entre sus diversas funcionalidades encontrarás el tema oscuro, navegación por gestos y modo sin distracciones, para que completes tus tareas mientras disfrutás al máximo tu dispositivo.', 1, 1, 'https://http2.mlstatic.com/D_NQ_NP_814600-MLA43772081185_102020-O.webp', 15.000, 16)

INSERT Producto (Codigo, Nombre, Descripcion, IDMarca, IDCategoria, URLimagen, Precio, Cantidad) VALUES ('CP02', 'Nokia 23 M 32 GB gris carbón 2 GB RAM', 1, 1, 'El Nokia 23 M posee el novedoso sistema operativo Android 10 que incorpora respuestas inteligentes y acciones sugeridas para todas tus aplicaciones. Entre sus diversas funcionalidades encontrarás el tema oscuro, navegación por gestos y modo sin distracciones, para que completes tus tareas mientras disfrutás al máximo tu dispositivo.', 1, 1, 'https://http2.mlstatic.com/D_NQ_NP_828063-MLA44280741156_122020-O.webp', 12.000, 33)

INSERT Producto (Codigo, Nombre, Descripcion, IDMarca, IDCategoria, URLimagen, Precio, Cantidad) VALUES ('HC20', 'LG K22 32 GB blue 2 GB RAM', 1, 1, 'El LG K22 posee el novedoso sistema operativo Android 10 que incorpora respuestas inteligentes y acciones sugeridas para todas tus aplicaciones. Entre sus diversas funcionalidades encontrarás el tema oscuro, navegación por gestos y modo sin distracciones, para que completes tus tareas mientras disfrutás al máximo tu dispositivo.', 1, 1, 'https://http2.mlstatic.com/D_NQ_NP_836391-MLA44123219615_112020-O.webp', 5.000, 1)

INSERT Producto (Codigo, Nombre, Descripcion, IDMarca, IDCategoria, URLimagen, Precio, Cantidad) VALUES ('CE20', 'Samsung Galaxy A02 32 GB negro 2 GB RAM', 1, 1, 'El Samsung A02 posee el novedoso sistema operativo Android 10 que incorpora respuestas inteligentes y acciones sugeridas para todas tus aplicaciones. Entre sus diversas funcionalidades encontrarás el tema oscuro, navegación por gestos y modo sin distracciones, para que completes tus tareas mientras disfrutás al máximo tu dispositivo.', 1, 1, 'https://http2.mlstatic.com/D_NQ_NP_748880-MLA45509953525_042021-O.webp', 12.000, 1)

INSERT Producto (Codigo, Nombre, Descripcion, IDMarca, IDCategoria, URLimagen, Precio, Cantidad) VALUES ('CQ20', 'Sansei S191 Dual SIM 3 MB negro/rojo 4 MB RAM', 1, 1, 'Si buscás un dispositivo que te permita estar en contacto siempre, este teléfono S191 es una opción excelente. Vas a poder comunicarte de manera inmediata con amigas y amigos, o con las personas de tu familia. Y además, si estás trabajando, vas a alcanzar una mayor colaboración con tu equipo.', 1, 1, 'https://http2.mlstatic.com/D_NQ_NP_896790-MLA44547132275_012021-O.webp', 6.000, 1)

INSERT Producto (Codigo, Nombre, Descripcion, IDMarca, IDCategoria, URLimagen, Precio, Cantidad) VALUES ('CQ20', 'Noblex N405 Dual SIM 8 GB negro 2 GB RAM', 1, 1, 'Su memoria RAM de 2 GB es justo lo que necesitás para utilizar las funciones más importantes como llamar, enviar mensajes, navegar y ejecutar aplicaciones de uso frecuente como redes sociales o multimedia.', 1, 1, 'https://http2.mlstatic.com/D_NQ_NP_626394-MLA44099561210_112020-O.webp', 2.000, 1)

INSERT Producto (Codigo, Nombre, Descripcion, IDMarca, IDCategoria, URLimagen, Precio, Cantidad) VALUES ('CQ20', 'Click here Maxi', 'There are no nudes here', 1, 1, ' https://i.pinimg.com/originals/f0/85/2b/f0852ba7e229b2cb518032719b48e6e5.gif ', 666.0000, 1)














































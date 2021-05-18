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
	Descripcion varchar(150) not null,
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
INSERT Producto (Codigo, Nombre, Descripcion, IDMarca, IDCategoria, URLimagen, Precio, Cantidad) VALUES ('A100', 'OnePlus 9 Pro', 'The best OnePlus in the market, never settle', 2, 1, 'https://www.notebookcheck.org/fileadmin/Notebooks/News/_nc3/OnePlus_9_Pro_Pine_Green.png', 999.0000, 50)
INSERT Producto (Codigo, Nombre, Descripcion, IDMarca, IDCategoria, URLimagen, Precio, Cantidad) VALUES ('B100', 'iPhone 12 Pro Max', 'Apple''s last iPhone to break the market.', 1, 1, 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSPIue8RhdCK3nYTAJIrb56eHqXh-cWQNfHSsO88LwBOz7zZt_rZtFXrMbbKlM8AW7KCYWzPPab&usqp=CAc', 1100.0000, 10)
INSERT Producto (Codigo, Nombre, Descripcion, IDMarca, IDCategoria, URLimagen, Precio, Cantidad) VALUES ('B200', 'MacBook Pro M1', 'MacBook Pro M1 Mid 2020', 1, 2, N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQY1mARNDMioyZ16N3z9_YKdu6pynCdFBqAKYUj_RVRotFUWrhS7U1D_Z5RKz9sM8ZGlWijG2s&usqp=CAc', 1300.0000, 4)
INSERT Producto (Codigo, Nombre, Descripcion, IDMarca, IDCategoria, URLimagen, Precio, Cantidad) VALUES ('S100', 'Samsung Galaxy S20 Ultra', 'The newest Samsung Galaxy in the Galaxy', 4, 1, ' https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRs19G_0HjuJJ7dVb-eI5S4NSUzp1ptc7AKhgbjgE4GqMz8z5NfaxXq3od7rg&usqp=CAc ', 850.0000, 6)
INSERT Producto (Codigo, Nombre, Descripcion, IDMarca, IDCategoria, URLimagen, Precio, Cantidad) VALUES ('A200', 'OnePlus Watch', 'The best fvcking watch you can buy for x-mas', 2, 1, ' https://www.virtualizados.net/wp-content/uploads/2021/03/oneplus-watch-01.jpg ', 120.0000, 6)
INSERT Producto (Codigo, Nombre, Descripcion, IDMarca, IDCategoria, URLimagen, Precio, Cantidad) VALUES ('S200', 'Galaxy Z Fold 2', 'The new foldable phone', 4, 1, 'https://cdn.computerhoy.com/sites/navi.axelspringer.es/public/styles/main_card_image/https/bdt.computerhoy.com/sites/default/files/fold%25202.png?itok=hhYF5UGa', 2200.0000, 1)
INSERT Producto (Codigo, Nombre, Descripcion, IDMarca, IDCategoria, URLimagen, Precio, Cantidad) VALUES ('C420', 'Click here Maxi', 'There are no nudes here', 1, 1, ' https://i.pinimg.com/originals/f0/85/2b/f0852ba7e229b2cb518032719b48e6e5.gif ', 666.0000, 1)
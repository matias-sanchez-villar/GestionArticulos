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
	Codigo char(4) NULL,
	Nombre varchar(50) not null,
	Descripcion varchar(150) not null,
	IDMarca int foreign key references Marcas(ID) not null,
	IDCategoria int foreign key references Categorias(ID) not null,
	URLimagen varchar(1000) null,
	Precio money not null check(Precio > 0),
	Cantidad int null check(Cantidad > 0)
)


--Informacion contenida en la BD


--Consultas para el proyecto
select p.Codigo, M.Nombre as MarcaProducto, C.Nombre as CategoriaProducto, p.Nombre, p.Descripcion, p.Precio, P.Cantidad, P.URLimagen from Producto p
inner join Categorias C on c.ID = p.IDCartegoria
inner join Marcas M on M.ID = P.IDMarca

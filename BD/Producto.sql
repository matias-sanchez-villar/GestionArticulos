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
	IDCartegoria int foreign key references Categorias(ID) not null,
	URLimagen varchar(350) null,
	Precio money not null check(Precio > 0),
	Cantidad int null check(Cantidad > 0)
)

create database Producto
go
use Producto
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
Create table Productos(
	ID int not null primary key identity(1,1),
	Codigo varchar(50) NULL,
	Nombre varchar(50) not null,
	Descrepcion varchar(150) not null,
	IDMarca int foreign key references Marcas(ID) not null,
	IDCartegoria int foreign key references Categorias(ID) not null,
	URLimagen varchar(250) null,
	Precio money not null check(Precio>0),
	Cantidad bigint not null check(Cantidad>0),
)

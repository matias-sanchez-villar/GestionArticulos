create database Producto
go
use Producto
go
create table Categoria(
	ID int not null primary key identity(1,1),
	Nombre varchar(50) not null,
)
go
create table Marca(
	ID int not null primary key identity(1,1),
	Nombre varchar(50) not null,
)
go
Create table Producto(
	ID int not null primary key identity(1,1),
	Nombre varchar(50) not null,
	Descrepcion varchar(150) not null,
	IDMarca int foreign key references Marca(ID) not null,
	IDCartegoria int foreign key references Categoria(ID) not null,
	URLimagen varchar(150) null,
	Precio money not null check(Precio>0),
	Cantidad bigint not null check(Cantidad>0),
)
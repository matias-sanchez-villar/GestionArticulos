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

go

insert into Marcas values ('Samsung'), ('Apple'), ('Sony'), ('Huawei'), ('Motorola')
insert into Categorias values ('Celulares'),('Televisores'), ('Media'), ('Audio')
insert into Productos values ('S01', 'Galaxy S10', 'Una canoa cara', 1, 2, 'https://images.samsung.com/is/image/samsung/co-galaxy-s10-sm-g970-sm-g970fzyjcoo-frontcanaryyellow-thumb-149016542', 69.999, 15),
('M03', 'Moto G Play 7ma Gen', 'Ya siete de estos?', 1, 5, 'https://www.motorola.cl/arquivos/moto-g7-play-img-product.png?v=636862863804700000', 15699, 99),
('S99', 'Play 4', 'Ya no se cuantas versiones hay', 3, 3, 'https://www.euronics.cz/image/product/800x800/532620.jpg', 35000, 159),
('S56', 'Bravia 55', 'Alta tele', 3, 2, 'https://intercompras.com/product_thumb_keepratio_2.php?img=images/product/SONY_KDL-55W950A.jpg&w=650&h=450', 49500, 0),
('A23', 'Apple TV', 'lindo loro', 2, 3, 'https://cnnespanol2.files.wordpress.com/2015/12/gadgets-mc3a1s-populares-apple-tv-2015-18.jpg?quality=100&strip=info&w=460&h=260&crop=1', 7850, 24)


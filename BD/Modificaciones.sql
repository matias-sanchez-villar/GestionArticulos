Use Catalogo_DB
GO
Alter Table Producto
Alter Column Codigo char(5)
GO
Alter Table Producto
Alter Column URLImagen varchar(1000)
GO
Alter Table Producto
Add unique(codigo)
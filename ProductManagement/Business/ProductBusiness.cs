using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Business
{
    public class ProductBusiness
    {
        public List<Product> listProducts()
        {
            List<Product> list = new List<Product>();
            DataAccess access = new DataAccess();

            try
            {
                access.setQuery("select p.Codigo, p.Nombre, p.Descripcion, p.Precio, P.Cantidad, P.URLimagen, M.Nombre as MarcaProducto, C.Nombre as CategoriaProducto from Producto p inner join Categorias C on c.ID = p.IDCartegoria inner join Marcas M on M.ID = P.IDMarca");
                access.executeQuery();

                while (access.Reader.Read())
                {
                    Product productAux = new Product();

                    productAux.Code = (String) access.Reader["Codigo"];
                    productAux.Name=(String) access.Reader["Nombre"];
                    productAux.Description = (String) access.Reader["Descripcion"];
                    productAux.Price = (float) access.Reader["Precio"];
                    productAux.Quantity = (int) access.Reader["Cantidad"];
                    productAux.URLimage = (String) access.Reader["URLImagen"];
                    productAux.Brand = new Brand((string)access.Reader["MarcaProducto"]);
                    productAux.Category = new Category((string)access.Reader["CategoriaProducto"]);

                    list.Add(productAux);
                }
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                access.closeConnection();
            }
        }

    }
}

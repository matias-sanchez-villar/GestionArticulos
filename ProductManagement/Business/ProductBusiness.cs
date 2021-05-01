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
                access.setQuery("select p.ID ,p.Codigo, p.Nombre, p.Descripcion, p.Precio, P.Cantidad, P.URLimagen, M.Nombre as MarcaProducto, C.Nombre as CategoriaProducto from Producto p inner join Categorias C on c.ID = p.IDCategoria inner join Marcas M on M.ID = P.IDMarca order by p.Cantidad desc");
                access.executeQuery();

                while (access.Reader.Read())
                {
                    Product productAux = new Product();

                    productAux.Code = (String) access.Reader["Codigo"];
                    productAux.Name=(String) access.Reader["Nombre"];
                    productAux.Description = (String) access.Reader["Descripcion"];
                    productAux.Price = (decimal) access.Reader["Precio"];
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
        // Returns brand list for combo box
        public List<Brand> listBrands()
        {
            List<Brand> list = new List<Brand>();
            DataAccess access = new DataAccess();

            try
            {
                access.setQuery("Select ID, Nombre From Marcas");
                access.executeQuery();

                while (access.Reader.Read())
                {
                    list.Add(new Brand((string)access.Reader["Nombre"], (int)access.Reader["ID"]));
                }
                return list;
             }
            catch (Exception exc)
            {

                throw exc;
            }
            finally
            {
                access.closeConnection();
            }
        }
        // Returns Category list for combo box
        public List<Category> listCategory()
        {
            List<Category> list = new List<Category>();
            DataAccess access = new DataAccess();

            try
            {
                access.setQuery("Select ID, Nombre From Categorias");
                access.executeQuery();

                while (access.Reader.Read())
                {
                    list.Add(new Category((string)access.Reader["Nombre"], (int)access.Reader["ID"]));
                }
                return list;
            }
            catch (Exception exc)
            {

                throw exc;
            }
            finally
            {
                access.closeConnection();
            }
        }

        public void addProduct(Product productAdd)
        {
            DataAccess data = new DataAccess();
            //Product prodAux = new Product();

            try
            {
                //string values = $"values('{ productAdd.Code }', '{ productAdd.Name }', '{ productAdd.Description }', { productAdd.Brand.ID }" +
                //                $",{ productAdd.Category.ID },'{ productAdd.URLimage }',{ productAdd.Price },{ productAdd.Quantity })";
                string values = "values( ' " + productAdd.Code + " ' , ' "+ productAdd.Name + " ', ' " + productAdd.Description + " ', " + productAdd.Brand.ID + ", " + productAdd.Category.ID + ", ' " + productAdd.URLimage + " ', " + productAdd.Price + ", " + productAdd.Quantity + ")";
                data.setQuery("Insert into Producto (Codigo, Nombre, Descripcion, IDMarca, IDCategoria, URLimagen, Precio, Cantidad)" + values);
                data.executeAction();

            }
            catch (Exception exc)
            {
                throw exc;
            }
            finally
            {
                data.closeConnection();
            }
        }


        public void DeleteProduct(int ID)
        {
            DataAccess data = new DataAccess();

            try
            {
                data.setQuery("Delete From Producto Where Id =" + ID);
                data.executeAction();
            }
            catch (Exception exc)
            {
                throw exc;
            }
            finally
            {
                data.closeConnection();
            }
        }



    }
}

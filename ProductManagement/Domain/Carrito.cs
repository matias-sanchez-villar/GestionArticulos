using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Carrito
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public Carrito(Product aux)
        {
            this.Product = aux;
            Quantity = 1;
        }

        public void aumentar()
        {
            Quantity ++;
        }
        public void restar()
        {
            Quantity --;
        }


    }
}

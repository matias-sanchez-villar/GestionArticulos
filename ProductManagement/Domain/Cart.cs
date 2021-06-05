using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Cart
    {
        public Product product { get; set; }
        public float TotalPrice { get; set; }
        public int Quantity {
            get
            {
                return Quantity;
            }
            set
            {
                if (value > 0)
                {
                    /*
                        Si aumente la cantidad Automaticamente aumenta el precio total.
                     */
                    Quantity = value;
                    TotalPrice = ((float)product.Price * (float)Quantity);
                }
            }
        }


        /*
            Cuando se cree la cantidad sea igual a 1;
         */

        public Cart()
        {
            Quantity = 1;
        }

    }
}

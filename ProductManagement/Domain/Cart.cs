using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Cart
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
                    Quantity = value;
                    TotalPrice = ((float)product.Price * (float)Quantity);
                }
            }
        }

    }
}

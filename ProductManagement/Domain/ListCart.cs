using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ListCart
    {
        /*
            Esto la verdad no entiendo bien si esta bien o esta mal.
            No entiendo bien como funciona una lista.
            Yo creo que esta mal, pero lo que me gustaria hacer es,
            Poder pasarle una lista o un objeto carrito y que con un metodo (Setet, geter o pirulito),
            se encarge de, agregar el carrito si no existe o aumentar la cantidad.
        */
        public List<Cart> CartList { get; set; }


        /*
            Aguante la consola, no entendi nada, pero fue asi va a andar "CREO".
        */
        public void Modificar(Cart cart)
        {
            bool estado = false;
            foreach (var lista in CartList)
            {
                if (cart.product.ID == lista.product.ID)
                {
                    lista.Quantity ++;
                    estado = true;
                }
            }
            if (estado == false)
            {
                CartList.Add(cart);
            }
        }
    }
}

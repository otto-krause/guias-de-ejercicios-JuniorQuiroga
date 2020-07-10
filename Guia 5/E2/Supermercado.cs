using System.Collections.Generic;
using System.Linq;

namespace E2
{
    public class Supermercado
    {
        static List<Carrito> carritos = new List<Carrito>();

        public Supermercado(){
            Carrito c1 = new Carrito();
            carritos.Add(c1);
            Carrito c2 = new Carrito();
            carritos.Add(c2);
        }

        public static int Ganancias(){
            int total=0;

            foreach (Carrito carrito in carritos)
            {
                List<Producto> productos = carrito.getProductos;
                
                total += productos.Sum(i => i.Precio);
            }
            return total;
        }
    }
}
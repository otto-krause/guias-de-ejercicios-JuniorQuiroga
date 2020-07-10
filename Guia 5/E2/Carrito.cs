using System.Collections.Generic;

namespace E2
{
    public class Carrito
    {
        List<Producto> productos = new List<Producto>();

        public List<Producto> getProductos {get => productos;}

        public Carrito(){
            Producto p1 = new Producto("jabon",12);
            Producto p2 = new Producto("carne",60);
            Producto p3 = new Producto("gaseosa",20);
            productos.Add(p1);
            productos.Add(p2);
            productos.Add(p3);
        }
    }
}
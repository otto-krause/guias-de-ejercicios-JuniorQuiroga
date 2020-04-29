using System;

namespace E5
{
    public class Producto
    {
        string nombre;
        int precio;
        public int Precio {get => precio;}

        public Producto(string nombre,int precio){
            this.nombre=nombre;
            this.precio=precio;
        }
    }
}
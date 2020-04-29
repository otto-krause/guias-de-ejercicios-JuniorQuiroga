using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            Supermercado super = new Supermercado();
            Console.WriteLine("las ganancias totales del dia son: $"+Supermercado.Ganancias());
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
namespace E2
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

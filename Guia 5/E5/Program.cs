using System;
using System.Collections.Generic;
using System.Linq;

namespace E5
{
    class Program
    {
        public static void mostrar(List<string> lista){
            lista.ForEach(x => Console.WriteLine(x));
        }
        static void Main(string[] args)
        {
            List<string> aux = new List<string>();
            Persona p1 = new Persona();

            aux = p1.UltimosConocimientos();

            Console.WriteLine("sus ultimos conocimientos son: ");
            mostrar(aux);

            Console.WriteLine("\nsus primeros 4 conocimientos son: ");
            aux = p1.PrimerosConocimientos();
            mostrar(aux);

            Console.WriteLine("\ncantidad de conocimientos acabados en 'cion': ");
            aux = p1.Terminacion();
            mostrar(aux);
        }
    }
}

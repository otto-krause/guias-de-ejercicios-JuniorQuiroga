using System;
using System.Linq;
using System.Collections.Generic;

namespace E8
{
    class Program
    {
        public static void mostrar(List<int> resultados){
            resultados.ForEach(r => Console.WriteLine(r));
        }

        static void Main(string[] args)
        {
            List<int> A= new List<int>() {2,4,6,7,1,3};
            List<int> B= new List<int>() {7,1,3,5,7,6};
            List<int> resultados= new List<int>();
            Matematicas2 m = new Matematicas2(A,B);

            Console.WriteLine("Los numeros primos son:");
            resultados = m.Primos();
            mostrar(resultados);

            Console.WriteLine("Los numeros pares son:");
            resultados = m.Pares();
            mostrar(resultados);

            Console.WriteLine("Los numeros aplanados son:");
            resultados = m.Aplanar();
            mostrar(resultados);

            Console.WriteLine("La suma de todos los numeros da: "+m.Sumar());
            
            Console.WriteLine("Los numeros primos sumados dan: "+ m.Primos().Sum());

            Console.WriteLine("El mayor numero es: "+m.Maximo());
            Console.WriteLine("El menor numero es: "+m.Minimo());
        }
    }
}

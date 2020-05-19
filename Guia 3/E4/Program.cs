using System;
using System.Collections.Generic;

namespace E4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Tragalibros jose = new Tragalibros();
            string nombre;
            string autor;

            Libro l1 = new Libro("100 recetas con brocoli","Romulo III");
            Libro l2 = new Libro("100 formas de cocinar arroz","Romulo IV");
            jose.Leer(l1);
            jose.Leer(l2);

            Console.WriteLine("Ingrese el nombre del libro y el autor");
            nombre = Console.ReadLine();
            autor = Console.ReadLine();

            if(!jose.EsRepetido(nombre,autor)){
                Libro l3 = new Libro(nombre,autor);
                jose.Leer(l3);
            }
            else
            Console.WriteLine("Ya haz leido este libro");

            Console.WriteLine("su CI es de "+jose.CalcularCI());
        }
    }
}

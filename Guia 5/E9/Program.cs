using System;
using System.Collections.Generic;
using System.Linq;

namespace E9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            Console.WriteLine("ingrese numeros, cuando desee finalizar ingrese 0");

            do{
                numeros.Add(Int32.Parse(Console.ReadLine()));
            } while(numeros.Last()!=0);

            numeros= numeros.Take(numeros.Count-1).ToList();
            
            Console.WriteLine("se ingresaron estos nuemero:");
            numeros.ForEach(n => Console.WriteLine(n));
            Console.WriteLine("la cantidad de numeros impares es: "+numeros.Where(n => n%2!=0).ToList().Count);
            Console.WriteLine("el primer numero par es: "+numeros.Where(n => n%2==0).ToList().First());
            Console.WriteLine("estos son los numeros mayores a 50:");
            numeros.Where(n => n>50).ToList().ForEach(n => Console.WriteLine(n));
            Console.WriteLine("la cantidad de numeros mayores a 50 es: "+numeros.Where(n => n>50).ToList().Count);
        }
    }
}

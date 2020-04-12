using System;

namespace E3
{
    class Program
    {
        static public void esPar(int num){ 
            if(num%2==0) 
            Console.WriteLine("El numero es par"); 
            else 
            Console.WriteLine("El numero no es par"); 
        }

        static public void esPrimo(int num)
        {
            int contador=0;

            for(int i=1;i<=num;i++)
                if(num%i==0)
                    contador++;

            if(contador!=2)
            Console.WriteLine("El numero no es primo");
            else
            Console.WriteLine("El numero es primo");
            
        }

        static void Main(string[] args)
        {
            int numero=0;

            Console.WriteLine("Ingrese un numero");
            numero= Int32.Parse(Console.ReadLine());

            esPar(numero);
            esPrimo(numero);

        }
    }
}

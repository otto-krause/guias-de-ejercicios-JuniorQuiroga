using System;

namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado=0,a=0,b=0;

            Console.WriteLine("[1]Fibonacci \n[2]Factorial \n[3]Mayor \n[4]Menor \n[5]Cubo");
            
            switch (Int32.Parse(Console.ReadLine())){
                case 1:
                    Console.WriteLine("Ingrese el limite de numeros a mostrar");
                    Matematica.Fibonacci(Int32.Parse(Console.ReadLine()));
                break;

                case 2:
                    Console.WriteLine("Ingrese el numero");
                    a=Int32.Parse(Console.ReadLine());
                    resultado = Matematica.Factorial(a);
                    Console.WriteLine("El factorial de {0} es: {1}",a,resultado);
                break;
                
                case 3:
                    Console.WriteLine("Ingrese dos numeros");
                    a=Int32.Parse(Console.ReadLine());
                    b=Int32.Parse(Console.ReadLine());
                    Console.WriteLine("El mayor numero es: "+Matematica.Mayor(a,b));
                break;

                case 4:
                    Console.WriteLine("Ingrese dos numeros");
                    a=Int32.Parse(Console.ReadLine());
                    b=Int32.Parse(Console.ReadLine());
                    Console.WriteLine("El menor numero es: "+Matematica.Menor(a,b));
                break;

                case 5:
                    Console.WriteLine("Ingrese el numero");
                    a=Int32.Parse(Console.ReadLine());
                    resultado=Matematica.Cubo(a);
                    Console.WriteLine("el cubo de {0} es: {1}",a,resultado);
                break;

                default:
                    Console.WriteLine("Opcion invalida");
                break;
            }
        }
    }
}

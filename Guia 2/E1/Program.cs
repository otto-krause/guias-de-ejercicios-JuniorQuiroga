using System;
using System.Collections.Generic;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont=0,menu=0,contador50=0;
            List<int> numeros= new List<int>();
            

            Console.WriteLine("Ingrese numeros a la lista, ingrese 0 para terminar");

            do{
                numeros.Add(Int32.Parse(Console.ReadLine()));
                cont+=1;
            }while (numeros[cont-1] != 0);
            numeros.Remove(0);

            Console.WriteLine("[1]numeros ingresados \n[2]cantidad de numeros \n[3]primer numero \n[4]ultimo numero \n[5]cantidad de numeros mayores a 50");
            menu=Int32.Parse(Console.ReadLine());

            switch (menu){
                case 1:        
                    Console.WriteLine("Los numeros ingresados son:");
                    foreach (var num in numeros){
                        Console.WriteLine(num);
                    }
                break;

                case 2:
                    Console.WriteLine("se ingresaron: "+numeros.Count+" elementos");
                break;

                case 3:
                    Console.WriteLine("el primer numero es: "+numeros[0]);
                break;
                
                case 4:
                    Console.WriteLine("el ultimo numero es: "+numeros[(numeros.Count)-1]);
                break;

                case 5:
                    foreach (var num in numeros)
                    {
                        if(num > 50) 
                        contador50+=1;
                    }
                    
                    Console.WriteLine("hay "+contador50+" numeros mayores a 50");
                break;

                default:
                    Console.WriteLine("Opcion invalida");
                break;
            }
        }
    }
}

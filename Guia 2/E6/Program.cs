using System;
using System.Collections.Generic;

namespace POO.guias_de_ejercicios_JuniorQuiroga.Guia_2.E6
{
    class Program
    {
        public static void Mostrar(List<string> resultados){
            if (resultados.Count!=0){
                Console.WriteLine("Se encontraron estos juegos:");

                foreach (var resultado in resultados){
                    Console.WriteLine(resultado);
                }
            }
            else                
            Console.WriteLine("No se encontraron resultados");
        }

        static void Main(string[] args)
        {
            int menu=0;
            string parametro;

            Steam steam = new Steam();
            
            Console.WriteLine("[1]Buscar por genero \n[2]buscar por calificacion");
            menu = Int32.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Ingrese el genero deseado");
                    parametro = Console.ReadLine();
                    List<string> resultados = Steam.BuscarGenero(parametro);

                    Mostrar(resultados);
                break;

                case 2:
                    Console.WriteLine("Ingrese la calificacion deseado");
                    Console.WriteLine("[alta]\n[media]\n[baja]");
                    parametro = Console.ReadLine(); 
                    resultados =Steam.BuscarCalificacion(parametro);

                    Mostrar(resultados);
                break;

                default:
                    Console.WriteLine("opcion invalida");
                break;
            }
        }
    }
}

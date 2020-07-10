using System;
using System.Linq;
using System.Collections.Generic;

namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu=0;
            string busqueda;
            Peliteca peliculista = new Peliteca();
            List<Pelicula> peliculas = Peliteca.GetList(); 
            
            Console.WriteLine("[1]Busqueda por genero \n[2]Busqueda por nombre \n[3]Busqueda por año \n[4]Busqueda por director \n[5]Cantidad de peliculas \n[6]Cantidad de un genero \n");
            menu=Int32.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.WriteLine("Ingrese el genero deseado");
                    busqueda=Console.ReadLine();
                    peliculas.Where(pelicula => pelicula.Genero == busqueda).ToList()
                    .ForEach(pelicula => Console.WriteLine(pelicula.Nombre+" "+pelicula.Genero));
                break;

                case 2:
                    Console.WriteLine("Ingrese el nombre de la pelicula");
                    busqueda=Console.ReadLine();
                    peliculas.Where(pelicula => pelicula.Nombre == busqueda).ToList()
                    .ForEach(pelicula => Console.WriteLine(pelicula.Nombre+" "+pelicula.Genero));
                break;

                case 3:
                    Console.WriteLine("Ingrese el año de lanzamiento");
                    busqueda=Console.ReadLine();
                    peliculas.Where(pelicula => pelicula.Año.ToString() == busqueda).ToList()
                    .ForEach(pelicula => Console.WriteLine(pelicula.Nombre+" "+pelicula.Genero));
                break;

                case 4:
                    Console.WriteLine("Ingrese el nombre del director");
                    busqueda=Console.ReadLine();
                    peliculas.Where(pelicula => pelicula.Director == busqueda).ToList()
                    .ForEach(pelicula => Console.WriteLine(pelicula.Nombre+" "+pelicula.Genero));
                break;

                case 5:
                    Console.WriteLine("hay "+peliculas.Count+" peliculas");
                break;
                
                case 6:
                    Console.WriteLine("Ingrese el genero");
                    busqueda=Console.ReadLine();
                    Console.WriteLine("hay "+peliculas.Where(peli => peli.Genero==busqueda ).ToList().Count+" peliculas de este genero");
                break;
                
                default:
                    Console.WriteLine("Opcion no valida");
                break;
            }
        }
    }
}
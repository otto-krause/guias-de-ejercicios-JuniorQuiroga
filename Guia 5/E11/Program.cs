using System;
using System.Linq;
using System.Collections.Generic;

namespace E11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aplicacion> aplicaciones = new List<Aplicacion>(){new Aplicacion(4,100,0,"almacenamiento","NUESTRO juego"),
                                                                    new Aplicacion(90,500,1900,"fotos/videos","CaraeLibro"),
                                                                    new Aplicacion(5,126,40,"almacenamiento","esto no es una app"),
                                                                    new Aplicacion(20,29,500,"fotos/videos","virus pero legal"),
                                                                    new Aplicacion(20,5000,12,"almacenamiento","patata game"),
                                                                    new Aplicacion(5,50,12,"almacenamiento","patata que es nada"),
                                                                    new Aplicacion(20,22,5000,"fotos/videos","patata pero social")};
            List<Aplicacion> juegos = new List<Aplicacion>(); 
            List<Aplicacion> redes_sociales = new List<Aplicacion>();
            List<Aplicacion> resto = new List<Aplicacion>(); 
                
            //juegos:
            //  25tps
            //redes sociales:
            //  permiso a fotos y videos
            //  interaccion teclado 20%
            juegos = aplicaciones.Where(a => a.Interaccion()>=25f).ToList();
            Console.WriteLine("Los juegos son:");
            juegos.ForEach(j => Console.WriteLine(j.Nombre));

            redes_sociales = aplicaciones.Where(a => a.InteraccionTeclado()>=20f && a.Permisos.Contains("fotos/videos")).ToList();
            Console.WriteLine("\nLas redes sociales son:");
            redes_sociales.ForEach(j => Console.WriteLine(j.Nombre));

            resto = juegos.Concat(redes_sociales).ToList();
            resto = aplicaciones.Except(resto).ToList();
            Console.WriteLine("\nLas siguientes aplicaciones no son identificables:");
            resto.ForEach(r => Console.WriteLine(r.Nombre));
        }
    }
}

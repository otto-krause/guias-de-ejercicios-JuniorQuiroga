using System.Collections.Generic;
using System;

namespace E4
{
    public class Peliteca
    {
        static List<Pelicula> peliculas = new List<Pelicula>();

        void AddPeli(Pelicula nueva_pelicula){
            peliculas.Add(nueva_pelicula);
        }

        public Peliteca(){
            Pelicula p1 = new Pelicula("King Kong","Aventura",1933,"Merian C");
            Pelicula p2 = new Pelicula("Blade Runner","ciencia ficcion",1982,"Ridley Scott");
            Pelicula p3 = new Pelicula("Prometeo","ciencia ficcion",2012,"Ridley Scott");
            Pelicula p4 = new Pelicula("Gladeador","accion",2000,"Ridley Scott");
            Pelicula p5 = new Pelicula("Tiempos Modernos","Comedia",1936,"Charles Chaplin");

            AddPeli(p1);
            AddPeli(p2);
            AddPeli(p3);
            AddPeli(p4);
            AddPeli(p5);
        }

        public static List<Pelicula> GetList(){
            return peliculas;
        }
    }
}
using System.Collections.Generic;
using System;

namespace POO.guias_de_ejercicios_JuniorQuiroga.Guia_2.E6
{
    public class Juego
    {
        //parametros y lista de calificaciones
        string titulo;
        public string GetTitulo{get => titulo;}
        string genero;
        List<Calificacion> calificaciones = new List<Calificacion>();
        public List<Calificacion> GetCalificaciones{get => calificaciones;}

        //random 
        Random random = new Random();
        
        
        //guarda los nombres y generos de cada juego
        static List<string> listaInfo = new List<string>();
        public static List<string> GetInfo{get => listaInfo;}

        //constructor
        public Juego(string titulo, string genero){
            this.titulo=titulo;
            this.genero=genero;

            listaInfo.Add(titulo+"/"+genero);

            Calificacion c1 = new Calificacion(genValor(),"Exelente juego");
            Calificacion c2 = new Calificacion(genValor(),"ta bueno juego");
            Calificacion c3 = new Calificacion(genValor(),"buen juego");
            Calificacion c4 = new Calificacion(genValor(),"meh...");
            Calificacion c5 = new Calificacion(genValor(),"EL PEOR JUEGO QUE JUGUE!!");
            
            calificaciones.Add(c1);
            calificaciones.Add(c2);
            calificaciones.Add(c3);
            calificaciones.Add(c4);
            calificaciones.Add(c5);
        }

        private int genValor(){
            int valor=0;

            valor = random.Next(1,5);
            return valor+(valor%2);
        }
    }
}
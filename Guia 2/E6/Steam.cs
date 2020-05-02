using System.Collections.Generic;
using System;

namespace POO.guias_de_ejercicios_JuniorQuiroga.Guia_2.E6
{
    public class Steam
    {
        static string[] split_info;
        static List<string> coincidencias = new List<string>();
        
        static List<Juego> lista_juegos = new List<Juego>();
        
        public Steam(){
            Juego j1 = new Juego("Half-Life","FPS");
            Juego j2 = new Juego("Half-Life 2","FPS");
            Juego j3 = new Juego("GTA V","Mundo Abierto");
            Juego j4 = new Juego("Bioshock","FPS");
            Juego j5 = new Juego("Half-Life: Alix","VR");
            Juego j6 = new Juego("EVE Online","MMO");
            Juego j7 = new Juego("Path Of Exile","MMO");
            Juego j8 = new Juego("The Crew 2","Accion");
            lista_juegos.Add(j1);
            lista_juegos.Add(j2);
            lista_juegos.Add(j3);
            lista_juegos.Add(j4);
            lista_juegos.Add(j5);
            lista_juegos.Add(j6);
            lista_juegos.Add(j7);
            lista_juegos.Add(j8);
        }

        public static List<string> BuscarGenero(string parametro){
            
            List<string> informacion = Juego.GetInfo;

            foreach (var info in informacion)
            {
                split_info=info.Split("/");

                if(parametro == split_info[1])
                    coincidencias.Add(split_info[0]);
            }
            return coincidencias;
        }

        public static List<string>  BuscarCalificacion(string calidad){            
            int acu =0;
            float prom;
            foreach (var juego in lista_juegos)
            {
                List<Calificacion> lista_calificaciones = juego.GetCalificaciones;
                foreach (var cali in lista_calificaciones){
                    acu += cali.Estrellas;
                }
                prom = acu / lista_calificaciones.Count;

                switch (calidad)
                {
                    case "alta":
                        if(prom>=4)
                            coincidencias.Add(juego.GetTitulo);
                    break;
                    case "media":
                        if(prom==3)
                            coincidencias.Add(juego.GetTitulo);
                    break;
                    case "baja":
                        if(prom<=2)
                            coincidencias.Add(juego.GetTitulo);
                    break;
                } 
                acu=0;
                prom=0;
            }
            return coincidencias;
        }
    }
}
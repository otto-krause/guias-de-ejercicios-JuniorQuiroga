using System.Collections.Generic;
using System;
using System.Linq;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace E2
{
    public class Archivo
    {
        string json;
        Franquicia franquicia;

        public Archivo(){

        }
        
        public void cosa(){
            using (StreamReader r = new StreamReader("text.json"))
            {
                json = r.ReadToEnd();
            }
        
            franquicia =  JsonSerializer.Deserialize<Franquicia>(json);    
        }

        public string Buscar(double x, double y){
            double menor = franquicia.locales[0].coordenadas.latitud+franquicia.locales[0].coordenadas.longitud;
            string nombre = franquicia.locales[0].nombre;
            foreach (var local in franquicia.locales)
            {
                if(x+y - menor > local.coordenadas.latitud+local.coordenadas.longitud - x+y){
                    menor = local.coordenadas.latitud+local.coordenadas.longitud - x+y;
                    nombre = local.nombre;
                }
            }

            return nombre;
        }


        public bool BuscarTrabajo(double x, double y){
            bool res= false;
            List<Local> localesCercanos = franquicia.locales.OrderBy(l=>l.coordenadas.latitud+l.coordenadas.longitud - x+y).ToList();
            
            for (int i = 0; i < 5; i++)
            {
                if(localesCercanos[i].empleados.Any(e => e.asignadoA == "")){
                    res=true;
                    //Console.WriteLine(localesCercanos[i].nombre);
                }
            }
            return res;
        }
    }
}
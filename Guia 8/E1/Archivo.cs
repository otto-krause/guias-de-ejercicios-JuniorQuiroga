using System.Net;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System;

namespace E1
{
    public class Archivo
    {
        StreamWriter peliculas;
        public StreamWriter Peliculas{get => peliculas;}

        public Archivo(){
            if(!File.Exists("peliculas.txt")){
                peliculas = File.CreateText("peliculas.txt");
                peliculas.Close();
            }
        }

        public void Agregar(string nombre){
            peliculas = File.AppendText("peliculas.txt");

            peliculas.WriteLine(nombre);
            peliculas.Close();
        }

        public string Leer(){
            using (StreamReader r = new StreamReader("peliculas.txt"))
            {
                string txt = r.ReadToEnd();
                return txt;
            }
        }
    }
}
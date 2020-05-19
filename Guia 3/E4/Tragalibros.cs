using System.Collections.Generic;
using System;
namespace E4
{
    public class Tragalibros
    {
        List<Libro> libros = new List<Libro>();

        public Tragalibros(){
                
        }

        public void Leer(Libro libro){
            libros.Add(libro);
        }

        public int CalcularCI(){
            return libros.Count*5;
        }

        public bool EsRepetido(string nombre, string autor){
            bool indicador=false;
            foreach (var libro in libros)
            {
                if(libro.getTitulo==nombre && libro.getAutor==autor){
                    indicador=true;
                }
            }
            return indicador;
        }
    }
}
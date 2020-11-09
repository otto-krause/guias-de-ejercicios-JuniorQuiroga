using System;
using System.Linq;
using System.Collections.Generic;

namespace Ejercicio
{
    public class Quirk
    {
        private string nombre;
        private int duracion;
        private bool consecuencia;
        private int poder;
        private bool esPeligroso;
        private int cantTraspasos;
        private List<Quirk> quirksRobados;

        public string Nombre{get=> nombre;}
        public int Traspasos{get =>cantTraspasos;
                             set =>cantTraspasos = value;}
        public List<Quirk> Robados{get => quirksRobados;}

        public Quirk(string nombre, int duracion, bool consecuencia){
            this.nombre = nombre;
            this.duracion = duracion;
            this.consecuencia = consecuencia;
            this.quirksRobados = new List<Quirk>();
            Poder();
            this.esPeligroso=Peligroso();
        }
            
        public int Poder(){
            int resp = 0;
            if("One For All" == nombre)
                resp = duracion * nombre.Length + cantTraspasos*(15*(duracion * nombre.Length)/100);
            else if("All For One" == nombre){
                resp= quirksRobados.Sum(q=>q.Poder());
                poder = resp;
            }
            else
                resp = duracion * nombre.Length;
            poder = resp;
            return resp;
        }

        public void Agregar(Quirk nuevo)=>quirksRobados.Add(nuevo);

        public bool Peligroso(){
            bool temp=false;
            if("One For All" == nombre)
                temp = true;
            else{ 
                if("All For One" == nombre)
                    temp = quirksRobados.Any(q=>q.Peligroso());
                else
                    temp = poder > 1000 && (duracion > 60 || consecuencia);
            }
            esPeligroso = temp;
            return temp;
        }
    }
}
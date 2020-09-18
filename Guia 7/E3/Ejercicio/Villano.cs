using System;
using System.Linq;
using System.Collections.Generic;

namespace Ejercicio
{
    public  class Villano
    {
        
        protected int asesinatos;
        protected int fuerza;
        protected string estado;

        public int Fuerza{get => fuerza;}
        public int Asesinatos{get => asesinatos;}
        public string Estado{get => estado;
                             set => estado = value;}

        public Villano(){
            this.estado = "profugo";
        }
        public virtual void HacerMaldades(List<Ciudadano> ciudadanos){}

        protected virtual void CalcularFuerza(){}
    }
}
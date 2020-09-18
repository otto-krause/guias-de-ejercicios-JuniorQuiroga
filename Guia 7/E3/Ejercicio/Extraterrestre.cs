using System;
using System.Linq;
using System.Collections.Generic;

namespace Ejercicio
{
    public class Extraterrestre:Villano
    {
        private int extremidades;
        private int abducidos;
        Random rng;

        public Extraterrestre(int extremidades) : base(){
            this.extremidades = extremidades;
            this.abducidos = 0;
            rng = new Random();
        }

        public override void HacerMaldades(List<Ciudadano> ciudadanos){
            ciudadanos.RemoveAt(rng.Next(1,ciudadanos.Count()));
            abducidos++;
            CalcularFuerza();
        }

        protected override void CalcularFuerza(){
            fuerza=abducidos/extremidades;
        }
    }
}
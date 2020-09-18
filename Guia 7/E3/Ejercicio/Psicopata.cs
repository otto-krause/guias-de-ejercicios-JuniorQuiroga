using System;
using System.Linq;
using System.Collections.Generic;

namespace Ejercicio
{
    public class Psicopata : Villano
    {
        int inteligencia;

        public Psicopata(int inteligencia): base(){
            this.inteligencia = inteligencia;
            this.asesinatos=0;
        }

        public override void HacerMaldades(List<Ciudadano> ciudadanos){
            asesinatos +=5;
            CalcularFuerza();
        }

        protected override void CalcularFuerza(){
            fuerza = inteligencia*asesinatos;
        }
    }
}
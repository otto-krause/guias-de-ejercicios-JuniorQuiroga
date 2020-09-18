using System;
using System.Linq;
using System.Collections.Generic;

namespace Ejercicio
{
    public abstract class Ladron : Villano
    {
        
        protected int robos;
        protected int dinero;
        public int Dinero{get => dinero;
                          set => dinero = value;}

        public Ladron(): base(){
        }

        public override void HacerMaldades(List<Ciudadano> ciudadanos){

        }

        protected override void CalcularFuerza(){
            fuerza = robos;
        }
    }
}
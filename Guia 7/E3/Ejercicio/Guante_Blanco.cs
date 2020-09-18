using System;
using System.Linq;
using System.Collections.Generic;

namespace Ejercicio
{
    public class Guante_Blanco:Ladron
    {
        
        public Guante_Blanco():base(){
            this.robos=0;
            this.fuerza=robos;
        }

        public override void HacerMaldades(List<Ciudadano> ciudadanos){
            foreach (var vistima in ciudadanos)
            {
                if(vistima.Clase == "rico"){
                    dinero = vistima.Dinero;
                    vistima.Dinero=0;
                }
            }
            CalcularFuerza();
        }
    }
}
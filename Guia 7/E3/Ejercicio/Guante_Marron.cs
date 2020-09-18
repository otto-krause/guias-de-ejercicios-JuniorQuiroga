using System;
using System.Linq;
using System.Collections.Generic;

namespace Ejercicio
{
    public class Guante_Marron:Ladron
    {
        public Guante_Marron():base(){
            this.robos=0;
            this.fuerza=robos;
        }

        public override void HacerMaldades(List<Ciudadano> ciudadanos){
            foreach (var vistima in ciudadanos)
            {
                if(vistima.Clase == "media"){
                    dinero = vistima.Dinero;
                    vistima.Dinero=0;
                }
            }
            CalcularFuerza();
        }
    }
}
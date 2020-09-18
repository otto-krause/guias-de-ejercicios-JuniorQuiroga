using System;
using System.Linq;
using System.Collections.Generic;

namespace Ejercicio
{
    public class Robin_Hood:Ladron
    {
        public Robin_Hood(): base(){
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
            int entregar = dinero/ciudadanos.Where(c=>c.Clase=="baja").Count();
            ciudadanos.Where(c=>c.Clase=="baja").ToList().ForEach(c=>c.Dinero+=entregar);
        }
    }
}
using System;
using System.Linq;
using System.Collections.Generic;

namespace Ejercicio
{
    public class Matilda:Pajaro
    {
        List<Huevo> huevos;

        public Matilda(int ira, List<Huevo> huevos): base(){
            this.huevos = huevos;
            this.ira=ira;
            this.fuerza = CalcularFuerza();
        }

        public override int CalcularFuerza(){
            return ira*2 + huevos.Sum(h => h.Fuerza);
        }

        public override void Enojarse(){
            huevos.Add(new Huevo(2));
            fuerza=CalcularFuerza();
        }
    }
}
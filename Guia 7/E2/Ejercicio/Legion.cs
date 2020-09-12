using System.Collections.Generic;
using System.Linq;
using System;

namespace Ejercicio
{
    public class Legion:Asustador
    {
        private List<Asustador> niños;
        private Asustador lider;

        public Asustador Lider{get=>lider;}

        public Legion(List<Asustador> niños):base(){
            if(niños.Count()>1)
                this.niños = niños;
            else
                throw new Exception("Se requieren 2 niños como minimo");

            this.caramelos = niños.Sum(n => n.Caramelos);
            this.capacidades = niños.Sum(n => n.Capacidad);
            this.lider = niños.OrderByDescending(n => n.Capacidad).First(); 
        }

        public override void Asustar(Adulto adulto){
            int recibidos = adulto.SeAsusta(this);

            if(recibidos !=0)
                lider.Caramelos=recibidos;
                caramelos += recibidos;
        }

        public override void Comer(int cantidad){}
    }
}
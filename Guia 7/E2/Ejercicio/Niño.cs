using System;
using System.Linq;
using System.Collections.Generic;

namespace Ejercicio
{
    public class Niño:Asustador
    {
        public Niño(Maquillaje maquillaje, Traje traje, int caramelos):base(){
            this.maquillaje = maquillaje;
            this.traje = traje;
            this.capacidades = maquillaje.Puntos + traje.Puntos;
            this.caramelos = caramelos;
        }

        public override void Asustar(Adulto adulto){
            caramelos += adulto.SeAsusta(this);
        }
    }
}
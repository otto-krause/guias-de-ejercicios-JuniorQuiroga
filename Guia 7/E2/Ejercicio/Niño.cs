using System;

namespace Ejercicio
{
    public class Niño:Asustador
    {
        private Maquillaje maquillaje;
        private Traje traje;
        

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
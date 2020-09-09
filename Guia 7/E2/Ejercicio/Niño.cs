using System;

namespace Ejercicio
{
    public class Niño
    {
        private Maquillaje maquillaje;
        private Traje traje;
        private int capacidadSusto;
        private int caramelos;

        public int Capacidad{get => capacidadSusto;}
        public int Caramelos{get => caramelos;}

        public Niño(Maquillaje maquillaje, Traje traje, int caramelos){
            this.maquillaje = maquillaje;
            this.traje = traje;
            this.capacidadSusto = maquillaje.Puntos + traje.Puntos;
            this.caramelos = caramelos;
        }

        public void Asustar(Adulto adulto){
            caramelos += adulto.SeAsusta(this);
        }
    }
}
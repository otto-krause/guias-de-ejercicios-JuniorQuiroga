using System;
namespace Ejercicio
{
    public abstract class Pajaro
    {
        protected int fuerza;
        protected int ira;

        public int Fuerza{get => fuerza;}
        public int Ira{get => ira;}

        public Pajaro(){
        }

        public abstract int CalcularFuerza();

        public virtual void Enojarse(){
            this.ira *=2;
            this.fuerza=CalcularFuerza();
        }
    }
}
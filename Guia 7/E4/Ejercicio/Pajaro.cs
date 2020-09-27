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

        public virtual void ManejarIra(){
            if(ira-5 > 0) 
                this.ira -=5;
            else 
                this.ira =0;
        }

        public void Derribar(Obstaculo obstaculo){
            if(obstaculo.Resistencia <= fuerza){
                obstaculo.Estado="derribado";
            }
            //else
                //throw new Exception(this +" Su fuerza no es suficiente");
        }
    }
}
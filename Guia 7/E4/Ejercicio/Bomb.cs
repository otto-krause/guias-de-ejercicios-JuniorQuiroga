using System;
namespace Ejercicio
{
    public class Bomb:Pajaro
    {
        public Bomb(int ira):base(){
            this.ira=ira;
            this.fuerza =CalcularFuerza();
        }

        public override int CalcularFuerza(){
            return ira*2 <= 9000? ira*2:ira;
        }

        public override void Enojarse(){ 
            if(ira*2 <= 9000)
                this.ira =ira *2;
            this.fuerza=CalcularFuerza();
        }
    }
}
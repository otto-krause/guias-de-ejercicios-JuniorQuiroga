namespace Ejercicio
{
    public class Chuck:Pajaro
    {
        private int velocidad;
        public int Velocidad{get => velocidad;}

        public Chuck(int velocidad):base(){
            this.velocidad = velocidad;
            this.fuerza =CalcularFuerza();
        }

        public override int CalcularFuerza(){
            return velocidad <= 80? 150 : fuerza + 5*(velocidad - 80); 
        }

        public override void Enojarse(){
            this.velocidad *=2;
            this.fuerza=CalcularFuerza();
        }
    }
}
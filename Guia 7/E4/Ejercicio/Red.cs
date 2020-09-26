namespace Ejercicio
{
    public class Red:Pajaro
    {
        private int cantEnojo;

        public Red(int ira) :base(){
            this.ira=ira;
            this.fuerza =CalcularFuerza();
        }

        public override int CalcularFuerza(){
            return ira*10*cantEnojo;
        }

        public override void Enojarse(){
            ira *=2;
            fuerza=CalcularFuerza();
            cantEnojo++;
        }
    }
}
namespace Ejercicio
{
    public class Comun:Pajaro
    {
        public Comun(int ira):base(){
            this.ira=ira;
            this.fuerza =CalcularFuerza();
        }

        public override int CalcularFuerza(){
            return ira*2;
        }
    }
}
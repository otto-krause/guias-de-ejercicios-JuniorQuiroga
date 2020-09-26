namespace Ejercicio
{
    public class Terence:Pajaro
    {
        private int cantEnojo;
        private int multiplicador;

        public Terence (int ira, int multiplicador): base(){
            this.multiplicador = multiplicador;
            this.ira=ira;
            this.fuerza =CalcularFuerza();
        }

        public override int CalcularFuerza(){
            return (ira + cantEnojo) * multiplicador;
        }

        public override void Enojarse(){
            cantEnojo++;
            ira *=2;
            fuerza=CalcularFuerza();
        }
    }
}
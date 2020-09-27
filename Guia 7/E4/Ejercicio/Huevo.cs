namespace Ejercicio
{
    public class Huevo
    {
        private int peso;
        private int fuerza;

        public int Peso {get => peso;}
        public int Fuerza {get => fuerza;}

        public Huevo(int peso){
            this.peso = peso;
            this.fuerza = peso;
        }

        public Pajaro Abrirse(){
            return new Comun(1);
        }
    }
}
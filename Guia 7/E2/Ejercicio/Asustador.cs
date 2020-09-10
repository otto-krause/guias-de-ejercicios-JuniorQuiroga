namespace Ejercicio
{
    public abstract class Asustador
    {   
        protected int capacidades;
        protected int caramelos;

        public int Capacidad{get => capacidades;}
        public int Caramelos{get => caramelos;
                             set => caramelos=value;}

        public Asustador(){
        }

        public abstract void Asustar(Adulto adulto);
    }
}
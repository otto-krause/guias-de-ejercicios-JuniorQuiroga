namespace Ejercicio
{
    public abstract class Asustador
    {   
        protected int capacidades;
        protected int caramelos;

        public int Capacidad{get => capacidades;}
        public int Caramelos{get => caramelos;
                             set => caramelos=value;}        
        
        protected Maquillaje maquillaje;
        protected Traje traje;
        
        public Maquillaje getMaqui{get=> maquillaje;}
        public Traje getTraje{get=> traje;}


        public Asustador(){
        }

        public abstract void Asustar(Adulto adulto);
    }
}
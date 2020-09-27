namespace Ejercicio
{
    public class Obstaculo
    {
        protected int resistencia;
        protected string estado;
        
        public int Resistencia{get => resistencia;}
        public string Estado{get => estado;
                              set => estado=value;}
        
        public Obstaculo(){

        }
    }
}
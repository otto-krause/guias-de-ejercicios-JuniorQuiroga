namespace E2
{
    public class Monstruo
    {
        protected int respeto;
        protected string nombre;

        public int getRespeto{get=> respeto;}
        public string getNombre{get=> nombre;}

        public Monstruo(string nombre){
            this.respeto=0;
            this.nombre=nombre;
        }

        public virtual void Asustar(){

        }

        public virtual void HacerReir(){

        }
    }
}
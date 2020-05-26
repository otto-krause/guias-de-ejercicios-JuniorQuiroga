namespace E1
{
    public class Animal
    {
        protected int energia;
        public int getEnergia{get=>energia;}

        public Animal(){
            this.energia=100;
        }

        public virtual void Comer(){

        }

        public virtual void Jugar(){

        }

        public void Dormir(){
            energia =100;
        }
    }
}
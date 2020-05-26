namespace E1
{
    public class Perro:Animal
    {
        public Perro() : base(){
        }

        public override void Comer(){
            energia +=15;
        }

        public override void Jugar(){
            energia -=20;
        }
    }
}
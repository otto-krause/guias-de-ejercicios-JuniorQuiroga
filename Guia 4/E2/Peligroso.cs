namespace E2
{
    public class Peligroso:Monstruo
    {
        public Peligroso(string nombre):base(nombre){

        }

        public override void Asustar(){
            respeto+=5;
        }

        public override void HacerReir(){
            respeto-=2;
        }
    }
}
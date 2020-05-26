namespace E2
{
    public class Amigable:Monstruo
    {
        public Amigable(string nombre):base(nombre){

        }


        public override void Asustar(){
            respeto+=7;
        }

        public override void HacerReir(){
            respeto+=1;
        }
    }
}
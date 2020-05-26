using System;
namespace E1
{
    public class Pajaro:Animal
    {
        public Pajaro() : base(){
        }

        public override void Comer(){
            energia +=10;
        }

        public override void Jugar(){
            energia -=5;
        }
    }
}
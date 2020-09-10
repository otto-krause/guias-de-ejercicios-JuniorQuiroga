using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public abstract class Adulto
    {
        protected List<int> caramelosDeNiños = new List<int>();
        protected int tolerancia;
        
        public int Tolerancia {get => tolerancia;}

        public Adulto(){
            this.tolerancia=0;
        }

        public abstract int SeAsusta(Asustador niño);
    }
}
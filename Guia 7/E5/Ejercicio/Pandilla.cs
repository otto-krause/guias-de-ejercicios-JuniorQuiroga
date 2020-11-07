using System.Collections.Generic;

namespace Ejercicio
{
    public class Pandilla
    {
        private List<Villano> villanos;
        public List<Villano> Villanos{get => villanos;} 

        public Pandilla(List<Villano> villanos){
            this.villanos = villanos;
        }
    }
}
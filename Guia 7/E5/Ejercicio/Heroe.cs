using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Heroe:Persona
    {
        private int victorias;
        private int derrotas;
        private string papeles;

        public int Victorias{get =>victorias;}
        public int Derrotas{get =>derrotas;}
        public string Papeles{get=>papeles;}
        
        public Heroe(Quirk quirk):base(quirk){
            this.papeles = "licencia";
        }

        public void Luchar(Villano villano){
            if(quirk.Poder > villano.suQuirk.Poder)
                victorias++;
            else
                derrotas++;
        }

        public void Luchar(Pandilla pandilla){
            if(quirk.Poder > pandilla.Villanos.Sum(v => v.suQuirk.Poder))
                victorias+= pandilla.Villanos.Count();
            else
                papeles = "acta de defuncion";
        }
    }
}
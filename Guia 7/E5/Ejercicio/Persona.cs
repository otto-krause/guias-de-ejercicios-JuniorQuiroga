using System.Linq;
using System.Collections.Generic;

namespace Ejercicio
{
    public class Persona
    {
        protected Quirk quirk;
        protected Quirk quirkOriginal;
       

        public Quirk suQuirk{get => quirk;
                             set => quirk = value;}
        public Quirk QuirkOriginal{get => quirkOriginal;}

        public Persona(Quirk quirk){
            this.quirk = quirk;
        }

        public void Recibir(Quirk nuevo){
            quirkOriginal=quirk;
            quirk = nuevo;
        }
        
        public void Traspasar(Persona persona){
            if(quirk.Nombre == "One For All"){
                quirk.Traspasos+=1;
                persona.Recibir(quirk);
                quirk=null;
            }
        }

        public void Robar(Persona asaltado){
            if(quirk.Nombre == "All For One"){
                quirk.Agregar(asaltado.suQuirk);
                asaltado.suQuirk = null;
            }
        }
    }
}
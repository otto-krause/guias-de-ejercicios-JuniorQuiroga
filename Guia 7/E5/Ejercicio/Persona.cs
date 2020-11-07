namespace Ejercicio
{
    public class Persona
    {
        protected Quirk quirk;

        public Quirk suQuirk{get => quirk;}

        public Persona(Quirk quirk){
            this.quirk = quirk;
        }
    }
}
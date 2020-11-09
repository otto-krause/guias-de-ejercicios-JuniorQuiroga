namespace Ejercicio
{
    public class Villano:Persona
    {
        private bool robo;
        private bool noTrabajo;
        private bool leGustaLaPizzaConPiña;

        private bool esMuyMalo;
        private bool algunaVezFueBueno;
        public bool MuyMalo{get => esMuyMalo;}
        public bool FueBueno{get => algunaVezFueBueno;}

        public Villano(bool robo, bool noTrabajo,bool leGustaLaPizzaConPiña, Quirk quirk):base(quirk){
            this.robo = robo;
            this.noTrabajo = noTrabajo;
            this.leGustaLaPizzaConPiña = leGustaLaPizzaConPiña;
            
            this.esMuyMalo = robo&&noTrabajo&&leGustaLaPizzaConPiña;
            this.algunaVezFueBueno = !quirk.Peligroso()&&!noTrabajo;
        }

    }
}
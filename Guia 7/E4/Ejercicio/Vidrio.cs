namespace Ejercicio
{
    public class Vidrio:Pared
    {
        public Vidrio(int ancho):base(){
            this.ancho = ancho;
            this.resistencia = 10*ancho;
            this.estado = "en pie";
        }
    }
}
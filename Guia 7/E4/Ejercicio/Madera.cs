namespace Ejercicio
{
    public class Madera:Pared
    {
        public Madera(int ancho):base(){
            this.ancho = ancho;
            this.resistencia = 25*ancho;
            this.estado = "en pie";
        }
    }
}
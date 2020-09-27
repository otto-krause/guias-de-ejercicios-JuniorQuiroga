namespace Ejercicio
{
    public class Piedra:Pared
    {
        public Piedra(int ancho):base(){
            this.ancho = ancho;
            this.resistencia = 50*ancho;
            this.estado = "en pie";
        }
    }
}
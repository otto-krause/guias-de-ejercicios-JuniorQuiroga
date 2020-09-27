namespace Ejercicio
{
    public class Armado:Cerdo
    {
        Armadura armadura;

        public Armado(Armadura armadura):base(){
            this.armadura=armadura;
            this.resistencia = 10*armadura.Resistencia;
            this.estado = "en pie";
        }
    }
}
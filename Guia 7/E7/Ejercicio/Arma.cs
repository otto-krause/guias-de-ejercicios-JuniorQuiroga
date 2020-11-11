namespace Ejercicio
{
    public class Arma
    {
        private string nombre;
        private int potencia;

        public string Nombre {get=>nombre;}
        public int Potencia{get =>potencia;}

        public Arma(string nombre, int potencia){
            this.nombre = nombre;
            this.potencia = potencia;
        }
    }
}
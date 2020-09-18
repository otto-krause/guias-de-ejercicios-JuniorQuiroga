namespace Ejercicio
{
    public class Herramienta
    {
        private string nombre;
        private int potencia;
        private int cantidadUsos;
        private int poder;

        public int Poder{get => poder;}
        public string Nombre{get => nombre;}

        public Herramienta(string nombre, int potencia, int cantidadUsos){
            this.nombre= nombre;
            this.potencia= potencia;
            this.cantidadUsos= cantidadUsos;
            this.poder= potencia/cantidadUsos;
        }
    }
}
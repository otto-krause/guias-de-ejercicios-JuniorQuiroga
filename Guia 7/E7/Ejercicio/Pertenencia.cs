namespace Ejercicio
{
    public class Pertenencia
    {
        private int altura;
        private string nombre;
        
        public int Altura{get => altura;}
        public string Nombre{get => nombre;}

        public Pertenencia(string nombre){
            this.nombre = nombre;
        }

        public Pertenencia(string nombre, int altura){
            this.nombre = nombre;
            this.altura = altura;
        }
    }
}
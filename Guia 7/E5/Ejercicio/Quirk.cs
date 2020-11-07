namespace Ejercicio
{
    public class Quirk
    {
        private string nombre;
        private int duracion;
        private bool consecuencia;
        private int poder;
        private bool esPeligroso;

        public int Poder{get => poder;}
        public bool EsPeligroso{get=> esPeligroso;}

        public Quirk(string nombre, int duracion, bool consecuencia){
            this.nombre = nombre;
            this.duracion = duracion;
            this.consecuencia = consecuencia;

            this.poder = duracion * nombre.Length;
            this.esPeligroso = poder > 1000 && (duracion > 60 || consecuencia);
        }
    }
}
namespace E1
{
    public class Persona
    {
        private int edad;
        private string nombre;
        private string apellido;
        public int Edad { get => edad; }
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }

        public Persona(int edad, string nombre, string apellido)
        {
            this.edad = edad;
            this.nombre = nombre;
            this.apellido = apellido;
        }

    }
}
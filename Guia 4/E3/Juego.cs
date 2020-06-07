namespace E3
{
    public class Juego
    {
        string nombre;
        public string getNombre {get=>nombre;}

        int año;
        public int getAño {get=>año;}

        string consola;
        public string getConsola {get=>consola;}


        public Juego(string nombre, int año, string consola){
            this.nombre=nombre;
            this.año = año;
            this.consola = consola;
        }
    }
}
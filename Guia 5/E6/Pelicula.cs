namespace E6
{
    public class Pelicula
    {
        string nombre;
        string genero;
        string director;
        int año;

        public string Nombre {get => nombre;}
        public string Genero {get => genero;}
        public string Director {get => director;}
        public int Año {get => año;}

        public Pelicula(string nombre,string genero,int año,string director){
            this.nombre=nombre;
            this.genero=genero;
            this.año=año;
            this.director=director;
        }
    }
}

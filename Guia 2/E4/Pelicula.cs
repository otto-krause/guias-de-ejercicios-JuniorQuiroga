namespace E4
{
    public class Pelicula
    {
        string nombre,genero,director;
        int año=0;

        public Pelicula(string nombre,string genero,int año,string director){
            this.nombre=nombre;
            this.genero=genero;
            this.año=año;
            this.director=director;
        }

        public string GetInfo(){
            return (nombre+"/"+genero+"/"+año+"/"+director);
        }
    }
}

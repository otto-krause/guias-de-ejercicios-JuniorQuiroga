namespace E4
{
    public class Libro
    {
        string titulo;
        public string getTitulo{get=>titulo;}
        string autor;
        public string getAutor{get=>autor;}
        
        public Libro(string titulo,string autor){
            this.titulo=titulo;
            this.autor=autor;
        }
    }
}
namespace POO.guias_de_ejercicios_JuniorQuiroga.Guia_2.E6
{
    public class Calificacion
    {
        int estrellas=0;
        public int Estrellas{get => estrellas;}
        string comentario;
        
        public Calificacion(int estrellas, string comentario){
            this.estrellas=estrellas;
            this.comentario=comentario;
        }
    }
}
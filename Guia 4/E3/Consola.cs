using System.Collections.Generic;

namespace E3
{
    public class Consola
    {
        protected List<Juego> lista_juegos = new List<Juego>();
        protected int puntaje;
        protected string nombre;
        public string getNombre(){return nombre;}

        public Consola(string nombre){
            this.puntaje=0;
            this.nombre=nombre;
        }
        
        public virtual void AgregarJuego(Juego juego){

        }

        public virtual void Jugar(int horas){

        } 

        public virtual float RevisarPuntaje(){
            return puntaje;
        }

        public string elMasNuevo(){
            int mayor = 0;
            string aux ="";
            foreach (var juego in lista_juegos)
            {
                if (juego.getAño > mayor){
                    mayor = juego.getAño;
                    aux = juego.getNombre;
                }
            }
            return aux;
        }

        public string elMasViejo(){
            int menor = 0;
            string aux="";
            foreach (var juego in lista_juegos)
            {
                if (juego.getAño < menor){
                    menor = juego.getAño;
                    aux = juego.getNombre;
                }
            }
            return aux;
        }
    }
}
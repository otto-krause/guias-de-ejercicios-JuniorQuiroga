using System.Collections.Generic;

namespace E3
{
    public class Jugador
    {
        string nombre;
        List<Consola> lista_Consolas= new List<Consola>();

        public Jugador(string nombre){
            this.nombre = nombre;
        }

        public void AdquirirConsola(Consola consola){
            lista_Consolas.Add(consola);
        }

        public void AdquirirJuego(Juego juego){
            foreach (var consola in lista_Consolas)
            {
                if(juego.getConsola==consola.getNombre())
                    consola.AgregarJuego(juego);
            }
        }

        public string laMasUsada(){
            float max=0f;
            string aux="";
            foreach (var consola in lista_Consolas)
            {
                if(consola.RevisarPuntaje()>max){
                    max= consola.RevisarPuntaje();
                    aux= consola.getNombre();
                }
            }
            return aux;
        }
    }
}
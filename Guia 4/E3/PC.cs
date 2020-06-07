using System.Collections.Generic;

namespace E3
{
    public class PC : Consola
    {
        public PC(string nombre):base(nombre){
            this.puntaje=0;
        }

        public override void AgregarJuego(Juego juego){
            lista_juegos.Add(juego);
        }

        public override void Jugar(int horas){
            puntaje += 10*horas;
        } 
    }
}
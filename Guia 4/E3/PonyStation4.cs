using System.Collections.Generic;

namespace E3
{
    public class PonyStation4 : Consola
    {
        public PonyStation4(string nombre):base(nombre){
            this.puntaje=0;
        }

        public override void AgregarJuego(Juego juego){
            lista_juegos.Add(juego);
            puntaje +=29;
        }

        public override void Jugar(int horas){
            puntaje += 3*horas;
        } 
    }
}
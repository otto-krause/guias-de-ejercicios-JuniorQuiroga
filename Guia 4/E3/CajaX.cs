using System.Collections.Generic;

namespace E3
{
    public class CajaX : Consola
    {
        public CajaX(string nombre):base(nombre){
            this.puntaje=0;
        }

        public override void AgregarJuego(Juego juego){
            lista_juegos.Add(juego);
            puntaje+=25;
        }

        public override void Jugar(int horas){
            puntaje += 4*horas;
        } 
    }
}
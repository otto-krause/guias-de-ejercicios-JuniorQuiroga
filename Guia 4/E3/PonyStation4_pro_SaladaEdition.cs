using System.Collections.Generic;

namespace E3
{
    public class PonyStation4_pro_SaladaEdition : Consola
    {
        public PonyStation4_pro_SaladaEdition(string nombre):base(nombre){
            this.puntaje=0;
        }

        public override void AgregarJuego(Juego juego){
            if(lista_juegos.Count>1)
                lista_juegos.RemoveAt(lista_juegos.Count);
            lista_juegos.Add(juego);
            puntaje +=29;
        }

        public override void Jugar(int horas){
            puntaje += 3*horas;
        }

        public override float RevisarPuntaje(){
            return puntaje/2f;
        }
    }
}
using System.Collections.Generic;

namespace E5
{
    public class Humano : SerPensante
    {
        public Humano(){
            intereses.Add("artes graficas");
            intereses.Add("armas nucleares");
            intereses.Add("paz");
            conocimientos.Add("pesca");
            conocimientos.Add("mineria");
            conocimientos.Add("vegetales");
            conocimientos.Add("medicina");
            conocimientos.Add("cocina");
        }

        public override void Estudiar(string conocimientoNuevo){
            conocimientos.Add(conocimientoNuevo);
            foreach (var interes in intereses)
            {
                if(conocimientoNuevo == interes)
                    puntos_inteligencia++;
            }
        }

        public override void Pensar(string pensamiento){
            conocimientos.Reverse();
            for (int i = 0; i < 5; i++)
            {
                if (conocimientos[i]==pensamiento){
                    puntos_inteligencia +=5;
                }
            }
        }
    }
}
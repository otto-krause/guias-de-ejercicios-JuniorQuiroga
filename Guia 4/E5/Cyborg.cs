using System.Collections.Generic;

namespace E5
{
    public class Cyborg:SerPensante
    {
        public Cyborg(){
            intereses.Add("arte");
            intereses.Add("vegetales");
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
            puntos_inteligencia = conocimientos.Count;
        }
    }
}
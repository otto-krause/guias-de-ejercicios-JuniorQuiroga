using System.Collections.Generic;

namespace E5
{
    public class Robot:SerPensante
    {
        public Robot(){
            conocimientos.Add("humanidades");
            conocimientos.Add("economia");
            conocimientos.Add("medicina");
            conocimientos.Add("plantas");
            conocimientos.Add("cocina");
        }

        public override void Estudiar(string conocimiento){
            conocimientos.Add(conocimiento);
        } 

        public override void Pensar(string pensamiento){
            puntos_inteligencia = conocimientos.Count;
        }
    }
}
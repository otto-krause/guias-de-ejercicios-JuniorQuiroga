using System.Collections.Generic;

namespace E5
{
    public class SerPensante
    {
        protected List<string> conocimientos = new List<string>();
        protected List<string> intereses = new List<string>();
        protected int puntos_inteligencia;

        public int getPuntos{get => puntos_inteligencia;}

        public SerPensante(){
            
        }

        public virtual void Estudiar(string conocimiento){

        }

        public virtual void Pensar(string pensamiento){

        }
    }
}
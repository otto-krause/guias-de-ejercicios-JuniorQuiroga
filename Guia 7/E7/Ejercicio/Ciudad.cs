using System;
using System.Linq;
using System.Collections.Generic;

namespace Ejercicio
{
    public class Ciudad
    {
        private int temperatura;
        private List<Pertenencia> pertenencias;
        
        public int Temperatura{get => temperatura;
                               set => temperatura=value;}
        public List<Pertenencia> Pertenencias{get=>pertenencias;
                                              set=>pertenencias=value;}

        public Ciudad(int temperatura,List<Pertenencia> pertenencias){
            this.temperatura = temperatura;
            this.pertenencias = pertenencias;
        }
    }
}
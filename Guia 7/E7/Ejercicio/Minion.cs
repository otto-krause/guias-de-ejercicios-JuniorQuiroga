using System;
using System.Linq;
using System.Collections.Generic;

namespace Ejercicio
{
    public class Minion
    {
        private List<Arma> armas;
        private string color;
        private int bananas;
        private bool peligroso;
        private int concentracion;
        private int participaciones;
        
        public string Color{get =>color;}
        public int Bananas {get=>bananas;}
        public List<Arma> Armas{get => armas;}
        public int Participaciones{get=>participaciones;
                                    set=>participaciones=value;}


        public Minion(List<Arma> armas,int bananas){
            this.armas = armas;
            this.bananas = bananas;
            this.color = "amarillo";
            this.peligroso= armas.Count>2;
            this.concentracion=CalcConcentracion();
        }

        public int CalcConcentracion(){
            int res=0;
            if(color == "amarillo")
                res = armas.Max(a => a.Potencia)+bananas;
            else
                res = bananas;
            return res;
        }

        public void BeberSuero(){
            if(color == "amarillo"){
                color = "violeta";
                peligroso=true;
                armas.Clear();
            }
            else{
                color="amarillo";
                peligroso=armas.Count>2;
            }
            bananas--;
        }

        public void OtorgarArma(Arma arma) => armas.Add(arma);
        public void Alimentar(int bananas) => this.bananas += bananas;
        public int NivelDeConcentracion() {return concentracion;} 
        public bool EsPeligroso() {return peligroso;} 
    }
}
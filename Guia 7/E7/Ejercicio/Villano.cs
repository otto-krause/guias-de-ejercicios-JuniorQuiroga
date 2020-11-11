using System;
using System.Linq;
using System.Collections.Generic;

namespace Ejercicio
{
    public class Villano
    {
        private List<Minion> minions;
        private List<Minion> minionsAsignados;
        
        public List<Minion> Minions{get=>minions;}
        public List<Minion> MinionsAsignados{get=>minionsAsignados;}


        public Villano(List<Minion> minions){
            this.minions = minions;
            this.minionsAsignados = new List<Minion>();
        }

        public void NuevoMinion() => minions.Add(new Minion(new List<Arma>(){new Arma("Rayo Congelador",10)},5));

        public void Congelar(Ciudad ciudad,int nivelRequerido){
            minionsAsignados.Clear();
            foreach (var minion in minions)
                foreach (var arma in minion.Armas)
                    if(arma.Nombre == "Rayo Congelador" && minion.NivelDeConcentracion() >= nivelRequerido)
                        minionsAsignados.Add(minion);

            minionsAsignados.ForEach(m=> m.Alimentar(10));
            ciudad.Temperatura -= 30; 
        }

        public void Robar(Pertenencia objeto,Ciudad ciudad){
            minionsAsignados.Clear();
            //asignar
            foreach (var minion in minions)
            {
                switch (objeto.Nombre)
                {
                    case "Piramides":
                        if(minion.EsPeligroso() && minion.NivelDeConcentracion() >= objeto.Altura/2)
                            minionsAsignados.Add(minion);
                    break;

                    case "Suero Mutante":
                        if(minion.EsPeligroso() && minion.Bananas>=100 && minion.NivelDeConcentracion() >=23)
                            minionsAsignados.Add(minion);
                    break;
                    
                    case "La Luna":
                        foreach (var arma in minion.Armas)
                            if(minion.EsPeligroso() && arma.Nombre == "Rayo Encojedor")
                                minionsAsignados.Add(minion);
                    break;
                }
            }
            
            if(minionsAsignados.Count > 0){
                ciudad.Pertenencias.Remove(objeto);
                //recompensas
                switch (objeto.Nombre)
                {
                    case "Piramides":
                        minionsAsignados.ForEach(m=> m.Alimentar(10));
                    break;
                    case "Suero Mutante":
                        minions.ForEach(m => m.BeberSuero());
                    break;
                    
                    case "La Luna":
                        minionsAsignados.ForEach(m => m.OtorgarArma(new Arma("Rayo Congelador",10)));
                    break;
                }
                minionsAsignados.ForEach(m=> m.Participaciones++);
            }
            else
                 throw new System.Exception("Ningun minion asignado"); 
        }
    }
}
using System;
using System.Linq;
using System.Collections.Generic;

namespace Ejercicio
{
    public class Isla
    {
        private List<Pajaro> pajaros;
        public List<Pajaro> Pajaros{get => pajaros;}

        public Isla(List<Pajaro> pajaros){
            this.pajaros = pajaros;
        }

        public void ManejoDeIra(){
            pajaros.ForEach(p=>p.ManejarIra());
        }

        public void Invacion(int cerditos){
            for(int i=0;i<(cerditos/100);i++){
                pajaros.ForEach(p=>p.Enojarse());
            }
        }

        public void Fiesta(List<Pajaro> homenajeados){
            if(homenajeados.Count() >0)
                homenajeados.ForEach(p=>p.Enojarse());
            else
                throw new Exception("No hay ningun homenajeado");
        }

        public void EventosDesafortunados(List<Pajaro> homenajeados,int cerditos){
            Invacion(cerditos);
            ManejoDeIra();
            Fiesta(homenajeados);
        }

        public void Atacar(Isla_Cerdo islaCerditos){
            foreach (var pajaro in pajaros)
            {
                if(!islaCerditos.Obstaculos.All(o=>o.Estado == "derribado"))
                    pajaro.Derribar(islaCerditos.Obstaculos.First(o=> o.Estado == "en pie"));
            }
        }

        public void HuevoSeAbre(Huevo huevo){
            pajaros.Add(huevo.Abrirse()); 
        }
    }
}
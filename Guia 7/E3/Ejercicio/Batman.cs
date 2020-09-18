using System;
using System.Linq;
using System.Collections.Generic;

namespace Ejercicio
{
    public class Batman
    {
        private int vida;
        private int estres;
        private int fuerza;
        private List<Herramienta> batiRiñonera;

        public int Vida{get => vida;}
        public int Fuerza{get => fuerza;}
        public int Estres{get => estres;}
        public List<Herramienta> Riñonera{get => batiRiñonera;}

        public Batman(List<Herramienta> batiRiñonera){
            this.vida = 800;
            this.estres = 8;
            this.batiRiñonera = batiRiñonera;
            this.fuerza = vida + batiRiñonera.Sum(b => b.Poder);
        }

        public void DesarrollarTegnologia(string nombre, int potencia, int cantidadUsos){
            batiRiñonera.Add(new Herramienta(nombre,potencia,cantidadUsos));
        }

        public void CombatirCrimen(Villano enemigo){
            if(fuerza> enemigo.Fuerza)
                enemigo.Estado = "inconsciente";
            else{
                vida -= 200;
            }
            estres++;
            CalcularFuerza();
        }
        
        public void CombatirCrimen(List<Villano> pandilla){
             if(fuerza> pandilla.Sum(v => v.Fuerza))
                pandilla.ForEach(v => v.Estado = "inconsciente");
            else{
                vida -= 200;
            }
            estres+= pandilla.Count();
            CalcularFuerza();
        }

        public void Llorar(){
            if(estres-10 > 0)
            estres-=10;
            else
            estres=0;

            batiRiñonera.Remove(batiRiñonera.First());
        }


        private void CalcularFuerza(){
            fuerza = vida + batiRiñonera.Sum(b => b.Poder);
        }

        public void BatiTwist(){
            vida +=100;
        }

        public bool EstaEstresado(){
            return estres > 15;
        }
    }
}
using System.Collections.Generic;
using System;
namespace E3
{
    public class PC
    {
        List<Componente> lista_componente = new List<Componente>();
        MotherBoard mother;

        public PC(MotherBoard MB,Procesador cpu, MemoriaRAM RAM, PlacaDeVideo video, DiscoSSD ssd, DiscoHDD hdd, LectoraDeCD lectora){
            this.mother = MB;
            lista_componente.Add(MB);
            lista_componente.Add(cpu);
            lista_componente.Add(RAM);
            lista_componente.Add(video);
            lista_componente.Add(ssd);
            lista_componente.Add(hdd);
            lista_componente.Add(lectora);
        }
        
        public int PrecioTotal(){
            int total=0;
            foreach (var componente in lista_componente)
            {
                total+= componente.Precio();
            }
            return total;
        }

        public bool SePuedeArmar(){
            int contador=0, paso=0;
                foreach (var comp in lista_componente)
                {
                    if(paso!=0 && comp.EsCompatible(mother))
                    contador++;
                    paso++;
                }
            return contador==6;
        }
    }
}
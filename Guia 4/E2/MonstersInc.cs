using System.Collections.Generic;
using System;
namespace E2
{
    public class MonstersInc
    {
        List<Monstruo> listaMonstruos = new List<Monstruo>();

        List<string> nombres = new List<string>();

        public MonstersInc(){
            listaMonstruos.Add(new Amigable("Maik Wasauski"));
            listaMonstruos.Add(new Amigable("Sulivan"));
            listaMonstruos.Add(new Peligroso("Randal"));
            listaMonstruos.Add(new Peligroso("Henry"));
        }

        public void NocheDeSustos(){
            foreach (var monsta in listaMonstruos)
            {
                monsta.Asustar();
            }
        }

        public void NocheDeRisas(){
            foreach (var monsta in listaMonstruos)
            {
                monsta.HacerReir();
            }
        }

        public int EnergiaGenerada(){
            int total=0;
            foreach (var monsta in listaMonstruos)
            {
                total += monsta.getRespeto;
            }
            return total;
        }

        public List<string> Respetables(){
            nombres.Clear();
            foreach (var monsta in listaMonstruos)
            {
                if (monsta.getRespeto>70)
                nombres.Add(monsta.getNombre);
            }
            return nombres;
        }
    }
}